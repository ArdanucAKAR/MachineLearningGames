using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningGames.LocateLarry.Class
{
    public class SingletonLL
    {
        private static SingletonLL instance;

        public string tahmin = "";
        public string tahminLarry = "Evet bu larry";
        public string tahminotLarry = "Hayır bu larry değil";
        public int larry = 0;
        public int lady = 0;
        public int lily = 0;
        public int kings = 0;
        public int golden = 0;

        private SingletonLL()
        {

        }

        public static SingletonLL GetInstance()
        {
            if (instance == null)
                instance = new SingletonLL();

            return instance;
        }
    }
}
