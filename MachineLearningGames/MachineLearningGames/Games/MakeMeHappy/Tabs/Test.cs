using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningGames.Main.Classes;

namespace MachineLearningGames.MakeMeHappy.Tabs
{
    public partial class Test : UserControl
    {
        Singleton db = Singleton.GetInstance();

        public Test()
        {
            InitializeComponent();
        }

        public int ScorePhrase(string[] phrase)
        {
            int score = 0;
            foreach (string word in phrase)
            {
                try
                {
                    score += db.MakeMeHappy.WordsDic[word];
                }
                catch
                {
                    Console.WriteLine("Sözlükte olmayan kelime");
                }
            }
            return score;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string sentence = txtWord.Text;
            if (sentence != string.Empty && sentence.Length < 120)
            {
                string clearText = db.MakeMeHappy.PreparePhrase(sentence);
                string[] words = clearText.Split(' ');
                int score = ScorePhrase(words);

                pnlResult.Location = new Point((pnlMain.Width - pnlResult.Width) / 2, 28);

                if (score > 0)
                {
                    pbResult.Image = Properties.Resources.happy;
                    transitionResult.Hide(pnlTest);
                    transitionResult.ShowSync(pnlResult);
                }
                else if (score < 0)
                {
                    pbResult.Image = Properties.Resources.unhappy;
                    transitionResult.Hide(pnlTest);
                    transitionResult.ShowSync(pnlResult);
                }
                else
                {
                    pbResult.Image = Properties.Resources.expressionless;
                    transitionResult.Hide(pnlTest);
                    transitionResult.ShowSync(pnlResult);
                }
            }
        }

        private void Test_Load(object sender, EventArgs e)
        {
            pnlTest.Location = new Point((pnlMain.Width - pnlTest.Width) / 2, 28);
        }

        private void btnNewTest_Click(object sender, EventArgs e)
        {
            pnlTest.Location = new Point((pnlMain.Width - pnlTest.Width) / 2, 28);
            transitionResult.Hide(pnlResult);
            transitionResult.ShowSync(pnlTest);
            txtWord.Clear();
        }
    }
}
