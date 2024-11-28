using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SaoLuuPhucHoiBLL
    {
        private SaoLuuPhucHoiDAL saoLuuPhucHoiDAL;

        public SaoLuuPhucHoiBLL(string username, string password)
        {
            saoLuuPhucHoiDAL = new SaoLuuPhucHoiDAL(username, password);
        }

        public void BackupDatabase(string backupFilePath)
        {
            saoLuuPhucHoiDAL.BackupDatabase(backupFilePath);
        }
        public void RestoreDatabase(string restoreFilePath)
        {
            saoLuuPhucHoiDAL.RestoreDatabase(restoreFilePath);
        }

    }
}
