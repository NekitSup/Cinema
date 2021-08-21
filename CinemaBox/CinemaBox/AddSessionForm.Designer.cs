
namespace CinemaBox {
    partial class AddSessionForm {
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
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startSessionTimeDTP = new System.Windows.Forms.DateTimePicker();
            this.sessionNameCB = new System.Windows.Forms.ComboBox();
            this.clearAllLinesButt = new System.Windows.Forms.PictureBox();
            this.addSessionToBDButt = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.sessTimeTB = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clearAllLinesButt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addSessionToBDButt)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 24);
            this.label6.TabIndex = 59;
            this.label6.Text = "Время начала сеанса (H:mm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "Дата начала сеанса";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Название фильма";
            // 
            // startSessionTimeDTP
            // 
            this.startSessionTimeDTP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startSessionTimeDTP.Location = new System.Drawing.Point(376, 80);
            this.startSessionTimeDTP.Name = "startSessionTimeDTP";
            this.startSessionTimeDTP.Size = new System.Drawing.Size(200, 26);
            this.startSessionTimeDTP.TabIndex = 49;
            // 
            // sessionNameCB
            // 
            this.sessionNameCB.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sessionNameCB.FormattingEnabled = true;
            this.sessionNameCB.Items.AddRange(new object[] {
            "2D",
            "3D"});
            this.sessionNameCB.Location = new System.Drawing.Point(284, 12);
            this.sessionNameCB.Name = "sessionNameCB";
            this.sessionNameCB.Size = new System.Drawing.Size(292, 27);
            this.sessionNameCB.TabIndex = 47;
            this.sessionNameCB.DropDown += new System.EventHandler(this.sessionNameCB_DropDown);
            this.sessionNameCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sessionNameCB_KeyPress);
            // 
            // clearAllLinesButt
            // 
            this.clearAllLinesButt.BackgroundImage = global::CinemaBox.Properties.Resources.clear_icon_png_19;
            this.clearAllLinesButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearAllLinesButt.Location = new System.Drawing.Point(12, 175);
            this.clearAllLinesButt.Name = "clearAllLinesButt";
            this.clearAllLinesButt.Size = new System.Drawing.Size(39, 38);
            this.clearAllLinesButt.TabIndex = 46;
            this.clearAllLinesButt.TabStop = false;
            this.clearAllLinesButt.Click += new System.EventHandler(this.clearAllLinesButt_Click);
            // 
            // addSessionToBDButt
            // 
            this.addSessionToBDButt.BackgroundImage = global::CinemaBox.Properties.Resources.icons8_add_column_64;
            this.addSessionToBDButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addSessionToBDButt.Location = new System.Drawing.Point(58, 175);
            this.addSessionToBDButt.Name = "addSessionToBDButt";
            this.addSessionToBDButt.Size = new System.Drawing.Size(39, 38);
            this.addSessionToBDButt.TabIndex = 45;
            this.addSessionToBDButt.TabStop = false;
            this.addSessionToBDButt.Click += new System.EventHandler(this.addSessionToBDButt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 61;
            this.label2.Text = "Цена билета";
            // 
            // priceTB
            // 
            this.priceTB.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTB.Location = new System.Drawing.Point(479, 46);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(97, 27);
            this.priceTB.TabIndex = 60;
            // 
            // sessTimeTB
            // 
            this.sessTimeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sessTimeTB.Location = new System.Drawing.Point(529, 112);
            this.sessTimeTB.Mask = "00:00";
            this.sessTimeTB.Name = "sessTimeTB";
            this.sessTimeTB.Size = new System.Drawing.Size(47, 26);
            this.sessTimeTB.TabIndex = 62;
            this.sessTimeTB.ValidatingType = typeof(System.DateTime);
            // 
            // AddSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 225);
            this.Controls.Add(this.sessTimeTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startSessionTimeDTP);
            this.Controls.Add(this.sessionNameCB);
            this.Controls.Add(this.clearAllLinesButt);
            this.Controls.Add(this.addSessionToBDButt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddSessionForm";
            this.Text = "Добавить сеанс";
            this.Load += new System.EventHandler(this.AddSessionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clearAllLinesButt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addSessionToBDButt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startSessionTimeDTP;
        private System.Windows.Forms.ComboBox sessionNameCB;
        private System.Windows.Forms.PictureBox clearAllLinesButt;
        private System.Windows.Forms.PictureBox addSessionToBDButt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.MaskedTextBox sessTimeTB;
    }
}