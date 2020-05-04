using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningGames
{
    class UlasSingleton
    {

        public int carCount { get; set; }
        public int walkCount { get; set; }
        public int cycleCount { get; set; }
        public int publicTranspotaionCount { get; set; }
        public List<Journey> Journeys { get; set; }
        private static UlasSingleton instance = null;

        private UlasSingleton()
        {
            carCount = 0;
            walkCount = 0;
            cycleCount = 0;
            publicTranspotaionCount = 0;
            Journeys = new List<Journey>();
        }

        public static UlasSingleton Instance
        {
            get { return instance ?? (instance = new UlasSingleton()); }
        }

    }
}
