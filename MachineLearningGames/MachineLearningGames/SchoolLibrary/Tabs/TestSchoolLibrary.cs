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
    public partial class TestSchoolLibrary : UserControl
    {
        public TestSchoolLibrary()
        {
            InitializeComponent();
        }

        private void btnTestEt_Click(object sender, EventArgs e)
        {
            int pageCount = Convert.ToInt32(txtPageTest.Text);
            int lineCount = Convert.ToInt32(txtLineTest.Text);
            int imageCount = Convert.ToInt32(txtImageTest.Text);

            if (pageCount <= 100 && imageCount >= 1)
                lblSonuc.Text = "Year R";
            else if (pageCount >= 100 && pageCount <= 300 && lineCount >= 10 && imageCount <= 20)
                lblSonuc.Text = "Key Stage 1";
            else if (pageCount >= 300 && lineCount >= 15)
                lblSonuc.Text = "Key Stage 2";
            else
                lblSonuc.Text = "Key Stage 2";
        }
    }
}
