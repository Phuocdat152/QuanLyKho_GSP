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
                    // Gán dữ liệu vào SearchLookUpEdit
                    cb_ThuocHuy.Properties.DataSource = dtLuuTru;
                    cb_ThuocHuy.Properties.DisplayMember = "TenThuoc"; // Hiển thị tên thuốc
                    cb_ThuocHuy.Properties.ValueMember = "IDLuuTru";   // Giá trị là IDLuuTru

                    // Tùy chỉnh hiển thị cột trong danh sách
                    cb_ThuocHuy.Properties.PopulateViewColumns();
                    var view = cb_ThuocHuy.Properties.View;

                    // Đặt tên cột và hiển thị dữ liệu
                    view.Columns["IDLuuTru"].Caption = "Mã lưu trữ";
                    view.Columns["IDThuoc"].Caption = "Mã thuốc";
                    view.Columns["TenThuoc"].Caption = "Tên thuốc";
                    view.Columns["SLTon"].Caption = "Số lượng tồn";
                    view.Columns["Khu"].Caption = "Khu vực";
                    view.Columns["Ke"].Caption = "Kệ";
                    view.Columns["O"].Caption = "Ô";
                    view.Columns["IDChiTietPhieuNhap"].Visible = false;
                    view.Columns["NgayNhap"].Visible = false;
                    view.Columns["TrangThai"].Visible = false;

                    // Ẩn các cột không cần thiết (nếu có)
                    // view.Columns["SomeColumn"].Visible = false;

                    // Tắt chỉnh sửa trong danh sách
                    view.OptionsBehavior.Editable = false;

                    // Đặt giá trị mặc định (nếu cần)
                    cb_ThuocHuy.EditValue = null;

                    // Gán văn bản placeholder cho ô tìm kiếm
                    cb_ThuocHuy.Properties.NullText = "Tìm kiếm thuốc...";
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



        private void View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                // Lấy dòng được chọn trong SearchLookUpEdit
                var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
                DataRow selectedRow = view.GetDataRow(e.RowHandle);

                if (selectedRow != null)
                {
                    string idLuuTru = selectedRow["IDLuuTru"].ToString();
                    string idThuoc = selectedRow["IDThuoc"].ToString();
                    string tenThuoc = selectedRow["TenThuoc"].ToString();
                    int soLuongTon = Convert.ToInt32(selectedRow["SLTon"]);

                    // Lấy DataTable từ GridControl
                    DataTable dt = gc_ThuocHuy.DataSource as DataTable;
                    if (dt == null)
                    {
                        // Tạo mới DataTable nếu GridControl chưa có nguồn dữ liệu
                        dt = new DataTable();
                        dt.Columns.Add("IDLuuTru", typeof(string));
                        dt.Columns.Add("IDThuoc", typeof(string));
                        dt.Columns.Add("TenThuoc", typeof(string));
                        dt.Columns.Add("SoLuongHuy", typeof(int));
                        gc_ThuocHuy.DataSource = dt;
                    }

                    // Kiểm tra xem thuốc với IDLuuTru đã tồn tại trong GridControl hay chưa
                    bool isExists = dt.AsEnumerable().Any(row => row.Field<string>("IDLuuTru") == idLuuTru);

                    if (isExists)
                    {
                        MessageBox.Show($"Thuốc '{tenThuoc}' với ID lưu trữ '{idLuuTru}' đã được thêm vào danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Thêm dòng mới vào DataTable
                    DataRow newRow = dt.NewRow();
                    newRow["IDLuuTru"] = idLuuTru;
                    newRow["IDThuoc"] = idThuoc;
                    newRow["TenThuoc"] = tenThuoc;
                    newRow["SoLuongHuy"] = soLuongTon; // Có thể thêm số lượng hủy từ người dùng
                    dt.Rows.Add(newRow);

                    // Làm mới GridControl
                    gc_ThuocHuy.RefreshDataSource();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm thuốc vào danh sách hủy: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"Đã lưu thành công {successCount} thuốc hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachThuocHuy_ChoHuy();
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
                    cb_ThuocHuy.EditValue = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LoadDanhSachThuocHuy_ChoHuy()
        {
            try
            {
                // Lấy dữ liệu từ BLL
                DataTable dt = thuocHuyBLL.HienThiThongTinThuocHuy_ChoHuy();

                if (dt != null && dt.Rows.Count > 0)
                {
                    // Gán dữ liệu vào GridControl
                    gc_DSTH.DataSource = dt;
                    ConfigureDanhSachThuocHuyGridColumns();

                    // Thêm nút Hủy vào cuối mỗi dòng
                    AddCancelButtonToGrid(); // Gọi hàm sau khi gán dữ liệu
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



        private void LoadDanhSachThuocHuy_DaHuy()
        {
            try
            {
                // Lấy dữ liệu từ BLL
                DataTable dt = thuocHuyBLL.HienThiThongTinThuocHuy_DaHuy();

                if (dt != null && dt.Rows.Count > 0)
                {
                    // Gán dữ liệu vào GridControl
                    gc_DSTDH.DataSource = dt;
                    ConfigureDanhSachThuocHuy_DaHuyGridColumns(); // Cấu hình GridView
                }
                else
                {
                    // Xóa dữ liệu cũ nếu không có kết quả
                    gc_DSTDH.DataSource = null;
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
                gridView.Columns["Mã Lưu Trữ"].Visible = false;
                gridView.Columns["Vị Trí"].Caption = "Vị Trí";
                gridView.Columns["Số Lượng Hủy"].Caption = "Số Lượng Hủy";
                gridView.Columns["Lý Do Hủy"].Caption = "Lý Do Hủy";
                gridView.Columns["Ngày Hủy"].Caption = "Ngày Hủy";
                gridView.Columns["Tình Trạng"].Caption = "Tình Trạng";
                gridView.Columns["Ghi Chú"].Caption = "Ghi Chú";

                // Tắt chỉnh sửa tất cả các cột ngoại trừ cột "Hủy"
                foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                {
                    if (column.FieldName != "Action") // Cột "Hủy" có FieldName là "Action"
                    {
                        column.OptionsColumn.AllowEdit = false; // Chỉ đọc
                    }
                    else
                    {
                        column.OptionsColumn.AllowEdit = true; // Cho phép chỉnh sửa
                    }

                    // Căn giữa tiêu đề cột
                    column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                }

                // Tắt các chức năng không cần thiết
                gridView.OptionsBehavior.Editable = true; // Bật chỉnh sửa GridView
                gridView.OptionsView.ShowGroupPanel = false; // Ẩn GroupPanel
                gridView.OptionsSelection.EnableAppearanceFocusedCell = false; // Không cho chọn ô
                gridView.OptionsSelection.EnableAppearanceFocusedRow = true; // Chỉ cho chọn hàng
                gridView.OptionsSelection.MultiSelect = false; // Chỉ cho phép chọn một hàng tại một thời điểm

                gridView.RefreshData(); // Làm mới GridView
            }
        }



        private void ConfigureDanhSachThuocHuy_DaHuyGridColumns()
        {
            var gridView = gc_DSTDH.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            if (gridView != null)
            {
                // Đặt tên hiển thị cho các cột
                gridView.Columns["Mã Thuốc Hủy"].Caption = "Mã Thuốc Hủy";
                gridView.Columns["Mã Thuốc"].Caption = "Mã Thuốc";
                gridView.Columns["Tên Thuốc"].Caption = "Tên Thuốc";
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
                    column.OptionsColumn.AllowEdit = true;
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
            LoadDanhSachThuocHuy_ChoHuy();
            LoadDanhSachThuocHuy_DaHuy();

            // Gắn sự kiện SelectedIndexChanged
            btn_TaiBienBan.Click += btn_TaiBienBan_Click;

            btn_Luu.Click += btn_Luu_Click;

            // Gắn sự kiện khi người dùng nhấn vào dòng trong SearchLookUpEdit
            cb_ThuocHuy.Properties.View.RowClick += View_RowClick;

            var gridView = gc_DSTH.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (gridView != null)
            {
                gridView.CustomDrawCell += GridView_CustomDrawCell;
            }



        }



        // Tạo nút "Hủy"
        private void AddCancelButtonToGrid()
        {
            // Tạo RepositoryItemButtonEdit
            RepositoryItemButtonEdit btnHuy = new RepositoryItemButtonEdit
            {
                ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            };

            btnHuy.Buttons[0].Caption = "Hủy thuốc";
            btnHuy.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;

            // Thiết lập màu sắc mặc định
            btnHuy.Appearance.BackColor = Color.Red; // Nền đỏ
            btnHuy.Appearance.ForeColor = Color.White; // Chữ trắng
            btnHuy.Appearance.Font = new Font("Arial", 10, FontStyle.Bold); // Font chữ
            btnHuy.Appearance.Options.UseBackColor = true; // Áp dụng màu nền
            btnHuy.Appearance.Options.UseForeColor = true; // Áp dụng màu chữ

            // Ẩn TextEdit
            btnHuy.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;

            // Gắn sự kiện click
            btnHuy.ButtonClick += BtnHuy_ButtonClick;

            // Thêm nút vào GridControl
            var gridView = gc_DSTH.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (gridView != null)
            {
                var colHuy = gridView.Columns["Action"];
                if (colHuy == null)
                {
                    // Nếu cột chưa tồn tại, tạo mới
                    colHuy = new DevExpress.XtraGrid.Columns.GridColumn
                    {
                        Caption = "Chức năng",
                        FieldName = "Action", // Không bắt buộc
                        ColumnEdit = btnHuy,
                        Visible = true,
                        Width = 50 // Đặt độ rộng phù hợp
                    };

                    // Canh giữa tiêu đề cột
                    colHuy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                    // Canh giữa nội dung cột
                    colHuy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                    gridView.Columns.Add(colHuy);
                }
                else
                {
                    colHuy.ColumnEdit = btnHuy; // Gắn lại ColumnEdit nếu đã tồn tại
                    colHuy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center; // Canh giữa tiêu đề
                    colHuy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center; // Canh giữa nội dung
                }

                gridView.RefreshData(); // Làm mới GridView
            }
        }





        private void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "Action") // Chỉ áp dụng cho cột "Action"
            {
                // Kiểm tra nếu hàng được chọn (giả lập hiệu ứng "Pressed")
                if (e.RowHandle == (sender as DevExpress.XtraGrid.Views.Grid.GridView)?.FocusedRowHandle)
                {
                    e.Appearance.BackColor = Color.Maroon; // Màu nền khi nhấn
                    e.Appearance.ForeColor = Color.White; // Màu chữ khi nhấn
                }
                else
                {
                    // Màu nền khi hover
                    e.Appearance.BackColor = Color.DarkRed;
                    e.Appearance.ForeColor = Color.White;
                }
            }
        }





        private void BtnHuy_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView = gc_DSTH.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            if (gridView != null)
            {
                int rowIndex = gridView.FocusedRowHandle;

                if (rowIndex >= 0)
                {
                    string idThuocHuy = gridView.GetRowCellValue(rowIndex, "Mã Thuốc Hủy")?.ToString();
                    DateTime ngayHuy = Convert.ToDateTime(gridView.GetRowCellValue(rowIndex, "Ngày Hủy"));

                    // Kiểm tra nếu ngày hiện tại chưa tới ngày hủy
                    if (DateTime.Now.Date < ngayHuy.Date)
                    {
                        DialogResult confirmEarlyCancel = MessageBox.Show(
                            $"Chưa tới thời gian hủy ({ngayHuy:dd/MM/yyyy}). Bạn có muốn hủy trước thời hạn không?",
                            "Xác nhận hủy trước thời hạn",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (confirmEarlyCancel != DialogResult.Yes)
                        {
                            // Nếu chọn "No", thoát mà không làm gì
                            return;
                        }
                    }

                    // Hiển thị xác nhận hủy
                    DialogResult confirm = MessageBox.Show(
                        $"Bạn có chắc chắn muốn hủy thuốc với ID: {idThuocHuy}?",
                        "Xác nhận hủy",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (confirm == DialogResult.Yes)
                    {
                        try
                        {
                            // Cập nhật trạng thái thuốc thành "Đã hủy"
                            bool isUpdated = thuocHuyBLL.CapNhatTinhTrangThuocHuy(idThuocHuy, "Đã hủy");

                            if (isUpdated)
                            {
                                MessageBox.Show("Hủy thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Cập nhật lại danh sách
                                LoadDanhSachThuocHuy_ChoHuy();
                                LoadDanhSachThuocHuy_DaHuy();
                            }
                            else
                            {
                                MessageBox.Show("Không thể cập nhật trạng thái thuốc hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi hủy thuốc: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }








    }
}
