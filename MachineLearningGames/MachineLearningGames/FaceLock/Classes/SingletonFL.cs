using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningGames.FaceLock.Classes
{
    class SingletonFL
    {
        private static SingletonFL instance;


        public bool upload = false;

        private SingletonFL()
        {

        }

        public static SingletonFL Instance()
        {
            if (instance == null)
                instance = new SingletonFL();

            return instance;
        }
    }
}
