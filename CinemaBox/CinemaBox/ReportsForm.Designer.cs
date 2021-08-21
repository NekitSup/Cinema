
namespace CinemaBox {
    partial class ReportsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.percentPieChartButt = new System.Windows.Forms.Button();
            this.pieChartButt = new System.Windows.Forms.Button();
            this.barChartButt = new System.Windows.Forms.Button();
            this.diagrammLab = new System.Windows.Forms.Label();
            this.printWord = new System.Windows.Forms.Button();
            this.yearCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yearLab = new System.Windows.Forms.Label();
            this.annualPeriodRB = new System.Windows.Forms.RadioButton();
            this.showReportButt = new System.Windows.Forms.Button();
            this.yearPeriodRB = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.quartPeriodRB = new System.Windows.Forms.RadioButton();
            this.endPeriodDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reportTypeCB = new System.Windows.Forms.ComboBox();
            this.initialPeriodDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mainDGV = new System.Windows.Forms.DataGridView();
            this.diagramChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.closeDiagramButt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramChart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.percentPieChartButt);
            this.panel1.Controls.Add(this.pieChartButt);
            this.panel1.Controls.Add(this.barChartButt);
            this.panel1.Controls.Add(this.diagrammLab);
            this.panel1.Controls.Add(this.printWord);
            this.panel1.Controls.Add(this.yearCB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.yearLab);
            this.panel1.Controls.Add(this.annualPeriodRB);
            this.panel1.Controls.Add(this.showReportButt);
            this.panel1.Controls.Add(this.yearPeriodRB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.quartPeriodRB);
            this.panel1.Controls.Add(this.endPeriodDateTimePicker);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.reportTypeCB);
            this.panel1.Controls.Add(this.initialPeriodDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(696, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 468);
            this.panel1.TabIndex = 6;
            // 
            // percentPieChartButt
            // 
            this.percentPieChartButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percentPieChartButt.Location = new System.Drawing.Point(190, 440);
            this.percentPieChartButt.Name = "percentPieChartButt";
            this.percentPieChartButt.Size = new System.Drawing.Size(23, 23);
            this.percentPieChartButt.TabIndex = 39;
            this.percentPieChartButt.Text = "%";
            this.percentPieChartButt.UseVisualStyleBackColor = true;
            this.percentPieChartButt.Click += new System.EventHandler(this.percentPieChartButt_Click);
            // 
            // pieChartButt
            // 
            this.pieChartButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pieChartButt.Location = new System.Drawing.Point(18, 440);
            this.pieChartButt.Name = "pieChartButt";
            this.pieChartButt.Size = new System.Drawing.Size(166, 23);
            this.pieChartButt.TabIndex = 37;
            this.pieChartButt.Text = "Круговая диаграмма";
            this.pieChartButt.UseVisualStyleBackColor = true;
            this.pieChartButt.Click += new System.EventHandler(this.pieChartButt_Click);
            // 
            // barChartButt
            // 
            this.barChartButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barChartButt.Location = new System.Drawing.Point(18, 415);
            this.barChartButt.Name = "barChartButt";
            this.barChartButt.Size = new System.Drawing.Size(166, 23);
            this.barChartButt.TabIndex = 36;
            this.barChartButt.Text = "Столбчатая диаграмма";
            this.barChartButt.UseVisualStyleBackColor = true;
            this.barChartButt.Click += new System.EventHandler(this.barChartButt_Click);
            // 
            // diagrammLab
            // 
            this.diagrammLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diagrammLab.Location = new System.Drawing.Point(20, 399);
            this.diagrammLab.Name = "diagrammLab";
            this.diagrammLab.Size = new System.Drawing.Size(130, 22);
            this.diagrammLab.TabIndex = 35;
            this.diagrammLab.Text = "Диаграммы";
            // 
            // printWord
            // 
            this.printWord.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printWord.Location = new System.Drawing.Point(78, 363);
            this.printWord.Name = "printWord";
            this.printWord.Size = new System.Drawing.Size(106, 33);
            this.printWord.TabIndex = 34;
            this.printWord.Text = "Печать";
            this.printWord.UseVisualStyleBackColor = true;
            this.printWord.Click += new System.EventHandler(this.printWord_Click);
            // 
            // yearCB
            // 
            this.yearCB.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearCB.FormattingEnabled = true;
            this.yearCB.Items.AddRange(new object[] {
            "2020",
            "2021"});
            this.yearCB.Location = new System.Drawing.Point(23, 331);
            this.yearCB.Name = "yearCB";
            this.yearCB.Size = new System.Drawing.Size(198, 26);
            this.yearCB.TabIndex = 33;
            this.yearCB.SelectedIndexChanged += new System.EventHandler(this.yearCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Панель фильтрации";
            // 
            // yearLab
            // 
            this.yearLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLab.Location = new System.Drawing.Point(23, 297);
            this.yearLab.Name = "yearLab";
            this.yearLab.Size = new System.Drawing.Size(94, 34);
            this.yearLab.TabIndex = 32;
            this.yearLab.Text = "Год для выручки";
            // 
            // annualPeriodRB
            // 
            this.annualPeriodRB.AutoSize = true;
            this.annualPeriodRB.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.annualPeriodRB.Location = new System.Drawing.Point(26, 48);
            this.annualPeriodRB.Name = "annualPeriodRB";
            this.annualPeriodRB.Size = new System.Drawing.Size(124, 22);
            this.annualPeriodRB.TabIndex = 23;
            this.annualPeriodRB.TabStop = true;
            this.annualPeriodRB.Text = "Выбранный период";
            this.annualPeriodRB.UseVisualStyleBackColor = true;
            this.annualPeriodRB.CheckedChanged += new System.EventHandler(this.annualPeriodRB_CheckedChanged);
            // 
            // showReportButt
            // 
            this.showReportButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showReportButt.Location = new System.Drawing.Point(123, 287);
            this.showReportButt.Name = "showReportButt";
            this.showReportButt.Size = new System.Drawing.Size(100, 38);
            this.showReportButt.TabIndex = 31;
            this.showReportButt.Text = "Отобразить";
            this.showReportButt.UseVisualStyleBackColor = true;
            this.showReportButt.Click += new System.EventHandler(this.showReportButt_Click);
            // 
            // yearPeriodRB
            // 
            this.yearPeriodRB.AutoSize = true;
            this.yearPeriodRB.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearPeriodRB.Location = new System.Drawing.Point(26, 76);
            this.yearPeriodRB.Name = "yearPeriodRB";
            this.yearPeriodRB.Size = new System.Drawing.Size(67, 22);
            this.yearPeriodRB.TabIndex = 24;
            this.yearPeriodRB.TabStop = true;
            this.yearPeriodRB.Text = "Годовой";
            this.yearPeriodRB.UseVisualStyleBackColor = true;
            this.yearPeriodRB.CheckedChanged += new System.EventHandler(this.yearPeriodRB_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(27, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Конечный период";
            // 
            // quartPeriodRB
            // 
            this.quartPeriodRB.AutoSize = true;
            this.quartPeriodRB.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quartPeriodRB.Location = new System.Drawing.Point(26, 104);
            this.quartPeriodRB.Name = "quartPeriodRB";
            this.quartPeriodRB.Size = new System.Drawing.Size(93, 22);
            this.quartPeriodRB.TabIndex = 25;
            this.quartPeriodRB.TabStop = true;
            this.quartPeriodRB.Text = "Квартальный";
            this.quartPeriodRB.UseVisualStyleBackColor = true;
            this.quartPeriodRB.CheckedChanged += new System.EventHandler(this.quartPeriodRB_CheckedChanged);
            // 
            // endPeriodDateTimePicker
            // 
            this.endPeriodDateTimePicker.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endPeriodDateTimePicker.Location = new System.Drawing.Point(23, 258);
            this.endPeriodDateTimePicker.Name = "endPeriodDateTimePicker";
            this.endPeriodDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.endPeriodDateTimePicker.TabIndex = 29;
            this.endPeriodDateTimePicker.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Данные для отчета";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(27, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Начальный период";
            // 
            // reportTypeCB
            // 
            this.reportTypeCB.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportTypeCB.FormattingEnabled = true;
            this.reportTypeCB.Items.AddRange(new object[] {
            "Название фильма",
            "Тип фильма",
            "Кол-во проданных билетов"});
            this.reportTypeCB.Location = new System.Drawing.Point(23, 158);
            this.reportTypeCB.Name = "reportTypeCB";
            this.reportTypeCB.Size = new System.Drawing.Size(198, 27);
            this.reportTypeCB.TabIndex = 22;
            this.reportTypeCB.SelectedIndexChanged += new System.EventHandler(this.reportTypeCB_SelectedIndexChanged);
            // 
            // initialPeriodDateTimePicker
            // 
            this.initialPeriodDateTimePicker.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.initialPeriodDateTimePicker.Location = new System.Drawing.Point(23, 210);
            this.initialPeriodDateTimePicker.Name = "initialPeriodDateTimePicker";
            this.initialPeriodDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.initialPeriodDateTimePicker.TabIndex = 27;
            this.initialPeriodDateTimePicker.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // mainDGV
            // 
            this.mainDGV.BackgroundColor = System.Drawing.Color.Silver;
            this.mainDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.mainDGV.Location = new System.Drawing.Point(12, 7);
            this.mainDGV.Name = "mainDGV";
            this.mainDGV.Size = new System.Drawing.Size(678, 468);
            this.mainDGV.TabIndex = 7;
            // 
            // diagramChart
            // 
            this.diagramChart.BackColor = System.Drawing.Color.Silver;
            this.diagramChart.BackSecondaryColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.diagramChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.diagramChart.Legends.Add(legend1);
            this.diagramChart.Location = new System.Drawing.Point(12, 7);
            this.diagramChart.Name = "diagramChart";
            this.diagramChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.diagramChart.Series.Add(series1);
            this.diagramChart.Size = new System.Drawing.Size(678, 468);
            this.diagramChart.TabIndex = 8;
            this.diagramChart.Text = "chart1";
            // 
            // closeDiagramButt
            // 
            this.closeDiagramButt.Location = new System.Drawing.Point(613, 450);
            this.closeDiagramButt.Name = "closeDiagramButt";
            this.closeDiagramButt.Size = new System.Drawing.Size(75, 23);
            this.closeDiagramButt.TabIndex = 9;
            this.closeDiagramButt.Text = "Close";
            this.closeDiagramButt.UseVisualStyleBackColor = true;
            this.closeDiagramButt.Click += new System.EventHandler(this.closeDiagramButt_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(939, 490);
            this.Controls.Add(this.closeDiagramButt);
            this.Controls.Add(this.diagramChart);
            this.Controls.Add(this.mainDGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет о выручке";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button printWord;
        private System.Windows.Forms.ComboBox yearCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label yearLab;
        private System.Windows.Forms.RadioButton annualPeriodRB;
        private System.Windows.Forms.Button showReportButt;
        private System.Windows.Forms.RadioButton yearPeriodRB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton quartPeriodRB;
        private System.Windows.Forms.DateTimePicker endPeriodDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox reportTypeCB;
        private System.Windows.Forms.DateTimePicker initialPeriodDateTimePicker;
        private System.Windows.Forms.DataGridView mainDGV;
        private System.Windows.Forms.Button pieChartButt;
        private System.Windows.Forms.Button barChartButt;
        private System.Windows.Forms.Label diagrammLab;
        private System.Windows.Forms.DataVisualization.Charting.Chart diagramChart;
        private System.Windows.Forms.Button closeDiagramButt;
        private System.Windows.Forms.Button percentPieChartButt;
    }
}