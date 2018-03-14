using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyPool
{
    class Game
    {
        Score finalScore;
        Team homeTeam;
        Team awayTeam;

        public Game()
        {
            finalScore = null;
            homeTeam = null;
            awayTeam = null;
        }

        public Game(Team home, Team away)
        {
            homeTeam = home;
            awayTeam = away;
        }

        public Score FinalScore { get => finalScore; set => finalScore = value; }
    }
}
