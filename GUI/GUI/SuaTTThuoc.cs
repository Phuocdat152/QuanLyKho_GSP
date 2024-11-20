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

        public SuaTTThuoc(string maThuoc, string username, string password)
        {
            InitializeComponent();
            _username = username;
            _password = password;
            _maThuoc = maThuoc;
            thuocBLL = new ThuocBLL(_username, _password);
            baoQuanBLL = new BaoQuanBLL(_username, _password);

            // Lấy IDBaoQuan từ cơ sở dữ liệu
            _idBaoQuan = thuocBLL.GetBaoQuanIDByThuocID(_maThuoc);

            LoadComboBoxData();
            LoadFormData();
        }








        private void LoadComboBoxData()
        {
            // Tải danh sách đơn vị tính
            DataTable dvtData = thuocBLL.GetAllDVT();
            cb_DVT.DataSource = dvtData;
            cb_DVT.DisplayMember = "TenDVT";
            cb_DVT.ValueMember = "IDDVT";

            // Tải danh sách danh mục thuốc
            DataTable danhMucData = thuocBLL.GetAllDanhMucThuoc();
            cb_DanhMucThuoc.DataSource = danhMucData;
            cb_DanhMucThuoc.DisplayMember = "TenDanhMuc";
            cb_DanhMucThuoc.ValueMember = "IDDanhMuc";
        }
        private void LoadFormData()
        {
            ThuocDTO thuoc = thuocBLL.GetThuocChiTiet(_maThuoc);
            if (thuoc == null)
            {
                MessageBox.Show("Không tìm thấy thông tin thuốc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Hiển thị thông tin thuốc
            txt_suaMaThuoc.Text = thuoc.IDThuoc;
            txt_suaTenThuoc.Text = thuoc.TenThuoc;
            txt_ThanhPhan.Text = thuoc.ThanhPhan; // Hiển thị thông tin thành phần
            cb_DVT.SelectedValue = thuoc.IDDVT;
            txt_DonGia.Text = thuoc.DonGia.ToString();
            cb_DanhMucThuoc.SelectedValue = thuoc.IDDanhMuc;
            cb_NSX.Text = thuoc.NuocSanXuat;

            // Hiển thị thông tin bảo quản
            var baoQuan = baoQuanBLL.GetBaoQuanByID(thuoc.IDBaoQuan);
            if (baoQuan != null)
            {
                nup_NhietDo.Value = Convert.ToDecimal(baoQuan.NhietDo);
                nup_DoAm.Value = Convert.ToDecimal(baoQuan.DoAm);
                txt_AnhSang.Text = baoQuan.AnhSang;
            }
        }


        private void btn_LuuThuoc_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn lưu các thay đổi này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                SaveThuocData();
            }

        }
        private void SaveThuocData()
        {
            try
            {
                // Tạo đối tượng BaoQuanDTO
                var baoQuan = new BaoQuanDTO
                {
                    IDBaoQuan = _idBaoQuan, // Lấy từ cơ sở dữ liệu
                    NhietDo = nup_NhietDo.Value.ToString(),
                    DoAm = nup_DoAm.Value.ToString(),
                    AnhSang = txt_AnhSang.Text.Trim()
                };

                // Tạo đối tượng ThuocDTO
                var thuoc = new ThuocDTO
                {
                    IDThuoc = txt_suaMaThuoc.Text.Trim(),
                    TenThuoc = txt_suaTenThuoc.Text.Trim(),
                    ThanhPhan = txt_ThanhPhan.Text.Trim(), // Lưu thông tin thành phần
                    IDDVT = cb_DVT.SelectedValue?.ToString(),
                    DonGia = float.Parse(txt_DonGia.Text.Trim()),
                    IDDanhMuc = cb_DanhMucThuoc.SelectedValue?.ToString(),
                    NuocSanXuat = cb_NSX.Text.Trim()
                };


                // Gọi phương thức cập nhật thông tin bảo quản
                bool isBaoQuanUpdated = baoQuanBLL.UpdateBaoQuan(baoQuan);

                // Gọi phương thức cập nhật thông tin thuốc
                bool isThuocUpdated = thuocBLL.UpdateThuoc(thuoc);

                // Kiểm tra kết quả
                if (isBaoQuanUpdated && isThuocUpdated)
                {
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi lưu thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadBaoQuanID()
        {
            _idBaoQuan = thuocBLL.GetBaoQuanIDByThuocID(_maThuoc);

            if (string.IsNullOrEmpty(_idBaoQuan))
            {
                MessageBox.Show("Không tìm thấy ID bảo quản cho thuốc này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void SuaTTThuoc_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
