using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningGames
{
    public partial class TrainSchoolLibrary : UserControl
    {
        public TrainSchoolLibrary()
        {
            InitializeComponent();
        }
        string[,] books = new string[100, 3];
        int counter = 0;
        int page;
        int line;
        int image;
        private void btnAddYearR_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPageYearR.Text, out page) && int.TryParse(txtLineYearR.Text, out line) && int.TryParse(txtImageYearR.Text, out image))
            {
                books[counter, 0] = txtPageYearR.Text;
                books[counter, 1] = txtLineYearR.Text;
                books[counter, 2] = txtImageYearR.Text;
                counter++;
                lbYearR.Items.Add("Sayfa : " + txtPageYearR.Text + " Satır : " + txtLineYearR.Text + " Resim : " + txtImageYearR.Text);
            }
            else
            {
                MessageBox.Show("Sayfa, Satır ve Resim Değerleri Integer Olmak Zorundadır...");
            }
            txtPageYearR.Text = "";
            txtLineYearR.Text = "";
            txtImageYearR.Text = "";
        }

        private void btnAddKeyStage1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPageKeyStage1.Text, out page) && int.TryParse(txtLineKeyStage1.Text, out line) && int.TryParse(txtImageKeyStage1.Text, out image))
            {
                books[counter, 0] = txtPageKeyStage1.Text;
                books[counter, 1] = txtLineKeyStage1.Text;
                books[counter, 2] = txtImageKeyStage1.Text;
                counter++;
                lbKeyStage1.Items.Add("Sayfa : " + txtPageKeyStage1.Text + " Satır : " + txtLineKeyStage1.Text + " Resim : " + txtImageKeyStage1.Text);
            }
            else
            {
                MessageBox.Show("Sayfa, Satır ve Resim Değerleri Integer Olmak Zorundadır...");
            }
            txtPageKeyStage1.Text = "";
            txtLineKeyStage1.Text = "";
            txtImageKeyStage1.Text = "";
        }

        private void btnAddKeyStage2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPageKeyStage2.Text, out page) && int.TryParse(txtLineKeyStage2.Text, out line) && int.TryParse(txtImageKeyStage2.Text, out image))
            {
                books[counter, 0] = txtPageKeyStage2.Text;
                books[counter, 1] = txtLineKeyStage2.Text;
                books[counter, 2] = txtImageKeyStage2.Text;
                counter++;
                lbKeyStage2.Items.Add("Sayfa : " + txtPageKeyStage2.Text + " Satır : " + txtLineKeyStage2.Text + " Resim : " + txtImageKeyStage2.Text);
            }
            else
            {
                MessageBox.Show("Sayfa, Satır ve Resim Değerleri Integer Olmak Zorundadır...");
            }
            txtPageKeyStage2.Text = "";
            txtLineKeyStage2.Text = "";
            txtImageKeyStage2.Text = "";
        }
    }
}
