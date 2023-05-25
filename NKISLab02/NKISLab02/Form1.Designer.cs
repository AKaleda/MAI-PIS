namespace NKISLab02
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.nudStep = new System.Windows.Forms.NumericUpDown();
            this.btStart = new System.Windows.Forms.Button();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMax = new System.Windows.Forms.CheckBox();
            this.cbMin = new System.Windows.Forms.CheckBox();
            this.cbKratno = new System.Windows.Forms.CheckBox();
            this.nudKratno = new System.Windows.Forms.NumericUpDown();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.btReview = new System.Windows.Forms.Button();
            this.dgvLasts = new System.Windows.Forms.DataGridView();
            this.t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSelected = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Признак = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.nudProc = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKratno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLasts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(18, 309);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Данные";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Среднее";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(596, 263);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество отображаемых данных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Шаг по времени (сек)";
            // 
            // nudMin
            // 
            this.nudMin.DecimalPlaces = 1;
            this.nudMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMin.Location = new System.Drawing.Point(340, 183);
            this.nudMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(82, 31);
            this.nudMin.TabIndex = 2;
            this.nudMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.nudMin.ValueChanged += new System.EventHandler(this.nudMin_ValueChanged);
            // 
            // nudMax
            // 
            this.nudMax.DecimalPlaces = 1;
            this.nudMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMax.Location = new System.Drawing.Point(340, 146);
            this.nudMax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(82, 31);
            this.nudMax.TabIndex = 2;
            this.nudMax.Value = new decimal(new int[] {
            35,
            0,
            0,
            65536});
            this.nudMax.ValueChanged += new System.EventHandler(this.nudMax_ValueChanged);
            // 
            // nudStep
            // 
            this.nudStep.DecimalPlaces = 1;
            this.nudStep.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudStep.Location = new System.Drawing.Point(340, 2);
            this.nudStep.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudStep.Name = "nudStep";
            this.nudStep.Size = new System.Drawing.Size(82, 31);
            this.nudStep.TabIndex = 2;
            this.nudStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(18, 264);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(116, 31);
            this.btStart.TabIndex = 3;
            this.btStart.Text = "Старт";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // nudN
            // 
            this.nudN.Location = new System.Drawing.Point(340, 40);
            this.nudN.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudN.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(82, 31);
            this.nudN.TabIndex = 4;
            this.nudN.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Условия выборочных данных:";
            // 
            // cbMax
            // 
            this.cbMax.AutoSize = true;
            this.cbMax.Checked = true;
            this.cbMax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMax.Location = new System.Drawing.Point(17, 144);
            this.cbMax.Name = "cbMax";
            this.cbMax.Size = new System.Drawing.Size(184, 29);
            this.cbMax.TabIndex = 7;
            this.cbMax.Text = "Верхнее значение";
            this.cbMax.UseVisualStyleBackColor = true;
            this.cbMax.CheckedChanged += new System.EventHandler(this.cbMax_CheckedChanged);
            // 
            // cbMin
            // 
            this.cbMin.AutoSize = true;
            this.cbMin.Checked = true;
            this.cbMin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMin.Location = new System.Drawing.Point(17, 183);
            this.cbMin.Name = "cbMin";
            this.cbMin.Size = new System.Drawing.Size(182, 29);
            this.cbMin.TabIndex = 8;
            this.cbMin.Text = "Нижнее значение";
            this.cbMin.UseVisualStyleBackColor = true;
            this.cbMin.CheckedChanged += new System.EventHandler(this.cbMin_CheckedChanged);
            // 
            // cbKratno
            // 
            this.cbKratno.AutoSize = true;
            this.cbKratno.Checked = true;
            this.cbKratno.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbKratno.Location = new System.Drawing.Point(17, 220);
            this.cbKratno.Name = "cbKratno";
            this.cbKratno.Size = new System.Drawing.Size(317, 29);
            this.cbKratno.TabIndex = 9;
            this.cbKratno.Text = "Значение для контроля кратности";
            this.cbKratno.UseVisualStyleBackColor = true;
            this.cbKratno.CheckedChanged += new System.EventHandler(this.cbKratno_CheckedChanged);
            // 
            // nudKratno
            // 
            this.nudKratno.DecimalPlaces = 1;
            this.nudKratno.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudKratno.Location = new System.Drawing.Point(340, 220);
            this.nudKratno.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudKratno.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudKratno.Name = "nudKratno";
            this.nudKratno.Size = new System.Drawing.Size(82, 31);
            this.nudKratno.TabIndex = 10;
            this.nudKratno.Value = new decimal(new int[] {
            19,
            0,
            0,
            65536});
            this.nudKratno.ValueChanged += new System.EventHandler(this.nudKratno_ValueChanged);
            // 
            // tbTime
            // 
            this.tbTime.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTime.Location = new System.Drawing.Point(140, 267);
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(194, 30);
            this.tbTime.TabIndex = 11;
            // 
            // btReview
            // 
            this.btReview.Enabled = false;
            this.btReview.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btReview.Location = new System.Drawing.Point(502, 164);
            this.btReview.Name = "btReview";
            this.btReview.Size = new System.Drawing.Size(94, 120);
            this.btReview.TabIndex = 12;
            this.btReview.Text = "Сигнал от таймера";
            this.btReview.UseVisualStyleBackColor = true;
            this.btReview.Click += new System.EventHandler(this.btReview_Click);
            // 
            // dgvLasts
            // 
            this.dgvLasts.AllowUserToAddRows = false;
            this.dgvLasts.AllowUserToDeleteRows = false;
            this.dgvLasts.AllowUserToOrderColumns = true;
            this.dgvLasts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLasts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLasts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t,
            this.v});
            this.dgvLasts.Location = new System.Drawing.Point(459, 30);
            this.dgvLasts.Name = "dgvLasts";
            this.dgvLasts.RowHeadersVisible = false;
            this.dgvLasts.RowHeadersWidth = 62;
            this.dgvLasts.RowTemplate.Height = 20;
            this.dgvLasts.Size = new System.Drawing.Size(155, 265);
            this.dgvLasts.TabIndex = 13;
            // 
            // t
            // 
            this.t.Frozen = true;
            this.t.HeaderText = " -t ";
            this.t.MinimumWidth = 8;
            this.t.Name = "t";
            this.t.ReadOnly = true;
            this.t.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.t.Width = 50;
            // 
            // v
            // 
            this.v.Frozen = true;
            this.v.HeaderText = "Значение";
            this.v.MinimumWidth = 8;
            this.v.Name = "v";
            this.v.ReadOnly = true;
            this.v.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.v.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(454, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Последние данные";
            // 
            // dgvSelected
            // 
            this.dgvSelected.AllowUserToAddRows = false;
            this.dgvSelected.AllowUserToDeleteRows = false;
            this.dgvSelected.AllowUserToOrderColumns = true;
            this.dgvSelected.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Признак});
            this.dgvSelected.Location = new System.Drawing.Point(650, 30);
            this.dgvSelected.Name = "dgvSelected";
            this.dgvSelected.RowHeadersVisible = false;
            this.dgvSelected.RowHeadersWidth = 80;
            this.dgvSelected.RowTemplate.Height = 20;
            this.dgvSelected.Size = new System.Drawing.Size(225, 265);
            this.dgvSelected.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "t Отн";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Значение";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // Признак
            // 
            this.Признак.HeaderText = "Признак";
            this.Признак.MinimumWidth = 8;
            this.Признак.Name = "Признак";
            this.Признак.ReadOnly = true;
            this.Признак.Width = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(645, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Выборочные данные";
            // 
            // nudProc
            // 
            this.nudProc.Location = new System.Drawing.Point(341, 76);
            this.nudProc.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudProc.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudProc.Name = "nudProc";
            this.nudProc.Size = new System.Drawing.Size(82, 31);
            this.nudProc.TabIndex = 18;
            this.nudProc.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudProc.ValueChanged += new System.EventHandler(this.nudProc_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Контроль изменения данных (%)";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(650, 312);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Выб. данные";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(388, 260);
            this.chart2.TabIndex = 19;
            this.chart2.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 584);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.nudProc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvSelected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLasts);
            this.Controls.Add(this.btReview);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.nudKratno);
            this.Controls.Add(this.cbKratno);
            this.Controls.Add(this.cbMin);
            this.Controls.Add(this.cbMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudN);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.nudStep);
            this.Controls.Add(this.nudMax);
            this.Controls.Add(this.nudMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "АРМ контроля данных";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKratno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLasts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.NumericUpDown nudStep;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbMax;
        private System.Windows.Forms.CheckBox cbMin;
        private System.Windows.Forms.CheckBox cbKratno;
        private System.Windows.Forms.NumericUpDown nudKratno;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Button btReview;
        private System.Windows.Forms.DataGridView dgvLasts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSelected;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Признак;
        private System.Windows.Forms.DataGridViewTextBoxColumn t;
        private System.Windows.Forms.DataGridViewTextBoxColumn v;
        private System.Windows.Forms.NumericUpDown nudProc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

