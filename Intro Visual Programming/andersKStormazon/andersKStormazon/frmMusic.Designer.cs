namespace andersKStormazon
{
    partial class frmMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusic));
            this.btnExit = new System.Windows.Forms.Button();
            this.picMotley = new System.Windows.Forms.PictureBox();
            this.picGNR = new System.Windows.Forms.PictureBox();
            this.picJovi = new System.Windows.Forms.PictureBox();
            this.picPoison = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMotley)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGNR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoison)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(104, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picMotley
            // 
            this.picMotley.Image = ((System.Drawing.Image)(resources.GetObject("picMotley.Image")));
            this.picMotley.Location = new System.Drawing.Point(12, 115);
            this.picMotley.Name = "picMotley";
            this.picMotley.Size = new System.Drawing.Size(100, 84);
            this.picMotley.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMotley.TabIndex = 2;
            this.picMotley.TabStop = false;
            this.picMotley.Click += new System.EventHandler(this.picMotley_Click);
            // 
            // picGNR
            // 
            this.picGNR.Image = ((System.Drawing.Image)(resources.GetObject("picGNR.Image")));
            this.picGNR.Location = new System.Drawing.Point(12, 12);
            this.picGNR.Name = "picGNR";
            this.picGNR.Size = new System.Drawing.Size(100, 84);
            this.picGNR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGNR.TabIndex = 3;
            this.picGNR.TabStop = false;
            this.picGNR.Click += new System.EventHandler(this.picGNR_Click);
            // 
            // picJovi
            // 
            this.picJovi.Image = ((System.Drawing.Image)(resources.GetObject("picJovi.Image")));
            this.picJovi.Location = new System.Drawing.Point(172, 12);
            this.picJovi.Name = "picJovi";
            this.picJovi.Size = new System.Drawing.Size(100, 84);
            this.picJovi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJovi.TabIndex = 4;
            this.picJovi.TabStop = false;
            this.picJovi.Click += new System.EventHandler(this.picJovi_Click);
            // 
            // picPoison
            // 
            this.picPoison.Image = ((System.Drawing.Image)(resources.GetObject("picPoison.Image")));
            this.picPoison.Location = new System.Drawing.Point(172, 115);
            this.picPoison.Name = "picPoison";
            this.picPoison.Size = new System.Drawing.Size(100, 84);
            this.picPoison.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPoison.TabIndex = 5;
            this.picPoison.TabStop = false;
            this.picPoison.Click += new System.EventHandler(this.picPoison_Click);
            // 
            // frmMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.picPoison);
            this.Controls.Add(this.picJovi);
            this.Controls.Add(this.picGNR);
            this.Controls.Add(this.picMotley);
            this.Controls.Add(this.btnExit);
            this.Name = "frmMusic";
            this.Text = "frmMusic";
            ((System.ComponentModel.ISupportInitialize)(this.picMotley)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGNR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPoison)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picMotley;
        private System.Windows.Forms.PictureBox picGNR;
        private System.Windows.Forms.PictureBox picJovi;
        private System.Windows.Forms.PictureBox picPoison;
    }
}