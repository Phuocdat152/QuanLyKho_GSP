using System;

public class UserDTO
{
    public string MaNhanVienID { get; set; }
    public string TenNhanVien { get; set; }
    public string ChucVuID { get; set; } // Thêm thuộc tính ChucVuID
    public string Username { get; set; }
    public DateTime NgaySinh { get; set; }
    public string DiaChi { get; set; }
    public string Email { get; set; }
    public string SoDienThoai { get; set; }
    public string TrinhDo { get; set; }
    public string ChucVu { get; set; } // Tên chức vụ
    public byte[] Anh { get; set; }

    public UserDTO() { }

    public UserDTO(string maNhanVienID, string tenNhanVien, string chucVuID, string username,
        DateTime ngaySinh, string diaChi, string email, string soDienThoai,
        string trinhDo, string chucVu, byte[] anh)
    {
        MaNhanVienID = maNhanVienID;
        TenNhanVien = tenNhanVien;
        ChucVuID = chucVuID; // Gán giá trị cho thuộc tính ChucVuID
        Username = username;
        NgaySinh = ngaySinh;
        DiaChi = diaChi;
        Email = email;
        SoDienThoai = soDienThoai;
        TrinhDo = trinhDo;
        ChucVu = chucVu; // Gán tên chức vụ
        Anh = anh;
    }
}
