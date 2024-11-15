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
    public class ThuocDAL
    {
        private DataConnect dataConnect;

        // Khởi tạo lớp DataConnect với username và password
        public ThuocDAL(string username, string password)
        {
            dataConnect = new DataConnect(username, password);
        }
        public DataTable GetThuocIDVaTen()
        {
            try
            {
                // Gọi thủ tục lưu trữ "sp_HienThiIDVaTenThuoc"
                return dataConnect.GetData("sp_GetThuocInfo", null);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi gọi thủ tục lưu trữ: " + ex.Message);
                return null;
            }
        }
        public string GenerateNewIDThuoc()
        {
            DataTable dt = dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetLastIDThuoc");
            if (dt.Rows.Count > 0)
            {
                string lastID = dt.Rows[0]["IDThuoc"].ToString();
                int number = int.Parse(lastID.Substring(2)) + 1;
                return "TH" + number.ToString("D4");
            }
            return "TH0001";
        }

        // Lấy danh sách đơn vị tính
        public DataTable GetDVT()
        {
            return dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetDVT");
        }

        // Lấy danh sách danh mục
        public DataTable GetDanhMuc()
        {
            return dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetDanhMuc");
        }

        // Thêm thuốc
        public void AddThuoc(ThuocDTO thuoc)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@IDThuoc", thuoc.IDThuoc),
                new SqlParameter("@TenThuoc", thuoc.TenThuoc),
                new SqlParameter("@IDDVT", thuoc.IDDVT),
                new SqlParameter("@DonGia", thuoc.DonGia),
                new SqlParameter("@IDDanhMuc", thuoc.IDDanhMuc),
                new SqlParameter("@NuocSanXuat", thuoc.NuocSanXuat),
                new SqlParameter("@IDBaoQuan", thuoc.IDBaoQuan),
                new SqlParameter("@IDLoaiKT", thuoc.IDLoaiKT) // Tham số IDLoaiKT
            };

            dataConnect.ExecuteStoredProcedure("sp_AddThuoc", parameters);
        }

        public DataTable GetLoaiKiemTra()
        {
            return dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetLoaiKiemTra");
        }
        public DataTable GetAllThuoc()
        {
            return dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetAllThuoc");
        }
        public bool CheckConnection()
        {
            return dataConnect.CheckConnection();
        }
        public DataTable GetThuocByDanhMuc(string idDanhMuc)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDDanhMuc", string.IsNullOrEmpty(idDanhMuc) ? (object)DBNull.Value : idDanhMuc)
            };
            return dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetThuocByDanhMuc", parameters);
        }
        public DataTable SearchThuoc(string keyword)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Keyword", keyword)
            };
            return dataConnect.ExecuteStoredProcedureWithDataTable("sp_SearchThuoc", parameters);
        }
        public DataTable SearchThuocByDanhMucAndKeyword(string keyword, string idDanhMuc)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Keyword", keyword),
                new SqlParameter("@IDDanhMuc", string.IsNullOrEmpty(idDanhMuc) ? (object)DBNull.Value : idDanhMuc)
            };
            return dataConnect.ExecuteStoredProcedureWithDataTable("sp_SearchThuoc", parameters);
        }
        public bool UpdateThuoc(string idThuoc, string tenThuoc, string idDVT, float donGia, string idDanhMuc, string nuocSanXuat)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@IDThuoc", idThuoc),
                new SqlParameter("@TenThuoc", tenThuoc),
                new SqlParameter("@IDDVT", idDVT),
                new SqlParameter("@DonGia", donGia),
                new SqlParameter("@IDDanhMuc", idDanhMuc),
                new SqlParameter("@NuocSanXuat", nuocSanXuat)
            };

            try
            {
                int result = dataConnect.ExecuteStoredProcedure("sp_UpdateThuoc", parameters);
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating Thuoc: " + ex.Message);
                return false;
            }
        }

        public bool UpdateBaoQuan(string idBaoQuan, string nhietDo, string doAm, string anhSang)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@IDBaoQuan", idBaoQuan),
                new SqlParameter("@NhietDo", nhietDo),
                new SqlParameter("@DoAm", doAm),
                new SqlParameter("@AnhSang", anhSang)
            };

            try
            {
                int result = dataConnect.ExecuteStoredProcedure("sp_UpdateBaoQuan", parameters);
                return result > 0; // Trả về true nếu có dòng bị ảnh hưởng
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating BaoQuan: " + ex.Message);
                return false;
            }
        }
        public ThuocDTO GetThuocByID(string idThuoc)
        {
            SqlParameter[] parameters = { new SqlParameter("@IDThuoc", idThuoc) };
            DataTable result = dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetThuocByID", parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return new ThuocDTO
                {
                    IDThuoc = row["IDThuoc"].ToString(),
                    TenThuoc = row["TenThuoc"].ToString(),
                    IDDVT = row["IDDVT"].ToString(),
                    DonGia = Convert.ToSingle(row["DonGia"]),
                    IDDanhMuc = row["IDDanhMuc"].ToString(),
                    NuocSanXuat = row["NuocSanXuat"].ToString()
                };
            }

            return null;
        }
    }
}
