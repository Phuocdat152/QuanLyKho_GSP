using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaCungCapDAL
    {
        private DataConnect dataConnect;

        public NhaCungCapDAL(string username, string password)
        {
            dataConnect = new DataConnect(username, password);
        }

        // Hàm lấy danh sách tên nhà cung cấp từ stored procedure
        public Dictionary<string, string> GetAllTenNhaCC()
        {
            Dictionary<string, string> nhaCCList = new Dictionary<string, string>();

            try
            {
                string storedProcedure = "sp_GetIDAndTenNhaCC";
                DataTable dt = dataConnect.GetData(storedProcedure); // Gọi stored procedure

                foreach (DataRow row in dt.Rows)
                {
                    string idNhaCC = row["IDNhaCC"].ToString();
                    string tenNhaCC = row["TenNhaCC"].ToString();
                    nhaCCList.Add(idNhaCC, tenNhaCC);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách tên nhà cung cấp: " + ex.Message);
            }

            return nhaCCList;
        }
        public void AddNhaCungCap(NhaCungCapDTO nhaCungCap)
        {
            try
            {
                string query = "EXEC sp_AddNhaCungCap @IDNhaCC, @TenNhaCC, @SDT, @DiaChi, @Email";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDNhaCC", nhaCungCap.IDNhaCC),
                    new SqlParameter("@TenNhaCC", nhaCungCap.TenNhaCC),
                    new SqlParameter("@SDT", nhaCungCap.SDT),
                    new SqlParameter("@DiaChi", nhaCungCap.DiaChi),
                    new SqlParameter("@Email", nhaCungCap.Email)
                };

                dataConnect.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in DAL while adding supplier: " + ex.Message);
            }
        }
        public DataTable GetAllNhaCungCap()
        {
            try
            {
                string storedProcedure = "sp_GetAllNhaCungCap";
                return dataConnect.GetData(storedProcedure); // Gọi stored procedure
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching supplier data: " + ex.Message);
            }
        }
        public void SuaNhaCungCap(NhaCungCapDTO nhaCungCap)
        {
            try
            {
                // Sử dụng phương thức ExecuteNonQuery để gọi stored procedure
                string storedProcedure = "sp_SuaNhaCungCap";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDNhaCC", nhaCungCap.IDNhaCC),
                    new SqlParameter("@TenNhaCC", nhaCungCap.TenNhaCC),
                    new SqlParameter("@SDT", nhaCungCap.SDT),
                    new SqlParameter("@DiaChi", nhaCungCap.DiaChi),
                    new SqlParameter("@Email", nhaCungCap.Email)
                };

                dataConnect.ExecuteStoredProcedure(storedProcedure, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa thông tin nhà cung cấp: " + ex.Message);
            }
        }

    }

}

