namespace NKISLab05
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
            tbK1 = new TextBox();
            tbV10 = new TextBox();
            dgvR = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tbV11 = new TextBox();
            tbV12 = new TextBox();
            tbV22 = new TextBox();
            tbV21 = new TextBox();
            tbV20 = new TextBox();
            tbK2 = new TextBox();
            tbV32 = new TextBox();
            tbV31 = new TextBox();
            tbV30 = new TextBox();
            tbK3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvR).BeginInit();
            SuspendLayout();
            // 
            // tbK1
            // 
            tbK1.BackColor = Color.White;
            tbK1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbK1.Location = new Point(12, 16);
            tbK1.Name = "tbK1";
            tbK1.ReadOnly = true;
            tbK1.Size = new Size(53, 28);
            tbK1.TabIndex = 2;
            tbK1.Text = "USD";
            // 
            // tbV10
            // 
            tbV10.BackColor = Color.White;
            tbV10.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbV10.Location = new Point(62, 16);
            tbV10.Name = "tbV10";
            tbV10.ReadOnly = true;
            tbV10.Size = new Size(288, 28);
            tbV10.TabIndex = 5;
            // 
            // dgvR
            // 
            dgvR.BackgroundColor = Color.White;
            dgvR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvR.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvR.Location = new Point(1, 112);
            dgvR.Name = "dgvR";
            dgvR.ReadOnly = true;
            dgvR.RowHeadersVisible = false;
            dgvR.RowHeadersWidth = 62;
            dgvR.RowTemplate.Height = 33;
            dgvR.Size = new Size(590, 605);
            dgvR.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "Код";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 60;
            // 
            // Column2
            // 
            Column2.HeaderText = "Валюта";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 280;
            // 
            // Column3
            // 
            Column3.HeaderText = "Кол-во";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 80;
            // 
            // Column4
            // 
            Column4.HeaderText = "Курс";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 120;
            // 
            // tbV11
            // 
            tbV11.BackColor = Color.White;
            tbV11.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbV11.Location = new Point(349, 16);
            tbV11.Name = "tbV11";
            tbV11.ReadOnly = true;
            tbV11.Size = new Size(77, 28);
            tbV11.TabIndex = 8;
            // 
            // tbV12
            // 
            tbV12.BackColor = Color.White;
            tbV12.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbV12.Location = new Point(426, 16);
            tbV12.Name = "tbV12";
            tbV12.ReadOnly = true;
            tbV12.Size = new Size(119, 28);
            tbV12.TabIndex = 9;
            // 
            // tbV22
            // 
            tbV22.BackColor = Color.White;
            tbV22.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbV22.Location = new Point(426, 41);
            tbV22.Name = "tbV22";
            tbV22.ReadOnly = true;
            tbV22.Size = new Size(119, 28);
            tbV22.TabIndex = 13;
            // 
            // tbV21
            // 
            tbV21.BackColor = Color.White;
            tbV21.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbV21.Location = new Point(349, 41);
            tbV21.Name = "tbV21";
            tbV21.ReadOnly = true;
            tbV21.Size = new Size(77, 28);
            tbV21.TabIndex = 12;
            // 
            // tbV20
            // 
            tbV20.BackColor = Color.White;
            tbV20.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbV20.Location = new Point(62, 41);
            tbV20.Name = "tbV20";
            tbV20.ReadOnly = true;
            tbV20.Size = new Size(288, 28);
            tbV20.TabIndex = 11;
            // 
            // tbK2
            // 
            tbK2.BackColor = Color.White;
            tbK2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbK2.Location = new Point(12, 41);
            tbK2.Name = "tbK2";
            tbK2.ReadOnly = true;
            tbK2.Size = new Size(53, 28);
            tbK2.TabIndex = 10;
            tbK2.Text = "EUR";
            // 
            // tbV32
            // 
            tbV32.BackColor = Color.White;
            tbV32.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbV32.Location = new Point(426, 65);
            tbV32.Name = "tbV32";
            tbV32.ReadOnly = true;
            tbV32.Size = new Size(119, 28);
            tbV32.TabIndex = 17;
            // 
            // tbV31
            // 
            tbV31.BackColor = Color.White;
            tbV31.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbV31.Location = new Point(349, 65);
            tbV31.Name = "tbV31";
            tbV31.ReadOnly = true;
            tbV31.Size = new Size(77, 28);
            tbV31.TabIndex = 16;
            // 
            // tbV30
            // 
            tbV30.BackColor = Color.White;
            tbV30.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbV30.Location = new Point(62, 65);
            tbV30.Name = "tbV30";
            tbV30.ReadOnly = true;
            tbV30.Size = new Size(288, 28);
            tbV30.TabIndex = 15;
            // 
            // tbK3
            // 
            tbK3.BackColor = Color.White;
            tbK3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbK3.Location = new Point(12, 65);
            tbK3.Name = "tbK3";
            tbK3.ReadOnly = true;
            tbK3.Size = new Size(53, 28);
            tbK3.TabIndex = 14;
            tbK3.Text = "GBP";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 729);
            Controls.Add(tbV32);
            Controls.Add(tbV31);
            Controls.Add(tbV30);
            Controls.Add(tbK3);
            Controls.Add(tbV22);
            Controls.Add(tbV21);
            Controls.Add(tbV20);
            Controls.Add(tbK2);
            Controls.Add(tbV12);
            Controls.Add(tbV11);
            Controls.Add(dgvR);
            Controls.Add(tbV10);
            Controls.Add(tbK1);
            Name = "Form1";
            Text = "Курсы валют";
            ((System.ComponentModel.ISupportInitialize)dgvR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbK1;
        private TextBox tbV10;
        private DataGridView dgvR;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox tbV11;
        private TextBox tbV12;
        private TextBox tbV22;
        private TextBox tbV21;
        private TextBox tbV20;
        private TextBox tbK2;
        private TextBox tbV32;
        private TextBox tbV31;
        private TextBox tbV30;
        private TextBox tbK3;
    }
}