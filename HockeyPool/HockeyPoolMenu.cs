using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHLStats;

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
            
            
            todayGames = new List<HockeyPoolGame>();
            todayBets = new List<BetLine>();
            AllUsers = new List<Person>();

            currentUser = DBUtilities.GetUser(user);
        }

        private async void HockeyPoolMenu_Load(object sender, EventArgs e)
        {
            await ResolveBets();
            UpdatePool();
            UpdateLeaderboard();

            // get today's games
            await LoadGames(DateTime.Today.ToString("yyyy-MM-dd"));
            // get today's bets
            LoadBets(DateTime.Today.ToString("yyyy-MM-dd"));

            cmd1Dollar.Focus();
        }

        private void PaintAwayTeamLabel()
        {
            Graphics g;
            g = this.CreateGraphics();

            g.Clear(this.BackColor); // reset drawing surface

            if (todayGames.Count == 0) return;
            string myText = todayGames[0].AwayTeam;

            FontFamily fontFamily = new FontFamily("Microsoft Sans Serif");
            Font font = new Font(fontFamily, 15, FontStyle.Regular, GraphicsUnit.Point);
            PointF pointF = new PointF(gridSquares.Left - 30, gridSquares.Top);
            StringFormat stringFormat = new StringFormat();
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(255, 0, 0, 0));

            stringFormat.FormatFlags = StringFormatFlags.DirectionVertical;

            g.DrawString(myText, font, solidBrush, pointF, stringFormat);
        }

        #region Button Events

        private void changeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HockeyPoolLogin login = new HockeyPoolLogin();
            switch (login.ShowDialog())
            {
                case DialogResult.OK:
                    login.Close();
                    currentUser = DBUtilities.GetUser(login.Username);
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.No:
                    MessageBox.Show("Unsuccessful login attempt.");
                    break;
            }
        }

        private async void cmd1Dollar_Click(object sender, EventArgs e)
        {
            EnterBet(1);
            UpdatePool();
            UpdateLeaderboard();

            await UpdateDate(dtpSchedule);
        }

        private async void cmd2Dollar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
                EnterBet(1);

            UpdatePool();
            UpdateLeaderboard();

            await UpdateDate(dtpSchedule);
        }

        private async void cmd5Dollar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                EnterBet(1);

            UpdatePool();
            UpdateLeaderboard();

            await UpdateDate(dtpSchedule);
        }

        private void cmdAddMoney_Click(object sender, EventArgs e)
        {
            InputBox newAmount = new InputBox("Enter Balance:", "Add Balance");

            newAmount.ShowDialog();
            string input = newAmount.userInput;
            if (string.IsNullOrEmpty(input))
                return;

            int balance = Convert.ToInt32(input);

            DBUtilities.AddToBalance(currentUser, balance);

            UpdateLeaderboard();
        }
        

        private void cmdPreviousDay_Click(object sender, EventArgs e)
        {
            this.dtpSchedule.Value = this.dtpSchedule.Value.AddDays(-1);
        }

        private void cmdNextDay_Click(object sender, EventArgs e)
        {
            this.dtpSchedule.Value = this.dtpSchedule.Value.AddDays(1);
        }
        #endregion

        #region Grid Events

        private async void dtpSchedule_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            await UpdateDate(dtp);

            if (dtp.Value < DateTime.Today)
            {
                cmd1Dollar.Enabled = false;
                cmd2Dollar.Enabled = false;
                cmd5Dollar.Enabled = false;
            }
            else
            {
                cmd1Dollar.Enabled = true;
                cmd2Dollar.Enabled = true;
                cmd5Dollar.Enabled = true;
            }

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
                        dataGridSchedule.Columns[i].HeaderText = "Home";
                        dataGridSchedule.Columns[i].DisplayIndex = 0;
                        break;
                    case "AwayTeam":
                        dataGridSchedule.Columns[i].HeaderText = "Away";
                        dataGridSchedule.Columns[i].DisplayIndex = 2;
                        break;
                    case "HomeScore":
                        if (dtpSchedule.Value >= DateTime.Today)
                            toRemove.Add(col);
                        else
                        {
                            dataGridSchedule.Columns[i].HeaderText = "S";
                            dataGridSchedule.Columns[i].DisplayIndex = 1;
                        }

                        break;
                    case "AwayScore":
                        if (dtpSchedule.Value >= DateTime.Today)
                            toRemove.Add(col);
                        else
                        {
                            dataGridSchedule.Columns[i].HeaderText = "S";
                            dataGridSchedule.Columns[i].DisplayIndex = 3;
                        }

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

            for (int i = 0; i < dataGridSchedule.ColumnCount; i++)
            {
                col = dataGridSchedule.Columns[i].Name;
                switch (col)
                {
                    case "HomeTeam":
                        dataGridSchedule.Columns[i].DisplayIndex = 0;
                        break;
                    case "AwayTeam":
                        if (dtpSchedule.Value >= DateTime.Today)
                            dataGridSchedule.Columns[i].DisplayIndex = 1;
                        else
                            dataGridSchedule.Columns[i].DisplayIndex = 2;

                        break;
                    case "HomeScore":
                        dataGridSchedule.Columns[i].DisplayIndex = 1;
                        break;
                    case "AwayScore":
                        dataGridSchedule.Columns[i].DisplayIndex = 3;
                        break;
                }
            }

            dataGridSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        #endregion

        #region Update Form 
        private async Task UpdateDate(DateTimePicker d)
        {
            await LoadGames(d.Value.ToString("yyyy-MM-dd"));
            LoadBets(d.Value.ToString("yyyy-MM-dd"));
        }

        private void UpdateLeaderboard()
        {
            tblUsersBindingSource.Sort = "balance";
            tblUsersTableAdapter.ClearBeforeFill = true;
            tblUsersTableAdapter.Fill(hockeyPoolDataSet.tblUsers);
        }

        private void UpdatePool()
        {
            tblBetPoolTableAdapter.ClearBeforeFill = true;
            tblBetPoolTableAdapter.Fill(hockeyPoolDataSet.tblBetPool);
        }
        #endregion

        #region Methods
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
                    AwayTeamID = p.dates[0].games[i].teams.away.team.id,
                    HomeScore = p.dates[0].games[i].teams.home.score,
                    AwayScore = p.dates[0].games[i].teams.away.score
                    
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
                txtHomeTeamLabel.Text = todayGames[0].HomeTeam;
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

            DataTable grid = new DataTable();
            // create table with 10 columns
            for (int i = 0; i < 10; i++)
                grid.Columns.Add(i.ToString());

            // fill with 10 empty rows
            for (int i = 0; i <10; i++)
            {
                DataRow r = grid.NewRow();
                for (int c = 0; c < 10; c++)                  
                    r[c] = "";

                grid.Rows.Add(r);                
            }
            
            // fill in bet names
            foreach (BetLine b in todayBets)
                grid.Rows[b.AwayScore][b.HomeScore] = b.Name;

            // format data grid view
            gridSquares.DataSource = grid;
            // add row header
            foreach (DataGridViewRow r in gridSquares.Rows)
            {
                r.HeaderCell.Value = r.Index.ToString();
            }
            // format column headers
            for (int i = 0; i < 10; i++)
            {
                gridSquares.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
                gridSquares.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            // add away team label
            PaintAwayTeamLabel();
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

        private async Task ResolveBets()
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

                NHLStats.Game g = new NHLStats.Game((string)r["gameID"]);
                if (g.abstractGameState == "Final") { 
                    // first check if there is any score, if not, the game has not been played yet
                    if (homeScore == 0 && awayScore == 0)
                        continue;

                    DBUtilities.ResolveBet((int)r["ID"], homeScore, awayScore);
                }   

            }
            return;
        }

        #endregion
    }
}
