# Generated by Django 4.2 on 2023-05-21 07:29

from django.db import migrations


class Migration(migrations.Migration):

    dependencies = [
        ('uchet', '0012_remove_sklad_good_good_sklad_id_sklad_good_id'),
    ]

    operations = [
        migrations.RemoveField(
            model_name='good',
            name='sklad_id',
        ),
        migrations.RemoveField(
            model_name='sklad',
            name='good_id',
        ),
    ]