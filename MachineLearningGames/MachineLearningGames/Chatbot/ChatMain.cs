using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningGames.Chatbot.Tabs;

namespace MachineLearningGames.Chatbot
{
    public partial class ChatMain : UserControl
    {
        public ChatMain()
        {
            InitializeComponent();
        }

        public Form main;

        private void homeButton_Click_1(object sender, EventArgs e)
        {
            Panel pnl = main.Controls.Find("pnlMain", true).FirstOrDefault() as Panel;
            pnl.Controls.Clear();
            Games games = new Games();
            games.main = main;
            pnl.Controls.Add(games);
        }

        private void trainButton_Click_1(object sender, EventArgs e)
        {
            ChatBotTrain cs = new ChatBotTrain();
            mainPanels.Controls.Clear();
            mainPanels.Controls.Add(cs);
        }

        private void makeButton_Click_1(object sender, EventArgs e)
        {
            Chat c = new Chat();
            mainPanels.Controls.Clear();
            mainPanels.Controls.Add(c);
        }
    }
}
