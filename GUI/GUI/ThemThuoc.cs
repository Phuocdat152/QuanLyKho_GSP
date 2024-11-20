using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class ThemThuoc : Form
    {
        private string _username;
        private string _password;
        private UserBLL userBLL;
        private ThuocBLL thuocBLL;
        private BaoQuanBLL baoQuanBLL;
        public ThemThuoc(string username, string password)
        {
            InitializeComponent();
            _username = username;
            _password = password;

            userBLL = new UserBLL(_username, _password);
            thuocBLL = new ThuocBLL(_username, _password);
            baoQuanBLL = new BaoQuanBLL(_username, _password);

            // Kiểm tra kết nối trước khi tải dữ liệu
            if (!userBLL.CheckConnection())
            {
                MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu. Vui lòng kiểm tra thông tin đăng nhập.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            LoadFormData();
        }


        private void ThemThuoc_Load(object sender, EventArgs e)
        {
            // Không cần tạo mới đối tượng BLL tại đây, đã có sẵn từ constructor
            LoadFormData();
        }

        private void LoadFormData()
        {
            // Tạo mã thuốc tự động
            txt_addMaThuoc.Text = thuocBLL.GenerateNewIDThuoc();

            // Lấy danh sách đơn vị tính
            cb_DVT.DataSource = thuocBLL.GetDVT();
            cb_DVT.DisplayMember = "TenDVT";
            cb_DVT.ValueMember = "IDDVT";

            // Lấy danh sách danh mục
            cb_DanhMuc.DataSource = thuocBLL.GetDanhMuc();
            cb_DanhMuc.DisplayMember = "TenDanhMuc";
            cb_DanhMuc.ValueMember = "IDDanhMuc";

            // Lấy danh sách loại kiểm tra
            cb_KiemTra.DataSource = thuocBLL.GetLoaiKiemTra();
            cb_KiemTra.DisplayMember = "TenLoaiKT";
            cb_KiemTra.ValueMember = "IDLoaiKT";
        }


        private void btn_Luu_ThemThuoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_addTenThuoc.Text) ||
                cb_DVT.SelectedIndex == -1 ||
                cb_DanhMuc.SelectedIndex == -1 ||
                cb_KiemTra.SelectedIndex == -1 || // Kiểm tra người dùng đã chọn loại kiểm tra
                string.IsNullOrWhiteSpace(txt_AnhSang.Text) ||
                nup_NhietDo.Value <= 0 || nup_DoAm.Value <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Tạo mã bảo quản tự động
                string idBaoQuan = baoQuanBLL.GenerateNewIDBaoQuan();

                // Thêm thông tin bảo quản
                BaoQuanDTO baoQuan = new BaoQuanDTO(idBaoQuan, nup_NhietDo.Value.ToString(), nup_DoAm.Value.ToString(), txt_AnhSang.Text);
                baoQuanBLL.AddBaoQuan(baoQuan);

                // Thêm thông tin thuốc
                ThuocDTO thuoc = new ThuocDTO(
                    txt_addMaThuoc.Text,
                    txt_addTenThuoc.Text,
                    txt_ThanhPhan.Text, // Truyền giá trị trực tiếp
                    cb_DVT.SelectedValue.ToString(),
                    float.Parse(txt_DonGia.Text),
                    cb_DanhMuc.SelectedValue.ToString(),
                    cb_NSX.Text,
                    idBaoQuan,
                    cb_KiemTra.SelectedValue.ToString()
                );

                thuocBLL.AddThuoc(thuoc);

                MessageBox.Show("Thêm thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm thuốc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
