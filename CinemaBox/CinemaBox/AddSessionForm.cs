using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBox {
    public partial class AddSessionForm : Form {
        DataBaseSQL sql;

        public AddSessionForm() {
            InitializeComponent();
        }

        private void AddSessionForm_Load(object sender, EventArgs e) {
            defaultDate();

            sql = new DataBaseSQL();
            sql.ConnectToBD();
        }
        void defaultDate() {
            startSessionTimeDTP.Value = DateTime.Now;

            sessTimeTB.Text = string.Empty;
        }

        private void sessionNameCB_DropDown(object sender, EventArgs e) {
            sql.AddInComboBoxSQL(sessionNameCB, "FilmName, TypeName"
                , "Films f inner join Types t on f.FilmType = t.TypeCode" +
                $" where now() >= f.StartFilmDate and now() <= f.EndFilmDate"
                , "FilmName", "FilmName", "TypeName");
        }

        private void clearAllLinesButt_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Вы действительно хотите очистить все поля?", "Очистить поля?", MessageBoxButtons.YesNoCancel);

            if (result != DialogResult.Yes) return;
            else {
                sessionNameCB.Text = "";
                defaultDate();
            }
        }

        void dateError() {
            MessageBox.Show("Даты настроены неправильно!", "Ошибка в датах");
            defaultDate();
        }

        private void addSessionToBDButt_Click(object sender, EventArgs e) {
                var texts = new List<string>(new string[] { sessionNameCB.Text, sessTimeTB.Text, priceTB.Text });
                string condidion = texts.Find(cond => string.IsNullOrEmpty(cond));

                string time = sql.SelectStringSQL("SessionTime", "Sessions"
                , $"SessionDate = {startSessionTimeDTP.Value.ToString("#yyyy-MM-dd#")} and SessionTime = '{sessTimeTB.Text}'");

            try {
                    var startSession = startSessionTimeDTP.Value.ToString("#yyyy-MM-dd#");

                    if (condidion == "") {
                        MessageBox.Show("Заполните все поля");
                        return;
                    }
                    else {
                        if (string.IsNullOrWhiteSpace(time)) {
                            string name = sessionNameCB.Text.Substring(0, sessionNameCB.Text.Length - 3);
                            string commQFilm = $"insert into Sessions(ID_Film, SessionDate, SessionTime, CinemaHall, TicketPrice) " +
                                $"select ID_Film " +
                                $", {startSession}" +
                                $", '{sessTimeTB.Text}'" +
                                $", 1 " +
                                $", {priceTB.Text}" +
                                $"from Films where '{name}' = Films.FilmName";

                            sql.InsertSelectSQL("Sessions", "ID_Film, SessionDate, SessionTime, CinemaHall, TicketPrice",
                                 $"ID_Film, {startSession}, '{sessTimeTB.Text}',  1, {priceTB.Text}"
                                 , $"Films where '{name}' = Films.FilmName");

                            createTable(startSession.ToString() + sessTimeTB.Text, name);
                            DialogResult dialogResult;

                            dialogResult = MessageBox.Show("Хотите добавтить еще сеанс?", "Внимание", MessageBoxButtons.YesNo);

                            if (dialogResult == DialogResult.Yes) {
                                sessTimeTB.Text = string.Empty;
                                priceTB.Text = string.Empty;
                                sessTimeTB.Focus();
                                return;
                            } else {
                                this.Close();
                                mainForm main = new mainForm();
                                main.Focus();
                            }
                        } else {
                            MessageBox.Show("Сеанс на это время уже создан", "Внимание", MessageBoxButtons.OK);
                            sessTimeTB.Text = string.Empty;
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Неправильно заполнены поля времени");
                }
        }

        void createTable(string time, string filmName) {
            time = time.Replace(".", "").Replace(" ", "").Replace("#", "").Replace("-", "");
            
            sql.SelectSQL($"* into [{filmName}_{time}]", " tempHall");
        }

        private void sessionNameCB_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void startPriodSessionTimeTB_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar == 58)) e.Handled = true;
        }
    }
}
