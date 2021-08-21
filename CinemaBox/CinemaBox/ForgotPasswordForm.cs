using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace CinemaBox {
    public partial class ForgotPasswordForm : Form {
        DataBaseSQL sql;
        Random r;

        int confCode;

        string path;
        public ForgotPasswordForm() {
            InitializeComponent();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e) {
            sql = new DataBaseSQL();
            sql.ConnectToBD();

            r = new Random();


            confPassAcceptedPB.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\PB\decline.png");
            confCodeAcceptedPB.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\PB\decline.png");

            confirmCodeTB.Enabled = false;
            changePassButt.Enabled = false;
            sendConfimCodeButt.Enabled = false;

            newPassTB.UseSystemPasswordChar = true;
            confirmNewPassTB.UseSystemPasswordChar = true;
        }

        private void sendConfimCodeButt_Click(object sender, EventArgs e) {
            string username = sql.SelectStringSQL("Login", "Login", $"Login = '{userNameTB.Text}'");
            string phone = sql.SelectStringSQL("Phone", "Login", $"Login = '{userNameTB.Text}'");

            if (!string.IsNullOrWhiteSpace(userNameTB.Text)) {
                if (!string.IsNullOrWhiteSpace(username)) {
                    if (!string.IsNullOrWhiteSpace(newPassTB.Text) || !string.IsNullOrWhiteSpace(confirmNewPassTB.Text)) {
                        confCode = r.Next(100000, 999999);

                        path = Directory.GetCurrentDirectory() + $"\\ConfCodes\\{userNameTB.Text}.txt";

                        using (FileStream fs = File.Create(path)) {
                            fs.Close();
                            using (StreamWriter sw = new StreamWriter(path)) {
                                sw.WriteLine($"Сообщение на номер {phone}\n");
                                sw.WriteLine($"Код подтверждения для пользователя {username}: {confCode}");
                                sw.WriteLine("Никому не говорите свой код подтверждения");
                                sw.WriteLine("Если вы не пытались поменять свой пароль, обратитесь к администратору системы");

                                sw.Close();

                                sendConfimCodeButt.Enabled = false;

                                confirmCodeTB.Enabled = true;

                                userNameTB.Enabled = false;
                                newPassTB.Enabled = false;
                                confirmNewPassTB.Enabled = false;
                            }
                            Process.Start(path);
                        }
                    } else {
                        MessageBox.Show("Введите новый пароль и подтвердите его", "Внимание", MessageBoxButtons.OK);
                    }
                } else {
                    MessageBox.Show("Данного пользователя не существует", "Внимание", MessageBoxButtons.OK);
                }
            } else {
                changePassButt.Enabled = false;
                confirmCodeTB.Enabled = false;
                MessageBox.Show("Введите имя пользователя", "Внимание", MessageBoxButtons.OK);
            }
        }

        private void showPassButt_MouseDown(object sender, MouseEventArgs e) {
            newPassTB.UseSystemPasswordChar = false;
            confirmNewPassTB.UseSystemPasswordChar = false;
        }

        private void showPassButt_MouseUp(object sender, MouseEventArgs e) {
            newPassTB.UseSystemPasswordChar = true;
            confirmNewPassTB.UseSystemPasswordChar = true;
        }

        private void confirmNewPassTB_TextChanged(object sender, EventArgs e) {
            if(!string.IsNullOrWhiteSpace(newPassTB.Text) && !string.IsNullOrWhiteSpace(confirmNewPassTB.Text)) {
                if (newPassTB.Text == confirmNewPassTB.Text) {
                    confPassAcceptedPB.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\PB\accept.png");
                    sendConfimCodeButt.Enabled = true;
                } else {
                    confPassAcceptedPB.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\PB\decline.png");
                    sendConfimCodeButt.Enabled = false;
                }
            }
        }

        private void confirmCodeTB_TextChanged(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(confirmCodeTB.Text)) {
                if (Convert.ToInt32(confirmCodeTB.Text) == confCode) {
                    confCodeAcceptedPB.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\PB\accept.png");
                    changePassButt.Enabled = true;
                } else {
                    confCodeAcceptedPB.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\PB\decline.png");
                    changePassButt.Enabled = false;
                }
            }
        }

        private void changePassButt_Click(object sender, EventArgs e) {
            sql.updateSQL("[Login]", $"[Password] = {newPassTB.Text}", $"[Login] = '{userNameTB.Text}'");

            MessageBox.Show("Пароль успешно изменен", "Внимание", MessageBoxButtons.OK);
            this.Close();
        }

        private void confirmCodeTB_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)) e.Handled = true;
        }
    }
}
