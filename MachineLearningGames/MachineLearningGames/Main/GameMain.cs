using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MachineLearningGames.Main.Classes;

namespace MachineLearningGames.Main
{
    public partial class GameMain : UserControl
    {
        Singleton db = Singleton.GetInstance();

        public Form master;
        private Panel pnlMaster;
        private Panel pnlTop;
        public UserControl current;
        public _Game _game;

        void ButtonAnimation(BunifuTileButton train, string trainText, Color trainColor, BunifuTileButton test, string testText, Color testColor)
        {
            train.color = trainColor;
            train.LabelText = trainText;
            test.color = testColor;
            test.LabelText = testText;
        }

        bool CheckTab(Game game, Tab tab)
        {
            if (tab == Tab.Train)
            {
                if (game == Game.ChatBot)
                {
                    if (current is Chatbot.Tabs.Train)
                        return true;
                }
                else if (game == Game.FaceLock)
                {
                    if (current is FaceLock.Tabs.Train)
                        return true;
                }
                else if (game == Game.JourneyToSchool)
                {
                    if (current is JourneyToSchool.Tabs.Train)
                        return true;
                }
                else if (game == Game.JudgeBook)
                {
                    if (current is JudgeBook.Tabs.Train)
                        return true;
                }
                else if (game == Game.LocateLarry)
                {
                    if (current is LocateLarry.Tabs.Train)
                        return true;
                }
                else if (game == Game.MakeMeHappy)
                {
                    if (current is MakeMeHappy.Tabs.Train)
                        return true;
                }
                else if (game == Game.RockPaperScissors)
                {
                    if (current is RockPaperScissors.Tabs.Train)
                        return true;
                }
                else if (game == Game.SchoolLibrary)
                {
                    if (current is SchoolLibrary.Tabs.Train)
                        return true;
                }
                else if (game == Game.Snap)
                {
                    if (current is Snap.Tabs.Train)
                        return true;
                }
                else if (game == Game.Titanic)
                {
                    if (current is Titanic.Tabs.Train)
                        return true;
                }
            }
            else if (tab == Tab.Test)
            {
                if (game == Game.ChatBot)
                {
                    if (current is Chatbot.Tabs.Test)
                        return true;
                }
                else if (game == Game.FaceLock)
                {
                    if (current is FaceLock.Tabs.Test)
                        return true;
                }
                else if (game == Game.JourneyToSchool)
                {
                    if (current is JourneyToSchool.Tabs.Test)
                        return true;
                }
                else if (game == Game.JudgeBook)
                {
                    if (current is JudgeBook.Tabs.Test)
                        return true;
                }
                else if (game == Game.LocateLarry)
                {
                    if (current is LocateLarry.Tabs.Test)
                        return true;
                }
                else if (game == Game.MakeMeHappy)
                {
                    if (current is MakeMeHappy.Tabs.Test)
                        return true;
                }
                else if (game == Game.RockPaperScissors)
                {
                    if (current is RockPaperScissors.Tabs.Test)
                        return true;
                }
                else if (game == Game.SchoolLibrary)
                {
                    if (current is SchoolLibrary.Tabs.Test)
                        return true;
                }
                else if (game == Game.Snap)
                {
                    if (current is Snap.Tabs.Test)
                        return true;
                }
                else if (game == Game.Titanic)
                {
                    if (current is Titanic.Tabs.Test)
                        return true;
                }
            }

            return false;
        }

        void OpenTabs(Tab willBeOpenedTab)
        {
            if (!CheckTab(_game.Game, willBeOpenedTab))
            {
                UserControl tab = null;

                if (_game.Game == Game.ChatBot)
                {
                    if (willBeOpenedTab == Tab.Train)
                        tab = new Chatbot.Tabs.Train();
                    else if (willBeOpenedTab == Tab.Test)
                        tab = new Chatbot.Tabs.Test();
                }
                else if (_game.Game == Game.FaceLock)
                {
                    if (willBeOpenedTab == Tab.Train)
                        tab = new FaceLock.Tabs.Train();
                    else if (willBeOpenedTab == Tab.Test)
                        tab = new FaceLock.Tabs.Test();
                }
                else if (_game.Game == Game.JourneyToSchool)
                {
                    if (willBeOpenedTab == Tab.Train)
                        tab = new JourneyToSchool.Tabs.Train();
                    else if (willBeOpenedTab == Tab.Test)
                        tab = new JourneyToSchool.Tabs.Test();
                }
                else if (_game.Game == Game.JudgeBook)
                {
                    if (willBeOpenedTab == Tab.Train)
                        tab = new JudgeBook.Tabs.Train();
                    else if (willBeOpenedTab == Tab.Test)
                        tab = new JudgeBook.Tabs.Test();
                }
                else if (_game.Game == Game.LocateLarry)
                {
                    if (willBeOpenedTab == Tab.Train)
                        tab = new LocateLarry.Tabs.Train();
                    else if (willBeOpenedTab == Tab.Test)
                        tab = new LocateLarry.Tabs.Test();
                }
                else if (_game.Game == Game.MakeMeHappy)
                {
                    if (willBeOpenedTab == Tab.Train)
                        tab = new MakeMeHappy.Tabs.Train();
                    else if (willBeOpenedTab == Tab.Test)
                        tab = new MakeMeHappy.Tabs.Test();
                }
                else if (_game.Game == Game.RockPaperScissors)
                {
                    if (willBeOpenedTab == Tab.Train)
                        tab = new RockPaperScissors.Tabs.Train();
                    else if (willBeOpenedTab == Tab.Test)
                        tab = new RockPaperScissors.Tabs.Test();
                }
                else if (_game.Game == Game.SchoolLibrary)
                {
                    if (willBeOpenedTab == Tab.Train)
                        tab = new SchoolLibrary.Tabs.Train();
                    else if (willBeOpenedTab == Tab.Test)
                        tab = new SchoolLibrary.Tabs.Test();
                }
                else if (_game.Game == Game.Snap)
                {
                    if (willBeOpenedTab == Tab.Train)
                        tab = new Snap.Tabs.Train();
                    else if (willBeOpenedTab == Tab.Test)
                        tab = new Snap.Tabs.Test();
                }
                else if (_game.Game == Game.Titanic)
                {
                    if (willBeOpenedTab == Tab.Train)
                        tab = new Titanic.Tabs.Train();
                    else if (willBeOpenedTab == Tab.Test)
                        tab = new Titanic.Tabs.Test();
                }

                if (tab != null)
                {
                    pnlMain.Controls.Clear();
                    pnlMain.Visible = false;
                    pnlMain.Controls.Add(tab);
                    transitionTabs.ShowSync(pnlMain);
                    current = tab;
                }
            }
        }

        public GameMain()
        {
            InitializeComponent();
        }

        #region Home Butonu
        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            btnHome.LabelText = "Anasayfa";
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.LabelText = "";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlMaster = master.Controls.Find("pnlMain", true).FirstOrDefault() as Panel;
            pnlTop = master.Controls.Find("pnlTop", true).FirstOrDefault() as Panel;
            BunifuCustomLabel label = master.Controls.Find("lblHeader", true).FirstOrDefault() as BunifuCustomLabel;
            label.Text = "Çocuklar İçin Makine Öğrenmesi";
            label.Location = new Point((pnlTop.Width - label.Width) / 2, 12);
            pnlMaster.Controls.Clear();
            Games games = new Games();
            games.master = master;
            pnlMaster.Controls.Add(games);
        }
        #endregion

        #region Train Butonu
        private void btnTrain_MouseHover(object sender, EventArgs e)
        {
            btnTrain.LabelText = "Eğitme";
        }

        private void btnTrain_MouseLeave(object sender, EventArgs e)
        {
            if (!CheckTab(_game.Game, Tab.Train))
                btnTrain.LabelText = "";
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            if (_game.Game == Game.JourneyToSchool && db.JourneyToSchool.Journeys.Count > 0 && db.JourneyToSchool.Journeys[db.JourneyToSchool.Journeys.Count - 1].Age <= 0)
                db.JourneyToSchool.Journeys.RemoveAt(db.JourneyToSchool.Journeys.Count - 1);
            OpenTabs(Tab.Train);
            ButtonAnimation(btnTrain, "Eğitme", Color.DarkCyan, btnTest, "", Color.Transparent);
        }
        #endregion

        #region Test Butonu
        private void btnTest_MouseHover(object sender, EventArgs e)
        {
            btnTest.LabelText = "Test";
        }

        private void btnTest_MouseLeave(object sender, EventArgs e)
        {
            if (!CheckTab(_game.Game, Tab.Test))
                btnTest.LabelText = "";
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (_game.Game == Game.ChatBot)
            {
                OpenTabs(Tab.Test);
                ButtonAnimation(btnTrain, "", Color.Transparent, btnTest, "Test", Color.DarkCyan);
            }
            else if (_game.Game == Game.FaceLock)
            {
                if (db.FaceLock.Upload)
                {
                    current = null;
                    OpenTabs(Tab.Test);
                    ButtonAnimation(btnTrain, "", Color.Transparent, btnTest, "Test", Color.DarkCyan);
                }
                else
                {
                    MessageBox.Show("Eğitim için resim yüklemeden test aşamasına geçilemez.");
                    OpenTabs(Tab.Train);
                    ButtonAnimation(btnTrain, "Eğitme", Color.DarkCyan, btnTest, "", Color.Transparent);
                }
            }
            else if (_game.Game == Game.JourneyToSchool)
            {
                if (db.JourneyToSchool.Journeys.Count > 0)
                {
                    current = null;
                    OpenTabs(Tab.Test);
                    ButtonAnimation(btnTrain, "", Color.Transparent, btnTest, "Test", Color.DarkCyan);
                }
                else
                {
                    MessageBox.Show("Model eğitmeden test aşamasına geçilemez");
                    OpenTabs(Tab.Train);
                    ButtonAnimation(btnTrain, "Eğitme", Color.DarkCyan, btnTest, "", Color.Transparent);
                }
            }
            else if (_game.Game == Game.JudgeBook)
            {
                if (db.JudgeBook.ChildrenBook == 0 && db.JudgeBook.RomanceBook == 0 && db.JudgeBook.ThrillerBook == 0 && db.JudgeBook.ScifiBook == 0)
                {
                    MessageBox.Show("Lütfen önce makineyi eğitin", "Önemli", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    OpenTabs(Tab.Train);
                    ButtonAnimation(btnTrain, "Eğitme", Color.DarkCyan, btnTest, "", Color.Transparent);
                }
                else if (db.JudgeBook.ChildrenBook == 0 || db.JudgeBook.RomanceBook == 0 || db.JudgeBook.ThrillerBook == 0 || db.JudgeBook.ScifiBook == 0)
                {
                    MessageBox.Show("Lütfen bütün kitap türlerine resim yükleyin", "Önemli", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    OpenTabs(Tab.Train);
                    ButtonAnimation(btnTrain, "Eğitme", Color.DarkCyan, btnTest, "", Color.Transparent);
                }
                else
                {
                    current = null;
                    OpenTabs(Tab.Test);
                    ButtonAnimation(btnTrain, "", Color.Transparent, btnTest, "Test", Color.DarkCyan);
                }
            }
            else if (_game.Game == Game.LocateLarry)
            {
                if (db.LocateLarry.Larry == 0 && db.LocateLarry.Lily == 0 && db.LocateLarry.Kings == 0 && db.LocateLarry.Lady == 0 && db.LocateLarry.Golden == 0)
                {
                    MessageBox.Show("Lütfen önce güzel hayvanlarımızı tanıtın.", "Önemli", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    OpenTabs(Tab.Train);
                    ButtonAnimation(btnTrain, "Eğitme", Color.DarkCyan, btnTest, "", Color.Transparent);
                }
                else if (db.LocateLarry.Larry == 0 || db.LocateLarry.Lily == 0 || db.LocateLarry.Kings == 0 || db.LocateLarry.Lady == 0 || db.LocateLarry.Golden == 0)
                {
                    MessageBox.Show("Lütfen bütün hayvanlarımıza aynı önemi gösterin", "Önemli", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    OpenTabs(Tab.Train);
                    ButtonAnimation(btnTrain, "Eğitme", Color.DarkCyan, btnTest, "", Color.Transparent);
                }
                else
                {
                    current = null;
                    OpenTabs(Tab.Test);
                    ButtonAnimation(btnTrain, "", Color.Transparent, btnTest, "Test", Color.DarkCyan);
                }
            }
            else if (_game.Game == Game.MakeMeHappy)
            {
                if (db.MakeMeHappy.WordsDic.Count > 10)
                {
                    current = null;
                    OpenTabs(Tab.Test);
                    ButtonAnimation(btnTrain, "", Color.Transparent, btnTest, "Test", Color.DarkCyan);
                }
                else
                {
                    MessageBox.Show("Cümle Girmeden Test Aşamasına Geçilemez");
                    OpenTabs(Tab.Train);
                    ButtonAnimation(btnTrain, "Eğitme", Color.DarkCyan, btnTest, "", Color.Transparent);
                }
            }
            else if (_game.Game == Game.RockPaperScissors)
            {
                if (db.RockPaperScissors.Upload)
                {
                    current = null;
                    OpenTabs(Tab.Test);
                    ButtonAnimation(btnTrain, "", Color.Transparent, btnTest, "Test", Color.DarkCyan);
                }
                else
                {
                    MessageBox.Show("Eğitim için resim yüklemeden test aşamasına geçilemez.");
                    OpenTabs(Tab.Train);
                    ButtonAnimation(btnTrain, "Eğitme", Color.DarkCyan, btnTest, "", Color.Transparent);
                }
            }
            else if (_game.Game == Game.SchoolLibrary)
            {
                if (db.SchoolLibrary.IsTrained)
                {
                    current = null;
                    OpenTabs(Tab.Test);
                    ButtonAnimation(btnTrain, "", Color.Transparent, btnTest, "Test", Color.DarkCyan);
                }
                else
                {
                    MessageBox.Show("Eğitim için resim yüklemeden test aşamasına geçilemez.");
                    OpenTabs(Tab.Train);
                    ButtonAnimation(btnTrain, "Eğitme", Color.DarkCyan, btnTest, "", Color.Transparent);
                }
            }
            else if (_game.Game == Game.Snap)
            {
                if (db.Snap.Upload)
                {
                    current = null;
                    OpenTabs(Tab.Test);
                    ButtonAnimation(btnTrain, "", Color.Transparent, btnTest, "Test", Color.DarkCyan);
                }
                else
                {
                    MessageBox.Show("Eğitim için resim yüklemeden test aşamasına geçilemez.");
                    OpenTabs(Tab.Train);
                    ButtonAnimation(btnTrain, "Eğitme", Color.DarkCyan, btnTest, "", Color.Transparent);
                }
            }
            else if (_game.Game == Game.Titanic)
            {
                if (db.Titanic.State)
                {
                    current = null;
                    OpenTabs(Tab.Test);
                    ButtonAnimation(btnTrain, "", Color.Transparent, btnTest, "Test", Color.DarkCyan);
                }
                else
                {
                    MessageBox.Show("Lütfen önce eğitme işlemini yapınız!");
                    OpenTabs(Tab.Train);
                    ButtonAnimation(btnTrain, "Eğitme", Color.DarkCyan, btnTest, "", Color.Transparent);
                }
            }
        }
        #endregion

        private void GameMain_Load(object sender, EventArgs e)
        {
            pnlMaster = master.Controls.Find("pnlMain", true).FirstOrDefault() as Panel;
            pnlTop = master.Controls.Find("pnlTop", true).FirstOrDefault() as Panel;
            BunifuCustomLabel lblHeader = master.Controls.Find("lblHeader", true).FirstOrDefault() as BunifuCustomLabel;
            lblHeader.Text = _game.Name + " - Çocuklar İçin Makine Öğrenmesi";
            lblHeader.Location = new Point((pnlTop.Width - lblHeader.Width) / 2, 12);
            pbMain.Image = _game.Image;
            pbMain.Location = new Point((pnlMaster.Width - pbMain.Width) / 2, 71);
            lblGameName.Text = _game.Name;
            lblGameName.Location = new Point((pnlMaster.Width - lblGameName.Width) / 2, 400);
            lblGameDescription.Text = _game.Description;
            lblGameDescription.Location = new Point((pnlMaster.Width - lblGameDescription.Width) / 2, 457);
        }
    }
}
