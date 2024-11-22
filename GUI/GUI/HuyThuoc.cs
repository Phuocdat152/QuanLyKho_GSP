using BLL;
using DevExpress.XtraEditors.Repository;
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
    public partial class HuyThuoc : Form
    {
        private LuuTruBLL luuTruBLL;
        private ViTriBLL viTriBLL;
        private ThuocHuyBLL thuocHuyBLL;
        public HuyThuoc(string username, string password)
        {
            InitializeComponent();
            luuTruBLL = new LuuTruBLL(username, password);
            viTriBLL = new ViTriBLL(username,password);
            thuocHuyBLL = new ThuocHuyBLL(username,password);
        }


        private void InitializeThuocHuyGrid()
        {
            // Tạo một DataTable rỗng với các cột cần thiết
            DataTable dtEmpty = new DataTable();
            dtEmpty.Columns.Add("IDLuuTru", typeof(string));
            dtEmpty.Columns.Add("TenThuoc", typeof(string));
            dtEmpty.Columns.Add("IDThuoc", typeof(string));
            dtEmpty.Columns.Add("SoLuongHuy", typeof(int));
            dtEmpty.Columns.Add("ViTri", typeof(string));
            dtEmpty.Columns.Add("LyDoHuy", typeof(string));
            dtEmpty.Columns.Add("NgayHuy", typeof(DateTime));
            dtEmpty.Columns.Add("GhiChu", typeof(string));

            // Gán DataTable vào GridControl để đảm bảo cột luôn hiển thị
            gc_ThuocHuy.DataSource = dtEmpty;

            // Gọi cấu hình cột
            ConfigureThuocHuyGridColumns();
        }


        private void LoadLuuTruToComboBoxEdit()
        {
            try
            {
                // Gọi phương thức BLL để lấy dữ liệu
                DataTable dtLuuTru = luuTruBLL.HienThiThongTinLuuTru();

                if (dtLuuTru != null && dtLuuTru.Rows.Count > 0)
                {
                    // Gán dữ liệu vào ComboBoxEdit
                    cb_ThuocHuy.Properties.Items.Clear(); // Xóa dữ liệu cũ
                    foreach (DataRow row in dtLuuTru.Rows)
                    {
                        // Ghép nối các tham số có tên và giá trị
                        string displayText = $"Mã lưu trữ: {row["IDLuuTru"]}| " + 
                                             $"Mã thuốc: {row["IDThuoc"]}| " +
                                             $"Tên thuốc: {row["TenThuoc"]}| " +
                                             $"Số lượng tồn: {row["SLTon"]}| " +
                                             $"Vị trí: {row["Khu"]}, " +
                                             $"{row["Ke"]}, " +
                                             $"{row["O"]}";


                        // Thêm dòng vào ComboBoxEdit
                        cb_ThuocHuy.Properties.Items.Add(displayText);
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu lưu trữ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureThuocHuyGridColumns()
        {
            var gridView = gc_ThuocHuy.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            if (gridView != null)
            {
                // Đặt tên hiển thị cho các cột
                if (gridView.Columns["IDLuuTru"] != null)
                    gridView.Columns["IDLuuTru"].Caption = "Mã lưu trữ";

                if (gridView.Columns["TenThuoc"] != null)
                    gridView.Columns["TenThuoc"].Caption = "Tên thuốc";

                if (gridView.Columns["IDThuoc"] != null)
                    gridView.Columns["IDThuoc"].Caption = "Mã thuốc";

                if (gridView.Columns["SoLuongHuy"] != null)
                    gridView.Columns["SoLuongHuy"].Caption = "Số lượng hủy";

                if (gridView.Columns["ViTri"] != null)
                    gridView.Columns["ViTri"].Caption = "Vị trí";

                if (gridView.Columns["LyDoHuy"] != null)
                    gridView.Columns["LyDoHuy"].Caption = "Lý do hủy";

                if (gridView.Columns["NgayHuy"] != null)
                    gridView.Columns["NgayHuy"].Caption = "Ngày hủy";

                if (gridView.Columns["GhiChu"] != null)
                    gridView.Columns["GhiChu"].Caption = "Ghi chú";

                // Căn giữa tiêu đề cột
                foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                {
                    column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                }

                // Làm mới lại GridView
                gridView.RefreshData();
            }
        }



        private void cb_ThuocHuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_ThuocHuy.SelectedIndex != -1)
                {
                    // Lấy thông tin từ dòng đã chọn
                    string selectedText = cb_ThuocHuy.Properties.Items[cb_ThuocHuy.SelectedIndex].ToString();

                    // Tách thông tin từ chuỗi
                    string[] parts = selectedText.Split('|');
                    if (parts.Length >= 3)
                    {
                        string idLuuTru = parts[0].Split(':')[1].Trim();
                        string idThuoc = parts[1].Split(':')[1].Trim();
                        string tenThuoc = parts[2].Split(':')[1].Trim();
                        string soLuongHuy = parts[3].Split(':')[1].Trim();

                        // Lấy DataTable từ GridControl
                        DataTable dt = gc_ThuocHuy.DataSource as DataTable;

                        // Thêm dòng mới vào GridControl
                        DataRow newRow = dt.NewRow();
                        newRow["IDLuuTru"] = idLuuTru;
                        newRow["IDThuoc"] = idThuoc;
                        newRow["TenThuoc"] = tenThuoc;
                        newRow["SoLuongHuy"] = soLuongHuy;

                        dt.Rows.Add(newRow);

                        // Làm mới GridControl
                        gc_ThuocHuy.RefreshDataSource();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm thông tin thuốc vào GridControl: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxInViTriColumn()
        {
            try
            {
                // Lấy dữ liệu vị trí từ ViTriBLL
                DataTable dtViTri = viTriBLL.GetViTriTheoLoaiKhuHuy();

                // Tạo RepositoryItemLookUpEdit cho cột "Vị trí"
                RepositoryItemLookUpEdit lookUpEditViTri = new RepositoryItemLookUpEdit
                {
                    DataSource = dtViTri,
                    DisplayMember = "Mã Vị Trí",  // Hiển thị mã vị trí trong ComboBox
                    ValueMember = "Mã Vị Trí",    // Giá trị lưu trữ là mã vị trí
                    NullText = "Chọn vị trí",
                    BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit // Tự động điều chỉnh
                };

                // Cấu hình các cột hiển thị trong LookUpEdit
                lookUpEditViTri.PopulateColumns();
                lookUpEditViTri.Columns["Mã Vị Trí"].Caption = "Mã Vị Trí";
                lookUpEditViTri.Columns["Tên Khu"].Caption = "Tên Khu";
                lookUpEditViTri.Columns["Tên Kệ"].Caption = "Tên Kệ";
                lookUpEditViTri.Columns["Tên Ô"].Caption = "Tên Ô";

                // Ẩn các cột không cần thiết
                if (lookUpEditViTri.Columns["Trạng Thái"] != null)
                    lookUpEditViTri.Columns["Trạng Thái"].Caption = "Trạng Thái";
                if (lookUpEditViTri.Columns["Loại Khu"] != null)
                    lookUpEditViTri.Columns["Loại Khu"].Caption = "Loại khu";

                // Kiểm tra và gán LookUpEdit vào cột "ViTri"
                var gridView = gc_ThuocHuy.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (gridView != null)
                {
                    var colViTri = gridView.Columns["ViTri"];
                    if (colViTri != null)
                    {
                        colViTri.ColumnEdit = lookUpEditViTri;
                        gridView.RefreshData(); // Làm mới GridView
                    }
                    else
                    {
                        MessageBox.Show("Cột 'ViTri' không tồn tại trong GridView.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("MainView không phải là GridView.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu vào ComboBox Vị trí: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy GridView từ GridControl
                var gridView = gc_ThuocHuy.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (gridView == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin cần lưu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int successCount = 0; // Đếm số dòng lưu thành công
                int errorCount = 0;   // Đếm số dòng lưu thất bại
                StringBuilder errorMessages = new StringBuilder(); // Lưu thông báo lỗi chi tiết

                // Duyệt qua từng dòng trong GridView
                for (int i = 0; i < gridView.RowCount; i++)
                {
                    try
                    {
                        // Lấy thông tin từ từng dòng
                        string idLuuTru = gridView.GetRowCellValue(i, "IDLuuTru")?.ToString();
                        string idThuoc = gridView.GetRowCellValue(i, "IDThuoc")?.ToString();
                        string tenThuoc = gridView.GetRowCellValue(i, "TenThuoc")?.ToString();
                        string soLuongHuyStr = gridView.GetRowCellValue(i, "SoLuongHuy")?.ToString();
                        string viTri = gridView.GetRowCellValue(i, "ViTri")?.ToString();
                        string lyDoHuy = gridView.GetRowCellValue(i, "LyDoHuy")?.ToString();
                        string ngayHuyStr = gridView.GetRowCellValue(i, "NgayHuy")?.ToString();
                        string ghiChu = gridView.GetRowCellValue(i, "GhiChu")?.ToString();

                        // Kiểm tra từng cột dữ liệu
                        if (string.IsNullOrEmpty(idLuuTru) || string.IsNullOrEmpty(idThuoc) ||
                            string.IsNullOrEmpty(soLuongHuyStr) || !int.TryParse(soLuongHuyStr, out int soLuongHuy) || soLuongHuy <= 0 ||
                            string.IsNullOrEmpty(viTri) || string.IsNullOrEmpty(lyDoHuy) ||
                            string.IsNullOrEmpty(ngayHuyStr) || !DateTime.TryParse(ngayHuyStr, out DateTime ngayHuy))
                        {
                            errorMessages.AppendLine($"Dòng {i + 1}: Dữ liệu không hợp lệ.");
                            errorCount++;
                            continue;
                        }

                        // Gọi BLL để lưu thông tin
                        string idThuocHuy = thuocHuyBLL.ThemThuocHuy(idThuoc, idLuuTru, viTri, soLuongHuy, lyDoHuy, ngayHuy, "Chờ hủy", ghiChu);

                        // Kiểm tra kết quả lưu
                        if (!string.IsNullOrEmpty(idThuocHuy))
                        {
                            successCount++;
                        }
                        else
                        {
                            errorMessages.AppendLine($"Dòng {i + 1}: Lưu thất bại.");
                            errorCount++;
                        }
                    }
                    catch (Exception ex)
                    {
                        errorMessages.AppendLine($"Dòng {i + 1}: {ex.Message}");
                        errorCount++;
                    }
                }

                // Hiển thị thông báo kết quả
                if (successCount > 0)
                {
                    MessageBox.Show($"Đã lưu thành công {successCount} dòng thuốc hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachThuocHuy();
                }

                if (errorCount > 0)
                {
                    MessageBox.Show($"Có {errorCount} dòng không được lưu.\nChi tiết:\n{errorMessages}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Xóa dữ liệu sau khi lưu thành công
                if (successCount > 0)
                {
                    var dataTable = gc_ThuocHuy.DataSource as DataTable;
                    dataTable?.Clear();
                    gc_ThuocHuy.RefreshDataSource();
                    cb_ThuocHuy.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LoadDanhSachThuocHuy()
        {
            try
            {
                // Lấy dữ liệu từ BLL
                DataTable dt = thuocHuyBLL.HienThiThongTinThuocHuy();

                if (dt != null && dt.Rows.Count > 0)
                {
                    // Gán dữ liệu vào GridControl
                    gc_DSTH.DataSource = dt;
                    ConfigureDanhSachThuocHuyGridColumns(); // Cấu hình GridView
                }
                else
                {
                    // Xóa dữ liệu cũ nếu không có kết quả
                    gc_DSTH.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách thuốc hủy: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ConfigureDanhSachThuocHuyGridColumns()
        {
            var gridView = gc_DSTH.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            if (gridView != null)
            {
                // Đặt tên hiển thị cho các cột
                gridView.Columns["Mã Thuốc Hủy"].Caption = "Mã Thuốc Hủy";
                gridView.Columns["Mã Thuốc"].Caption = "Mã Thuốc";
                gridView.Columns["Tên Thuốc"].Caption = "Tên Thuốc";
                gridView.Columns["Mã Lưu Trữ"].Caption = "Mã Lưu Trữ";
                gridView.Columns["Vị Trí"].Caption = "Vị Trí";
                gridView.Columns["Số Lượng Hủy"].Caption = "Số Lượng Hủy";
                gridView.Columns["Lý Do Hủy"].Caption = "Lý Do Hủy";
                gridView.Columns["Ngày Hủy"].Caption = "Ngày Hủy";
                gridView.Columns["Tình Trạng"].Caption = "Tình Trạng";
                gridView.Columns["Ghi Chú"].Caption = "Ghi Chú";

                // Căn giữa tiêu đề cột
                foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                {
                    column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                    // Đặt tất cả cột chỉ đọc
                    column.OptionsColumn.AllowEdit = false;
                }

                // Tắt các chức năng chỉnh sửa khác
                gridView.OptionsBehavior.Editable = false; // Tắt chỉnh sửa GridView
                gridView.OptionsBehavior.ReadOnly = true; // Bật chế độ chỉ đọc
                gridView.OptionsView.ShowGroupPanel = false; // Ẩn GroupPanel
                gridView.OptionsSelection.EnableAppearanceFocusedCell = false; // Không cho chọn ô
                gridView.OptionsSelection.EnableAppearanceFocusedRow = true; // Chỉ cho chọn hàng
                gridView.OptionsSelection.MultiSelect = false; // Chỉ cho phép chọn một hàng tại một thời điểm

                gridView.RefreshData(); // Làm mới GridView
            }
        }


        private void CapNhatTinhTrangThuocHuy()
        {
                int soDongCapNhat = thuocHuyBLL.CapNhatTinhTrangThuocHuy();
                LoadDanhSachThuocHuy();

        }


        private void btn_TaiBienBan_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở hộp thoại chọn file
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png|All Files (*.*)|*.*",
                    Title = "Chọn Biên Bản Hủy Thuốc"
                };

                // Nếu người dùng chọn file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị hình ảnh biên bản trong PictureBox
                    pb_BienBan.Image = Image.FromFile(openFileDialog.FileName);

                    // Đặt SizeMode để hình ảnh vừa với khung
                    pb_BienBan.SizeMode = PictureBoxSizeMode.Zoom;

                    // Enable các control khác
                    cb_ThuocHuy.Enabled = true;
                    btn_Luu.Enabled = true;

                    // Hiển thị thông báo
                    MessageBox.Show("Tải biên bản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có
                MessageBox.Show($"Lỗi khi tải biên bản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void HuyThuoc_Load(object sender, EventArgs e)
        {
            InitializeThuocHuyGrid();
            LoadLuuTruToComboBoxEdit();
            LoadComboBoxInViTriColumn();
            LoadDanhSachThuocHuy();
            CapNhatTinhTrangThuocHuy();

            // Gắn sự kiện SelectedIndexChanged
            cb_ThuocHuy.SelectedIndexChanged += cb_ThuocHuy_SelectedIndexChanged;
            btn_TaiBienBan.Click += btn_TaiBienBan_Click;

            btn_Luu.Click += btn_Luu_Click;


        }
    }
}
