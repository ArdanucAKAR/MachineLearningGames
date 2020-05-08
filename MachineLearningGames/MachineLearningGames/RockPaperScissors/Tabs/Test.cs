using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningGames.RockPaperScissors.Tabs
{
    public partial class Test : UserControl
    {
        public Test()
        {
            InitializeComponent();
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Lütfen Hamle Resminizi Seçiniz";
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string[] format = { ".png", ".jpg",".jpeg" };
                string[] pickTypes = { "rock", "paper", "scissors", "taş", "kağıt", "makas" };
                string fileName = ofd.SafeFileName.ToLower();
                foreach (var f in format)
                    fileName = fileName.Replace(f, "");
                if (fileName == pickTypes[0] || fileName == pickTypes[3])
                    lblResult.Text = pickTypes[3].ToUpper();
                else if (fileName == pickTypes[1] || fileName == pickTypes[4])
                    lblResult.Text = pickTypes[4].ToUpper();
                else if (fileName == pickTypes[2] || fileName == pickTypes[5])
                    lblResult.Text = pickTypes[5].ToUpper();
                else
                    lblResult.Text = "Sonuç Bulunmadı";
                pbResult.Image = Image.FromFile(ofd.FileName);
                pnlResult.Location = new Point((pnlMain.Width - pnlResult.Width) / 2, 28);
                lblResult.Location = new Point((pnlResult.Width - lblResult.Width) / 2, 420);
                transitionResult.Hide(pnlTest);
                transitionResult.ShowSync(pnlResult);
            }
        }

        private void Test_Load(object sender, EventArgs e)
        {
            pnlTest.Location = new Point((pnlMain.Width - pnlTest.Width) / 2, 28);
        }

        private void btnNewTest_Click(object sender, EventArgs e)
        {
            pnlTest.Location = new Point((pnlMain.Width - pnlTest.Width) / 2, 28);
            transitionResult.Hide(pnlResult);
            transitionResult.ShowSync(pnlTest);
        }
    }
}
