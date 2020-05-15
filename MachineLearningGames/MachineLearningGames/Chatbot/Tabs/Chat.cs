using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningGames.Chatbot.Classes;

namespace MachineLearningGames.Chatbot.Tabs
{
    public partial class Chat : UserControl
    {
        SingletonCB db = SingletonCB.GetInstance();

        public Chat()
        {
            InitializeComponent();
        }

        private void btnAskLion_Click(object sender, EventArgs e)
        {
            string[] strlist = db.answers.ToArray();
            strlist.ToString();
            string[] words = soruTextbx.text.Split(' ', '?', '.');

            foreach (string cevap in db.answers)
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
