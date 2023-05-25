namespace NKISLab04
{
    partial class FormUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbUserThis = new System.Windows.Forms.TextBox();
            this.tbPasswordThis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbWorkPh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbHomeAdr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbHomePh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbF = new System.Windows.Forms.TextBox();
            this.btToFirst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пользователь";
            // 
            // tbUserThis
            // 
            this.tbUserThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUserThis.Location = new System.Drawing.Point(177, 7);
            this.tbUserThis.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserThis.Name = "tbUserThis";
            this.tbUserThis.Size = new System.Drawing.Size(312, 22);
            this.tbUserThis.TabIndex = 1;
            // 
            // tbPasswordThis
            // 
            this.tbPasswordThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPasswordThis.Location = new System.Drawing.Point(177, 41);
            this.tbPasswordThis.Margin = new System.Windows.Forms.Padding(2);
            this.tbPasswordThis.Name = "tbPasswordThis";
            this.tbPasswordThis.PasswordChar = 'X';
            this.tbPasswordThis.Size = new System.Drawing.Size(312, 22);
            this.tbPasswordThis.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // btLogin
            // 
            this.btLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btLogin.FlatAppearance.BorderSize = 4;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLogin.Location = new System.Drawing.Point(5, 72);
            this.btLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(150, 31);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Вход";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btNext
            // 
            this.btNext.Enabled = false;
            this.btNext.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btNext.FlatAppearance.BorderSize = 4;
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btNext.Location = new System.Drawing.Point(177, 72);
            this.btNext.Margin = new System.Windows.Forms.Padding(2);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(150, 34);
            this.btNext.TabIndex = 5;
            this.btNext.Text = "Следующая запись";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btDel
            // 
            this.btDel.Enabled = false;
            this.btDel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btDel.FlatAppearance.BorderSize = 4;
            this.btDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDel.Location = new System.Drawing.Point(10, 405);
            this.btDel.Margin = new System.Windows.Forms.Padding(2);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(85, 34);
            this.btDel.TabIndex = 6;
            this.btDel.Text = "Удалить";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btAdd
            // 
            this.btAdd.Enabled = false;
            this.btAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btAdd.FlatAppearance.BorderSize = 4;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAdd.Location = new System.Drawing.Point(108, 405);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(94, 34);
            this.btAdd.TabIndex = 7;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btSave.FlatAppearance.BorderSize = 4;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSave.Location = new System.Drawing.Point(281, 405);
            this.btSave.Margin = new System.Windows.Forms.Padding(2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(93, 34);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Enabled = false;
            this.btCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btCancel.FlatAppearance.BorderSize = 4;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCancel.Location = new System.Drawing.Point(387, 405);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(98, 34);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Отменить";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пользователь";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Фамилия";
            // 
            // tbI
            // 
            this.tbI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbI.Location = new System.Drawing.Point(177, 175);
            this.tbI.Margin = new System.Windows.Forms.Padding(2);
            this.tbI.Name = "tbI";
            this.tbI.Size = new System.Drawing.Size(467, 26);
            this.tbI.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(9, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Имя";
            // 
            // tbO
            // 
            this.tbO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbO.Location = new System.Drawing.Point(177, 202);
            this.tbO.Margin = new System.Windows.Forms.Padding(2);
            this.tbO.Name = "tbO";
            this.tbO.Size = new System.Drawing.Size(467, 24);
            this.tbO.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 200);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Отчество";
            // 
            // tbPosition
            // 
            this.tbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPosition.Location = new System.Drawing.Point(177, 228);
            this.tbPosition.Margin = new System.Windows.Forms.Padding(2);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(467, 24);
            this.tbPosition.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 227);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Должность";
            // 
            // tbWorkPh
            // 
            this.tbWorkPh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbWorkPh.Location = new System.Drawing.Point(177, 258);
            this.tbWorkPh.Margin = new System.Windows.Forms.Padding(2);
            this.tbWorkPh.Name = "tbWorkPh";
            this.tbWorkPh.Size = new System.Drawing.Size(467, 24);
            this.tbWorkPh.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(9, 257);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Телефон";
            // 
            // tbHomeAdr
            // 
            this.tbHomeAdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbHomeAdr.Location = new System.Drawing.Point(177, 286);
            this.tbHomeAdr.Margin = new System.Windows.Forms.Padding(2);
            this.tbHomeAdr.Name = "tbHomeAdr";
            this.tbHomeAdr.Size = new System.Drawing.Size(467, 24);
            this.tbHomeAdr.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(9, 285);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Адрес";
            // 
            // tbHomePh
            // 
            this.tbHomePh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbHomePh.Location = new System.Drawing.Point(177, 315);
            this.tbHomePh.Margin = new System.Windows.Forms.Padding(2);
            this.tbHomePh.Name = "tbHomePh";
            this.tbHomePh.Size = new System.Drawing.Size(467, 24);
            this.tbHomePh.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(9, 314);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "Телефон дом.";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(9, 345);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 18);
            this.label11.TabIndex = 26;
            this.label11.Text = "Группа";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(177, 374);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(467, 24);
            this.tbPassword.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(9, 373);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 18);
            this.label12.TabIndex = 27;
            this.label12.Text = "Пароль";
            // 
            // cbGroup
            // 
            this.cbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbGroup.Location = new System.Drawing.Point(177, 344);
            this.cbGroup.Margin = new System.Windows.Forms.Padding(2);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(68, 26);
            this.cbGroup.TabIndex = 30;
            // 
            // tbUser
            // 
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUser.Location = new System.Drawing.Point(177, 122);
            this.tbUser.Margin = new System.Windows.Forms.Padding(2);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(467, 26);
            this.tbUser.TabIndex = 32;
            // 
            // tbF
            // 
            this.tbF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbF.Location = new System.Drawing.Point(177, 148);
            this.tbF.Margin = new System.Windows.Forms.Padding(2);
            this.tbF.Name = "tbF";
            this.tbF.Size = new System.Drawing.Size(467, 26);
            this.tbF.TabIndex = 32;
            // 
            // btToFirst
            // 
            this.btToFirst.Enabled = false;
            this.btToFirst.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btToFirst.FlatAppearance.BorderSize = 4;
            this.btToFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btToFirst.Location = new System.Drawing.Point(339, 72);
            this.btToFirst.Margin = new System.Windows.Forms.Padding(2);
            this.btToFirst.Name = "btToFirst";
            this.btToFirst.Size = new System.Drawing.Size(150, 34);
            this.btToFirst.TabIndex = 33;
            this.btToFirst.Text = "В начало";
            this.btToFirst.UseVisualStyleBackColor = true;
            this.btToFirst.Click += new System.EventHandler(this.btToFirst_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btToFirst);
            this.Controls.Add(this.tbF);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbHomePh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbHomeAdr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbWorkPh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbPasswordThis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUserThis);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUserThis;
        private System.Windows.Forms.TextBox tbPasswordThis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbWorkPh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbHomeAdr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbHomePh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbGroup;
        private TextBox tbUser;
        private TextBox tbF;
        private Button btToFirst;
    }
}