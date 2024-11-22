using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThuocHuyDTO
    {
        public string IDThuocHuy {  get; set; }
        public string IDthuoc {  get; set; }
        public string IDLuuTru {  get; set; }
        public string IDViTri {  get; set; }
        public string LyDoHuy {  get; set; }
        public DateTime NgayHuy { get; set; }
        public string TinhTrang {  get; set; }
        public string GhiChu {  get; set; }

        public ThuocHuyDTO() { }

        public ThuocHuyDTO(string iDThuocHuy, string iDthuoc, string iDLuuTru, string iDViTri, string lyDoHuy, DateTime ngayHuy, string tinhTrang, string ghiChu)
        {
            this.IDThuocHuy = iDThuocHuy;
            this.IDthuoc = iDthuoc;
            this.IDLuuTru = iDLuuTru;
            this.IDViTri = iDViTri;
            this.LyDoHuy = lyDoHuy;
            this.NgayHuy = ngayHuy;
            this.TinhTrang = tinhTrang;
            this.GhiChu = ghiChu;
        }
    }
}
