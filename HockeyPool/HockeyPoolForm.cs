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
    public partial class HockeyPoolForm : Form
    {
        public HockeyPoolForm()
        {
            InitializeComponent();
        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.peopleBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hockeyDataDataSet);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }


        }

        private void HockeyPoolForm_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'hockeyDataDataSet.GameList' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'hockeyDataDataSet.Games' table. You can move, or remove it, as needed.
            this.gamesTableAdapter.Fill(this.hockeyDataDataSet.Games);
            // TODO: This line of code loads data into the 'hockeyDataDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.hockeyDataDataSet.People);

            
        }

        private void peopleBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView r = (DataRowView)peopleBindingNavigator.BindingSource.Current;
            int ID = (int)(System.Convert.ChangeType(r["ID"], typeof(int)));
            try
            {
                //this.gamesListTableAdapter.FillByPerson(this.hockeyDataDataSet.GameList, ID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            peopleBindingNavigator.BindingSource.AddNew();
            
        }

        private void cmdNewBet_Click(object sender, EventArgs e)
        {
            // open the form to enter a new bet for the current person
        }


        // choose a player
        // options:
        // choose a future game
        // see their balance
        // see their win/loss
    }
}
