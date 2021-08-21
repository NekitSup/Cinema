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
    public partial class SignUpForm : Form {
        DataBaseSQL sql;

        int roleID;
        public SignUpForm() {
            InitializeComponent();
        }

        private void signUpButt_Click(object sender, EventArgs e) {
            roleID = sql.SelectIntSQL("LoginTypeId", "LoginType", $"LoginTypeName = '{roleCB.Text}'");

            try {
                if (string.IsNullOrWhiteSpace(logInTB.Text) || string.IsNullOrWhiteSpace(passwordTB.Text)
                    || string.IsNullOrWhiteSpace(roleCB.Text) || string.IsNullOrWhiteSpace(phoneTB.Text))
                    MessageBox.Show("Заполните все поля", "Внимание");
                else
                    sql.InsertValueSQL("[Login]", "[Login], [Password], [LoginType], [Phone]", $"'{logInTB.Text}', '{passwordTB.Text}', {roleID}, '{phoneTB.Text}'");
            } catch {
                MessageBox.Show("Пользователь с таким LogIn'ом уже существует", "Внимание");
            }

            MessageBox.Show($"Пользователь {logInTB.Text} успешно добавлен", "Пользователь добавлен", MessageBoxButtons.OK);

            this.Close();
        }

        private void SignUpForm_Load(object sender, EventArgs e) {
            sql = new DataBaseSQL();
            sql.ConnectToBD();

            passwordTB.UseSystemPasswordChar = true;
        }

        private void roleCB_DropDown(object sender, EventArgs e) {
            sql.AddInComboBoxSQL(roleCB, "LoginTypeName", "LoginType", "LoginTypeId");
        }

        private void showPassButt_MouseDown(object sender, MouseEventArgs e) {
            passwordTB.UseSystemPasswordChar = false;
        }

        private void showPassButt_MouseUp(object sender, MouseEventArgs e) {
            passwordTB.UseSystemPasswordChar = true;
        }

        private void roleCB_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }
    }
}
