using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class XuatKhoDAL
    {
        private DataConnect dataConnect;

        public XuatKhoDAL(string username, string password)
        {
            dataConnect = new DataConnect(username, password);
        }

        public DataTable HienThiThongTinKhoDen()
        {
            try
            {
                return dataConnect.ExecuteStoredProcedureWithDataTable("sp_HienThiThongTinKhoDen");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi hiển thị thông tin Kho Đến: " + ex.Message);
            }
        }


        public DataTable LayThongTinThuocXuatTheoID(string idThuoc, int soLuongYeuCau)
        {
            try
            {
                // Khai báo các tham số cho stored procedure
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDThuoc", idThuoc),
                    new SqlParameter("@SoLuongYeuCau", soLuongYeuCau)
                };

                // Gọi stored procedure và trả về kết quả dưới dạng DataTable
                return dataConnect.ExecuteStoredProcedureWithDataTable("sp_LayThongTinThuocXuatTheoID", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("" + ex.Message);
            }
        }

        public bool ThemPhieuXuat(
            DateTime ngayXuat,
            string idKho,
            string idKhoDen,
            string idNhanVien,
            string ghiChu,
            float tongTien,
            string trangThai,
            DataTable chiTietPhieuXuat)
        {
            try
            {
                // Tạo danh sách tham số cho stored procedure
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@NgayXuat", SqlDbType.Date) { Value = ngayXuat },
                    new SqlParameter("@IDKho", SqlDbType.NVarChar) { Value = idKho },
                    new SqlParameter("@IDKhoDen", SqlDbType.NVarChar) { Value = idKhoDen },
                    new SqlParameter("@IDNhanVien", SqlDbType.NVarChar) { Value = idNhanVien },
                    new SqlParameter("@GhiChu", SqlDbType.NVarChar) { Value = ghiChu },
                    new SqlParameter("@TongTien", SqlDbType.Float) { Value = tongTien },
                    new SqlParameter("@TrangThai", SqlDbType.NVarChar) { Value = trangThai },
                    new SqlParameter("@ChiTietPhieuXuat", SqlDbType.Structured)
                    {
                        TypeName = "ChiTietPhieuXuatType",
                        Value = chiTietPhieuXuat
                    }
                };

                // Gọi stored procedure
                int result = dataConnect.ExecuteStoredProcedure("sp_ThemPhieuXuat", parameters);

                // Trả về true nếu thêm thành công
                return result == 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm phiếu xuất: " + ex.Message);
            }
        }

        public DataTable HienThiPhieuXuat()
        {
            try
            {
                // Gọi stored procedure `sp_HienThiPhieuXuat` và trả về DataTable
                return dataConnect.ExecuteStoredProcedureWithDataTable("sp_HienThiPhieuXuat");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi hiển thị phiếu xuất: " + ex.Message);
            }
        }

        public DataTable HienThiChiTietTheoIDPhieuXuat(string idPhieuXuat)
        {
            try
            {
                // Tạo tham số đầu vào cho stored procedure
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDPhieuXuat", SqlDbType.NVarChar)
                    {
                        Value = idPhieuXuat
                    }
                };

                // Gọi stored procedure và trả về DataTable
                return dataConnect.ExecuteStoredProcedureWithDataTable("sp_HienThiChiTietTheoIDPhieuXuat", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi gọi stored procedure sp_HienThiChiTietTheoIDPhieuXuat: " + ex.Message);
            }
        }

        public DataSet LayThongTinPhieuXuatTheoID(string idPhieuXuat)
        {
            try
            {
                // Khởi tạo tham số cho stored procedure
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDPhieuXuat", SqlDbType.NVarChar) { Value = idPhieuXuat }
                };

                // Gọi stored procedure và trả về DataSet
                return dataConnect.ExecuteStoredProcedureWithDataSet("sp_LayThongTinPhieuXuatTheoID", parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin phiếu xuất: " + ex.Message);
            }
        }

    }
}
