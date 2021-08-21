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
    public partial class AddDirectorForm : Form {
        DataBaseSQL sql;
        
        public AddDirectorForm() {
            InitializeComponent();
        }

        private void AddDirectorForm_Load(object sender, EventArgs e) {
            sql = new DataBaseSQL();
            sql.ConnectToBD();
        }

        private void addDirButt_Click(object sender, EventArgs e) {
            string directorFromBD = sql.SelectStringSQL("DirectorsName", "Directors", $"DirectorsName = '{dirNameTB.Text}'");

            if (!string.IsNullOrWhiteSpace(dirNameTB.Text)) {
                if (string.IsNullOrWhiteSpace(directorFromBD)) {
                    sql.InsertValueSQL("[Directors]", "[DirectorsName]", $"'{dirNameTB.Text}'");
                    MessageBox.Show("Режиссер успешно добавлен", "Внимание", MessageBoxButtons.OK);
                    this.Close();
                } else {
                    MessageBox.Show("Такой режиссер уже существует", "Внимание", MessageBoxButtons.OK);
                }
            }
        }

        private void dirNameTB_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') e.Handled = true;
            else e.Handled = false;
        }
    }
}
