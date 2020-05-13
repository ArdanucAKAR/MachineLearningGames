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

        private int age = 0;
        private double distance = 0;
        private int friends = 0;
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            lblWarning.Visible = false;
            UlasSingleton singleton = UlasSingleton.Instance;
            if(int.TryParse(txtAge.Text,out age)&& double.TryParse(txtDistance.Text, out distance) && int.TryParse(txtFriends.Text, out friends))
            {

                singleton.Journeys.LastOrDefault().Age = age;
                singleton.Journeys.LastOrDefault().Friends = friends;
                singleton.Journeys.LastOrDefault().Distance = distance;

                JourneyToSchoolUC add = new JourneyToSchoolUC();
                panel1.Controls.Clear();
                panel1.Controls.Add(add);
            }
            else
            {
                lblWarning.Text = "Hatalı giriş yaptınız tekrar sayı giriniz";
                txtFriends.Text = "";
                txtAge.Text = "";
                txtDistance.Text = "";
                lblWarning.Visible = true;
            }
           
            

        }
    }
}
