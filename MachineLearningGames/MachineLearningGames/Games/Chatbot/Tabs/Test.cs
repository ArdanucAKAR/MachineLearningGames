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

namespace MachineLearningGames.Chatbot.Tabs
{
    public partial class Test : UserControl
    {
        Singleton db = Singleton.GetInstance();

        public Test()
        {
            InitializeComponent();
        }

        private void btnAskLion_Click(object sender, EventArgs e)
        {            
            string[] words = soruTextbx.text.Split(' ', '?', '.');

            foreach (string cevap in db.ChatBot.Answers)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i] == "Aslan" && words[i] == "Aslanlar")
                        break;

                    if (cevap.Contains(words[i]))
                    {
                        cvpLabel.Text = cevap;
                        continue;
                    }
                    else
                        cvpLabel.Text = "Üzgünüm sizi anlayamadım. RAWWWWWWWWRRRRRRRR!";
                }
            }
        }
    }
}
