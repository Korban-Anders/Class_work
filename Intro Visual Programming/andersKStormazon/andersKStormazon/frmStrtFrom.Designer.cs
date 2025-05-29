namespace andersKStormazon
{
    partial class frmStrtFrom
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
            this.components = new System.ComponentModel.Container();
            this.mnuStartUp = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileRemoveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProductsMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProductVideoGames = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProductMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblItemsInCart = new System.Windows.Forms.Label();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.chkShip = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.mnuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.productsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextProductsMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextProductsMovies = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextProductsVideoGames = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStartUp.SuspendLayout();
            this.mnuContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStartUp
            // 
            this.mnuStartUp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuStartUp.Location = new System.Drawing.Point(0, 0);
            this.mnuStartUp.Name = "mnuStartUp";
            this.mnuStartUp.Size = new System.Drawing.Size(498, 24);
            this.mnuStartUp.TabIndex = 0;
            this.mnuStartUp.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileClearAll,
            this.mnuFileRemoveItem,
            this.mnuFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuFileClearAll
            // 
            this.mnuFileClearAll.Name = "mnuFileClearAll";
            this.mnuFileClearAll.Size = new System.Drawing.Size(152, 22);
            this.mnuFileClearAll.Text = "Clear All Items";
            this.mnuFileClearAll.Click += new System.EventHandler(this.mnuFileClearAll_Click);
            // 
            // mnuFileRemoveItem
            // 
            this.mnuFileRemoveItem.Name = "mnuFileRemoveItem";
            this.mnuFileRemoveItem.Size = new System.Drawing.Size(152, 22);
            this.mnuFileRemoveItem.Text = "Remove Item";
            this.mnuFileRemoveItem.Click += new System.EventHandler(this.mnuFileRemoveItem_Click);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(152, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProductsMovie,
            this.mnuProductVideoGames,
            this.mnuProductMusic});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // mnuProductsMovie
            // 
            this.mnuProductsMovie.Name = "mnuProductsMovie";
            this.mnuProductsMovie.Size = new System.Drawing.Size(152, 22);
            this.mnuProductsMovie.Text = "Movies";
            this.mnuProductsMovie.Click += new System.EventHandler(this.mnuProductsMovie_Click);
            // 
            // mnuProductVideoGames
            // 
            this.mnuProductVideoGames.Name = "mnuProductVideoGames";
            this.mnuProductVideoGames.Size = new System.Drawing.Size(152, 22);
            this.mnuProductVideoGames.Text = "Video Games";
            this.mnuProductVideoGames.Click += new System.EventHandler(this.mnuProductVideoGames_Click);
            // 
            // mnuProductMusic
            // 
            this.mnuProductMusic.Name = "mnuProductMusic";
            this.mnuProductMusic.Size = new System.Drawing.Size(152, 22);
            this.mnuProductMusic.Text = "Music";
            this.mnuProductMusic.Click += new System.EventHandler(this.mnuProductMusic_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(152, 22);
            this.mnuHelpAbout.Text = "About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // lblItemsInCart
            // 
            this.lblItemsInCart.AutoSize = true;
            this.lblItemsInCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsInCart.ForeColor = System.Drawing.Color.Blue;
            this.lblItemsInCart.Location = new System.Drawing.Point(12, 37);
            this.lblItemsInCart.Name = "lblItemsInCart";
            this.lblItemsInCart.Size = new System.Drawing.Size(187, 24);
            this.lblItemsInCart.TabIndex = 1;
            this.lblItemsInCart.Text = "Items in Your Cart :  0";
            this.lblItemsInCart.Click += new System.EventHandler(this.lblItemsInCart_Click);
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.Location = new System.Drawing.Point(15, 64);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(287, 108);
            this.lstCart.TabIndex = 2;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(15, 179);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(287, 23);
            this.btnRemoveItem.TabIndex = 3;
            this.btnRemoveItem.Text = "Remove Selected";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // chkShip
            // 
            this.chkShip.AutoSize = true;
            this.chkShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShip.ForeColor = System.Drawing.Color.Blue;
            this.chkShip.Location = new System.Drawing.Point(89, 225);
            this.chkShip.Name = "chkShip";
            this.chkShip.Size = new System.Drawing.Size(209, 28);
            this.chkShip.TabIndex = 4;
            this.chkShip.Text = "Please ship this order";
            this.chkShip.UseVisualStyleBackColor = true;
            this.chkShip.CheckedChanged += new System.EventHandler(this.chkShip_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subtotal:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(409, 124);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(34, 13);
            this.lblSubTotal.TabIndex = 6;
            this.lblSubTotal.Text = "$0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tax:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(409, 158);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(34, 13);
            this.lblTax.TabIndex = 8;
            this.lblTax.Text = "$0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Shipping:";
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(409, 199);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(34, 13);
            this.lblShipping.TabIndex = 10;
            this.lblShipping.Text = "$0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(332, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Crimson;
            this.lblTotal.Location = new System.Drawing.Point(409, 241);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 24);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "$0.00";
            // 
            // mnuContext
            // 
            this.mnuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem1,
            this.mnuContextExit});
            this.mnuContext.Name = "mnuContext";
            this.mnuContext.Size = new System.Drawing.Size(122, 48);
            // 
            // productsToolStripMenuItem1
            // 
            this.productsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContextProductsMusic,
            this.mnuContextProductsMovies,
            this.mnuContextProductsVideoGames});
            this.productsToolStripMenuItem1.Name = "productsToolStripMenuItem1";
            this.productsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.productsToolStripMenuItem1.Text = "Products";
            // 
            // mnuContextExit
            // 
            this.mnuContextExit.Name = "mnuContextExit";
            this.mnuContextExit.Size = new System.Drawing.Size(152, 22);
            this.mnuContextExit.Text = "Exit";
            this.mnuContextExit.Click += new System.EventHandler(this.mnuContextExit_Click);
            // 
            // mnuContextProductsMusic
            // 
            this.mnuContextProductsMusic.Name = "mnuContextProductsMusic";
            this.mnuContextProductsMusic.Size = new System.Drawing.Size(152, 22);
            this.mnuContextProductsMusic.Text = "Music";
            this.mnuContextProductsMusic.Click += new System.EventHandler(this.mnuContextProductsMusic_Click);
            // 
            // mnuContextProductsMovies
            // 
            this.mnuContextProductsMovies.Name = "mnuContextProductsMovies";
            this.mnuContextProductsMovies.Size = new System.Drawing.Size(152, 22);
            this.mnuContextProductsMovies.Text = "Movies";
            this.mnuContextProductsMovies.Click += new System.EventHandler(this.mnuContextProductsMovies_Click);
            // 
            // mnuContextProductsVideoGames
            // 
            this.mnuContextProductsVideoGames.Name = "mnuContextProductsVideoGames";
            this.mnuContextProductsVideoGames.Size = new System.Drawing.Size(152, 22);
            this.mnuContextProductsVideoGames.Text = "Video Games";
            this.mnuContextProductsVideoGames.Click += new System.EventHandler(this.mnuContextProductsVideoGames_Click);
            // 
            // frmStrtFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 266);
            this.ContextMenuStrip = this.mnuContext;
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkShip);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.lblItemsInCart);
            this.Controls.Add(this.mnuStartUp);
            this.MainMenuStrip = this.mnuStartUp;
            this.Name = "frmStrtFrom";
            this.Text = "Form1";
            this.mnuStartUp.ResumeLayout(false);
            this.mnuStartUp.PerformLayout();
            this.mnuContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStartUp;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClearAll;
        private System.Windows.Forms.ToolStripMenuItem mnuFileRemoveItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuProductsMovie;
        private System.Windows.Forms.ToolStripMenuItem mnuProductVideoGames;
        private System.Windows.Forms.ToolStripMenuItem mnuProductMusic;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.Label lblItemsInCart;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.CheckBox chkShip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ContextMenuStrip mnuContext;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuContextProductsMusic;
        private System.Windows.Forms.ToolStripMenuItem mnuContextProductsMovies;
        private System.Windows.Forms.ToolStripMenuItem mnuContextProductsVideoGames;
        private System.Windows.Forms.ToolStripMenuItem mnuContextExit;
    }
}

