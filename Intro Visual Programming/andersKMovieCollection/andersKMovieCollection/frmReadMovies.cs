using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace andersKMovieCollection
{
    public partial class frmReadMovies : Form
    {
        public frmReadMovies()
        {
            InitializeComponent();
        }

        //declare a StreamReader object
        StreamReader inFile;

        //fields
        string strInputFIle = "";
        int totalMovies = 0;
        int currentPostion = 0;

        //arrays
        string[] strMovieTitle = new string[100];
        int[] intMovieYear = new int[100];
        int[] intMovieRuntime = new int[100];
        int[] intMovieStars = new int[100];
        string[] strMovieGenre = new string[100];
        string[] strMovieFormat = new string[100];

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes Application
            this.Close();
        }

        private void readInFile() {
            // while not EOF or larger than buffer size it reads in the file
            while (!inFile.EndOfStream && totalMovies <=100) {
                strMovieTitle[totalMovies] = inFile.ReadLine();
                intMovieYear[totalMovies] = int.Parse(inFile.ReadLine());
                intMovieRuntime[totalMovies] = int.Parse(inFile.ReadLine());
                intMovieStars[totalMovies] = int.Parse(inFile.ReadLine());
                strMovieGenre[totalMovies] = inFile.ReadLine();
                strMovieFormat[totalMovies] = inFile.ReadLine();

                MessageBox.Show("Added Movie " + strMovieTitle[totalMovies] + " to the array at the index " + totalMovies + " out of 100 avaliable slots");

                //increases the total movie count
                totalMovies++;
            }
        }

        private void updateLabels() {
            // updates the labels for there repcted field 
            lblMovieTitle.Text = strMovieTitle[currentPostion];
            lblMovieYear.Text = intMovieYear[currentPostion].ToString();
            lblMovieRuntime.Text = intMovieRuntime[currentPostion].ToString();
            lblMovieStars.Text = intMovieStars[currentPostion].ToString();
            lblMovieGeneres.Text = strMovieGenre[currentPostion];
            lblMoiveFormat.Text = strMovieFormat[currentPostion];

            lblMoviePosition.Text = (currentPostion + 1).ToString() + " of " + totalMovies.ToString();
        }

        private void frmReadMovies_Load(object sender, EventArgs e)
        {
            // sets up the code to read into the movie file
            ofdOpenFile.ShowDialog();
            //MessageBox.Show(ofdOpenFile.FileName);
            strInputFIle = ofdOpenFile.FileName;

            if (System.IO.File.Exists(strInputFIle))
            {
                inFile = File.OpenText(strInputFIle);
                MessageBox.Show("File Exist");
                // if there is a file it reads in the movies and then updates the labels
                readInFile();
                updateLabels();
                UpdatePic();
            }
            else {
                MessageBox.Show("File does not exist.");
            }
        }
        //updates the picBox i hope this will work on the graders end
        private void UpdatePic() {
            if (strMovieTitle[currentPostion] == "Jurassic Park")
                picMoviePic.Image = Properties.Resources.Jurassic_Park_poster;
            else if (strMovieTitle[currentPostion] == "The Lost World")
                picMoviePic.Image = Properties.Resources.The_Lost_World_Jurassic_Park_poster;
            else if (strMovieTitle[currentPostion] == "Jurassic Park III")
                picMoviePic.Image = Properties.Resources.Jurassic_Park_III_poster;
            else if (strMovieTitle[currentPostion] == "Jurassic World")
                picMoviePic.Image = Properties.Resources.Jurassic_World_poster;
            else if (strMovieTitle[currentPostion] == "Jurassic World: Fallen Kingdom")
                picMoviePic.Image = Properties.Resources.Jurassic_World_Fallen_Kingdom;
            else if (strMovieTitle[currentPostion] == "Jurassic World Dominion")
                picMoviePic.Image = Properties.Resources.JurassicWorldDominion_Poster;
            else if (strMovieTitle[currentPostion] == "Star Wars Holiday Special")
                picMoviePic.Image = Properties.Resources.StarWarsHS;
        }

        private void postionCheck() {
            // if the currentPostion is not at the beginning or end then both buttons are enabled
            if ((currentPostion > 0) && (currentPostion < totalMovies - 1)) {
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
            }
            // if the currentPostion is at the start it diables the previous and enables next
            else if (currentPostion == 0){
                btnPrevious.Enabled = false;
                btnNext.Enabled = true;
                //MessageBox.Show("You are at the start of the movies");
            }
            // if the currentPostion is at the end it diables the next and enables previous
            else if (currentPostion == totalMovies - 1){
                btnNext.Enabled = false;
                btnPrevious.Enabled = true;
                MessageBox.Show("You are at the end of movies");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // moves to the next movie so long as there is one 
            if (currentPostion < totalMovies - 1)
            {
                currentPostion++;
                updateLabels();
                UpdatePic();
                postionCheck();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // moves to the prevoius movie as long as there is one
            if (currentPostion != 0)
            {
                currentPostion--;
                updateLabels();
                UpdatePic();
                postionCheck();
                
            }
            
        }

        private void frmReadMovies_FormClosed(object sender, FormClosedEventArgs e)
        {
            //closes the file
            inFile.Close();
        }


    }
}
