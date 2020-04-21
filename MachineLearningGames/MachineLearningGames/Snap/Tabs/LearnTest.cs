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
    public partial class LearnTest : UserControl
    {
        public LearnTest()
        {
            InitializeComponent();
        }
        #region Methods
        private void ProgressTextChangeAndNewLocation(string text)
        {
            lblProgress.Text = text;
            lblProgress.Location = new Point((pnlLearnTest.Width - lblProgress.Width) / 2, 455);
        }
        #endregion

        Singleton db = Singleton.Nesne();
        Random random = new Random();

        private void btnLearnTest_Click(object sender, EventArgs e)
        {
            if (db.club == 0 && db.diamond == 0 && db.heart == 0 && db.spade == 0)
                ProgressTextChangeAndNewLocation("Lütfen Resim Yükleyin");
            else if (db.club == 0)
                ProgressTextChangeAndNewLocation("Lütfen Sinek Kartına Örnek Resim Yükleyin");
            else if (db.diamond == 0)
                ProgressTextChangeAndNewLocation("Lütfen Karo Kartına Örnek Resim Yükleyin");
            else if (db.heart == 0)
                ProgressTextChangeAndNewLocation("Lütfen Kalp Kartına Örnek Resim Yükleyin");
            else if (db.spade == 0)
                ProgressTextChangeAndNewLocation("Lütfen Maça Kartına Örnek Resim Yükleyin");
            else
            {
                btnProgressAnimation.Hide(btnLearnTest);
                btnProgressAnimation.ShowSync(prgssbLearnTest);
                db.club = 0;
                db.diamond = 0;
                db.heart = 0;
                db.spade = 0;
                tmrLearnTest.Start();
            }
        }

        private void LearnTest_Load(object sender, EventArgs e)
        {
            lblClubsCount.Text = db.club.ToString();
            lblDiamondsCount.Text = db.diamond.ToString();
            lblHeartsCount.Text = db.heart.ToString();
            lblSpadesCount.Text = db.spade.ToString();
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
                ProgressTextChangeAndNewLocation("Tamamlandı\nDiğer Aşamaya Geçebilirsiniz");
                tmrLearnTest.Stop();
            }
        }
    }
}
