using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CinemaBox {
    public partial class mainForm : Form {
        DataBaseSQL sql;

        public static string filmName, filmType
            , filmGenre, filmDirector
            , filmCategory, filmPrice, filmDesrib
            , time, startFD, endFD;

        int filmDirINT;

        public static int filmDuration;

        public static string sessionName;
        public static string sessionTime, sessionDate;
        public int sessionID;
        public static string placeName;

        public static int ticketId;

        string username = LogInForm.log;
        string roleName = LogInForm.roleName;
        int role = LogInForm.role;

        public mainForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            sql = new DataBaseSQL();
            this.Text = "Cinema BOX";
            currentTabLabel.Text = "Главная страница";
            mainDGV.Visible = false;

            sql.ConnectToBD();
            location();
            hideButtons();
            showAllFilmsCButt.Visible = false;

            moreInfoPanel.Visible = false;

            NewsButt.Enabled = false;
            NewsButt.Text = "Новости - WIP";
            stocksButt.Enabled = false;
            stocksButt.Text = "Акции - WIP";

            usernameLabel.Text = username;
            roleLabel.Text = roleName;

            checkRole();
        }

        private void checkRole() {
            if (role == 2) {
                firstButt.Enabled = false;
                secondButt.Enabled = false;

                changeFilmParamsPanel.Enabled = false;
                signUpPanel.Enabled = false;
                offersPanel.Enabled = false;

                if (currentTabLabel.Text == "Журнал продаж") {
                    firstButt.Enabled = true;
                }
            } else if(role == 1) {
                firstButt.Enabled = true;
                secondButt.Enabled = true;
            }
            else if(role == 3) {
                firstButt.Enabled = false;
                secondButt.Enabled = false;
                thirdButt.Enabled = false;
                sessionsButt.Enabled = false;

                changeFilmParamsPanel.Enabled = false;
                signUpPanel.Enabled = false;
                offersPanel.Enabled = false;

                if (currentTabLabel.Text == "Журнал продаж") {
                    secondButt.Enabled = true;
                }
            }
        }

        private void location() {
            //mainFilterPanel
            mainFilterPanel.Width = 226;
            mainFilterPanel.Height = 498;
        }

        void hideButtons() {
            firstButt.Visible = false;
            secondButt.Visible = false;
            thirdButt.Visible = false;

            firstPB.Visible = false;
            secondPB.Visible = false;
            thirdPB.Visible = false;

            changeFilmParamsPanel.Visible = false;
            signUpPanel.Visible = false;
            addOrChangePanel.Visible = false;
            changeUserPanel.Visible = false;
            offersPanel.Visible = false;

            freePlacesCountLab.Visible = false;
        }

        //Новости
        private void NewsButt_Click(object sender, EventArgs e)
        {
            hideButtons();
            showAllFilmsCButt.Visible = false;
            currentTabLabel.Text = "Новости";
            mainDGV.Visible = false;
            moreInfoPanel.Visible = false;
        }
        //Афиша SQL
        void postersSQL(string date)
        {
            string q = "select FilmName as [Название фильма], TypeName as [Тип фильма], " +
                " FilmGenre as [Жанр], DirectorsName as [Режиссер]," +
                " left(StartFilmDate, 16) as [Начало проката], left(EndFilmDate, 16) as [Конец проката]" +
                " from (Films f inner join Types t on f.FilmType = t.TypeCode)" +
                " inner join Directors d on f.FilmDirector = d.DirectorCode" +
                $" where {date}";

            sql.MainQuery(q, mainDGV, this);
        }
        //Афиша
        private void postersButt_Click(object sender, EventArgs e)
        {
            mainDGV.Columns.Clear();

            firstButt.Visible = true;
            firstButt.Text = "Добавить";
            secondButt.Visible = true;
            secondButt.Text = "Изменить";
            firstPB.Visible = true;
            firstPB.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\PB\add.png");
            secondPB.Visible = true;
            secondPB.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\PB\change.png");

            changeFilmParamsPanel.Visible = false;
            signUpPanel.Visible = false;
            addOrChangePanel.Visible = false;
            changeUserPanel.Visible = false;
            offersPanel.Visible = false;

            thirdButt.Visible = false;
            thirdPB.Visible = false;

            freePlacesCountLab.Visible = false;

            showAllFilmsCButt.Visible = true;

            mainDGV.Visible = true;

            moreInfoPanel.Visible = true;

            currentTabLabel.Text = "Афиша";

            mainDGV.Size = new Size(775, 617);

            checkRole();

            if (showAllFilmsCButt.Checked)
                postersSQL("StartFilmDate is not null");
            else
                postersSQL($"now() >= StartFilmDate and now() <= EndFilmDate");

            if (mainDGV.RowCount > 1)
            {
                filmName = mainDGV.Rows[0].Cells[0].Value.ToString();
                filmType = mainDGV.Rows[0].Cells[1].Value.ToString();
                filmDirector = mainDGV.Rows[0].Cells[3].Value.ToString();

                selectParameters();
                moreFilmInfo();
                filmInfo();
            }
        }
        //Сеансы SQL
        void sessionsSQL()
        {
            string q = "select FilmName as [Название фильма], " +
                "SessionDate as [Дата сеанса], SessionTime as [Время сеанса], TicketPrice&' руб.' as [Цена билета], CinemaHall as [Зал] " +
                "from Sessions s inner join Films f on s.ID_Film = f.ID_Film" +
                $" where now() >= f.StartFilmDate and now() <= f.EndFilmDate";

            sql.MainQuery(q, mainDGV, this);
        }

        private void mainDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentTabLabel.Text == "Сеансы") {
                //Инфа о сеансах
                sessionName = mainDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                sessionDate = mainDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                sessionTime = mainDGV.Rows[e.RowIndex].Cells[2].Value.ToString();

                Debug.WriteLine(sessionName + " " + sessionDate + " " + sessionTime);

                freePlacesCount();
            }
            if (currentTabLabel.Text == "Афиша") {
                //Инфа о фильме
                filmName = mainDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                filmType = mainDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                filmDirector = mainDGV.Rows[e.RowIndex].Cells[4].Value.ToString();

                selectParameters();
                moreFilmInfo();
                filmInfo();
            }

            if (e.RowIndex == mainDGV.NewRowIndex || e.RowIndex < 0)
                return;
        }

        void freePlacesCount() {
            string year = sessionDate.Substring(6, 4);
            string month = sessionDate.Substring(3, 2);
            string day = sessionDate.Substring(0, 2);
            string time = year + month + day + sessionTime;
            time = time.Replace(".", "").Replace(" ", "").Replace("#", "").Replace("-", "");

            int countPlaces = 0;

            int[,] freePL = new int[5, 6];
            for(int col = 0; col < 5; col++) {
                for(int row = 0; row < 6; row++) {
                    freePL[col, row] = sql.SelectIntSQL($"P{row + 1}", $"[{sessionName}_{time}]", $"pID = {col + 1} and P{row + 1} is not null");
                }
            }

            for (int col = 0; col < 5; col++) {
                for (int row = 0; row < 6; row++) {
                    if (freePL[col, row] == 0) countPlaces++;
                }
            }
            Debug.WriteLine(countPlaces);

            freePlacesCountLab.Text = "Кол-во свободных мест: " + countPlaces;
            if (countPlaces == 0)
                thirdButt.Enabled = false;
            else
                thirdButt.Enabled = true;
        }

        void filmInfo() {
            filmNameLab.Text = filmName;
            filmTypeLab.Text = filmType;
            filmDurLab.Text = filmDuration + " мин.";
            filmGenreLab.Text = filmGenre;
            filmDirectorLab.Text = filmDirector;
            filmCategoryLab.Text = filmCategory;
            filmDescribRB.Text = filmDesrib;
            startFDLab.Text = startFD.Substring(0, 10);
            endFDLab.Text = endFD.Substring(0, 10);
        }

        private void selectParameters() {
            int typeCode = sql.SelectIntSQL("TypeCode", "Types", $"TypeName = '{filmType}'");

            filmDuration = sql.SelectIntSQL("FilmDuration"
                , "Films f inner join Types t on f.FilmType = t.TypeCode"
                , $"FilmName = '{filmName}' and TypeCode = {typeCode}");
            filmCategory = sql.SelectStringSQL("CategoryName"
                , "(Films f inner join Categories c on f.FilmCategory = c.CategoryCode)" +
                " inner join Types t on f.FilmType = t.TypeCode"
                , $"FilmName = '{filmName}' and TypeName = '{filmType}'");
            filmDesrib = sql.SelectStringSQL("FilmDescription"
                , "Films f inner join Types t on f.FilmType = t.TypeCode"
                , $"FilmName = '{filmName}' and TypeName = '{filmType}'");
        }



        //Для доп инфы
        private void moreFilmInfo() {
            int type = sql.SelectIntSQL("TypeCode", "Types", $"TypeName = '{filmType}'");
            //FilmDur already exists
            filmGenre = sql.SelectStringSQL("FilmGenre", "Films", $"FilmName = '{filmName}' and FilmType = {type}");

            //FilmCat alredy exists
            //FilmDescrib already exists

            startFD = sql.SelectStringSQL("StartFilmDate", "Films", $"FilmName = '{filmName}' and FilmType = {type}");
            endFD = sql.SelectStringSQL("EndFilmDate", "Films", $"FilmName = '{filmName}' and FilmType = {type}");
        }

        //Сеансы
        private void sessionsButt_Click(object sender, EventArgs e)
        {
            firstButt.Visible = true;
            firstButt.Text = "Добавить";
            secondButt.Visible = true;
            secondButt.Text = "Удалить";
            thirdButt.Visible = true;
            thirdButt.Text = "Купить билет";
            firstPB.Visible = true;
            firstPB.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\PB\add.png");
            secondPB.Visible = true;
            secondPB.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\PB\delete.png");
            thirdPB.Visible = true;
            thirdPB.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\PB\buy.png");

            changeFilmParamsPanel.Visible = false;
            signUpPanel.Visible = false;
            addOrChangePanel.Visible = false;
            changeUserPanel.Visible = false;
            offersPanel.Visible = false;

            freePlacesCountLab.Visible = true;

            showAllFilmsCButt.Visible = false;

            mainDGV.Visible = true;

            moreInfoPanel.Visible = false;

            currentTabLabel.Text = "Сеансы";

            mainDGV.Size = new Size(1034, 617);

            checkRole();

            sessionsSQL();

            
            if (mainDGV.RowCount > 1) {
                sessionName = mainDGV.Rows[0].Cells[0].Value.ToString();
                sessionDate = mainDGV.Rows[0].Cells[1].Value.ToString();
                sessionTime = mainDGV.Rows[0].Cells[2].Value.ToString();
                freePlacesCount();
            }
        }

        //Журнал продаж SQL
        void salesMagSQL()
        {
            string q = "select ID_Ticket as [Номер билета]" +
                " , FilmName as [Название фильма], t.TypeName as [Тип фильма], CinemaHall as [Номер зала]" +
                ", TicketPrice as [Стоимость билета], SessionDate as [Дата сеанса]" +
                $", left(SessionTime, 5) as [Время сеанса], Place as [Место], left(BuyDate, 16) as [Дата покупки]" +
                " from (Tickets tick inner join Films f on tick.ID_Film = f.ID_Film)" +
                " inner join Types t on tick.FilmType = t.TypeCode" +
                " order by 1 desc";

            sql.MainQuery(q, mainDGV, this);
        }

        private void thirdButt_Click(object sender, EventArgs e) {
            if(currentTabLabel.Text == "Сеансы") {
                BuyTicketFrom buyTicketFrom = new BuyTicketFrom();
                buyTicketFrom.ShowDialog();
            }
        }

        //Журнал продаж
        private void salesMagazineButt_Click(object sender, EventArgs e) {
            mainDGV.Columns.Clear();

            firstButt.Visible = true;
            firstButt.Text = "Вернуть билет";
            secondButt.Visible = true;
            secondButt.Text = "Отчеты";
            firstPB.Visible = true;
            firstPB.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\PB\returnTick.png");
            secondPB.Visible = true;
            secondPB.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\PB\reports.png");

            changeFilmParamsPanel.Visible = false;
            signUpPanel.Visible = false;
            addOrChangePanel.Visible = false;
            changeUserPanel.Visible = false;
            offersPanel.Visible = false;

            thirdButt.Visible = false;
            thirdPB.Visible = false;

            showAllFilmsCButt.Visible = false;

            freePlacesCountLab.Visible = false;

            mainDGV.Visible = true;

            moreInfoPanel.Visible = false;

            currentTabLabel.Text = "Журнал продаж";

            mainDGV.Size = new Size(1034, 617);

            checkRole();

            salesMagSQL();
        }

        private void changeUserButt_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void addOrChangeDir_Click(object sender, EventArgs e) {
            addOrChangePanel.Visible = true;
        }

        private void closeAOrCPanel_Click(object sender, EventArgs e) {
            addOrChangePanel.Visible = false;
        }

        private void signUpButt_Click(object sender, EventArgs e) {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }

        private void offersButt_Click(object sender, EventArgs e) {
            OffersForm offersForm = new OffersForm();
            offersForm.ShowDialog();
        }

        private void addParamsButt_Click(object sender, EventArgs e) {
            AddDirectorForm addDirectorForm = new AddDirectorForm();
            addDirectorForm.ShowDialog();
        }

        private void changeParamsButt_Click(object sender, EventArgs e) {
            ChangeDirecrorForm changeDirecrorForm = new ChangeDirecrorForm();
            changeDirecrorForm.ShowDialog();
        }

        //Акции
        private void stocksButt_Click(object sender, EventArgs e)
        {
            hideButtons();
            showAllFilmsCButt.Visible = false;
            currentTabLabel.Text = "Акции";
            mainDGV.Visible = false;
            moreInfoPanel.Visible = false;
        }

        private void settingsButt_Click(object sender, EventArgs e)
        {
            hideButtons();

            changeFilmParamsPanel.Visible = true;
            signUpPanel.Visible = true;
            changeUserPanel.Visible = true;
            offersPanel.Visible = true;

            showAllFilmsCButt.Visible = false;
            currentTabLabel.Text = "Настройки";
            mainDGV.Visible = false;
            moreInfoPanel.Visible = false;

            userNameLab.Text = usernameLabel.Text;

            checkRole();
        }

        private void showAllFilmsCButt_CheckedChanged(object sender, EventArgs e)
        {
            postersButt_Click(null, null);
        }

        private void mainForm_Activated(object sender, EventArgs e)
        {
            if (currentTabLabel.Text == "Афиша") {
                /* if (showAllFilmsCButt.Checked)
                     postersSQL("StartFilmDate is not null");
                 else
                     postersSQL($"now() >= StartFilmDate and now() <= EndFilmDate");*/
                postersButt_Click(null, null);
            } else if (currentTabLabel.Text == "Сеансы")
                sessionsButt_Click(null, null);
            else if (currentTabLabel.Text == "Журнал продаж")
                salesMagazineButt_Click(null, null);
        }

        private void firstButt_Click(object sender, EventArgs e)
        {
            if(currentTabLabel.Text == "Афиша") {
                AddFilmForm addFilmForm = new AddFilmForm();
                addFilmForm.ShowDialog();
            }
            else if(currentTabLabel.Text == "Сеансы") {
                AddSessionForm addSessionForm = new AddSessionForm();
                addSessionForm.ShowDialog();
            }
            else if(currentTabLabel.Text == "Журнал продаж") {
                ReturnTicketForm returnTicketForm = new ReturnTicketForm();
                returnTicketForm.ShowDialog();
            }
        }

        private void secondButt_Click(object sender, EventArgs e)
        {
            if(currentTabLabel.Text == "Афиша") { 
                ChangeFilmInfoForm changeFilmInfoForm = new ChangeFilmInfoForm();
                changeFilmInfoForm.ShowDialog();
            }
            else if(currentTabLabel.Text == "Сеансы") {
                delSession();
            } else if (currentTabLabel.Text == "Журнал продаж") {
                ReportsForm reportsForm = new ReportsForm();
                reportsForm.ShowDialog();
            }
        }

        public void Clear(DataGridView dataGridView) {
            while (dataGridView.Rows.Count > 1)
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                    dataGridView.Rows.Remove(dataGridView.Rows[i]);
        }

        void delSession() {
            if (string.IsNullOrEmpty(sessionName))
                return;
            else {
                string message = $"Вы действительно хотите удалить {sessionName}[{sessionDate + " - " + sessionTime}]?";
                string caption = "Удалить сеанс?";
                MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNoCancel;
                DialogResult result = MessageBox.Show(message, caption, messageBoxButtons);

                if (result != DialogResult.Yes)
                sessionsButt_Click(null, null);
                else {
                    sql.DeleteSQL("", "Sessions", $"Sessions.ID_Film = (select Films.ID_Film from Films inner join Sessions on Sessions.ID_Film = Films.ID_Film" +
                        $" where FilmName = '{sessionName}'" +
                        $" and SessionDate = {DateTime.Parse(sessionDate).ToString("#yyyy-MM-dd#")} and SessionTime = '{sessionTime}')" +
                        $" and SessionDate = {DateTime.Parse(sessionDate).ToString("#yyyy-MM-dd#")} and SessionTime = '{sessionTime}'");
                    try {
                        dropTable();
                    } catch {

                    }
                    sessionsButt_Click(null, null);
                }
            }
        }

        void dropTable() {
            string year = sessionDate.Substring(6, 4);
            string month = sessionDate.Substring(3, 2);
            string day = sessionDate.Substring(0, 2);
            string time = year + month + day + sessionTime;
            Debug.WriteLine(sessionDate);
            Debug.WriteLine(sessionTime);
            Debug.WriteLine(time);
            time = time.Replace(".", "").Replace(" ", "").Replace("#", "").Replace("-", "");
            sql.Drop($"[{sessionName}_{time}]");
        }
    }
}
