using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningGames.JudgeBook;
using MachineLearningGames.Chatbot;
using MachineLearningGames.RockPaperScissors;
using MachineLearningGames.LocateLarry;
using MachineLearningGames.Main;
using MachineLearningGames.Main.Classes;

namespace MachineLearningGames
{
    public partial class Games : UserControl
    {
        public Form master;
        private Panel pnlMaster;
        private GameMain gameMain;

        void OpenGame(_Game _game)
        {
            gameMain = new GameMain();
            gameMain.master = master;
            gameMain._game = new _Game();
            gameMain._game.Game = _game.Game;
            gameMain._game.Name = _game.Name;
            gameMain._game.Description = _game.Description;
            gameMain._game.Image = _game.Image;
            gameMain.Visible = false;
            pnlMaster.Controls.Clear();
            pnlMaster.Controls.Add(gameMain);
            transitionGames.ShowSync(gameMain);
        }

        public Games()
        {
            InitializeComponent();
        }

        private void Games_Load(object sender, EventArgs e)
        {
            pnlMaster = master.Controls.Find("pnlMain", true).FirstOrDefault() as Panel;
        }

        private void btnSnap_Click(object sender, EventArgs e)
        {
            OpenGame(new _Game()
            {
                Game = Game.Snap,
                Name = "SNAP",
                Description = "Bu oyunda eğitim aşamasında farklı tiplerde oyun kartlarına yükleyeceğiniz resimleri eğiterek\n    test aşamasında yükleyeceğiniz resmin hangi oyun kartına ait olduğunu öğrenebilirsiniz.",
                Image = Properties.Resources.snapLogo
            });
        }

        private void btnJudgeBook_Click(object sender, EventArgs e)
        {
            OpenGame(new _Game()
            {
                Game = Game.JudgeBook,
                Name = "JUDGE BOOK",
                Description = "Bu oyun sayesinde kitapları kapaklarına göre yargılamanın mümkün olup olmadığını öğreneceksiniz.\n       Her bir kitap türü için kitap kapağı fotoğraflarını ekleyerek model eğitilir. Sonra da test edilir.",
                Image = Properties.Resources.judgebookLogo
            });
        }

        private void btnSchoolLibrary_Click(object sender, EventArgs e)
        {
            OpenGame(new _Game()
            {
                Game = Game.SchoolLibrary,
                Name = "SCHOOL LIBRARY",
                Description = "Sayfa, satır ve resim sayısına göre bir kitabın seviyesini tahmin eden bir uygulama.",
                Image = Properties.Resources.schoollibraryLogo
            });
        }

        private void btnChatbot_Click(object sender, EventArgs e)
        {
            OpenGame(new _Game()
            {
                Game = Game.ChatBot,
                Name = "CHATBOT",
                Description = "Aslanla ilgili bildigimiz şeyleri girip modeli eğitip daha sonrasinda aslanla konusabildigimiz bir oyun.",
                Image = Properties.Resources.chatbotLogo
            });
        }

        private void btnJourneyToSchool_Click(object sender, EventArgs e)
        {
            OpenGame(new _Game()
            {
                Game = Game.JourneyToSchool,
                Name = "JOURNEY TO SCHOOL",
                Description = "Bu oyunda belirli verileri girdikten sonra okula hangi araçla gidiceğiniz tahmin edilir.",
                Image = Properties.Resources.journeytoschoolLogo
            });
        }

        private void btnTitanicGame_Click(object sender, EventArgs e)
        {
            OpenGame(new _Game()
            {
                Game = Game.Titanic,
                Name = "TITANIC",
                Description = "Bu oyunda Titanic gemisinde yolculuk yapan yolcuların geminin batması sonucu hayatta kalıp kalmadığını öğrenebilirisiniz.\n                                  Bunun için yolcuların bazı bilgileriniz girmeniz yeterlidir.Daha sonra test edebilirsiniz.",
                Image = Properties.Resources.titanicLogo
            });
        }

        private void btnMakeMeHappy_Click(object sender, EventArgs e)
        {
            OpenGame(new _Game()
            {
                Game = Game.MakeMeHappy,
                Name = "MAKE ME HAPPY",
                Description = "                                  Olumlu ve olumsuz cümleler ile modeli eğitip\ndaha sonra bir cümlenin olumlu veya olumsuz olduğunun tahminini yapan bir oyun.",
                Image = Properties.Resources.makemehappyLogo
            });
        }

        private void btnRockPaperScissors_Click(object sender, EventArgs e)
        {
            OpenGame(new _Game()
            {
                Game = Game.RockPaperScissors,
                Name = "ROCK PAPER SCISSORS",
                Description = "",
                Image = Properties.Resources.rockpaperscissorsLogo
            });
        }

        private void btnFaceLock_Click(object sender, EventArgs e)
        {
            OpenGame(new _Game()
            {
                Game = Game.FaceLock,
                Name = "FACE LOCK",
                Description = "Bu oyunda eğtim aşamasında yükleyeceğiniz geçerli ve geçersiz yüz resimleri eğiterek\ntest aşamasında yükleyeceğiniz resmin geçerli mi geçersiz mi olduğu ayırt edebilirsiniz",
                Image = Properties.Resources.facelockLogo
            });
        }

        private void btnLocateLarry_Click(object sender, EventArgs e)
        {
            OpenGame(new _Game()
            {
                Game = Game.LocateLarry,
                Name = "LOCATE LARRY",
                Description = "Oyun tanıttığımız Larry ve arkadaşları arasından Larry'i tahmin etmemize olanak sağlayan bir uygulama.",
                Image = Properties.Resources.locatelarryLogo
            });
        }
    }
}