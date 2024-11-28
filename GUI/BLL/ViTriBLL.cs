using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ViTriBLL
    {
        private ViTriDAL viTriDAL;

        public ViTriBLL(string username, string password)
        {
            viTriDAL = new ViTriDAL(username, password);
        }

        public bool TaoKhuKeO(int soLuongKhu, int soLuongKe, int soLuongO, string loaiKhu)
        {
            return viTriDAL.TaoKhuKeO(soLuongKhu, soLuongKe, soLuongO, loaiKhu);
        }


        public DataTable GetThongTinViTri()
        {

                return viTriDAL.GetThongTinViTri();
            
        }

        public DataTable GetViTriTheoLoaiKhuNhap()
        {
            return viTriDAL.GetViTriTheoLoaiKhuNhap();
        }

        public DataTable GetViTriTheoLoaiKhuHuy()
        {
            return viTriDAL.GetViTriTheoLoaiKhuHuy();
        }

        public (string IDKhoMoi, string TenKhoMoi) TaoKhoMoi()
        {
                return  viTriDAL.TaoKhoMoiVaKhuKeO();
            
        }

        public DataTable GetThongTinViTri1()
        {

                return viTriDAL.GetThongTinViTri1(); // Lấy dữ liệu từ DAL           
        }

        public DataTable GetThongTinViTriTheoKho(string selectedIDKho)
        {
            return viTriDAL.GetThongTinViTriTheoKho(selectedIDKho);
        }


        public DataTable GetViTriTheoLoaiThuocThuong(string loaiThuoc)
        {

                // Gọi ViTriDAL để lấy dữ liệu vị trí theo loại thuốc thường
                return viTriDAL.GetViTriTheoLoaiThuocThuong(loaiThuoc);
            
        }

        public DataTable GetViTriTheoLoaiThuocKSDB(string loaiThuoc)
        {

                // Gọi ViTriDAL để lấy dữ liệu vị trí theo loại thuốc kiểm soát đặc biệt
                return viTriDAL.GetViTriTheoLoaiThuocKSDB(loaiThuoc);
          
        }

        public DataTable GetViTriTheoLoaiThuoc(string loaiThuoc)
        {
            // Gọi ViTriDAL để lấy dữ liệu vị trí theo loại thuốc
            return viTriDAL.GetViTriTheoLoaiThuoc(loaiThuoc);
        }


    }
}
