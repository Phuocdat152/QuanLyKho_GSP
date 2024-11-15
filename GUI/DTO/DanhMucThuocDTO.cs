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

        public DanhMucThuocDTO() { }

        public DanhMucThuocDTO(string idDanhMuc, string tenDanhMuc)
        {
            IDDanhMuc = idDanhMuc;
            TenDanhMuc = tenDanhMuc;
        }
    }
}