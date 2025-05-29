namespace andersKFavorites
{
    partial class MyMusicMix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMusicMix));
            this.lblTitle = new System.Windows.Forms.Label();
            this.picVolbeat = new System.Windows.Forms.PictureBox();
            this.picHeilung = new System.Windows.Forms.PictureBox();
            this.picGhost = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblPicSelected = new System.Windows.Forms.Label();
            this.picBrotherOfMetal = new System.Windows.Forms.PictureBox();
            this.picCaravanPalace = new System.Windows.Forms.PictureBox();
            this.picPoorMansPosion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVolbeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeilung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBrotherOfMetal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCaravanPalace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoorMansPosion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Ink Free", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTitle.Location = new System.Drawing.Point(116, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Music Mix";
            // 
            // picVolbeat
            // 
            this.picVolbeat.Image = ((System.Drawing.Image)(resources.GetObject("picVolbeat.Image")));
            this.picVolbeat.Location = new System.Drawing.Point(5, 77);
            this.picVolbeat.Name = "picVolbeat";
            this.picVolbeat.Size = new System.Drawing.Size(120, 90);
            this.picVolbeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVolbeat.TabIndex = 1;
            this.picVolbeat.TabStop = false;
            this.picVolbeat.Click += new System.EventHandler(this.picVolbeat_Click);
            // 
            // picHeilung
            // 
            this.picHeilung.Image = ((System.Drawing.Image)(resources.GetObject("picHeilung.Image")));
            this.picHeilung.Location = new System.Drawing.Point(134, 77);
            this.picHeilung.Name = "picHeilung";
            this.picHeilung.Size = new System.Drawing.Size(120, 90);
            this.picHeilung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeilung.TabIndex = 2;
            this.picHeilung.TabStop = false;
            this.picHeilung.Click += new System.EventHandler(this.picHeilung_Click);
            // 
            // picGhost
            // 
            this.picGhost.Image = ((System.Drawing.Image)(resources.GetObject("picGhost.Image")));
            this.picGhost.Location = new System.Drawing.Point(260, 77);
            this.picGhost.Name = "picGhost";
            this.picGhost.Size = new System.Drawing.Size(120, 90);
            this.picGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGhost.TabIndex = 3;
            this.picGhost.TabStop = false;
            this.picGhost.Click += new System.EventHandler(this.picGhost_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(12, 226);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(148, 226);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(272, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(12, 186);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(74, 13);
            this.lblSelected.TabIndex = 7;
            this.lblSelected.Text = "You Selected:";
            // 
            // lblPicSelected
            // 
            this.lblPicSelected.AutoSize = true;
            this.lblPicSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPicSelected.Location = new System.Drawing.Point(97, 186);
            this.lblPicSelected.Name = "lblPicSelected";
            this.lblPicSelected.Size = new System.Drawing.Size(80, 13);
            this.lblPicSelected.TabIndex = 8;
            this.lblPicSelected.Text = "No Selection";
            // 
            // picBrotherOfMetal
            // 
            this.picBrotherOfMetal.Image = ((System.Drawing.Image)(resources.GetObject("picBrotherOfMetal.Image")));
            this.picBrotherOfMetal.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBrotherOfMetal.InitialImage")));
            this.picBrotherOfMetal.Location = new System.Drawing.Point(5, 77);
            this.picBrotherOfMetal.Name = "picBrotherOfMetal";
            this.picBrotherOfMetal.Size = new System.Drawing.Size(120, 90);
            this.picBrotherOfMetal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBrotherOfMetal.TabIndex = 9;
            this.picBrotherOfMetal.TabStop = false;
            this.picBrotherOfMetal.Visible = false;
            this.picBrotherOfMetal.Click += new System.EventHandler(this.picBrotherOfMetal_Click);
            // 
            // picCaravanPalace
            // 
            this.picCaravanPalace.Image = ((System.Drawing.Image)(resources.GetObject("picCaravanPalace.Image")));
            this.picCaravanPalace.Location = new System.Drawing.Point(134, 77);
            this.picCaravanPalace.Name = "picCaravanPalace";
            this.picCaravanPalace.Size = new System.Drawing.Size(120, 90);
            this.picCaravanPalace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCaravanPalace.TabIndex = 10;
            this.picCaravanPalace.TabStop = false;
            this.picCaravanPalace.Visible = false;
            this.picCaravanPalace.Click += new System.EventHandler(this.picCaravanPalace_Click);
            // 
            // picPoorMansPosion
            // 
            this.picPoorMansPosion.Image = ((System.Drawing.Image)(resources.GetObject("picPoorMansPosion.Image")));
            this.picPoorMansPosion.Location = new System.Drawing.Point(260, 77);
            this.picPoorMansPosion.Name = "picPoorMansPosion";
            this.picPoorMansPosion.Size = new System.Drawing.Size(120, 90);
            this.picPoorMansPosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPoorMansPosion.TabIndex = 11;
            this.picPoorMansPosion.TabStop = false;
            this.picPoorMansPosion.Visible = false;
            this.picPoorMansPosion.Click += new System.EventHandler(this.picPoorMansPosion_Click);
            // 
            // MyMusicMix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.picPoorMansPosion);
            this.Controls.Add(this.picCaravanPalace);
            this.Controls.Add(this.picBrotherOfMetal);
            this.Controls.Add(this.lblPicSelected);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.picGhost);
            this.Controls.Add(this.picHeilung);
            this.Controls.Add(this.picVolbeat);
            this.Controls.Add(this.lblTitle);
            this.Name = "MyMusicMix";
            this.Text = "MyMusicMix";
            ((System.ComponentModel.ISupportInitialize)(this.picVolbeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeilung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBrotherOfMetal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCaravanPalace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoorMansPosion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picVolbeat;
        private System.Windows.Forms.PictureBox picHeilung;
        private System.Windows.Forms.PictureBox picGhost;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblPicSelected;
        private System.Windows.Forms.PictureBox picBrotherOfMetal;
        private System.Windows.Forms.PictureBox picCaravanPalace;
        private System.Windows.Forms.PictureBox picPoorMansPosion;
    }
}

