using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoDenDTO
    {
        public string IDKhoDen {  get; set; }
        public string TenKhoDen { get; set; }
        public string SDT { get; set; }
        public string DiaChi {  get; set; }
        public string Email {  get; set; }

        public KhoDenDTO() { }
        public KhoDenDTO(string iDKhoDen, string tenKhoDen, string sDT, string diaChi, string email)
        {
            this.IDKhoDen = iDKhoDen;
            this.TenKhoDen = tenKhoDen;
            this.SDT = sDT;
            this.DiaChi = diaChi;
            this.Email = email;
        }
    }
}
