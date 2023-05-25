using System;
using System.IO;

var months = new Dictionary<string, string>()
{ {"JAN","01"},{"FEB","02"},{"MAR","03"},{"APR","04"},{"MAY","05"},{"JUN","06"},
  {"JUL","07"},{"AUG","08"},{"SEP","09"},{"OCT","10"},{"NOV","11"},{"DEC","12"} };

// код, номер выходного столбца(1,2,...), наименование, тип (D,T,S,I,F),
// точность (к-во цифр после .), 1 - передается в файл обмена
string[,] Codes = { { "DT", "1", "Дата",     "D",  "", "1" }   
                   ,{ "UD", "2", "Курс Евро","F", "5", "1" } 
                   ,{ "TM", "3", "Время",    "T",  "", "0" }
                    };
int jDT=0;
int jUD=1;

String pname = Path.GetFullPath(@"../../../../") ;  // Mac, Win - папка на предыдущем уровне
string s;

StreamReader sr;
try                                                 // Открыть текстовый файл для чтения
{
    sr = new StreamReader(pname + "EuroToUSD_2022.txt");
}
catch (FileNotFoundException e)
{
    Console.WriteLine("Ошибка: {0}", e.Message);
    // Если попытка открыть файл неудачная
    return;
}

s = sr.ReadLine();                      // прочитать строку с заголовками и пропустить
if (s == null)
{
    Console.WriteLine("Ошибка: Файл не содержит записей");
    return;
}

StreamWriter sw = new StreamWriter(pname + "NKISLab03D.csv");  // файл для обмена данными - тип CSV

int nVals = 0;                      // количество выводимых столбцов
int nVal;                           // текущий столбец

for (int j = 0; j <= Codes.GetUpperBound(0); j++)
{
    if (Codes[j, 5] != "1") continue;           // этот столбец не передается в файл
    nVal = Convert.ToInt32(Codes[j, 1]);
    if (nVal > nVals) nVals = nVal;             // больший номер столбца увеличивает кол-во стобцов
    if (Codes[j, 0] == "DT") jDT = nVal - 1;    // индекс столбца с датой
    if (Codes[j, 0] == "UD") jUD = nVal - 1;    // индекс столбца с курсом в USD
}

string[] vv = new String[nVals];                        
for (int j = 0; j < nVals; j++) vv[j] = "";     // очищаем значения во всех столбцах

string hdr ="";                                 // Заголовок
for (int j = 0; j <= Codes.GetUpperBound(0); j++)
{
    nVal = Convert.ToInt32(Codes[j, 1]);        // номер выходного столбца
    //if (Codes[j, 5] == "1") vv[nVal-1] = Codes[j, 3] + '|' + Codes[j, 0] + '|' + Codes[j, 2];
    if (Codes[j, 5] == "1") vv[nVal-1] =  Codes[j, 2];
}
for (int j = 0; j < nVals; j++)
{
    if (hdr != "") hdr += ';';
    hdr = hdr + vv[j];
}
sw.WriteLine(hdr);               // вывод заголовка

string[] vvs;                   // массив разобранной строки
int k;                    
double dl, dls;

s = sr.ReadLine();              // Прочитать 1-ю строку с данными
while (s != null)               // еще не конец файла 
{
    //Console.WriteLine(s);
    vvs = s.Split();            // массив всех полей данных входного файла
    k = -1;                     // -1 - признак столбца с датой
    dls = 0;                    // сумма курсов со всех бирж
    foreach (string v in vvs)   // v - текущее поле
    {
        if (k == -1)
        {                       // Jan-03-2022 -> 03.01.2022
            vv[jDT] = v.Substring(4,2)+'.'+ months[v.Substring(0, 3).ToUpper()] + '.' + v.Substring(7,4); 
            k=0; 
            continue;           // к следующему полю
        }
        dl = 0;         // курс с текущей биржи
        try
        {
            dl = Convert.ToDouble(v);
        }
        catch (Exception e)
        {
            continue;           // не число
        }
        dls += dl;
        k++;
    }
    vv[jUD] = Math.Round(dls / k, 5).ToString();    // среднее по биржам, 5 цифр после запятой

    s = "";
    for (int j = 0; j < nVals; j++)     // по всем столбцам
    {
        if (s != "") s += ';';          // добавляем разделитель от предыдущего значения
        s = s + vv[j];
    }
    sw.WriteLine(s);               // вывод строки данных

    s = sr.ReadLine();          // Прочитать следующую строку
}
sr.Close();
sw.Close();

Console.Write("Данные переданы. Нажмите любую клавишу чтобы выйти из программы");
Console.ReadKey();
