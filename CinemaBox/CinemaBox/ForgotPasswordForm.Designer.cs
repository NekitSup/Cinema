
namespace CinemaBox {
    partial class ForgotPasswordForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.newPassTB = new System.Windows.Forms.TextBox();
            this.confirmNewPassTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.showPassButt = new System.Windows.Forms.PictureBox();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmCodeTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sendConfimCodeButt = new System.Windows.Forms.Button();
            this.changePassButt = new System.Windows.Forms.Button();
            this.confPassAcceptedPB = new System.Windows.Forms.PictureBox();
            this.confCodeAcceptedPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.showPassButt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confPassAcceptedPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confCodeAcceptedPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите новый пароль";
            // 
            // newPassTB
            // 
            this.newPassTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPassTB.Location = new System.Drawing.Point(12, 78);
            this.newPassTB.Name = "newPassTB";
            this.newPassTB.Size = new System.Drawing.Size(218, 24);
            this.newPassTB.TabIndex = 2;
            // 
            // confirmNewPassTB
            // 
            this.confirmNewPassTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmNewPassTB.Location = new System.Drawing.Point(12, 126);
            this.confirmNewPassTB.Name = "confirmNewPassTB";
            this.confirmNewPassTB.Size = new System.Drawing.Size(218, 24);
            this.confirmNewPassTB.TabIndex = 3;
            this.confirmNewPassTB.TextChanged += new System.EventHandler(this.confirmNewPassTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Подтвердите пароль";
            // 
            // showPassButt
            // 
            this.showPassButt.BackgroundImage = global::CinemaBox.Properties.Resources.icons8_eye_48;
            this.showPassButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showPassButt.Location = new System.Drawing.Point(236, 77);
            this.showPassButt.Name = "showPassButt";
            this.showPassButt.Size = new System.Drawing.Size(25, 25);
            this.showPassButt.TabIndex = 4;
            this.showPassButt.TabStop = false;
            this.showPassButt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPassButt_MouseDown);
            this.showPassButt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showPassButt_MouseUp);
            // 
            // userNameTB
            // 
            this.userNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameTB.Location = new System.Drawing.Point(12, 30);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.Size = new System.Drawing.Size(218, 24);
            this.userNameTB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите имя пользователя";
            // 
            // confirmCodeTB
            // 
            this.confirmCodeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmCodeTB.Location = new System.Drawing.Point(12, 213);
            this.confirmCodeTB.Name = "confirmCodeTB";
            this.confirmCodeTB.Size = new System.Drawing.Size(218, 24);
            this.confirmCodeTB.TabIndex = 5;
            this.confirmCodeTB.TextChanged += new System.EventHandler(this.confirmCodeTB_TextChanged);
            this.confirmCodeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirmCodeTB_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Введите код подтверждения";
            // 
            // sendConfimCodeButt
            // 
            this.sendConfimCodeButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendConfimCodeButt.Location = new System.Drawing.Point(11, 156);
            this.sendConfimCodeButt.Name = "sendConfimCodeButt";
            this.sendConfimCodeButt.Size = new System.Drawing.Size(219, 33);
            this.sendConfimCodeButt.TabIndex = 4;
            this.sendConfimCodeButt.Text = "Получить код подтверждения";
            this.sendConfimCodeButt.UseVisualStyleBackColor = true;
            this.sendConfimCodeButt.Click += new System.EventHandler(this.sendConfimCodeButt_Click);
            // 
            // changePassButt
            // 
            this.changePassButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePassButt.Location = new System.Drawing.Point(11, 243);
            this.changePassButt.Name = "changePassButt";
            this.changePassButt.Size = new System.Drawing.Size(219, 33);
            this.changePassButt.TabIndex = 6;
            this.changePassButt.Text = "Сменить пароль";
            this.changePassButt.UseVisualStyleBackColor = true;
            this.changePassButt.Click += new System.EventHandler(this.changePassButt_Click);
            // 
            // confPassAcceptedPB
            // 
            this.confPassAcceptedPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.confPassAcceptedPB.Location = new System.Drawing.Point(236, 125);
            this.confPassAcceptedPB.Name = "confPassAcceptedPB";
            this.confPassAcceptedPB.Size = new System.Drawing.Size(25, 25);
            this.confPassAcceptedPB.TabIndex = 11;
            this.confPassAcceptedPB.TabStop = false;
            // 
            // confCodeAcceptedPB
            // 
            this.confCodeAcceptedPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.confCodeAcceptedPB.Location = new System.Drawing.Point(236, 212);
            this.confCodeAcceptedPB.Name = "confCodeAcceptedPB";
            this.confCodeAcceptedPB.Size = new System.Drawing.Size(25, 25);
            this.confCodeAcceptedPB.TabIndex = 12;
            this.confCodeAcceptedPB.TabStop = false;
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 292);
            this.Controls.Add(this.confCodeAcceptedPB);
            this.Controls.Add(this.confPassAcceptedPB);
            this.Controls.Add(this.changePassButt);
            this.Controls.Add(this.sendConfimCodeButt);
            this.Controls.Add(this.confirmCodeTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showPassButt);
            this.Controls.Add(this.confirmNewPassTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPassTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Смена пароля";
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showPassButt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confPassAcceptedPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confCodeAcceptedPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newPassTB;
        private System.Windows.Forms.TextBox confirmNewPassTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox showPassButt;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmCodeTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sendConfimCodeButt;
        private System.Windows.Forms.Button changePassButt;
        private System.Windows.Forms.PictureBox confPassAcceptedPB;
        private System.Windows.Forms.PictureBox confCodeAcceptedPB;
    }
}