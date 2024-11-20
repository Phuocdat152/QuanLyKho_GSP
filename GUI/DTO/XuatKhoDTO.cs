using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class XuatKhoDTO
    {
        public string IDPhieuXuat {  get; set; }
        public DateTime NgayXuat { get; set; }
        public string IDKho {  get; set; }
        public string IDKhoDen {  get; set; }
        public string IDNhanVien {  get; set; }
        public float TongTien {  get; set; }
        public string TrangThai { get; set; }
        public string GhiChu {  get; set; }

        public XuatKhoDTO() { }

        public XuatKhoDTO(string iDPhieuXuat, DateTime ngayXuat, string iDKho, string iDKhoDen, string iDNhanVien, float tongTien, string trangThai, string ghiChu)
        {
            this.IDPhieuXuat = iDPhieuXuat;
            this.NgayXuat = ngayXuat;
            this.IDKho = iDKho;
            this.IDKhoDen = iDKhoDen;
            this.IDNhanVien = iDNhanVien;
            this.TongTien = tongTien;
            this.TrangThai = trangThai;
            this.GhiChu = ghiChu;
        }
    }
}
