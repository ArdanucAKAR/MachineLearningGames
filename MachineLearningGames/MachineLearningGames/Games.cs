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
            Snap.Snap snap = new Snap.Snap();
            snap.main = main;
            pnlMain.Controls.Clear();
            snap.Visible = false;
            pnlMain.Controls.Add(snap);
            transitionGames.ShowSync(snap);
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

        private void btnSchoolLibrary_Click(object sender, EventArgs e)
        {
            SchoolLibrary school_library = new SchoolLibrary();
            school_library.main = main;
            pnlMain.Controls.Clear();
            school_library.Visible = false;
            pnlMain.Controls.Add(school_library);
            transitionGames.ShowSync(school_library);
        }

        private void btnChatbot_Click(object sender, EventArgs e)
        {
            //ChatbotMainForm chatbot = new ChatbotMainForm();
            //chatbot.main = main;
            //pnlMain.Controls.Clear();
            //chatbot.Visible = false;
            //pnlMain.Controls.Add(chatbot);
            //transitionGames.ShowSync(chatbot);
        }

        private void btnJourneyToSchool_Click(object sender, EventArgs e)
        {
            GamePanel game = new GamePanel();
            game.main = main;
            pnlMain.Controls.Clear();
            game.Visible = false;
            pnlMain.Controls.Add(game);
            transitionGames.ShowSync(game);
        }

        private void btnTitanicGame_Click(object sender, EventArgs e)
        {
            Titanic titanic = new Titanic();
            titanic.main = main;
            pnlMain.Controls.Clear();
            titanic.Visible = false;
            pnlMain.Controls.Add(titanic);
            transitionGames.ShowSync(titanic);
        }

        private void btnMakeMeHappy_Click(object sender, EventArgs e)
        {
            MakeMeHappy.MakeMeHappy makeMeHappy = new MakeMeHappy.MakeMeHappy();
            makeMeHappy.main = main;
            pnlMain.Controls.Clear();
            makeMeHappy.Visible = false;
            pnlMain.Controls.Add(makeMeHappy);
            transitionGames.ShowSync(makeMeHappy);
        }
    }
}
