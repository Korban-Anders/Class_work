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
    public partial class frmVideoGame : Form
    {
        public frmVideoGame()
        {
            InitializeComponent();
            // adds items on start up
            addToSelectList();
        }

        // closes form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //adds the items to the list to be selected
        private void addToSelectList() {
            lstSelectItem.Items.Add("Atari 2600");
            lstSelectItem.Items.Add("NES");
            lstSelectItem.Items.Add("SNES");
            lstSelectItem.Items.Add("Sega Genesis");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmStrtFrom startUp = (frmStrtFrom)this.Owner;
            
            //index of selected items
            int intIndex = lstSelectItem.SelectedIndex;
            string strItem;

            if (intIndex != -1){
                strItem = lstSelectItem.Items[intIndex].ToString();
                startUp.addItem(strItem);
            }

        }


    }
}
