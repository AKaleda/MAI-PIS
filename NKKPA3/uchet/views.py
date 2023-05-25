from django.shortcuts import render
from django.http import HttpResponse,HttpResponseRedirect
from .models import buyer, item, tovar, supplier, order, goodr, skladr
from django import forms
from django.forms import ModelForm
from datetime import datetime
import calculation

class RegForm(forms.Form):
    z_id = forms.IntegerField(label="Номер поставки", min_value=1)

class RegFormDo(forms.Form):
    zr_id = forms.IntegerField(label="Номер поставки", min_value=1, disabled=True)
    tovar = forms.CharField(label="Товар", disabled=True)
    supplier = forms.CharField(label="Поставщик", disabled=True)
    qty = forms.IntegerField(label="Количество", min_value=1)  
    price = forms.IntegerField(label="Цена за единицу (руб)", min_value=1)    
    amount = forms.IntegerField(label="Стоимость (руб)", disabled=True, required=False, 
        widget=calculation.FormulaInput('qty*price'))
       
class NewFormDo(ModelForm):
    tovar = forms.ModelChoiceField(tovar.objects.order_by('name'), label = 'Товар')
    supplier = forms.ModelChoiceField(supplier.objects.order_by('name'), label = 'Поставщик')
    qty = forms.IntegerField(label="Количество", min_value=1)  
    price = forms.IntegerField(label="Цена за единицу (руб)", min_value=1)    
    amount = forms.IntegerField(label="Стоимость (руб)", disabled=True, required=False, 
        widget=calculation.FormulaInput('qty*price'))
    def __init__(self, *args, **kwargs):    # перегрузка конструктора
        super().__init__(*args, **kwargs)   # вызов конструктора класса, от которого наследуемся
        self.fields['tovar'].empty_label = '-Выберите товар-' # self - ссылка на создаваемый экземпляр класса
        self.fields['supplier'].empty_label = '-Выберите поставщика-'
    class Meta:
        model = item
        fields = ('tovar', 'qty', 'price', 'supplier', 'postupil')
        labels = {'tovar':'Товар', 'qty':'Количество', 'price':'Цена за единицу', 
        'supplier':'Поставщик', 'postupil':'Товар поставлен?'}
    
def zakazy(request):
    items = item.objects.raw("SELECT * FROM uchet_zakazy")
    data = {"what":"Все заказы","items": items}
    return render(request, "status_all.html", context=data) 
    
def zakazyopen(request):
    items = item.objects.raw("SELECT * FROM uchet_zakazyopen")
    data = {"what":"Не выполненные заказы","items": items}
    return render(request, "status_all.html", context=data) 
    
def zakazyclosed(request):
    items = item.objects.raw("SELECT * FROM uchet_cost")
    data = {"what":"Выполненные заказы","items": items}
    return render(request, "status_closed.html", context=data) 
    
def zakazycosts(request):
    items = item.objects.raw("SELECT * FROM uchet_zakazycosts order by br, id")
    data = {"what":"Не выданные заказы","items": items}
    return render(request, "zakazycosts.html", context=data) 
    
def manager(request):
    items = item.objects.filter(oprih=0).order_by('id')
    for it in items:
        itid=it.id
        it_order=it.order
        qty = it.qty
        dti=it.dt
        tovar=it.tovar
        print("manager init",itid, it_order, qty, tovar, dti)
        for k in range(int(qty)):
            gd = goodr.objects.create( tovar=it.tovar, dt=dti, order=it.order)
            print("gd.id",gd.id)
        number = item.objects.filter(id=itid).update(oprih=1)  # признак, что goodr создан
        print("number",number)

    return render(request, "manager.html")
    
def prihod(request):
# оприходовать
    gds = goodr.objects.filter(skladref=0).order_by('id')
    for gd in gds:
        gdtovar=gd.tovar
        print("gds:", gd.id, gd.order, gdtovar)
        skls = skladr.objects.filter(goodref=0, tovar=gdtovar).order_by('id')
        for skl in skls:
            print("skls:", skl.id, skl.supplier, skl.tovar)
            if (gdtovar == skl.tovar):
                print("==tovar== ")
                number = skladr.objects.filter(id=skl.id).update(goodref=gd.id)
                number = goodr.objects.filter(id=gd.id).update(skladref=skl.id)
                number = goodr.objects.filter(id=gd.id).update(price=skl.price)
                number = goodr.objects.filter(id=gd.id).update(supplier=skl.supplier)
                break
        # end for
    # next gd

# неоприходованные
    items = buyer.objects.raw("SELECT * FROM uchet_neopr")
    data = {"items": items}
    return render(request, "prihod.html", context=data)
    
def tags(request):
    items = item.objects.raw("SELECT * FROM uchet_tags;")
    s='<!DOCTYPE html> <html>'
    s+='<head> <title>Автомагазин</title> <meta charset="utf-8" /> </head>'
    s+='<table class=MsoTableGrid border=1 cellspacing=1 cellpadding=4 > '
    
    ntd=0
    for it in items:
        if ntd==0:
            s+='<tr>'

        s+='<td width=400 align="left" >  <p>'
        s+=(f'<p>N:{it.id} Товар:{it.tname}  Цена за {it.unit}: {it.price}р.</p>')
        s+=(f"<p>Страна: {it.state}</p>")
        s+=(f"<p>Поставщик: {it.sname}</p>")
        today=datetime.today().strftime('%d.%m.%Y')
        s+=(f"<p>Дата: {today}</p><p>Подпись и печать:___________________________</p> ")
        s+='</td>'
        
        if ntd==1:
            ntd=0
            s+='</tr>'
        else:
            ntd+=1
    if ntd==1:
        s+='</tr>'
   
    s+='</table>'
    s+='</html>'
    return HttpResponse(s)
       
def registr(request,n):
    if request.method == "POST":
        vqty = request.POST.get("qty")
        vprice = request.POST.get("price")
        #number = item.objects.filter(id=n).update(qty=vqty)
        #number = item.objects.filter(id=n).update(price=vprice)
        number = item.objects.filter(id=n).update(postupil='1')
        print("NNN: ", n,vqty,vprice)
        
        it = item.objects.get(id=n) 
        it_order = it.order_id
        print(it.id, it.qty, it.price, it.dt, it_order, it.supplier, it.tovar)
        for k in range(int(vqty)):
            skl = skladr.objects.create( tovar=it.tovar, dt=datetime.now(), 
            supplier=it.supplier, price=vprice, goodref=0)  
            print("skl.id",skl.id)
            if (not(it_order is None)):
                number = skladr.objects.filter(id=skl.id).update(order=it.order)

    items = buyer.objects.raw("SELECT * FROM uchet_postupili")
    userform = RegForm()
    data = {"items": items,"form": userform}
    return render(request, "postupili.html", context=data) 

def postupili(request):
    if request.method == "POST":
        z_id = request.POST.get("z_id")     ; print("z_id: ", z_id)
        items = buyer.objects.raw("SELECT * FROM uchet_postupili where id = " + z_id)
        print("len(list(items))",len(list(items)))
        if (len(list(items))==1):
            uf=RegFormDo(initial={'zr_id':z_id,'tovar':items[0].namet, 'supplier':items[0].name, 
            'qty':items[0].qty, 'price':items[0].price, 'amount':items[0].qty*items[0].price})            
            data = {"zrid":z_id,"form": uf}             
            return render(request, "registr.html", context=data) 
    
    items = buyer.objects.raw("SELECT * FROM uchet_postupili")

    uf = RegForm()
    data = {"items": items,"form": uf}
    return render(request, "postupili.html", context=data) 
    
def doppost(request):
    if request.method == "POST":
        uf=NewFormDo(request.POST)
        if uf.is_valid():
            qty=int(request.POST.get("qty"))
            price=int(request.POST.get("price"))
            postupil=int(request.POST.get("postupil"))
            print("uf.qty",qty, "uf.price",price, "uf.postupil",postupil)
            if (qty>0 and price>0):
                zz_id=uf.save()         ; print('zz_id of uf.save=', zz_id.id)
                number = item.objects.filter(id=zz_id.id).update(dt=datetime.now())  ; print(number)  
                number = item.objects.filter(id=zz_id.id).update(oprih=1)  # goodr создаваться не должен
                if postupil==1:
                    it = item.objects.get(id=zz_id.id) 
                    print(it.id, it.qty, it.price, it.dt, it.supplier, it.tovar)
                    for k in range(int(qty)):
                        skl = skladr.objects.create(tovar=it.tovar, dt=datetime.now(), 
                        supplier=it.supplier, price=it.price, goodref=0)  
                        print("skl.id",skl.id)
                
                return HttpResponseRedirect("/manager/postupili/")
        else:
            print ("NOT uf.is_valid")
    else:
        uf=NewFormDo(initial={'postupil':0,'qty':1,'price':1,'amount':1})
        
    data = {"form": uf}
    return render(request, "doppost.html", context=data) 

