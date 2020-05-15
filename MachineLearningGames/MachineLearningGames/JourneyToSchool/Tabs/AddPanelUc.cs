using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningGames.JourneyToSchool.Classes;

namespace MachineLearningGames.JourneyToSchool.Tabs
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

        SingletonJTS db = SingletonJTS.GetInstance();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblWarning.Visible = false;

            if (int.TryParse(txtAge.Text, out age) && double.TryParse(txtDistance.Text, out distance) && int.TryParse(txtFriends.Text, out friends))
            {
                if (age > 0)
                {
                    db.Journeys.LastOrDefault().Age = age;
                    db.Journeys.LastOrDefault().Friends = friends;
                    db.Journeys.LastOrDefault().Distance = distance;

                    JourneyToSchoolUC add = new JourneyToSchoolUC();
                    panel1.Controls.Clear();
                    panel1.Controls.Add(add);
                }
                else
                    db.Journeys.RemoveAt(db.Journeys.Count - 1);
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
