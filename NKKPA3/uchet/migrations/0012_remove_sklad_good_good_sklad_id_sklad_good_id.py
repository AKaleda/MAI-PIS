# Generated by Django 4.2 on 2023-05-21 07:26

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('uchet', '0011_sklad'),
    ]

    operations = [
        migrations.RemoveField(
            model_name='sklad',
            name='good',
        ),
        migrations.AddField(
            model_name='good',
            name='sklad_id',
            field=models.IntegerField(default=0),
        ),
        migrations.AddField(
            model_name='sklad',
            name='good_id',
            field=models.IntegerField(default=0),
        ),
    ]
