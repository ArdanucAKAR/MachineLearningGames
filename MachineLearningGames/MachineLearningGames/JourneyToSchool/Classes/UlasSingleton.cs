using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningGames
{
    class UlasSingleton
    {

        public List<Journey> Journeys { get; set; }
        private static UlasSingleton instance = null;

        private UlasSingleton()
        {
            Journeys = new List<Journey>();
        }

        public static UlasSingleton Instance
        {
            get { return instance ?? (instance = new UlasSingleton()); }
        }

    }
}
