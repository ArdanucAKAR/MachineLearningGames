using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningGames.MakeMeHappy.Tabs;
using MachineLearningGames.MakeMeHappy.Classes;

namespace MachineLearningGames.MakeMeHappy
{
    public partial class MakeMeHappy : UserControl
    {
        public MakeMeHappy()
        {
            InitializeComponent();
        }

        public Form main;

        SingletonMMH db = SingletonMMH.GetInstance();

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
            Train train = new Train();
            pnlSnapMain.Controls.Clear();
            pnlSnapMain.Visible = false;
            pnlSnapMain.Controls.Add(train);
            transitionTabs.ShowSync(pnlSnapMain);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (db.wordsDic.Count > 20)
            {
                Test train = new Test();
                pnlSnapMain.Controls.Clear();
                pnlSnapMain.Visible = false;
                pnlSnapMain.Controls.Add(train);
                transitionTabs.ShowSync(pnlSnapMain);
            }
            else
            {
                MessageBox.Show("Cümle Girmeden Test Aşamasına Geçilemez");
                Train train = new Train();
                pnlSnapMain.Controls.Clear();
                pnlSnapMain.Visible = false;
                pnlSnapMain.Controls.Add(train);
                transitionTabs.ShowSync(pnlSnapMain);
            }
        }
    }
}
