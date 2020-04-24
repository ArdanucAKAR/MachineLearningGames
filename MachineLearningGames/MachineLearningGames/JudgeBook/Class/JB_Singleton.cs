using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningGames.JudgeBook.Class
{
    public class JB_Singleton
    {
        private static JB_Singleton singleInstance;
        public string genre = "";
        private JB_Singleton()
        {

        }
        public static JB_Singleton SingleInstance()
        {
            if (singleInstance == null)
            {
                singleInstance = new JB_Singleton();
            }
            return singleInstance;

        }
    }
}
