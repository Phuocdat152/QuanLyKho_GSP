using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OBLL
    {
        private ODAL oDAL;

        public OBLL(string username, string password)
        {
            oDAL = new ODAL(username, password);
        }

        public DataTable GetOByKe(string idKe)
        {
            return oDAL.HienThiTheoKe(idKe);
        }
    }
}
