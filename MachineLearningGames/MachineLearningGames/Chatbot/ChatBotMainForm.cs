using MachineLearningGames.Ayberk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningGames
{
    public partial class ChatbotMainForm : Form
    {
        public ChatbotMainForm()
        {
            InitializeComponent();
        }
        public Form main;
        private void trainButton_Click(object sender, EventArgs e)
        {
            ChatBotTrain cs = new ChatBotTrain();
            
            mainPanels.Controls.Clear();
            mainPanels.Controls.Add(cs);
                       
        }

   

        private void makeButton_Click(object sender, EventArgs e)
        {
            Chat c = new Chat();
            mainPanels.Controls.Clear();
            mainPanels.Controls.Add(c);            
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Games games = new Games();
            games.Show();
            this.Hide();
        }
    }
}
