namespace andersKYourStore
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
            this.picBurger = new System.Windows.Forms.PictureBox();
            this.picFries = new System.Windows.Forms.PictureBox();
            this.picSoda = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.lblBurgerNum = new System.Windows.Forms.Label();
            this.lblFriesNum = new System.Windows.Forms.Label();
            this.lblSodaNum = new System.Windows.Forms.Label();
            this.btnTip = new System.Windows.Forms.Button();
            this.lblUpdatedTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBurger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSoda)).BeginInit();
            this.SuspendLayout();
            // 
            // picBurger
            // 
            this.picBurger.Image = ((System.Drawing.Image)(resources.GetObject("picBurger.Image")));
            this.picBurger.Location = new System.Drawing.Point(12, 12);
            this.picBurger.Name = "picBurger";
            this.picBurger.Size = new System.Drawing.Size(90, 89);
            this.picBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBurger.TabIndex = 0;
            this.picBurger.TabStop = false;
            this.picBurger.Click += new System.EventHandler(this.picBurger_Click);
            // 
            // picFries
            // 
            this.picFries.Image = ((System.Drawing.Image)(resources.GetObject("picFries.Image")));
            this.picFries.Location = new System.Drawing.Point(130, 12);
            this.picFries.Name = "picFries";
            this.picFries.Size = new System.Drawing.Size(84, 89);
            this.picFries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFries.TabIndex = 1;
            this.picFries.TabStop = false;
            this.picFries.Click += new System.EventHandler(this.picFries_Click);
            // 
            // picSoda
            // 
            this.picSoda.Image = ((System.Drawing.Image)(resources.GetObject("picSoda.Image")));
            this.picSoda.Location = new System.Drawing.Point(238, 12);
            this.picSoda.Name = "picSoda";
            this.picSoda.Size = new System.Drawing.Size(75, 89);
            this.picSoda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSoda.TabIndex = 2;
            this.picSoda.TabStop = false;
            this.picSoda.Click += new System.EventHandler(this.picSoda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sub-total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(183, 148);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(27, 20);
            this.lblSubTotal.TabIndex = 6;
            this.lblSubTotal.Text = "$0";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(183, 177);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(27, 20);
            this.lblTax.TabIndex = 7;
            this.lblTax.Text = "$0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(183, 209);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(29, 20);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "$0";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(238, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 298);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(60, 263);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(100, 20);
            this.txtTip.TabIndex = 12;
            // 
            // lblBurgerNum
            // 
            this.lblBurgerNum.AutoSize = true;
            this.lblBurgerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurgerNum.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBurgerNum.Location = new System.Drawing.Point(48, 104);
            this.lblBurgerNum.Name = "lblBurgerNum";
            this.lblBurgerNum.Size = new System.Drawing.Size(16, 16);
            this.lblBurgerNum.TabIndex = 13;
            this.lblBurgerNum.Text = "0";
            // 
            // lblFriesNum
            // 
            this.lblFriesNum.AutoSize = true;
            this.lblFriesNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriesNum.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblFriesNum.Location = new System.Drawing.Point(164, 104);
            this.lblFriesNum.Name = "lblFriesNum";
            this.lblFriesNum.Size = new System.Drawing.Size(16, 16);
            this.lblFriesNum.TabIndex = 14;
            this.lblFriesNum.Text = "0";
            // 
            // lblSodaNum
            // 
            this.lblSodaNum.AutoSize = true;
            this.lblSodaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSodaNum.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSodaNum.Location = new System.Drawing.Point(269, 104);
            this.lblSodaNum.Name = "lblSodaNum";
            this.lblSodaNum.Size = new System.Drawing.Size(16, 16);
            this.lblSodaNum.TabIndex = 15;
            this.lblSodaNum.Text = "0";
            // 
            // btnTip
            // 
            this.btnTip.Location = new System.Drawing.Point(167, 260);
            this.btnTip.Name = "btnTip";
            this.btnTip.Size = new System.Drawing.Size(146, 23);
            this.btnTip.TabIndex = 16;
            this.btnTip.Text = "Add Tip And Update Total";
            this.btnTip.UseVisualStyleBackColor = true;
            this.btnTip.Click += new System.EventHandler(this.btnTip_Click);
            // 
            // lblUpdatedTotal
            // 
            this.lblUpdatedTotal.AutoSize = true;
            this.lblUpdatedTotal.Location = new System.Drawing.Point(175, 229);
            this.lblUpdatedTotal.Name = "lblUpdatedTotal";
            this.lblUpdatedTotal.Size = new System.Drawing.Size(35, 13);
            this.lblUpdatedTotal.TabIndex = 17;
            this.lblUpdatedTotal.Text = "label4";
            this.lblUpdatedTotal.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 333);
            this.Controls.Add(this.lblUpdatedTotal);
            this.Controls.Add(this.btnTip);
            this.Controls.Add(this.lblSodaNum);
            this.Controls.Add(this.lblFriesNum);
            this.Controls.Add(this.lblBurgerNum);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picSoda);
            this.Controls.Add(this.picFries);
            this.Controls.Add(this.picBurger);
            this.Name = "Form1";
            this.Text = "Korban\'s Burgers";
            ((System.ComponentModel.ISupportInitialize)(this.picBurger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSoda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBurger;
        private System.Windows.Forms.PictureBox picFries;
        private System.Windows.Forms.PictureBox picSoda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label lblBurgerNum;
        private System.Windows.Forms.Label lblFriesNum;
        private System.Windows.Forms.Label lblSodaNum;
        private System.Windows.Forms.Button btnTip;
        private System.Windows.Forms.Label lblUpdatedTotal;
    }
}

