using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace HockeyPool
{
    public partial class EnterBet : Form
    {

        int betAmount;
        HockeyPoolGame currentGame; // the game being bet on
        int userID;

        public EnterBet()
        {
            InitializeComponent();
            cmdAwayTeam.Text = "";
            cmdHomeTeam.Text = "";
            betAmount = 0;
            
        }

        public EnterBet(int amount, HockeyPoolGame g, int user)
        {
            InitializeComponent();
            lblBetAmount.Text = "$" + amount.ToString() + " bet";
            betAmount = amount;
            cmdAwayTeam.Text = g.AwayTeam;
            cmdHomeTeam.Text = g.HomeTeam;
            currentGame = g;

            userID = user;
        }

        private void cmdAwayTeam_Click(object sender, EventArgs e)
        {
            
            //tblBetsTableAdapter.InsertBet(userID, currentGame.GameID, betAmount, currentGame.AwayTeamID);
            this.Close();
        }

        private void cmdHomeTeam_Click(object sender, EventArgs e)
        {

           // tblBetsTableAdapter.InsertBet(userID, currentGame.GameID, betAmount, currentGame.HomeTeamID);
            this.Close();
        }
    }
}
