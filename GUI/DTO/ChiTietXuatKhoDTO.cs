using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietXuatKhoDTO
    {
        public string IDChiTietPhieuXuat {  get; set; }
        public string IDPhieuXuat { get; set; }
        public string IDLuuTru {  get; set; }
        public string IDThuoc {  get; set; }
        public string DVT {  get; set; }
        public int SoLuong {  get; set; }
        public float GiaDonVi {  get; set; }
        public float ThanhTien {  get; set; }

        public ChiTietXuatKhoDTO() { }
        public ChiTietXuatKhoDTO(string iDChiTietPhieuXuat, string iDPhieuXuat, string iDLuuTru, string iDThuoc, string dVT, int soLuong, float giaDonVi, float thanhTien)
        {
            this.IDChiTietPhieuXuat = iDChiTietPhieuXuat;
            this.IDPhieuXuat = iDPhieuXuat;
            this.IDLuuTru = iDLuuTru;
            this.IDThuoc = iDThuoc;
            this.DVT = dVT;
            this.SoLuong = soLuong;
            this.GiaDonVi = giaDonVi;
            this.ThanhTien = thanhTien;
        }
    }
}
