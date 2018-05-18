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
        public HockeyPoolMenu()
        {
            InitializeComponent();
            todayGames = new List<HockeyPoolGame>();
        }

        

        private async void HockeyPoolMenu_Load(object sender, EventArgs e)
        {

            //this.peopleTableAdapter.Fill(this.hockeyDataDataSet.People);
            string today = DateTime.Today.ToString("yyyy-MM-dd");

            
            p = await GetSchedule(today);
            if (p == null) {
                MessageBox.Show("Could not get info.");
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
            cmd1Dollar.Focus();
        }

        private async void LoadGames(string d)
        {
            p = await GetSchedule(d);
            if (p == null)
            {
                MessageBox.Show("Could not get info.");
                return;
            }
            if (p.totalGames == 0 ){
                MessageBox.Show("No games scheduled for " + d);
                return;
            }
            todayGames.Clear();
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
            dataGridSchedule.DataSource = null;
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


        private void peopleListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmPeople;
            frmPeople = new HockeyPoolForm();
            frmPeople.Show();
        }

        private void cmd1Dollar_Click(object sender, EventArgs e)
        {
            Form frmBet;
            HockeyPoolGame g = (HockeyPoolGame) dataGridSchedule.CurrentRow.DataBoundItem;

            frmBet = new EnterBet(1, g);
            
            frmBet.Show();
        }

        private void cmd2Dollar_Click(object sender, EventArgs e)
        {
            Form frmBet;
            HockeyPoolGame g = (HockeyPoolGame)dataGridSchedule.CurrentRow.DataBoundItem;

            frmBet = new EnterBet(2, g);

            frmBet.Show();
        }

        private void cmd5Dollar_Click(object sender, EventArgs e)
        {
            Form frmBet;
            HockeyPoolGame g = (HockeyPoolGame)dataGridSchedule.CurrentRow.DataBoundItem;

            frmBet = new EnterBet(5, g);

            frmBet.Show();
        }

        private void dtpSchedule_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            LoadGames(dtp.Value.ToString("yyyy-MM-dd"));
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

        
    }
}
