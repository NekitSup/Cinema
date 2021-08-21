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
    public partial class OffersForm : Form {
        DataBaseSQL sql;
        int offerID;
        //Для выборки из бд
        string offerType, offerCat, offerDir;
        //Для добавления в Films
        int offTypeINT, offDirINT, offCatINT, offDurINT;
        string offFilmName, offFilmGenres, offFilmDescrib, offSFD, offEFD;

        public OffersForm() {
            InitializeComponent();
        }

        private void OffersForm_Load(object sender, EventArgs e) {
            sql = new DataBaseSQL();
            sql.ConnectToBD();

            offerSQL();
        }

        void offerSQL() {
            string q = "select ID_Offer as [Номер предложения], OfferCompany as [Компания - поставщик]" +
                ", OfferName as [Название фильма], OfferType as [Тип фильма], OfferDuration as [Длительность фильма]" +
                ", OfferGenres as [Жанры фильма], OfferDirector as [Режиссер фильма]" +
                ", OfferCategory as [Категория фильма], OfferStartPrice as [Начальная цена проката]" +
                " from Offers";

            sql.MainQuery(q, mainDGV, this);

            if (mainDGV.Rows.Count > 1) {
                offerID = Convert.ToInt32(mainDGV.Rows[0].Cells[0].Value);
                offerType = mainDGV.Rows[0].Cells[3].Value.ToString();
                offerDir = mainDGV.Rows[0].Cells[6].Value.ToString();
                offerCat = mainDGV.Rows[0].Cells[7].Value.ToString();
                moreOffInfo();
            }
        }

        private void mainDGV_CellClick(object sender, DataGridViewCellEventArgs e) {
            offerID = Convert.ToInt32(mainDGV.Rows[e.RowIndex].Cells[0].Value);
            offerType = mainDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            offerDir = mainDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
            offerCat = mainDGV.Rows[e.RowIndex].Cells[7].Value.ToString();
            moreOffInfo();

            if (e.RowIndex == mainDGV.NewRowIndex || e.RowIndex < 0)
                return;
        }

        void moreOffInfo() {
            offFilmName = sql.SelectStringSQL("OfferName", "Offers", $"ID_Offer = {offerID}");
            offFilmGenres = sql.SelectStringSQL("OfferGenres", "Offers", $"ID_Offer = {offerID}");
            offFilmDescrib = sql.SelectStringSQL("OfferDescription", "Offers", $"ID_Offer = {offerID}");
            offSFD = sql.SelectStringSQL("OfferStartFilmDate", "Offers", $"ID_Offer = {offerID}");
            offEFD = sql.SelectStringSQL("OfferEndFilmDate", "Offers", $"ID_Offer = {offerID}");
            offDurINT = sql.SelectIntSQL("OfferDuration", "Offers", $"ID_Offer = {offerID}");

            offTypeINT = sql.SelectIntSQL("TypeCode", "Types", $"TypeName = '{offerType}'");
            offDirINT = sql.SelectIntSQL("DirectorCode", "Directors", $"DirectorsName = '{offerDir}'");
            offCatINT = sql.SelectIntSQL("CategoryCode", "Categories", $"CategoryName = '{offerCat}'");
        }

        private void declineOfferButt_Click(object sender, EventArgs e) {
            DialogResult result;

            result = MessageBox.Show("Вы действительно хотите отказаться от проката?", "Внимание", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                sql.DeleteSQL("", "Offers", $"ID_Offer = {offerID}");
                offerSQL();
            } else
                return;
        }

        private void acceptOfferButt_Click(object sender, EventArgs e) {
            if (offDirINT == 0) {
                sql.InsertValueSQL("Directors", "DirectorsName", $"'{offerDir}'");
            }

            sql.InsertValueSQL("[Films]", "[FilmName], [FilmType], [FilmDuration], [FilmGenre], [FilmDirector], [FilmCategory]" +
                ", [FilmDescription], [StartFilmDate], [EndFilmDate]"
                , $"'{offFilmName}', {offTypeINT}, {offDurINT}, '{offFilmGenres}', {offDirINT}, {offCatINT}" +
                $", '{offFilmDescrib}', {DateTime.Parse(offSFD).ToString("#yyyy-MM-dd#")}" +
                $", {DateTime.Parse(offEFD).ToString("#yyyy-MM-dd#")}");

            sql.DeleteSQL("", "Offers", $"ID_Offer = {offerID}");
            MessageBox.Show("Фильма успешно добавлен в прокат");

            offerSQL();

        }
    }
}
