//  NKISLab05 ������ 1.01   ������ ������ �����, ������������� �� �� �� ������� ����
//  =====================   ���������� ���������� �� ��������� � ������ on-line
//  ������� ������:
//  1.00 26.03.2023 ������ �. ��������� ����������
//  1.01 28.03.2023 ������ �. ����������� ��������� � ������ Form1:
//      - ������� ������� Dictionary Rates, httpClient, string s c HTTP ���������
//        ��������� Private Static � ����� Form1
//      - ������� ��������� HTTP �������� �������� � ��������� ������� static async Task GetHTTP() 
//        ��� ������� - ������������ ����������� �������, ���������� ������� ��������� �� await

using System.Text;          // ������ ��� ����������� ������ � �����������

namespace NKISLab05         // ��� ������������ ���� �������
{
    public partial class Form1 : Form       // ����� ��� ������ ������ �����
    {
        const string K1 = "USD";    // ���������� ������, ����� ������� ������������ � ������ �����
        const string K2 = "EUR";    // ������������ �������������
        const string K3 = "CNY";    // ����� �������� ������ � ��������� (�����)

        static Dictionary<string, List<string>> Rates = 
            new Dictionary<string, List<string>>();  // Dictionary ��� ������ �����
        static HttpClient httpC = 
            new HttpClient();    // ��������� ������ HttpClient ��� �������������� � ���-��������� �� http
        static string s = "";    // HTTP ��������, ���������������� �� Unicode � Windows-1251

        public Form1()                 // ����������� ����� Form1
        {
            InitializeComponent();     // ����������� ������������� �����
            GetRates();                // ����� �������-����������� ��� ����������� ��������� ������ ����� � ��������� � �����
        }

        private async void GetRates()  // �������-����������� ��� ����������� ��������� ������ ����� � ��������� � �����
        {                              // ���������� ��� async ��� ����������� �������������� � async GetHTTP()
            await GetHTTP();                // ��������� HTTP �������� � ������� ����� � ��������� �� � string s
            GetRatesFromHTTP();             // ������ ������ s � ���������� Dictionary Rates
            OutputRates();                  // ��������� ���������� � ������� � ����� Form1
        }

        private async Task GetHTTP()    // ��������� HTTP �������� � ��������� Windows-1251
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); // ������������� �������� (���������) �������������
            Encoding.GetEncoding("Windows-1251");       // �������� ��������� ������������� �� ���� � ��� Windows-1251

            byte[] bs = await httpC.GetByteArrayAsync(     // ������ ������� ��������� HTTP ��������
                "http://www.finmarket.ru/currency/rates/");         // (����� Web-��������) � �������� ������
            s = System.Text.Encoding.GetEncoding("Windows-1251").GetString(bs); // ������������� � Windows-1251
        }

        private void GetRatesFromHTTP()  // ������ ������ s � ���������� Dictionary - ������ ������ �����
        {
            string fs11 = "<td class=" + '"' + "fs11" + '"' + '>';  // ������ <td class="fs11"> ������ ����� �������� ������
            int lfs11 = fs11.Length;                                // �� �����

            int i = 0;      // ������� ������ � ������ s � �������� ������� HTTP ������
            int i1, i2;     // ������� ������ (�������� �� i) � ����� ��������� � s ��������� �����������
            string K;       // ��� ������

// ������ ������������ �� ������� <td class="fs11">AUD</td><td><a href="/currency/details/?val=52182"
// >������������� ������</a></td><td>1</td><td>51,5221</td><td class="green">+0,1103</td></tr><tr class="">

            while (i < s.Length - lfs11)    // �� ������� �� ����� ������ s �� lfs11 ��������
            {
                if (s[i] == '<')                            // ����� ��������� ������� <
                    if (s.Substring(i, lfs11) == fs11)          // ����� - ��������� �� ����� <td class="fs11">
                    {                                           // �� - ������ ����� ���������� � ������
                        i += lfs11;                             // ���������� <td class="fs11">

                        List<string> RTs = new List<string>();  // ������ RTs ���������� ������: ������. ����� ��������� ������
                                                                // ������������ ������, ���-�� ������, �� ���� � ���
                        K = s.Substring(i, 3).ToUpper();        // ��������� ��� ������ AUD (3 �������)
                        i += 3 + 18;                            // ���������� AUD</td><td><a href="

                        i1 = s.Substring(i).IndexOf('"');       // ����� ���������� ". i1 - �������� �� ������� i
                        i += i1 + 2;                            // ���������� i1 �������� + ��� 2 "> ������������ �� ������������� ������</a>...
                        i2 = s.Substring(i).IndexOf('<');       // ���� ���������� ������� <  i2 - ����� ���������� ������
                        RTs.Add(s.Substring(i, i2));            // ����� ������������ ������ - ��������� � ������ RTs
                        i += i2 + 13;                           // ���������� ������������ ������ � 13 �������� </a></td><td>
                                                                // ������������ �� 1</td><td>51,5221</td>

                        i2 = s.Substring(i).IndexOf('<');       // ���� ������� <  i2 - ����� ���������� ������
                        RTs.Add(s.Substring(i, i2).Replace("�", "")); // ����� ���-�� ������, ������ ������� � ��������� � ������ RTs
                        i += i2 + 9;                            // ���������� ���-�� ������ � 9 �������� </td><td>
                                                                // ������������ �� 51,5221</td>

                        i2 = s.Substring(i).IndexOf('<');       // ���� ������� <  i2 - ����� ���������� ������
                        RTs.Add(s.Substring(i, i2));            // ����� ���� � ��� - ��������� ���� � ������ RTs
                        i += i2 + 4;                            // ���������� ���� � ��� � 4 ������� </td
                                                                //      ���������� ������ > ����� �������� ��� i++;

                        Rates.Add(K, RTs);        // ��������� � Dictionary ������ �� ��������� ������
                    }
                i++;  // ���������� 1 ������ 
            }
        }

        private void OutputRates()    // ��������� ������ ����� � �����
        {
            string K;                       // ��� ������
            List<string> RTs;               //  ������������ ������, ���-�� ������, �� ���� � ���

            K = K1.ToUpper(); tbK1.Text = K;                                                    // ������ �� 3� ���������
            tbV10.Text = Rates.ContainsKey(K) ? Rates[K][0] : " ";                              // ������������ ������
            tbV11.Text = Rates.ContainsKey(K) ? String.Format("{0,8}", Rates[K][1]) : " ";      // ���-�� ������ (8 �������, ��������� ������)
            tbV12.Text = Rates.ContainsKey(K) ? String.Format("  {0,-12}", Rates[K][2]) : " ";  // �� ���� � ��� (12 �������, ��������� �����)

            K = K2.ToUpper(); tbK2.Text = K;                                                    // ������ �� 3� ���������
            tbV20.Text = Rates.ContainsKey(K) ? Rates[K][0] : " ";                              // ������������ ������
            tbV21.Text = Rates.ContainsKey(K) ? String.Format("{0,8}", Rates[K][1]) : " ";      // ���-�� ������ (8 �������, ��������� ������)
            tbV22.Text = Rates.ContainsKey(K) ? String.Format("  {0,-12}", Rates[K][2]) : " ";  // �� ���� � ��� (12 �������, ��������� �����)

            K = K3.ToUpper(); tbK3.Text = K;                                                    // ������ �� 3� ���������
            tbV30.Text = Rates.ContainsKey(K) ? Rates[K][0] : " ";                              // ������������ ������
            tbV31.Text = Rates.ContainsKey(K) ? String.Format("{0,8}", Rates[K][1]) : " ";      // ���-�� ������ (8 �������, ��������� ������)
            tbV32.Text = Rates.ContainsKey(K) ? String.Format("  {0,-12}", Rates[K][2]) : " ";  // �� ���� � ��� (12 �������, ��������� �����)

            foreach (var v in Rates)            
            {
                K = v.Key;              // ��� ������
                RTs = v.Value;          // ��������� ������: 
                string[] row = new string[] { K, RTs[0],        // ���, ������������ ������
                    String.Format("{0,8}", RTs[1]),             // ���-�� ������ (8 �������, ��������� ������)
                    String.Format("  {0,-12}",RTs[2]) };        // �� ���� � ��� (12 �������, ��������� �����)
                dgvR.Rows.Add(row);                             // ��������� ������ � DataGridView dgvR - ������� ���� �����      
            }
        }
    }
}