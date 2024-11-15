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
    public class LuuTruBLL
    {
        private LuuTruDAL luuTruDAL;

        public LuuTruBLL(string username, string password)
        {
            luuTruDAL = new LuuTruDAL(username, password);
        }

        public DataTable HienThiTatCaChiTietNhapKho()
        {

                return luuTruDAL.HienThiTatCaChiTietNhapKho();
        }

        //Thêm Lưu trữ
        public bool ThemLuuTru(string idThuoc, string idChiTietPhieuNhap, int slTon, DateTime ngayNhap, string idViTri)
        {
            return luuTruDAL.ThemLuuTru(idThuoc, idChiTietPhieuNhap, slTon, ngayNhap, idViTri);
        }

        //Hiển thị lưu trữ
        public DataTable HienThiThongTinLuuTru()
        {

            return luuTruDAL.HienThiThongTinLuuTru();
        }


        public List<string> GetSavedIDChiTietPhieuNhap()
        {
            return luuTruDAL.GetSavedIDChiTietPhieuNhap();
        }

        //Hiển thị tra cứu
        public DataTable HienThiThongTinTraCuu()
        {

            return luuTruDAL.HienThiThongTinTraCuu();
        }

        //Tra cứu theo IDthuoc
        public DataTable TraCuuThuocTheoIDThuoc(string idThuoc)
        {

                return luuTruDAL.TraCuuThuocTheoIDThuoc(idThuoc);           
        }

        //Tra cứu theo Ngày hết hạn
        public DataTable TraCuuThuocTheoNgayHetHan(DateTime ngayHetHan)
        {

            return luuTruDAL.TraCuuThuocTheoNgayHetHan(ngayHetHan);
        }

        //Tra cứu thuốc theo trạng thái
        public DataTable TraCuuThuocTheoTrangThai(string trangThai)
        {

            return luuTruDAL.TraCuuThuocTheoTrangThai(trangThai);
        }

        //Kiểm tra ngày hết hạn
        public DataTable KiemTraThuocSapHetHan()
        {
            return luuTruDAL.KiemTraThuocSapHetHan();
        }
    }
}
