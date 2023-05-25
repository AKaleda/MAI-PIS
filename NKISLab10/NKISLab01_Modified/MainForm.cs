using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Media;
using Microsoft.Office.Interop.Excel;
using MySqlX.XDevAPI;

namespace NKISLab01
{
    public partial class MainForm : Form
    {
        DB db = new DB("");
        private BindingSource bsClientData = new BindingSource();
        private BindingSource bsOrdersData = new BindingSource();

        private static String clientName = "";
        private static String clientID = "";
        private static int clientCredit = 0;    // ��� �������� ������ ��� ������ �������� ������
        private static int clientMoney = 0;     //
        private static int clientDolg = 0;      //
        private static int VidProdazi = 1;
        private static String orderID = "";     // ����� �������� ������
        private static int rowIndex = -1;
        private static int orderC = 0;      // ����������� ��������� �������� ������
        private static int returnC = 0;      // ����������� ��������� �������� ��������

        private static Process? p_excel = null;    // ? - ��������� �������� NULL

        public MainForm()                           // ����������� ������ MainForm
        {
            InitializeComponent();

            dgvClientData.AutoGenerateColumns = true;           // ������������� dgvClientData
            dgvClientsUpdate("");
            dgvClientData.DataSource = bsClientData;

            dgvClientOrders.AutoGenerateColumns = true;         // ������������� dgvClientOrders
            dgvOrdersUpdate("");
            dgvClientOrders.DataSource = bsOrdersData;
            dgvClientOrders.Visible = true;

            System.Data.DataTable clients = db.GetTableData(
                "SELECT Client from clients order by Client");  // ������ ��� ������ ������� 
            for (int i = 0; i < clients.Rows.Count; i++)
                cbClientSelected.Items.Add(clients.Rows[i][0].ToString());
            cbClientSelected.SelectedIndex = 0;

            System.Data.DataTable goods = db.GetTableData(
                "SELECT Good from goods order by Good");        // ������ ��� ������ ������ 
            for (int i = 0; i < goods.Rows.Count; i++)
            {
                cbOrderGood.Items.Add(goods.Rows[i][0].ToString());
                cbReturnGood.Items.Add(goods.Rows[i][0].ToString());
            }
        }

        private void dgvClientsUpdate(String clientName)        // dgvClientsUpdate
        {
            bsClientData.DataSource = db.GetTableData(
                "Select * from clients_info where ������ = " +
                (clientName == "" ? "null" : "'" + clientName + "'"));
            if (clientName == "") return;

            int cCredit, cDolg;

            System.Data.DataTable clients = db.GetTableData(
                "SELECT credit, dolg from clients where Client = '" + clientName + "'");
            cCredit = (int)clients.Rows[0][0];        //      credit,  dolg
            cDolg = (int)clients.Rows[0][1];

            if (cDolg * 100 > (cCredit + cDolg) * 90)  // ���� ������ 90% �� ������� �������
            {
                SystemSounds.Beep.Play();
                tbBigDolg.Visible = true;
            }
            else tbBigDolg.Visible = false;
        }

        private void dgvOrdersUpdate(String clientName)         // dgvOrdersUpdate
        {
            bsOrdersData.DataSource = db.GetTableData(
                "Select * From sales_info where ������ = " +
                (clientName == "" ? "null" : "'" + clientName + "'") +
                " order by ����� desc, ������� desc");
        }

        private void cbClientSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvClientsUpdate(cbClientSelected.Text);        // ������� ������ �������
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            cbClientSelected.Enabled = false;               // ������� �������
            btSelect.Visible = false;
            clientName = cbClientSelected.Text;

            System.Data.DataTable clients = db.GetTableData(
                "SELECT id, credit, money, dolg from clients where Client = '" + clientName + "'");
            clientID = clients.Rows[0][0].ToString();       // ��������� ��� ������: client ID 
            clientCredit = (int)clients.Rows[0][1];        //      credit, money, dolg
            clientMoney = (int)clients.Rows[0][2];
            clientDolg = (int)clients.Rows[0][3];
            //MessageBox.Show("Client:" + clientID + clientName+ "credit " + clientCredit.ToString());

            btNewOrder.Visible = true;
            btNewOrder.Enabled = true;

            dgvClientOrders.Visible = true;
            dgvOrdersUpdate(clientName);
            rowIndex = -1;
        }

        private void btNewOrder_Click(object sender, EventArgs e)                      // ����� �����
        {
            int rowCount = db.Operation("INSERT INTO orders (clientID) VALUES ('" +
                                    clientID + "')");
            if (rowCount == 0) return;
            btNewOrder.Enabled = false;

            System.Data.DataTable orders = db.GetTableData("SELECT max(id) from orders");
            orderID = orders.Rows[0][0].ToString();                 // orderID = max ordertID
            tbNewOrder.Text = orderID;
            tbNewOrder.Visible = true;

            btClear.Visible = true;
            btSaveOrder.Visible = true;

            cbOrderGood.SelectedIndex = 0;
            cbReturnGood.SelectedIndex = 0;

            cbVidProdazi.Visible = true;
            cbVidProdazi.Enabled = true;
            cbVidProdazi.SelectedIndex = VidProdazi - 1;

            cbVidProdazi_SelectedIndexChanged(sender, e);
            rowIndex = -1;

            tbOrderQty.Text = "";
            tbReturnQty.Text = "";
            orderC = 0;
            returnC = 0;
        }

        private void cbVidProdazi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //VidProdazi = Convert.ToInt32(cbVidProdazi.Text.Substring(0, 1));
            //VidProdazi = cbVidProdazi.SelectedIndex + 1;
            VidProdazi = cbVidProdazi.Text[0] - '0';                // ��� ������� - ������ ����� ������
            btAction.Visible = true;
            btAction.Text = "�������� ������";
            if (VidProdazi == 4) btAction.Text = "�������� �     ->\n ������� ������ ->";
            if (VidProdazi == 5) btAction.Text = "\n������� ������";
        }

        private void btAction_Click(object sender, EventArgs e)     // ������� ��� �������
        {
            cbVidProdazi.Enabled = false;

            if (VidProdazi == 4)
            {
                SetFormOrdering(true);
                SetFormReturning(true);
            }
            else if (VidProdazi == 5)
            {
                SetFormReturning(true);
            }
            else
            {
                SetFormOrdering(true);
            }
        }

        private void SetFormHeadersAndButtons(bool v)           // SetFormHeadersAndButtons
        {
            label2.Visible = v;
            label3.Visible = v;
            label4.Visible = v;
            label5.Visible = v;
            label6.Visible = v;

            btAdd.Visible = v;
            btDelete.Visible = v;
        }

        private void SetFormReturning(bool v)                   // SetFormReturning
        {
            SetFormHeadersAndButtons(v);

            cbReturnGood.Visible = v;
            tbReturnPrice.Visible = v;
            tbReturnQty.Visible = v;
            tbReturnMax.Visible = v;
            tbReturnCost.Visible = v;
        }
        private void SetFormOrdering(bool v)                    // SetFormOrdering
        {
            SetFormHeadersAndButtons(v);

            cbOrderGood.Visible = v;
            tbOrderPrice.Visible = v;
            tbOrderQty.Visible = v;
            tbOrderMax.Visible = v;
            tbOrderCost.Visible = v;
        }

        private void ClearOrderDetails()        // ClearOrderDetails - ������� ������� ������
        {
            tbNewOrder.Visible = false;
            btClear.Visible = false;
            btSaveOrder.Visible = false;
            cbVidProdazi.Visible = false;

            SetFormOrdering(false);
            SetFormReturning(false);
        }

        private void cbOrderGood_SelectedIndexChanged(object sender, EventArgs e)
        {
            String g = cbOrderGood.Text;
            System.Data.DataTable goods = db.GetTableData("SELECT Price, ngoods from goods_qty where Good = '" +
                g + "'");
            tbOrderPrice.Text = goods.Rows[0][0].ToString();
            tbOrderQty.ReadOnly = false;
            int k = Convert.ToInt32(goods.Rows[0][1].ToString());
            if (k < 0) k = 0;
            tbOrderMax.Text = k.ToString();
            if (k == 0)
            {
                tbOrderQty.Text = "0";
                tbOrderQty.ReadOnly = true;
            }
        }

        private void cbReturnGood_SelectedIndexChanged(object sender, EventArgs e)
        {
            String g = cbReturnGood.Text;
            //MessageBox.Show("SELECT Price, ngoods from goods_qty where Good = '" +
            //    g + "'");
            System.Data.DataTable goods = db.GetTableData("SELECT Price, ngoods from goods_qty where Good = '" +
                g + "'");
            tbReturnPrice.Text = goods.Rows[0][0].ToString();

            //tbReturnQty.Text = "";
            tbReturnQty.ReadOnly = false;
            string s = "SELECT sum(i.qty) from orders r, items i, goods g where i.goodid = g.id and r.id = i.Orderid and r.clientID ='" +
                clientID + "' and g.good = '" + g + "'";
            //MessageBox.Show(s);
            System.Data.DataTable goodsr = db.GetTableData(s);

            //MessageBox.Show(goodsr.Rows.Count.ToString() + "'" + goodsr.Rows[0][0].ToString());
            int k = 0;
            if (goodsr.Rows.Count != 0)
            {
                try
                {
                    k = Convert.ToInt32(goodsr.Rows[0][0].ToString());
                }
                catch
                {
                    k = 0;
                }
            }
            if (k < 0) k = 0;
            tbReturnMax.Text = k.ToString();
            if (k == 0)
            {
                tbReturnQty.Text = "0";
                tbReturnQty.ReadOnly = true;
            }
        }

        private void tbOrderQty_TextChanged(object sender, EventArgs e)
        {
            tbOrderQty.BackColor = Color.White;
            tbOrderCost.BackColor = Color.White;
            tbOrderQty.ForeColor = Color.Green;
            tbOrderCost.Text = "";

            //dgvClientData.Rows[0].DefaultCellStyle.BackColor = Color.White;

            int p = Convert.ToInt32(tbOrderPrice.Text);
            int kMax = Convert.ToInt32(tbOrderMax.Text);
            int k = 0;
            //int c = 0;
            bool isErr = false;

            orderC = 0;

            if (tbOrderQty.Text != "")
            {
                try
                {
                    k = Convert.ToInt32(tbOrderQty.Text);
                    //MessageBox.Show("p k kmax:" + p.ToString() + ":" + k.ToString()+ ":" + kMax.ToString());
                    if (k > kMax)
                    {
                        isErr = true;
                        tbOrderCost.Text = "";
                    }
                    else
                    {
                        orderC = p * k;
                        tbOrderCost.Text = orderC.ToString();
                    }
                }
                catch
                {
                    tbOrderCost.Text = "�� �����";
                    isErr = true;
                }
                if (isErr)
                {
                    tbOrderQty.BackColor = Color.Yellow;
                    tbOrderCost.BackColor = Color.Yellow;
                    tbOrderQty.ForeColor = Color.Red;
                    SystemSounds.Beep.Play();
                }
            }
        }

        private void tbReturnQty_TextChanged(object sender, EventArgs e)
        {
            tbReturnQty.BackColor = Color.White;
            tbReturnCost.BackColor = Color.White;
            tbReturnQty.ForeColor = Color.Green;
            tbReturnCost.Text = "";

            int p = Convert.ToInt32(tbReturnPrice.Text);
            int kMax = Convert.ToInt32(tbReturnMax.Text);
            int k = 0;
            //int c = 0;
            bool isErr = false;

            returnC = 0;

            if (tbReturnQty.Text != "")
            {
                try
                {
                    k = Convert.ToInt32(tbReturnQty.Text);
                    if (k > kMax)
                    {
                        isErr = true;
                        tbReturnCost.Text = "";
                    }
                    else
                    {
                        returnC = p * k;
                        tbReturnCost.Text = returnC.ToString();
                    }
                }
                catch
                {
                    tbReturnCost.Text = "�� �����";
                    isErr = true;
                }
                if (isErr)
                {
                    tbReturnQty.BackColor = Color.Yellow;
                    tbReturnCost.BackColor = Color.Yellow;
                    tbReturnQty.ForeColor = Color.Red;
                    SystemSounds.Beep.Play();
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)           // ������ �������� ������� � �����
        {
            String g, gID;
            int gQty;
            System.Data.DataTable goods;
            int rowCount;
            String cID;
            int cCredit, cMoney, cDolg;

            System.Data.DataTable clients = db.GetTableData(
                "SELECT id, credit, money, dolg from clients where Client = '" + clientName + "'");
            cID = clients.Rows[0][0].ToString();       //     ������� ��������
            cCredit = (int)clients.Rows[0][1];        //      credit, money, dolg
            cMoney = (int)clients.Rows[0][2];
            cDolg = (int)clients.Rows[0][3];

            if (tbOrderQty.Visible)             // ��������� � ��������: �����
            {
                if (tbOrderQty.Text == "" | tbOrderQty.Text == "0")      // �� ������� ����������
                {
                    tbOrderQty.Text = "0";
                    tbOrderQty.BackColor = Color.Yellow;
                    return;
                }
            }
            if (tbReturnQty.Visible)             // ��������� � �������� : �������
            {
                if (tbReturnQty.Text == "" | tbReturnQty.Text == "0")      // �� ������� ����������
                {
                    tbReturnQty.Text = "0";
                    tbReturnQty.BackColor = Color.Yellow;
                    return;
                }
            }
            if (VidProdazi == 1) { }            // �������� ������ 
            if (VidProdazi == 2 & orderC > 0)                // ����������� ������ 
            {
                if (orderC > cMoney)
                {
                    MessageBox.Show("������������ ����� �� �����");
                    return;
                }
                cMoney -= orderC;
                //MessageBox.Show("UPDATE clients SET Money = '" + cMoney.ToString() +
                //            "' WHERE id = '" + clientID + "'");
                rowCount = db.Operation("UPDATE clients SET Money = '" + cMoney.ToString() +
                            "' WHERE id = '" + clientID + "'");
            }
            if (VidProdazi == 3 & orderC > 0)                // � ������ 
            {
                int toPay = orderC;
                //MessageBox.Show(toPay.ToString() + ":" + cMoney.ToString());
                if (toPay > cMoney)
                {
                    toPay -= cMoney;
                    cMoney = 0;
                }
                else
                {
                    cMoney -= toPay;
                    toPay = 0;
                }
                if (toPay > cCredit)
                {
                    MessageBox.Show("������������ ������� ������� ��� ������");
                    return;
                }
                cCredit -= toPay;
                cDolg += toPay;

                rowCount = db.Operation("UPDATE clients SET Credit = '" +
                    cCredit.ToString() + "', Money = '" + cMoney.ToString() + "', Dolg = '" +
                    cDolg.ToString() + "' WHERE id = '" + clientID + "'");

            }
            if (VidProdazi == 4 & orderC > 0)                    // ������
            {
                if (tbOrderCost.Text != tbReturnCost.Text)
                {
                    MessageBox.Show("��������� ������������ � ������������ ������� �� �����" +
                        " ��� ��������� ���������� �������");
                    return;
                }
            }
            if (VidProdazi == 5 & returnC > 0)                    // �����������  
            {
                if (returnC > cDolg)            // ����� �������� 
                {
                    cCredit += cDolg;           // ���� ����������, ������ �������������
                    cMoney += (returnC - cDolg);     // ���������� ����� - �� ����
                    cDolg = 0;
                }
                else
                {
                    cCredit += returnC;         // ���� �����������, ������ �������������
                    cDolg -= returnC;
                }

                rowCount = db.Operation("UPDATE clients SET Credit = '" +
                    cCredit.ToString() + "', Money = '" + cMoney.ToString() + "', Dolg = '" +
                    cDolg.ToString() + "' WHERE id = '" + clientID + "'");
            }

            if (tbOrderQty.Visible & orderC > 0)       // ��������� � ��������, � ������� ��� ��
            {
                g = cbOrderGood.Text;
                goods = db.GetTableData(
                    "SELECT id from goods where Good = '" + g + "'");  // ����� ID ������ 
                gID = goods.Rows[0][0].ToString();
                gQty = Convert.ToInt32(tbOrderQty.Text);

                //MessageBox.Show(g+":"+ gID+":"+ gQty);
                rowCount = db.Operation("INSERT INTO items (orderID, goodID, qty, vidProdazi) VALUES ('" +
                                        orderID + "', '" + gID + "', '" + gQty + "', '" + VidProdazi + "')");
                tbOrderQty.Text = "";
            }

            if (tbReturnQty.Visible & returnC > 0)       // � ������� ��� ��
            {
                g = cbReturnGood.Text;
                goods = db.GetTableData(
                    "SELECT id from goods where Good = '" + g + "'");  // ����� ID ������ 
                gID = goods.Rows[0][0].ToString();
                gQty = Convert.ToInt32(tbReturnQty.Text);

                //MessageBox.Show(g + ":" + gID + ":" + gQty);
                //MessageBox.Show(g+":"+ gID+":"+ gQty);
                rowCount = db.Operation("INSERT INTO items (orderID, goodID, qty, vidProdazi) VALUES ('" +
                                        orderID + "', '" + gID + "', '-" + gQty + "', '" + VidProdazi + "')");
                tbReturnQty.Text = "";
            }

            dgvClientsUpdate(clientName);                       // ������������� �������
            dgvOrdersUpdate(clientName);

            cbOrderGood_SelectedIndexChanged(sender, e);        // ��������� ������������� ����� tbOrder*, tbReturn*
            cbReturnGood_SelectedIndexChanged(sender, e);
        }

        private void dgvClientOrders_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            rowIndex = -1;
            // For any other operation except, StateChanged, do nothing
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            rowIndex = e.Row.Index;
            if (rowIndex >= (dgvClientOrders.Rows.Count - 1))  // �� ��������� ������ ������ 
                rowIndex = -1;
        }

        private void btDelete_Click(object sender, EventArgs e)     // ������ ������� ������� �� ������
        {
            if (rowIndex == -1)
            {
                MessageBox.Show("��� �������� ������� ���������� ������� � ������� ������ �������� ������ N "
                    + orderID);
                return;
            }

            string ordID = "";
            string itemID = "";
            ordID = dgvClientOrders.Rows[rowIndex].Cells[1].Value.ToString();
            itemID = dgvClientOrders.Rows[rowIndex].Cells[2].Value.ToString();
            //MessageBox.Show("dgvClientOrders:'" + rowIndex.ToString() + "'" + ordID + "'" + itemID + "'");
            rowIndex = -1;

            if (ordID != orderID)
            {
                MessageBox.Show("����� ������� ������ ������ �������� ������ N " + orderID);
                return;
            }

            int cCredit, cMoney, cDolg;
            System.Data.DataTable clients = db.GetTableData(
                "SELECT credit, money, dolg from clients where Client = '" + clientName + "'");
            cCredit = (int)clients.Rows[0][0];        //   ������� ��������   credit, money, dolg
            cMoney = (int)clients.Rows[0][1];
            cDolg = (int)clients.Rows[0][2];

            int orderMoney;
            System.Data.DataTable salesinfo = db.GetTableData(
                "SELECT ��������� from sales_info where ������� = '" + itemID + "'");
            orderMoney = Convert.ToInt32(salesinfo.Rows[0][0].ToString());        //   �������� � �������� ������� 

            if (orderMoney > 0)
            {                           // ���� �������, ������ ������� �� ��� �����
                if (orderMoney > cDolg)            // ����� ��������
                {
                    cCredit += cDolg;                   // ���� ����������, ������ �������������
                    cMoney += (orderMoney - cDolg);        // ���������� ����� - �� ����
                    cDolg = 0;
                }
                else
                {
                    cCredit += orderMoney;                 // ���� �����������, ������ �������������
                    cDolg -= orderMoney;
                }
            }
            else
            {
                int toPay = -orderMoney;
                if (toPay > cMoney)
                {
                    toPay -= cMoney;
                    cMoney = 0;
                }
                else
                {
                    cMoney -= toPay;
                    toPay = 0;
                }
                if (toPay > cCredit)
                {
                    MessageBox.Show("���������� ������� ������ - " +
                        "������������ ������� ������� ��� �������������� �������");
                    return;
                }
                cCredit -= toPay;
                cDolg += toPay;
            }

            int rowCount;
            rowCount = db.Operation("UPDATE clients SET Credit = '" +
                cCredit.ToString() + "', Money = '" + cMoney.ToString() + "', Dolg = '" +
                cDolg.ToString() + "' WHERE id = '" + clientID + "'");

            rowCount = db.Operation("DELETE from items where id = '" + itemID + "'");

            //dgvClientOrders.ClearSelection();

            dgvClientsUpdate(clientName);                       // ������������� �������
            dgvOrdersUpdate(clientName);

            cbOrderGood_SelectedIndexChanged(sender, e);        // ��������� ������������� ����� tbOrder*, tbReturn*
            cbReturnGood_SelectedIndexChanged(sender, e);
        }

        private void btClear_Click(object sender, EventArgs e)          // ������ �������� �����
        {
            int rowCount = 0;
            ClearOrderDetails();
            btNewOrder.Enabled = true;
            btAction.Visible = false;
            // ������� ������� ����� � �������� ��� ��� items 
            rowCount = db.Operation("DELETE from orders where id = '" + orderID + "'");
            // ����� (rollback) � ������ �������� ����� �����
            rowCount = db.Operation("UPDATE clients SET Credit = '" +
                clientCredit.ToString() + "', Money = '" + clientMoney.ToString() + "', Dolg = '" +
                clientDolg.ToString() + "' WHERE id = '" + clientID + "'");

            dgvClientsUpdate(clientName);                       // ������������� �������
            dgvOrdersUpdate(clientName);
            orderID = "";
        }

        private void btSaveOrder_Click(object sender, EventArgs e)          // ������ ���������������� �����
        {
            ClearOrderDetails();
            btNewOrder.Enabled = true;
            btAction.Visible = false;

            dgvClientsUpdate(clientName);                       // ������������� �������
            dgvOrdersUpdate(clientName);
            orderID = "";
        }

        private void btReport_Click(object sender, EventArgs e)
        {                                               // �������� ������ ������� ������� �� �������
            btReport.Enabled = false;

            if (p_excel is not null)                    // ���������� ���������� ������� Excel
            {
                try
                {
                    p_excel.Kill();
                    p_excel.Close();
                }
                catch (Exception exp0)   // ����������� ������
                {
                                        // ���������������
                }
                p_excel = null;
            }

            _Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;


            String pname = Path.GetFullPath(@"../../../../");  // Mac, Win - ����� �� ���������� ������
            excel.DisplayAlerts = false;
            wb = excel.Workbooks.Open(pname + "NKISLab01R.xlsm");
            ws = wb.Worksheets["������� �������"];

            System.Data.DataTable goods = db.GetTableData(
                "SELECT good, id, price, " +
                "ngoods, ngoods*price as \"Sum\" " +
                "FROM dev.goods_qty order by good;");           // ������ ��� ������ �� ������� 

            for (int j = 0; j < 5; j++)                         // �������� �������
                ws.Columns[j + 1].ClearContents();
            ws.Cells.Font.Bold = false;
            ws.Rows[1].Font.Bold = true;

            ws.Cells[1, 1].Value = "�����";                     // ���������
            ws.Cells[1, 2].Value = "ID";
            ws.Cells[1, 3].Value = "���� �������";
            ws.Cells[1, 4].Value = "�������";
            ws.Cells[1, 5].Value = "���������";

            int nGoods = goods.Rows.Count;

            for (int i = 0; i < nGoods; i++)
                for (int j = 0; j < 5; j++)
                    ws.Cells[i + 2, j + 1].Value = goods.Rows[i][j].ToString();
            ws.Cells[nGoods + 2, 5].Formula = "=SUM(E2:E" + (nGoods + 1).ToString() + ")";
            ws.Cells[nGoods + 2, 1].Value = "�����";
            ws.Rows[nGoods + 2].Font.Bold = true;

            try
            {
                wb.Save();
            }
            catch (Exception exp)   // ����������� ������
            {
                MessageBox.Show("Error: {0}", exp.Message); // ���������� ��
            }

            wb.Close();

            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE";
            psi.Arguments = @"/x " + pname + "NKISLab01R.xlsm";
            p_excel = new Process();
            p_excel.StartInfo = psi;
            p_excel.Start();
            //p_excel.WaitForExit();

            btReport.Enabled = true;
        }
    }
}