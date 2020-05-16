using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningGames.MakeMeHappy.Classes
{
    public class DBMakeMeHappy
    {
        public Dictionary<string, int> WordsDic = new Dictionary<string, int>();

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
    }
}
