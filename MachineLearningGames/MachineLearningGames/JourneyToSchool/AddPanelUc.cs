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
    public partial class AddPanelUc : UserControl
    {
        public AddPanelUc()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UlasSingleton singleton = UlasSingleton.Instance;
            Journey journey = new Journey();
            journey.Age = Convert.ToInt32(txtAge.Text);
            journey.Friends = Convert.ToInt32(txtFriends.Text);
            journey.Distance = Convert.ToDouble(txtDistance.Text);
            journey.JouneyType = 1;
            singleton.Journeys.Add(journey);
        }
    }
}
