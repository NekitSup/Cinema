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
    public partial class ChangeDirecrorForm : Form {
        DataBaseSQL sql;
        public ChangeDirecrorForm() {
            InitializeComponent();
        }

        private void ChangeDirecrorForm_Load(object sender, EventArgs e) {
            sql = new DataBaseSQL();
            sql.ConnectToBD();
        }

        private void chooseDirCB_DropDown(object sender, EventArgs e) {
            sql.AddInComboBoxSQL(chooseDirCB, "DirectorsName", "Directors", "DirectorsName");
        }

        private void changeDirButt_Click(object sender, EventArgs e) {
            string dirInBD = sql.SelectStringSQL("DirectorsName", "Directors", $"DirectorsName = '{newDirTB.Text}'");

            if(!string.IsNullOrWhiteSpace(chooseDirCB.Text) && !string.IsNullOrWhiteSpace(newDirTB.Text)) {
                if (string.IsNullOrWhiteSpace(dirInBD)){
                    sql.updateSQL("Directors", $"DirectorsName = '{newDirTB.Text}'", $"DirectorsName = '{chooseDirCB.Text}'");
                    MessageBox.Show("Данные о режиссере успешно обновлены", "Внимание", MessageBoxButtons.OK);
                    this.Close();
                } else {
                    MessageBox.Show("Режиссер с таким именем уже существует", "Внимание", MessageBoxButtons.OK);
                }
            } else {
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK);
            }
        }

        private void chooseDirCB_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void newDirTB_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') e.Handled = true;
            else e.Handled = false;
        }
    }
}
