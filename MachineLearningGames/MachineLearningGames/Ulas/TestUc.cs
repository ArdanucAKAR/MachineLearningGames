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
    public partial class TestUc : UserControl
    {
        public TestUc()
        {
            InitializeComponent();
        }

        

       

        private void btnTry_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int _random = rnd.Next(3);

            if (_random == 0)
            {
                lblResult.Text = "Car";
            }
            else if (_random == 1)
            {
                lblResult.Text = "Walk";
            }
            else
            {
                lblResult.Text = "Cycle";
            }
        }
    }
}
