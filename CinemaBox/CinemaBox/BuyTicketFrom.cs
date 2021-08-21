using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using System.IO;
using System.Diagnostics;

namespace CinemaBox {
    public partial class BuyTicketFrom : Form {
        OleDbConnection connectionBuyForm = new OleDbConnection();

        DataBaseSQL sql;

        mainForm m;

        string tableName;

        static string placeName;

        string sessName, sessType, sessCateg, sessGenres
            , sessDuration, sessPrice, sessTime;
        bool p1, p2, p3, p4, p5, p6, p7;

        string sessTypeName, sessCatName;

        bool[] pl1 = new bool[7];
        bool[] pl2 = new bool[7];
        bool[] pl3 = new bool[7];
        bool[] pl4 = new bool[7];
        bool[] pl5 = new bool[7];
        bool[] pl6 = new bool[7];

        static int id;

        private void placesDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (Convert.ToBoolean(placesDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == true) {
                ap.Add("Ряд " + (e.RowIndex + 1) + " Место " + (e.ColumnIndex + 1).ToString());
                sessChoosenPlacesLab.Text = "";
                sessChoosenPlacesLab.Text = string.Join("\n", ap);
                sessChoosenPlacesLab.Text += "\n";
                foreach (string s in ap)
                    Debug.WriteLine(s);
            } else {
                    string place = "Ряд " + (e.RowIndex + 1) + " Место " + (e.ColumnIndex + 1).ToString();
                ap.Remove(place);
                /*foreach (string s in ap) {
                    if (s == place) {
                        ap.Remove(s);
                        Debug.WriteLine(s);
                        
                    }
                }*/

                sessChoosenPlacesLab.Text = "";
                sessChoosenPlacesLab.Text = string.Join("\n", ap);
                sessChoosenPlacesLab.Text += "\n";
            }

            if (e.RowIndex == 0) {
                if (Convert.ToBoolean(placesDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == true)
                    pl1[e.ColumnIndex] = true;
                else
                    pl1[e.ColumnIndex] = false;
            }
            if (e.RowIndex == 1) {
                if (Convert.ToBoolean(placesDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == true)
                    pl2[e.ColumnIndex] = true;
                else
                    pl2[e.ColumnIndex] = false;
            }
            if (e.RowIndex == 2) {
                if (Convert.ToBoolean(placesDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == true)
                    pl3[e.ColumnIndex] = true;
                else
                    pl3[e.ColumnIndex] = false;
            }
            if (e.RowIndex == 3) {
                if (Convert.ToBoolean(placesDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == true)
                    pl4[e.ColumnIndex] = true;
                else
                    pl4[e.ColumnIndex] = false;
            }
            if (e.RowIndex == 4) {
                if (Convert.ToBoolean(placesDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == true)
                    pl5[e.ColumnIndex] = true;
                else
                    pl5[e.ColumnIndex] = false;
            }
            if (e.RowIndex == 5) {
                if (Convert.ToBoolean(placesDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == true)
                    pl6[e.ColumnIndex] = true;
                else
                    pl6[e.ColumnIndex] = false;
            }


            ticketPriceLab.Text = (Convert.ToInt32(sessPrice) * ap.Count()).ToString() + " руб.";
        }

        private void placesDGV_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
            placesDGV.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        //string[,] p = new string[7, 6];
        List<string> ap = new List<string>();

        public BuyTicketFrom() {
            InitializeComponent();
        }

        private void BuyTicketFrom_Load(object sender, EventArgs e) {
            sql = new DataBaseSQL();
            sql.ConnectToBD();

            m = new mainForm();

            connectionBuyForm.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                 "Data Source=" + Directory.GetCurrentDirectory() + "\\Cinema.mdb";

            sessName = mainForm.sessionName;
            DateTime sessTimeDT = DateTime.Parse(mainForm.sessionTime);
            string weekDay = sessTimeDT.DayOfWeek.ToString();
            string day = sessTimeDT.Day.ToString();
            string month = Months(sessTimeDT.Month);
            string time = sessTimeDT.ToString().Substring(11, 5);
            sessTime = weekDay + ", " + day + " " + month + ", " + time;

            selectInfo();

            sessNameLabel.Text = sessName + " (" + sessTypeName + ", " + sessCatName + ")";
            sessGenreTB.Text = sessGenres;
            sessDuratLab.Text = sessDuration + " минут";
            sessPriceLab.Text = sessPrice + " руб.";
            sessDateTimeLab.Text = sessTime.ToString();

            showPlacesDGV();

            sessChoosenPlacesLab.Text = "";

            getPlacesPar();

            if (connectionBuyForm.State != ConnectionState.Open) connectionBuyForm.Open();
            OleDbCommand compossion = new OleDbCommand($"SELECT MAX(ID_Ticket) AS maxkod FROM Tickets", connectionBuyForm);
            OleDbDataReader readcompossion = compossion.ExecuteReader();
            while (readcompossion.Read()) {
                id = Convert.ToInt32(readcompossion["maxkod"]);
            }
        }

        private void buyButt_Click(object sender, EventArgs e) {
            string time = mainForm.sessionTime.Replace(".", "").Replace(" ", "");

            updSess(1, pl1);
            updSess(2, pl2);
            updSess(3, pl3);
            updSess(4, pl4);
            updSess(5, pl5);
            //updSess(6, pl6);

            addInTickets();
                if (connectionBuyForm.State == ConnectionState.Open) connectionBuyForm.Close();


            DialogResult result;
            result = MessageBox.Show("Покупка совершена, ожидайте билеты", "Внимание");
            this.Close();
            if (result == DialogResult.OK) {
                mainForm main = new mainForm();
                main.Focus();
            }
        }

        void updSess(int pid, bool[] pl) {
            string qPl = $"UPDATE [{tableName}]" +
                        $" SET" +
                        $" P1 = {pl[0]}, P2 = {pl[1]}, P3 = {pl[2]}, P4 = {pl[3]}, P5 = {pl[4]}, P6 = {pl[5]}, P7 = {pl[6]}" +
                        $" where pID = {pid}";
            Debug.WriteLine(qPl);
            if (connectionBuyForm.State == ConnectionState.Closed) connectionBuyForm.Open();
            OleDbCommand updPlaces = new OleDbCommand();
            updPlaces = connectionBuyForm.CreateCommand();
            updPlaces.CommandText = qPl;
            updPlaces.Connection = connectionBuyForm;
            updPlaces.ExecuteNonQuery();
        }

        void addInTickets() {

            string date = mainForm.sessionDate.Substring(0, 10);
            string time = mainForm.sessionTime;
            
            for (int i = 0; i < ap.Count; i++) {
                string ticketQ = $"insert into Tickets(ID_Film, FilmType, CinemaHall, TicketPrice" +
                $", SessionDate, SessionTime, Place, BuyDate)" +
                $" select f.ID_Film" +
                $", {Convert.ToInt32(sessType)}" +
                $", 1" +
                $", s.TicketPrice" +
                $", '{date}'" +
                $", '{time}'" +
                $", '{ap[i]}'" +
                $", '{DateTime.Now}'" +
                $" from Films f inner join Sessions s on f.ID_Film = s.ID_Film" +
                $" where f.FilmName = '{sessName}' and f.FilmType = {sessType}" +
                $" and s.SessionDate = {DateTime.Parse(date).ToString("#yyyy-MM-dd#")} and s.SessionTime = '{time}'";
                Debug.WriteLine(ticketQ);
                OleDbCommand addTick = new OleDbCommand();
                addTick = connectionBuyForm.CreateCommand();
                addTick.CommandText = ticketQ;
                addTick.Connection = connectionBuyForm;
                addTick.ExecuteNonQuery();

                id++;
                try {
                    SetTemplate(sessPrice, ap[i].ToString(), date, time, id.ToString(), sessName);
                } catch {
                }
            }
        }

        Word.Application oWord = new Word.Application();

        private void SetTemplate(string sPrice, string place, string sDate, string sTime, string sID, string sName) {

            _Document oDoc = oWord.Documents.Add(Environment.CurrentDirectory + (@"\Tickets\TemplateTicket.docx"));
            oDoc.Bookmarks["Price"].Range.Text = sPrice.ToString()+ "р.";
            oDoc.Bookmarks["Place"].Range.Text = place.ToString();
            oDoc.Bookmarks["SessionDate"].Range.Text = sDate;
            oDoc.Bookmarks["SessionTime"].Range.Text = sTime;
            oDoc.Bookmarks["SessionID"].Range.Text = sID.ToString();
            oDoc.Bookmarks["SessionName"].Range.Text = sName.ToString();
            oDoc.SaveAs(FileName: Environment.CurrentDirectory + ($"\\Tickets\\Result{id}.doc"));
            oDoc.Close();
            Process.Start(Environment.CurrentDirectory + ($"\\Tickets\\Result{id}.doc"));

        }

        void selectInfo() {
            if (connectionBuyForm.State == ConnectionState.Closed) connectionBuyForm.Open();
            OleDbCommand selPar = new OleDbCommand();
            selPar = connectionBuyForm.CreateCommand();
            selPar.CommandText = $"select FilmType, FilmGenre, FilmDuration, FilmCategory" +
                $" from Films inner join Sessions on Sessions.ID_Film = Films.ID_Film" +
                $" where FilmName = '{sessName}' and Films.ID_Film = Sessions.ID_Film";
            selPar.Connection = connectionBuyForm;
            OleDbDataReader reader = selPar.ExecuteReader();
            while (reader.Read()) {
                sessType = reader.GetValue(0).ToString();
                sessGenres = reader.GetValue(1).ToString();
                sessDuration = reader.GetValue(2).ToString();
                sessCateg = reader.GetValue(3).ToString();
            }
            sessPrice = sql.SelectStringSQL("TicketPrice", "Sessions s inner join Films f on s.ID_Film = f.ID_Film"
                , $"FilmName = '{sessName}'");
            if (connectionBuyForm.State == ConnectionState.Open) connectionBuyForm.Close();

            sessTypeName = sql.SelectStringSQL("TypeName", "Types", $"TypeCode = {sessType}");
            sessCatName = sql.SelectStringSQL("CategoryName", "Categories", $"CategoryCode = {sessCateg}");

        }
        void showPlacesDGV() {
            string year = mainForm.sessionDate.Substring(6, 4);
            string month = mainForm.sessionDate.Substring(3, 2);
            string day = mainForm.sessionDate.Substring(0, 2);
            string time = year + month + day + mainForm.sessionTime;
            time = time.Replace(".", "").Replace(" ", "").Replace("#", "").Replace("-", "");

            tableName = sessName + "_" + time;

            sql.MainQuery($"select P1 as [1 место], P2 as [2 место], P3 as [3 место], P4 as [4 место]" +
                $", P5 as [5 место], P6 as [6 место]" +
                $" from [{tableName}]", placesDGV, this);
            //dataGridDB();

            for (int i = 0; i < 6; i++) {
                placesDGV.Columns[i].Width = 82;
            }

            placesDGV.ScrollBars = ScrollBars.None;
        }        

        void getPlacesPar() {
            if (connectionBuyForm.State == ConnectionState.Closed) connectionBuyForm.Open();

            for (int i = 0; i < 6; i++) {
                OleDbCommand plPar = new OleDbCommand();
                plPar = connectionBuyForm.CreateCommand();
                plPar.CommandText = $"select * from [{tableName}] where pID = {i + 1}";
                plPar.Connection = connectionBuyForm;
                OleDbDataReader reader = plPar.ExecuteReader();
                while (reader.Read()) {
                    p1 = Convert.ToBoolean(reader.GetValue(1));
                    p2 = Convert.ToBoolean(reader.GetValue(2));
                    p3 = Convert.ToBoolean(reader.GetValue(3));
                    p4 = Convert.ToBoolean(reader.GetValue(4));
                    p5 = Convert.ToBoolean(reader.GetValue(5));
                    p6 = Convert.ToBoolean(reader.GetValue(6));
                    p7 = Convert.ToBoolean(reader.GetValue(7));

                    if (i == 0) pl1 = new bool[] { p1, p2, p3, p4, p5, p6, p7 };
                    if (i == 1) pl2 = new bool[] { p1, p2, p3, p4, p5, p6, p7 };
                    if (i == 2) pl3 = new bool[] { p1, p2, p3, p4, p5, p6, p7 };
                    if (i == 3) pl4 = new bool[] { p1, p2, p3, p4, p5, p6, p7 };
                    if (i == 4) pl5 = new bool[] { p1, p2, p3, p4, p5, p6, p7 };
                    if (i == 5) pl6 = new bool[] { p1, p2, p3, p4, p5, p6, p7 };
                }
            }

            if (connectionBuyForm.State == ConnectionState.Open) connectionBuyForm.Close();
        }

        private string Months(int m) {

            switch (m) {
                case 1: return "Января";
                case 2: return "Февраля";
                case 3: return "Марта";
                case 4: return "Апреля";
                case 5: return "Мая";
                case 6: return "Июня";
                case 7: return "Июля";
                case 8: return "Августа";
                case 9: return "Сентября";
                case 10: return "Октября";
                case 11: return "Ноября";
                case 12: return "Декабря";
                default: return "";
            }
        }
    }
}
