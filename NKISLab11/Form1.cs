//  Мини CASE-система создания программ для реализации функций y = F_1(F_2(F_3(x)))
//             из набора 4-х базовых функций: y=x; y=sqr(x); y=1/x; y=exp(x)

using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace NKISLab11
{
    public partial class Form1 : Form
    {
        static string FCode;            // шаблон для генерации кода

        public Form1()
        {
            InitializeComponent();
            FCode = tbFCode.Text;       // сохранить шаблон
            cbF1.Select();
        }

        private void cbF1_SelectedIndexChanged(object sender, EventArgs e)
        {                               // выбрали функцию для F_1
            tbFCode.Visible = false;
            lbCopied.Visible = false;
            btGenVBA.Select();
        }

        private void cbF2_SelectedIndexChanged(object sender, EventArgs e)
        {                               // выбрали функцию для F_2
            tbFCode.Visible = false;
            lbCopied.Visible = false;
            btGenVBA.Select();
        }

        private void cbF3_SelectedIndexChanged(object sender, EventArgs e)
        {                               // выбрали функцию для F_3
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
            tbFCode.Copy(); // копирование сгенерированного кода в буфер обмена
            lbCopied.Visible = true;
            cbF1.Select();
        }
    }
}