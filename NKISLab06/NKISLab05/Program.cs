//  NKISLab05 ������ 1.01   ������ ������ �����, ������������� �� �� �� ������� ����
//  =====================   ���������� ���������� �� ��������� � ������ on-line
//  ������� ������:
//  1.00 26.03.2023 ������ �. ��������� ����������
//  1.01 28.03.2023 ������ �. ����������� ��������� � ������ Form1:
//      - ������� ������� Dictionary Rates, httpClient, string s c HTTP ���������
//        ��������� Private Static � ����� Form1
//      - ������� ��������� HTTP �������� �������� � ��������� ������� static async Task GetHTTP() 
//        ��� ������� - ������������ ����������� �������, ���������� ������� ��������� �� await

namespace NKISLab05
{
    class Program
    {
        [STAThread]
        static void Main()                          // ������� ��������� Main()
        {
            ApplicationConfiguration.Initialize();  // ������������� ����� ����������
            Application.Run(new Form1());           // �������� ���������� Form1 � ��� ������
        }
    }
}