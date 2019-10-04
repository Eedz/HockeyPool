using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace HockeyPool
{
     
    static class DBUtilities
    {
        
        public static void ResolveBet (int betID, int homeScore, int awayScore)
        {
            using (SqlDataAdapter sql = new SqlDataAdapter())
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HockeyPoolConnectionString"].ConnectionString))
            {
                conn.Open();

                sql.InsertCommand = new SqlCommand("proc_ResolveBet", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                sql.InsertCommand.Parameters.AddWithValue("@betID", betID);
                sql.InsertCommand.Parameters.AddWithValue("@homeScore", homeScore);
                sql.InsertCommand.Parameters.AddWithValue("@awayScore", awayScore);


                try
                {
                    sql.InsertCommand.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    
                }
            }
            
        }

        public static int EnterBet (int userID, int amount, int gameID, int homeScore, int awayScore)
        {
            using (SqlDataAdapter sql = new SqlDataAdapter())
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HockeyPoolConnectionString"].ConnectionString))
            {
                conn.Open();

                sql.InsertCommand = new SqlCommand("proc_CreateBetWithScore", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                sql.InsertCommand.Parameters.AddWithValue("@userID", userID);
                sql.InsertCommand.Parameters.AddWithValue("@gameID", gameID);
                sql.InsertCommand.Parameters.AddWithValue("@betAmount", amount);
                sql.InsertCommand.Parameters.AddWithValue("@homeScore", homeScore);
                sql.InsertCommand.Parameters.AddWithValue("@awayScore", awayScore);


                try
                {
                    sql.InsertCommand.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    return 1;
                }
            }
            return 0;
        }

        public static BettingSquares GetGameBets(int gameID)
        {
            BettingSquares squares = new BettingSquares();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HockeyPoolConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM FN_GetGameBets(@gameID)", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@gameID", gameID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            int user = (int)reader["UserID"];
                            decimal amt = (decimal)reader["BetAmount"];
                            UserBet bet = new UserBet(user, amt );
                            squares.BuySquare(bet, (int)reader["HomeScore"], (int)reader["AwayScore"]);
                        }
                    }

                }
            }
            return squares;
        }

        public static int GetUserID (string username)
        {
            int result;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HockeyPoolConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ID FROM tblUsers WHERE username = @username", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@username", username);
                    result = (int)cmd.ExecuteScalar();
                    
                }
            }
            return result;
        }

        public static string GetUserName(int userid)
        {
            string result = "";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HockeyPoolConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT username FROM tblUsers WHERE ID = @userid", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@userid", userid);
                    result = (string)cmd.ExecuteScalar();

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
                        while (reader.Read())
                        {
                           
                            result.ID = (int)reader["ID"];
                            result.Name = (string)reader["username"];
                        }
                    }
                    
                    

                }
            }
            return result;
        }

        public static List<HockeyPoolGame> GetUnresolvedGames()
        {
            List<HockeyPoolGame> result = new List<HockeyPoolGame>();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HockeyPoolConnectionString"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT GameID FROM tblBets WHERE Resolved = 0 GROUP BY GameID", conn))
                {
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HockeyPoolGame g = new HockeyPoolGame();
                            g.GameID = (int)reader["GameID"];
                            result.Add(g);
                        }
                    }



                }
            }
            return result;
        }

        public static void AddToPool(HockeyPoolGame g)
        {

            using (SqlDataAdapter sql = new SqlDataAdapter())
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HockeyPoolConnectionString"].ConnectionString))
            {
                conn.Open();

                sql.InsertCommand = new SqlCommand("proc_AddToPool", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };


                sql.InsertCommand.Parameters.AddWithValue("@gameID", g.GameID);

                try
                {
                    sql.InsertCommand.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    int i = 0;
                }

            }
            
        }

        public static void AddToBalance(Person p, int amount)
        {

            using (SqlDataAdapter sql = new SqlDataAdapter())
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HockeyPoolConnectionString"].ConnectionString))
            {
                conn.Open();

                sql.InsertCommand = new SqlCommand("proc_AddBalance", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };


                sql.InsertCommand.Parameters.AddWithValue("@userID", p.ID);
                sql.InsertCommand.Parameters.AddWithValue("@amount", amount);

                try
                {
                    sql.InsertCommand.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    int i = 0;
                }

            }

        }

    }
}
