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

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HockeyPoolConnectionString"].ConnectionString);

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
            MessageBox.Show("Insert Bet record for away team for gameID " + currentGame.GameID);           
            
            SqlCommand cmd = new SqlCommand() ;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "dbo.proc_CreateBet";
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@gameID", currentGame.GameID);
            cmd.Parameters.AddWithValue("@betAmount", betAmount);
            cmd.Parameters.AddWithValue("@winnerID", currentGame.AwayTeamID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void cmdHomeTeam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Insert Bet record for home team for gameID " + currentGame.GameID);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "dbo.proc_CreateBet";
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@gameID", currentGame.GameID);
            cmd.Parameters.AddWithValue("@betAmount", betAmount);
            cmd.Parameters.AddWithValue("@winnerID", currentGame.HomeTeamID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
