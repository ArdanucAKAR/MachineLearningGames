using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningGames.Mehmetcik.Class;

namespace MachineLearningGames.Mehmetcik.Tabs
{
    public partial class PicturesTest : UserControl
    {


        Pictures db = Pictures.SingleInstance();
        System.Windows.Forms.ImageList myImageList = new ImageList();

        OpenFileDialog ofd = new OpenFileDialog()
        {
            Multiselect = true,
            ValidateNames = true,
            Filter =
         "JPG|*jpg|JPEG|*.jpeg|PNG|*.png"
        };





        public PicturesTest()
        {
            InitializeComponent();
            
            gbGuess.Visible = false;
            lblGuess.Visible = false;
        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }

        /*
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureLarry_Click(object sender, EventArgs e)
        {

        }

       */

        private void btnUploadLarry_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureLarry.ImageLocation = openFileDialog1.FileName;

        }

      

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureLarry.ImageLocation = openFileDialog1.FileName;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureLarry.ImageLocation = openFileDialog1.FileName;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureLarry.ImageLocation = openFileDialog1.FileName;
        }

        private void pictureLarry_Click(object sender, EventArgs e)
        {
            {
                lblGuess.Text = db.genre;
                gbGuess.Visible = true;
                lblGuess.Visible = true;
            }
        }

        private void pictureNotLarry1_Click(object sender, EventArgs e)
        {
            {
                lblGuess.Text = db.genre;
                gbGuess.Visible = true;
                lblGuess.Visible = true;
            }
        }

        private void pictureNotLarry2_Click(object sender, EventArgs e)
        {
            {
                lblGuess.Text = db.genre;
                gbGuess.Visible = true;
                lblGuess.Visible = true;
            }
        }

        private void pictureNotLarry3_Click(object sender, EventArgs e)
        {
            {
                lblGuess.Text = db.genre;
                gbGuess.Visible = true;
                lblGuess.Visible = true;
            }
        }
    }
}
