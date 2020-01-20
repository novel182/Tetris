using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Tetris.Models;

namespace Tetris
{
    public class MySqlDb
    {
        private MySqlConnection conn;

        public MySqlDb(string server, string user, string pw, string db)
        {
            var connStringBuilder = new MySqlConnectionStringBuilder
            {
                Server = server,
                UserID = user,
                Password = pw,
                Database = db,
                OldGuids = true
            };

            string connstr = connStringBuilder.ConnectionString;
            conn = new MySqlConnection(connstr);
        }

        public void OpenConnection()
        {
            conn.Open();
        }

        public void CloseConnection()
        {
            conn.Close();
        }

        public List<HighScore> GetAllScore()
        {
            List<HighScore> score = new List<HighScore>();
            string sql = "SELECT * FROM HighScore orderby Score limit 5";
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = sql;
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    score.Add(new HighScore
                    {
                        
                        Name = (string)reader["Name"],
                        Score = (string)reader["Score"]
                    });
                }
                reader.Close();
            }
            return score;
        }

       
        public void AddScore (string name, int score)
        {
          
            string sql = "INSERT INTO HighScore (Name, Score) Values (" + name +"," + score + ")";
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = sql;
                cmd.Connection = conn;
               
            }

        }

             

       

        
    }
}




