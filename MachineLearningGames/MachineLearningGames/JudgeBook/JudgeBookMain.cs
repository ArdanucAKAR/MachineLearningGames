using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningGames.JudgeBook.Tabs;
using MachineLearningGames.JudgeBook.Class;

namespace MachineLearningGames.JudgeBook
{
    public partial class JudgeBookMain : UserControl
    {
        public JudgeBookMain()
        {
            InitializeComponent();
        }

        SingletonJB db = SingletonJB.GetInstance();
        public Form main;

        private void btnHome_Click(object sender, EventArgs e)
        {
            Panel pnl = main.Controls.Find("pnlMain", true).FirstOrDefault() as Panel;
            pnl.Controls.Clear();
            Games games = new Games();
            games.main = main;
            pnl.Controls.Add(games);
        }

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
            pnlJudgeBookMain.Controls.Clear();
            JudgeBookTrain train = new JudgeBookTrain();
            pnlJudgeBookMain.Controls.Add(train);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (db.childrenBook == 0 && db.romanceBook == 0 && db.thrillerBook == 0 && db.scifiBook == 0)
                MessageBox.Show("Lütfen önce makineyi eğitin", "Önemli", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (db.childrenBook == 0 || db.romanceBook == 0 || db.thrillerBook == 0 || db.scifiBook == 0)
                MessageBox.Show("Lütfen bütün kitap türlerine resim yükleyin", "Önemli", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                JudgeBookTest test = new JudgeBookTest();
                pnlJudgeBookMain.Controls.Clear();
                pnlJudgeBookMain.Controls.Add(test);
            }
        }
    }
}
