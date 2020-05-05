using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningGames.MakeMeHappy.Classes
{
    public class Singleton
    {
        public static Singleton nesne;
        public Dictionary<string, int> wordsDic = new Dictionary<string, int>();

        public string PreparePhrase(string phrase)
        {
            string[] unwantedChars = { ".", ",", "!", "ben", "miş", "dım", "muş" };

            string formatted = phrase.ToLower();

            foreach (string chr in unwantedChars)
            {
                formatted.Replace(chr, "");
            }

            return formatted;
        }
        //public Form main = new Main();

        public Singleton()
        {

        }

        public static Singleton Nesne()
        {
            if (nesne == null)
                nesne = new Singleton();

            return nesne;
        }
    }
}
