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
    public partial class frmMyMovieCollection : Form
    {
        public frmMyMovieCollection()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the application
            this.Close();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            frmAddMovie addMovie = new frmAddMovie();
            addMovie.ShowDialog();
        }

        private void btnViewMovies_Click(object sender, EventArgs e)
        {
            frmReadMovies readMovie = new frmReadMovies();
            readMovie.ShowDialog();
        }
        
    }
}
