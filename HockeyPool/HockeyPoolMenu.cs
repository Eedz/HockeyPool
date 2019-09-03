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
        Person currentUser; // get user from login form
        public HockeyPoolMenu()
        {
            InitializeComponent();
            todayGames = new List<HockeyPoolGame>();
        }

        public HockeyPoolMenu(string user)
        {
            InitializeComponent();
            ResolveBets();
            
            todayGames = new List<HockeyPoolGame>();

            currentUser = DBUtilities.GetUser(user);

            dataGridBets.ColumnCount = 10;
            
            for(int r = 0; r < 10; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                
                for (int c = 0; c < 10; c++)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell()
                    {
                        Value = ""
                    });
                                            
                    dataGridBets.Columns[c].HeaderText = c.ToString();
                    
                }
                dataGridBets.Rows.Add(row);
                dataGridBets.Rows[r].HeaderCell.Value = r.ToString();
            }

            dataGridBets.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            
            
        }

        private void navBetsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            BindingSource bs = (BindingSource)sender;
            BettingSquares squares = (BettingSquares)bs.Current;

            updateBetGrid(squares);
        }

        private void updateBetGrid(BettingSquares squares)
        {
            for (int home = 0; home < 10; home++)
            {
                for (int away = 0; away < 10; away++)
                {
                    //dataGridBets.Rows[home].Cells[away].Value = DBUtilities.GetUserName(squares.GetSquareUser(home, away));
                    dataGridBets.Rows[home].Cells[away].Value = squares.GetSquareUser(home, away);
                }
            }

            dataGridBets.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void HockeyPoolMenu_Load(object sender, EventArgs e)
        {
            // fill the leader board
            //this.tblUsersTableAdapter.Fill(this.hockeyPoolDataSet.tblUsers);

            

            // get today's games
            LoadGames(DateTime.Today.ToString("yyyy-MM-dd"));

            //updateBetGrid((BettingSquares)navBets.BindingSource.Current);



            cmd1Dollar.Focus();
        }

        private async void LoadGames(string d)
        {
            p = await GetSchedule(d);
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

            LoadBets();
        }

        private void LoadBets()
        {
            List<BettingSquares> squares = new List<BettingSquares>();

            foreach (HockeyPoolGame g in todayGames)
            {
                BettingSquares bs = DBUtilities.GetGameBets(g.GameID);

                squares.Add(bs);
                

            }
            BindingSource binder = new BindingSource(squares, "");
            navBets.BindingSource = binder;
            navBets.BindingSource.PositionChanged += navBetsBindingSource_PositionChanged;
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

        private void cmd1Dollar_Click(object sender, EventArgs e)
        {
            if (EnterBet(1) ==1)
                MessageBox.Show("You have already bet on this game!");
        }

        private void cmd2Dollar_Click(object sender, EventArgs e)
        {
            if (EnterBet(2) == 1)
                MessageBox.Show("You have already bet on this game!");
        }

        private void cmd5Dollar_Click(object sender, EventArgs e)
        {
            if (EnterBet(5) == 1)
                MessageBox.Show("You have already bet on this game!");
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

        private void dtpSchedule_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            LoadGames(dtp.Value.ToString("yyyy-MM-dd"));
          
            // TODO FOR TESTING
            //if (dtp.Value < DateTime.Today)
            //{
            //    cmd1Dollar.Enabled = false;
            //    cmd2Dollar.Enabled = false;
            //    cmd5Dollar.Enabled = false;
            //}

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
       
    }
}
