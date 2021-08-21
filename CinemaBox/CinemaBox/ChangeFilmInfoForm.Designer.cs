namespace CinemaBox
{
    partial class ChangeFilmInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.changeFilmInfoButt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.filmGenreCLB = new System.Windows.Forms.CheckedListBox();
            this.filmTypeCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filmNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteDirectorButt = new System.Windows.Forms.PictureBox();
            this.acceptAddingDirectorButt = new System.Windows.Forms.PictureBox();
            this.filmDirectorCB = new System.Windows.Forms.ComboBox();
            this.durationTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deleteDirectorButt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptAddingDirectorButt)).BeginInit();
            this.SuspendLayout();
            // 
            // changeFilmInfoButt
            // 
            this.changeFilmInfoButt.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeFilmInfoButt.Location = new System.Drawing.Point(97, 250);
            this.changeFilmInfoButt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.changeFilmInfoButt.Name = "changeFilmInfoButt";
            this.changeFilmInfoButt.Size = new System.Drawing.Size(137, 34);
            this.changeFilmInfoButt.TabIndex = 49;
            this.changeFilmInfoButt.Text = "Изменить";
            this.changeFilmInfoButt.UseVisualStyleBackColor = true;
            this.changeFilmInfoButt.Click += new System.EventHandler(this.changeFilmInfoButt_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 35);
            this.label5.TabIndex = 42;
            this.label5.Text = "Режиссер фильма";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Жанр фильма";
            // 
            // filmGenreCLB
            // 
            this.filmGenreCLB.CheckOnClick = true;
            this.filmGenreCLB.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filmGenreCLB.FormattingEnabled = true;
            this.filmGenreCLB.Location = new System.Drawing.Point(137, 119);
            this.filmGenreCLB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.filmGenreCLB.Name = "filmGenreCLB";
            this.filmGenreCLB.Size = new System.Drawing.Size(189, 70);
            this.filmGenreCLB.TabIndex = 39;
            this.filmGenreCLB.SelectedIndexChanged += new System.EventHandler(this.filmGenreCLB_SelectedIndexChanged);
            // 
            // filmTypeCB
            // 
            this.filmTypeCB.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filmTypeCB.FormattingEnabled = true;
            this.filmTypeCB.Items.AddRange(new object[] {
            "2D",
            "3D"});
            this.filmTypeCB.Location = new System.Drawing.Point(160, 45);
            this.filmTypeCB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.filmTypeCB.Name = "filmTypeCB";
            this.filmTypeCB.Size = new System.Drawing.Size(166, 27);
            this.filmTypeCB.TabIndex = 38;
            this.filmTypeCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filmTypeCB_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Тип фильма";
            // 
            // filmNameTB
            // 
            this.filmNameTB.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filmNameTB.Location = new System.Drawing.Point(160, 12);
            this.filmNameTB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.filmNameTB.Name = "filmNameTB";
            this.filmNameTB.Size = new System.Drawing.Size(166, 27);
            this.filmNameTB.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Название фильма";
            // 
            // deleteDirectorButt
            // 
            this.deleteDirectorButt.BackgroundImage = global::CinemaBox.Properties.Resources.delete;
            this.deleteDirectorButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteDirectorButt.Location = new System.Drawing.Point(131, 195);
            this.deleteDirectorButt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deleteDirectorButt.Name = "deleteDirectorButt";
            this.deleteDirectorButt.Size = new System.Drawing.Size(25, 25);
            this.deleteDirectorButt.TabIndex = 46;
            this.deleteDirectorButt.TabStop = false;
            this.deleteDirectorButt.Click += new System.EventHandler(this.deleteDirectorButt_Click);
            // 
            // acceptAddingDirectorButt
            // 
            this.acceptAddingDirectorButt.BackgroundImage = global::CinemaBox.Properties.Resources.accept;
            this.acceptAddingDirectorButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.acceptAddingDirectorButt.Location = new System.Drawing.Point(308, 195);
            this.acceptAddingDirectorButt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.acceptAddingDirectorButt.Name = "acceptAddingDirectorButt";
            this.acceptAddingDirectorButt.Size = new System.Drawing.Size(25, 25);
            this.acceptAddingDirectorButt.TabIndex = 45;
            this.acceptAddingDirectorButt.TabStop = false;
            this.acceptAddingDirectorButt.Click += new System.EventHandler(this.acceptAddingDirectorButt_Click);
            // 
            // filmDirectorCB
            // 
            this.filmDirectorCB.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filmDirectorCB.FormattingEnabled = true;
            this.filmDirectorCB.Items.AddRange(new object[] {
            "2D",
            "3D"});
            this.filmDirectorCB.Location = new System.Drawing.Point(160, 195);
            this.filmDirectorCB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.filmDirectorCB.Name = "filmDirectorCB";
            this.filmDirectorCB.Size = new System.Drawing.Size(144, 27);
            this.filmDirectorCB.TabIndex = 50;
            this.filmDirectorCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filmTypeCB_KeyPress);
            // 
            // durationTB
            // 
            this.durationTB.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.durationTB.Location = new System.Drawing.Point(211, 79);
            this.durationTB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.durationTB.Name = "durationTB";
            this.durationTB.Size = new System.Drawing.Size(115, 27);
            this.durationTB.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Длительность фильма";
            // 
            // ChangeFilmInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(344, 290);
            this.Controls.Add(this.durationTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filmDirectorCB);
            this.Controls.Add(this.changeFilmInfoButt);
            this.Controls.Add(this.deleteDirectorButt);
            this.Controls.Add(this.acceptAddingDirectorButt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filmGenreCLB);
            this.Controls.Add(this.filmTypeCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filmNameTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ChangeFilmInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить информацию о фильме";
            this.Load += new System.EventHandler(this.ChangeFilmInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deleteDirectorButt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptAddingDirectorButt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeFilmInfoButt;
        private System.Windows.Forms.PictureBox deleteDirectorButt;
        private System.Windows.Forms.PictureBox acceptAddingDirectorButt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox filmGenreCLB;
        private System.Windows.Forms.ComboBox filmTypeCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filmNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filmDirectorCB;
        private System.Windows.Forms.TextBox durationTB;
        private System.Windows.Forms.Label label3;
    }
}