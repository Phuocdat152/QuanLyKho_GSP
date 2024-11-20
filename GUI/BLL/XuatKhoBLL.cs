using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BLL
{
    public class XuatKhoBLL
    {
        private XuatKhoDAL xuatKhoDAL;

        public XuatKhoBLL(string username, string password)
        {
            xuatKhoDAL = new XuatKhoDAL(username, password);
        }

        public DataTable HienThiThongTinKhoDen()
        {

                return xuatKhoDAL.HienThiThongTinKhoDen();         
        }

        public DataTable LayThongTinThuocXuatTheoID(string idThuoc, int soLuongYeuCau)
        {
            return xuatKhoDAL.LayThongTinThuocXuatTheoID(idThuoc, soLuongYeuCau);
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
            // Gọi phương thức từ lớp XuatKhoDAL
            return xuatKhoDAL.ThemPhieuXuat(
                ngayXuat,
                idKho,
                idKhoDen,
                idNhanVien,
                ghiChu,
                tongTien,
                trangThai,
                chiTietPhieuXuat
            );
        }

        public DataTable GetDanhSachPhieuXuat()
        {
           
                return xuatKhoDAL.HienThiPhieuXuat();            
        }

        public DataTable LayChiTietTheoIDPhieuXuat(string idPhieuXuat)
        {

            return xuatKhoDAL.HienThiChiTietTheoIDPhieuXuat(idPhieuXuat);
        }

        public DataSet LayThongTinPhieuXuatTheoID(string idPhieuXuat)
        {

                return xuatKhoDAL.LayThongTinPhieuXuatTheoID(idPhieuXuat);
            
        }

    }
}
