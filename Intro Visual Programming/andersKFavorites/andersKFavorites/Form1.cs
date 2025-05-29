using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace andersKFavorites
{
    public partial class MyMusicMix : Form
    {
        public MyMusicMix()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // closes the gui
            this.Close();
        }

        private void picVolbeat_Click(object sender, EventArgs e)
        {
            // sets the picSelected text to Volbeat
            lblPicSelected.Text = "Volbeat";
        }

        private void picHeilung_Click(object sender, EventArgs e)
        {
            // sets the picSelected text to Heilung
            lblPicSelected.Text = "Heilung";
        }

        private void picGhost_Click(object sender, EventArgs e)
        {
            // sets the picSelected text to Ghost
            lblPicSelected.Text = "Ghost";
        }

        private void picBrotherOfMetal_Click(object sender, EventArgs e)
        {
            // sets the picSelected text to Brothers of Metal
            lblPicSelected.Text = "Brothers of Metal";
        }

        private void picCaravanPalace_Click(object sender, EventArgs e)
        {
            // sets the picSelected text to Cravan Palace
            lblPicSelected.Text = "Caravan Palace";
        }

        private void picPoorMansPosion_Click(object sender, EventArgs e)
        {
            // sets the picSelected text to Poor Mans Posion
            lblPicSelected.Text = "Poor Mans Posion";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // sets the picSelected text back to No Selection
            // hides the first three pics
            // shows the next three pics
            // disables the next btn
            lblPicSelected.Text = "No Selection";

            picVolbeat.Visible = false;
            picHeilung.Visible = false;
            picGhost.Visible = false;

            picBrotherOfMetal.Visible = true;
            picCaravanPalace.Visible = true;
            picPoorMansPosion.Visible = true;

            btnNext.Enabled = false;
            btnBack.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // sets the picSelected text back to No Selection
            // hides the current three pics
            // shows the last three pics
            // disables the back btn
            // enables the next btn

            lblPicSelected.Text = "No Selection";

            picVolbeat.Visible = true;
            picHeilung.Visible = true;
            picGhost.Visible = true;

            picBrotherOfMetal.Visible = false;
            picCaravanPalace.Visible = false;
            picPoorMansPosion.Visible = false;

            btnNext.Enabled = true;
            btnBack.Enabled = false;
        }

    }
}
