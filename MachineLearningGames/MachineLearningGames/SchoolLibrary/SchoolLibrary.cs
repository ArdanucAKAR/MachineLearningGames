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

namespace MachineLearningGames
{
    public partial class SchoolLibrary : UserControl
    {
        public SchoolLibrary()
        {
            InitializeComponent();
        }

        public Form main;

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Panel pnl = main.Controls.Find("pnlMain", true).FirstOrDefault() as Panel;
            pnl.Controls.Clear();
            Games games = new Games();
            games.main = main;
            pnl.Controls.Add(games);
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            pnlSchoolLibraryMain.Controls.Clear();
            Train train = new Train();
            pnlSchoolLibraryMain.Visible = false;
            pnlSchoolLibraryMain.Controls.Add(train);
        }
    }
}
