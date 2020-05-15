using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningGames.FaceLock.Classes
{
    public class SingletonFL
    {
        private static SingletonFL instance = null;
        public bool upload = false;

        private SingletonFL()
        {

        }

        public static SingletonFL GetInstance()
        {
            if (instance == null)
                instance = new SingletonFL();

            return instance;
        }
    }
}
