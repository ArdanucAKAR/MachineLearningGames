using MachineLearningGames.Chatbot.Classes;
using MachineLearningGames.FaceLock.Classes;
using MachineLearningGames.SchoolLibrary.Classes;
using MachineLearningGames.JourneyToSchool.Classes;
using MachineLearningGames.JudgeBook.Class;
using MachineLearningGames.LocateLarry.Class;
using MachineLearningGames.MakeMeHappy.Classes;
using MachineLearningGames.RockPaperScissors.Classes;
using MachineLearningGames.Snap.Classes;
using MachineLearningGames.Titanic.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningGames.Main.Classes
{
    public class Singleton
    {
        private static Singleton instance;

        public DBChatBot ChatBot { get; set; }
        public DBFaceLock FaceLock { get; set; }
        public DBJourneyToSchool JourneyToSchool { get; set; }
        public DBJudgeBook JudgeBook { get; set; }
        public DBLocateLarry LocateLarry { get; set; }
        public DBMakeMeHappy MakeMeHappy { get; set; }
        public DBRockPaperScissors RockPaperScissors { get; set; }
        public DBSchoolLibrary SchoolLibrary { get; set; }
        public DBSnap Snap { get; set; }
        public DBTitanic Titanic { get; set; }

        public Singleton()
        {
            ChatBot = new DBChatBot();
            FaceLock= new DBFaceLock();
            JourneyToSchool = new DBJourneyToSchool();
            JudgeBook = new DBJudgeBook();
            LocateLarry = new DBLocateLarry();
            MakeMeHappy = new DBMakeMeHappy();
            RockPaperScissors = new DBRockPaperScissors();
            SchoolLibrary = new DBSchoolLibrary();
            Snap = new DBSnap();
            Titanic = new DBTitanic();
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
                instance = new Singleton();

            return instance;
        }
    }
}
