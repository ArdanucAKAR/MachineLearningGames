using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningGames.Main.Classes
{
    public class _Game
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Image Image { get; set; }
        public Game Game { get; set; }
    }

    public enum Game
    {
        ChatBot, FaceLock, JourneyToSchool, JudgeBook, LocateLarry, MakeMeHappy, RockPaperScissors, SchoolLibrary, Snap, Titanic
    }
}
