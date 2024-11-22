using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhMucThuocDTO
    {
        public string IDDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }
        public string LoaiThuoc { get; set; } // Thuộc tính mới

        public DanhMucThuocDTO() { }

        public DanhMucThuocDTO(string idDanhMuc, string tenDanhMuc, string loaiThuoc)
        {
            IDDanhMuc = idDanhMuc;
            TenDanhMuc = tenDanhMuc;
            LoaiThuoc = loaiThuoc; // Khởi tạo thuộc tính mới
        }
    }
}
