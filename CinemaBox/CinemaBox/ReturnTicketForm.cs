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
using System.IO;
using System.Diagnostics;

namespace CinemaBox {

    public partial class ReturnTicketForm : Form {
        public OleDbConnection connectionReturnForm = new OleDbConnection();

        public OleDbDataAdapter cinemaAdapter;
        public DataSet cinemaDataSet;

        string filmName, filmDate, filmTime, filmPlace;

        int row;
        int place;

        private void findTickButt_Click(object sender, EventArgs e) {
            try {
                if (connectionReturnForm.State == ConnectionState.Closed) connectionReturnForm.Open();
                OleDbCommand selPar = new OleDbCommand();
                selPar = connectionReturnForm.CreateCommand();
                selPar.CommandText = $"select f.FilmName, t.SessionDate, t.SessionTime, t.Place from Films f" +
                    $" inner join Tickets t on f.ID_Film = t.ID_Film" +
                    $" where t.ID_Ticket = {tickIDTB.Value}";
                selPar.Connection = connectionReturnForm;
                OleDbDataReader reader = selPar.ExecuteReader();
                while (reader.Read()) {
                    filmName = reader.GetValue(0).ToString();
                    filmDate = reader.GetValue(1).ToString();
                    filmTime = reader.GetValue(2).ToString();
                    filmPlace = reader.GetValue(3).ToString();
                }
                selectInfo();
                if (connectionReturnForm.State == ConnectionState.Open) connectionReturnForm.Close();
                if (!string.IsNullOrWhiteSpace(tickIDTB.Text) && !string.IsNullOrWhiteSpace(filmName)) {
                    filmNameLab.Text = filmName;
                    returnTickButt.Enabled = true;
                } else {
                    filmNameLab.Text = "Билета по данному ID не существует";
                    returnTickButt.Enabled = false;
                }
                tickIDTB.Text = "";
                Debug.WriteLine(selPar.CommandText);

            } catch {
                filmNameLab.Text = "Билета по данному ID не существует";
                returnTickButt.Enabled = false;
                tickIDTB.Text = "";
            }
        }

        private void tickIDTB_ValueChanged(object sender, EventArgs e) {
            filmNameLab.Text = string.Empty;
        }

        private void tickIDTB_KeyPress(object sender, KeyPressEventArgs e) {
            filmNameLab.Text = string.Empty;
        }

        private void returnTickButt_Click(object sender, EventArgs e) {
            row = Convert.ToInt32(pl.Substring(0, pl.LastIndexOf(' ')).Substring(0, pl.LastIndexOf(' ')).Substring(pl.IndexOf(' ')).Substring(0, pl.IndexOf(' ') - 1));
            place = Convert.ToInt32(pl.Substring(pl.LastIndexOf(' ') + 1));
            Debug.WriteLine(row + "|" + place);

            string message = "Вы уверены, что хотите вернуть билет?";
            string caption = "Возврат билета";
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show(message, caption, messageBoxButtons);

            if (dialogResult != DialogResult.Yes)
                return;
            else {
                try {
                    string year = filmDate.Substring(6, 4);
                    string month = filmDate.Substring(3, 2);
                    string day = filmDate.Substring(0, 2);
                    string time = year + month + day + filmTime;
                    string tbName = filmName + "_" + time;
                    string updPlaces = $"update [{tbName}]" +
                        $" set P{place} = 0" +
                        $" where pID = {row}";
                    OleDbCommand updPl = new OleDbCommand();
                    updPl = connectionReturnForm.CreateCommand();
                    updPl.CommandText = updPlaces;
                    updPl.Connection = connectionReturnForm;
                    if (connectionReturnForm.State == ConnectionState.Closed) connectionReturnForm.Open();
                    Debug.WriteLine(updPlaces);
                    updPl.ExecuteNonQuery();
                    if (connectionReturnForm.State == ConnectionState.Open) connectionReturnForm.Close();


                    //delete from Билеты значение возврата
                    string deleteTickRow = $"delete from Tickets where ID_Ticket = {tickIDTB.Value}";
                    OleDbCommand delRow = new OleDbCommand();
                    delRow = connectionReturnForm.CreateCommand();
                    delRow.CommandText = deleteTickRow;
                    delRow.Connection = connectionReturnForm;
                    if (connectionReturnForm.State == ConnectionState.Closed) connectionReturnForm.Open();
                    delRow.ExecuteNonQuery();
                    if (connectionReturnForm.State == ConnectionState.Open) connectionReturnForm.Close();

                    this.Close();
                    mainForm main = new mainForm();
                    main.Focus();
                } catch (Exception ex) {
                    Debug.WriteLine(ex.Message);
                    MessageBox.Show("Невозможно вернуть билет так как он просрочен");
                }
            }
        }

        string pl;

        private void ReturnTicketForm_Load(object sender, EventArgs e) {
            connectionReturnForm.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                 "Data Source=" + Directory.GetCurrentDirectory() + "\\Cinema.mdb";
            selectInfo();
            filmNameLab.Text = "";
            tickIDTB.Text = string.Empty;
            returnTickButt.Enabled = false;
        }

        
        public ReturnTicketForm() {
            InitializeComponent();
        }
        void selectInfo() {
            if (connectionReturnForm.State == ConnectionState.Closed) connectionReturnForm.Open();
            OleDbCommand selPar = new OleDbCommand();
            selPar = connectionReturnForm.CreateCommand();
            selPar.CommandText = $"select place from Tickets where ID_Ticket = {tickIDTB.Value}";
            selPar.Connection = connectionReturnForm;
            OleDbDataReader reader = selPar.ExecuteReader();
            while (reader.Read()) {
                pl = reader.GetValue(0).ToString();
            }
            if (connectionReturnForm.State == ConnectionState.Open) connectionReturnForm.Close();
        }
    }
}
