using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class UserDAL
    {
        private DataConnect dataConnect;

        // Khởi tạo UserDAL với thông tin đăng nhập động
        public UserDAL(string username, string password)
        {
            dataConnect = new DataConnect(username, password);
        }
        public DataTable GetAllNhanVienWithChucVu()
        {
            return dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetAllNhanVienWithChucVu");
        }


        // Lấy thông tin user bằng username
        public UserDTO GetUserByUsername(string username)
        {
            string query = "sp_GetAllNhanVienWithChucVu"; // Giả sử stored procedure này trả về tên chức vụ
            SqlParameter[] parameters = { new SqlParameter("@Username", username) };
            DataTable result = dataConnect.ExecuteStoredProcedureWithDataTable(query, parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return new UserDTO(
                    row["IDNhanVien"].ToString(),
                    row["TenNhanVien"].ToString(),
                    row["IDChucVu"].ToString(), // ID của chức vụ
                    row["Username"].ToString(),
                    DateTime.Parse(row["NgaySinh"].ToString()),
                    row["DiaChi"].ToString(),
                    row["Email"].ToString(),
                    row["SoDienThoai"].ToString(),
                    row["TrinhDo"].ToString(),
                    row["ChucVu"].ToString(), // Tên chức vụ từ bảng ChucVu
                    row["Anh"] == DBNull.Value ? null : (byte[])row["Anh"]
                );
            }
            return null;
        }
        public UserDTO GetNhanVienByUsername(string username)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@Username", username) };
                DataTable result = dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetNhanVienByUsername", parameters);

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];
                    return new UserDTO
                    {
                        MaNhanVienID = row["IDNhanVien"].ToString(),
                        TenNhanVien = row["TenNhanVien"].ToString()
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin nhân viên theo Username: " + ex.Message);
            }

        }


        public UserDTO GetUserById(string maNhanVien)
        {
            SqlParameter[] parameters = { new SqlParameter("@MaNhanVien", maNhanVien) };
            DataTable result = dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetNhanVienById", parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return new UserDTO(
                    row["IDNhanVien"].ToString(),
                    row["TenNhanVien"].ToString(),
                    row["IDChucVu"].ToString(), // ID chức vụ
                    row["Username"].ToString(),
                    DateTime.Parse(row["NgaySinh"].ToString()),
                    row["DiaChi"].ToString(),
                    row["Email"].ToString(),
                    row["SoDienThoai"].ToString(),
                    row["TrinhDo"].ToString(),
                    row["ChucVu"].ToString(), // Tên chức vụ từ bảng ChucVu
                    row["Anh"] == DBNull.Value ? null : (byte[])row["Anh"]
                );
            }
            return null;
        }
        public DataTable GetAllChucVu()
        {
            return dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetAllChucVu");
        }
        public bool UpdateNhanVien2(string maNhanVien, string idChucVu)
        {
            SqlParameter[] parameters = {
        new SqlParameter("@IDNhanVien", maNhanVien),
        new SqlParameter("@IDChucVu", idChucVu)
    };

            int result = dataConnect.ExecuteStoredProcedure("sp_UpdateNhanVien2", parameters);
            return result > 0;
        }

        public UserDTO GetNhanVienById(string maNhanVien)
        {
            SqlParameter[] parameters = { new SqlParameter("@MaNhanVien", maNhanVien) };
            DataTable result = dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetNhanVienById2", parameters);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return new UserDTO(
                    row["IDNhanVien"].ToString(),
                    row["TenNhanVien"].ToString(),
                    null, // Không cần ID chức vụ
                    row["Username"].ToString(),
                    DateTime.MinValue, // Không cần ngày sinh
                    null, // Không cần địa chỉ
                    null, // Không cần email
                    null, // Không cần số điện thoại
                    null, // Không cần trình độ
                    row["ChucVu"].ToString(), // Lấy tên chức vụ
                    null // Không cần ảnh
                );
            }
            return null;
        }

        public DataTable GetChucVuList()
        {
            string query = "SELECT IDChucVu, TenChucVu FROM ChucVu";
            return dataConnect.GetData(query);
        }


        public bool UpdateNhanVien(UserDTO user)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@IDNhanVien", user.MaNhanVienID),
                new SqlParameter("@TenNhanVien", user.TenNhanVien),
                new SqlParameter("@IDChucVu", user.ChucVuID),
                new SqlParameter("@NgaySinh", user.NgaySinh),
                new SqlParameter("@DiaChi", user.DiaChi),
                new SqlParameter("@Email", user.Email),
                new SqlParameter("@SoDienThoai", user.SoDienThoai),
                new SqlParameter("@TrinhDo", user.TrinhDo),
                new SqlParameter("@Anh", user.Anh)
            };

            int result = dataConnect.ExecuteStoredProcedure("sp_UpdateNhanVien", parameters);
            return result >= 0; // Trả về true nếu cập nhật thành công
        }


        public string GetNextNhanVienId()
        {
            string lastId = null;
            DataTable result = dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetLastNhanVienId");

            if (result.Rows.Count > 0)
            {
                lastId = result.Rows[0]["IDNhanVien"].ToString();
            }

            if (!string.IsNullOrEmpty(lastId))
            {
                // Giả sử mã nhân viên có định dạng NVxxxx, tách phần số và tăng lên 1
                int number = int.Parse(lastId.Substring(2)) + 1;
                return "NV" + number.ToString("D4"); // Định dạng số thành 4 chữ số với tiền tố "NV"
            }

            // Nếu không có mã nào trong CSDL, bắt đầu từ NV0001
            return "NV0001";
        }


        // Thêm user bằng stored procedure
        public int AddUserWithProcedure(UserDTO user, string password)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@TenNhanVien", user.TenNhanVien),
                new SqlParameter("@IDChucVu", user.ChucVuID),
                new SqlParameter("@Password", password),
                new SqlParameter("@NgaySinh", user.NgaySinh),
                new SqlParameter("@DiaChi", user.DiaChi),
                new SqlParameter("@Email", user.Email),
                new SqlParameter("@SoDienThoai", user.SoDienThoai),
                new SqlParameter("@TrinhDo", user.TrinhDo),
                new SqlParameter("@Anh", user.Anh)
            };
            return dataConnect.ExecuteStoredProcedure("sp_AddNhanVien", parameters);
        }


        public DataTable GetAllUsers()
        {
            return dataConnect.GetData("sp_GetUserData", null);
        }
        // Kiểm tra trùng tên đăng nhập hoặc login
        public bool CheckDuplicateUsernameOrLogin(string username)
        {
            SqlParameter[] parameters = { new SqlParameter("@Username", username) };
            int result = dataConnect.ExecuteStoredProcedure("sp_CheckDuplicateUsernameOrLogin", parameters);
            return result == -1 || result == -2;
        }

        // Xóa user bằng stored procedure
        public bool DeleteUser(string maNhanVien, string username)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@MaNhanVien", maNhanVien),
                new SqlParameter("@Username", username)
            };

            try
            {
                int result = dataConnect.ExecuteStoredProcedure("sp_DeleteNhanVien", parameters);
                return result == 0; // Trả về true nếu xóa thành công
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa nhân viên: " + ex.Message);
                return false; // Trả về false nếu có lỗi
            }
        }

        // Thay đổi mật khẩu user
        public bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@OldPassword", oldPassword),
                new SqlParameter("@NewPassword", newPassword)
            };

            try
            {
                int result = dataConnect.ExecuteStoredProcedure("sp_ChangePassword", parameters);
                return result == 0; // Trả về true nếu đổi mật khẩu thành công, false nếu thất bại
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đổi mật khẩu: " + ex.Message);
                return false;
            }
        }
        public bool UpdatePassword(string username, string newPassword)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@NewPassword", newPassword)
            };

            int result = dataConnect.ExecuteStoredProcedure("sp_UpdatePassword", parameters);
            return result == 0; // Trả về true nếu thành công
        }
        public bool DoiMatKhau(string username, string oldPassword, string newPassword)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@OldPassword", oldPassword),
                new SqlParameter("@NewPassword", newPassword)
            };

            try
            {
                int result = dataConnect.ExecuteStoredProcedure("sp_DoiMatKhau", parameters);
                return result == 0; // Trả về true nếu đổi mật khẩu thành công, false nếu thất bại
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đổi mật khẩu: " + ex.Message);
                return false;
            }
        }

        //Hiển thị ID và tên Nhân viên
        public Dictionary<string, string> GetIDAndTenNhanVien()
        {
            Dictionary<string, string> tenNVList = new Dictionary<string, string>();

            try
            {
                DataTable dataTable = dataConnect.GetData("sp_HienThiIDVaTenNhanVien");

                foreach (DataRow row in dataTable.Rows)
                {
                    string idNhanVien = row["IDNhanVien"].ToString();
                    string tenNhanVien = row["TenNhanVien"].ToString();
                    tenNVList.Add(idNhanVien, tenNhanVien);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi gọi stored procedure sp_HienThiIDVaTenNhanVien: " + ex.Message);
            }

            return tenNVList;
        }
        public bool CheckDuplicateNhanVien(string maNhanVien, string username)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@IDNhanVien", maNhanVien),
                new SqlParameter("@Username", username)
            };
            int result = dataConnect.ExecuteStoredProcedure("sp_CheckDuplicateNhanVien", parameters);

            return result != 0; // Trả về true nếu có trùng lặp
        }

        public string GetTenNhanVien(string username)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@Username", username)
                };

                DataTable dt = dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetTenNhanVien", parameters);

                if (dt != null && dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["TenNhanVien"].ToString();
                }
                return string.Empty;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy tên nhân viên: " + ex.Message);
            }
        }


        public DataRow GetNhanVienByUsername1(string username)
        {
            try
            {
                string query = "sp_GetNhanVienByUsername";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@Username", username)
                };

                DataTable result = dataConnect.ExecuteStoredProcedureWithDataTable(query, parameters);
                if (result.Rows.Count > 0)
                {
                    return result.Rows[0]; // Trả về dòng đầu tiên chứa thông tin nhân viên
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin nhân viên: " + ex.Message);
            }
        }
        public DataTable GetAllNhanVienWithChucVuSimple()
        {
            return dataConnect.ExecuteStoredProcedureWithDataTable("sp_GetAllNhanVienWithChucVu2");
        }
        public bool ResetUserPassword(string username, string newPassword)
        {
            SqlParameter[] parameters = {
        new SqlParameter("@Username", username),
        new SqlParameter("@NewPassword", newPassword)
    };

            try
            {
                int result = dataConnect.ExecuteStoredProcedure("sp_ResetUserPassword", parameters);
                return result == 0; // Thành công nếu trả về 0
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đặt lại mật khẩu: " + ex.Message);
            }
        }

        public bool ChangeLoginPassword(string username, string oldPassword, string newPassword)
        {
            SqlParameter[] parameters = {
        new SqlParameter("@Username", username),
        new SqlParameter("@OldPassword", oldPassword),
        new SqlParameter("@NewPassword", newPassword)
    };

            try
            {
                int result = dataConnect.ExecuteStoredProcedure("sp_DoiMatKhauLogin", parameters);
                return result == 0; // Trả về true nếu đổi mật khẩu thành công
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đổi mật khẩu: " + ex.Message);
            }
        }




        public string GetUserRole(string username)
        {
            try
            {
                // Câu truy vấn để lấy chức vụ
                string query = @"
                    SELECT c.TenChucVu 
                    FROM NhanVien n
                    JOIN ChucVu c ON n.IDChucVu = c.IDChucVu
                    WHERE n.Username = @Username";

                // Tham số cho truy vấn
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Username", username)
                };

                // Sử dụng ExecuteScalar để lấy kết quả
                object role = dataConnect.ExecuteScalar(query, parameters);

                return role?.ToString(); // Trả về tên chức vụ
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy chức vụ người dùng: " + ex.Message);
            }
        }
    }
}
