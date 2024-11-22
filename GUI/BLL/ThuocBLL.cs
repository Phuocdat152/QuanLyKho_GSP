using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThuocBLL
    {
        private ThuocDAL thuocDAL;

        // Khởi tạo đối tượng ThuocDAL
        public ThuocBLL(string username, string password)
        {
            thuocDAL = new ThuocDAL(username, password);
        }

        // Lấy danh sách IDThuoc và TenThuoc
        public DataTable GetThuocInfo()
        {
            try
            {
                // Gọi phương thức từ ThuocDAL để lấy dữ liệu
                return thuocDAL.GetThuocIDVaTen();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách thuốc: " + ex.Message);
                return null;
            }
        }
        public string GenerateNewIDThuoc()
        {
            return thuocDAL.GenerateNewIDThuoc();
        }

        // Lấy danh sách đơn vị tính
        public DataTable GetDVT()
        {
            return thuocDAL.GetDVT();
        }

        // Lấy danh sách danh mục
        public DataTable GetDanhMuc()
        {
            return thuocDAL.GetDanhMuc();
        }

        // Thêm thuốc
        public void AddThuoc(ThuocDTO thuoc)
        {
            thuocDAL.AddThuoc(thuoc);
        }
        public DataTable GetLoaiKiemTra()
        {
            return thuocDAL.GetLoaiKiemTra();
        }
        public DataTable GetAllThuoc()
        {
            return thuocDAL.GetAllThuoc();
        }
        public bool CheckConnection()
        {
            return thuocDAL.CheckConnection();
        }
        public DataTable GetThuocByDanhMuc(string idDanhMuc)
        {
            return thuocDAL.GetThuocByDanhMuc(idDanhMuc);
        }
        public DataTable SearchThuoc(string keyword)
        {
            return thuocDAL.SearchThuoc(keyword);
        }
        public DataTable SearchThuoc(string keyword, string idDanhMuc = null)
        {
            return thuocDAL.SearchThuocByDanhMucAndKeyword(keyword, idDanhMuc);
        }
        public bool UpdateThuoc(ThuocDTO thuoc)
        {
            return thuocDAL.UpdateThuoc(
                thuoc.IDThuoc,
                thuoc.TenThuoc,
                thuoc.ThanhPhan, // Truyền thêm ThanhPhan
                thuoc.IDDVT,
                thuoc.DonGia,
                thuoc.IDDanhMuc,
                thuoc.NuocSanXuat
            );
        }

        public string GetBaoQuanIDByThuocID(string idThuoc)
        {
            return thuocDAL.GetBaoQuanIDByThuocID(idThuoc);
        }



        public ThuocDTO GetThuocByID(string idThuoc)
        {
            return thuocDAL.GetThuocByID(idThuoc);
        }
        public ThuocDTO GetThuocChiTiet(string idThuoc)
        {
            return thuocDAL.GetThuocChiTiet(idThuoc);
        }

        public DataTable GetAllDVT()
        {
            return thuocDAL.GetAllDVT();
        }

        public DataTable GetAllDanhMucThuoc()
        {
            return thuocDAL.GetAllDanhMucThuoc();
        }
        public DataTable GetThuocByLoaiKT(string idLoaiKT)
        {
            return thuocDAL.GetThuocByLoaiKT(idLoaiKT);
        }
        public DataTable GetThuocWithKiemTra(string idLoaiKT)
        {
            try
            {
                return thuocDAL.GetThuocWithKiemTra(idLoaiKT);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu thuốc với kiểm tra: " + ex.Message);
            }
        }
        public string GenerateNewIDKiemTra()
        {
            return thuocDAL.GenerateNewIDKiemTra();
        }
        public string GetIDLuuTruByThuocID(string idThuoc)
        {
            return thuocDAL.GetIDLuuTruByThuocID(idThuoc);
        }
        public void SaveKiemTra(string idKiemTra, DateTime ngayKT, string idLuuTru, string idThuoc, string tinhTrang, int slThucTe, int slTon, string idLoaiKT, string nhanVienKT)
        {
            thuocDAL.SaveKiemTra(idKiemTra, ngayKT, idLuuTru, idThuoc, tinhTrang, slThucTe, slTon, idLoaiKT, nhanVienKT);
        }
        public DataTable GetDanhSachKiemKe()
        {
            try
            {
                return thuocDAL.GetDanhSachKiemKe();
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
                return thuocDAL.GetThuocToKiemKe(idLoaiKT, currentDate);
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
                thuocDAL.UpdateSoLuongTon(idThuoc, slTon); // Gọi phương thức từ DAL
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật số lượng tồn kho: " + ex.Message);
            }
        }
        public DataTable GetDanhSachKiemKeByLoaiKT(string idLoaiKT)
        {
            return thuocDAL.GetDanhSachKiemKeByLoaiKT(idLoaiKT);
        }




    }
}
