using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace HockeyPool
{
     
    static class DBUtilities
    {
        
        public static int GetUserID (string username)
        {
            int result;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HockeyPoolConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ID FROM tblUsers WHERE username = @username", conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    result = (int)cmd.ExecuteScalar();
                    
                }
            }
            return result;
        }

        public static Person GetUser(string username)
        {
            Person result = new Person();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HockeyPoolConnectionString"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT ID, username FROM tblUsers WHERE username = @username", conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        result.ID = (int)reader["ID"];
                        result.Name = (string)reader["username"];
                    }
                    
                    

                }
            }
            return result;
        }

    }
}
