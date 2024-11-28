using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BackUpRestoreConnect
    {
        private string connectionString;

        public BackUpRestoreConnect(string username, string password)
        {
            connectionString = $"Server=NARIZMUSIC\\CHOCOPRO;Database=QuanLyGSPPP;User Id={username};Password={password};";
        }

        public bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public void BackupDatabase(string databaseName, string backupPath)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string backupQuery = $"BACKUP DATABASE [{databaseName}] TO DISK = @backupPath";

                using (SqlCommand cmd = new SqlCommand(backupQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@backupPath", backupPath);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
