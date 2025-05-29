using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace andersKMovieCollection
{
    public partial class frmAddMovie : Form
    {
        public frmAddMovie()
        {
            InitializeComponent();
        }

        // StreamWriter Object refernce variable
        StreamWriter outfile;

        //method to get all the data of a movie from the user
        private void getMovieData() {
            // movie variables 
            string strMovieTitle = txtMovieTitle.Text;
            int intMovieYear;            
            int intMovieRunTime;
            int intMovieStars = getStars();
            string strMovieGenre = getGenre();
            string strMovieFormat = cobFormat.SelectedItem.ToString();

            int.TryParse(txtYear.Text, out intMovieYear);
            int.TryParse(txtRuntime.Text, out intMovieRunTime);

            writeMovieData(strMovieTitle, intMovieYear, intMovieRunTime, intMovieStars, strMovieGenre, strMovieFormat);

            MessageBox.Show(strMovieTitle + " Was Sccuessfully add to colection");
        }

        // Method to get the star rating 
        private int getStars() {
            int intStars = 0;

            if (radStarOne.Checked)
                intStars = 1;
            else if (radStarTwo.Checked)
                intStars = 2;
            else if (radStartThree.Checked)
                intStars = 3;
            else
                intStars = 4;
            //MessageBox.Show(intStars.ToString());
            return intStars;
        }

        //Method to get the genre of the movie
        private string getGenre() {
            string strGenre = "";

            if (chkGenreAction.Checked)
                strGenre += "Action ";
            if (chkGenreComedy.Checked)
                strGenre += "Comedy ";
            if (chkGenreDrama.Checked)
                strGenre += "Drama ";
            if (chkGenreKids.Checked)
                strGenre += "Kids ";
            if (chkGenreSciFi.Checked)
                strGenre += "Sci-Fi ";
            if (chkGenreTelevision.Checked)
                strGenre += "Television ";

            //MessageBox.Show(strGenre);

            return strGenre;
        }

        // method to write/append the data to the movie.txt file
        private void writeMovieData(string title, int year, int runtime, int stars, string genre, string format) {
            saveFileDialog1.ShowDialog();
            //MessageBox.Show(saveFileDialog1.FileName);
            string strSaveFile = saveFileDialog1.FileName;

            outfile = File.AppendText(strSaveFile);

            outfile.WriteLine(title);
            outfile.WriteLine(year);
            outfile.WriteLine(runtime);
            outfile.WriteLine(stars);
            outfile.WriteLine(genre);
            outfile.WriteLine(format);

            outfile.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void frmAddMovie_Load(object sender, EventArgs e)
        {
            //set up the combo box 
            cobFormat.Items.Add("LazerDisk");
            cobFormat.Items.Add("VHS");
            cobFormat.Items.Add("DVD");
            cobFormat.Items.Add("Blu-Ray");
            cobFormat.Items.Add("Video File");
            cobFormat.Items.Add("Streaming");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // calls get movie function
            getMovieData();
            clear();

        }


        private void clear() {
            // Clears all input areas
            txtMovieTitle.Text = "";
            txtYear.Text = "";
            txtRuntime.Text = "";

            radStarOne.Checked = false;
            radStarTwo.Checked = false;
            radStartThree.Checked = false;
            radStarFour.Checked = false;

            chkGenreAction.Checked = false;
            chkGenreComedy.Checked = false;
            chkGenreDrama.Checked = false;
            chkGenreKids.Checked = false;
            chkGenreSciFi.Checked = false;
            chkGenreTelevision.Checked = false;

            cobFormat.SelectedItem = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

    }
}
