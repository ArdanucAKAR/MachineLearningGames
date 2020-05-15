using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningGames.JudgeBook.Class
{
    public class SingletonJB
    {
        private static SingletonJB instance;
        public string genre = "";
        public int childrenBook = 0;
        public int romanceBook = 0;
        public int thrillerBook = 0;
        public int scifiBook = 0;

        private SingletonJB()
        {

        }

        public static SingletonJB GetInstance()
        {
            if (instance == null)
                instance = new SingletonJB();

            return instance;
        }
    }
}
