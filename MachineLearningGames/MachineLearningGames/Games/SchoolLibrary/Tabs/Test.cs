using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningGames.SchoolLibrary.Tabs
{
    public partial class Test : UserControl
    {
        public Test()
        {
            InitializeComponent();
        }

        private void btnTestEt_Click(object sender, EventArgs e)
        {
            int pageCount;
            int lineCount;
            int imageCount;

            if (int.TryParse(txtPageTest.Text, out pageCount) && int.TryParse(txtLineTest.Text, out lineCount) && int.TryParse(txtImageTest.Text, out imageCount))
            {
                if (pageCount <= 100 && imageCount >= 1)
                    lblSonuc.Text = "Çocuk Kitabı";
                else if (pageCount >= 100 && pageCount <= 300 && lineCount >= 10 && imageCount <= 20)
                    lblSonuc.Text = "Birinci Seviye";
                else if (pageCount >= 300 && lineCount >= 15)
                    lblSonuc.Text = "İkinci Seviye";
                else
                    lblSonuc.Text = "İkinci Seviye";
            }
            else
                MessageBox.Show("Sayfa, Satır ve Resim Değerleri Integer Olmak Zorundadır...");
        }
    }
}
