using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MachineLearningGames.RockPaperScissors.Classes;
using MachineLearningGames.RockPaperScissors.Tabs;

namespace MachineLearningGames.RockPaperScissors
{
    public partial class RockPaperScissors : UserControl
    {
        public RockPaperScissors()
        {
            InitializeComponent();
        }

        SingletonRPC db = SingletonRPC.GetInstance();
        public Form main;

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

        private void btnTrain_Click(object sender, EventArgs e)
        {
            Train train = new Train();
            pnlSnapMain.Controls.Clear();
            pnlSnapMain.Visible = false;
            pnlSnapMain.Controls.Add(train);
            transitionTabs.ShowSync(pnlSnapMain);
            btnTest.color = Color.Transparent;
            btnTrain.color = Color.DimGray;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            
            if (db.upload)
            {
                Test make = new Test();
                pnlSnapMain.Controls.Clear();
                pnlSnapMain.Visible = false;
                pnlSnapMain.Controls.Add(make);
                transitionTabs.ShowSync(pnlSnapMain);
                btnTrain.color = Color.Transparent;
                btnTest.color = Color.DimGray;
            }
            else
            {
                MessageBox.Show("Eğitim için resim yüklemeden test aşamasına geçilemez.");
                Train train = new Train();
                pnlSnapMain.Controls.Clear();
                pnlSnapMain.Visible = false;
                pnlSnapMain.Controls.Add(train);
                transitionTabs.ShowSync(pnlSnapMain);
                btnTest.color = Color.Transparent;
                btnTrain.color = Color.DimGray;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Panel pnlMain = main.Controls.Find("pnlMain", true).FirstOrDefault() as Panel;
            Panel pnlTop = main.Controls.Find("pnlTop", true).FirstOrDefault() as Panel;
            BunifuCustomLabel label = main.Controls.Find("lblHeader", true).FirstOrDefault() as BunifuCustomLabel;
            label.Text = "Çocuklar İçin Makine Öğrenmesi";
            label.Location = new Point((pnlTop.Width - label.Width) / 2, 12);
            pnlMain.Controls.Clear();
            Games games = new Games();
            games.main = main;
            pnlMain.Controls.Add(games);
        }

        private void RockPaperScissors_Load(object sender, EventArgs e)
        {
            lblDescription.Text = "Bu oyunda taş kağıt ve makas resimleri girildikten sonra girilen resmin taş mı kağıt mı yoksa makas mı olduğu tahmin edilir.";
            lblDescription.Location = new Point((pnlSnapMain.Width - lblDescription.Width) / 2, 457);
        }
    }
}
