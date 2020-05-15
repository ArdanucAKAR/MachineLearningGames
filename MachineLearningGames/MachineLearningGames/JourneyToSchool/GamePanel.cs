using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningGames.JourneyToSchool.Classes;
using MachineLearningGames.JourneyToSchool.Tabs;

namespace MachineLearningGames
{
    public partial class GamePanel : UserControl
    {
        SingletonJTS db = SingletonJTS.GetInstance();

        public Form main;

        public GamePanel()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (db.Journeys.Count > 0)
            {
                TestUc add = new TestUc();
                mainGamingPanel.Controls.Clear();
                mainGamingPanel.Controls.Add(add);
            }
            else
                MessageBox.Show("Model eğitmeden test aşamasına geçilemez");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (db.Journeys.Count > 0 && db.Journeys[db.Journeys.Count - 1].Age <= 0)
                db.Journeys.RemoveAt(db.Journeys.Count - 1);

            Panel pnl = main.Controls.Find("pnlMain", true).FirstOrDefault() as Panel;
            pnl.Controls.Clear();
            Games games = new Games();
            games.main = main;
            pnl.Controls.Add(games);
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            if (db.Journeys.Count > 0 && db.Journeys[db.Journeys.Count - 1].Age <= 0)
                db.Journeys.RemoveAt(db.Journeys.Count - 1);

            JourneyToSchoolUC add = new JourneyToSchoolUC();
            mainGamingPanel.Controls.Clear();
            mainGamingPanel.Controls.Add(add);
        }

        private void GamePanel_Load(object sender, EventArgs e)
        {
            lblDescription.Text = "Bu oyunda belirli verileri girdikten sonra okula hangi araçla gidiceğiniz tahmin edilir.";
            lblDescription.Location = new Point((mainGamingPanel.Width - lblDescription.Width) / 2, 457);
        }
    }
}