using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningGames.Ayberk;

namespace MachineLearningGames.Ayberk
{
    public partial class Chat : UserControl
    {
        Cevap c = Cevap.GetCevap();
        //char[] seperator = { "" };
        Int32 count = 2;
        public Chat()
        {
            InitializeComponent();
        }
        
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string[] strlist = c.cevaplar.ToArray();
            strlist.ToString();
            //string[] words = strlist.Split('.',' ');
            
            
            foreach (string cevap in c.cevaplar)
            {
                if (cevap.Contains(soruTextbx.text))
                {
                    cvpLabel.Text = cevap; 
                }
                else
                {
                    cvpLabel.Text = "Üzgünüm sizi anlayamadım.";
                }
            }
                 
        }
    }
}
