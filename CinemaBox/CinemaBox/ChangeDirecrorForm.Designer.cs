
namespace CinemaBox {
    partial class ChangeDirecrorForm {
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
            this.chooseDirCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newDirTB = new System.Windows.Forms.TextBox();
            this.changeDirButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите режиссера для изменения";
            // 
            // chooseDirCB
            // 
            this.chooseDirCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseDirCB.FormattingEnabled = true;
            this.chooseDirCB.Location = new System.Drawing.Point(12, 30);
            this.chooseDirCB.Name = "chooseDirCB";
            this.chooseDirCB.Size = new System.Drawing.Size(272, 26);
            this.chooseDirCB.TabIndex = 1;
            this.chooseDirCB.DropDown += new System.EventHandler(this.chooseDirCB_DropDown);
            this.chooseDirCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chooseDirCB_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите новое значение";
            // 
            // newDirTB
            // 
            this.newDirTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newDirTB.Location = new System.Drawing.Point(12, 80);
            this.newDirTB.Name = "newDirTB";
            this.newDirTB.Size = new System.Drawing.Size(272, 24);
            this.newDirTB.TabIndex = 3;
            this.newDirTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newDirTB_KeyPress);
            // 
            // changeDirButt
            // 
            this.changeDirButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeDirButt.Location = new System.Drawing.Point(99, 121);
            this.changeDirButt.Name = "changeDirButt";
            this.changeDirButt.Size = new System.Drawing.Size(108, 30);
            this.changeDirButt.TabIndex = 4;
            this.changeDirButt.Text = "Изменить";
            this.changeDirButt.UseVisualStyleBackColor = true;
            this.changeDirButt.Click += new System.EventHandler(this.changeDirButt_Click);
            // 
            // ChangeDirecrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 163);
            this.Controls.Add(this.changeDirButt);
            this.Controls.Add(this.newDirTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chooseDirCB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangeDirecrorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить режиссера";
            this.Load += new System.EventHandler(this.ChangeDirecrorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chooseDirCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newDirTB;
        private System.Windows.Forms.Button changeDirButt;
    }
}