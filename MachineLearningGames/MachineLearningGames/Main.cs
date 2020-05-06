using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MachineLearningGames
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public void GoToMain()
        {
            pnlMain.Controls.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            lblHeader.Location = new Point((pnlTop.Width - lblHeader.Width) / 2, 12);
            transitionLogo.ShowSync(pbLogo);
            transtionText.ShowSync(lblText);
            Thread.Sleep(1000);
            transitionLogo.HideSync(pbLogo);
            transtionText.HideSync(lblText);
            Thread.Sleep(500);
            Games games = new Games();
            games.main = this;
            pnlMain.Visible = false;
            pnlMain.Controls.Add(games);
            transitionPages.ShowSync(pnlMain);
        }
    }
}
