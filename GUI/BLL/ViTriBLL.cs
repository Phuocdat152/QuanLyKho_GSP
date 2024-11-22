using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ViTriBLL
    {
        private ViTriDAL viTriDAL;

        public ViTriBLL(string username, string password)
        {
            viTriDAL = new ViTriDAL(username, password);
        }

        public bool TaoKhuKeO(int soLuongKhu, int soLuongKe, int soLuongO, string loaiKhu)
        {
            return viTriDAL.TaoKhuKeO(soLuongKhu, soLuongKe, soLuongO, loaiKhu);
        }


        public DataTable GetThongTinViTri()
        {

                return viTriDAL.GetThongTinViTri();
            
        }

        public DataTable GetViTriTheoLoaiKhuNhap()
        {
            return viTriDAL.GetViTriTheoLoaiKhuNhap();
        }

        public DataTable GetViTriTheoLoaiKhuHuy()
        {
            return viTriDAL.GetViTriTheoLoaiKhuHuy();
        }
    }
}
