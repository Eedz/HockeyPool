using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HockeyPool
{
    public partial class HockeyPoolMenu : Form
    {
        NHLAPI p;
        HockeyAPI hapi = new HockeyAPI();
        List<HockeyPoolGame> todayGames;
        List<BetLine> todayBets;
        Person currentUser; // get user from login form
        List<Person> AllUsers;
        public HockeyPoolMenu()
        {
            InitializeComponent();
            todayGames = new List<HockeyPoolGame>();
            todayBets = new List<BetLine>();
        }

        public HockeyPoolMenu(string user)
        {
            InitializeComponent();
            ResolveBets();
            
            todayGames = new List<HockeyPoolGame>();
            todayBets = new List<BetLine>();
            AllUsers = new List<Person>();

            currentUser = DBUtilities.GetUser(user);
            
        }

        

        private async void HockeyPoolMenu_Load(object sender, EventArgs e)
        {
                       

            // get today's games
            await LoadGames(DateTime.Today.ToString("yyyy-MM-dd"));
            // get today's bets
            LoadBets(DateTime.Today.ToString("yyyy-MM-dd"));

            cmd1Dollar.Focus();
        }

        private async Task LoadGames(string d)
        {
            p = await GetSchedule(10,d);
            todayGames.Clear();
            dataGridSchedule.DataSource = null;
            if (p == null)
            {
                MessageBox.Show("Could not get info.");
                
                return;
            }
            if (p.totalGames == 0 ){
                //MessageBox.Show("No games scheduled for " + d);
                
                return;
            }
           
            HockeyPoolGame g;
            for (int i = 0; i < p.dates[0].games.Count; i++)
            {
                g = new HockeyPoolGame
                {
                    GameID = p.dates[0].games[i].gamePk,
                    GameDate = p.dates[0].games[i].gameDate,
                    HomeTeam = p.dates[0].games[i].teams.home.team.name,
                    HomeTeamID = p.dates[0].games[i].teams.home.team.id,
                    AwayTeam = p.dates[0].games[i].teams.away.team.name,
                    AwayTeamID = p.dates[0].games[i].teams.away.team.id
                };
                todayGames.Add(g);
            }
            
            dataGridSchedule.DataSource = todayGames;
        }

        

        private void LoadBets(string d)
        {

            todayBets.Clear();

            List<BettingSquares> squares = new List<BettingSquares>();
            
            foreach (HockeyPoolGame g in todayGames)
            {
                BettingSquares bs = DBUtilities.GetGameBets(g.GameID);

                squares.Add(bs);
                

            }
            
            foreach (BettingSquares bs in squares)
            {

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0;j < 10; j++)
                    {
                        if (bs.Squares[i,j] != null)
                        {
                            // create a bet line for each bet in the squares
                            BetLine b = new BetLine();
                            b.Name = DBUtilities.GetUserName(bs.Squares[i, j].userid);
                            b.HomeScore = i;
                            b.AwayScore = j;
                            todayBets.Add(b);
                        }
                    }
                    
                }
                

            }

            dataGridBets.DataSource = null;
            dataGridBets.DataSource = todayBets;
           
        }



        private async Task<NHLAPI> LoadTeams()
        {
            p = await hapi.GetTeams() ;
            return p;
        }

        private async Task<NHLAPI> GetSchedule()
        {
            p = await hapi.GetSchedule();
            return p;
        }

        private async Task<NHLAPI> GetSchedule(string d)
        {
            p = await hapi.GetSchedule(d);
            return p;
        }

        private async Task<NHLAPI> GetSchedule(int t, string d)
        {
            p = await hapi.GetSchedule(t, d);
            return p;
        }



        /// <summary>
        /// Enter a bet by assigning a random score to the current user.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        private int EnterBet(int amount)
        {
            
            if (dataGridSchedule.CurrentRow == null)
                return 1;

            HockeyPoolGame g = (HockeyPoolGame)dataGridSchedule.CurrentRow.DataBoundItem;
            BettingSquares squares;

            squares = DBUtilities.GetGameBets(g.GameID);

            if (squares.SquaresFull())
            {
                MessageBox.Show("No more bets available for this game.");
                return 1;
            }


            int home, away;
            do
            {
                RandomScore(out home, out away);
            } while (!squares.IsSquareAvailable(home, away));

            // we have a score and a bet, now record the bet
            int betResult = DBUtilities.EnterBet(currentUser.ID, 1, g.GameID, home, away);

            return betResult;
        }

        /// <summary>
        /// Get a random score by generating 2 unique random integers between 0 and 9.
        /// </summary>
        /// <param name="home"></param>
        /// <param name="away"></param>
        private void RandomScore(out int home, out int away)
        {
            Random r = new Random();

            home = r.Next(0, 9);
            away = r.Next(0, 9);

            while (home == away)
            {
                away = r.Next(0, 9);
            }
        }

        private async void cmd1Dollar_Click(object sender, EventArgs e)
        {
            EnterBet(1);

            await UpdateDate(dtpSchedule);
        }

        private async void cmd2Dollar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i ++)
                EnterBet(1);

            await UpdateDate(dtpSchedule);
        }

        private async void cmd5Dollar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                EnterBet(1);

            await UpdateDate(dtpSchedule);
        }

        /// <summary>
        /// Enter a bet for a specific winning team.
        /// </summary>
        /// <param name="amount"></param>
        private void EnterBetWinningTeam(int amount)
        {

            if (dataGridSchedule.CurrentRow == null)
                return;

            Form frmBet;
            HockeyPoolGame g = (HockeyPoolGame)dataGridSchedule.CurrentRow.DataBoundItem;

            frmBet = new EnterBet(amount, g, currentUser.ID);

            frmBet.Show();
        }

        private async void dtpSchedule_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            await UpdateDate(dtp);
            
            #if RELEASE 
            if (dtp.Value < DateTime.Today)
            {
                cmd1Dollar.Enabled = false;
                cmd2Dollar.Enabled = false;
                cmd5Dollar.Enabled = false;
            }
            #endif 
        }

        private async Task UpdateDate(DateTimePicker d)
        {
            await LoadGames(d.Value.ToString("yyyy-MM-dd"));
            LoadBets(d.Value.ToString("yyyy-MM-dd"));
        }

        /// <summary>
        /// Remove extra columns and add spaces to shown columns.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridSchedule_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string col;
            List<string> toRemove = new List<string>();
            for (int i = 0; i < dataGridSchedule.ColumnCount; i++)
            {
                col = dataGridSchedule.Columns[i].Name;
                switch (col)
                {
                    case "HomeTeam":
                        dataGridSchedule.Columns[i].Name = "Home Team";
                        break;
                    case "AwayTeam":
                        dataGridSchedule.Columns[i].Name = "Away Team";
                        break;
                    default:
                        toRemove.Add(col);
                        break;
                }
            }
            foreach (string s in toRemove)
            {
                dataGridSchedule.Columns.Remove(s);
            }
            dataGridSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


     
        private async void ResolveBets()
        {
            // get unresolved bets
            DataTable bets;
       
            int homeScore, awayScore;

            List<HockeyPoolGame> unresolvedGames;
            unresolvedGames = DBUtilities.GetUnresolvedGames();
            
            foreach (HockeyPoolGame g in unresolvedGames)
            {
                if (!HasWinner(g))
                    DBUtilities.AddToPool(g);
            }

            bets = tblBetsTableAdapter.GetDataByUnresolved();
            
            foreach (DataRow r in bets.Rows)
            {
                p = await hapi.GetGameResult(r["gameID"].ToString());

                homeScore = p.teams.home.teamStats.teamSkaterStats.goals;
                awayScore = p.teams.away.teamStats.teamSkaterStats.goals;

                // first check if there is any score, if not, the game has not been played yet
                if (homeScore == 0 && awayScore == 0)
                    continue;

                
                DBUtilities.ResolveBet((int)r["ID"], homeScore, awayScore);

            }



            this.tblUsersTableAdapter.Fill(this.hockeyPoolDataSet.tblUsers);

        }

        private bool HasWinner(HockeyPoolGame g)
        {
            List<BettingSquares> squares = new List<BettingSquares>();
          
            BettingSquares bs = DBUtilities.GetGameBets(g.GameID);

            squares.Add(bs);

            foreach (BettingSquares s in squares)
            {

            }

            return false;
        }

        
    }
}
