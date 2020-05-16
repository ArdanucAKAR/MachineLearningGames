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
using MachineLearningGames.Main.Classes;

namespace MachineLearningGames.JourneyToSchool.Tabs
{
    public partial class Train : UserControl
    {
        Singleton db = Singleton.GetInstance();

        public Train()
        {
            InitializeComponent();

            if (db.JourneyToSchool.Journeys.Count > 0)
            {
                for (int i = 0; i < db.JourneyToSchool.Journeys.Count; i++)
                {
                    WayToArrive wayToArrive = new WayToArrive();

                    if (db.JourneyToSchool.Journeys[i].JouneyType == 1)
                    {
                        wayToArrive.setAge(db.JourneyToSchool.Journeys[i].Age.ToString());
                        wayToArrive.setDistance(db.JourneyToSchool.Journeys[i].Distance.ToString());
                        wayToArrive.setFriends(db.JourneyToSchool.Journeys[i].Friends.ToString());
                        flowLayoutPanel1.Controls.Add(wayToArrive);
                    }
                    else if (db.JourneyToSchool.Journeys[i].JouneyType == 2)
                    {
                        wayToArrive.setAge(db.JourneyToSchool.Journeys[i].Age.ToString());
                        wayToArrive.setDistance(db.JourneyToSchool.Journeys[i].Distance.ToString());
                        wayToArrive.setFriends(db.JourneyToSchool.Journeys[i].Friends.ToString());
                        flowLayoutPanel2.Controls.Add(wayToArrive);
                    }
                    else if (db.JourneyToSchool.Journeys[i].JouneyType == 3)
                    {
                        wayToArrive.setAge(db.JourneyToSchool.Journeys[i].Age.ToString());
                        wayToArrive.setDistance(db.JourneyToSchool.Journeys[i].Distance.ToString());
                        wayToArrive.setFriends(db.JourneyToSchool.Journeys[i].Friends.ToString());
                        flowLayoutPanel3.Controls.Add(wayToArrive);
                    }
                }
            }
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            Journey jn = new Journey();
            jn.JouneyType = 1;
            db.JourneyToSchool.Journeys.Add(jn);

            AddPanelUc add = new AddPanelUc();
            panel1.Controls.Clear();
            panel1.Controls.Add(add);
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            Journey jn = new Journey();
            jn.JouneyType = 2;
            db.JourneyToSchool.Journeys.Add(jn);

            AddPanelUc add = new AddPanelUc();
            panel1.Controls.Clear();
            panel1.Controls.Add(add);
        }

        private void btnCycle_Click(object sender, EventArgs e)
        {
            Journey jn = new Journey();
            jn.JouneyType = 3;
            db.JourneyToSchool.Journeys.Add(jn);

            AddPanelUc add = new AddPanelUc();
            panel1.Controls.Clear();
            panel1.Controls.Add(add);
        }
    }
}
