using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaCungCapBLL
    {
        private NhaCungCapDAL nhaCungCapDAL;

        public NhaCungCapBLL(string username, string password)
        {
            nhaCungCapDAL = new NhaCungCapDAL(username, password);
        }

        public Dictionary<string, string> GetAllTenNhaCC()
        {
            try
            {
                return nhaCungCapDAL.GetAllTenNhaCC();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách tên nhà cung cấp từ DAL: " + ex.Message);
            }
        }

        public void AddNhaCungCap(NhaCungCapDTO nhaCungCap)
        {
            try
            {
                nhaCungCapDAL.AddNhaCungCap(nhaCungCap);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in BLL while adding supplier: " + ex.Message);
            }
        }
        public DataTable GetAllNhaCungCap()
        {
            try
            {
                return nhaCungCapDAL.GetAllNhaCungCap();
            }
            catch (Exception ex)
            {
                throw new Exception("Error in BLL while fetching supplier data: " + ex.Message);
            }
        }
        public void SuaNhaCungCap(NhaCungCapDTO nhaCungCap)
        {
            try
            {
                nhaCungCapDAL.SuaNhaCungCap(nhaCungCap);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BLL khi sửa nhà cung cấp: " + ex.Message);
            }
        }


    }
}
