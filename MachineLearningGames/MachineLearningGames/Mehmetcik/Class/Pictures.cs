using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningGames.Mehmetcik.Class
{
    class Pictures
    {
        private static Pictures singleInstance;
        public string genre = "";
        public int larry = 0;
        public int notLarry = 0;
        
        private Pictures()
        {

        }
        public static Pictures SingleInstance()
        {
            if (singleInstance == null)
            {
                singleInstance = new Pictures();
            }
            return singleInstance;

        }
    }
}
