from django.contrib import admin
from django.urls import path
from uchet import views

urlpatterns = [
    path('', views.zakazy, name='zakazy'),
    path('zakazyopen/', views.zakazyopen, name='zakazyopen'),
    path('zakazyclosed/', views.zakazyclosed, name='zakazyclosed'),
    path('zakazycosts/', views.zakazycosts, name='zakazycosts'),
    path('manager/', views.manager, name='manager'),
    path('manager/postupili/', views.postupili, name='postupili'),
    path('manager/registr/<int:n>', views.registr),
    path('manager/prihod/', views.prihod, name='prihod'),
    path('manager/tags/', views.tags, name='tags'),
    path('manager/doppost/', views.doppost, name='doppost'),
    
]
