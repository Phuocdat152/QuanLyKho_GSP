using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThuocDTO
    {
        public string IDThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string IDDVT { get; set; }
        public float DonGia { get; set; }
        public string IDDanhMuc { get; set; }
        public string NuocSanXuat { get; set; }
        public string IDBaoQuan { get; set; }
        public int SoLuong { get; set; } // Thêm thuộc tính SoLuong
        public string IDLoaiKT { get; set; } // Thêm thuộc tính IDLoaiKT

        public ThuocDTO() { }
        public ThuocDTO(string idThuoc, string tenThuoc, string idDVT, float donGia, string idDanhMuc, string nuocSanXuat, string idBaoQuan, string idLoaiKT)
        {
            IDThuoc = idThuoc;
            TenThuoc = tenThuoc;
            IDDVT = idDVT;
            DonGia = donGia;
            IDDanhMuc = idDanhMuc;
            NuocSanXuat = nuocSanXuat;
            IDBaoQuan = idBaoQuan;
            IDLoaiKT = idLoaiKT;
        }
        public ThuocDTO(string idThuoc, string tenThuoc, string idDVT, float donGia, string idDanhMuc, string nuocSanXuat, string idBaoQuan, int soLuong)
        {
            IDThuoc = idThuoc;
            TenThuoc = tenThuoc;
            IDDVT = idDVT;
            DonGia = donGia;
            IDDanhMuc = idDanhMuc;
            NuocSanXuat = nuocSanXuat;
            IDBaoQuan = idBaoQuan;
            SoLuong = soLuong; // Gán giá trị SoLuong
        }
        public ThuocDTO(string idThuoc, string tenThuoc, string idDVT, float donGia, string idDanhMuc, string nuocSanXuat, string idBaoQuan)
        {
            IDThuoc = idThuoc;
            TenThuoc = tenThuoc;
            IDDVT = idDVT;
            DonGia = donGia;
            IDDanhMuc = idDanhMuc;
            NuocSanXuat = nuocSanXuat;
            IDBaoQuan = idBaoQuan; // Gán giá trị SoLuong
        }
        public ThuocDTO(string iDThuoc, string tenThuoc, string iDDVT, float donGia)
        {
            this.IDThuoc = iDThuoc;
            this.TenThuoc = tenThuoc;
            this.IDDVT = iDDVT;
            this.DonGia = donGia;
        }
    }
}
