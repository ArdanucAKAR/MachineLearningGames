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
    public partial class TestUc : UserControl
    {
        public TestUc()
        {
            InitializeComponent();
        }
        
        

        private void btnTry_Click(object sender, EventArgs e)
        {
            int age;
            double distance;
            int friends;

            if (int.TryParse(txtAge.Text, out age) && double.TryParse(txtDistance.Text, out distance) &&
                int.TryParse(txtFriends.Text, out friends)&& !String.IsNullOrEmpty(txtDistance.Text) && !String.IsNullOrEmpty(txtAge.Text) && !String.IsNullOrEmpty(txtFriends.Text))
            {
                lblWarning.Visible = false;
                lblResult.Visible = true;

                Random rnd = new Random();
                int _random = rnd.Next(3);

                if (_random == 0)
                {
                    lblResult.Text = "Araba ile";
                }
                else if (_random == 1)
                {
                    lblResult.Text = "Yürüyerek";
                }
                else
                {
                    lblResult.Text = "Bisikleti ile";
                }
            }
            else
            {
                lblResult.Visible = false;
                lblWarning.Text = "Hatalı giriş yaptınız tekrar sayı giriniz";
                txtFriends.Text = "";
                txtAge.Text = "";
                txtDistance.Text = "";
                lblWarning.Visible = true;

            }



        }
        }
}

