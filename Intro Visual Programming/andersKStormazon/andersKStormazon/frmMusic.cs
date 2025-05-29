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
    public partial class frmMusic : Form
    {
        public frmMusic()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }

        private void picGNR_Click(object sender, EventArgs e)
        {
            frmStrtFrom startUp = (frmStrtFrom)this.Owner;
            startUp.addItem("Guns N Roses");
        }

        private void picJovi_Click(object sender, EventArgs e)
        {
            frmStrtFrom startUp = (frmStrtFrom)this.Owner;
            startUp.addItem("Bon Jovi");
        }

        private void picMotley_Click(object sender, EventArgs e)
        {
            frmStrtFrom startUp = (frmStrtFrom)this.Owner;
            startUp.addItem("Motley Crue");
        }

        private void picPoison_Click(object sender, EventArgs e)
        {
            frmStrtFrom startUp = (frmStrtFrom)this.Owner;
            startUp.addItem("Poison");
        }

        
    }
}
