using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;

namespace MachineLearningGames
{
    public partial class SchoolLibrary : UserControl
    {
        public SchoolLibrary()
        {
            InitializeComponent();
        }

        public Form main;
        public bool isTrained = false;
        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            btnHome.LabelText = "Anasayfa";
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.LabelText = "";
        }

        private void btnTrain_MouseHover(object sender, EventArgs e)
        {
            btnTrain.LabelText = "Eğitme";
        }

        private void btnTrain_MouseLeave(object sender, EventArgs e)
        {
            btnTrain.LabelText = "";
        }

        private void btnTest_MouseHover(object sender, EventArgs e)
        {
            btnTest.LabelText = "Test";
        }

        private void btnTest_MouseLeave(object sender, EventArgs e)
        {
            btnTest.LabelText = "";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Panel pnl = main.Controls.Find("pnlMain", true).FirstOrDefault() as Panel;
            pnl.Controls.Clear();
            Games games = new Games();
            games.main = main;
            pnl.Controls.Add(games);
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            isTrained = true;
            pnlSchoolLibraryMain.Controls.Clear();
            TrainSchoolLibrary train = new TrainSchoolLibrary();
            pnlSchoolLibraryMain.Controls.Add(train);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if(isTrained)
            {
                TestSchoolLibrary test = new TestSchoolLibrary();
                pnlSchoolLibraryMain.Controls.Clear();
                pnlSchoolLibraryMain.Controls.Add(test);
            } 
            else {
                MessageBox.Show("Test Etmeden Önce Yapay Zekayı Eğitmeniz Gerekmektedir...");
            }
            
        }
    }
}
