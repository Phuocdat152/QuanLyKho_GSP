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

        public DataTable HienThiThongTinThuocHuy()
        {
            try
            {
                // Gọi stored procedure và trả về DataTable
                return dataConnect.ExecuteStoredProcedureWithDataTable("sp_HienThiThongTinThuocHuy");
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi hiển thị thông tin thuốc hủy: {ex.Message}");
            }
        }

        public int CapNhatTinhTrangThuocHuy()
        {
            try
            {
                // Gọi stored procedure
                return dataConnect.ExecuteStoredProcedure("sp_CapNhatTinhTrangThuocHuy");
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật trạng thái thuốc hủy: {ex.Message}");
            }
        }
    }
}
