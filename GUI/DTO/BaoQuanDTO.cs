using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoQuanDTO
    {
        public string IDBaoQuan { get; set; }
        public string NhietDo { get; set; }
        public string DoAm { get; set; }
        public string AnhSang { get; set; }

        public BaoQuanDTO() { }

        public BaoQuanDTO(string idBaoQuan, string nhietDo, string doAm, string anhSang)
        {
            IDBaoQuan = idBaoQuan;
            NhietDo = nhietDo;
            DoAm = doAm;
            AnhSang = anhSang;
        }
    }
}
