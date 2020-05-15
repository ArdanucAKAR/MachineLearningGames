using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningGames.JourneyToSchool.Classes
{
    public class SingletonJTS
    {
        public List<Journey> Journeys { get; set; }
        private static SingletonJTS instance = null;

        private SingletonJTS()
        {
            Journeys = new List<Journey>();
        }

        public static SingletonJTS GetInstance()
        {
            return instance ?? (instance = new SingletonJTS());
        }
    }
}
