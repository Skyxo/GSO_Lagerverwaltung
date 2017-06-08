using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Lagerverwaltung.Utils
{
    class DatenUtils
    {

        private static string connectionString = "host=localhost;user=root;database=lagerverwaltung";

        /// <summary>
        /// Daten aus der Datenbank holen
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static DataTable DatenHolen(string query, Dictionary<string, object> parameters)
        {
            DataTable data = new DataTable();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    // Parameter dem Command hinzufügen
                    if (parameters != null && parameters.Count > 0)
                    {
                        foreach (KeyValuePair<string, object> pair in parameters)
                        {
                            cmd.Parameters.AddWithValue(pair.Key, pair.Value);
                        }
                    }

                    // Ausführen und DataTable befüllen
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(data);
                    }
                }

                con.Close();
            }

            return data;
        }

        /// <summary>
        /// Daten aus der Datenbank bearbeiten
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static int DatenBearbeiten(string query, Dictionary<string, object> parameters)
        {
            int ret = -1;

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    // Parameter dem Command hinzufügen
                    if (parameters != null && parameters.Count > 0)
                    {
                        foreach (KeyValuePair<string, object> pair in parameters)
                        {
                            cmd.Parameters.AddWithValue(pair.Key, pair.Value);
                        }
                    }

                    // Abfrage ausführen
                    ret = cmd.ExecuteNonQuery();
                }

                con.Close();
            }

            return ret;
        }

    }
}
