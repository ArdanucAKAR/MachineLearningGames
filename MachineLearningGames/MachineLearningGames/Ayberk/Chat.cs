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
   
        public Chat()
        {
            InitializeComponent();
        }
        
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string[] strlist = c.cevaplar.ToArray();
            strlist.ToString();
            //string[] words = strlist.Split('.',' ');
            string[] words = soruTextbx.text.Split(' ','?','.');
            
            foreach (string cevap in c.cevaplar)
            {
                for(int i =0;i<words.Length;i++)
                {
                    if (cevap.Contains(words[i]))
                    {
                        cvpLabel.Text = cevap;
                        continue;
                    }
                    else
                    {
                        cvpLabel.Text = "Üzgünüm sizi anlayamadım. RAWWWWWWWWRRRRRRRR!";
                    }
                }
                             
            }
                 
        }
    }
}
