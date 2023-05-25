# Generated by Django 4.2 on 2023-05-21 07:55

from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    dependencies = [
        ('uchet', '0020_sklad_good'),
    ]

    operations = [
        migrations.CreateModel(
            name='goodr',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('dt', models.DateField()),
                ('price', models.IntegerField(default=0)),
                ('skladref', models.IntegerField(default=0)),
                ('order', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='uchet.order')),
                ('supplier', models.ForeignKey(null=True, on_delete=django.db.models.deletion.CASCADE, to='uchet.supplier')),
                ('tovar', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='uchet.tovar')),
            ],
        ),
        migrations.CreateModel(
            name='skladr',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('dt', models.DateField()),
                ('price', models.IntegerField(default=0)),
                ('goodref', models.IntegerField(default=0)),
                ('order', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='uchet.order')),
                ('supplier', models.ForeignKey(null=True, on_delete=django.db.models.deletion.CASCADE, to='uchet.supplier')),
                ('tovar', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='uchet.tovar')),
            ],
        ),
        migrations.RemoveField(
            model_name='sklad',
            name='order',
        ),
        migrations.RemoveField(
            model_name='sklad',
            name='supplier',
        ),
        migrations.RemoveField(
            model_name='sklad',
            name='tovar',
        ),
        migrations.DeleteModel(
            name='good',
        ),
        migrations.DeleteModel(
            name='sklad',
        ),
    ]
