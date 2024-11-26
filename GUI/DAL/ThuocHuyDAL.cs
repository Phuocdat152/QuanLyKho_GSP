using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThuocHuyDAL
    {
        private readonly DataConnect dataConnect;

        public ThuocHuyDAL(string username, string password)
        {
            dataConnect = new DataConnect(username, password);
        }

        public string ThemThuocHuy(string idThuoc, string idLuuTru, string idViTri, int soLuongHuy, string lyDoHuy, DateTime ngayHuy, string tinhTrang, string ghiChu)
        {
            try
            {
                // Khởi tạo tham số cho stored procedure
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDThuoc", idThuoc),
                    new SqlParameter("@IDLuuTru", idLuuTru),
                    new SqlParameter("@IDViTri", idViTri),
                    new SqlParameter("@SoLuongHuy", soLuongHuy),
                    new SqlParameter("@LyDoHuy", lyDoHuy),
                    new SqlParameter("@NgayHuy", ngayHuy),
                    new SqlParameter("@TinhTrang", tinhTrang),
                    new SqlParameter("@GhiChu", ghiChu)
                };

                // Thực thi stored procedure và lấy kết quả trả về
                DataTable resultTable = dataConnect.ExecuteStoredProcedureWithDataTable("sp_ThemThuocHuy", parameters);

                if (resultTable != null && resultTable.Rows.Count > 0)
                {
                    // Lấy giá trị IDThuocHuy được tạo tự động
                    return resultTable.Rows[0]["NewIDThuocHuy"].ToString();
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm thuốc hủy: {ex.Message}");
            }
        }

        public DataTable HienThiThongTinThuocHuy_ChuaHuy()
        {
            try
            {
                // Gọi stored procedure và trả về DataTable
                return dataConnect.ExecuteStoredProcedureWithDataTable("sp_HienThiThongTinThuocHuy_ChuaHuy");
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi hiển thị thông tin thuốc hủy: {ex.Message}");
            }
        }

        public DataTable HienThiThongTinThuocHuy_DaHuy()
        {
            try
            {
                // Gọi stored procedure và trả về DataTable
                return dataConnect.ExecuteStoredProcedureWithDataTable("sp_HienThiThongTinThuocHuy_DaHuy");
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi hiển thị thông tin thuốc hủy: {ex.Message}");
            }
        }

        public bool CapNhatTinhTrangThuocHuy(string idThuocHuy, string tinhTrangMoi)
        {
            try
            {
                // Câu truy vấn SQL
                string query = "UPDATE ThuocHuy SET TinhTrang = @TinhTrangMoi WHERE IDThuocHuy = @IDThuocHuy";

                // Tạo tham số
                SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@TinhTrangMoi", tinhTrangMoi),
                new SqlParameter("@IDThuocHuy", idThuocHuy)
                };

                // Thực thi truy vấn
                int rowsAffected = dataConnect.ExecuteNonQuery(query, parameters);

                // Trả về kết quả
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật tình trạng thuốc hủy: " + ex.Message);
            }
        }
    }
}
