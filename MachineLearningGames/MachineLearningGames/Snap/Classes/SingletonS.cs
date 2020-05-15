using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningGames.Snap.Classes
{
    public class SingletonS
    {
        private static SingletonS instance;

        public int spade = 0,
                   diamond = 0,
                   heart = 0,
                   club = 0;

        public bool upload = false;

        public SingletonS()
        {

        }

        public static SingletonS GetInstance()
        {
            if (instance == null)
                instance = new SingletonS();

            return instance;
        }
    }
}
