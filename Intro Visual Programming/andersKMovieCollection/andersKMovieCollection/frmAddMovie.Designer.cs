namespace andersKMovieCollection
{
    partial class frmAddMovie
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRuntime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radStarOne = new System.Windows.Forms.RadioButton();
            this.radStarTwo = new System.Windows.Forms.RadioButton();
            this.radStartThree = new System.Windows.Forms.RadioButton();
            this.radStarFour = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.chkGenreComedy = new System.Windows.Forms.CheckBox();
            this.chkGenreKids = new System.Windows.Forms.CheckBox();
            this.chkGenreDrama = new System.Windows.Forms.CheckBox();
            this.chkGenreAction = new System.Windows.Forms.CheckBox();
            this.chkGenreSciFi = new System.Windows.Forms.CheckBox();
            this.chkGenreTelevision = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cobFormat = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Title";
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Location = new System.Drawing.Point(16, 30);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(256, 20);
            this.txtMovieTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(16, 93);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(71, 20);
            this.txtYear.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Runtime(minutes)";
            // 
            // txtRuntime
            // 
            this.txtRuntime.Location = new System.Drawing.Point(182, 92);
            this.txtRuntime.Name = "txtRuntime";
            this.txtRuntime.Size = new System.Drawing.Size(66, 20);
            this.txtRuntime.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stars";
            // 
            // radStarOne
            // 
            this.radStarOne.AutoSize = true;
            this.radStarOne.Location = new System.Drawing.Point(16, 201);
            this.radStarOne.Name = "radStarOne";
            this.radStarOne.Size = new System.Drawing.Size(31, 17);
            this.radStarOne.TabIndex = 7;
            this.radStarOne.TabStop = true;
            this.radStarOne.Text = "1";
            this.radStarOne.UseVisualStyleBackColor = true;
            // 
            // radStarTwo
            // 
            this.radStarTwo.AutoSize = true;
            this.radStarTwo.Location = new System.Drawing.Point(86, 201);
            this.radStarTwo.Name = "radStarTwo";
            this.radStarTwo.Size = new System.Drawing.Size(31, 17);
            this.radStarTwo.TabIndex = 8;
            this.radStarTwo.TabStop = true;
            this.radStarTwo.Text = "2";
            this.radStarTwo.UseVisualStyleBackColor = true;
            // 
            // radStartThree
            // 
            this.radStartThree.AutoSize = true;
            this.radStartThree.Location = new System.Drawing.Point(163, 201);
            this.radStartThree.Name = "radStartThree";
            this.radStartThree.Size = new System.Drawing.Size(31, 17);
            this.radStartThree.TabIndex = 9;
            this.radStartThree.TabStop = true;
            this.radStartThree.Text = "3";
            this.radStartThree.UseVisualStyleBackColor = true;
            // 
            // radStarFour
            // 
            this.radStarFour.AutoSize = true;
            this.radStarFour.Location = new System.Drawing.Point(241, 201);
            this.radStarFour.Name = "radStarFour";
            this.radStarFour.Size = new System.Drawing.Size(31, 17);
            this.radStarFour.TabIndex = 10;
            this.radStarFour.TabStop = true;
            this.radStarFour.Text = "4";
            this.radStarFour.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Genre";
            // 
            // chkGenreComedy
            // 
            this.chkGenreComedy.AutoSize = true;
            this.chkGenreComedy.Location = new System.Drawing.Point(16, 289);
            this.chkGenreComedy.Name = "chkGenreComedy";
            this.chkGenreComedy.Size = new System.Drawing.Size(64, 17);
            this.chkGenreComedy.TabIndex = 12;
            this.chkGenreComedy.Text = "Comedy";
            this.chkGenreComedy.UseVisualStyleBackColor = true;
            // 
            // chkGenreKids
            // 
            this.chkGenreKids.AutoSize = true;
            this.chkGenreKids.Location = new System.Drawing.Point(102, 289);
            this.chkGenreKids.Name = "chkGenreKids";
            this.chkGenreKids.Size = new System.Drawing.Size(46, 17);
            this.chkGenreKids.TabIndex = 13;
            this.chkGenreKids.Text = "Kids";
            this.chkGenreKids.UseVisualStyleBackColor = true;
            // 
            // chkGenreDrama
            // 
            this.chkGenreDrama.AutoSize = true;
            this.chkGenreDrama.Location = new System.Drawing.Point(188, 289);
            this.chkGenreDrama.Name = "chkGenreDrama";
            this.chkGenreDrama.Size = new System.Drawing.Size(57, 17);
            this.chkGenreDrama.TabIndex = 14;
            this.chkGenreDrama.Text = "Drama";
            this.chkGenreDrama.UseVisualStyleBackColor = true;
            // 
            // chkGenreAction
            // 
            this.chkGenreAction.AutoSize = true;
            this.chkGenreAction.Location = new System.Drawing.Point(16, 312);
            this.chkGenreAction.Name = "chkGenreAction";
            this.chkGenreAction.Size = new System.Drawing.Size(56, 17);
            this.chkGenreAction.TabIndex = 15;
            this.chkGenreAction.Text = "Action";
            this.chkGenreAction.UseVisualStyleBackColor = true;
            // 
            // chkGenreSciFi
            // 
            this.chkGenreSciFi.AutoSize = true;
            this.chkGenreSciFi.Location = new System.Drawing.Point(102, 312);
            this.chkGenreSciFi.Name = "chkGenreSciFi";
            this.chkGenreSciFi.Size = new System.Drawing.Size(52, 17);
            this.chkGenreSciFi.TabIndex = 16;
            this.chkGenreSciFi.Text = "Sci-Fi";
            this.chkGenreSciFi.UseVisualStyleBackColor = true;
            // 
            // chkGenreTelevision
            // 
            this.chkGenreTelevision.AutoSize = true;
            this.chkGenreTelevision.Location = new System.Drawing.Point(188, 312);
            this.chkGenreTelevision.Name = "chkGenreTelevision";
            this.chkGenreTelevision.Size = new System.Drawing.Size(74, 17);
            this.chkGenreTelevision.TabIndex = 17;
            this.chkGenreTelevision.Text = "Television";
            this.chkGenreTelevision.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Format";
            // 
            // cobFormat
            // 
            this.cobFormat.FormattingEnabled = true;
            this.cobFormat.Location = new System.Drawing.Point(16, 389);
            this.cobFormat.Name = "cobFormat";
            this.cobFormat.Size = new System.Drawing.Size(121, 21);
            this.cobFormat.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(61, 447);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(171, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(13, 492);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 492);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 527);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cobFormat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkGenreTelevision);
            this.Controls.Add(this.chkGenreSciFi);
            this.Controls.Add(this.chkGenreAction);
            this.Controls.Add(this.chkGenreDrama);
            this.Controls.Add(this.chkGenreKids);
            this.Controls.Add(this.chkGenreComedy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radStarFour);
            this.Controls.Add(this.radStartThree);
            this.Controls.Add(this.radStarTwo);
            this.Controls.Add(this.radStarOne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRuntime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMovieTitle);
            this.Controls.Add(this.label1);
            this.Name = "frmAddMovie";
            this.Text = "frmAddMovie";
            this.Load += new System.EventHandler(this.frmAddMovie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRuntime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radStarOne;
        private System.Windows.Forms.RadioButton radStarTwo;
        private System.Windows.Forms.RadioButton radStartThree;
        private System.Windows.Forms.RadioButton radStarFour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkGenreComedy;
        private System.Windows.Forms.CheckBox chkGenreKids;
        private System.Windows.Forms.CheckBox chkGenreDrama;
        private System.Windows.Forms.CheckBox chkGenreAction;
        private System.Windows.Forms.CheckBox chkGenreSciFi;
        private System.Windows.Forms.CheckBox chkGenreTelevision;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cobFormat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}