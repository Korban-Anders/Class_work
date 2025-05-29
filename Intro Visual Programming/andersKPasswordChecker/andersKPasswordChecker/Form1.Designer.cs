namespace andersKPasswordChecker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnterPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPasswordResults = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblCharNum = new System.Windows.Forms.Label();
            this.lblLowerCaseChar = new System.Windows.Forms.Label();
            this.lblUpperCaseChar = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblSpChar = new System.Windows.Forms.Label();
            this.picCharNumCorrect = new System.Windows.Forms.PictureBox();
            this.btnValidatePassword = new System.Windows.Forms.Button();
            this.picLowerCaseCharCorrect = new System.Windows.Forms.PictureBox();
            this.picUpperCaseCharCorrect = new System.Windows.Forms.PictureBox();
            this.picNumCorrect = new System.Windows.Forms.PictureBox();
            this.picSpCharCorrect = new System.Windows.Forms.PictureBox();
            this.picCharNumIncorrect = new System.Windows.Forms.PictureBox();
            this.picNumIncorrect = new System.Windows.Forms.PictureBox();
            this.picUpperCaseCharIncorrect = new System.Windows.Forms.PictureBox();
            this.picLowerCaseCharIncorrect = new System.Windows.Forms.PictureBox();
            this.picSpCharIncorrect = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCharNumCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLowerCaseCharCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpperCaseCharCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpCharCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCharNumIncorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumIncorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpperCaseCharIncorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLowerCaseCharIncorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpCharIncorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter A Password";
            // 
            // txtEnterPassword
            // 
            this.txtEnterPassword.Location = new System.Drawing.Point(15, 25);
            this.txtEnterPassword.Name = "txtEnterPassword";
            this.txtEnterPassword.Size = new System.Drawing.Size(100, 20);
            this.txtEnterPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Min Password Length";
            // 
            // txtPasswordLength
            // 
            this.txtPasswordLength.Location = new System.Drawing.Point(181, 25);
            this.txtPasswordLength.Name = "txtPasswordLength";
            this.txtPasswordLength.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordLength.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password Results";
            // 
            // lstPasswordResults
            // 
            this.lstPasswordResults.FormattingEnabled = true;
            this.lstPasswordResults.Location = new System.Drawing.Point(325, 25);
            this.lstPasswordResults.Name = "lstPasswordResults";
            this.lstPasswordResults.Size = new System.Drawing.Size(228, 212);
            this.lstPasswordResults.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(478, 245);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(325, 245);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblCharNum
            // 
            this.lblCharNum.AutoSize = true;
            this.lblCharNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharNum.Location = new System.Drawing.Point(76, 67);
            this.lblCharNum.Name = "lblCharNum";
            this.lblCharNum.Size = new System.Drawing.Size(163, 20);
            this.lblCharNum.TabIndex = 8;
            this.lblCharNum.Text = "Is Required Length";
            // 
            // lblLowerCaseChar
            // 
            this.lblLowerCaseChar.AutoSize = true;
            this.lblLowerCaseChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowerCaseChar.Location = new System.Drawing.Point(76, 104);
            this.lblLowerCaseChar.Name = "lblLowerCaseChar";
            this.lblLowerCaseChar.Size = new System.Drawing.Size(211, 20);
            this.lblLowerCaseChar.TabIndex = 9;
            this.lblLowerCaseChar.Text = "Has A Lower-Case Letter";
            // 
            // lblUpperCaseChar
            // 
            this.lblUpperCaseChar.AutoSize = true;
            this.lblUpperCaseChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpperCaseChar.Location = new System.Drawing.Point(76, 137);
            this.lblUpperCaseChar.Name = "lblUpperCaseChar";
            this.lblUpperCaseChar.Size = new System.Drawing.Size(172, 20);
            this.lblUpperCaseChar.TabIndex = 10;
            this.lblUpperCaseChar.Text = "Has A Capital Letter";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(76, 173);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(125, 20);
            this.lblNum.TabIndex = 11;
            this.lblNum.Text = "Has A Number";
            // 
            // lblSpChar
            // 
            this.lblSpChar.AutoSize = true;
            this.lblSpChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpChar.Location = new System.Drawing.Point(76, 210);
            this.lblSpChar.Name = "lblSpChar";
            this.lblSpChar.Size = new System.Drawing.Size(204, 20);
            this.lblSpChar.TabIndex = 12;
            this.lblSpChar.Text = "Has a Special Character";
            // 
            // picCharNumCorrect
            // 
            this.picCharNumCorrect.Image = ((System.Drawing.Image)(resources.GetObject("picCharNumCorrect.Image")));
            this.picCharNumCorrect.Location = new System.Drawing.Point(26, 61);
            this.picCharNumCorrect.Name = "picCharNumCorrect";
            this.picCharNumCorrect.Size = new System.Drawing.Size(32, 29);
            this.picCharNumCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCharNumCorrect.TabIndex = 13;
            this.picCharNumCorrect.TabStop = false;
            this.picCharNumCorrect.Visible = false;
            // 
            // btnValidatePassword
            // 
            this.btnValidatePassword.Location = new System.Drawing.Point(15, 245);
            this.btnValidatePassword.Name = "btnValidatePassword";
            this.btnValidatePassword.Size = new System.Drawing.Size(198, 23);
            this.btnValidatePassword.TabIndex = 14;
            this.btnValidatePassword.Text = "Validate Password";
            this.btnValidatePassword.UseVisualStyleBackColor = true;
            this.btnValidatePassword.Click += new System.EventHandler(this.btnValidatePassword_Click);
            // 
            // picLowerCaseCharCorrect
            // 
            this.picLowerCaseCharCorrect.Image = ((System.Drawing.Image)(resources.GetObject("picLowerCaseCharCorrect.Image")));
            this.picLowerCaseCharCorrect.Location = new System.Drawing.Point(26, 96);
            this.picLowerCaseCharCorrect.Name = "picLowerCaseCharCorrect";
            this.picLowerCaseCharCorrect.Size = new System.Drawing.Size(32, 30);
            this.picLowerCaseCharCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLowerCaseCharCorrect.TabIndex = 15;
            this.picLowerCaseCharCorrect.TabStop = false;
            this.picLowerCaseCharCorrect.Visible = false;
            // 
            // picUpperCaseCharCorrect
            // 
            this.picUpperCaseCharCorrect.Image = ((System.Drawing.Image)(resources.GetObject("picUpperCaseCharCorrect.Image")));
            this.picUpperCaseCharCorrect.Location = new System.Drawing.Point(26, 132);
            this.picUpperCaseCharCorrect.Name = "picUpperCaseCharCorrect";
            this.picUpperCaseCharCorrect.Size = new System.Drawing.Size(32, 29);
            this.picUpperCaseCharCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUpperCaseCharCorrect.TabIndex = 16;
            this.picUpperCaseCharCorrect.TabStop = false;
            this.picUpperCaseCharCorrect.Visible = false;
            // 
            // picNumCorrect
            // 
            this.picNumCorrect.Image = ((System.Drawing.Image)(resources.GetObject("picNumCorrect.Image")));
            this.picNumCorrect.Location = new System.Drawing.Point(26, 167);
            this.picNumCorrect.Name = "picNumCorrect";
            this.picNumCorrect.Size = new System.Drawing.Size(32, 28);
            this.picNumCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNumCorrect.TabIndex = 17;
            this.picNumCorrect.TabStop = false;
            this.picNumCorrect.Visible = false;
            // 
            // picSpCharCorrect
            // 
            this.picSpCharCorrect.Image = ((System.Drawing.Image)(resources.GetObject("picSpCharCorrect.Image")));
            this.picSpCharCorrect.Location = new System.Drawing.Point(26, 201);
            this.picSpCharCorrect.Name = "picSpCharCorrect";
            this.picSpCharCorrect.Size = new System.Drawing.Size(32, 31);
            this.picSpCharCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpCharCorrect.TabIndex = 18;
            this.picSpCharCorrect.TabStop = false;
            this.picSpCharCorrect.Visible = false;
            // 
            // picCharNumIncorrect
            // 
            this.picCharNumIncorrect.Image = ((System.Drawing.Image)(resources.GetObject("picCharNumIncorrect.Image")));
            this.picCharNumIncorrect.Location = new System.Drawing.Point(26, 61);
            this.picCharNumIncorrect.Name = "picCharNumIncorrect";
            this.picCharNumIncorrect.Size = new System.Drawing.Size(32, 29);
            this.picCharNumIncorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCharNumIncorrect.TabIndex = 19;
            this.picCharNumIncorrect.TabStop = false;
            this.picCharNumIncorrect.Visible = false;
            // 
            // picNumIncorrect
            // 
            this.picNumIncorrect.Image = ((System.Drawing.Image)(resources.GetObject("picNumIncorrect.Image")));
            this.picNumIncorrect.Location = new System.Drawing.Point(26, 167);
            this.picNumIncorrect.Name = "picNumIncorrect";
            this.picNumIncorrect.Size = new System.Drawing.Size(32, 29);
            this.picNumIncorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNumIncorrect.TabIndex = 20;
            this.picNumIncorrect.TabStop = false;
            this.picNumIncorrect.Visible = false;
            // 
            // picUpperCaseCharIncorrect
            // 
            this.picUpperCaseCharIncorrect.Image = ((System.Drawing.Image)(resources.GetObject("picUpperCaseCharIncorrect.Image")));
            this.picUpperCaseCharIncorrect.Location = new System.Drawing.Point(26, 132);
            this.picUpperCaseCharIncorrect.Name = "picUpperCaseCharIncorrect";
            this.picUpperCaseCharIncorrect.Size = new System.Drawing.Size(32, 29);
            this.picUpperCaseCharIncorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUpperCaseCharIncorrect.TabIndex = 21;
            this.picUpperCaseCharIncorrect.TabStop = false;
            this.picUpperCaseCharIncorrect.Visible = false;
            // 
            // picLowerCaseCharIncorrect
            // 
            this.picLowerCaseCharIncorrect.Image = ((System.Drawing.Image)(resources.GetObject("picLowerCaseCharIncorrect.Image")));
            this.picLowerCaseCharIncorrect.Location = new System.Drawing.Point(26, 97);
            this.picLowerCaseCharIncorrect.Name = "picLowerCaseCharIncorrect";
            this.picLowerCaseCharIncorrect.Size = new System.Drawing.Size(32, 29);
            this.picLowerCaseCharIncorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLowerCaseCharIncorrect.TabIndex = 22;
            this.picLowerCaseCharIncorrect.TabStop = false;
            this.picLowerCaseCharIncorrect.Visible = false;
            // 
            // picSpCharIncorrect
            // 
            this.picSpCharIncorrect.Image = ((System.Drawing.Image)(resources.GetObject("picSpCharIncorrect.Image")));
            this.picSpCharIncorrect.Location = new System.Drawing.Point(26, 203);
            this.picSpCharIncorrect.Name = "picSpCharIncorrect";
            this.picSpCharIncorrect.Size = new System.Drawing.Size(32, 29);
            this.picSpCharIncorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpCharIncorrect.TabIndex = 23;
            this.picSpCharIncorrect.TabStop = false;
            this.picSpCharIncorrect.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 280);
            this.Controls.Add(this.picSpCharIncorrect);
            this.Controls.Add(this.picLowerCaseCharIncorrect);
            this.Controls.Add(this.picUpperCaseCharIncorrect);
            this.Controls.Add(this.picNumIncorrect);
            this.Controls.Add(this.picCharNumIncorrect);
            this.Controls.Add(this.picSpCharCorrect);
            this.Controls.Add(this.picNumCorrect);
            this.Controls.Add(this.picUpperCaseCharCorrect);
            this.Controls.Add(this.picLowerCaseCharCorrect);
            this.Controls.Add(this.btnValidatePassword);
            this.Controls.Add(this.picCharNumCorrect);
            this.Controls.Add(this.lblSpChar);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblUpperCaseChar);
            this.Controls.Add(this.lblLowerCaseChar);
            this.Controls.Add(this.lblCharNum);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstPasswordResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPasswordLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEnterPassword);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Password Validation";
            ((System.ComponentModel.ISupportInitialize)(this.picCharNumCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLowerCaseCharCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpperCaseCharCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpCharCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCharNumIncorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNumIncorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpperCaseCharIncorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLowerCaseCharIncorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpCharIncorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnterPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswordLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstPasswordResults;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblCharNum;
        private System.Windows.Forms.Label lblLowerCaseChar;
        private System.Windows.Forms.Label lblUpperCaseChar;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblSpChar;
        private System.Windows.Forms.PictureBox picCharNumCorrect;
        private System.Windows.Forms.Button btnValidatePassword;
        private System.Windows.Forms.PictureBox picLowerCaseCharCorrect;
        private System.Windows.Forms.PictureBox picUpperCaseCharCorrect;
        private System.Windows.Forms.PictureBox picNumCorrect;
        private System.Windows.Forms.PictureBox picSpCharCorrect;
        private System.Windows.Forms.PictureBox picCharNumIncorrect;
        private System.Windows.Forms.PictureBox picNumIncorrect;
        private System.Windows.Forms.PictureBox picUpperCaseCharIncorrect;
        private System.Windows.Forms.PictureBox picLowerCaseCharIncorrect;
        private System.Windows.Forms.PictureBox picSpCharIncorrect;
    }
}

