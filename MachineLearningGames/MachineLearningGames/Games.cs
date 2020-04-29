using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningGames.JudgeBook;
using MachineLearningGames.Mehmetcik;

namespace MachineLearningGames
{
    public partial class Games : UserControl
    {
        public Games()
        {
            InitializeComponent();
        }

        public Form main;

        private void btnSnap_Click(object sender, EventArgs e)
        {
            Snap snap = new Snap();
            snap.main = main;
            pnlMain.Controls.Clear();
            snap.Visible = false;
            pnlMain.Controls.Add(snap);
            transitionGames.ShowSync(snap);
        }

        private void btnSchoolLibrary_Click(object sender, EventArgs e)
        {
            SchoolLibrary school_library = new SchoolLibrary();
            school_library.main = main;
            pnlMain.Controls.Clear();
            school_library.Visible = false;
            pnlMain.Controls.Add(school_library);
            transitionGames.ShowSync(school_library);
        }

        private void btnJudgeBook_Click(object sender, EventArgs e)
        {
            JudgeBookMain judgeBook = new JudgeBookMain();
            judgeBook.main = main;
            pnlMain.Controls.Clear();
            judgeBook.Visible = false;
            pnlMain.Controls.Add(judgeBook);
            transitionGames.ShowSync(judgeBook);
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            JudgeBookMain judgeBook = new JudgeBookMain();
            judgeBook.main = main;
            pnlMain.Controls.Clear();
            judgeBook.Visible = false;
            pnlMain.Controls.Add(judgeBook);
            transitionGames.ShowSync(judgeBook);
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            LocateLarryMain1 yeniSayfa = new LocateLarryMain1();
            
            yeniSayfa.ShowDialog();
            this.Show();
        }
    }
}
