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
    public partial class EnterGameResult : Form
    {
        public EnterGameResult()
        {
            InitializeComponent();
        }

        private void gamesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gamesListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hockeyDataDataSet);

        }

        private void AddGame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hockeyDataDataSet.GamesList' table. You can move, or remove it, as needed.
            this.gamesListTableAdapter.Fill(this.hockeyDataDataSet.GamesList);
            // TODO: This line of code loads data into the 'hockeyDataDataSet.GamesList' table. You can move, or remove it, as needed.
            this.gamesListTableAdapter.Fill(this.hockeyDataDataSet.GamesList);
            // TODO: This line of code loads data into the 'hockeyDataDataSet.Teams' table. You can move, or remove it, as needed.
           

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
