
namespace CinemaBox {
    partial class OffersForm {
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
            this.mainDGV = new System.Windows.Forms.DataGridView();
            this.acceptOfferButt = new System.Windows.Forms.Button();
            this.declineOfferButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDGV
            // 
            this.mainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDGV.Location = new System.Drawing.Point(12, 12);
            this.mainDGV.Name = "mainDGV";
            this.mainDGV.Size = new System.Drawing.Size(776, 348);
            this.mainDGV.TabIndex = 0;
            this.mainDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDGV_CellClick);
            // 
            // acceptOfferButt
            // 
            this.acceptOfferButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptOfferButt.Location = new System.Drawing.Point(12, 366);
            this.acceptOfferButt.Name = "acceptOfferButt";
            this.acceptOfferButt.Size = new System.Drawing.Size(126, 51);
            this.acceptOfferButt.TabIndex = 1;
            this.acceptOfferButt.Text = "Принять прокат";
            this.acceptOfferButt.UseVisualStyleBackColor = true;
            this.acceptOfferButt.Click += new System.EventHandler(this.acceptOfferButt_Click);
            // 
            // declineOfferButt
            // 
            this.declineOfferButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.declineOfferButt.Location = new System.Drawing.Point(144, 366);
            this.declineOfferButt.Name = "declineOfferButt";
            this.declineOfferButt.Size = new System.Drawing.Size(126, 51);
            this.declineOfferButt.TabIndex = 2;
            this.declineOfferButt.Text = "Отклонить прокат";
            this.declineOfferButt.UseVisualStyleBackColor = true;
            this.declineOfferButt.Click += new System.EventHandler(this.declineOfferButt_Click);
            // 
            // OffersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.declineOfferButt);
            this.Controls.Add(this.acceptOfferButt);
            this.Controls.Add(this.mainDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OffersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Предложения проката";
            this.Load += new System.EventHandler(this.OffersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView mainDGV;
        private System.Windows.Forms.Button acceptOfferButt;
        private System.Windows.Forms.Button declineOfferButt;
    }
}