using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyPool
{
    public class Status
    {
        public string abstractGameState { get; set; }
        public string codedGameState { get; set; }
        public string detailedState { get; set; }
        public string statusCode { get; set; }
        public bool startTimeTBD { get; set; }
    }

    public class LeagueRecord
    {
        public int wins { get; set; }
        public int losses { get; set; }
        public string type { get; set; }
    }

    public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Away
    {
        public LeagueRecord leagueRecord { get; set; }
        public int score { get; set; }
        public Team team { get; set; }
    }

    public class LeagueRecord2
    {
        public int wins { get; set; }
        public int losses { get; set; }
        public string type { get; set; }
    }

    public class Team2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Home
    {
        public LeagueRecord2 leagueRecord { get; set; }
        public int score { get; set; }
        public Team2 team { get; set; }
    }

    public class Teams
    {
        public Away away { get; set; }
        public Home home { get; set; }
    }

    public class Venue
    {
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Content
    {
        public string link { get; set; }
    }

    public class Game
    {
        public int gamePk { get; set; }
        public string link { get; set; }
        public string gameType { get; set; }
        public string season { get; set; }
        public DateTime gameDate { get; set; }
        public Status status { get; set; }
        public Teams teams { get; set; }
        public Venue venue { get; set; }
        public Content content { get; set; }
    }

    public class Date
    {
        public string date { get; set; }
        public int totalItems { get; set; }
        public int totalEvents { get; set; }
        public int totalGames { get; set; }
        public int totalMatches { get; set; }
        public List<Game> games { get; set; }
        public List<object> events { get; set; }
        public List<object> matches { get; set; }
    }

    public class TeamSkaterStats
    {
        public int goals { get; set; }
        public int pim { get; set; }
        public int shots { get; set; }
        public string powerPlayPercentage { get; set; }
        public double powerPlayGoals { get; set; }
        public double powerPlayOpportunities { get; set; }
        public string faceOffWinPercentage { get; set; }
        public int blocked { get; set; }
        public int takeaways { get; set; }
        public int giveaways { get; set; }
        public int hits { get; set; }
    }

    public class TeamStats
    {
        public TeamSkaterStats teamSkaterStats { get; set; }
    }


    public class NHLAPI
    {
        public string copyright { get; set; }
        public int totalItems { get; set; }
        public int totalEvents { get; set; }
        public int totalGames { get; set; }
        public int totalMatches { get; set; }
        public int wait { get; set; }
        public List<Date> dates { get; set; }
        public List<Game> games { get; set; }
        public Teams teams { get; set; } // for boxscores
    }
}
