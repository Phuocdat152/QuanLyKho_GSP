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

            dgv_DanhSachThuoc.CellClick += new DataGridViewCellEventHandler(dgv_DanhSachThuoc_CellClick);
            dgv_DanhSachThuoc.CellContentClick += new DataGridViewCellEventHandler(dgv_DanhSachThuoc_CellContentClick);

            // Sự kiện TextChanged cho ô tìm kiếm
            txt_TimKiem.TextChanged += new EventHandler(txt_TimKiem_TextChanged);

            // Sự kiện SelectedIndexChanged cho ComboBox
            cb_DanhMuc.SelectedIndexChanged += new EventHandler(cb_DanhMuc_SelectedIndexChanged);

            // Sự kiện Click cho các nút
            btn_ThemThuoc.Click += new EventHandler(btn_ThemThuoc_Click);
            btn_ChinhSua.Click += new EventHandler(btn_ChinhSua_Click);
        }

        private void Quanlythuoc_Load(object sender, EventArgs e)
        {
            
            LoadThuocData();
            LoadDanhMucData();
        }
        private void LoadInitialData()
        {
            try
            {
                // Khởi tạo BLL để gọi phương thức lấy dữ liệu
                ThuocBLL thuocBLL = new ThuocBLL(_username, _password);

                // Lấy toàn bộ thuốc
                DataTable thuocData = thuocBLL.GetAllThuoc();

                // Kiểm tra dữ liệu trả về
                if (thuocData == null || thuocData.Rows.Count == 0)
                {
                    dgv_DanhSachThuoc.DataSource = null;
                    MessageBox.Show("Không có dữ liệu thuốc để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Gán dữ liệu vào DataGridView
                dgv_DanhSachThuoc.DataSource = thuocData;

                // Đặt tiêu đề cột
                if (dgv_DanhSachThuoc.Columns.Contains("IDThuoc"))
                    dgv_DanhSachThuoc.Columns["IDThuoc"].HeaderText = "Mã Thuốc";
                if (dgv_DanhSachThuoc.Columns.Contains("TenThuoc"))
                    dgv_DanhSachThuoc.Columns["TenThuoc"].HeaderText = "Tên Thuốc";
                if (dgv_DanhSachThuoc.Columns.Contains("ThanhPhan"))
                    dgv_DanhSachThuoc.Columns["ThanhPhan"].HeaderText = "Thành Phần";
                if (dgv_DanhSachThuoc.Columns.Contains("IDDVT"))
                    dgv_DanhSachThuoc.Columns["IDDVT"].HeaderText = "Đơn Vị Tính";
                if (dgv_DanhSachThuoc.Columns.Contains("DonGia"))
                    dgv_DanhSachThuoc.Columns["DonGia"].HeaderText = "Đơn Giá";
                if (dgv_DanhSachThuoc.Columns.Contains("NuocSanXuat"))
                    dgv_DanhSachThuoc.Columns["NuocSanXuat"].HeaderText = "Nước Sản Xuất";

                // Đặt tiêu đề tiếng Việt cho các cột "Độ Ẩm", "Nhiệt Độ", "Ánh Sáng"
                if (dgv_DanhSachThuoc.Columns.Contains("DoAm"))
                    dgv_DanhSachThuoc.Columns["DoAm"].HeaderText = "Độ Ẩm";
                if (dgv_DanhSachThuoc.Columns.Contains("NhietDo"))
                    dgv_DanhSachThuoc.Columns["NhietDo"].HeaderText = "Nhiệt Độ";
                if (dgv_DanhSachThuoc.Columns.Contains("AnhSang"))
                    dgv_DanhSachThuoc.Columns["AnhSang"].HeaderText = "Ánh Sáng";

                // Ẩn các cột không cần thiết
                if (dgv_DanhSachThuoc.Columns.Contains("SoLuong"))
                    dgv_DanhSachThuoc.Columns["SoLuong"].Visible = false;
                if (dgv_DanhSachThuoc.Columns.Contains("IDLoaiKT"))
                    dgv_DanhSachThuoc.Columns["IDLoaiKT"].Visible = false;
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu xảy ra
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu thuốc: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadThuocData(string idDanhMuc = null)
        {
            try
            {
                // Khởi tạo BLL để gọi phương thức lấy dữ liệ
                ThuocBLL thuocBLL = new ThuocBLL(_username, _password);

                // Lấy toàn bộ thuốc
                DataTable thuocData = thuocBLL.GetAllThuoc();

                // Kiểm tra dữ liệu trả về
                if (thuocData == null || thuocData.Rows.Count == 0)
                {
                    dgv_DanhSachThuoc.DataSource = null;
                    MessageBox.Show("Không có dữ liệu thuốc để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Gán dữ liệu vào DataGridView
                dgv_DanhSachThuoc.DataSource = thuocData;

                // Đặt tiêu đề cột
                if (dgv_DanhSachThuoc.Columns.Contains("IDThuoc"))
                    dgv_DanhSachThuoc.Columns["IDThuoc"].HeaderText = "Mã Thuốc";
                if (dgv_DanhSachThuoc.Columns.Contains("TenThuoc"))
                    dgv_DanhSachThuoc.Columns["TenThuoc"].HeaderText = "Tên Thuốc";
                if (dgv_DanhSachThuoc.Columns.Contains("ThanhPhan"))
                    dgv_DanhSachThuoc.Columns["ThanhPhan"].HeaderText = "Thành Phần";
                if (dgv_DanhSachThuoc.Columns.Contains("IDDVT"))
                    dgv_DanhSachThuoc.Columns["IDDVT"].HeaderText = "Đơn Vị Tính";
                if (dgv_DanhSachThuoc.Columns.Contains("DonGia"))
                    dgv_DanhSachThuoc.Columns["DonGia"].HeaderText = "Đơn Giá";
                if (dgv_DanhSachThuoc.Columns.Contains("NuocSanXuat"))
                    dgv_DanhSachThuoc.Columns["NuocSanXuat"].HeaderText = "Nước Sản Xuất";

                // Đặt tiêu đề tiếng Việt cho các cột "Độ Ẩm", "Nhiệt Độ", "Ánh Sáng"
                if (dgv_DanhSachThuoc.Columns.Contains("DoAm"))
                    dgv_DanhSachThuoc.Columns["DoAm"].HeaderText = "Độ Ẩm";
                if (dgv_DanhSachThuoc.Columns.Contains("NhietDo"))
                    dgv_DanhSachThuoc.Columns["NhietDo"].HeaderText = "Nhiệt Độ";
                if (dgv_DanhSachThuoc.Columns.Contains("AnhSang"))
                    dgv_DanhSachThuoc.Columns["AnhSang"].HeaderText = "Ánh Sáng";

                // Ẩn các cột không cần thiết
                if (dgv_DanhSachThuoc.Columns.Contains("SoLuong"))
                    dgv_DanhSachThuoc.Columns["SoLuong"].Visible = false;
                if (dgv_DanhSachThuoc.Columns.Contains("IDLoaiKT"))
                    dgv_DanhSachThuoc.Columns["IDLoaiKT"].Visible = false;
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu xảy ra
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu thuốc: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void LoadDanhMucData()
        {
            DanhMucThuocBLL danhMucBLL = new DanhMucThuocBLL(_username, _password);
            DataTable danhMucData = danhMucBLL.GetAllDanhMucThuoc();

            // Thêm một dòng "Tất cả" vào danh sách
            DataRow allRow = danhMucData.NewRow();
            allRow["IDDanhMuc"] = DBNull.Value; // hoặc để null nếu không cần giá trị cụ thể
            allRow["TenDanhMuc"] = "Tất cả";
            danhMucData.Rows.InsertAt(allRow, 0);

            cb_DanhMuc.DataSource = danhMucData;
            cb_DanhMuc.DisplayMember = "TenDanhMuc";
            cb_DanhMuc.ValueMember = "IDDanhMuc";

            // Đặt mục được chọn mặc định là "Tất cả"
            cb_DanhMuc.SelectedIndex = 0;
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
                lb_ThanhPhan.Text = row.Cells["ThanhPhan"].Value.ToString();
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
            try
            {
                // Lấy từ khóa tìm kiếm
                string keyword = txt_TimKiem.Text.Trim();

                // Lấy danh mục được chọn (nếu có)
                string selectedDanhMucID = cb_DanhMuc.SelectedValue?.ToString();

                // Khởi tạo BLL
                ThuocBLL thuocBLL = new ThuocBLL(_username, _password);

                // Nếu từ khóa rỗng, hiển thị tất cả thuốc
                DataTable result = string.IsNullOrEmpty(keyword)
                    ? thuocBLL.GetThuocByDanhMuc(selectedDanhMucID) // Lấy thuốc theo danh mục hoặc tất cả nếu danh mục rỗng
                    : thuocBLL.SearchThuoc(keyword, selectedDanhMucID); // Tìm kiếm thuốc theo từ khóa

                // Kiểm tra dữ liệu trả về
                if (result == null || result.Rows.Count == 0)
                {
                    // Tạo bảng trống với cấu trúc cột
                    DataTable emptyTable = new DataTable();
                    emptyTable.Columns.Add("MaThuoc", typeof(string));
                    emptyTable.Columns.Add("TenThuoc", typeof(string));
                    emptyTable.Columns.Add("ThanhPhan", typeof(string));
                    emptyTable.Columns.Add("DVT", typeof(string));
                    emptyTable.Columns.Add("DonGia", typeof(decimal));
                    emptyTable.Columns.Add("NSX", typeof(string));
                    emptyTable.Columns.Add("NhietDo", typeof(string));
                    emptyTable.Columns.Add("DoAm", typeof(string));
                    emptyTable.Columns.Add("AnhSang", typeof(string));

                    dgv_DanhSachThuoc.DataSource = emptyTable;
                    return;
                }

                // Hiển thị dữ liệu vào DataGridView
                dgv_DanhSachThuoc.DataSource = result;

                // Đặt tiêu đề cột tiếng Việt
                if (dgv_DanhSachThuoc.Columns.Contains("MaThuoc"))
                    dgv_DanhSachThuoc.Columns["MaThuoc"].HeaderText = "Mã Thuốc";
                if (dgv_DanhSachThuoc.Columns.Contains("TenThuoc"))
                    dgv_DanhSachThuoc.Columns["TenThuoc"].HeaderText = "Tên Thuốc";
                if (dgv_DanhSachThuoc.Columns.Contains("ThanhPhan"))
                    dgv_DanhSachThuoc.Columns["ThanhPhan"].HeaderText = "Thành Phần";
                if (dgv_DanhSachThuoc.Columns.Contains("DVT"))
                    dgv_DanhSachThuoc.Columns["DVT"].HeaderText = "Đơn Vị Tính";
                if (dgv_DanhSachThuoc.Columns.Contains("DonGia"))
                    dgv_DanhSachThuoc.Columns["DonGia"].HeaderText = "Đơn Giá";
                if (dgv_DanhSachThuoc.Columns.Contains("NSX"))
                    dgv_DanhSachThuoc.Columns["NSX"].HeaderText = "Nước Sản Xuất";

                // Ẩn các cột không cần thiết
                if (dgv_DanhSachThuoc.Columns.Contains("SoLuong"))
                    dgv_DanhSachThuoc.Columns["SoLuong"].Visible = false;
                if (dgv_DanhSachThuoc.Columns.Contains("LKT"))
                    dgv_DanhSachThuoc.Columns["LKT"].Visible = false;
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu xảy ra
                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_DanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Chỉ thực hiện khi danh mục được chọn
            if (cb_DanhMuc.SelectedValue != null)
            {
                string selectedDanhMucID = cb_DanhMuc.SelectedValue.ToString();

                // Nếu chọn "Tất cả" hoặc danh mục rỗng, tải lại toàn bộ dữ liệu
                if (string.IsNullOrEmpty(selectedDanhMucID) || selectedDanhMucID == "Tất cả")
                {
                    LoadInitialData(); // Tải toàn bộ thuốc
                }
                else
                {
                    UpdateThuocData(); // Tải thuốc theo danh mục
                }
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            UpdateThuocData();
        }


        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedMaThuoc))
            {
                // Mở form sửa thông tin thuốc
                SuaTTThuoc suaTTThuocForm = new SuaTTThuoc(selectedMaThuoc, _username, _password);
                suaTTThuocForm.FormClosed += (s, args) =>
                {
                    // Tải lại danh sách thuốc khi form đóng
                    LoadThuocData();
                };
                suaTTThuocForm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một thuốc để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_DanhSachThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
