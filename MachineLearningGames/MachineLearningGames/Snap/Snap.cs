using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BunifuAnimatorNS;
using MachineLearningGames.Snap.Tabs;
using Bunifu.Framework.UI;

namespace MachineLearningGames.Snap
{
    public partial class Snap : UserControl
    {
        public Snap()
        {
            InitializeComponent();
        }

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
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Make make = new Make();
            pnlSnapMain.Controls.Clear();
            pnlSnapMain.Visible = false;
            pnlSnapMain.Controls.Add(make);
            transitionTabs.ShowSync(pnlSnapMain);
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

        private void Snap_Load(object sender, EventArgs e)
        {
            Panel pnl = main.Controls.Find("pnlTop", true).FirstOrDefault() as Panel;
            BunifuCustomLabel label = main.Controls.Find("lblHeader", true).FirstOrDefault() as BunifuCustomLabel;
            label.Text = "SNAP - Çocuklar İçin Makine Öğrenmesi";
            label.Location = new Point((pnl.Width - label.Width) / 2, 12);
            pbSnap.Location = new Point((pnlSnapMain.Width - pbSnap.Width) / 2, 71);
            lblSnap.Location = new Point((pnlSnapMain.Width - lblSnap.Width) / 2, 400);
            lblDescription.Text = "Bu oyunda eğitim aşamasında farklı tiplerde oyun kartlarına yükleyeceğiniz resimleri eğiterek\n    test aşamasında yükleyeceğiniz resmin hangi oyun kartına ait olduğunu öğrenebilirsiniz.";
            lblDescription.Location = new Point((pnlSnapMain.Width - lblDescription.Width) / 2, 457);
        }
    }
}
