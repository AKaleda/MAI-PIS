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
            this.cbClientSelected = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSelect = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btSaveOrder = new System.Windows.Forms.Button();
            this.dgvClientOrders = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvClientData = new System.Windows.Forms.DataGridView();
            this.cbVidProdazi = new System.Windows.Forms.ComboBox();
            this.btNewOrder = new System.Windows.Forms.Button();
            this.cbReturnGood = new System.Windows.Forms.ComboBox();
            this.cbOrderGood = new System.Windows.Forms.ComboBox();
            this.tbReturnQty = new System.Windows.Forms.TextBox();
            this.tbOrderQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOrderPrice = new System.Windows.Forms.TextBox();
            this.tbReturnPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOrderCost = new System.Windows.Forms.TextBox();
            this.tbReturnCost = new System.Windows.Forms.TextBox();
            this.tbNewOrder = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAction = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOrderMax = new System.Windows.Forms.TextBox();
            this.tbReturnMax = new System.Windows.Forms.TextBox();
            this.tbBigDolg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientOrders)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientData)).BeginInit();
            this.SuspendLayout();
            // 
            // cbClientSelected
            // 
            this.cbClientSelected.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbClientSelected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientSelected.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbClientSelected.FormattingEnabled = true;
            this.cbClientSelected.IntegralHeight = false;
            this.cbClientSelected.Location = new System.Drawing.Point(93, 7);
            this.cbClientSelected.Name = "cbClientSelected";
            this.cbClientSelected.Size = new System.Drawing.Size(541, 31);
            this.cbClientSelected.TabIndex = 1;
            this.cbClientSelected.SelectedIndexChanged += new System.EventHandler(this.cbClientSelected_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-2, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиент";
            // 
            // btSelect
            // 
            this.btSelect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btSelect.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSelect.Location = new System.Drawing.Point(653, 5);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(112, 34);
            this.btSelect.TabIndex = 3;
            this.btSelect.Text = "Выбрать";
            this.btSelect.UseVisualStyleBackColor = false;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.Yellow;
            this.btClear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btClear.Location = new System.Drawing.Point(287, 211);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(182, 34);
            this.btClear.TabIndex = 7;
            this.btClear.Text = "Отменить Заказ";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Visible = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btSaveOrder
            // 
            this.btSaveOrder.BackColor = System.Drawing.Color.Lime;
            this.btSaveOrder.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSaveOrder.Location = new System.Drawing.Point(4, 211);
            this.btSaveOrder.Name = "btSaveOrder";
            this.btSaveOrder.Size = new System.Drawing.Size(277, 34);
            this.btSaveOrder.TabIndex = 8;
            this.btSaveOrder.Text = "Зарегистрировать Заказ";
            this.btSaveOrder.UseVisualStyleBackColor = false;
            this.btSaveOrder.Visible = false;
            this.btSaveOrder.Click += new System.EventHandler(this.btSaveOrder_Click);
            // 
            // dgvClientOrders
            // 
            this.dgvClientOrders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvClientOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvClientOrders.Name = "dgvClientOrders";
            this.dgvClientOrders.ReadOnly = true;
            this.dgvClientOrders.RowHeadersWidth = 62;
            this.dgvClientOrders.RowTemplate.Height = 33;
            this.dgvClientOrders.Size = new System.Drawing.Size(1600, 337);
            this.dgvClientOrders.TabIndex = 9;
            this.dgvClientOrders.Visible = false;
            this.dgvClientOrders.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvClientOrders_RowStateChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvClientOrders);
            this.panel1.Location = new System.Drawing.Point(-2, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 337);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvClientData);
            this.panel2.Location = new System.Drawing.Point(-2, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1600, 59);
            this.panel2.TabIndex = 11;
            // 
            // dgvClientData
            // 
            this.dgvClientData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvClientData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvClientData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClientData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientData.Location = new System.Drawing.Point(0, 0);
            this.dgvClientData.Name = "dgvClientData";
            this.dgvClientData.ReadOnly = true;
            this.dgvClientData.RowHeadersWidth = 62;
            this.dgvClientData.RowTemplate.Height = 33;
            this.dgvClientData.Size = new System.Drawing.Size(1600, 59);
            this.dgvClientData.TabIndex = 0;
            // 
            // cbVidProdazi
            // 
            this.cbVidProdazi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbVidProdazi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVidProdazi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbVidProdazi.FormattingEnabled = true;
            this.cbVidProdazi.IntegralHeight = false;
            this.cbVidProdazi.Items.AddRange(new object[] {
            "1 Наличный расчет",
            "2 Безналичный расчет",
            "3 В кредит",
            "4 Бартер",
            "5 Взаимозачет "});
            this.cbVidProdazi.Location = new System.Drawing.Point(256, 168);
            this.cbVidProdazi.Name = "cbVidProdazi";
            this.cbVidProdazi.Size = new System.Drawing.Size(213, 31);
            this.cbVidProdazi.TabIndex = 12;
            this.cbVidProdazi.Visible = false;
            this.cbVidProdazi.SelectedIndexChanged += new System.EventHandler(this.cbVidProdazi_SelectedIndexChanged);
            // 
            // btNewOrder
            // 
            this.btNewOrder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btNewOrder.Enabled = false;
            this.btNewOrder.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btNewOrder.Location = new System.Drawing.Point(4, 159);
            this.btNewOrder.Name = "btNewOrder";
            this.btNewOrder.Size = new System.Drawing.Size(147, 34);
            this.btNewOrder.TabIndex = 13;
            this.btNewOrder.Text = "Новый Заказ";
            this.btNewOrder.UseVisualStyleBackColor = false;
            this.btNewOrder.Visible = false;
            this.btNewOrder.Click += new System.EventHandler(this.btNewOrder_Click);
            // 
            // cbReturnGood
            // 
            this.cbReturnGood.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbReturnGood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReturnGood.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbReturnGood.FormattingEnabled = true;
            this.cbReturnGood.IntegralHeight = false;
            this.cbReturnGood.Location = new System.Drawing.Point(712, 211);
            this.cbReturnGood.Name = "cbReturnGood";
            this.cbReturnGood.Size = new System.Drawing.Size(223, 31);
            this.cbReturnGood.TabIndex = 14;
            this.cbReturnGood.Visible = false;
            this.cbReturnGood.SelectedIndexChanged += new System.EventHandler(this.cbReturnGood_SelectedIndexChanged);
            // 
            // cbOrderGood
            // 
            this.cbOrderGood.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbOrderGood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderGood.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbOrderGood.FormattingEnabled = true;
            this.cbOrderGood.IntegralHeight = false;
            this.cbOrderGood.Location = new System.Drawing.Point(712, 168);
            this.cbOrderGood.Name = "cbOrderGood";
            this.cbOrderGood.Size = new System.Drawing.Size(223, 31);
            this.cbOrderGood.TabIndex = 15;
            this.cbOrderGood.Visible = false;
            this.cbOrderGood.SelectedIndexChanged += new System.EventHandler(this.cbOrderGood_SelectedIndexChanged);
            // 
            // tbReturnQty
            // 
            this.tbReturnQty.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbReturnQty.Location = new System.Drawing.Point(1056, 209);
            this.tbReturnQty.Name = "tbReturnQty";
            this.tbReturnQty.Size = new System.Drawing.Size(94, 33);
            this.tbReturnQty.TabIndex = 19;
            this.tbReturnQty.Visible = false;
            this.tbReturnQty.TextChanged += new System.EventHandler(this.tbReturnQty_TextChanged);
            // 
            // tbOrderQty
            // 
            this.tbOrderQty.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbOrderQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbOrderQty.Location = new System.Drawing.Point(1056, 169);
            this.tbOrderQty.Name = "tbOrderQty";
            this.tbOrderQty.Size = new System.Drawing.Size(94, 33);
            this.tbOrderQty.TabIndex = 20;
            this.tbOrderQty.Visible = false;
            this.tbOrderQty.TextChanged += new System.EventHandler(this.tbOrderQty_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(781, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Товар";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1068, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Кол-во";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(945, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Цена 1 шт";
            this.label4.Visible = false;
            // 
            // tbOrderPrice
            // 
            this.tbOrderPrice.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbOrderPrice.Location = new System.Drawing.Point(949, 169);
            this.tbOrderPrice.Name = "tbOrderPrice";
            this.tbOrderPrice.ReadOnly = true;
            this.tbOrderPrice.Size = new System.Drawing.Size(101, 33);
            this.tbOrderPrice.TabIndex = 24;
            this.tbOrderPrice.Visible = false;
            // 
            // tbReturnPrice
            // 
            this.tbReturnPrice.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbReturnPrice.Location = new System.Drawing.Point(949, 211);
            this.tbReturnPrice.Name = "tbReturnPrice";
            this.tbReturnPrice.ReadOnly = true;
            this.tbReturnPrice.Size = new System.Drawing.Size(101, 33);
            this.tbReturnPrice.TabIndex = 23;
            this.tbReturnPrice.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1282, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Сумма";
            this.label5.Visible = false;
            // 
            // tbOrderCost
            // 
            this.tbOrderCost.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbOrderCost.Location = new System.Drawing.Point(1272, 169);
            this.tbOrderCost.Name = "tbOrderCost";
            this.tbOrderCost.ReadOnly = true;
            this.tbOrderCost.Size = new System.Drawing.Size(129, 33);
            this.tbOrderCost.TabIndex = 27;
            this.tbOrderCost.Visible = false;
            // 
            // tbReturnCost
            // 
            this.tbReturnCost.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbReturnCost.Location = new System.Drawing.Point(1272, 210);
            this.tbReturnCost.Name = "tbReturnCost";
            this.tbReturnCost.ReadOnly = true;
            this.tbReturnCost.Size = new System.Drawing.Size(129, 33);
            this.tbReturnCost.TabIndex = 26;
            this.tbReturnCost.Visible = false;
            // 
            // tbNewOrder
            // 
            this.tbNewOrder.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbNewOrder.Location = new System.Drawing.Point(157, 160);
            this.tbNewOrder.Name = "tbNewOrder";
            this.tbNewOrder.ReadOnly = true;
            this.tbNewOrder.Size = new System.Drawing.Size(62, 33);
            this.tbNewOrder.TabIndex = 29;
            this.tbNewOrder.Visible = false;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Lime;
            this.btAdd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAdd.Location = new System.Drawing.Point(712, 256);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(223, 34);
            this.btAdd.TabIndex = 30;
            this.btAdd.Text = "Добавить в Заказ";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Visible = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Yellow;
            this.btDelete.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btDelete.Location = new System.Drawing.Point(495, 256);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(199, 34);
            this.btDelete.TabIndex = 31;
            this.btDelete.Text = "Удалить из Заказа";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Visible = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAction
            // 
            this.btAction.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btAction.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAction.Location = new System.Drawing.Point(495, 168);
            this.btAction.Name = "btAction";
            this.btAction.Size = new System.Drawing.Size(199, 58);
            this.btAction.TabIndex = 32;
            this.btAction.Text = "Действие";
            this.btAction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAction.UseVisualStyleBackColor = false;
            this.btAction.Visible = false;
            this.btAction.Click += new System.EventHandler(this.btAction_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1158, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "не больше";
            this.label6.Visible = false;
            // 
            // tbOrderMax
            // 
            this.tbOrderMax.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbOrderMax.Location = new System.Drawing.Point(1168, 170);
            this.tbOrderMax.Name = "tbOrderMax";
            this.tbOrderMax.ReadOnly = true;
            this.tbOrderMax.Size = new System.Drawing.Size(94, 33);
            this.tbOrderMax.TabIndex = 34;
            this.tbOrderMax.Visible = false;
            // 
            // tbReturnMax
            // 
            this.tbReturnMax.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbReturnMax.Location = new System.Drawing.Point(1168, 210);
            this.tbReturnMax.Name = "tbReturnMax";
            this.tbReturnMax.ReadOnly = true;
            this.tbReturnMax.Size = new System.Drawing.Size(94, 33);
            this.tbReturnMax.TabIndex = 35;
            this.tbReturnMax.Visible = false;
            // 
            // tbBigDolg
            // 
            this.tbBigDolg.BackColor = System.Drawing.Color.Red;
            this.tbBigDolg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbBigDolg.Location = new System.Drawing.Point(643, 105);
            this.tbBigDolg.Name = "tbBigDolg";
            this.tbBigDolg.ReadOnly = true;
            this.tbBigDolg.Size = new System.Drawing.Size(465, 28);
            this.tbBigDolg.TabIndex = 36;
            this.tbBigDolg.Text = "Текущий долг превышает 90% от потолка кредита";
            this.tbBigDolg.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1612, 684);
            this.Controls.Add(this.tbBigDolg);
            this.Controls.Add(this.tbReturnMax);
            this.Controls.Add(this.tbOrderMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btAction);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbNewOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbOrderCost);
            this.Controls.Add(this.tbReturnCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbOrderPrice);
            this.Controls.Add(this.tbReturnPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOrderQty);
            this.Controls.Add(this.tbReturnQty);
            this.Controls.Add(this.cbOrderGood);
            this.Controls.Add(this.cbReturnGood);
            this.Controls.Add(this.btNewOrder);
            this.Controls.Add(this.cbVidProdazi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSaveOrder);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.cbClientSelected);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Обработка заказов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientOrders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}