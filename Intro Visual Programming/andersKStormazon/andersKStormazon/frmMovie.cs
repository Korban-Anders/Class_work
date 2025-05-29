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
    public partial class frmMovie : Form
    {
        public frmMovie()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close form
            this.Close();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmStrtFrom startUp = (frmStrtFrom)this.Owner;
            string ItemName;
            if (radBTTF.Checked)
                ItemName = "Back to the Future";
            else if (radCBML.Checked)
                ItemName = "Cant Buy Me Love";
            else if (radROTLA.Checked)
                ItemName = "Raiders of the Lost Ark";
            else
                ItemName = "The Breakfast Club";
            startUp.addItem(ItemName);
        } 
    }
}
