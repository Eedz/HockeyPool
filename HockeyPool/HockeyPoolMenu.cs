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
            
            
        }

        private void HockeyPoolMenu_Load(object sender, EventArgs e)
        {
            // fill the leader board
            //this.tblUsersTableAdapter.Fill(this.hockeyPoolDataSet.tblUsers);

            // get today's games
            LoadGames(DateTime.Today.ToString("yyyy-MM-dd"));
          
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

        private void cmd1Dollar_Click(object sender, EventArgs e)
        {
            Form frmBet;
            HockeyPoolGame g = (HockeyPoolGame) dataGridSchedule.CurrentRow.DataBoundItem;

            frmBet = new EnterBet(1, g, currentUser.ID);
            
            frmBet.Show();
        }

        private void cmd2Dollar_Click(object sender, EventArgs e)
        {
            Form frmBet;
            HockeyPoolGame g = (HockeyPoolGame)dataGridSchedule.CurrentRow.DataBoundItem;

            frmBet = new EnterBet(2, g, currentUser.ID);

            frmBet.Show();
        }

        private void cmd5Dollar_Click(object sender, EventArgs e)
        {
            Form frmBet;
            HockeyPoolGame g = (HockeyPoolGame)dataGridSchedule.CurrentRow.DataBoundItem;

            frmBet = new EnterBet(5, g, currentUser.ID);

            frmBet.Show();
        }

        private void dtpSchedule_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            LoadGames(dtp.Value.ToString("yyyy-MM-dd"));
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
            int winningTeam;
            bets = tblBetsTableAdapter.GetDataByUnresolved();
            
            foreach (DataRow r in bets.Rows)
            {
                p = await hapi.GetGameResult(r["gameID"].ToString());

                homeScore = p.teams.home.teamStats.teamSkaterStats.goals;
                awayScore = p.teams.away.teamStats.teamSkaterStats.goals;

                // first check if there is any score, if not, the game has not been played yet
                if (homeScore == 0 && awayScore == 0)
                    continue;

                if (homeScore > awayScore)
                    winningTeam = p.teams.home.team.id;
                else
                    winningTeam = p.teams.away.team.id;

                if (winningTeam != 0 )
                    tblBetsTableAdapter.ResolveBet((int)r["ID"], winningTeam);
            }


            this.tblUsersTableAdapter.Fill(this.hockeyPoolDataSet.tblUsers);

        }
       
    }
}
