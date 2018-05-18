using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyPool
{
    public class HockeyPoolGame
    {
        int gameID;
        DateTime gameDate;
        int homeTeamID;
        int awayTeamID;
        string homeTeam;
        string awayTeam;
        int homeScore;
        int awayScore;

        public HockeyPoolGame()
        {

        }

        public int GameID { get => gameID; set => gameID = value; }
        public DateTime GameDate { get => gameDate; set => gameDate = value; }
        public int HomeTeamID { get => homeTeamID; set => homeTeamID = value; }
        public int AwayTeamID { get => awayTeamID; set => awayTeamID = value; }
        public string HomeTeam { get => homeTeam; set => homeTeam = value; }
        public string AwayTeam { get => awayTeam; set => awayTeam = value; }
        public int HomeScore { get => homeScore; set => homeScore = value; }
        public int AwayScore { get => awayScore; set => awayScore = value; }
        
    }
}
