using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningGames.JourneyToSchool.Classes
{
    /*
        Journeytype 1 =  Walk
        Journeytype 2 =  Car
        Journeytype 3 =  Cycle
    */
    public class Journey
    {
        public int Age { get; set; }
        public double Distance { get; set; }
        public int Friends { get; set; }
        public int JouneyType { get; set; }
    }
}
