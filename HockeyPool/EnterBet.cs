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
    public partial class EnterBet : Form
    {
        
        int betAmount;
        Game nextGame;

        // get next game for this user
        HockeyPoolGame currentGame; // the game being bet on

        public EnterBet()
        {
            InitializeComponent();
            cmdAwayTeam.Text = "";
            cmdHomeTeam.Text = "";

            
        }

        public EnterBet(int amount, HockeyPoolGame g)
        {
            InitializeComponent();
            lblBetAmount.Text = "$" + amount.ToString() + " bet";
            cmdAwayTeam.Text = g.AwayTeam;
            cmdHomeTeam.Text = g.HomeTeam;
            currentGame = g;


        }

        private void cmdAwayTeam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Insert Bet record for away team for gameID " + currentGame.GameID);
        }

        private void cmdHomeTeam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Insert Bet record for home team for gameID " + currentGame.GameID);
        }
    }
}
