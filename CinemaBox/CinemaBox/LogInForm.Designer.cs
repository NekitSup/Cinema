
namespace CinemaBox {
    partial class LogInForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.signInButt = new System.Windows.Forms.Button();
            this.ErrorPanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.showPassButt = new System.Windows.Forms.PictureBox();
            this.forgotPassLab = new System.Windows.Forms.Label();
            this.ErrorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPassButt)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(61, 53);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(211, 20);
            this.usernameTB.TabIndex = 0;
            this.usernameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LogInForm_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(66, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(61, 99);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(211, 20);
            this.passwordTB.TabIndex = 2;
            this.passwordTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LogInForm_KeyPress);
            // 
            // signInButt
            // 
            this.signInButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInButt.Location = new System.Drawing.Point(106, 161);
            this.signInButt.Name = "signInButt";
            this.signInButt.Size = new System.Drawing.Size(122, 33);
            this.signInButt.TabIndex = 4;
            this.signInButt.Text = "Sign in";
            this.signInButt.UseVisualStyleBackColor = true;
            this.signInButt.Click += new System.EventHandler(this.signInButt_Click);
            // 
            // ErrorPanel
            // 
            this.ErrorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ErrorPanel.Controls.Add(this.errorLabel);
            this.ErrorPanel.Location = new System.Drawing.Point(0, 0);
            this.ErrorPanel.Name = "ErrorPanel";
            this.ErrorPanel.Size = new System.Drawing.Size(342, 26);
            this.ErrorPanel.TabIndex = 5;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.Location = new System.Drawing.Point(3, 3);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(191, 20);
            this.errorLabel.TabIndex = 2;
            this.errorLabel.Text = "Заполните пустые поля";
            // 
            // showPassButt
            // 
            this.showPassButt.BackgroundImage = global::CinemaBox.Properties.Resources.icons8_eye_481;
            this.showPassButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showPassButt.Location = new System.Drawing.Point(278, 99);
            this.showPassButt.Name = "showPassButt";
            this.showPassButt.Size = new System.Drawing.Size(20, 20);
            this.showPassButt.TabIndex = 6;
            this.showPassButt.TabStop = false;
            this.showPassButt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPassButt_MouseDown);
            this.showPassButt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showPassButt_MouseUp);
            // 
            // forgotPassLab
            // 
            this.forgotPassLab.AutoSize = true;
            this.forgotPassLab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPassLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forgotPassLab.ForeColor = System.Drawing.Color.Blue;
            this.forgotPassLab.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.forgotPassLab.Location = new System.Drawing.Point(111, 132);
            this.forgotPassLab.Name = "forgotPassLab";
            this.forgotPassLab.Size = new System.Drawing.Size(115, 16);
            this.forgotPassLab.TabIndex = 7;
            this.forgotPassLab.Text = "Забыли пароль?";
            this.forgotPassLab.Click += new System.EventHandler(this.forgotPassLab_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(343, 204);
            this.Controls.Add(this.forgotPassLab);
            this.Controls.Add(this.showPassButt);
            this.Controls.Add(this.ErrorPanel);
            this.Controls.Add(this.signInButt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LogInForm_KeyPress);
            this.ErrorPanel.ResumeLayout(false);
            this.ErrorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPassButt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button signInButt;
        private System.Windows.Forms.Panel ErrorPanel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox showPassButt;
        private System.Windows.Forms.Label forgotPassLab;
    }
}