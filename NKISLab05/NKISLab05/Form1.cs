using System.Text;

namespace NKISLab05
{
    public partial class Form1 : Form
    {
        public Dictionary<string, List<string>> Rates = new Dictionary<string, List<string>>();
        static HttpClient httpClient = new HttpClient();    // ����� ��� �������������� � ���-��������� �� http

        public Form1()                      // ����������� �����
        {
            InitializeComponent();
            OutputRates();
        }

        private async void OutputRates()    // ����� �����������
        {
            await GetRatesFromHTTP(this);   // ������ ������ � ��������� (���������� �����)

            string K;                       // ��� ������
            List<string> vvs;               // ������������, ���-�� ������, ����

            K = tbK1.Text.ToUpper(); tbK1.Text = K;                 // ������ �� 3� ���������
            tbV10.Text = Rates.ContainsKey(K) ? Rates[K][0] : " ";
            tbV11.Text = Rates.ContainsKey(K) ? String.Format("{0,8}", Rates[K][1]) : " ";
            tbV12.Text = Rates.ContainsKey(K) ? String.Format("  {0,-12}", Rates[K][2]) : " ";

            K = tbK2.Text.ToUpper(); tbK2.Text = K;                 // ������ �� 3� ���������
            tbV20.Text = Rates.ContainsKey(K) ? Rates[K][0] : " ";
            tbV21.Text = Rates.ContainsKey(K) ? String.Format("{0,8}", Rates[K][1]) : " ";
            tbV22.Text = Rates.ContainsKey(K) ? String.Format("  {0,-12}", Rates[K][2]) : " ";

            K = tbK3.Text.ToUpper(); tbK3.Text = K;                 // ������ �� 3� ���������
            tbV30.Text = Rates.ContainsKey(K) ? Rates[K][0] : " ";
            tbV31.Text = Rates.ContainsKey(K) ? String.Format("{0,8}", Rates[K][1]) : " ";
            tbV32.Text = Rates.ContainsKey(K) ? String.Format("  {0,-12}", Rates[K][2]) : " ";

            foreach (var v in Rates)            // dgvR - ������� ���� �����
            {
                K = v.Key;
                vvs = v.Value;
                string[] row = new string[] { K, vvs[0],
                    String.Format("{0,8}", vvs[1]), String.Format("  {0,-12}",vvs[2]) };
                dgvR.Rows.Add(row);
            }
        }

        static async Task GetRatesFromHTTP(Form1 f)     // ���������� ������ ������ �����
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); // ������������� �������� (���������) �������������
            Encoding.GetEncoding("Windows-1251");       // �������� ��������� ������������� �� ���� � ��� Windows-1251

            byte[] buffer = await httpClient.GetByteArrayAsync(     // ������ ������� (������ ���-��������) � �������� ������
                "http://www.finmarket.ru/currency/rates/");
            string s = System.Text.Encoding.GetEncoding("Windows-1251").GetString(buffer); // ���������: HTTP ��������

            string hdr1 = "<td class=" + '"' + "fs11" + '"' + '>';  // ������ <td class="fs11"> ��� ������ �������� ������
            int lhdr1 = hdr1.Length;

            int i = 0;      // ������� ������ � ������ HTTP ��������
            int i1, i2;
            string K;       // ��� ������

            while (i < s.Length - lhdr1)
            {
                if (s[i] == '<')
                    // �� ������� <td class="fs11">AUD</td><td><a href="/currency/details/?val=52182"
                    // >������������� ������</a></td><td>1</td><td>51,5221</td>
                    // <td class="green">+0,1103</td></tr><tr class="">

                    if (s.Substring(i, lhdr1) == hdr1)
                    {                                           // <td class="fs11">AUD</td>...
                        List<string> RTs = new List<string>();  // ������ ���������� ������

                        K = s.Substring(i + lhdr1, 3);          // ����� ��� ������ AUD</td>...
                        i += lhdr1 + 21;                        // ���������� AUD</td><td><a href="

                        i1 = s.Substring(i).IndexOf('"');       // ����� ���������� ". i1 - �������� �� s[i]
                        i += i1 + 2;                            // s[i] == 'A'
                        i2 = s.Substring(i).IndexOf('<');       // ���� '<' � ������������� ������</a>...
                        RTs.Add(s.Substring(i, i2));            // ����� ������������ ������

                        i += i2 + 13;                           // ������������ �� 1</td><td>51,5221</td>
                        i2 = s.Substring(i).IndexOf('<');
                        RTs.Add(s.Substring(i, i2).Replace("�", "")); // ����� ���-�� ������ � ������ �������
                        i += i2 + 9;                            // ������������ �� 51,5221</td>

                        i2 = s.Substring(i).IndexOf('<');
                        RTs.Add(s.Substring(i, i2));            // ����� ���� ������
                        i += i2 + 20;                           // ���������� ������� ������

                        f.Rates.Add(K, RTs);        // �������� � Dictionary ������ �� ��������� ������
                    }
                i++;        // ��� �� 1 ������ ������
            }
        }
    }
}