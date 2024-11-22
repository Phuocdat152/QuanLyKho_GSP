using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhuDTO
    {
        public string IDKho { get; set; }
        public string IDKhu {  get; set; }
        public string TenKhu {  get; set; } 
        public string LoaiKhu {  get; set; }

        public KhuDTO() { }

        public KhuDTO(string iDKho, string iDKhu, string tenKhu, string ghiChu, string loaiKhu)
        {
            this.IDKho = iDKho;
            this.IDKhu = iDKhu;
            this.TenKhu = tenKhu;
            this.LoaiKhu = loaiKhu;
        }
    }
}
