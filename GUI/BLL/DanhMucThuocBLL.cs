using DAL;
using DTO;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class DanhMucThuocBLL
    {
        private DanhMucThuocDAL _danhMucThuocDAL;

        public DanhMucThuocBLL(string username, string password)
        {
            _danhMucThuocDAL = new DanhMucThuocDAL(username, password);
        }

        public bool AddDanhMucThuoc(DanhMucThuocDTO danhMuc)
        {
            // Kiểm tra trùng tên danh mục thuốc
            if (_danhMucThuocDAL.IsDuplicateTenDanhMuc(danhMuc.TenDanhMuc))
            {
                MessageBox.Show("Tên danh mục đã tồn tại. Vui lòng chọn tên khác.");
                return false;
            }

            // Thêm danh mục thuốc
            danhMuc.IDDanhMuc = _danhMucThuocDAL.GenerateNewIDDanhMuc();
            return _danhMucThuocDAL.AddDanhMucThuoc(danhMuc) > 0;
        }
        public bool IsDuplicateTenDanhMuc(string tenDanhMuc)
        {
            return _danhMucThuocDAL.IsDuplicateTenDanhMuc(tenDanhMuc);
        }

        public string GetNewIDDanhMuc()
        {
            return _danhMucThuocDAL.GenerateNewIDDanhMuc();
        }

        public DataTable GetAllDanhMucThuoc()
        {
            return _danhMucThuocDAL.GetAllDanhMucThuoc();
        }
        public bool UpdateDanhMuc(string maDanhMuc, string tenDanhMucMoi)
        {
            return _danhMucThuocDAL.UpdateDanhMuc(maDanhMuc, tenDanhMucMoi) > 0;
        }
        public bool DeleteDanhMuc(string maDanhMuc)
        {
            return _danhMucThuocDAL.DeleteDanhMuc(maDanhMuc) > 0;
        }


    }
}