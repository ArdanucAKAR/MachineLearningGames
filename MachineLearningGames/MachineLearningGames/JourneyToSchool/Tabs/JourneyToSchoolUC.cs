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
    public partial class JourneyToSchoolUC : UserControl
    {
        SingletonJTS singleton = SingletonJTS.GetInstance();

        public JourneyToSchoolUC()
        {
            InitializeComponent();

            if (singleton.Journeys.Count > 0)
            {
                for (int i = 0; i < singleton.Journeys.Count; i++)
                {
                    if (singleton.Journeys[i].JouneyType == 1)
                    {
                        WayToArrive wayToArrive = new WayToArrive();

                        wayToArrive.setAge(singleton.Journeys[i].Age.ToString());
                        wayToArrive.setDistance(singleton.Journeys[i].Distance.ToString());
                        wayToArrive.setFriends(singleton.Journeys[i].Friends.ToString());
                        flowLayoutPanel1.Controls.Add(wayToArrive);
                    }
                    else if (singleton.Journeys[i].JouneyType == 2)
                    {
                        WayToArrive wayToArrive = new WayToArrive();

                        wayToArrive.setAge(singleton.Journeys[i].Age.ToString());
                        wayToArrive.setDistance(singleton.Journeys[i].Distance.ToString());
                        wayToArrive.setFriends(singleton.Journeys[i].Friends.ToString());
                        flowLayoutPanel2.Controls.Add(wayToArrive);
                    }
                    else if (singleton.Journeys[i].JouneyType == 3)
                    {
                        WayToArrive wayToArrive = new WayToArrive();

                        wayToArrive.setAge(singleton.Journeys[i].Age.ToString());
                        wayToArrive.setDistance(singleton.Journeys[i].Distance.ToString());
                        wayToArrive.setFriends(singleton.Journeys[i].Friends.ToString());
                        flowLayoutPanel3.Controls.Add(wayToArrive);
                    }
                }
            }
        }

        private void btnWalk_Click_1(object sender, EventArgs e)
        {
            Journey jn = new Journey();
            jn.JouneyType = 1;
            singleton.Journeys.Add(jn);

            AddPanelUc add = new AddPanelUc();
            panel1.Controls.Clear();
            panel1.Controls.Add(add);
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            Journey jn = new Journey();
            jn.JouneyType = 2;
            singleton.Journeys.Add(jn);

            AddPanelUc add = new AddPanelUc();
            panel1.Controls.Clear();
            panel1.Controls.Add(add);
        }

        private void btnCycle_Click(object sender, EventArgs e)
        {
            Journey jn = new Journey();
            jn.JouneyType = 3;
            singleton.Journeys.Add(jn);

            AddPanelUc add = new AddPanelUc();
            panel1.Controls.Clear();
            panel1.Controls.Add(add);
        }
    }
}
