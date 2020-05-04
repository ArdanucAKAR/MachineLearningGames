using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningGames.Ayberk
{
    public  class Cevap
    {
        public static Cevap Instance = null;
        public List<String> cevaplar;
        public Cevap()
        {
            
            cevaplar = new List<String>();
        }
       
        public static Cevap GetCevap()
        {
            if (Instance == null)
            {
                Instance = new Cevap();
            }
            return Instance;

        }
    }
}

