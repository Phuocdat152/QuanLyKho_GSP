using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BaoQuanBLL
    {
        private BaoQuanDAL baoQuanDAL;

        public BaoQuanBLL(string username, string password)
        {
            baoQuanDAL = new BaoQuanDAL(username, password);
        }

        // Lấy mã bảo quản mới
        public string GenerateNewIDBaoQuan()
        {
            return baoQuanDAL.GenerateNewIDBaoQuan();
        }

        // Thêm bảo quản
        public void AddBaoQuan(BaoQuanDTO baoQuan)
        {
            baoQuanDAL.AddBaoQuan(baoQuan);
        }
        public BaoQuanDTO GetBaoQuanByID(string idBaoQuan)
        {
            return baoQuanDAL.GetBaoQuanByID(idBaoQuan);
        }
    }

}
