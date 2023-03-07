using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDPlanes
    {
        string connString = "Server=localhost;User=root;Password=;Port=3306;database=bd_tpintegrador";

        public List<string> TraerPlanes()
        {
            List<string> datafill = new List<string>{};

            string query = "SELECT * from planes";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    datafill.Add(reader[1].ToString());
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            return datafill;
        }
    }
}
