from django.db import models
from django.core.validators import MaxValueValidator, MinValueValidator 
class buyer(models.Model):
    name = models.CharField(max_length=20)
    address = models.CharField(max_length=80)
    phone = models.CharField(max_length=20, default='')
    
class supplier(models.Model):
    name = models.CharField(max_length=20)
    address = models.CharField(max_length=80)
    phone = models.CharField(max_length=20, default='')
    def __str__(self):
        return self.name
    
class tovar(models.Model):
    name = models.CharField(max_length=80)    
    unit = models.CharField(max_length=20)
    state = models.CharField(max_length=80)
    def __str__(self):
        return self.name
    
class order(models.Model):
    buyer = models.ForeignKey(buyer, on_delete = models.CASCADE)
    dt = models.DateField()                 # дата заказа
    vydan = models.IntegerField(default=0)
    
class item(models.Model):
    order = models.ForeignKey(order, on_delete = models.CASCADE)
    supplier = models.ForeignKey(supplier, on_delete = models.CASCADE)
    tovar = models.ForeignKey(tovar, on_delete = models.CASCADE)
    dt = models.DateField() # дата размещения/поступления товара
    qty = models.IntegerField(default=1,
        validators=[MinValueValidator(1)])  # кол-во товаров  
    price = models.IntegerField(default=1,
        validators=[MinValueValidator(1)])
    postupil = models.IntegerField(default=1,
        validators=[MaxValueValidator(1), MinValueValidator(0)])  # 0-нет, 1-да
    oprih = models.IntegerField(default=0,                        # оприходование заказа в goodr
        validators=[MaxValueValidator(1), MinValueValidator(0)])  # 0-нет, 1-да
    
class goodr(models.Model):
    order = models.ForeignKey(order, on_delete = models.CASCADE)
    tovar = models.ForeignKey(tovar, on_delete = models.CASCADE)
    dt = models.DateField() # дата размещения товара
    supplier = models.ForeignKey(supplier, on_delete = models.CASCADE, null=True)
    price = models.IntegerField(default=0)
    skladref = models.IntegerField(default=0)
    
class skladr(models.Model):
    order = models.ForeignKey(order, on_delete = models.CASCADE, null=True)
    tovar = models.ForeignKey(tovar, on_delete = models.CASCADE)
    dt = models.DateField() # дата получения товара
    supplier = models.ForeignKey(supplier, on_delete = models.CASCADE, null=True)
    price = models.IntegerField(default=0)
    goodref = models.IntegerField(default=0)


    
    
