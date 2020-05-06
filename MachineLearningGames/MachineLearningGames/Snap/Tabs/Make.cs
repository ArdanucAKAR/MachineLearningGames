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

namespace MachineLearningGames.Snap.Tabs
{
    public partial class Make : UserControl
    {
        public Make()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Lütfen Kart Resmini Seçiniz";
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string[] format = { ".png", ".jpg" };
                string[] cardTypes = { "spade", "diamond", "heart", "club", "maça", "karo", "kalp", "sinek" };
                string fileName = ofd.SafeFileName.ToLower();
                foreach (var f in format)
                    fileName = fileName.Replace(f, "");
                if(fileName==cardTypes[0]|| fileName == cardTypes[4])
                    lblResult.Text = cardTypes[4].ToUpper();
                else if(fileName==cardTypes[1]|| fileName == cardTypes[5])
                    lblResult.Text = cardTypes[5].ToUpper();
                else if(fileName==cardTypes[2]|| fileName == cardTypes[6])
                    lblResult.Text = cardTypes[6].ToUpper();
                else if(fileName==cardTypes[3]|| fileName == cardTypes[7])
                    lblResult.Text = cardTypes[7].ToUpper();
                else
                    lblResult.Text = "Sonuç Bulunmadı";
                pbResult.Image = Image.FromFile(ofd.FileName);
                pnlResult.Location = new Point((pnlMake.Width - pnlResult.Width) / 2, 28);                
                lblResult.Location = new Point((pnlResult.Width - lblResult.Width) / 2, 420);
                transitionResult.Hide(pnlTest);
                transitionResult.ShowSync(pnlResult);
            }
        }

        private void Make_Load(object sender, EventArgs e)
        {
            pnlTest.Location = new Point((pnlMake.Width - pnlTest.Width) / 2, 28);
        }

        private void btnNewTest_Click(object sender, EventArgs e)
        {
            pnlTest.Location = new Point((pnlMake.Width - pnlTest.Width) / 2, 28);
            transitionResult.Hide(pnlResult);
            transitionResult.ShowSync(pnlTest);
        }
    }
}
