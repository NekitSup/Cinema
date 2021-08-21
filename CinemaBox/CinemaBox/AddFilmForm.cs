using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBox
{
    public partial class AddFilmForm : Form
    {
        DataBaseSQL sql;

        public string[] genres = new string[]{"Аниме", "Биографический", "Боевик", "Вестерн", "Военный", "Детектив",
            "Детский", "Документальный", "Драма", "Исторический", "Кинокомикс", "Комедия", "Концерт", "Короткометражный",
            "Криминал", "Мелодрама", "Мистика", "Музыка", "Мультфильм", "Мюзикл", "Научный", "Нуар", "Приключения",
            "Реалити-шоу", "Семейный", "Спорт", "Ток-шоу", "Триллер", "Ужасы", "Фантастика", "Фэнтези", "Эротика"};

        public AddFilmForm()
        {
            InitializeComponent();
        }

        private void AddFilmForm_Load(object sender, EventArgs e)
        {
            sql = new DataBaseSQL();
            sql.ConnectToBD();


            filmGenreCLB.CheckOnClick = true;

            filmGenreCLB.Items.AddRange(genres);
            addDir();
        }

        
        //Добавление режиссеров в CLB
        void addDir()
        {
            sql.AddInComboBoxSQL(filmDirectorCB, "DirectorsName", "Directors", "DirectorsName");
        }


        private void acceptAddingDirectorButt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filmDirectorCB.Text))
            {
                MessageBox.Show("Заполните поле для добавления режиссера", "Ошибка!", MessageBoxButtons.OK);
            }
            else
            {
                sql.InsertValueSQL("Directors", "DirectorsName", $"'{filmDirectorCB.Text}'");

                addDir();
            }
        }

        private void deleteDirectorButt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(filmDirectorCB.Text))
            {
                MessageBox.Show("Выберите только 1 элемент для удаления");
            }
            else
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Удалить элемент?", MessageBoxButtons.YesNoCancel);
                if (result != DialogResult.Yes) return;
                else
                {
                    string dirName = filmDirectorCB.Text;
                    

                    sql.DeleteSQL("", "Directors", $"DirectorsName = '{dirName}'");

                    addDir();
                    filmDirectorCB.Text = "";
                }
            }
        }

        private void clearAllLinesButt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите очистить все поля?", "Очистить поля?", MessageBoxButtons.YesNoCancel);

            if (result != DialogResult.Yes) return;
            else
            {
                filmCategoryCB.Text = "";
                filmDescribRTB.Text = "";

                filmDurationTB.Text = "";
                for (int i = 0; i < filmGenreCLB.Items.Count; i++)
                    filmGenreCLB.SetItemCheckState(i, CheckState.Unchecked);
                filmDirectorCB.Text = "";
                filmInterval.Text = "";
                filmGenreCLB.ClearSelected(); // не снимает флаг
                filmNameTB.Text = "";
                filmTypeCB.Text = "";
            }
        }

        private void addFilmToBDButt_Click(object sender, EventArgs e)
        {
            if (filmInterval.SelectedIndex == 0)
                sqlInsert(7);
            else if (filmInterval.SelectedIndex == 1)
                sqlInsert(14);
            else if (filmInterval.SelectedIndex == 2)
                sqlInsert(21);
            else if (filmInterval.SelectedIndex == 3)
                sqlInsert(30);
        }

        private void sqlInsert(int interval) {
            var texts = new List<string>(new string[] { filmNameTB.Text, filmDurationTB.Text, filmCategoryCB.Text,
            filmDescribRTB.Text, filmInterval.Text, filmTypeCB.Text});

            string condition = texts.Find(cond => string.IsNullOrEmpty(cond));
            if (condition == "" || string.IsNullOrWhiteSpace(filmDirectorCB.Text) || filmGenreCLB.CheckedItems == null) {
                MessageBox.Show("Все поля должны быть заполнены!");
            } else {
                string[] genresArr = new string[filmGenreCLB.CheckedItems.Count];
                string dir = filmDirectorCB.Text;
                for (int i = 0; i < filmGenreCLB.CheckedItems.Count; i++) {
                    genresArr[i] = filmGenreCLB.CheckedItems[i].ToString();
                }


                string genres = string.Join(", ", genresArr);

                int typeCode = sql.SelectIntSQL("TypeCode", "Types", $"TypeName = '{filmTypeCB.Text}'");
                int catCode = sql.SelectIntSQL("CategoryCode", "Categories", $"CategoryName = '{filmCategoryCB.Text}'");
                int dirCode = sql.SelectIntSQL("DirectorCode", "Directors", $"DirectorsName = '{dir}'");


                sql.InsertValueSQL("Films", "FilmName, FilmType, FilmDuration, FilmGenre, FilmDirector, FilmCategory, FilmDescription, StartFilmDate, EndFilmDate",
                    $"'{filmNameTB.Text}'" +
                    $", {typeCode}" +
                    $", '{filmDurationTB.Text}'" +
                    $", '{genres}'" +
                    $", {dirCode}" +
                    $", {catCode}" +
                    $", '{filmDescribRTB.Text}'" +
                    $", {DateTime.Now.ToString("#yyyy-MM-dd#")}" +
                    $", {DateTime.Now.AddDays(interval).ToString("#yyyy-MM-dd#")}");

                this.Close();
                mainForm main = new mainForm();
                main.Focus();
            }
        }

        private void filmGenreCLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmGenreCLB.SelectedItem = null;
        }

        private void filmTypeCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void filmPriceTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)) e.Handled = true;
        }

        private void filmDurationTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)) e.Handled = true;
        }

        private void filmCategoryCB_DropDown(object sender, EventArgs e) {
            sql.AddInComboBoxSQL(filmCategoryCB, "CategoryName", "Categories", "CategoryCode");
        }

        private void filmTypeCB_DropDown(object sender, EventArgs e) {
            sql.AddInComboBoxSQL(filmTypeCB, "TypeName", "Types", "TypeName");
        }
    }
}
