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


        public EnterBet()
        {
            InitializeComponent();
            cmdAwayTeam.Text = "";
            cmdHomeTeam.Text = "";

            
        }

        private void cmdAwayTeam_Click(object sender, EventArgs e)
        {
           
        }
    }
}
