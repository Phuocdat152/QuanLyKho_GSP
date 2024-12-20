﻿using System;
using System.Data.SqlClient;

namespace DAL
{
    public class SaoLuuPhucHoiDAL
    {
        private DataConnect dataConnect;

        public SaoLuuPhucHoiDAL(string username, string password)
        {
            dataConnect = new DataConnect(username, password);
        }

        public void BackupDatabase(string backupFilePath)
        {
            string query = $"BACKUP DATABASE QuanLyGSP TO DISK = @BackupFile";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BackupFile", backupFilePath)
            };

            dataConnect.ExecuteNonQuery(query, parameters);
        }
        public void RestoreDatabase(string restoreFilePath)
        {
            try
            {
                // Tạm thời thay đổi kết nối sang cơ sở dữ liệu master
                dataConnect.ExecuteNonQuery("USE master;");

                // Thực hiện lệnh phục hồi
                string query = @"
            ALTER DATABASE QuanLyGSP SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
            RESTORE DATABASE QuanLyGSP FROM DISK = @RestoreFile WITH REPLACE;
            ALTER DATABASE QuanLyGSP SET MULTI_USER;";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@RestoreFile", restoreFilePath)
                };

                dataConnect.ExecuteNonQuery(query, parameters);

                // Khôi phục lại kết nối về QuanLyGSPPP sau khi phục hồi xong
                dataConnect.ExecuteNonQuery("USE QuanLyGSP;");
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing restore operation: " + ex.Message);
            }
        }

    }
}
