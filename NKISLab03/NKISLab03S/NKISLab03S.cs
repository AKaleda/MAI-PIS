using System;
using System.IO;                // stream Read/Write

using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;  // ссылка для использования
using System.Diagnostics;

namespace XLSWrite
{
    class Excel
    {

        string fFullName = "";
        _Application excel = new _Excel.Application();      // запустить внутренее приложение Exсel для поддержки OLE
        Workbook wb;
        Worksheet ws;

        public Excel(string fFullName, object Sheet)            // конструктор по файлу и имени(или номеру) листа
        {                                                   // + окрытие Excel файла в режиме OLE
            this.fFullName = fFullName;
            wb = excel.Workbooks.Open(fFullName);           // открыть книгу
            ws = wb.Worksheets[Sheet];                      // настроить указатель на лист
        }

        public string ReadFromCell(int i, int j)            // ReadFromCell - чтение значения из ячейки
        {
            string str = "";
            if (ws.Cells[i, j].Value != null)
                str = Convert.ToString(ws.Cells[i, j].Value);
            return str;
        }

        public void WriteToCell(int i, int j, object s)     // WriteToCell - запись значения в ячейку
        {
            ws.Cells[i, j].Value = s;
        }

        public void ClearCol(int j)
        {
            ws.Columns[j].ClearContents();                  // ClearCol - очистка столбца
        }

        public void Save()                                  // Save - сохранение файла
        {
            wb.Save();
        }

        public void Close()                                 // Close - закрытие файла
        {
            wb.Close();
        }

        static void Main(string[] args)
        {
            String pname = Path.GetFullPath(@"../../../../");  // Mac, Win - папка на предыдущем уровне

            StreamReader sr;
            try       // Открыть текстовый файл для чтения
            {
                sr = new StreamReader(pname + "NKISLab03D.csv");
            }
            catch (FileNotFoundException e)
            {                                // Если попытка открыть файл неудачная
                Console.WriteLine("Ошибка: {0}", e.Message);
                return;
            }

            Console.WriteLine("Ввод данных из файла обмена в формате CSV ...");

            Excel excel = new Excel(pname + "NKISLab03R.xlsx", "Data");  // открыть xlsx файл для занесения данных
            excel.ClearCol(1);
            excel.ClearCol(2);

            string s;
            int i = 1;              // номер строки в файле Excel
            double dd;

            s = sr.ReadLine();      // прочитать строку с названиями столбцов
            if (s == null)
            {
                Console.WriteLine("Ошибка: Файл не содержит записей");
                return;
            }
            string[] hdr = s.Split(";");
            excel.WriteToCell(i, 1, hdr[0]);
            excel.WriteToCell(i, 2, hdr[1]);
            i++;

            s = sr.ReadLine();    // Прочитать 1-ю строку с данными
            string[] v;

            Console.WriteLine("Загрузка данных через интерфейс OLE в файл Excel ...");

            while (s != null) // конец файла  => значение null
            {
                //Console.WriteLine(s);
                v = s.Split(";");
                //Console.WriteLine(DateTime.Parse(v[0]).ToOADate()); 
                excel.WriteToCell(i, 1, (DateTime.Parse(v[0]).ToOADate() ));
                // DateTime.Parse(v[0]) разбор строки v[0] и преобразование во внутренний формат DateTime
                // .ToOADate() - преобразование даты в кол-во дней от 01.01.1900 + 1

                dd = Convert.ToDouble(v[1]);
                excel.WriteToCell(i, 2, dd);
                i++;
                s = sr.ReadLine();    // Прочитать следующую строку
            }
            sr.Close();

            excel.excel.DisplayAlerts = false;
            try
            {
                excel.Save();
            }
            catch (Exception e)   // перехватить ошибку
            {
                Console.WriteLine("Ошибка: {0}", e.Message); // обработать ее
            }

            excel.Close();
            Console.Write("Данные загружены в Excel. Старт Excel ...");

            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE"; // @ -  в юникод
            psi.Arguments = @"/x " + pname + "NKISLab03R.xlsx"; // @ -  в юникод
            var p = new Process();
            p.StartInfo = psi;
            p.Start();
            p.WaitForExit();

            Console.Write("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}


