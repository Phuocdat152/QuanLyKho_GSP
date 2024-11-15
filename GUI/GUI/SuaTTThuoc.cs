using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SuaTTThuoc : Form
    {

        private string _username;
        private string _password;
        private string _maThuoc;
        private string _idBaoQuan;
        private BaoQuanBLL baoQuanBLL;
        private ThuocBLL thuocBLL;
        public SuaTTThuoc(string maThuoc, string idBaoQuan, string username, string password)
        {
            InitializeComponent();
            _username = username;
            _password = password;
            _maThuoc = maThuoc;
            _idBaoQuan = idBaoQuan;
            thuocBLL = new ThuocBLL(_username, _password);
            baoQuanBLL = new BaoQuanBLL(_username, _password);

            LoadFormData();
        }
        private void LoadFormData()
        {
            // Lấy thông tin thuốc dựa trên mã thuốc
            var thuoc = thuocBLL.GetThuocByID(_maThuoc);
            var baoQuan = baoQuanBLL.GetBaoQuanByID(_idBaoQuan); // Lấy thông tin bảo quản dựa trên IDBaoQuan

            if (thuoc == null || baoQuan == null)
            {
                MessageBox.Show("Không tìm thấy thông tin thuốc hoặc bảo quản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Hiển thị thông tin thuốc
            txt_suaMaThuoc.Text = thuoc.IDThuoc;
            txt_suaTenThuoc.Text = thuoc.TenThuoc;
            cb_DVT.SelectedValue = thuoc.IDDVT;
            txt_DonGia.Text = thuoc.DonGia.ToString();
            cb_DanhMucThuoc.SelectedValue = thuoc.IDDanhMuc;
            cb_NSX.Text = thuoc.NuocSanXuat;

            // Hiển thị thông tin bảo quản
            nup_NhietDo.Value = Convert.ToDecimal(baoQuan.NhietDo);
            nup_DoAm.Value = Convert.ToDecimal(baoQuan.DoAm);
            txt_AnhSang.Text = baoQuan.AnhSang;
        }


        private void btn_LuuThuoc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn lưu thay đổi không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Cập nhật thông tin từ các điều khiển trên form cho ThuocDTO
                var thuoc = new ThuocDTO
                {
                    IDThuoc = txt_suaMaThuoc.Text,
                    TenThuoc = txt_suaTenThuoc.Text,
                    IDDVT = cb_DVT.SelectedValue.ToString(),
                    DonGia = float.Parse(txt_DonGia.Text),
                    IDDanhMuc = cb_DanhMucThuoc.SelectedValue.ToString(),
                    NuocSanXuat = cb_NSX.Text
                };

                // Cập nhật thông tin từ các điều khiển trên form cho BaoQuanDTO
                var baoQuan = new BaoQuanDTO
                {
                    IDBaoQuan = _idBaoQuan,
                    NhietDo = nup_NhietDo.Value.ToString(),
                    DoAm = nup_DoAm.Value.ToString(),
                    AnhSang = txt_AnhSang.Text
                };

                // Lưu thông tin cập nhật cho thuốc và bảo quản
                bool isThuocUpdated = thuocBLL.UpdateThuoc(thuoc);
                bool isBaoQuanUpdated = thuocBLL.UpdateBaoQuan(baoQuan);

                if (isThuocUpdated && isBaoQuanUpdated)
                {
                    MessageBox.Show("Cập nhật thông tin thuốc và bảo quản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form sau khi lưu thành công
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi cập nhật thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void SuaTTThuoc_Load(object sender, EventArgs e)
        {

        }
    }
}
