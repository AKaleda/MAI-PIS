namespace NKISLab01
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbClientSelected = new ComboBox();
            label1 = new Label();
            btSelect = new Button();
            btClear = new Button();
            btSaveOrder = new Button();
            dgvClientOrders = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            dgvClientData = new DataGridView();
            cbVidProdazi = new ComboBox();
            btNewOrder = new Button();
            cbReturnGood = new ComboBox();
            cbOrderGood = new ComboBox();
            tbReturnQty = new TextBox();
            tbOrderQty = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbOrderPrice = new TextBox();
            tbReturnPrice = new TextBox();
            label5 = new Label();
            tbOrderCost = new TextBox();
            tbReturnCost = new TextBox();
            tbNewOrder = new TextBox();
            btAdd = new Button();
            btDelete = new Button();
            btAction = new Button();
            label6 = new Label();
            tbOrderMax = new TextBox();
            tbReturnMax = new TextBox();
            tbBigDolg = new TextBox();
            btReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientOrders).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientData).BeginInit();
            SuspendLayout();
            // 
            // cbClientSelected
            // 
            cbClientSelected.BackColor = SystemColors.ControlLightLight;
            cbClientSelected.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClientSelected.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbClientSelected.FormattingEnabled = true;
            cbClientSelected.IntegralHeight = false;
            cbClientSelected.Location = new Point(93, 7);
            cbClientSelected.Name = "cbClientSelected";
            cbClientSelected.Size = new Size(541, 31);
            cbClientSelected.TabIndex = 1;
            cbClientSelected.SelectedIndexChanged += cbClientSelected_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-2, 14);
            label1.Name = "label1";
            label1.Size = new Size(79, 24);
            label1.TabIndex = 0;
            label1.Text = "Клиент";
            // 
            // btSelect
            // 
            btSelect.BackColor = SystemColors.ControlLight;
            btSelect.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btSelect.Location = new Point(653, 5);
            btSelect.Name = "btSelect";
            btSelect.Size = new Size(112, 34);
            btSelect.TabIndex = 3;
            btSelect.Text = "Выбрать";
            btSelect.UseVisualStyleBackColor = false;
            btSelect.Click += btSelect_Click;
            // 
            // btClear
            // 
            btClear.BackColor = Color.Yellow;
            btClear.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btClear.Location = new Point(287, 211);
            btClear.Name = "btClear";
            btClear.Size = new Size(182, 34);
            btClear.TabIndex = 7;
            btClear.Text = "Отменить Заказ";
            btClear.UseVisualStyleBackColor = false;
            btClear.Visible = false;
            btClear.Click += btClear_Click;
            // 
            // btSaveOrder
            // 
            btSaveOrder.BackColor = Color.Lime;
            btSaveOrder.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btSaveOrder.Location = new Point(4, 211);
            btSaveOrder.Name = "btSaveOrder";
            btSaveOrder.Size = new Size(277, 34);
            btSaveOrder.TabIndex = 8;
            btSaveOrder.Text = "Зарегистрировать Заказ";
            btSaveOrder.UseVisualStyleBackColor = false;
            btSaveOrder.Visible = false;
            btSaveOrder.Click += btSaveOrder_Click;
            // 
            // dgvClientOrders
            // 
            dgvClientOrders.BackgroundColor = SystemColors.ControlLightLight;
            dgvClientOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientOrders.Dock = DockStyle.Fill;
            dgvClientOrders.Location = new Point(0, 0);
            dgvClientOrders.Name = "dgvClientOrders";
            dgvClientOrders.ReadOnly = true;
            dgvClientOrders.RowHeadersWidth = 62;
            dgvClientOrders.RowTemplate.Height = 33;
            dgvClientOrders.Size = new Size(1600, 337);
            dgvClientOrders.TabIndex = 9;
            dgvClientOrders.Visible = false;
            dgvClientOrders.RowStateChanged += dgvClientOrders_RowStateChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvClientOrders);
            panel1.Location = new Point(-2, 306);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 337);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvClientData);
            panel2.Location = new Point(-2, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(1600, 59);
            panel2.TabIndex = 11;
            // 
            // dgvClientData
            // 
            dgvClientData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvClientData.BackgroundColor = SystemColors.ControlLightLight;
            dgvClientData.BorderStyle = BorderStyle.Fixed3D;
            dgvClientData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientData.Dock = DockStyle.Fill;
            dgvClientData.Location = new Point(0, 0);
            dgvClientData.Name = "dgvClientData";
            dgvClientData.ReadOnly = true;
            dgvClientData.RowHeadersWidth = 62;
            dgvClientData.RowTemplate.Height = 33;
            dgvClientData.Size = new Size(1600, 59);
            dgvClientData.TabIndex = 0;
            // 
            // cbVidProdazi
            // 
            cbVidProdazi.BackColor = SystemColors.ControlLightLight;
            cbVidProdazi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVidProdazi.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbVidProdazi.FormattingEnabled = true;
            cbVidProdazi.IntegralHeight = false;
            cbVidProdazi.Items.AddRange(new object[] { "1 Наличный расчет", "2 Безналичный расчет", "3 В кредит", "4 Бартер", "5 Взаимозачет " });
            cbVidProdazi.Location = new Point(256, 168);
            cbVidProdazi.Name = "cbVidProdazi";
            cbVidProdazi.Size = new Size(213, 31);
            cbVidProdazi.TabIndex = 12;
            cbVidProdazi.Visible = false;
            cbVidProdazi.SelectedIndexChanged += cbVidProdazi_SelectedIndexChanged;
            // 
            // btNewOrder
            // 
            btNewOrder.BackColor = SystemColors.ControlLight;
            btNewOrder.Enabled = false;
            btNewOrder.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btNewOrder.Location = new Point(4, 159);
            btNewOrder.Name = "btNewOrder";
            btNewOrder.Size = new Size(147, 34);
            btNewOrder.TabIndex = 13;
            btNewOrder.Text = "Новый Заказ";
            btNewOrder.UseVisualStyleBackColor = false;
            btNewOrder.Visible = false;
            btNewOrder.Click += btNewOrder_Click;
            // 
            // cbReturnGood
            // 
            cbReturnGood.BackColor = SystemColors.ControlLightLight;
            cbReturnGood.DropDownStyle = ComboBoxStyle.DropDownList;
            cbReturnGood.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbReturnGood.FormattingEnabled = true;
            cbReturnGood.IntegralHeight = false;
            cbReturnGood.Location = new Point(712, 211);
            cbReturnGood.Name = "cbReturnGood";
            cbReturnGood.Size = new Size(223, 31);
            cbReturnGood.TabIndex = 14;
            cbReturnGood.Visible = false;
            cbReturnGood.SelectedIndexChanged += cbReturnGood_SelectedIndexChanged;
            // 
            // cbOrderGood
            // 
            cbOrderGood.BackColor = SystemColors.ControlLightLight;
            cbOrderGood.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOrderGood.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbOrderGood.FormattingEnabled = true;
            cbOrderGood.IntegralHeight = false;
            cbOrderGood.Location = new Point(712, 168);
            cbOrderGood.Name = "cbOrderGood";
            cbOrderGood.Size = new Size(223, 31);
            cbOrderGood.TabIndex = 15;
            cbOrderGood.Visible = false;
            cbOrderGood.SelectedIndexChanged += cbOrderGood_SelectedIndexChanged;
            // 
            // tbReturnQty
            // 
            tbReturnQty.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            tbReturnQty.Location = new Point(1056, 209);
            tbReturnQty.Name = "tbReturnQty";
            tbReturnQty.Size = new Size(94, 33);
            tbReturnQty.TabIndex = 19;
            tbReturnQty.Visible = false;
            tbReturnQty.TextChanged += tbReturnQty_TextChanged;
            // 
            // tbOrderQty
            // 
            tbOrderQty.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            tbOrderQty.ForeColor = Color.FromArgb(0, 192, 0);
            tbOrderQty.Location = new Point(1056, 169);
            tbOrderQty.Name = "tbOrderQty";
            tbOrderQty.Size = new Size(94, 33);
            tbOrderQty.TabIndex = 20;
            tbOrderQty.Visible = false;
            tbOrderQty.TextChanged += tbOrderQty_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(781, 139);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 21;
            label2.Text = "Товар";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1068, 139);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 22;
            label3.Text = "Кол-во";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(945, 139);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 25;
            label4.Text = "Цена 1 шт";
            label4.Visible = false;
            // 
            // tbOrderPrice
            // 
            tbOrderPrice.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            tbOrderPrice.Location = new Point(949, 169);
            tbOrderPrice.Name = "tbOrderPrice";
            tbOrderPrice.ReadOnly = true;
            tbOrderPrice.Size = new Size(101, 33);
            tbOrderPrice.TabIndex = 24;
            tbOrderPrice.Visible = false;
            // 
            // tbReturnPrice
            // 
            tbReturnPrice.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            tbReturnPrice.Location = new Point(949, 211);
            tbReturnPrice.Name = "tbReturnPrice";
            tbReturnPrice.ReadOnly = true;
            tbReturnPrice.Size = new Size(101, 33);
            tbReturnPrice.TabIndex = 23;
            tbReturnPrice.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1282, 139);
            label5.Name = "label5";
            label5.Size = new Size(71, 23);
            label5.TabIndex = 28;
            label5.Text = "Сумма";
            label5.Visible = false;
            // 
            // tbOrderCost
            // 
            tbOrderCost.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            tbOrderCost.Location = new Point(1272, 169);
            tbOrderCost.Name = "tbOrderCost";
            tbOrderCost.ReadOnly = true;
            tbOrderCost.Size = new Size(129, 33);
            tbOrderCost.TabIndex = 27;
            tbOrderCost.Visible = false;
            // 
            // tbReturnCost
            // 
            tbReturnCost.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            tbReturnCost.Location = new Point(1272, 210);
            tbReturnCost.Name = "tbReturnCost";
            tbReturnCost.ReadOnly = true;
            tbReturnCost.Size = new Size(129, 33);
            tbReturnCost.TabIndex = 26;
            tbReturnCost.Visible = false;
            // 
            // tbNewOrder
            // 
            tbNewOrder.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            tbNewOrder.Location = new Point(157, 160);
            tbNewOrder.Name = "tbNewOrder";
            tbNewOrder.ReadOnly = true;
            tbNewOrder.Size = new Size(62, 33);
            tbNewOrder.TabIndex = 29;
            tbNewOrder.Visible = false;
            // 
            // btAdd
            // 
            btAdd.BackColor = Color.Lime;
            btAdd.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btAdd.Location = new Point(712, 256);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(223, 34);
            btAdd.TabIndex = 30;
            btAdd.Text = "Добавить в Заказ";
            btAdd.UseVisualStyleBackColor = false;
            btAdd.Visible = false;
            btAdd.Click += btAdd_Click;
            // 
            // btDelete
            // 
            btDelete.BackColor = Color.Yellow;
            btDelete.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btDelete.Location = new Point(495, 256);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(199, 34);
            btDelete.TabIndex = 31;
            btDelete.Text = "Удалить из Заказа";
            btDelete.UseVisualStyleBackColor = false;
            btDelete.Visible = false;
            btDelete.Click += btDelete_Click;
            // 
            // btAction
            // 
            btAction.BackColor = SystemColors.ControlLight;
            btAction.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btAction.Location = new Point(495, 168);
            btAction.Name = "btAction";
            btAction.Size = new Size(199, 58);
            btAction.TabIndex = 32;
            btAction.Text = "Действие";
            btAction.TextAlign = ContentAlignment.TopCenter;
            btAction.UseVisualStyleBackColor = false;
            btAction.Visible = false;
            btAction.Click += btAction_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1158, 139);
            label6.Name = "label6";
            label6.Size = new Size(108, 23);
            label6.TabIndex = 33;
            label6.Text = "не больше";
            label6.Visible = false;
            // 
            // tbOrderMax
            // 
            tbOrderMax.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            tbOrderMax.Location = new Point(1168, 170);
            tbOrderMax.Name = "tbOrderMax";
            tbOrderMax.ReadOnly = true;
            tbOrderMax.Size = new Size(94, 33);
            tbOrderMax.TabIndex = 34;
            tbOrderMax.Visible = false;
            // 
            // tbReturnMax
            // 
            tbReturnMax.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            tbReturnMax.Location = new Point(1168, 210);
            tbReturnMax.Name = "tbReturnMax";
            tbReturnMax.ReadOnly = true;
            tbReturnMax.Size = new Size(94, 33);
            tbReturnMax.TabIndex = 35;
            tbReturnMax.Visible = false;
            // 
            // tbBigDolg
            // 
            tbBigDolg.BackColor = Color.Red;
            tbBigDolg.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbBigDolg.Location = new Point(643, 105);
            tbBigDolg.Name = "tbBigDolg";
            tbBigDolg.ReadOnly = true;
            tbBigDolg.Size = new Size(465, 28);
            tbBigDolg.TabIndex = 36;
            tbBigDolg.Text = "Текущий долг превышает 90% от потолка кредита";
            tbBigDolg.Visible = false;
            // 
            // btReport
            // 
            btReport.BackColor = SystemColors.ControlLight;
            btReport.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btReport.Location = new Point(974, 4);
            btReport.Name = "btReport";
            btReport.Size = new Size(217, 34);
            btReport.TabIndex = 37;
            btReport.Text = "Остатки товаров";
            btReport.UseVisualStyleBackColor = false;
            btReport.Click += btReport_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1612, 684);
            Controls.Add(btReport);
            Controls.Add(tbBigDolg);
            Controls.Add(tbReturnMax);
            Controls.Add(tbOrderMax);
            Controls.Add(label6);
            Controls.Add(btAction);
            Controls.Add(btDelete);
            Controls.Add(btAdd);
            Controls.Add(tbNewOrder);
            Controls.Add(label5);
            Controls.Add(tbOrderCost);
            Controls.Add(tbReturnCost);
            Controls.Add(label4);
            Controls.Add(tbOrderPrice);
            Controls.Add(tbReturnPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbOrderQty);
            Controls.Add(tbReturnQty);
            Controls.Add(cbOrderGood);
            Controls.Add(cbReturnGood);
            Controls.Add(btNewOrder);
            Controls.Add(cbVidProdazi);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btSaveOrder);
            Controls.Add(btClear);
            Controls.Add(btSelect);
            Controls.Add(cbClientSelected);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Обработка заказов";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvClientOrders).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbClientSelected;
        private Button btSelect;
        private Button btClear;
        private Button btSaveOrder;
        private DataGridView dgvClientOrders;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvClientData;
        private ComboBox cbVidProdazi;
        private Button btNewOrder;
        private ComboBox cbReturnGood;
        private ComboBox cbOrderGood;
        private TextBox tbReturnQty;
        private TextBox tbOrderQty;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbOrderPrice;
        private TextBox tbReturnPrice;
        private Label label5;
        private TextBox tbOrderCost;
        private TextBox tbReturnCost;
        private TextBox tbNewOrder;
        private Button btAdd;
        private Button btDelete;
        private Button btAction;
        private Label label6;
        private TextBox tbOrderMax;
        private TextBox tbReturnMax;
        private TextBox tbBigDolg;
        private Button btReport;
    }
}