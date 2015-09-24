namespace Lab_01_Chart
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabsId = new System.Windows.Forms.TabControl();
            this.settingTab = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resetSettingsBtn = new System.Windows.Forms.Button();
            this.pointCountTextBox = new System.Windows.Forms.TextBox();
            this.endNumTextBox = new System.Windows.Forms.TextBox();
            this.startNumTextBox = new System.Windows.Forms.TextBox();
            this.drawBtn = new System.Windows.Forms.Button();
            this.chartTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabsId.SuspendLayout();
            this.settingTab.SuspendLayout();
            this.chartTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.LightGray;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.Minimum = 1D;
            chartArea1.AxisX.Title = "Отсчеты";
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.Title = "Время сортировки (мс)";
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Silver;
            chartArea1.BorderColor = System.Drawing.Color.LightGray;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Типы сортировок";
            legend1.Title = "Типы сортировок:";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Типы сортировок";
            series1.Name = "Array.Sort()";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.Legend = "Типы сортировок";
            series2.Name = "QuickSort";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Типы сортировок";
            series3.Name = "Heapsort";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Lime;
            series4.Legend = "Типы сортировок";
            series4.Name = "Shellsort";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(460, 400);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chartId";
            // 
            // tabsId
            // 
            this.tabsId.Controls.Add(this.settingTab);
            this.tabsId.Controls.Add(this.chartTab);
            this.tabsId.Location = new System.Drawing.Point(12, 12);
            this.tabsId.Name = "tabsId";
            this.tabsId.SelectedIndex = 0;
            this.tabsId.Size = new System.Drawing.Size(481, 438);
            this.tabsId.TabIndex = 1;
            // 
            // settingTab
            // 
            this.settingTab.Controls.Add(this.button2);
            this.settingTab.Controls.Add(this.button1);
            this.settingTab.Controls.Add(this.label4);
            this.settingTab.Controls.Add(this.progressBar1);
            this.settingTab.Controls.Add(this.label3);
            this.settingTab.Controls.Add(this.label2);
            this.settingTab.Controls.Add(this.label1);
            this.settingTab.Controls.Add(this.resetSettingsBtn);
            this.settingTab.Controls.Add(this.pointCountTextBox);
            this.settingTab.Controls.Add(this.endNumTextBox);
            this.settingTab.Controls.Add(this.startNumTextBox);
            this.settingTab.Controls.Add(this.drawBtn);
            this.settingTab.Location = new System.Drawing.Point(4, 22);
            this.settingTab.Name = "settingTab";
            this.settingTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingTab.Size = new System.Drawing.Size(473, 412);
            this.settingTab.TabIndex = 0;
            this.settingTab.Text = "Настройки";
            this.settingTab.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(246, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Остановить выполнение задачи";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(246, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Значения по-умолчанию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Прогресс выполнения задачи:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 160);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(460, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество точек:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Конечный размер:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Начальный размер:";
            // 
            // resetSettingsBtn
            // 
            this.resetSettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetSettingsBtn.Location = new System.Drawing.Point(246, 13);
            this.resetSettingsBtn.Name = "resetSettingsBtn";
            this.resetSettingsBtn.Size = new System.Drawing.Size(220, 34);
            this.resetSettingsBtn.TabIndex = 4;
            this.resetSettingsBtn.Text = "Сбросить настройки";
            this.resetSettingsBtn.UseVisualStyleBackColor = true;
            this.resetSettingsBtn.Click += new System.EventHandler(this.resetSettingsBtn_Click);
            // 
            // pointCountTextBox
            // 
            this.pointCountTextBox.Location = new System.Drawing.Point(131, 65);
            this.pointCountTextBox.MaxLength = 4;
            this.pointCountTextBox.Name = "pointCountTextBox";
            this.pointCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.pointCountTextBox.TabIndex = 3;
            this.pointCountTextBox.Text = "10";
            // 
            // endNumTextBox
            // 
            this.endNumTextBox.Location = new System.Drawing.Point(131, 39);
            this.endNumTextBox.MaxLength = 20;
            this.endNumTextBox.Name = "endNumTextBox";
            this.endNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.endNumTextBox.TabIndex = 2;
            this.endNumTextBox.Text = "100000";
            // 
            // startNumTextBox
            // 
            this.startNumTextBox.Location = new System.Drawing.Point(131, 13);
            this.startNumTextBox.MaxLength = 19;
            this.startNumTextBox.Name = "startNumTextBox";
            this.startNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.startNumTextBox.TabIndex = 1;
            this.startNumTextBox.Text = "1000";
            // 
            // drawBtn
            // 
            this.drawBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawBtn.Location = new System.Drawing.Point(20, 91);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(211, 36);
            this.drawBtn.TabIndex = 0;
            this.drawBtn.Text = "Построить график";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartTab
            // 
            this.chartTab.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chartTab.Controls.Add(this.chart1);
            this.chartTab.Location = new System.Drawing.Point(4, 22);
            this.chartTab.Name = "chartTab";
            this.chartTab.Padding = new System.Windows.Forms.Padding(3);
            this.chartTab.Size = new System.Drawing.Size(473, 412);
            this.chartTab.TabIndex = 1;
            this.chartTab.Text = "График";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(498, 456);
            this.Controls.Add(this.tabsId);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №1, Силаков И., ИТД-111";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabsId.ResumeLayout(false);
            this.settingTab.ResumeLayout(false);
            this.settingTab.PerformLayout();
            this.chartTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabControl tabsId;
        private System.Windows.Forms.TabPage settingTab;
        private System.Windows.Forms.Button resetSettingsBtn;
        private System.Windows.Forms.TextBox pointCountTextBox;
        private System.Windows.Forms.TextBox endNumTextBox;
        private System.Windows.Forms.TextBox startNumTextBox;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.TabPage chartTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

