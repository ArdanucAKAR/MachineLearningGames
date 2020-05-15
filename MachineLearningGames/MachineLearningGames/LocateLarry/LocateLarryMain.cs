using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningGames.LocateLarry.Tabs;
using MachineLearningGames.LocateLarry.Class;

namespace MachineLearningGames.LocateLarry
{
    public partial class LocateLarryMain : UserControl
    {
        public LocateLarryMain()
        {
            InitializeComponent();
        }
        public Form main;

        private void btnTrain_Click(object sender, EventArgs e)
        {
            pnlLocateLarryMain.Controls.Clear();
            LocateLarryTrain train = new LocateLarryTrain();
            pnlLocateLarryMain.Controls.Add(train);
        }

        SingletonLL db = SingletonLL.GetInstance();

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (db.larry == 0 && db.lily == 0 && db.kings== 0 && db.lady == 0 && db.golden == 0)
                MessageBox.Show("Lütfen önce güzel hayvanlarımızı tanıtın.", "Önemli", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (db.larry == 0 || db.lily == 0 || db.kings == 0 || db.lady == 0 || db.golden == 0)
                MessageBox.Show("Lütfen bütün hayvanlarımıza aynı önemi gösterin", "Önemli", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                pnlLocateLarryMain.Controls.Clear();
                LocateLarryTest test = new LocateLarryTest();
                pnlLocateLarryMain.Controls.Add(test);
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
