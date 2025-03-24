using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ConfigDAL
    {
        public void SaveConfig(ConfigDTO config)
        {
            // Save config to database
            Settings.Default.strConn = "Data Source=" + config.Servername + ";Initial Catalog=" + config.Database + ";User ID=" + config.Username + ";Password=" + config.Password;
            Settings.Default.Save();

        }

        public DataTable getDatabase(ConfigDTO config)
        {
            try
            {
                DataTable dt = new DataTable();
                string conn = "Data Source=" + config.Servername + ";Initial Catalog=" + config.Database + ";User ID=" + config.Username + ";Password=" + config.Password;
                string sql = "SELECT name FROM sys.databases";
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    adapter.Fill(dt);
                }
                return dt;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }
    }
}
