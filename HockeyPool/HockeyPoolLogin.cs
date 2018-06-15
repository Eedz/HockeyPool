using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace HockeyPool
{
    public partial class HockeyPoolLogin : Form
    {

        private string username;

        public HockeyPoolLogin()
        {
            InitializeComponent();
        }

        public string Username { get => username; set => username = value; }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            
            if (txtUserName.Text.Equals("") || txtPassword.Text.Equals("")){
                return;
            }

            string result;
            username = txtUserName.Text;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HockeyPoolConnectionString"].ConnectionString);
            using (SqlCommand cmd = new SqlCommand("proc_Login", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.Add("@responseMessage", SqlDbType.VarChar, 255);
                cmd.Parameters["@responseMessage"].Direction = ParameterDirection.Output;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                result = cmd.Parameters["@responseMessage"].Value.ToString();
            }
            if (result.Equals ("User successfully logged in"))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.No;
            }
        }

        private void HockeyPoolLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                DialogResult = DialogResult.Cancel;
        }
    }
}
