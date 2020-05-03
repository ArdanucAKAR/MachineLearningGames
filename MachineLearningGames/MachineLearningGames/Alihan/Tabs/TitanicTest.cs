using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningGames.Alihan.Tabs
{
    public partial class TitanicTest : UserControl
    {
        public TitanicTest()
        {
            InitializeComponent();
        }

        private int _counter = 0;
        private void btnTest_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(txtAge.text);
            int sibSop = Convert.ToInt32(txtSiblingsOrSpouse.text);
            int parChil = Convert.ToInt32(txtParentOrChildren.text);
            int ticketFare = Convert.ToInt32(txtTickerFare.text);
            int ticketClass = Convert.ToInt32(drpTicketClass.selectedValue);

            if (age > 15 && age < 20 && ticketClass == 3 && parChil == 0 && sibSop == 0 && ticketFare < 75)
            {
                lblResult.ForeColor = Color.LawnGreen;
                lblResult.Text = "HAYATTA KALDI";
            }
            else if (age > 20 && age < 40 && ticketClass == 1 && parChil < 2 && sibSop < 2 && ticketFare > 75)
            {
                lblResult.ForeColor = Color.LawnGreen;
                lblResult.Text = "HAYATTA KALDI";
            }
            else
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "HAYATTA KALAMADI";
            }

        }
    }
}
