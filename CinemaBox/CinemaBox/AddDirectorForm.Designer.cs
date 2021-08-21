
namespace CinemaBox {
    partial class AddDirectorForm {
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
            this.dirNameTB = new System.Windows.Forms.TextBox();
            this.addDirButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите режиссера";
            // 
            // dirNameTB
            // 
            this.dirNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dirNameTB.Location = new System.Drawing.Point(12, 30);
            this.dirNameTB.Name = "dirNameTB";
            this.dirNameTB.Size = new System.Drawing.Size(272, 24);
            this.dirNameTB.TabIndex = 1;
            this.dirNameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dirNameTB_KeyPress);
            // 
            // addDirButt
            // 
            this.addDirButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDirButt.Location = new System.Drawing.Point(84, 74);
            this.addDirButt.Name = "addDirButt";
            this.addDirButt.Size = new System.Drawing.Size(125, 33);
            this.addDirButt.TabIndex = 2;
            this.addDirButt.Text = "Добавить";
            this.addDirButt.UseVisualStyleBackColor = true;
            this.addDirButt.Click += new System.EventHandler(this.addDirButt_Click);
            // 
            // AddDirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 119);
            this.Controls.Add(this.addDirButt);
            this.Controls.Add(this.dirNameTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddDirectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить режиссера";
            this.Load += new System.EventHandler(this.AddDirectorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dirNameTB;
        private System.Windows.Forms.Button addDirButt;
    }
}