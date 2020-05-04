using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningGames.Ayberk
{
    
    public partial class ChatBotTrain : UserControl
    {
        public static List<String> konular = new List<String>();
        public static List<String> sorular = new List<String>();
        
        public ChatBotTrain()
        {
            InitializeComponent();
        }
        Cevap ce = Cevap.GetCevap();

        
        private void ChatBotTrain_Load(object sender, EventArgs e)
        {
           
        }       
        private void cevapBtn_Click(object sender, EventArgs e)
        {           
            ce.cevaplar.Add(cevapTextBox.text);
            MessageBox.Show("Cümlen eklendi..");
        }
    }
}
