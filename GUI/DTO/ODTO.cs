using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ODTO
    {
        public string IDO { get; set; }
        public string IDKe { get; set; }
        public string TenO { get; set; }
        public string TrangThai { get; set; }

        public ODTO() { }

        public ODTO(string iDO, string iDKe, string tenO, string trangThai)
        {
            this.IDO = iDO;
            this.IDKe = iDKe;
            this.TenO = tenO;
            this.TrangThai = trangThai;
        }
    }
}
