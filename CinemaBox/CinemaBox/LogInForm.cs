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
    public partial class LogInForm : Form {
        DataBaseSQL sql;

        public static string log, roleName;
        public static int role;

        public LogInForm() {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e) {
            sql = new DataBaseSQL();
            sql.ConnectToBD();
            ErrorPanel.Hide();

            passwordTB.UseSystemPasswordChar = true;
        }

        private void LogInForm_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter)
                signIn();
        }

        private void signInButt_Click(object sender, EventArgs e) {
            signIn();
        }

        private void showPassButt_MouseDown(object sender, MouseEventArgs e) {
            passwordTB.UseSystemPasswordChar = false;
        }

        private void showPassButt_MouseUp(object sender, MouseEventArgs e) {
            passwordTB.UseSystemPasswordChar = true;
        }

        private void forgotPassLab_Click(object sender, EventArgs e) {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.ShowDialog();
        }

        private void signIn() {
            string password = string.Empty;
            password = sql.SelectStringSQL("Password", "Login", $"Login = '{usernameTB.Text}'");
            if (!string.IsNullOrEmpty(usernameTB.Text) && !string.IsNullOrEmpty(passwordTB.Text)) {
                if (string.IsNullOrWhiteSpace(password)) {
                    ErrorPanel.Show();
                    errorLabel.Text = "Пользователь отсутствует";

                } else {
                    if (password == passwordTB.Text) {
                        log = sql.SelectStringSQL("Login", "Login", $"Login = '{usernameTB.Text}'");
                        role = sql.SelectIntSQL("LoginType", "Login", $"Login = '{usernameTB.Text}'");
                        roleName = sql.SelectStringSQL("LoginTypeName", "LoginType", $"LoginTypeId = {role}");
                        mainForm mainForm = new mainForm();
                        this.Hide();
                        ErrorPanel.Hide();
                        usernameTB.Clear();
                        passwordTB.Clear();
                        mainForm.ShowDialog();
                        this.Show();
                        usernameTB.Focus();
                    } else {
                        ErrorPanel.Show();
                        errorLabel.Text = "Неверный пароль";
                        passwordTB.Clear();
                    }
                }
            } else {
                ErrorPanel.Show();
                errorLabel.Text = "Заполните пустые поля";
            }
        }
    }
}
