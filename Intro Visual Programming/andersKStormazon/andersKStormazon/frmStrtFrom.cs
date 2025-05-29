using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace andersKStormazon
{
    public partial class frmStrtFrom : Form
    {
        public frmStrtFrom()
        {
            InitializeComponent();
        }

        //Fields 
        private double dblTax = 0;
        private const double DBL_TAXRATE = 0.07;
        private double dblTotal = 0;
        private int intItemCount = 0;
        private double dblSubTotal = 0;
        private double dblShippingCost = 0;


        //method to close an menu/application
        public void exit() {
            this.Close();
        }
        // opens Movie menu
        private void openMovie() {
            frmMovie movie = new frmMovie();
            movie.Owner = this;
            movie.ShowDialog();
        }

        // opens video game menu
        private void openVideoGame() {
            frmVideoGame videoGame = new frmVideoGame();
            videoGame.Owner = this;
            videoGame.ShowDialog();
        }

        // opens music menu
        private void openMusic() {
            frmMusic music = new frmMusic();
            music.Owner = this;
            music.ShowDialog();
        }

        private void openAbout() {
            frmAbout about = new frmAbout();
            about.Owner = this;
            about.ShowDialog();
        }

        // remove item from list
        private void removeItem() {
            int intIndex = lstCart.SelectedIndex;
            string strItemName;
            double dblItemPrice = 0;

            if(intIndex != -1){
                // removes item
                strItemName = lstCart.Items[intIndex].ToString();
                lstCart.Items.RemoveAt(intIndex);

                // updates everything after item was removed
                dblItemPrice = -1 * getPrice(strItemName);
                intItemCount--;
                calcTotal(dblItemPrice);
                shippingCalc();
            }
        }
        // will calc the shipping cost
        private void shippingCalc() {
            //checks if shipping chk is checked
            if (chkShip.Checked)
            {
                //sets shipping cost based on item count 
                if (intItemCount >= 1 && intItemCount <= 3)
                    dblShippingCost = 9;
                else if (intItemCount >= 4 && intItemCount <= 6)
                    dblShippingCost = 6;
                else if (intItemCount >= 7)
                    dblShippingCost = 0;
                //updates total to inlclude shipping
                dblTotal += dblShippingCost;
            }
            else {
                //updates total to inlclude shipping
                dblTotal -= dblShippingCost;
                dblShippingCost = 0;
            }
            //updates shipping and total lbl
            lblShipping.Text = dblShippingCost.ToString("c");
            lblTotal.Text = dblTotal.ToString("c");

        }
        // will add item to the list
        public void addItem(string strItemName) {
            intItemCount++;
            double dblPrice = getPrice(strItemName);
            lstCart.Items.Add(strItemName);
            calcTotal(dblPrice);
        }
        // will calc the total
        private void calcTotal(double dblItemCost) {
            dblSubTotal += dblItemCost;
            dblTax = dblSubTotal * DBL_TAXRATE;
            dblTotal = dblSubTotal + dblTax;
            // updates lbl
            updateLbl();
        }
        // will update the lbls
        private void updateLbl() {
            lblItemsInCart.Text = "Items in Your Cart :  " + intItemCount.ToString();
            lblSubTotal.Text = dblSubTotal.ToString("c");
            lblTax.Text = dblTax.ToString("c");
            lblTotal.Text = dblTotal.ToString("c");
        }
        // will return the items price
        private double getPrice(string itemName) {
            double price = 0;
            switch(itemName){
                case "Back to the Future":
                    price = 29.99;
                    break;
                case "Cant Buy Me Love":
                    price = 24.99;
                    break;
                case "Raiders of the Lost Ark":
                    price = 22.99;
                    break;
                case "The Breakfast Club":
                    price = 20.99;
                    break;
                case "Atari 2600":
                    price = 19.99;
                    break;
                case "NES":
                    price = 14.99;
                    break;
                case "SNES":
                    price = 12.99;
                    break;
                case "Sega Genesis":
                    price = 10.99;
                    break;
                case "Guns N Roses":
                    price = 9.99;
                    break;
                case "Bon Jovi":
                    price = 4.99;
                    break;
                case "Poison":
                    price = 2.99;
                    break;
                case "Motley Crue":
                    price = 0.99;
                    break;
                default:
                    MessageBox.Show("Error Item Not Vaild");
                    price = 0;
                    break;
            }
            return price;
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            // close applcation
            exit();
        }

        private void mnuProductsMovie_Click(object sender, EventArgs e)
        {
            // opens movie menu
            openMovie();
        }

        private void lblItemsInCart_Click(object sender, EventArgs e)
        {
            //ignore it is bugging out without this
        }

        private void chkShip_CheckedChanged(object sender, EventArgs e)
        {
            // clacluates shipping cost
            shippingCalc();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            // removes selected item
            removeItem();
        }

        private void mnuFileRemoveItem_Click(object sender, EventArgs e)
        {
            // removes selected item
            removeItem();
        }

        private void mnuFileClearAll_Click(object sender, EventArgs e)
        {
            //clears all items
            lstCart.Items.Clear();
            intItemCount = 0;
            dblShippingCost = 0;
            dblSubTotal = 0;
            dblTax = 0;
            dblTotal = 0;
            updateLbl();
        }

        private void mnuProductVideoGames_Click(object sender, EventArgs e)
        {
            // opens video game menu
            openVideoGame();
        }

        private void mnuProductMusic_Click(object sender, EventArgs e)
        {
            // opens music menu
            openMusic();
        }

        private void mnuContextExit_Click(object sender, EventArgs e)
        {
            //closes form
            exit();
        }

        private void mnuContextProductsMusic_Click(object sender, EventArgs e)
        {
            // opens music
            openMusic();
        }

        private void mnuContextProductsMovies_Click(object sender, EventArgs e)
        {
            //opens movie
            openMovie();
        }

        private void mnuContextProductsVideoGames_Click(object sender, EventArgs e)
        {
            // open video games
            openVideoGame();
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            openAbout();
        }

     
        

    }
}
