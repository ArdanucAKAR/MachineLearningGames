using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningGames.Chatbot.Classes
{
    public class SingletonCB
    {
        private static SingletonCB instance = null;
        public List<String> answers;

        private SingletonCB()
        {
            answers = new List<String>();
        }

        public static SingletonCB GetInstance()
        {
            if (instance == null)
                instance = new SingletonCB();

            return instance;
        }
    }
}

