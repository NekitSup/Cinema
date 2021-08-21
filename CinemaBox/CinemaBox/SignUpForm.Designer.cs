
namespace CinemaBox {
    partial class SignUpForm {
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
            this.logInTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roleCB = new System.Windows.Forms.ComboBox();
            this.signUpButt = new System.Windows.Forms.Button();
            this.showPassButt = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneTB = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.showPassButt)).BeginInit();
            this.SuspendLayout();
            // 
            // logInTB
            // 
            this.logInTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logInTB.Location = new System.Drawing.Point(12, 30);
            this.logInTB.Name = "logInTB";
            this.logInTB.Size = new System.Drawing.Size(195, 22);
            this.logInTB.TabIndex = 0;
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTB.Location = new System.Drawing.Point(12, 87);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(195, 22);
            this.passwordTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите LogIn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Выберите роль";
            // 
            // roleCB
            // 
            this.roleCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleCB.FormattingEnabled = true;
            this.roleCB.Location = new System.Drawing.Point(12, 207);
            this.roleCB.Name = "roleCB";
            this.roleCB.Size = new System.Drawing.Size(195, 24);
            this.roleCB.TabIndex = 5;
            this.roleCB.DropDown += new System.EventHandler(this.roleCB_DropDown);
            this.roleCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roleCB_KeyPress);
            // 
            // signUpButt
            // 
            this.signUpButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpButt.Location = new System.Drawing.Point(43, 251);
            this.signUpButt.Name = "signUpButt";
            this.signUpButt.Size = new System.Drawing.Size(146, 31);
            this.signUpButt.TabIndex = 6;
            this.signUpButt.Text = "Зарегистрировать";
            this.signUpButt.UseVisualStyleBackColor = true;
            this.signUpButt.Click += new System.EventHandler(this.signUpButt_Click);
            // 
            // showPassButt
            // 
            this.showPassButt.BackgroundImage = global::CinemaBox.Properties.Resources.icons8_eye_48;
            this.showPassButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showPassButt.Location = new System.Drawing.Point(213, 87);
            this.showPassButt.Name = "showPassButt";
            this.showPassButt.Size = new System.Drawing.Size(25, 25);
            this.showPassButt.TabIndex = 7;
            this.showPassButt.TabStop = false;
            this.showPassButt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPassButt_MouseDown);
            this.showPassButt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showPassButt_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введите номер телефона";
            // 
            // phoneTB
            // 
            this.phoneTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTB.Location = new System.Drawing.Point(12, 148);
            this.phoneTB.Mask = "+7 (999) 000-00-00";
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(195, 24);
            this.phoneTB.TabIndex = 10;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 289);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showPassButt);
            this.Controls.Add(this.signUpButt);
            this.Controls.Add(this.roleCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.logInTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация нового пользователя";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showPassButt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logInTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox roleCB;
        private System.Windows.Forms.Button signUpButt;
        private System.Windows.Forms.PictureBox showPassButt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox phoneTB;
    }
}