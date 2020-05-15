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
    
    public partial class ChatBotTrain : UserControl
    {        
        public ChatBotTrain()
        {
            InitializeComponent();
        }

        SingletonCB db = SingletonCB.GetInstance();

        private void cevapBtn_Click(object sender, EventArgs e)
        {           
            db.answers.Add(cevapTextBox.text);
            MessageBox.Show("Cümlen eklendi..");
        }
    }
}
