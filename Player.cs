using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace MathTest
{
    /// <summary>
    /// Player class.
    /// </summary>
    public class Player
    {

        /// <summary>
        /// Gets or sets the name of the player.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the score of the player.
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        ///  String with some data needed for the connection.
        /// </summary>
        static string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        /// <summary>
        ///  Player constructor.
        /// </summary>
        public Player()
        {

        }

        /// <summary>
        /// Adds a new Player.
        /// </summary>
        /// <param name="id">Id of the new player.</param>
        /// <param name="score">Score of the new player.</param>
        /// <param name="name">Name of the new player.</param>
        public bool AddNewPlayer(Player P)
        {
            // Create connection Object.
            SqlConnection con = new SqlConnection(connString);

            // Open connection.
            con.Open();

            // Create query.
            string sql = "Insert into Tbl_Player values (@Player_Name, @Player_Score)";

            // Create command objetc.
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.Parameters.AddWithValue("@Player_Name", P.Name);
            cmd.Parameters.AddWithValue("@Player_Score", P.Score);

            int queryResult = cmd.ExecuteNonQuery();
            bool isSuccess = queryResult > 0;

            // Close the connection.
            con.Close();

            return isSuccess;
        }
    }
}
