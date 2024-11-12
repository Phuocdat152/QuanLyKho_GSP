using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ODAL
    {
        private DataConnect dataConnect;

        public ODAL(string username, string password)
        {
            dataConnect = new DataConnect(username, password);
        }

        public DataTable HienThiTheoKe(string idKe)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@IDKe", idKe)
                };

                return dataConnect.GetData("sp_HienThiOTheoKe", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching data for O by Ke: " + ex.Message);
            }
        }

    }
}
