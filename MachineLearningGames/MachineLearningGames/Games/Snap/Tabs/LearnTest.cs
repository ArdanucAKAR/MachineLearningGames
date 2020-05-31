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

namespace MachineLearningGames.Snap.Tabs
{
    public partial class LearnTest : UserControl
    {
        Singleton db = Singleton.GetInstance();

        Random random = new Random();

        public LearnTest()
        {
            InitializeComponent();
        }

        #region Methods
        private void ProgressTextChangeAndNewLocation(string text)
        {
            lblProgress.Text = text;
            lblProgress.Location = new Point((pnlLearnTest.Width - lblProgress.Width) / 2, 500);
        }
        #endregion

        private void btnLearnTest_Click(object sender, EventArgs e)
        {
            if (db.Snap.Club == 0 && db.Snap.Diamond == 0 && db.Snap.Heart == 0 && db.Snap.Spade == 0)
                ProgressTextChangeAndNewLocation("Lütfen Resim Yükleyin");
            else if (db.Snap.Club == 0)
                ProgressTextChangeAndNewLocation("Lütfen Sinek Kartına Örnek Resim Yükleyin");
            else if (db.Snap.Diamond == 0)
                ProgressTextChangeAndNewLocation("Lütfen Karo Kartına Örnek Resim Yükleyin");
            else if (db.Snap.Heart == 0)
                ProgressTextChangeAndNewLocation("Lütfen Kalp Kartına Örnek Resim Yükleyin");
            else if (db.Snap.Spade == 0)
                ProgressTextChangeAndNewLocation("Lütfen Maça Kartına Örnek Resim Yükleyin");
            else
            {
                btnProgressAnimation.Hide(btnLearnTest);
                btnProgressAnimation.ShowSync(prgssbLearnTest);
                db.Snap.Club = 0;
                db.Snap.Diamond = 0;
                db.Snap.Heart = 0;
                db.Snap.Spade = 0;
                tmrLearnTest.Start();
            }
        }

        private void LearnTest_Load(object sender, EventArgs e)
        {
            lblClubsCount.Text = db.Snap.Club.ToString();
            lblDiamondsCount.Text = db.Snap.Diamond.ToString();
            lblHeartsCount.Text = db.Snap.Heart.ToString();
            lblSpadesCount.Text = db.Snap.Spade.ToString();
        }

        private void tmrLearnTest_Tick(object sender, EventArgs e)
        {
            prgssbLearnTest.Value += random.Next(1, 15);

            if (prgssbLearnTest.Value >= 0 && prgssbLearnTest.Value <= 20)
                ProgressTextChangeAndNewLocation("Resimler Yükleniyor");
            else if (prgssbLearnTest.Value > 20 && prgssbLearnTest.Value <= 40)
                ProgressTextChangeAndNewLocation("Resimler İşleniyor");
            else if (prgssbLearnTest.Value > 40 && prgssbLearnTest.Value <= 60)
                ProgressTextChangeAndNewLocation("Nesnelere Ayrıştırılıyor");
            else if (prgssbLearnTest.Value > 60 && prgssbLearnTest.Value <= 80)
                ProgressTextChangeAndNewLocation("Nesneler Tanımlanıyor");
            else if (prgssbLearnTest.Value >= 90)
            {
                prgssbLearnTest.Value += (100 - prgssbLearnTest.Value);
                db.Snap.Upload = true;
                ProgressTextChangeAndNewLocation("Tamamlandı\nTest Aşamasına Geçebilirsiniz");
                tmrLearnTest.Stop();
            }
        }
    }
}
