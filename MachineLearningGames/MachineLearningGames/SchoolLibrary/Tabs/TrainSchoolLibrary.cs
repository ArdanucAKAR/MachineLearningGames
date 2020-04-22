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

        private void btnAddYearR_Click(object sender, EventArgs e)
        {
            books[counter, 0] = txtPageYearR.Text;
            books[counter, 1] = txtLineYearR.Text;
            books[counter, 2] = txtImageYearR.Text;
            counter++;
            lbYearR.Items.Add("Page : " + txtPageYearR.Text + " Line : " + txtLineYearR.Text + " Image : " + txtImageYearR.Text);
        }

        private void btnAddKeyStage1_Click(object sender, EventArgs e)
        {
            books[counter, 0] = txtPageKeyStage1.Text;
            books[counter, 1] = txtLineKeyStage1.Text;
            books[counter, 2] = txtImageKeyStage1.Text;
            counter++;
            lbKeyStage1.Items.Add("Page : " + txtPageKeyStage1.Text + " Line : " + txtLineKeyStage1.Text + " Image : " + txtImageKeyStage1.Text);
        }

        private void btnAddKeyStage2_Click(object sender, EventArgs e)
        {
            books[counter, 0] = txtPageKeyStage2.Text;
            books[counter, 1] = txtLineKeyStage2.Text;
            books[counter, 2] = txtImageKeyStage2.Text;
            counter++;
            lbKeyStage2.Items.Add("Page : " + txtPageKeyStage2.Text + " Line : " + txtLineKeyStage2.Text + " Image : " + txtImageKeyStage2.Text);
        }
    }
}
