//  ���� CASE-������� �������� �������� ��� ���������� ������� y = F_1(F_2(F_3(x)))
//             �� ������ 4-� ������� �������: y=x; y=sqr(x); y=1/x; y=exp(x)

using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace NKISLab11
{
    public partial class Form1 : Form
    {
        static string FCode;            // ������ ��� ��������� ����

        public Form1()
        {
            InitializeComponent();
            FCode = tbFCode.Text;       // ��������� ������
            cbF1.Select();
        }

        private void cbF1_SelectedIndexChanged(object sender, EventArgs e)
        {                               // ������� ������� ��� F_1
            tbFCode.Visible = false;
            lbCopied.Visible = false;
            btGenVBA.Select();
        }

        private void cbF2_SelectedIndexChanged(object sender, EventArgs e)
        {                               // ������� ������� ��� F_2
            tbFCode.Visible = false;
            lbCopied.Visible = false;
            btGenVBA.Select();
        }

        private void cbF3_SelectedIndexChanged(object sender, EventArgs e)
        {                               // ������� ������� ��� F_3
            tbFCode.Visible = false;
            lbCopied.Visible = false;
            btGenVBA.Select();
        }

        private void btGenVBA_Click(object sender, EventArgs e)
        {
            tbFCode.Text = FCode.Replace("###F",
                cbF1.Text + cbF2.Text + cbF3.Text + "))");
            tbFCode.Visible = true;
            tbFCode.Select();
            tbFCode.Copy(); // ����������� ���������������� ���� � ����� ������
            lbCopied.Visible = true;
            cbF1.Select();
        }
    }
}