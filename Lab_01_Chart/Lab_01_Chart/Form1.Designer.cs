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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabsId = new System.Windows.Forms.TabControl();
            this.settingTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resetSettingsBtn = new System.Windows.Forms.Button();
            this.pointCountTextBox = new System.Windows.Forms.TextBox();
            this.endNumTextBox = new System.Windows.Forms.TextBox();
            this.startNumTextBox = new System.Windows.Forms.TextBox();
            this.drawBtn = new System.Windows.Forms.Button();
            this.chartTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabsId.SuspendLayout();
            this.settingTab.SuspendLayout();
            this.chartTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.Name = "Series2";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.Name = "Series3";
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(460, 368);
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
            this.tabsId.Size = new System.Drawing.Size(480, 438);
            this.tabsId.TabIndex = 1;
            // 
            // settingTab
            // 
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
            this.settingTab.Size = new System.Drawing.Size(472, 412);
            this.settingTab.TabIndex = 0;
            this.settingTab.Text = "Настройки";
            this.settingTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество точек:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Конечный размер:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Начальный размер:";
            // 
            // resetSettingsBtn
            // 
            this.resetSettingsBtn.Location = new System.Drawing.Point(234, 89);
            this.resetSettingsBtn.Name = "resetSettingsBtn";
            this.resetSettingsBtn.Size = new System.Drawing.Size(100, 36);
            this.resetSettingsBtn.TabIndex = 4;
            this.resetSettingsBtn.Text = "Сбросить настройки";
            this.resetSettingsBtn.UseVisualStyleBackColor = true;
            this.resetSettingsBtn.Click += new System.EventHandler(this.resetSettingsBtn_Click);
            // 
            // pointCountTextBox
            // 
            this.pointCountTextBox.Location = new System.Drawing.Point(234, 63);
            this.pointCountTextBox.Name = "pointCountTextBox";
            this.pointCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.pointCountTextBox.TabIndex = 3;
            this.pointCountTextBox.Text = "10";
            // 
            // endNumTextBox
            // 
            this.endNumTextBox.Location = new System.Drawing.Point(234, 37);
            this.endNumTextBox.Name = "endNumTextBox";
            this.endNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.endNumTextBox.TabIndex = 2;
            this.endNumTextBox.Text = "10000";
            // 
            // startNumTextBox
            // 
            this.startNumTextBox.Location = new System.Drawing.Point(234, 11);
            this.startNumTextBox.Name = "startNumTextBox";
            this.startNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.startNumTextBox.TabIndex = 1;
            this.startNumTextBox.Text = "10";
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(123, 89);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(105, 36);
            this.drawBtn.TabIndex = 0;
            this.drawBtn.Text = "Построить график";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartTab
            // 
            this.chartTab.BackColor = System.Drawing.Color.SkyBlue;
            this.chartTab.Controls.Add(this.button1);
            this.chartTab.Controls.Add(this.chart1);
            this.chartTab.Location = new System.Drawing.Point(4, 22);
            this.chartTab.Name = "chartTab";
            this.chartTab.Padding = new System.Windows.Forms.Padding(3);
            this.chartTab.Size = new System.Drawing.Size(472, 412);
            this.chartTab.TabIndex = 1;
            this.chartTab.Text = "График";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(498, 451);
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
        private System.Windows.Forms.Button button1;
    }
}

