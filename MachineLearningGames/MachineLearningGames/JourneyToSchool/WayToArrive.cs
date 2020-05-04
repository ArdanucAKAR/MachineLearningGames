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
    public partial class WayToArrive : UserControl
    {
        public WayToArrive()
        {
            InitializeComponent();
        }
        public void setAge(string age)
        {
            lblAge.Text ="age :" + age;
        }
        public void setDistance(string distance)
        {
            lblDistance.Text = "distance :" + distance;
        }
        public void setFriends(string friends)
        {
            lblFriends.Text = "friends :" + friends;
        }
    }
}
