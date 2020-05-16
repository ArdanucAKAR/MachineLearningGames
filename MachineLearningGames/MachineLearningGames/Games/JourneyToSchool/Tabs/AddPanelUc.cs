using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningGames.Main.Classes;

namespace MachineLearningGames.JourneyToSchool.Tabs
{
    public partial class AddPanelUc : UserControl
    {
        Singleton db = Singleton.GetInstance();

        public AddPanelUc()
        {
            InitializeComponent();
        }

        private int age = 0;
        private double distance = 0;
        private int friends = 0;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblWarning.Visible = false;

            if (int.TryParse(txtAge.Text, out age) && double.TryParse(txtDistance.Text, out distance) && int.TryParse(txtFriends.Text, out friends))
            {
                if (age > 0)
                {
                    db.JourneyToSchool.Journeys.LastOrDefault().Age = age;
                    db.JourneyToSchool.Journeys.LastOrDefault().Friends = friends;
                    db.JourneyToSchool.Journeys.LastOrDefault().Distance = distance;

                    Train add = new Train();
                    panel1.Controls.Clear();
                    panel1.Controls.Add(add);
                }
                else
                    db.JourneyToSchool.Journeys.RemoveAt(db.JourneyToSchool.Journeys.Count - 1);
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
