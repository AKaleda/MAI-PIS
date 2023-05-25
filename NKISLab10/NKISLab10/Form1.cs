//using Microsoft.VisualBasic;
//using NKISLab10;

using System.Data;

namespace NKISLab10
{
    public partial class Form1 : Form
    {
        DB db = new DB("");

        private BindingSource bsReport = new BindingSource();
        public Form1()  // ���������� Form1
        {
            InitializeComponent();

            dgvCredits.AutoGenerateColumns = true; // �������������� �������� ������� � dgvCredits
            dgvCredits.DataSource = bsReport;      // ��������� ������
            showCredits();
        }

        private void dtPicker_ValueChanged(object sender, EventArgs e)
        {
            showCredits();
        }

        private void showCredits()
        {
            string dt0 = dtPicker.Value.ToString().Substring(0, 10);
            string dt = dt0.Substring(6, 4) + "-" +
                dt0.Substring(3, 2) + "-" + dt0.Substring(0, 2);
            //MessageBox.Show(dt);
            DataTable tbl;
            tbl = db.GetTableData(
            "SELECT fio AS `�.�.�.`,SUM(amount) AS `�����` " +
            "FROM creditsinfo WHERE (dt <= '" + dt +
            "') GROUP BY fio ORDER BY fio");   // ������ ��� ������ �� �������� 
            bsReport.DataSource = tbl;

            int vTotal = 0;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                vTotal += Convert.ToInt32(tbl.Rows[i][1].ToString());
            }
            tbTotal.Text = vTotal.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}