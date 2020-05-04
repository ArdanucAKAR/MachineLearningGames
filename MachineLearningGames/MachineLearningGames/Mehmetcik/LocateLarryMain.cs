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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        public Form main;
        Pictures db = Pictures.SingleInstance();
        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            pnlLocateLarry.Controls.Clear();
            PicturesTrain3 train = new PicturesTrain3();
            pnlLocateLarry.Controls.Add(train);

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (db.larry == 0 && db.notLarry == 0 )
            {
                MessageBox.Show("Lütfen önce makineyi eğitin", "Önemli", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (db.larry == 0 && db.notLarry == 0)
            {
                MessageBox.Show("Lütfen bütün hayvanlari öğretin", "Önemli", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                pnlLocateLarry.Controls.Clear();
                PicturesTest2 test = new PicturesTest2();
                pnlLocateLarry.Controls.Add(test);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Panel pnl = main.Controls.Find("pnlMain", true).FirstOrDefault() as Panel;
            pnl.Controls.Clear();
            Games games = new Games();
            games.main = main;
            pnl.Controls.Add(games);
        }
    }
}
