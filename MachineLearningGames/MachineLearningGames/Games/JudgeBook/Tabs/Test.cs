using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningGames.Main.Classes;

namespace MachineLearningGames.JudgeBook.Tabs
{
    public partial class Test : UserControl
    {
        Singleton db = Singleton.GetInstance();

        ImageList myImageList = new ImageList();
        OpenFileDialog ofd = new OpenFileDialog()
        {
            Multiselect = true,
            ValidateNames = true,
            Filter = "JPG|*jpg|JPEG|*.jpeg|PNG|*.png"
        };

        public Test()
        {
            InitializeComponent();
            btnTest.Visible = false;
            gbGuess.Visible = false;
            lblGuess.Visible = false;
        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            pbUploadPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ofd.ShowDialog();
            pbUploadPicture.ImageLocation = ofd.FileName;
            btnTest.Visible = true;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            lblGuess.Text = db.JudgeBook.Genre;
            gbGuess.Visible = true;
            lblGuess.Visible = true;
        }
    }
}
