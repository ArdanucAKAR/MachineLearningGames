using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningGames
{
    public partial class Snap : Form
    {
        public Snap()
        {
            InitializeComponent();
        }
        #region Methods
        private UserControl activeUserControl = null;
        private void OpenUserControl(UserControl uc)
        {
            if (activeUserControl != null)
                bnfTabAnimation.HideSync(activeUserControl);
            activeUserControl = uc;
            pnlMain.Controls.Clear();
            pnlMain.Visible = false;
            pnlMain.Controls.Add(uc);
            bnfTabAnimation.ShowSync(pnlMain);
        }
        private void SideClose()
        {
            bnfLogoAnimation.Hide(pbLogo);
            pnlSide.Visible = false;
            pnlSide.Width = 75;
            bnfSideAnimation.ShowSync(pnlSide);
        }
        private void GoToMain()
        {
            UserControl ucHome = new Home();
            if (!(activeUserControl is Home))
                OpenUserControl(ucHome);
            btnTrain.BackColor = Color.Black;
            btnLearnTest.BackColor = Color.Black;
            btnMake.BackColor = Color.Black;
            SideClose();
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Main main = new Main();            
            this.Close();
            main.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlSide.Width == 75)
            {
                pnlSide.Visible = false;
                pnlSide.Width = 300;
                bnfSideAnimation.ShowSync(pnlSide);
                bnfLogoAnimation.ShowSync(pbLogo);
            }
            else
                SideClose();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            if (pnlSide.Width == 300)
                SideClose();
            UserControl ucTrain = new Train();
            if (!(activeUserControl is Train))
                OpenUserControl(ucTrain);
        }

        private void btnLearnTest_Click(object sender, EventArgs e)
        {
            if (pnlSide.Width == 300)
                SideClose();
            UserControl ucLearnTest = new LearnTest();
            if (!(activeUserControl is LearnTest))
                OpenUserControl(ucLearnTest);
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            if (pnlSide.Width == 300)
                SideClose();
            UserControl ucMake = new Make();
            if (!(activeUserControl is Make))
                OpenUserControl(ucMake);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Singleton db = Singleton.Nesne();
            UserControl ucHome = new Home();
            OpenUserControl(ucHome);
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            GoToMain();
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            GoToMain();
        }
    }
}
