using System.Text;

namespace NKISLab05
{
    public partial class Form1 : Form
    {
        public Dictionary<string, List<string>> Rates = new Dictionary<string, List<string>>();
        static HttpClient httpClient = new HttpClient();    // класс дл€ взаимодействи€ с веб-серверами по http

        public Form1()                      //  онструктор формы
        {
            InitializeComponent();
            OutputRates();
        }

        private async void OutputRates()    // ¬ывод результатов
        {
            await GetRatesFromHTTP(this);   // «апрос курсов с ожиданием (синхронный режим)

            string K;                       //  од валюты
            List<string> vvs;               // Ќаименование, кол-во единиц, курс

            K = tbK1.Text.ToUpper(); tbK1.Text = K;                 // перва€ из 3х избранных
            tbV10.Text = Rates.ContainsKey(K) ? Rates[K][0] : " ";
            tbV11.Text = Rates.ContainsKey(K) ? String.Format("{0,8}", Rates[K][1]) : " ";
            tbV12.Text = Rates.ContainsKey(K) ? String.Format("  {0,-12}", Rates[K][2]) : " ";

            K = tbK2.Text.ToUpper(); tbK2.Text = K;                 // втора€ из 3х избранных
            tbV20.Text = Rates.ContainsKey(K) ? Rates[K][0] : " ";
            tbV21.Text = Rates.ContainsKey(K) ? String.Format("{0,8}", Rates[K][1]) : " ";
            tbV22.Text = Rates.ContainsKey(K) ? String.Format("  {0,-12}", Rates[K][2]) : " ";

            K = tbK3.Text.ToUpper(); tbK3.Text = K;                 // треть€ из 3х избранных
            tbV30.Text = Rates.ContainsKey(K) ? Rates[K][0] : " ";
            tbV31.Text = Rates.ContainsKey(K) ? String.Format("{0,8}", Rates[K][1]) : " ";
            tbV32.Text = Rates.ContainsKey(K) ? String.Format("  {0,-12}", Rates[K][2]) : " ";

            foreach (var v in Rates)            // dgvR - таблица всех валют
            {
                K = v.Key;
                vvs = v.Value;
                string[] row = new string[] { K, vvs[0],
                    String.Format("{0,8}", vvs[1]), String.Format("  {0,-12}",vvs[2]) };
                dgvR.Rows.Add(row);
            }
        }

        static async Task GetRatesFromHTTP(Form1 f)     // ѕостроение списка курсов валют
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); // устанавливаем менеджер (провайдер) перекодировок
            Encoding.GetEncoding("Windows-1251");       // «агрузка программы перекодировки из байт в код Windows-1251

            byte[] buffer = await httpClient.GetByteArrayAsync(     // запуск команды (адреса веб-страницы) и ожидание ответа
                "http://www.finmarket.ru/currency/rates/");
            string s = System.Text.Encoding.GetEncoding("Windows-1251").GetString(buffer); // результат: HTTP страница

            string hdr1 = "<td class=" + '"' + "fs11" + '"' + '>';  // строка <td class="fs11"> дл€ начала описани€ валюты
            int lhdr1 = hdr1.Length;

            int i = 0;      // текущий индекс в строке HTTP страницы
            int i1, i2;
            string K;       //  од валюты

            while (i < s.Length - lhdr1)
            {
                if (s[i] == '<')
                    // на примере <td class="fs11">AUD</td><td><a href="/currency/details/?val=52182"
                    // >јвстралийский доллар</a></td><td>1</td><td>51,5221</td>
                    // <td class="green">+0,1103</td></tr><tr class="">

                    if (s.Substring(i, lhdr1) == hdr1)
                    {                                           // <td class="fs11">AUD</td>...
                        List<string> RTs = new List<string>();  // —писок параметров валюты

                        K = s.Substring(i + lhdr1, 3);          // нашли  од валюты AUD</td>...
                        i += lhdr1 + 21;                        // пропустили AUD</td><td><a href="

                        i1 = s.Substring(i).IndexOf('"');       // поиск следующего ". i1 - смещение от s[i]
                        i += i1 + 2;                            // s[i] == 'A'
                        i2 = s.Substring(i).IndexOf('<');       // поск '<' в јвстралийский доллар</a>...
                        RTs.Add(s.Substring(i, i2));            // нашли Ќаименование валюты

                        i += i2 + 13;                           // установились на 1</td><td>51,5221</td>
                        i2 = s.Substring(i).IndexOf('<');
                        RTs.Add(s.Substring(i, i2).Replace("†", "")); // нашли  ол-во единиц и убрали пробелы
                        i += i2 + 9;                            // установились на 51,5221</td>

                        i2 = s.Substring(i).IndexOf('<');
                        RTs.Add(s.Substring(i, i2));            // нашли  урс валюты
                        i += i2 + 20;                           // сдвинулись немного вперед

                        f.Rates.Add(K, RTs);        // добавили в Dictionary запись об очередноц валюте
                    }
                i++;        // еще на 1 символ вперед
            }
        }
    }
}