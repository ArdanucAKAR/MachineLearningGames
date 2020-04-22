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
    public partial class Games : UserControl
    {
        public Games()
        {
            InitializeComponent();
        }

        public Form main;

        private void btnSnap_Click(object sender, EventArgs e)
        {
            Snap snap = new Snap();
            snap.main = main;
            pnlMain.Controls.Clear();
            snap.Visible = false;
            pnlMain.Controls.Add(snap);
            transitionGames.ShowSync(snap);
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            ChatbotMainForm cb= new ChatbotMainForm();
            cb.Show();
            this.Hide();
        }
    }
}
