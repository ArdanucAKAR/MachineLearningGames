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

    public partial class Train : UserControl
    {
        Singleton db = Singleton.GetInstance();

        public Train()
        {
            InitializeComponent();
        }

        private void cevapBtn_Click(object sender, EventArgs e)
        {
            db.ChatBot.Answers.Add(cevapTextBox.text);
            MessageBox.Show("Cümlen eklendi..");
        }
    }
}
