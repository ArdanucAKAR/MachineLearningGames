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

namespace MachineLearningGames.MakeMeHappy.Tabs
{
    public partial class Train : UserControl
    {
        Singleton db = Singleton.GetInstance();

        public Train()
        {
            InitializeComponent();
        }

        private void AddDictionaryWord(string sentence, int score, ListBox list, TextBox textBox)
        {
            if (sentence != string.Empty && sentence.Length < 120)
            {
                string clearText = db.MakeMeHappy.PreparePhrase(sentence);
                string[] words = clearText.Split(' ');

                //Pozitif kelime eklediği zaman çağrılıcak kod bloğu
                foreach (string word in words)
                {
                    try
                    {
                        db.MakeMeHappy.WordsDic.Add(word, 0);
                    }
                    catch
                    {
                        Console.WriteLine("Aynı kelime Poz {0}", word);
                    }
                    db.MakeMeHappy.WordsDic[word] += score;
                }
                list.Items.Add(sentence);
                textBox.Clear();
            }
        }

        private void btnPositiveWord_Click(object sender, EventArgs e)
        {
            AddDictionaryWord(txtPositiveWord.Text, 1, lbPositiveWords, txtPositiveWord);
        }

        private void txtPositiveWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddDictionaryWord(txtPositiveWord.Text, 1, lbPositiveWords, txtPositiveWord);
        }

        private void btnNegativeWord_Click(object sender, EventArgs e)
        {
            AddDictionaryWord(txtNegativeWord.Text, -1, lbNegativeWords, txtNegativeWord);
        }

        private void txtNegativeWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddDictionaryWord(txtNegativeWord.Text, -1, lbNegativeWords, txtNegativeWord);
        }

        private void Train_Load(object sender, EventArgs e)
        {
            txtPositiveWord.Focus();
        }

        private void txtPositiveWord_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPositiveWord.Clear();
        }

        private void txtNegativeWord_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtNegativeWord.Clear();
        }

        private void btnRemoveWords_Click(object sender, EventArgs e)
        {
            lbPositiveWords.Items.Clear();
            lbNegativeWords.Items.Clear();
            db.MakeMeHappy.WordsDic.Clear();
        }
    }
}
