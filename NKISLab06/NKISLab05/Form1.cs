//  NKISLab05 Версия 1.01   Выдача курсов валют, установленных ЦБ РФ на текущую дату
//  =====================   Информация получается из Интернета в режиме on-line
//  История версий:
//  1.00 26.03.2023 Каледа А. Начальная разработка
//  1.01 28.03.2023 Каледа А. Некритичные изменения в классе Form1:
//      - Рабочие объекты Dictionary Rates, httpClient, string s c HTTP страницей
//        объявлены Private Static в форме Form1
//      - Функция получения HTTP страницы выделена в отдельную функцию static async Task GetHTTP() 
//        Эта функция - единственная асинхронная функция, завершение которой ожидается по await

using System.Text;          // классы для обеспечения работы с кодировками

namespace NKISLab05         // имя пространства имен проекта
{
    public partial class Form1 : Form       // форма для выдачи курсов валют
    {
        const string K1 = "USD";    // Выделенные валюты, курсы которых показываются в начале формы
        const string K2 = "EUR";    // Определяются пользователем
        const string K3 = "CNY";    // Можно изменить только в программе (здесь)

        static Dictionary<string, List<string>> Rates = 
            new Dictionary<string, List<string>>();  // Dictionary для списка валют
        static HttpClient httpC = 
            new HttpClient();    // экземпляр класса HttpClient для взаимодействия с веб-серверами по http
        static string s = "";    // HTTP страница, перекодированная из Unicode в Windows-1251

        public Form1()                 // Конструктор формы Form1
        {
            InitializeComponent();     // Стандартная инициализация формы
            GetRates();                // Вызов функции-исполнителя для организации получения списка валют и занесения в форму
        }

        private async void GetRates()  // Функция-исполнитель для организации получения списка валют и занесения в форму
        {                              // Определена как async для возможности взаимодействия с async GetHTTP()
            await GetHTTP();                // Получения HTTP страницы с курсами валют и помещение ее в string s
            GetRatesFromHTTP();             // Разбор строки s и заполнение Dictionary Rates
            OutputRates();                  // Занесение информации о валютах в форму Form1
        }

        private async Task GetHTTP()    // Получение HTTP страницы в кодировке Windows-1251
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); // устанавливаем менеджер (провайдер) перекодировок
            Encoding.GetEncoding("Windows-1251");       // Загрузка программы перекодировки из байт в код Windows-1251

            byte[] bs = await httpC.GetByteArrayAsync(     // запуск команды получения HTTP страницы
                "http://www.finmarket.ru/currency/rates/");         // (адрес Web-страницы) и ожидание ответа
            s = System.Text.Encoding.GetEncoding("Windows-1251").GetString(bs); // перекодировка в Windows-1251
        }

        private void GetRatesFromHTTP()  // Разбор строки s и построение Dictionary - списка курсов валют
        {
            string fs11 = "<td class=" + '"' + "fs11" + '"' + '>';  // строка <td class="fs11"> начало блока описания валюты
            int lfs11 = fs11.Length;                                // ее длина

            int i = 0;      // текущий индекс в строке s в процессе разбора HTTP текста
            int i1, i2;     // индексы начала (смещения от i) и длины найденной в s текстовой конструкции
            string K;       // Код валюты

// разбор комментируем на примере <td class="fs11">AUD</td><td><a href="/currency/details/?val=52182"
// >Австралийский доллар</a></td><td>1</td><td>51,5221</td><td class="green">+0,1103</td></tr><tr class="">

            while (i < s.Length - lfs11)    // не доходим до конца строки s на lfs11 символов
            {
                if (s[i] == '<')                            // поиск головного символа <
                    if (s.Substring(i, lfs11) == fs11)          // нашли - проверяем на текст <td class="fs11">
                    {                                           // да - начало блока информации о валюте
                        i += lfs11;                             // пропускаем <td class="fs11">

                        List<string> RTs = new List<string>();  // Список RTs параметров валюты: пустой. Будут добавлены строки
                                                                // Наименование валюты, Кол-во единиц, их цена в Руб
                        K = s.Substring(i, 3).ToUpper();        // извлекаем Код валюты AUD (3 символа)
                        i += 3 + 18;                            // пропускаем AUD</td><td><a href="

                        i1 = s.Substring(i).IndexOf('"');       // поиск следующего ". i1 - смещение от индекса i
                        i += i1 + 2;                            // пропускаем i1 символов + еще 2 "> Установились на Австралийский доллар</a>...
                        i2 = s.Substring(i).IndexOf('<');       // поск очередного символа <  i2 - длина найденного текста
                        RTs.Add(s.Substring(i, i2));            // нашли Наименование валюты - добавляем в список RTs
                        i += i2 + 13;                           // пропускаем Наименование валюты и 13 символов </a></td><td>
                                                                // установились на 1</td><td>51,5221</td>

                        i2 = s.Substring(i).IndexOf('<');       // поск символа <  i2 - длина найденного текста
                        RTs.Add(s.Substring(i, i2).Replace(" ", "")); // нашли Кол-во единиц, убрали пробелы и добавляем в список RTs
                        i += i2 + 9;                            // пропускаем Кол-во единиц и 9 символов </td><td>
                                                                // установились на 51,5221</td>

                        i2 = s.Substring(i).IndexOf('<');       // поск символа <  i2 - длина найденного текста
                        RTs.Add(s.Substring(i, i2));            // нашли Цену в Руб - добавляем цену в список RTs
                        i += i2 + 4;                            // пропускаем Цену в Руб и 4 символа </td
                                                                //      оставшийся символ > будет пропущен при i++;

                        Rates.Add(K, RTs);        // добавляем в Dictionary запись об очередноц валюте
                    }
                i++;  // пропускаем 1 символ 
            }
        }

        private void OutputRates()    // Занесение курсов валют в форму
        {
            string K;                       // Код валюты
            List<string> RTs;               //  Наименование валюты, Кол-во единиц, их цена в Руб

            K = K1.ToUpper(); tbK1.Text = K;                                                    // первая из 3х избранных
            tbV10.Text = Rates.ContainsKey(K) ? Rates[K][0] : " ";                              // наименование валюты
            tbV11.Text = Rates.ContainsKey(K) ? String.Format("{0,8}", Rates[K][1]) : " ";      // кол-во единиц (8 позиций, выравнено вправо)
            tbV12.Text = Rates.ContainsKey(K) ? String.Format("  {0,-12}", Rates[K][2]) : " ";  // их цена в Руб (12 позиций, выравнено влево)

            K = K2.ToUpper(); tbK2.Text = K;                                                    // вторая из 3х избранных
            tbV20.Text = Rates.ContainsKey(K) ? Rates[K][0] : " ";                              // наименование валюты
            tbV21.Text = Rates.ContainsKey(K) ? String.Format("{0,8}", Rates[K][1]) : " ";      // кол-во единиц (8 позиций, выравнено вправо)
            tbV22.Text = Rates.ContainsKey(K) ? String.Format("  {0,-12}", Rates[K][2]) : " ";  // их цена в Руб (12 позиций, выравнено влево)

            K = K3.ToUpper(); tbK3.Text = K;                                                    // третья из 3х избранных
            tbV30.Text = Rates.ContainsKey(K) ? Rates[K][0] : " ";                              // наименование валюты
            tbV31.Text = Rates.ContainsKey(K) ? String.Format("{0,8}", Rates[K][1]) : " ";      // кол-во единиц (8 позиций, выравнено вправо)
            tbV32.Text = Rates.ContainsKey(K) ? String.Format("  {0,-12}", Rates[K][2]) : " ";  // их цена в Руб (12 позиций, выравнено влево)

            foreach (var v in Rates)            
            {
                K = v.Key;              // код валюты
                RTs = v.Value;          // параметры валюты: 
                string[] row = new string[] { K, RTs[0],        // Код, Наименование валюты
                    String.Format("{0,8}", RTs[1]),             // кол-во единиц (8 позиций, выравнено вправо)
                    String.Format("  {0,-12}",RTs[2]) };        // их цена в Руб (12 позиций, выравнено влево)
                dgvR.Rows.Add(row);                             // добавляем строку в DataGridView dgvR - таблицу всех валют      
            }
        }
    }
}