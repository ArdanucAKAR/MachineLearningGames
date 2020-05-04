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
    public partial class GamePanel : UserControl
    {
        public Form main;
        public GamePanel()
        {
            InitializeComponent();
            UlasSingleton singleton = UlasSingleton.Instance;
            if (singleton.Journeys.Count > 0)
            {
                for (int i = 0; i < singleton.Journeys.Count; i++)
                {
                    if (singleton.Journeys[i].JouneyType==1)
                    {

                        WayToArrive wayToArrive = new WayToArrive();

                        wayToArrive.setAge(singleton.Journeys[i].Age.ToString());
                        wayToArrive.setDistance(singleton.Journeys[i].Distance.ToString());
                        wayToArrive.setFriends(singleton.Journeys[i].Friends.ToString());
                        flowLayoutPanel1.Controls.Add(wayToArrive);
                    }
                    if (singleton.Journeys[i].JouneyType == 2)
                    {

                        WayToArrive wayToArrive = new WayToArrive();

                        wayToArrive.setAge(singleton.Journeys[i].Age.ToString());
                        wayToArrive.setDistance(singleton.Journeys[i].Distance.ToString());
                        wayToArrive.setFriends(singleton.Journeys[i].Friends.ToString());
                        flowLayoutPanel2.Controls.Add(wayToArrive);
                    }
                    if (singleton.Journeys[i].JouneyType == 3)
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

        private void btnAddWalk_Click(object sender, EventArgs e)
        {
           

        }
    }
}
