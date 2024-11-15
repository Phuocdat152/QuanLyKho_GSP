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
    public partial class Quanlythuoc : Form
    {
        private string _username;
        private string _password;
        private UserBLL userBLL;
        private ThuocDTO selectedThuoc;
        private BaoQuanDTO selectedBaoQuan;
        private string selectedMaThuoc;
        private string selectedIDBaoQuan;
        public Quanlythuoc(string username, string password)
        {
            InitializeComponent();
            _username = username;
            _password = password;
            userBLL = new UserBLL(_username, _password);
            this.dgv_DanhSachThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachThuoc_CellClick);
            this.cb_DanhMuc.SelectedIndexChanged += new System.EventHandler(this.cb_DanhMuc_SelectedIndexChanged);
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);


        }

        private void Quanlythuoc_Load(object sender, EventArgs e)
        {
            LoadThuocData();
            LoadDanhMucData();
        }

        private void LoadThuocData(string idDanhMuc = null)
        {
            ThuocBLL thuocBLL = new ThuocBLL(_username, _password);
            DataTable thuocData = thuocBLL.GetThuocByDanhMuc(idDanhMuc); // Lấy tất cả thuốc nếu idDanhMuc là null
            dgv_DanhSachThuoc.DataSource = thuocData;

            // Đặt tiêu đề cột tiếng Việt
            dgv_DanhSachThuoc.Columns["MaThuoc"].HeaderText = "Mã Thuốc";
            dgv_DanhSachThuoc.Columns["TenThuoc"].HeaderText = "Tên Thuốc";
            dgv_DanhSachThuoc.Columns["DVT"].HeaderText = "Đơn Vị Tính";
            dgv_DanhSachThuoc.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgv_DanhSachThuoc.Columns["NSX"].HeaderText = "Nước Sản Xuất";
            dgv_DanhSachThuoc.Columns["NhietDo"].HeaderText = "Nhiệt Độ Bảo Quản";
            dgv_DanhSachThuoc.Columns["DoAm"].HeaderText = "Độ Ẩm Bảo Quản";
            dgv_DanhSachThuoc.Columns["AnhSang"].HeaderText = "Điều Kiện Ánh Sáng";

            // Ẩn hai cột Số Lượng và Loại Kiểm Tra
            dgv_DanhSachThuoc.Columns["SoLuong"].Visible = false;
            dgv_DanhSachThuoc.Columns["LKT"].Visible = false;
        }


        private void LoadDanhMucData()
        {
            DanhMucThuocBLL danhMucBLL = new DanhMucThuocBLL(_username, _password);
            DataTable danhMucData = danhMucBLL.GetAllDanhMucThuoc();

            // Thêm một dòng "Tất cả" vào danh sách
            DataRow allRow = danhMucData.NewRow();
            allRow["IDDanhMuc"] = DBNull.Value; // hoặc "Tất cả"
            allRow["TenDanhMuc"] = "Tất cả";
            danhMucData.Rows.InsertAt(allRow, 0);

            cb_DanhMuc.DataSource = danhMucData;
            cb_DanhMuc.DisplayMember = "TenDanhMuc";
            cb_DanhMuc.ValueMember = "IDDanhMuc";
        }

        private void btn_ThemThuoc_Click(object sender, EventArgs e)
        {
            ThemThuoc themThuocForm = new ThemThuoc(_username, _password); // Truyền username và password
            themThuocForm.ShowDialog();
            LoadThuocData();
        }

        private void dgv_DanhSachThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) // Đảm bảo chỉ xử lý khi dòng được chọn là hợp lệ
            {
                DataGridViewRow row = dgv_DanhSachThuoc.Rows[e.RowIndex];

                // Lấy và hiển thị mã thuốc
                selectedMaThuoc = row.Cells["MaThuoc"].Value.ToString();
                lb_MaThuoc.Text = selectedMaThuoc;

                // Kiểm tra sự tồn tại của cột "IDBaoQuan" trước khi truy cập
                if (dgv_DanhSachThuoc.Columns.Contains("IDBaoQuan"))
                {
                    selectedIDBaoQuan = row.Cells["IDBaoQuan"].Value.ToString();
                }
                else
                {
                    selectedIDBaoQuan = null; // Hoặc giá trị mặc định nếu cột không tồn tại
                }

                // Hiển thị các thông tin khác của thuốc trên các Label
                lb_TenThuoc.Text = row.Cells["TenThuoc"].Value.ToString();
                lb_DVT.Text = row.Cells["DVT"].Value.ToString();
                lb_DonGia.Text = row.Cells["DonGia"].Value.ToString();
                lb_NSX.Text = row.Cells["NSX"].Value.ToString();
                lb_NhietDo.Text = row.Cells["NhietDo"].Value.ToString();
                lb_DoAm.Text = row.Cells["DoAm"].Value.ToString();
                lb_AnhSang.Text = row.Cells["AnhSang"].Value.ToString();
            }


        }
        private void UpdateThuocData()
        {
            string keyword = txt_TimKiem.Text.Trim();
            string selectedDanhMucID = cb_DanhMuc.SelectedValue?.ToString();

            ThuocBLL thuocBLL = new ThuocBLL(_username, _password);
            DataTable searchResult = thuocBLL.SearchThuoc(keyword, selectedDanhMucID);
            dgv_DanhSachThuoc.DataSource = searchResult;

            // Đặt tiêu đề cột tiếng Việt
            dgv_DanhSachThuoc.Columns["MaThuoc"].HeaderText = "Mã Thuốc";
            dgv_DanhSachThuoc.Columns["TenThuoc"].HeaderText = "Tên Thuốc";
            dgv_DanhSachThuoc.Columns["DVT"].HeaderText = "Đơn Vị Tính";
            dgv_DanhSachThuoc.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgv_DanhSachThuoc.Columns["NSX"].HeaderText = "Nước Sản Xuất";
            dgv_DanhSachThuoc.Columns["NhietDo"].HeaderText = "Nhiệt Độ Bảo Quản";
            dgv_DanhSachThuoc.Columns["DoAm"].HeaderText = "Độ Ẩm Bảo Quản";
            dgv_DanhSachThuoc.Columns["AnhSang"].HeaderText = "Điều Kiện Ánh Sáng";

            // Ẩn hai cột Số Lượng và Loại Kiểm Tra
            dgv_DanhSachThuoc.Columns["SoLuong"].Visible = false;
            dgv_DanhSachThuoc.Columns["LKT"].Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_DanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy ID danh mục được chọn từ ComboBox
            //string selectedDanhMucID = cb_DanhMuc.SelectedValue?.ToString();

            //// Nếu chọn "Tất cả" hoặc không chọn danh mục cụ thể, hiển thị tất cả thuốc
            //if (string.IsNullOrEmpty(selectedDanhMucID) || selectedDanhMucID == "Tất cả")
            //{
            //    LoadThuocData(); // Hiển thị tất cả thuốc

            //}
            //else
            //{
            //    LoadThuocData(selectedDanhMucID);
            //    // Hiển thị thuốc theo danh mục được chọn
            //}
            UpdateThuocData();
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            //string keyword = txt_TimKiem.Text.Trim();
            
            //// Kiểm tra từ khóa tìm kiếm
            //if (string.IsNullOrEmpty(keyword))
            //{
            //    // Nếu không có từ khóa, hiển thị tất cả thuốc
            //    LoadThuocData();
            //}
            //else
            //{
            //    // Tìm kiếm thuốc theo từ khóa
            //    ThuocBLL thuocBLL = new ThuocBLL(_username, _password);
            //    DataTable searchResult = thuocBLL.SearchThuoc(keyword);
            //    dgv_DanhSachThuoc.DataSource = searchResult;

            //    // Đặt tiêu đề cột tiếng Việt
            //    dgv_DanhSachThuoc.Columns["MaThuoc"].HeaderText = "Mã Thuốc";
            //    dgv_DanhSachThuoc.Columns["TenThuoc"].HeaderText = "Tên Thuốc";
            //    dgv_DanhSachThuoc.Columns["DVT"].HeaderText = "Đơn Vị Tính";
            //    dgv_DanhSachThuoc.Columns["DonGia"].HeaderText = "Đơn Giá";
            //    dgv_DanhSachThuoc.Columns["NSX"].HeaderText = "Nước Sản Xuất";
            //    dgv_DanhSachThuoc.Columns["NhietDo"].HeaderText = "Nhiệt Độ Bảo Quản";
            //    dgv_DanhSachThuoc.Columns["DoAm"].HeaderText = "Độ Ẩm Bảo Quản";
            //    dgv_DanhSachThuoc.Columns["AnhSang"].HeaderText = "Điều Kiện Ánh Sáng";

            //    // Ẩn hai cột Số Lượng và Loại Kiểm Tra
            //    dgv_DanhSachThuoc.Columns["SoLuong"].Visible = false;
            //    dgv_DanhSachThuoc.Columns["LKT"].Visible = false;
                
            //}
            UpdateThuocData();
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedMaThuoc) && !string.IsNullOrEmpty(selectedIDBaoQuan))
            {
                // Mở form SuaTTThuoc và truyền IDThuoc và IDBaoQuan đã chọn
                SuaTTThuoc formSuaTT = new SuaTTThuoc(selectedMaThuoc, selectedIDBaoQuan, _username, _password);
                formSuaTT.FormClosed += (s, args) => LoadThuocData(); // Tải lại DataGridView sau khi đóng form
                formSuaTT.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một thuốc để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_DanhSachThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
