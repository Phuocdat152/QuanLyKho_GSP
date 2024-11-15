using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LuuTruDTO
    {
        public string IDLuuTru { get; set; }
        public string IDThuoc { get; set; }
        public string IDChiTietPhieuNhap { get; set; }
        public int SLton {  get; set; }
        public DateTime NgayNhap { get; set; }
        public string IDViTri {  get; set; }
        public string TrangThai { get; set; }

        public LuuTruDTO() { }

        public LuuTruDTO(string iDLuuTru, string iDThuoc, string iDChiTietPhieuNhap, int sLton, DateTime ngayNhap, string iDViTri, string trangThai)
        {
            this.IDLuuTru = iDLuuTru;
            this.IDThuoc = iDThuoc;
            this.IDChiTietPhieuNhap = iDChiTietPhieuNhap;
            this.SLton = sLton;
            this.NgayNhap = ngayNhap;
            this.IDViTri = iDViTri;
            this.TrangThai = trangThai;
        }
    }
}
