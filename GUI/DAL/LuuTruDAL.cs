using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LuuTruDAL
    {
        private DataConnect dataConnect;

        public LuuTruDAL(string username, string password)
        {
            dataConnect = new DataConnect(username, password);
        }

        public DataTable HienThiTatCaChiTietNhapKho()
        {
            try
            {
                return dataConnect.ExecuteStoredProcedureWithDataSet("sp_HienThiTatCaChiTietNhapKho").Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi hiển thị tất cả chi tiết nhập kho: " + ex.Message);
            }
        }



        //Thêm lưu trữ 
        public bool ThemLuuTru(string idThuoc, string idChiTietPhieuNhap, int slTon, DateTime ngayNhap, string idViTri)
        {
            try
            {
                // Khai báo các tham số cho thủ tục
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDThuoc", idThuoc),
                    new SqlParameter("@IDChiTietPhieuNhap", idChiTietPhieuNhap),
                    new SqlParameter("@SLton", slTon),
                    new SqlParameter("@NgayNhap", ngayNhap),
                    new SqlParameter("@IDViTri", idViTri)
                };

                // Thực thi thủ tục và kiểm tra kết quả
                int result = dataConnect.ExecuteStoredProcedure("sp_ThemLuuTru", parameters);
                return result >= 0; // Nếu thực thi thành công sẽ trả về true
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm lưu trữ: " + ex.Message);
                return false;
            }
        }

        //Hiển thị lưu trữ
        public DataTable HienThiThongTinLuuTru()
        {
            try
            {
                // Gọi stored procedure "sp_HienThiThongTinLuuTru" và lấy kết quả
                return dataConnect.ExecuteStoredProcedureWithDataTable("sp_HienThiThongTinLuuTru");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi hiển thị thông tin lưu trữ: " + ex.Message);
            }
        }



        public List<string> GetSavedIDChiTietPhieuNhap()
        {
            List<string> savedIDs = new List<string>();
            string query = "SELECT DISTINCT IDChiTietPhieuNhap FROM LuuTru";

            DataTable dataTable = dataConnect.GetData(query);

            foreach (DataRow row in dataTable.Rows)
            {
                savedIDs.Add(row["IDChiTietPhieuNhap"].ToString());
            }

            return savedIDs;
        }


        public DataTable HienThiThongTinTraCuu()
        {
            try
            {
                // Gọi stored procedure "sp_HienThiThongTinLuuTru" và lấy kết quả
                return dataConnect.ExecuteStoredProcedureWithDataTable("sp_HienThiThongTinTraCuu");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi hiển thị thông tin lưu trữ: " + ex.Message);
            }
        }

        //Tra cứu thuốc theo tên thuốc
        public DataTable TraCuuThuocTheoTen(string tenThuoc)
        {
            string query = "sp_TraCuuThuocTheoTenThuocLuuTru";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@TenThuoc", tenThuoc)
            };
            return dataConnect.ExecuteStoredProcedureWithDataTable(query, parameters);
        }


        // Hàm gọi stored procedure sp_TraCuuThuocTheoKhoangThoiGian
        public DataTable TraCuuThuocTheoKhoangThoiGian(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            try
            {
                // Tên stored procedure
                string storedProcedure = "sp_TraCuuThuocTheoKhoangThoiGian";

                // Tham số đầu vào cho stored procedure
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@NgayBatDau", SqlDbType.Date) { Value = ngayBatDau },
                    new SqlParameter("@NgayKetThuc", SqlDbType.Date) { Value = ngayKetThuc }
                };

                // Gọi stored procedure và lấy dữ liệu trả về dưới dạng DataTable
                return dataConnect.ExecuteStoredProcedureWithDataTable(storedProcedure, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tra cứu thuốc theo khoảng thời gian: " + ex.Message);
            }
        }


        //Tra cứu theo trạng thái
        public DataTable TraCuuThuocTheoTrangThai(string trangThai)
        {
            try
            {
                // Khai báo tham số cho stored procedure
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@TrangThai", trangThai)
                };

                // Gọi stored procedure và trả về kết quả dưới dạng DataTable
                return dataConnect.ExecuteStoredProcedureWithDataTable("sp_TraCuuThuocTheoTrangThai", parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tra cứu thông tin thuốc: " + ex.Message);
                return null;
            }
        }

        //Kiểm tra ngày hết hạn
        public DataTable KiemTraThuocSapHetHan()
        {
            try
            {
                // Tạo câu truy vấn lấy danh sách thuốc sắp hết hạn trong vòng 1 tháng
                string query = @"
                    SELECT 
                        lt.IDLuuTru,
                        lt.IDChiTietPhieuNhap,
                        lt.IDThuoc,
                        t.TenThuoc,
                        lt.NgayNhap,
                        ctpn.NgayHetHan,
                        lt.TrangThai
                    FROM 
                        LuuTru lt
                    INNER JOIN 
                        Thuoc t ON lt.IDThuoc = t.IDThuoc
                    INNER JOIN 
                        ChiTietPhieuNhap ctpn ON lt.IDChiTietPhieuNhap = ctpn.IDChiTietPhieuNhap
                    WHERE 
                        DATEDIFF(day, GETDATE(), ctpn.NgayHetHan) <= 30 
                        AND DATEDIFF(day, GETDATE(), ctpn.NgayHetHan) >= 0"; // Kiểm tra trong vòng 1 tháng tới

                // Truy vấn dữ liệu
                return dataConnect.GetData(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi kiểm tra thuốc sắp hết hạn: " + ex.Message);
                return null;
            }
        }

        public void CapNhatTrangThaiThuoc(string idLuuTru, string trangThai)
        {
            try
            {
                string query = "UPDATE LuuTru SET TrangThai = @TrangThai WHERE IDLuuTru = @IDLuuTru";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@TrangThai", trangThai),
            new SqlParameter("@IDLuuTru", idLuuTru)
                };

                dataConnect.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật trạng thái thuốc: " + ex.Message);
            }
        }

        public void UpdateAndSetLuuTruAsEmpty()
        {
            try
            {
                // Gọi stored procedure sp_UpdateAndSetLuuTruAsEmpty
                dataConnect.ExecuteStoredProcedure("sp_UpdateAndSetLuuTruAsEmpty");
            }
            catch (Exception ex)
            {
                throw new Exception("Error while executing stored procedure sp_UpdateAndSetLuuTruAsEmpty: " + ex.Message);
            }
        }

    }
}
