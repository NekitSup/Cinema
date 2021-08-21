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

namespace CinemaBox
{
    public partial class ChangeFilmInfoForm : Form
    {
        DataBaseSQL sql;

        public string[] genres = new string[]{"Аниме", "Биографический", "Боевик", "Бестерн", "Военный", "Детектив",
            "Детский", "Документальный", "Драма", "Исторический", "Кинокомикс", "Комедия", "Концерт", "Короткометражный",
            "Криминал", "Мелодрама", "Мистика", "Музыка", "Мультфильм", "Мюзикл", "Научный", "Нуар", "Приключения",
            "Реалити-шоу", "Семейный", "Спорт", "Ток-шоу", "Триллер", "Ужасы", "Фантастика", "Фэнтези", "Эротика"};

        string[] genresArr;

        public ChangeFilmInfoForm()
        {
            InitializeComponent();
        }

        private void ChangeFilmInfoForm_Load(object sender, EventArgs e)
        {
            sql = new DataBaseSQL();
            sql.ConnectToBD();
            filmNameTB.Text = mainForm.filmName;
            filmTypeCB.Text = mainForm.filmType;
            durationTB.Text = mainForm.filmDuration.ToString();


            filmGenreCLB.CheckOnClick = true;
            addDir();
            filmGenreCLB.Items.AddRange(genres);


            string g = mainForm.filmGenre;
            genresArr = g.Split(',');
            for (int i = 0; i < genresArr.Length; i++)
                genresArr[i] = genresArr[i].Trim();
            Array.Sort(genresArr);

            for (int i = 0; i < filmGenreCLB.Items.Count; i++)
            {
                foreach (string j in genresArr)
                {
                    if (System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(j) == filmGenreCLB.Items[i].ToString())
                    {
                        filmGenreCLB.SetItemCheckState(i, CheckState.Checked);
                    }
                }
            }

            string d = mainForm.filmDirector;
            filmDirectorCB.Text = d;
        }
        

        void addDir()
        {
            sql.AddInComboBoxSQL(filmDirectorCB, "DirectorsName", "Directors", "DirectorsName");
        }

        private void deleteDirectorButt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(filmDirectorCB.Text))
            {
                MessageBox.Show("Выберите режиссера для удаления", "Внимание");
            }
            else
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить выбранный элемент?", "Удалить элемент?", MessageBoxButtons.YesNoCancel);
                if (result != DialogResult.Yes) return;
                else
                {
                    string dirName = filmDirectorCB.Text;
                    

                    sql.DeleteSQL("", "Directors", $"DirectorsName = '{dirName}'");
                    filmDirectorCB.Text = "";
                    addDir();
                }
            }
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

        private void changeFilmInfoButt_Click(object sender, EventArgs e)
        {
            string[] genresArr = new string[filmGenreCLB.CheckedItems.Count];
            string dir = filmDirectorCB.Text;
            for (int i = 0; i < filmGenreCLB.CheckedItems.Count; i++)
            {
                genresArr[i] = filmGenreCLB.CheckedItems[i].ToString();
            }
            

            string genres = string.Join(", ", genresArr);
            int typeCode = sql.SelectIntSQL("TypeCode", "Types", $"TypeName = '{filmTypeCB.Text}'");
            int dirCode = sql.SelectIntSQL("DirectorCode", "Directors", $"DirectorsName = '{dir}'");
            int filmType = sql.SelectIntSQL("TypeCode", "Types", $"TypeName = '{mainForm.filmType}'");

            sql.updateSQL("Films", 
                $"FilmName = '{filmNameTB.Text}'" +
                $", FilmType = {typeCode}" +
                $", FilmGenre = '{genres}'" +
                $", FilmDirector = {dirCode}" +
                $", FilmDuration = {durationTB.Text}",
                $"FilmName = '{mainForm.filmName}' and FilmType = {filmType}");
            
            this.Close();
            mainForm MainForm = new mainForm();
            MainForm.Focus();
        }


        private void filmGenreCLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmGenreCLB.SelectedItem = null;
        }

        private void filmTypeCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
