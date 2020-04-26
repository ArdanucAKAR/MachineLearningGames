using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningGames
{
    public class Singleton
    {
        public static Singleton nesne;
        public int spade = 0,
                   diamond = 0,
                   heart = 0,
                   club = 0;
        public Form main = new Main();

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
