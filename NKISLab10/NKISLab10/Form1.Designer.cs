namespace NKISLab10
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
            dtPicker = new DateTimePicker();
            dgvCredits = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            tbTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCredits).BeginInit();
            SuspendLayout();
            // 
            // dtPicker
            // 
            dtPicker.CustomFormat = "";
            dtPicker.Format = DateTimePickerFormat.Short;
            dtPicker.Location = new Point(419, 9);
            dtPicker.Margin = new Padding(4, 3, 4, 3);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(171, 30);
            dtPicker.TabIndex = 0;
            dtPicker.ValueChanged += dtPicker_ValueChanged;
            // 
            // dgvCredits
            // 
            dgvCredits.AllowUserToAddRows = false;
            dgvCredits.BackgroundColor = Color.White;
            dgvCredits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCredits.Location = new Point(26, 90);
            dgvCredits.Margin = new Padding(4, 3, 4, 3);
            dgvCredits.Name = "dgvCredits";
            dgvCredits.ReadOnly = true;
            dgvCredits.RowHeadersWidth = 62;
            dgvCredits.RowTemplate.Height = 33;
            dgvCredits.Size = new Size(564, 331);
            dgvCredits.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(368, 23);
            label1.TabIndex = 3;
            label1.Text = "Под отчет получено до (включительно)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 47);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 4;
            label2.Text = "Всего";
            // 
            // tbTotal
            // 
            tbTotal.BackColor = Color.White;
            tbTotal.Location = new Point(243, 44);
            tbTotal.Name = "tbTotal";
            tbTotal.ReadOnly = true;
            tbTotal.Size = new Size(142, 30);
            tbTotal.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 414);
            Controls.Add(tbTotal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCredits);
            Controls.Add(dtPicker);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Подотчетники";
            ((System.ComponentModel.ISupportInitialize)dgvCredits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtPicker;
        private DataGridView dgvCredits;
        private Label label1;
        private Label label2;
        private TextBox tbTotal;
    }
}