using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningGames.RockPaperScissors.Classes
{
    public class SingletonRPC
    {
        private static SingletonRPC instance;

        public bool upload = false;

        private SingletonRPC()
        {

        }

        public static SingletonRPC GetInstance()
        {
            if (instance == null)
                instance = new SingletonRPC();

            return instance;
        }
    }
}
