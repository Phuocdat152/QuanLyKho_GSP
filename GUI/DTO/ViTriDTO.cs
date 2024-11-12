using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ViTriDTO
    {
        public string IDViTri { get; set; }
        public string IDKhu {  get; set; }
        public string IDKe {  get; set; }
        public string IDO {  get; set; }

        public ViTriDTO() { }   

        public ViTriDTO(string iDViTri, string iDKhu, string iDKe, string iDO)
        {
            this.IDViTri = iDViTri;
            this.IDKhu = iDKhu;
            this.IDKe = iDKe;
            this.IDO = iDO;
        }
    }
}
