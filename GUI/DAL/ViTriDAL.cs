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

        public bool TaoKhuKeO(int soLuongKhu, int soLuongKe, int soLuongO)
        {
            try
            {
                // Thiết lập các tham số đầu vào cho thủ tục
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@SoLuongKhu", SqlDbType.Int) { Value = soLuongKhu },
                    new SqlParameter("@SoLuongKe", SqlDbType.Int) { Value = soLuongKe },
                    new SqlParameter("@SoLuongO", SqlDbType.Int) { Value = soLuongO }
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
    }
}
