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
        public HockeyPoolMenu()
        {
            InitializeComponent();
        }

        

        private async void HockeyPoolMenu_Load(object sender, EventArgs e)
        {
            
            //this.peopleTableAdapter.Fill(this.hockeyDataDataSet.People);

            
            Product p;
            
            //p = LoadTeams().GetAwaiter().GetResult();
            p = await LoadTeams();
            if (p == null) {
                MessageBox.Show("Could not get team info.");
            }
            MessageBox.Show("Copyright notice: " + p.copyright);
            for (int i = 0; i < p.teams.Count; i++)
            {
                //this.teamsTableAdapter1.Delete(i, p.teams[i].name);
                //this.teamsTableAdapter1.Insert(p.teams[i].name);
                MessageBox.Show("ID: " + p.teams[i].id + "\t" + "Team Name: " + p.teams[i].name);
            }
            
        }

        private async Task<Product> LoadTeams()
        {
            HockeyAPI hapi = new HockeyAPI();
            Product p;
            p = await hapi.GetTeams() ;
            return p;
        }

        private void cmdEnterGame_Click(object sender, EventArgs e)
        {
            Form frmEnterGame;
            frmEnterGame = new EnterGameResult();
            frmEnterGame.Show();
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
            frmBet = new EnterBet();

            frmBet.Show();
        }
    }
}
