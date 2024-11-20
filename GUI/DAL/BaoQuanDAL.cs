using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class BaoQuanDAL
    {
        private DataConnect dataConnect;

        public BaoQuanDAL(string username, string password)
        {
            dataConnect = new DataConnect(username, password);
        }

        // Lấy mã bảo quản mới
        public string GenerateNewIDBaoQuan()
        {
            DataTable dt = dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetLastIDBaoQuan");
            if (dt.Rows.Count > 0)
            {
                string lastID = dt.Rows[0]["IDBaoQuan"].ToString();
                int number = int.Parse(lastID.Substring(2)) + 1;
                return "BQ" + number.ToString("D4");
            }
            return "BQ0001";
        }

        // Thêm bảo quản
        public void AddBaoQuan(BaoQuanDTO baoQuan)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@IDBaoQuan", baoQuan.IDBaoQuan),
                new SqlParameter("@NhietDo", baoQuan.NhietDo),
                new SqlParameter("@DoAm", baoQuan.DoAm),
                new SqlParameter("@AnhSang", baoQuan.AnhSang)
            };
            dataConnect.ExecuteStoredProcedure("sp_AddBaoQuan", parameters);
        }
        public BaoQuanDTO GetBaoQuanByID(string idBaoQuan)
        {
            SqlParameter[] parameters = { new SqlParameter("@IDBaoQuan", idBaoQuan) };
            DataTable result = dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetBaoQuanByID", parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return new BaoQuanDTO
                {
                    IDBaoQuan = idBaoQuan,
                    NhietDo = row["NhietDo"].ToString(),
                    DoAm = row["DoAm"].ToString(),
                    AnhSang = row["AnhSang"].ToString()
                };
            }

            return null;
        }
        public bool UpdateBaoQuan(string idBaoQuan, string nhietDo, string doAm, string anhSang)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@IDBaoQuan", idBaoQuan),  // Đảm bảo tham số này không null
                new SqlParameter("@NhietDo", nhietDo),
                new SqlParameter("@DoAm", doAm),
                new SqlParameter("@AnhSang", anhSang)
            };

            try
            {
                int rowsAffected = dataConnect.ExecuteStoredProcedure("sp_UpdateBaoQuan", parameters);
                return rowsAffected > 0; // Trả về true nếu cập nhật thành công
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating BaoQuan: " + ex.Message);
            }
        }





    }

}
