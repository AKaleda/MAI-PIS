namespace NKISLab11
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cbF1 = new ComboBox();
            cbF2 = new ComboBox();
            cbF3 = new ComboBox();
            tbF = new TextBox();
            tbFCode = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btGenVBA = new Button();
            lbCopied = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // cbF1
            // 
            cbF1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cbF1.FormattingEnabled = true;
            cbF1.Items.AddRange(new object[] { "(", "sqr(", "exp(", "1/(" });
            cbF1.Location = new Point(74, 35);
            cbF1.Margin = new Padding(4, 3, 4, 3);
            cbF1.Name = "cbF1";
            cbF1.Size = new Size(86, 32);
            cbF1.TabIndex = 0;
            cbF1.Text = "(";
            cbF1.SelectedIndexChanged += cbF1_SelectedIndexChanged;
            // 
            // cbF2
            // 
            cbF2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cbF2.FormattingEnabled = true;
            cbF2.Items.AddRange(new object[] { "(", "sqr(", "exp(", "1/(" });
            cbF2.Location = new Point(156, 35);
            cbF2.Margin = new Padding(4, 3, 4, 3);
            cbF2.Name = "cbF2";
            cbF2.Size = new Size(86, 32);
            cbF2.TabIndex = 1;
            cbF2.Text = "(";
            cbF2.SelectedIndexChanged += cbF2_SelectedIndexChanged;
            // 
            // cbF3
            // 
            cbF3.BackColor = Color.White;
            cbF3.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cbF3.FormattingEnabled = true;
            cbF3.Items.AddRange(new object[] { "x", "sqr(x)", "exp(x)", "1/x" });
            cbF3.Location = new Point(239, 35);
            cbF3.Margin = new Padding(4, 3, 4, 3);
            cbF3.Name = "cbF3";
            cbF3.Size = new Size(103, 32);
            cbF3.TabIndex = 2;
            cbF3.Text = "x";
            cbF3.SelectedIndexChanged += cbF3_SelectedIndexChanged;
            // 
            // tbF
            // 
            tbF.BackColor = Color.White;
            tbF.Enabled = false;
            tbF.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tbF.Location = new Point(341, 35);
            tbF.Margin = new Padding(4, 3, 4, 3);
            tbF.Name = "tbF";
            tbF.ReadOnly = true;
            tbF.Size = new Size(35, 30);
            tbF.TabIndex = 3;
            tbF.Text = "))";
            // 
            // tbFCode
            // 
            tbFCode.BackColor = Color.White;
            tbFCode.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tbFCode.Location = new Point(34, 85);
            tbFCode.Margin = new Padding(4, 3, 4, 3);
            tbFCode.Multiline = true;
            tbFCode.Name = "tbFCode";
            tbFCode.ReadOnly = true;
            tbFCode.Size = new Size(816, 534);
            tbFCode.TabIndex = 4;
            tbFCode.Text = resources.GetString("tbFCode.Text");
            tbFCode.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(100, 6);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 23);
            label1.TabIndex = 5;
            label1.Text = "F_1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(178, 6);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 23);
            label2.TabIndex = 6;
            label2.Text = "F_2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(258, 6);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 23);
            label3.TabIndex = 7;
            label3.Text = "F_3";
            // 
            // btGenVBA
            // 
            btGenVBA.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btGenVBA.Location = new Point(384, 35);
            btGenVBA.Margin = new Padding(4, 3, 4, 3);
            btGenVBA.Name = "btGenVBA";
            btGenVBA.Size = new Size(203, 33);
            btGenVBA.TabIndex = 8;
            btGenVBA.Text = "Создать код на VBA";
            btGenVBA.UseVisualStyleBackColor = true;
            btGenVBA.Click += btGenVBA_Click;
            // 
            // lbCopied
            // 
            lbCopied.AutoSize = true;
            lbCopied.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCopied.Location = new Point(586, 41);
            lbCopied.Margin = new Padding(4, 0, 4, 0);
            lbCopied.Name = "lbCopied";
            lbCopied.Size = new Size(268, 21);
            lbCopied.TabIndex = 9;
            lbCopied.Text = "Код скопирован для вставки";
            lbCopied.Visible = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(39, 35);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(35, 30);
            textBox1.TabIndex = 10;
            textBox1.Text = "y=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 631);
            Controls.Add(textBox1);
            Controls.Add(lbCopied);
            Controls.Add(btGenVBA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbFCode);
            Controls.Add(tbF);
            Controls.Add(cbF3);
            Controls.Add(cbF2);
            Controls.Add(cbF1);
            Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Генерация кода на VBA для y = F_1(F_2(F_3(x)))";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbF1;
        private ComboBox cbF2;
        private ComboBox cbF3;
        private TextBox tbF;
        private TextBox tbFCode;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btGenVBA;
        private Label lbCopied;
        private TextBox textBox1;
    }
}