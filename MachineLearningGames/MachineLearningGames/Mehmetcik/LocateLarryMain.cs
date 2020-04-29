using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningGames.Mehmetcik.Tabs;
using MachineLearningGames.Mehmetcik.Class;

namespace MachineLearningGames.Mehmetcik
{
    public partial class LocateLarryMain1 : UserControl
    {
        public Form main;
        Pictures db = Pictures.SingleInstance();
        public LocateLarryMain1()
        {
            InitializeComponent();
        }

        private void judgeBookMain1_Load(object sender, EventArgs e)
        {
        
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            PicturesTest test = new PicturesTest();
            this.Hide();
            
            test.ShowDialog();
            this.Show();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            PicturesTrain1 train = new PicturesTrain1();
            this.Hide();

            train.ShowDialog();
            this.Show();

        }

        private void LocateLarryMain1_Load(object sender, EventArgs e)
        {
            
        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}
