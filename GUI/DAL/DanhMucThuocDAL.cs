using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DanhMucThuocDAL
    {
        private DataConnect _dataConnect;

        public DanhMucThuocDAL(string username, string password)
        {
            _dataConnect = new DataConnect(username, password);
        }

        public int AddDanhMucThuoc(DanhMucThuocDTO danhMuc)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@IDDanhMuc", danhMuc.IDDanhMuc),
                new SqlParameter("@TenDanhMuc", danhMuc.TenDanhMuc)
            };
            return _dataConnect.ExecuteStoredProcedure("sp_AddDanhMucThuoc", parameters);
        }

        public string GenerateNewIDDanhMuc()
        {
            DataTable result = _dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetLastIDDanhMuc");
            if (result.Rows.Count > 0)
            {
                string lastID = result.Rows[0]["IDDanhMuc"].ToString();
                int newIDNum = int.Parse(lastID.Substring(2)) + 1;
                return "DM" + newIDNum.ToString("D4");
            }
            else
            {
                return "DM0001";
            }
        }

        public DataTable GetAllDanhMucThuoc()
        {
            return _dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetAllDanhMucThuoc");
        }
        public bool IsDuplicateTenDanhMuc(string tenDanhMuc)
        {
            string query = "SELECT COUNT(*) FROM DanhMucThuoc WHERE UPPER(TenDanhMuc) = UPPER(@TenDanhMuc)";
            SqlParameter[] parameters = { new SqlParameter("@TenDanhMuc", tenDanhMuc) };
            int count = (int)_dataConnect.ExecuteScalar(query, parameters);
            return count > 0;
        }
        public int UpdateDanhMuc(string maDanhMuc, string tenDanhMucMoi)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@IDDanhMuc", maDanhMuc),
                new SqlParameter("@TenDanhMuc", tenDanhMucMoi)
            };
            return _dataConnect.ExecuteStoredProcedure("sp_UpdateDanhMucThuoc", parameters);
        }

        public int DeleteDanhMuc(string maDanhMuc)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@IDDanhMuc", maDanhMuc)
            };
            return _dataConnect.ExecuteStoredProcedure("sp_DeleteDanhMucThuoc", parameters);
        }


    }
}