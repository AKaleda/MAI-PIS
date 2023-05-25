from django.shortcuts import render
from django.http import HttpResponse
from .models import buyer, item
from django import forms
 
class RegForm(forms.Form):
    z_id = forms.IntegerField(label="Номер заявки")
    
class RegFormDo(forms.Form):
    zr_id = forms.IntegerField(label="Номер заявки", min_value=1)
    tovar = forms.CharField(label="Товар", disabled=True)
    supplier = forms.CharField(label="Поставщик", disabled=True)
    qty = forms.IntegerField(label="Количество", min_value=1)  
    unit = forms.CharField(label="Eдиница измерения", disabled=True)
    price = forms.IntegerField(label="Цена за единицу   (руб)", min_value=1)    
    
def index(request):
# получаем все объекты
    people = buyer.objects.all()
    print(people.query)
    print(people.count())
# получаем объекты с именем Петров
    people = people.filter(name = '"Петров"')
    print(people.query)
# получаем объекты с статусом, равным 0
    people = people.filter(status = 0)
    print(people.query)
    
    s="<h1>Django приветствует Покупателей</h1>"
    people = buyer.objects.all()
    people=people.order_by('name')
    print(people.query)

# здесь происходит выполнения запроса в БД
    for person in people:
        s+=(f"<h2>{person.id}.{person.name} - {person.address}</h2>")
    return HttpResponse(s) 
    
def developer(request):
    return HttpResponse("<h1>Django приветствует Настю Каледа и Катю, и Андрея также  !!!</h1>")
    
def manager(request):
    return render(request, "manager.html")
    
def prihod(request):
# оприходовать
    items = item.objects.raw("SELECT * FROM uchet_neopr")
    for it in items:
        z_id=it.id
        print(z_id, it.namet, it.postupil)
        if (it.postupil==1):
            number = item.objects.filter(id=z_id).update(oprih='1')
            print(number) # количество обновленных строк

# неоприходованные
    items = buyer.objects.raw("SELECT * FROM uchet_neopr")
    data = {"items": items}
    return render(request, "prihod.html", context=data)
    
def tags(request):
    return render(request, "tags.html")
       
def postupili(request):
    if request.method == "POST":
        z_id = request.POST.get("z_id")
        print("z_id: ", z_id)
        price = request.POST.get("price")
        print("price: ", price)
        zr_id = request.POST.get("zr_id")   # None- если пришли из RegForm
        print("zr_id: ", zr_id)
        if (zr_id is None):
            items = buyer.objects.raw("SELECT * FROM uchet_postupili where id = " + z_id)
            print(len(list(items)))
            if (len(list(items))==1):
                uf=RegFormDo(initial={'zr_id':z_id,'tovar':items[0].namet, 'supplier':items[0].name, 
                'qty':items[0].qty, 'unit':items[0].unit, 'price':items[0].price})
                
                return render(request, "registr.html", {"form": uf}) 
        else:   # пришли из RegFormDo 
            print ("From RegFormDo")
            submitbutton= request.POST.get("submit")
            zr2_id=0
            uf=RegFormDo(request.POST or None)
            uf.is_valid()
            zr2_id= uf.cleaned_data.get("zr_id")
            print ("zr2_id from uf: ", zr2_id)
            zr3_id= uf.cleaned_data.get("zr_id")
            print ("zr2_id from uf: ", zr2_id)
            1/0
            
            vqty = request.POST.get("qty")
            vprice = request.POST.get("price")
            number = item.objects.filter(id=zr_id).update(qty=vqty)
            number = item.objects.filter(id=zr_id).update(price=vprice)
            number = item.objects.filter(id=zr_id).update(postupil='1')
        #print(number) # количество обновленных строк
        #endif
    #endif
    items = buyer.objects.raw("SELECT * FROM uchet_postupili")
    userform = RegForm()
    data = {"items": items,"form": userform}
    return render(request, "postupili.html", context=data) 

def doppost(request):
    return render(request, "doppost.html")

