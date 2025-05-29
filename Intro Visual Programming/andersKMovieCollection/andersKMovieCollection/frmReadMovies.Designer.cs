namespace andersKMovieCollection
{
    partial class frmReadMovies
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
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.lblMovieYear = new System.Windows.Forms.Label();
            this.lblMoviePosition = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMovieRuntime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMovieStars = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMovieGeneres = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMoiveFormat = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.picMoviePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMoviePic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblMovieTitle.Location = new System.Drawing.Point(7, 9);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(61, 29);
            this.lblMovieTitle.TabIndex = 0;
            this.lblMovieTitle.Text = "Title";
            // 
            // lblMovieYear
            // 
            this.lblMovieYear.AutoSize = true;
            this.lblMovieYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieYear.ForeColor = System.Drawing.Color.Red;
            this.lblMovieYear.Location = new System.Drawing.Point(13, 47);
            this.lblMovieYear.Name = "lblMovieYear";
            this.lblMovieYear.Size = new System.Drawing.Size(38, 18);
            this.lblMovieYear.TabIndex = 1;
            this.lblMovieYear.Text = "Year";
            // 
            // lblMoviePosition
            // 
            this.lblMoviePosition.AutoSize = true;
            this.lblMoviePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoviePosition.ForeColor = System.Drawing.Color.Red;
            this.lblMoviePosition.Location = new System.Drawing.Point(274, 47);
            this.lblMoviePosition.Name = "lblMoviePosition";
            this.lblMoviePosition.Size = new System.Drawing.Size(43, 18);
            this.lblMoviePosition.TabIndex = 2;
            this.lblMoviePosition.Text = "x of x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Runtime:";
            // 
            // lblMovieRuntime
            // 
            this.lblMovieRuntime.AutoSize = true;
            this.lblMovieRuntime.Location = new System.Drawing.Point(68, 251);
            this.lblMovieRuntime.Name = "lblMovieRuntime";
            this.lblMovieRuntime.Size = new System.Drawing.Size(19, 13);
            this.lblMovieRuntime.TabIndex = 4;
            this.lblMovieRuntime.Text = "90";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rating";
            // 
            // lblMovieStars
            // 
            this.lblMovieStars.AutoSize = true;
            this.lblMovieStars.Location = new System.Drawing.Point(235, 251);
            this.lblMovieStars.Name = "lblMovieStars";
            this.lblMovieStars.Size = new System.Drawing.Size(13, 13);
            this.lblMovieStars.TabIndex = 6;
            this.lblMovieStars.Text = "4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Genere";
            // 
            // lblMovieGeneres
            // 
            this.lblMovieGeneres.AutoSize = true;
            this.lblMovieGeneres.Location = new System.Drawing.Point(54, 286);
            this.lblMovieGeneres.Name = "lblMovieGeneres";
            this.lblMovieGeneres.Size = new System.Drawing.Size(45, 13);
            this.lblMovieGeneres.TabIndex = 8;
            this.lblMovieGeneres.Text = "generes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Format";
            // 
            // lblMoiveFormat
            // 
            this.lblMoiveFormat.AutoSize = true;
            this.lblMoiveFormat.Location = new System.Drawing.Point(63, 330);
            this.lblMoiveFormat.Name = "lblMoiveFormat";
            this.lblMoiveFormat.Size = new System.Drawing.Size(36, 13);
            this.lblMoiveFormat.TabIndex = 10;
            this.lblMoiveFormat.Text = "format";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(12, 370);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(124, 370);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 12;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(234, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // picMoviePic
            // 
            this.picMoviePic.Location = new System.Drawing.Point(12, 69);
            this.picMoviePic.Name = "picMoviePic";
            this.picMoviePic.Size = new System.Drawing.Size(297, 179);
            this.picMoviePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMoviePic.TabIndex = 14;
            this.picMoviePic.TabStop = false;
            // 
            // frmReadMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 409);
            this.Controls.Add(this.picMoviePic);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblMoiveFormat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblMovieGeneres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMovieStars);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMovieRuntime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMoviePosition);
            this.Controls.Add(this.lblMovieYear);
            this.Controls.Add(this.lblMovieTitle);
            this.Name = "frmReadMovies";
            this.Text = "frmReadMovies";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReadMovies_FormClosed);
            this.Load += new System.EventHandler(this.frmReadMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMoviePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.Label lblMovieYear;
        private System.Windows.Forms.Label lblMoviePosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMovieRuntime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMovieStars;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMovieGeneres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMoiveFormat;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.PictureBox picMoviePic;
    }
}