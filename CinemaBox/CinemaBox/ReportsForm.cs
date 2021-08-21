using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;


namespace CinemaBox {
    public partial class ReportsForm : Form {
        DataBaseSQL sql;

        public ReportsForm() {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e) {
            sql = new DataBaseSQL();
            sql.ConnectToBD();

            annualPeriodRB.Checked = true;
            reportTypeCB.SelectedIndex = 0;
            yearCB.SelectedIndex = 1;
            annualPeriodProduct();

            diagramChart.Visible = false;
            closeDiagramButt.Visible = false;
        }

        void annualPeriodProduct() {
            string initialDate = initialPeriodDateTimePicker.Value.Year + "/" + initialPeriodDateTimePicker.Value.Month + "/" + initialPeriodDateTimePicker.Value.Day;
            string endDate = endPeriodDateTimePicker.Value.Year + "/" + endPeriodDateTimePicker.Value.Month + "/" + endPeriodDateTimePicker.Value.Day;

            sql.TransformSQL("sum(t.TicketPrice)", "f.FilmName as [Название фильма], sum(t.TicketPrice) as [Сумма]"
                , "Tickets t inner join Films f on t.ID_Film = f.ID_Film"
                , $"t.SessionDate >= #{initialDate}# and t.SessionDate <= #{endDate}#"
                , "f.FilmName, SessionDate", "SessionDate", "SessionDate&' '&SessionTime", mainDGV, this);
        }

        void annualPeriodCat() {
            string initialDate = initialPeriodDateTimePicker.Value.Year + "/" + initialPeriodDateTimePicker.Value.Month + "/" + initialPeriodDateTimePicker.Value.Day;
            string endDate = endPeriodDateTimePicker.Value.Year + "/" + endPeriodDateTimePicker.Value.Month + "/" + endPeriodDateTimePicker.Value.Day;

            sql.TransformSQL("sum(t.TicketPrice)", "type.TypeName as [Тип фильма], sum(t.TicketPrice) as [Сумма]"
                , "(Tickets t inner join Films f on t.ID_Film = f.ID_Film)" +
                " inner join Types type on f.FilmType = type.TypeCode"
                , $"t.SessionDate >= #{initialDate}# and t.SessionDate <= #{endDate}#"
                , "type.TypeName, SessionDate", "SessionDate", "SessionDate&' '&SessionTime", mainDGV, this);
        }

        void yearPeriodProduct() {
            int date = 0;
            if (yearCB.SelectedIndex == 0) date = 2020;
            else if (yearCB.SelectedIndex == 1) date = 2021;

            sql.TransformSQL("sum(t.TicketPrice)", "f.FilmName as [Название фильма], sum(t.TicketPrice) as [Сумма]"
                , "Tickets t inner join Films f on t.ID_Film = f.ID_Film"
                , $"year(SessionDate) = {date}"
                , "f.FilmName, SessionDate", "SessionDate", "format(t.SessionDate, 'mmmm')", mainDGV, this);
        }

        void yearPeriodCat() {
            int date = 0;
            if (yearCB.SelectedIndex == 0) date = 2020;
            else if (yearCB.SelectedIndex == 1) date = 2021;

            sql.TransformSQL("sum(t.TicketPrice)", "type.TypeName as [Тип фильма], sum(t.TicketPrice) as [Сумма]"
                , "(Tickets t inner join Films f on t.ID_Film = f.ID_Film)" +
                " inner join Types type on f.FilmType = type.TypeCode"
                , $"year(t.SessionDate) = {date}"
                , "type.TypeName, SessionDate", "SessionDate", "format(t.SessionDate, 'mmmm')", mainDGV, this);
        }

        void quartPeriodProduct() {
            int date = 0;
            if (yearCB.SelectedIndex == 0) date = 2020;
            else if (yearCB.SelectedIndex == 1) date = 2021;

            sql.TransformSQL("sum(t.TicketPrice)", "f.FilmName as [Название фильма], sum(t.TicketPrice) as [Сумма]"
                , "Tickets t inner join Films f on t.ID_Film = f.ID_Film"
                , $"year(SessionDate) = {date}"
                , "f.FilmName, SessionDate", "SessionDate", "'Квартал'&format(SessionDate, 'q') in(Квартал1, Квартал2, Квартал3, Квартал4)", mainDGV, this);
        }

        void quartPeriodCat() {
            int date = 0;
            if (yearCB.SelectedIndex == 0) date = 2020;
            else if (yearCB.SelectedIndex == 1) date = 2021;

            sql.TransformSQL("sum(t.TicketPrice)", "type.TypeName as [Тип фильма], sum(t.TicketPrice) as [Сумма]"
                , "(Tickets t inner join Films f on t.ID_Film = f.ID_Film)" +
                " inner join Types type on f.FilmType = type.TypeCode"
                , $"year(t.SessionDate) = {date}"
                , "type.TypeName, SessionDate", "SessionDate", "'Квартал'&format(SessionDate, 'q') in(Квартал1, Квартал2, Квартал3, Квартал4)", mainDGV,this);
        }

       void annualCountTicket() {
            string initialDate = initialPeriodDateTimePicker.Value.Year + "/" + initialPeriodDateTimePicker.Value.Month + "/" + initialPeriodDateTimePicker.Value.Day;
            string endDate = endPeriodDateTimePicker.Value.Year + "/" + endPeriodDateTimePicker.Value.Month + "/" + endPeriodDateTimePicker.Value.Day;

            sql.TransformSQL("count(*)", "f.FilmName as [Название фильма], count(*) as [Количество билетов]"
                , "Tickets t inner join Films f on t.ID_Film = f.ID_Film"
                , $"t.SessionDate >= #{initialDate}# and t.SessionDate <= #{endDate}#"
                , "f.FilmName, SessionDate", "SessionDate", "SessionDate&' '&SessionTime", mainDGV, this);
        }

        void yearCountTicket() {
            int date = 0;
            if (yearCB.SelectedIndex == 0) date = 2020;
            else if (yearCB.SelectedIndex == 1) date = 2021;

            sql.TransformSQL("count(*)", "f.FilmName as [Название фильма], count(*) as [Количество билетов]"
                , "Tickets t inner join Films f on t.ID_Film = f.ID_Film"
                , $"year(SessionDate) = {date}"
                , "f.FilmName, SessionDate", "SessionDate", "format(t.SessionDate, 'mmmm')", mainDGV, this);
        }

        void quartCountTicket() {
            int date = 0;
            if (yearCB.SelectedIndex == 0) date = 2020;
            else if (yearCB.SelectedIndex == 1) date = 2021;

            sql.TransformSQL("count(*)", "f.FilmName as [Название фильма], count(*) as [Количество билетов]"
                , "Tickets t inner join Films f on t.ID_Film = f.ID_Film"
                , $"year(SessionDate) = {date}"
                , "f.FilmName, SessionDate", "SessionDate", "'Квартал'&format(SessionDate, 'q') in(Квартал1, Квартал2, Квартал3, Квартал4)", mainDGV, this);
        }

        void checkRB() {
            if (annualPeriodRB.Checked) {
                if (reportTypeCB.SelectedIndex == 0)
                    annualPeriodProduct();
                else if (reportTypeCB.SelectedIndex == 1)
                    annualPeriodCat();
                else
                    annualCountTicket();
            } else if (yearPeriodRB.Checked) {
                if (reportTypeCB.SelectedIndex == 0)
                    yearPeriodProduct();
                else if (reportTypeCB.SelectedIndex == 1)
                    yearPeriodCat();
                else
                    yearCountTicket();
            } else if (quartPeriodRB.Checked) {
                if (reportTypeCB.SelectedIndex == 0)
                    quartPeriodProduct();
                else if (reportTypeCB.SelectedIndex == 0)
                    quartPeriodCat();
                else
                    quartCountTicket();
            }
        }

        private void annualPeriodRB_CheckedChanged(object sender, EventArgs e) {
            label5.Enabled = true;
            label6.Enabled = true;
            initialPeriodDateTimePicker.Enabled = true;
            endPeriodDateTimePicker.Enabled = true;
            showReportButt.Enabled = true;
            yearLab.Enabled = false;
            yearCB.Enabled = false;
            checkRB();
        }

        private void yearPeriodRB_CheckedChanged(object sender, EventArgs e) {
            label5.Enabled = false;
            label6.Enabled = false;
            initialPeriodDateTimePicker.Enabled = false;
            endPeriodDateTimePicker.Enabled = false;
            showReportButt.Enabled = false;
            yearLab.Enabled = true;
            yearCB.Enabled = true;
            checkRB();
        }

        private void quartPeriodRB_CheckedChanged(object sender, EventArgs e) {
            label5.Enabled = false;
            label6.Enabled = false;
            initialPeriodDateTimePicker.Enabled = false;
            endPeriodDateTimePicker.Enabled = false;
            showReportButt.Enabled = false;
            yearLab.Enabled = true;
            yearCB.Enabled = true;
            checkRB();
        }

        private void reportTypeCB_SelectedIndexChanged(object sender, EventArgs e) {
            checkRB();
        }

        private void yearCB_SelectedIndexChanged(object sender, EventArgs e) {
            checkRB();
        }

        private void showReportButt_Click(object sender, EventArgs e) {
            if (reportTypeCB.SelectedIndex == 0) {
                annualPeriodProduct();
            } else if (reportTypeCB.SelectedIndex == 1) {
                annualPeriodCat();
            } else
                annualCountTicket();
        }

        private void printWord_Click(object sender, EventArgs e) {
            try {
                Microsoft.Office.Interop.Word.Application winwordsReports = new Microsoft.Office.Interop.Word.Application();

                winwordsReports.Documents.Application.Caption = "Отчет о выручке";

                object missing = System.Reflection.Missing.Value;

                Microsoft.Office.Interop.Word.Document document = winwordsReports.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                winwordsReports.Selection.InsertNewPage();

                /*foreach (Microsoft.Office.Interop.Word.Section section in document.Sections) {
                    Word.Range headeRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headeRange.Fields.Add(headeRange, Word.WdFieldType.wdFieldPage);
                    headeRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    headeRange.Font.ColorIndex = Word.WdColorIndex.wdBlue;
                    headeRange.Font.Size = 10;
                    headeRange.Text = "Верхний колонтитул" + Environment.NewLine + "БПОУ ОО ОПЭК";
                }

                foreach (Microsoft.Office.Interop.Word.Section wordsSection in document.Sections) {
                    Word.Range footerRange = wordsSection.Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    footerRange.Font.ColorIndex = Word.WdColorIndex.wdDarkRed;
                    footerRange.Font.Size = 10;
                    footerRange.Text = "Нижний колонтитул" + Environment.NewLine + "Отчет";
                }*/

                document.Content.SetRange(0, 0);
                document.Content.Text = "Создание отчета в Microsoft Word" + Environment.NewLine;

                Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading1 = "Заголовок 1";
                para1.Range.set_Style(styleHeading1);
                para1.Range.Text = "Отчет о выручке за ... (период)";
                para1.Range.InsertParagraphAfter();

                Word.Range tableLocation = document.Range(ref missing, ref missing);
                document.Tables.Add(tableLocation, mainDGV.RowCount + 1, mainDGV.ColumnCount);
                document.Tables[1].Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                document.Tables[1].Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                for (int j = 1; j <= mainDGV.ColumnCount; j++) {
                    document.Tables[1].Cell(1, j).Range.Text = mainDGV.Columns[j - 1].HeaderCell.Value.ToString();
                    document.Tables[1].Cell(0, j).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    document.Tables[1].Cell(0, j).Range.Bold = 5;
                }
                for (int i = 1; i < mainDGV.RowCount; i++) {
                    for (int j = 1; j <= mainDGV.ColumnCount; j++) {
                        document.Tables[1].Cell(i + 1, j).Range.Text = mainDGV[j - 1, i - 1].Value.ToString();
                    }
                }
                winwordsReports.Visible = true;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void barChartButt_Click(object sender, EventArgs e) {
            panel1.Enabled = false;

            diagramChart.ChartAreas.Clear();
            diagramChart.ChartAreas.Add("q");
            closeDiagramButt.Visible = true;
            diagramChart.Visible = true;
            diagramChart.Series.Clear();
            /*diagramChart.Series.Add(new Series("Column"));
            diagramChart.Series["Column"].ChartType = SeriesChartType.Column;*/
            ChartArea chart = new ChartArea();

            diagramChart.Titles.Clear();
            diagramChart.Titles.Add("Столбчатая диаграмма выручки");
            diagramChart.Titles[0].Font = new Font("Utopia", 16);

            diagramChart.ChartAreas["q"].AxisX.Enabled = AxisEnabled.False;

            diagramChart.ChartAreas["q"].AxisY.Title = "Стоимость, руб"; // Chart Y Axis Title 
            diagramChart.ChartAreas["q"].AxisY.TitleAlignment = StringAlignment.Center;  // Chart Y axis Text Alignment 
            diagramChart.ChartAreas["q"].AxisY.TextOrientation = TextOrientation.Rotated270; // Chart Y Axis Text Orientation
            diagramChart.ChartAreas["q"].AxisY.TitleFont = new Font("Arial", 8, FontStyle.Bold); // Chart Y axis Title Font

            for (int i = 0; i < mainDGV.RowCount - 1; i++) {
                diagramChart.Series.Add(i.ToString());
                diagramChart.Series[i].Points.AddXY(i * 0.1, Convert.ToDouble(mainDGV.Rows[i].Cells[1].Value.ToString()));
                diagramChart.Series[i].Points[0].BorderWidth = 100;
                diagramChart.Series[i].Label = mainDGV.Rows[i].Cells[1].Value.ToString();
                diagramChart.Series[i].LegendText = mainDGV.Rows[i].Cells[0].Value.ToString();
                Debug.WriteLine(diagramChart.Series[i].LegendText);
            }
        }

        private void pieChartButt_Click(object sender, EventArgs e) {
            panel1.Enabled = false;

            diagramChart.ChartAreas.Clear();
            diagramChart.ChartAreas.Add("q");
            diagramChart.ChartAreas["q"].Area3DStyle.Enable3D = true;
            closeDiagramButt.Visible = true;
            diagramChart.Visible = true;
            
            diagramChart.Series.Clear();
            diagramChart.Series.Add(new Series("pie"));
            diagramChart.Series["pie"].ChartType = SeriesChartType.Pie;

            diagramChart.Titles.Clear();
            diagramChart.Titles.Add("Круговая диаграмма выручки");
            diagramChart.Titles[0].Font = new Font("Utopia", 16);

            for (int i = 0; i < mainDGV.RowCount - 1; i++) {
                int index = diagramChart.Series["pie"].Points.AddY(mainDGV.Rows[i].Cells[1].Value.ToString());
                diagramChart.Series["pie"].Points[index].Label = mainDGV.Rows[i].Cells[1].Value.ToString();
                diagramChart.Series["pie"].Label = mainDGV.Rows[i].Cells[1].Value.ToString();
                diagramChart.Series["pie"].Points[i].LegendText = mainDGV.Rows[i].Cells[0].Value.ToString();
            }
        }

        private void closeDiagramButt_Click(object sender, EventArgs e) {
            panel1.Enabled = true;

            closeDiagramButt.Visible = false;
            diagramChart.Visible = false;   
        }

        private void percentPieChartButt_Click(object sender, EventArgs e) {
            panel1.Enabled = false;

            diagramChart.ChartAreas.Clear();
            diagramChart.ChartAreas.Add("q");
            diagramChart.ChartAreas["q"].Area3DStyle.Enable3D = true;
            closeDiagramButt.Visible = true;
            diagramChart.Visible = true;

            diagramChart.Series.Clear();
            diagramChart.Series.Add(new Series("pie"));
            diagramChart.Series["pie"].ChartType = SeriesChartType.Pie;

            diagramChart.Titles.Clear();
            diagramChart.Titles.Add("Круговая диаграмма выручки");
            diagramChart.Titles[0].Font = new Font("Utopia", 16);

            for (int i = 0; i < mainDGV.RowCount - 1; i++) {
                int index = diagramChart.Series["pie"].Points.AddY(mainDGV.Rows[i].Cells[1].Value.ToString());
                diagramChart.Series["pie"].Points[index].Label = mainDGV.Rows[i].Cells[1].Value.ToString();
                diagramChart.Series["pie"].Label = mainDGV.Rows[i].Cells[1].Value.ToString();
                diagramChart.Series["pie"].Points[i].LegendText = mainDGV.Rows[i].Cells[0].Value.ToString();
            }

            foreach (DataPoint p in diagramChart.Series["pie"].Points) {
                p.Label = "#PERCENT";
            }
        }
    }
}
