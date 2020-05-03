using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningGames.Alihan.Entity;
using MachineLearningGames.Alihan.Utilities;
using MachineLearningGames.Alihan.Validation.FluentValidation;

namespace MachineLearningGames.Alihan.Tabs
{
    public partial class TitanicTrain : UserControl
    {
        public TitanicTrain()
        {
            InitializeComponent();
        }

        public Form main;
        private int _itemSurvivedCount = 0;
        private int _itemNotSurvivedCount = 0;

        private void btnStartTrain_Click(object sender, EventArgs e)
        {
            if (_itemSurvivedCount < 1)
                MessageBox.Show(
                    "Girmiş olduğunuz hayatta kalan veri sayısı yeterli değil!\nLütfen faha fazla veri giriniz");
            else if (_itemNotSurvivedCount < 1)
                MessageBox.Show(
                    "Girmiş olduğunuz hayatta kalamayan veri sayısı yeterli değil!\nLütfen faha fazla veri giriniz");
            else
            {
                pnlList.Visible = false;
                btnAdd.Visible = false;
                btnStartTrain.Visible = false;
                lblItemCount.Visible = false;
                lblDataCount.Visible = false;
                lblSurvived.Visible = false;
                lblNotSurvived.Visible = false;

                timer1.Start();
                lblModeTraining.Visible = true;
                pictureBox2.Visible = true;


            }

        }

        private int _progresscounter = 0;
        private int ProgressBarIncreasing()
        {
            Random random = new Random();

            if (_progresscounter < 80)
            {
                _progresscounter += random.Next(1, 20);
            }
            else
            {
                _progresscounter += 99 - _progresscounter;
            }
            Thread.Sleep(random.Next(1000, 5000));
            return _progresscounter;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer
                {
                    Age = Convert.ToInt32(txtAge.text),
                    Embarked = drpEmbarked.selectedValue,
                    Gender = drpGender.selectedValue,
                    ParentOrChildren = Convert.ToInt32(txtParentOrChildren.text),
                    SiblingsOrSpouse = Convert.ToInt32(txtSiblingsOrSpouse.text),
                    TicketClass = Convert.ToInt32(drpTicketClass.selectedValue),
                    TicketFare = Convert.ToInt32(txtTickerFare.text)
                };
                ValidationTool.Validate(new DataValidator(), customer);
                if (drpState.selectedIndex == 0)
                {
                    itemListSurvived.Items.Add("Bilet Sınıfı : " + drpTicketClass.selectedValue +
                                  "  Cinsiyet : " + drpGender.selectedValue +
                                  "  Yaş : " + txtAge.text +
                                  "  Kardeş ya da eş sayısı : " + txtSiblingsOrSpouse.text +
                                  "  Ebeveyn ya da çocuk sayısı : " + txtParentOrChildren.text +
                                  "  Bilet ücreti : " + txtTickerFare.text +
                                  "  Gideceğiniz yer : " + drpEmbarked.selectedValue);
                    itemListSurvived.Items.Add(
                        "-------------------------------------------------------------------------------------------------------------------------");
                    _itemSurvivedCount++;
                    lblItemCount.Text = (_itemSurvivedCount + _itemNotSurvivedCount).ToString();
                }
                else
                {
                    itemListNotSurvived.Items.Add("Bilet Sınıfı : " + drpTicketClass.selectedValue +
                                               "  Cinsiyet : " + drpGender.selectedValue +
                                               "  Yaş : " + txtAge.text +
                                               "  Kardeş ya da eş sayısı : " + txtSiblingsOrSpouse.text +
                                               "  Ebeveyn ya da çocuk sayısı : " + txtParentOrChildren.text +
                                               "  Bilet ücreti : " + txtTickerFare.text +
                                               "  Gideceğiniz yer : " + drpEmbarked.selectedValue);
                    itemListNotSurvived.Items.Add(
                        "-------------------------------------------------------------------------------------------------------------------------");
                    _itemNotSurvivedCount++;
                    lblItemCount.Text = (_itemSurvivedCount + _itemNotSurvivedCount).ToString();
                }



            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            DataClear();
        }

        private void DataClear()
        {
            txtAge.text = "0";
            txtTickerFare.text = "0";
            txtParentOrChildren.text = "0";
            txtSiblingsOrSpouse.text = "0";
            drpState.selectedIndex = 0;
            drpTicketClass.selectedIndex = 0;
            drpEmbarked.selectedIndex = 0;
            drpGender.selectedIndex = 0;
        }

        private int _counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            _counter++;
            if (_counter == 5)
            {
                pictureBox2.Visible = false;
                MessageBox.Show("Eğitim Tamamlandı!\nArtık Test Edebilirisiniz.");
                lblModeTraining.Text = "Eğitim Tamamlandı!";
                Titanic titanic = new Titanic();
                titanic.main = main;
                pnlMain.Controls.Clear();
                titanic.Visible = false;
                pnlMain.Controls.Add(titanic);
                bunifuTransition1.ShowSync(titanic);
            }
        }
    }
}
