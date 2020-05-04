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
       
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            UlasSingleton singleton = UlasSingleton.Instance;
           
            singleton.Journeys.LastOrDefault().Age = Convert.ToInt32(txtAge.Text);
            singleton.Journeys.LastOrDefault().Friends = Convert.ToInt32(txtFriends.Text);
            singleton.Journeys.LastOrDefault().Distance = Convert.ToDouble(txtDistance.Text);
          
           

            JourneyToSchoolUC add = new JourneyToSchoolUC();
            panel1.Controls.Clear();
            panel1.Controls.Add(add);
        }
    }
}
