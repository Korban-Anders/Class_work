using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace andersKYourStore
{
    public partial class Form1 : Form
    {
        // Global Variables

        // update number of burgers, fries, and sodas
        int intNumOfBurgers = 0;
        int intNumOfFries = 0;
        int intNumOfSoda = 0;

        // update tip, sub-tax, tax, and total
        const double DBL_TAX_CONST = 0.07;
        double dblSubTax = 0;
        double dblTotal = 0;
        double dblTax = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBurger_Click(object sender, EventArgs e)
        {
           /*
            * have a const burger price val
            * update number of burgers on burger lbl
            * update subtotal, tax, and total
            */
            // burger vars
            const double dblBurgerCost = 3.27;

            // update number of burgers on burger lbl
            intNumOfBurgers++;
            lblBurgerNum.Text = intNumOfBurgers.ToString();

            // update sub total lbl
            dblSubTax = dblSubTax + dblBurgerCost;
            lblSubTotal.Text = dblSubTax.ToString("c2");

            //update tax lbl
            dblTax = dblTax + (dblBurgerCost * DBL_TAX_CONST);
            lblTax.Text = dblTax.ToString("c2");

            //update total lbl
            dblTotal = dblSubTax + dblTax;
            lblTotal.Text = dblTotal.ToString("c2");
        }

        private void picFries_Click(object sender, EventArgs e)
        {
            /*
            * have a const fries price val
            * update number of fries on fries lbl
            * update subtotal, tax, and total
            */
            // Fries vars
            const double dblFriesCost = 1.57;

            // update number of fries on fries lbl
            intNumOfFries++;
            lblFriesNum.Text = intNumOfFries.ToString();

            // update sub total lbl
            dblSubTax = dblSubTax + dblFriesCost;
            lblSubTotal.Text = dblSubTax.ToString("c2");

            //update tax lbl
            dblTax = (dblSubTax * DBL_TAX_CONST);
            lblTax.Text = dblTax.ToString("c2");

            //update total lbl
            dblTotal = dblSubTax + dblTax;
            lblTotal.Text = dblTotal.ToString("c2");
        }

        private void picSoda_Click(object sender, EventArgs e)
        {
            /*
            * have a const soda price val
            * update number of soda on soda lbl
            * update subtotal, tax, and total
            */
            // soda vars
            const double dblSodaCost = 0.94;

            // update number of soda on soda lbl
            intNumOfSoda++;
            lblSodaNum.Text = intNumOfSoda.ToString();

            // update sub total lbl
            dblSubTax = dblSubTax + dblSodaCost;
            lblSubTotal.Text = dblSubTax.ToString("c2");

            //update tax lbl
            dblTax = (dblSubTax * DBL_TAX_CONST);
            lblTax.Text = dblTax.ToString("c2");

            //update total lbl
            dblTotal = dblSubTax + dblTax;
            lblTotal.Text = dblTotal.ToString("c2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            /*
            * Set all changed lbls back to default
            */

            // Set food lbl to 0
            lblBurgerNum.Text = "0";
            lblFriesNum.Text = "0";
            lblSodaNum.Text = "0";

            // Set food vars to 0
            intNumOfBurgers = 0;
            intNumOfFries = 0;
            intNumOfSoda = 0;

            // Set sub total, tax, and total lbl to 0
            lblSubTotal.Text = "$0";
            lblTax.Text = "$0";
            lblTotal.Text = "$0";

            // Set sub total, tax, and total var to 0
            dblSubTax = 0;
            dblTax = 0;
            dblTotal = 0;

            // Clears and enables the tip txt and btn
            txtTip.Text = "";
            lblUpdatedTotal.Visible = false;
            btnTip.Enabled = true;
            txtTip.Enabled = true;
        }

        private void btnTip_Click(object sender, EventArgs e)
        {
            /*
            *   take the txt input and add it to the total
             *  change the updatedTotal lbl to reflect the tip
             *  diable the tip btn
            */

            // try catch to make sure the user puts in a whole number
            try
            {
                // updates total with tip
                double dblTip = int.Parse(txtTip.Text);
                dblTotal = dblTotal + dblTip;
                lblTotal.Text = dblTotal.ToString("c2");

                // updates updatedTotal lbl and makes it vidable
                lblUpdatedTotal.Text = "Total includes a $" + txtTip.Text + " tip";
                lblUpdatedTotal.Visible = true;

                // disables tip btn and txt
                btnTip.Enabled = false;
                txtTip.Enabled = false;
            }
            catch {
                MessageBox.Show("Enter a Whole Number Please");
            }
        }

        
    }
}
