﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningGames
{
    public class Singleton
    {
        private static Singleton nesne;
        public int spade = 0,
                   diamond = 0,
                   heart = 0,
                   club = 0;

        private Singleton()
        {

        }

        public static Singleton Nesne()
        {
            if (nesne == null)
                nesne = new Singleton();

            return nesne;
        }
    }
}
