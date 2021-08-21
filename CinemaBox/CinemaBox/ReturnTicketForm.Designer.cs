
namespace CinemaBox {
    partial class ReturnTicketForm {
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
            this.tickIDTB = new System.Windows.Forms.NumericUpDown();
            this.returnTickButt = new System.Windows.Forms.Button();
            this.filmNameLab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.findTickButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tickIDTB)).BeginInit();
            this.SuspendLayout();
            // 
            // tickIDTB
            // 
            this.tickIDTB.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tickIDTB.Location = new System.Drawing.Point(16, 34);
            this.tickIDTB.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tickIDTB.Name = "tickIDTB";
            this.tickIDTB.Size = new System.Drawing.Size(94, 27);
            this.tickIDTB.TabIndex = 13;
            this.tickIDTB.ValueChanged += new System.EventHandler(this.tickIDTB_ValueChanged);
            this.tickIDTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tickIDTB_KeyPress);
            // 
            // returnTickButt
            // 
            this.returnTickButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnTickButt.Location = new System.Drawing.Point(131, 79);
            this.returnTickButt.Name = "returnTickButt";
            this.returnTickButt.Size = new System.Drawing.Size(107, 38);
            this.returnTickButt.TabIndex = 12;
            this.returnTickButt.Text = "Вернуть билет";
            this.returnTickButt.UseVisualStyleBackColor = true;
            this.returnTickButt.Click += new System.EventHandler(this.returnTickButt_Click);
            // 
            // filmNameLab
            // 
            this.filmNameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filmNameLab.Location = new System.Drawing.Point(140, 34);
            this.filmNameLab.Name = "filmNameLab";
            this.filmNameLab.Size = new System.Drawing.Size(157, 42);
            this.filmNameLab.TabIndex = 11;
            this.filmNameLab.Text = "filmName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(140, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Найден фильм:";
            // 
            // findTickButt
            // 
            this.findTickButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findTickButt.Location = new System.Drawing.Point(13, 79);
            this.findTickButt.Name = "findTickButt";
            this.findTickButt.Size = new System.Drawing.Size(97, 38);
            this.findTickButt.TabIndex = 9;
            this.findTickButt.Text = "Найти фильм";
            this.findTickButt.UseVisualStyleBackColor = true;
            this.findTickButt.Click += new System.EventHandler(this.findTickButt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите код билета";
            // 
            // ReturnTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(278, 133);
            this.Controls.Add(this.tickIDTB);
            this.Controls.Add(this.returnTickButt);
            this.Controls.Add(this.filmNameLab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findTickButt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReturnTicketForm";
            this.Text = "ReturnTicketForm";
            this.Load += new System.EventHandler(this.ReturnTicketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tickIDTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown tickIDTB;
        private System.Windows.Forms.Button returnTickButt;
        private System.Windows.Forms.Label filmNameLab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button findTickButt;
        private System.Windows.Forms.Label label1;
    }
}