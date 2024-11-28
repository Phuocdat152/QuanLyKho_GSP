using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ViTriDAL
    {
        private DataConnect dataConnect;

        public ViTriDAL(string username, string password)
        {
            // Khởi tạo DataConnect với thông tin đăng nhập
            dataConnect = new DataConnect(username, password);
        }

        public bool TaoKhuKeO(int soLuongKhu, int soLuongKe, int soLuongO, string loaiKhu)
        {
            try
            {
                // Thiết lập các tham số đầu vào cho thủ tục
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@SoLuongKhu", SqlDbType.Int) { Value = soLuongKhu },
            new SqlParameter("@SoLuongKe", SqlDbType.Int) { Value = soLuongKe },
            new SqlParameter("@SoLuongO", SqlDbType.Int) { Value = soLuongO },
            new SqlParameter("@LoaiKhu", SqlDbType.NVarChar, 50) { Value = loaiKhu }
                };

                // Gọi thủ tục lưu trữ `sp_TaoKhuKeO_TrongKhoK0001` và thực thi
                int result = dataConnect.ExecuteStoredProcedure("sp_TaoKhuKeO_TrongKhoK0001", parameters);

                // Kiểm tra kết quả trả về
                return result == 0; // Thực hiện thành công nếu kết quả trả về là 0
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi gọi thủ tục sp_TaoKhuKeO_TrongKhoK0001: " + ex.Message);
                return false; // Thực hiện thất bại
            }
        }


        public DataTable GetThongTinViTri()
        {
            try
            {
                // Sử dụng phương thức ExecuteStoredProcedureWithDataSet để gọi stored procedure `sp_HienThiThongTinViTri`
                DataSet ds = dataConnect.ExecuteStoredProcedureWithDataSet("sp_HienThiThongTinViTri");

                // Kiểm tra và trả về DataTable đầu tiên từ DataSet
                if (ds != null && ds.Tables.Count > 0)
                {
                    return ds.Tables[0];
                }
                else
                {
                    throw new Exception("Không có dữ liệu trả về từ stored procedure.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin vị trí: " + ex.Message);
            }
        }

        public DataTable GetViTriTheoLoaiKhuNhap()
        {
            try
            {
                // Gọi stored procedure
                return dataConnect.ExecuteStoredProcedureWithDataTable("sp_HienThiThongTinViTriTheoLoaiKhuNhap");
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy thông tin vị trí theo loại khu nhập: {ex.Message}");
            }
        }

        public DataTable GetViTriTheoLoaiKhuHuy()
        {
            try
            {
                // Gọi stored procedure
                return dataConnect.ExecuteStoredProcedureWithDataTable("sp_HienThiThongTinViTriTheoLoaiKhuHuy");
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy thông tin vị trí theo loại khu hủy: {ex.Message}");
            }
        }

        public (string IDKhoMoi, string TenKhoMoi) TaoKhoMoiVaKhuKeO()
        {
            try
            {
                // Gọi stored procedure
                DataTable result = dataConnect.ExecuteStoredProcedureWithDataTable("sp_TaoKhoMoiVaKhuKeO");

                // Kiểm tra kết quả trả về
                if (result != null && result.Rows.Count > 0)
                {
                    string idKhoMoi = result.Rows[0]["IDKhoMoi"].ToString();
                    string tenKhoMoi = result.Rows[0]["TenKhoMoi"].ToString();
                    return (idKhoMoi, tenKhoMoi);
                }
                else
                {
                    throw new Exception("Không có dữ liệu trả về từ stored procedure.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tạo kho mới: {ex.Message}");
            }
        }

        public DataTable GetThongTinViTri1()
        {
            string query = @"
        SELECT
            v.IDViTri,
            k.IDKho,
            k.LoaiKho AS TenKho,
            khu.IDKhu,
            khu.TenKhu,
            ke.IDKe,
            ke.TenKe,
            o.IDO,
            o.TenO,
            o.TrangThai
        FROM
            ViTri v
        INNER JOIN Khu khu ON v.IDKhu = khu.IDKhu
        INNER JOIN Kho k ON khu.IDKho = k.IDKho
        INNER JOIN Ke ke ON v.IDKe = ke.IDKe
        INNER JOIN O o ON v.IDO = o.IDO;";

            return dataConnect.GetData(query);
        }


        public DataTable GetThongTinViTriTheoKho(string selectedIDKho)
        {
            string query = @"
        SELECT
            v.IDViTri,
            k.IDKho,
            k.LoaiKho AS TenKho,
            khu.IDKhu,
            khu.TenKhu,
            ke.IDKe,
            ke.TenKe,
            o.IDO,
            o.TenO,
            o.TrangThai
        FROM
            ViTri v
        INNER JOIN Khu khu ON v.IDKhu = khu.IDKhu
        INNER JOIN Kho k ON khu.IDKho = k.IDKho
        INNER JOIN Ke ke ON v.IDKe = ke.IDKe
        INNER JOIN O o ON v.IDO = o.IDO
        WHERE k.IDKho = @IDKho";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@IDKho", SqlDbType.NVarChar) { Value = selectedIDKho }
            };

            return dataConnect.GetData(query, parameters);
        }


        public DataTable GetViTriTheoLoaiThuocThuong(string loaiThuoc)
        {
            try
            {
                // Gọi Stored Procedure sp_HienThiThongTinViTri_TheoLoaiThuocThuong
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@LoaiThuoc", SqlDbType.NVarChar) { Value = loaiThuoc }
                };

                return dataConnect.ExecuteStoredProcedureWithDataTable("sp_HienThiThongTinViTri_TheoLoaiThuocThuong", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin vị trí theo loại thuốc thường: " + ex.Message);
            }
        }

        public DataTable GetViTriTheoLoaiThuocKSDB(string loaiThuoc)
        {
            try
            {
                // Gọi Stored Procedure sp_HienThiThongTinViTri_TheoLoaiThuocKSDB
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@LoaiThuoc", SqlDbType.NVarChar) { Value = loaiThuoc }
                };

                return dataConnect.ExecuteStoredProcedureWithDataTable("sp_HienThiThongTinViTri_TheoLoaiThuocKSDB", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin vị trí theo loại thuốc KSĐB: " + ex.Message);
            }
        }


        public DataTable GetViTriTheoLoaiThuoc(string loaiThuoc)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@LoaiThuoc", SqlDbType.NVarChar) { Value = loaiThuoc }
                };

                // Kiểm tra loại thuốc và gọi stored procedure tương ứng
                if (loaiThuoc == "Thuốc thường")
                {
                    return dataConnect.ExecuteStoredProcedureWithDataTable("sp_HienThiThongTinViTri_TheoLoaiThuocThuong", parameters);
                }
                else if (loaiThuoc == "Thuốc kiểm soát đặc biệt")
                {
                    return dataConnect.ExecuteStoredProcedureWithDataTable("sp_HienThiThongTinViTri_TheoLoaiThuocKSDB", parameters);
                }
                else
                {
                    throw new Exception("Loại thuốc không hợp lệ.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin vị trí theo loại thuốc: " + ex.Message);
            }
        }




    }
}
