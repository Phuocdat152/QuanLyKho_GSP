using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThuocHuyBLL
    {
        private readonly ThuocHuyDAL thuocHuyDAL;

        public ThuocHuyBLL(string username, string password)
        {
            thuocHuyDAL = new ThuocHuyDAL(username, password);
        }

        public string ThemThuocHuy(string idThuoc, string idLuuTru, string idViTri, int soLuongHuy, string lyDoHuy, DateTime ngayHuy, string tinhTrang, string ghiChu)
        {
            try
            {
                // Gọi phương thức từ ThuocHuyDAL
                return thuocHuyDAL.ThemThuocHuy(idThuoc, idLuuTru, idViTri, soLuongHuy, lyDoHuy, ngayHuy, tinhTrang, ghiChu);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi BLL khi thêm thuốc hủy: {ex.Message}");
            }
        }

        public DataTable HienThiThongTinThuocHuy_ChoHuy()
        {
            return thuocHuyDAL.HienThiThongTinThuocHuy_ChuaHuy();
        }

        public DataTable HienThiThongTinThuocHuy_DaHuy()
        {
            return thuocHuyDAL.HienThiThongTinThuocHuy_DaHuy();
        }

        public bool CapNhatTinhTrangThuocHuy(string idThuocHuy, string tinhTrangMoi)
        {
            
                return thuocHuyDAL.CapNhatTinhTrangThuocHuy(idThuocHuy, tinhTrangMoi);          
        }
    }
}
