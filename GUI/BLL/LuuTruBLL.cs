﻿using DAL;
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
        private string _username;
        private string _password;
        public LuuTruBLL(string username, string password)
        {
            _username = username;
            _password = password;
            luuTruDAL = new LuuTruDAL(username, password);
        }

        public DataTable HienThiTatCaChiTietNhapKho()
        {
            // Gọi LuuTruDAL để lấy tất cả chi tiết nhập kho
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
        public DataTable TraCuuThuocTheoTenThuoc(string tenThuoc)
        {

            return luuTruDAL.TraCuuThuocTheoTen(tenThuoc);           
        }

        // Gọi DAL để tra cứu thuốc theo khoảng thời gian
        public DataTable TraCuuThuocTheoKhoangThoiGian(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return luuTruDAL.TraCuuThuocTheoKhoangThoiGian(ngayBatDau, ngayKetThuc);
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

        public void CapNhatTrangThaiThuoc(string idLuuTru, string trangThai)
        {
            
                luuTruDAL.CapNhatTrangThaiThuoc(idLuuTru, trangThai);
           
        }


        public void UpdateAndSetLuuTruAsEmpty()
        {
           
                luuTruDAL.UpdateAndSetLuuTruAsEmpty();      
        }
        public DataTable GetStoredMedicines()
        {
            return luuTruDAL.GetStoredMedicines();
        }
        public DataTable LayThuocTheoTen(string tenThuoc)
        {
            return luuTruDAL.LayThuocTheoTen(tenThuoc);
        }

        public DataTable SearchMedicineByName(string tenThuoc)
        {
            LuuTruDAL luuTruDAL = new LuuTruDAL(_username, _password);
            return luuTruDAL.LayThuocTheoTen(tenThuoc);
        }
        public DataTable LayThuocTheoKhoangThoiGian(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return luuTruDAL.LayThuocTheoKhoangThoiGian(ngayBatDau, ngayKetThuc);
        }


    }
}
