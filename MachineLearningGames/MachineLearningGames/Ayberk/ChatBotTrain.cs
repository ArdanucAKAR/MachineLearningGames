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
        public ChatBotTrain()
        {
            InitializeComponent();
        }

        List<String> konular = new List<String>();
        private void konuekleBtn_Click(object sender, EventArgs e)
        {

            //konular.Add(new Konu()
            //{
            //    konu = konuTextbox.text
            //});
            konular.Add(konuTextbox.text);
            //konularCombo.DataSource = konular;
            konularCombo.Items.Add(konular);
            konularCombo.DisplayMember = "konu";
            konularCombo.Items.Clear();
            foreach (string item in konular)
            {
                konularCombo.Items.Add(item.ToString());
            }
        }  
        private void ChatBotTrain_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            object selected = konularCombo.SelectedItem;
            MessageBox.Show(selected.ToString());
        }
    }
}
