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
                new SqlParameter("@IDLoaiKT", thuoc.IDLoaiKT),
                new SqlParameter("@ThanhPhan", thuoc.ThanhPhan) // Thêm tham số ThanhPhan
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
            SqlParameter[] parameters =
            {
                new SqlParameter("@Keyword", keyword),
                new SqlParameter("@IDDanhMuc", string.IsNullOrEmpty(idDanhMuc) ? (object)DBNull.Value : idDanhMuc)
            };
            return dataConnect.ExecuteStoredProcedureWithDataTable("sp_SearchThuoc", parameters);
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
                    ThanhPhan = row["ThanhPhan"].ToString(),
                    IDDVT = row["IDDVT"].ToString(),
                    DonGia = Convert.ToSingle(row["DonGia"]),
                    IDDanhMuc = row["IDDanhMuc"].ToString(),
                    NuocSanXuat = row["NuocSanXuat"].ToString()
                };

            }

            return null;
        }
        public ThuocDTO GetThuocChiTiet(string idThuoc)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@IDThuoc", idThuoc)
            };

            // Gọi đúng phương thức qua đối tượng DataConnect
            DataTable result = dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetThuocChiTiet", parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return new ThuocDTO
                {
                    IDThuoc = row["IDThuoc"].ToString(),
                    TenThuoc = row["TenThuoc"].ToString(),
                    ThanhPhan = row["ThanhPhan"].ToString(),
                    IDDVT = row["IDDVT"].ToString(),
                    DonGia = float.Parse(row["DonGia"].ToString()),
                    IDDanhMuc = row["IDDanhMuc"].ToString(),
                    NuocSanXuat = row["NuocSanXuat"].ToString(),
                    IDBaoQuan = row["IDBaoQuan"].ToString()
                };
            }

            return null;
        }
        public bool UpdateThuoc(string idThuoc, string tenThuoc, string thanhPhan, string idDVT, float donGia, string idDanhMuc, string nuocSanXuat)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@IDThuoc", idThuoc),
                new SqlParameter("@TenThuoc", tenThuoc),
                new SqlParameter("@ThanhPhan", thanhPhan), // Tham số ThanhPhan
                new SqlParameter("@IDDVT", idDVT),
                new SqlParameter("@DonGia", donGia),
                new SqlParameter("@IDDanhMuc", idDanhMuc),
                new SqlParameter("@NuocSanXuat", nuocSanXuat)
            };

            try
            {
                int rowsAffected = dataConnect.ExecuteStoredProcedure("sp_UpdateThuoc", parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating Thuoc: " + ex.Message);
            }
        }

        public string GetBaoQuanIDByThuocID(string idThuoc)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@IDThuoc", idThuoc)
            };

            DataTable result = dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetBaoQuanIDByThuocID", parameters);

            if (result.Rows.Count > 0)
            {
                return result.Rows[0]["IDBaoQuan"].ToString();
            }

            return null; // Nếu không tìm thấy
        }



        public DataTable GetAllDVT()
        {
            // Sử dụng đối tượng dataConnect để gọi phương thức ExecuteStoredProcedureWithDataTable
            return dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetAllDVT");
        }

        public DataTable GetAllDanhMucThuoc()
        {
            return dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetAllDanhMuc");
        }
        public DataTable GetThuocByLoaiKT(string idLoaiKT)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@IDLoaiKT", idLoaiKT)
                };

                return dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetThuocByLoaiKT", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách thuốc theo loại kiểm tra: " + ex.Message);
            }
        }
        public DataTable GetThuocWithKiemTra(string idLoaiKT)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@IDLoaiKT", idLoaiKT) };
                return dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetThuocWithKiemTra", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu thuốc với kiểm tra: " + ex.Message);
            }
        }
        public string GenerateNewIDKiemTra()
        {
            DataTable dt = dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetLastIDKiemTra");
            if (dt.Rows.Count > 0)
            {
                string lastID = dt.Rows[0]["IDKiemTra"].ToString();
                int number = int.Parse(lastID.Substring(2)) + 1;
                return "KT" + number.ToString("D4");
            }
            return "KT0001";
        }
        public string GetIDLuuTruByThuocID(string idThuoc)
        {
            SqlParameter[] parameters = { new SqlParameter("@IDThuoc", idThuoc) };
            DataTable result = dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetIDLuuTruByThuocID", parameters);

            if (result.Rows.Count > 0)
            {
                return result.Rows[0]["IDLuuTru"].ToString();
            }

            return null;
        }
        public void SaveKiemTra(string idKiemTra, DateTime ngayKT, string idLuuTru, string idThuoc, string tinhTrang, int slThucTe, int slTon, string idLoaiKT, string nhanVienKT)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@IDKiemTra", idKiemTra),
                new SqlParameter("@NgayKT", ngayKT),
                new SqlParameter("@IDLuuTru", idLuuTru),
                new SqlParameter("@IDThuoc", idThuoc),
                new SqlParameter("@TinhTrang", tinhTrang),
                new SqlParameter("@SLThucTe", slThucTe),
                new SqlParameter("@SLTon", slTon),
                new SqlParameter("@IDLoaiKT", idLoaiKT),
                new SqlParameter("@NhanVienKT", nhanVienKT)
            };
            dataConnect.ExecuteStoredProcedure("sp_SaveKiemTra", parameters);
        }
        public DataTable GetDanhSachKiemKe()
        {
            try
            {
                // Gọi Stored Procedure để lấy danh sách kiểm kê
                return dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetDanhSachKiemKe");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách kiểm kê: " + ex.Message);
            }
        }
        public DataTable GetThuocToKiemKe(string idLoaiKT, DateTime currentDate)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@CurrentDate", currentDate),
                    new SqlParameter("@IDLoaiKT", idLoaiKT)
                };

                return dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetThuocToKiemKe", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách thuốc cần kiểm kê: " + ex.Message);
            }
        }
        public void UpdateSoLuongTon(string idThuoc, int slTon)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@IDThuoc", idThuoc),
                    new SqlParameter("@SLTon", slTon)
                };

                dataConnect.ExecuteStoredProcedure("sp_UpdateSoLuongTon", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật số lượng tồn kho: " + ex.Message);
            }
        }
        public DataTable GetDanhSachKiemKeByLoaiKT(string idLoaiKT)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDLoaiKT", idLoaiKT)
            };

            return dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetDanhSachKiemKeByLoaiKT", parameters);
        }



    }
}
