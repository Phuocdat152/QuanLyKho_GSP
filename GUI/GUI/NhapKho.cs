using BLL;
using DAL;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DTO;

namespace GUI
{
    public partial class NhapKho : Form
    {
        private NhaCungCapBLL nhaCungCapBLL;
        private KhoBLL khoBLL;
        private ThuocBLL thuocBLL;
        private NhapKhoBLL nhapKhoBLL;
        private UserBLL userBLL;
        private Dictionary<string, string> drugIDNameDict = new Dictionary<string, string>();
        private RepositoryItemComboBox comboBoxTenThuoc; 

        public NhapKho(string username, string password)
        {
            InitializeComponent();
            nhaCungCapBLL = new NhaCungCapBLL(username, password);
            khoBLL = new KhoBLL(username, password);
            thuocBLL = new ThuocBLL(username, password);
            nhapKhoBLL = new NhapKhoBLL(username, password);
            userBLL = new UserBLL(username, password);

            HienThiTenNhanVien(username);


        }

        private void LoadNhaCungCapToComboBox()
        {
            try
            {
                Dictionary<string, string> nhaCCList = nhaCungCapBLL.GetAllTenNhaCC();

                cb_NhaCC.Items.Clear();

                foreach (var item in nhaCCList)
                {
                    cb_NhaCC.Items.Add(new KeyValuePair<string, string>(item.Key, item.Value));
                }

                cb_NhaCC.DisplayMember = "Value";
                cb_NhaCC.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải tên nhà cung cấp: " + ex.Message);
            }
        }

        private void LoadKhoToComboBox()
        {
            try
            {
                Dictionary<string, string> loaiKhoList = khoBLL.GetAllLoaiKho();

                cb_Kho.Items.Clear();

                foreach (var item in loaiKhoList)
                {
                    cb_Kho.Items.Add(new KeyValuePair<string, string>(item.Key, item.Value));
                }

                cb_Kho.DisplayMember = "Value";
                cb_Kho.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải loại kho: " + ex.Message);
            }
        }

        private void HienThiTenNhanVien(string username)
        {
            try
            {
                DataRow nhanVienInfo = userBLL.GetNhanVienByUsername(username);
                if (nhanVienInfo != null)
                {
                    string tenNhanVien = nhanVienInfo["TenNhanVien"].ToString();
                    string idNhanVien = nhanVienInfo["IDNhanVien"].ToString();

                    txt_NhanVien.Text = tenNhanVien;   // Hiển thị tên nhân viên
                    txt_IDNhanVien.Text = idNhanVien; // Lưu ID nhân viên vào TextBox ẩn
                }
                else
                {
                    txt_NhanVien.Text = "Không tìm thấy tên nhân viên";
                    txt_IDNhanVien.Text = ""; // Xóa giá trị nếu không tìm thấy
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị tên nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NhapKho_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhieuNhap();
            LoadNhaCungCapToComboBox();
            LoadKhoToComboBox();
            LoadThuocIntoComboBox();
            AddCot();

            dte_NgayNhap.EditValue = DateTime.Today;

            gv_SanPham.CellValueChanged += gv_SanPham_CellValueChanged;
            CalculateTotalAmount();
        }






        private void AddCot()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Tên thuốc", typeof(string));
            dataTable.Columns.Add("Mã thuốc", typeof(string));
            dataTable.Columns.Add("Ngày sản xuất", typeof(DateTime));
            dataTable.Columns.Add("Ngày hết hạn", typeof(DateTime));
            dataTable.Columns.Add("ĐVT", typeof(string));
            dataTable.Columns.Add("Số lượng", typeof(int));
            dataTable.Columns.Add("Đơn giá", typeof(float));
            dataTable.Columns.Add("Thành tiền", typeof(float));

            gc_SanPham.DataSource = dataTable;

            gv_SanPham.PopulateColumns();

            // Định dạng cột Thành tiền là tiền tệ
            GridColumn colThanhTien = gv_SanPham.Columns["Thành tiền"];
            if (colThanhTien != null)
            {
                colThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                colThanhTien.DisplayFormat.FormatString = "#,##0 ₫"; // Định dạng với dấu phân cách hàng nghìn và ký hiệu "₫"
            }

            // Thêm RepositoryItemDateEdit cho các cột ngày
            RepositoryItemDateEdit dateEdit = new RepositoryItemDateEdit();
            dateEdit.DisplayFormat.FormatString = "dd/MM/yyyy";
            dateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateEdit.EditFormat.FormatString = "dd/MM/yyyy";
            dateEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;

            gv_SanPham.Columns["Ngày sản xuất"].ColumnEdit = dateEdit;
            gv_SanPham.Columns["Ngày hết hạn"].ColumnEdit = dateEdit;

            // Gán lại ComboBox cho cột "Tên thuốc"
            LoadThuocIntoComboBox();
        }



        private void LoadThuocIntoComboBox()
        {
            DataTable dtThuoc = thuocBLL.GetThuocInfo();

            if (dtThuoc != null && dtThuoc.Rows.Count > 0)
            {
                // Khởi tạo RepositoryItemComboBox
                RepositoryItemComboBox comboBox = new RepositoryItemComboBox();

                // Xóa và nạp lại dữ liệu trong Dictionary
                drugIDNameDict.Clear();

                foreach (DataRow row in dtThuoc.Rows)
                {
                    string drugName = row["TenThuoc"].ToString();
                    string drugID = row["IDThuoc"].ToString();
                    comboBox.Items.Add(drugName);
                    drugIDNameDict[drugName] = drugID;
                }

                // Kiểm tra sự tồn tại của cột "Tên thuốc"
                GridColumn colTenThuoc = gv_SanPham.Columns["Tên thuốc"];
                if (colTenThuoc == null)
                {
                    colTenThuoc = gv_SanPham.Columns.AddField("Tên thuốc");
                    colTenThuoc.Visible = true;
                }

                // Gán RepositoryItemComboBox vào cột "Tên thuốc"
                colTenThuoc.ColumnEdit = comboBox;

                // Đảm bảo cột hiển thị đúng kiểu
                colTenThuoc.UnboundType = DevExpress.Data.UnboundColumnType.String;

                // Sự kiện khi người dùng thay đổi giá trị trong ComboBox
                comboBox.EditValueChanged += ComboBox_EditValueChanged;

                // Sự kiện khi người dùng bắt đầu chỉnh sửa cột "Tên thuốc"
                gv_SanPham.CustomRowCellEdit += (sender, e) =>
                {
                    if (e.Column.FieldName == "Tên thuốc")
                    {
                        e.RepositoryItem = comboBox;
                    }
                };

                // Làm mới lại GridView để áp dụng thay đổi
                gv_SanPham.RefreshData();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu thuốc.");
            }
        }


        private void ComboBox_EditValueChanged(object sender, EventArgs e)
        {
            if (sender is DevExpress.XtraEditors.ComboBoxEdit editor)
            {
                string selectedDrugName = editor.EditValue?.ToString();

                if (!string.IsNullOrEmpty(selectedDrugName) && drugIDNameDict.ContainsKey(selectedDrugName))
                {
                    // Lấy ID thuốc từ dictionary
                    string drugID = drugIDNameDict[selectedDrugName];

                    // Lấy thông tin thuốc từ DataTable hoặc từ cơ sở dữ liệu
                    DataTable dtThuoc = thuocBLL.GetThuocInfo(); // Bạn có thể gọi lại hàm này nếu cần hoặc dùng dữ liệu đã có
                    DataRow selectedDrug = dtThuoc.AsEnumerable().FirstOrDefault(row => row["TenThuoc"].ToString() == selectedDrugName);

                    if (selectedDrug != null)
                    {
                        // Cập nhật các cột trong GridView
                        gv_SanPham.SetFocusedRowCellValue("Mã thuốc", drugID);
                        gv_SanPham.SetFocusedRowCellValue("ĐVT", selectedDrug["TenDVT"].ToString());
                        gv_SanPham.SetFocusedRowCellValue("Đơn giá", Convert.ToSingle(selectedDrug["DonGia"]));

                        // Cập nhật thành tiền khi có thay đổi Đơn giá và Số lượng
                        // Lưu ý bạn có thể thêm logic để tính lại thành tiền dựa trên Số lượng và Đơn giá
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin thuốc.");
                    }
                }
                else
                {
                    // Nếu tên thuốc không hợp lệ trong Dictionary, xóa thông tin
                    gv_SanPham.SetFocusedRowCellValue("Mã thuốc", null);
                    gv_SanPham.SetFocusedRowCellValue("ĐVT", null);
                    gv_SanPham.SetFocusedRowCellValue("Đơn giá", null);
                    MessageBox.Show("Vui lòng chọn tên thuốc hợp lệ.");
                }
            }
        }

        private void gv_SanPham_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            // Kiểm tra xem có phải cột "Số lượng", "Đơn giá" hoặc "Thành tiền" thay đổi không
            if (e.Column.FieldName == "Số lượng" || e.Column.FieldName == "Đơn giá")
            {
                // Cập nhật lại Thành tiền cho dòng hiện tại
                UpdateThanhTienForRow(e.RowHandle);
            }

            // Sau khi cập nhật Thành tiền, tính lại tổng tiền
            CalculateTotalAmount();
        }

        private void UpdateThanhTienForRow(int rowHandle)
        {
            // Lấy giá trị Số lượng và Đơn giá từ dòng hiện tại
            object soLuongObj = gv_SanPham.GetRowCellValue(rowHandle, "Số lượng");
            object donGiaObj = gv_SanPham.GetRowCellValue(rowHandle, "Đơn giá");

            // Kiểm tra nếu cả Số lượng và Đơn giá đều hợp lệ
            if (soLuongObj != DBNull.Value && donGiaObj != DBNull.Value)
            {
                int soLuong = Convert.ToInt32(soLuongObj);
                float donGia = Convert.ToSingle(donGiaObj);

                // Tính Thành tiền và cập nhật lại cho dòng hiện tại
                float thanhTien = soLuong * donGia;
                gv_SanPham.SetRowCellValue(rowHandle, "Thành tiền", thanhTien);
            }
        }


        private void CalculateTotalAmount()
        {
            // Khai báo biến để lưu tổng tiền
            float totalAmount = 0;

            // Duyệt qua tất cả các dòng trong GridView
            for (int i = 0; i < gv_SanPham.RowCount; i++)
            {
                // Lấy giá trị Thành tiền của dòng hiện tại
                object thanhTienObj = gv_SanPham.GetRowCellValue(i, "Thành tiền");

                // Kiểm tra nếu Thành tiền không phải DBNull
                if (thanhTienObj != DBNull.Value)
                {
                    float thanhTien = Convert.ToSingle(thanhTienObj);

                    // Cộng vào tổng tiền
                    totalAmount += thanhTien;
                }
            }

            // Cập nhật tổng tiền vào TextBox
            txt_TongTien.Text = totalAmount.ToString("#,##0 ₫");  // Định dạng tiền tệ (Có thể thay đổi theo yêu cầu)
        }





        private void btn_ThemSP_Click(object sender, EventArgs e)
        {
            if (gc_SanPham.DataSource == null || !(gc_SanPham.DataSource is DataTable))
            {
                MessageBox.Show("DataSource của GridControl chưa được thiết lập hoặc không phải là DataTable.");
                return;
            }

            DataTable dataTable = (DataTable)gc_SanPham.DataSource;

            // Tạo một dòng mới và thêm vào DataTable
            DataRow newRow = dataTable.NewRow();
            dataTable.Rows.Add(newRow);

            // Gán lại RepositoryItemComboBox cho cột "Tên thuốc" sau khi thêm dòng
            LoadThuocIntoComboBox();

            // Hiển thị dòng mới trong GridView để người dùng có thể nhập liệu
            gv_SanPham.FocusedRowHandle = gv_SanPham.RowCount - 1;
            gv_SanPham.ShowEditor();

            // Tính tổng tiền lại sau khi thêm sản phẩm
            CalculateTotalAmount();
        }

        private void btn_XoaSP_Click(object sender, EventArgs e)
        {
            if (gv_SanPham.FocusedRowHandle < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataTable dataTable = (DataTable)gc_SanPham.DataSource;
                int selectedRowIndex = gv_SanPham.FocusedRowHandle;

                // Xóa dòng khỏi DataTable
                dataTable.Rows[selectedRowIndex].Delete();


                // Cập nhật lại GridControl
                gc_SanPham.RefreshDataSource();
                gv_SanPham.RefreshData();

                CalculateTotalAmount() ;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu trong GridControl và tạo một DataTable trống để làm sạch DataSource
            if (gc_SanPham.DataSource is DataTable dataTable)
            {
                dataTable.Clear(); // Xóa tất cả các dòng trong DataTable
                gc_SanPham.DataSource = dataTable;
            }
            else
            {
                DataTable emptyDataTable = new DataTable();
                emptyDataTable.Columns.Add("Tên thuốc", typeof(string));
                emptyDataTable.Columns.Add("Mã thuốc", typeof(string));
                emptyDataTable.Columns.Add("Ngày sản xuất", typeof(DateTime));
                emptyDataTable.Columns.Add("Ngày hết hạn", typeof(DateTime));
                emptyDataTable.Columns.Add("ĐVT", typeof(string));
                emptyDataTable.Columns.Add("Số lượng", typeof(int));
                emptyDataTable.Columns.Add("Đơn giá", typeof(float));
                emptyDataTable.Columns.Add("Thành tiền", typeof(float));

                gc_SanPham.DataSource = emptyDataTable;
            }
            gv_SanPham.RefreshData(); // Làm mới lại GridView

            // Xóa dữ liệu trong các TextBox
            txt_GhiChu.Clear();
            txt_TongTien.Clear();
            txt_TrangThai.Clear();
            txt_NhanVien.Clear();

            txt_GhiChu.Enabled = true;

            // Đặt lại lựa chọn trong ComboBox (về trạng thái không có mục nào được chọn)
            cb_Kho.SelectedIndex = -1;
            cb_NhaCC.SelectedIndex = -1;
            cb_Kho.Enabled = true;
            cb_NhaCC.Enabled = true;
            

            btn_Luu.Enabled = true;
            btn_ThemSP.Enabled = true;
            btn_XoaSP.Enabled = true;
            btn_Them.Enabled = false;
            btn_Xoa.Enabled = false;

            gc_SanPham.DataSource = null;

            dte_NgayNhap.EditValue = DateTime.Today;

            // Khởi tạo lại các cột trong lưới mà không thêm trùng lặp
            InitializeSanPhamGridColumns();
        }

        private void InitializeSanPhamGridColumns()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Tên thuốc", typeof(string));
            dataTable.Columns.Add("Mã thuốc", typeof(string));
            dataTable.Columns.Add("Ngày sản xuất", typeof(DateTime));
            dataTable.Columns.Add("Ngày hết hạn", typeof(DateTime));
            dataTable.Columns.Add("ĐVT", typeof(string));
            dataTable.Columns.Add("Số lượng", typeof(int));
            dataTable.Columns.Add("Đơn giá", typeof(float));
            dataTable.Columns.Add("Thành tiền", typeof(float));

            gc_SanPham.DataSource = dataTable;
            gv_SanPham.PopulateColumns();

            // Định dạng cột "Thành tiền" (nếu cần)
            GridColumn colThanhTien = gv_SanPham.Columns["Thành tiền"];
            if (colThanhTien != null)
            {
                colThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                colThanhTien.DisplayFormat.FormatString = "#,##0 ₫";
            }
        }


        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các điều khiển trên form
                string idKho = (cb_Kho.SelectedItem as KeyValuePair<string, string>?).Value.Key ?? "";
                string idNhaCC = (cb_NhaCC.SelectedItem as KeyValuePair<string, string>?).Value.Key ?? "";
                string idNhanVien = txt_IDNhanVien.Text; // Lấy ID nhân viên từ TextBox ẩn
                string ghiChu = txt_GhiChu.Text;
                DateTime ngayNhap = dte_NgayNhap.EditValue == null ? DateTime.Now : (DateTime)dte_NgayNhap.EditValue;

                // Kiểm tra dữ liệu đầu vào cần thiết
                if (string.IsNullOrEmpty(idKho) || string.IsNullOrEmpty(idNhaCC))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy danh sách chi tiết phiếu nhập từ GridView
                List<ChiTietNhapKhoDTO> chiTietPhieuNhapList = new List<ChiTietNhapKhoDTO>();
                DataTable dataTable = gc_SanPham.DataSource as DataTable;

                if (dataTable != null)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Kiểm tra các trường bắt buộc
                        if (row["Tên thuốc"] == DBNull.Value || row["Số lượng"] == DBNull.Value || row["Đơn giá"] == DBNull.Value)
                            continue;

                        ChiTietNhapKhoDTO chiTiet = new ChiTietNhapKhoDTO
                        {
                            IDThuoc = drugIDNameDict.ContainsKey(row["Tên thuốc"].ToString()) ? drugIDNameDict[row["Tên thuốc"].ToString()] : "",
                            NgaySanXuat = row["Ngày sản xuất"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(row["Ngày sản xuất"]),
                            NgayHetHan = row["Ngày hết hạn"] == DBNull.Value ? DateTime.Now.AddMonths(6) : Convert.ToDateTime(row["Ngày hết hạn"]),
                            QuyCach = row["ĐVT"].ToString(),
                            SoLuong = Convert.ToInt32(row["Số lượng"]),
                            GiaDonVi = Convert.ToSingle(row["Đơn giá"]),
                            ThanhTien = Convert.ToInt32(row["Số lượng"]) * Convert.ToSingle(row["Đơn giá"]) // Tính Thành tiền
                        };
                        chiTietPhieuNhapList.Add(chiTiet);
                    }
                }

                if (chiTietPhieuNhapList.Count == 0)
                {
                    MessageBox.Show("Danh sách chi tiết phiếu nhập trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận trước khi lưu
                DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn muốn lưu phiếu nhập này?", "Xác nhận lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.No)
                {
                    return;
                }

                // Gọi hàm lưu vào cơ sở dữ liệu
                string newPhieuNhapID = nhapKhoBLL.ThemPhieuNhapVaChiTiet(
                    ngayNhap,
                    idKho,
                    idNhaCC,
                    idNhanVien,
                    ghiChu,
                    chiTietPhieuNhapList
                );

                // Kiểm tra giá trị trả về
                if (!string.IsNullOrEmpty(newPhieuNhapID))
                {
                    MessageBox.Show($"Thêm phiếu nhập thành công với ID: {newPhieuNhapID}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm(); // Reset dữ liệu sau khi lưu thành công
                    LoadDanhSachPhieuNhap();
                    // Xóa dữ liệu trong các TextBox
                    txt_GhiChu.Clear();
                    txt_TongTien.Clear();
                    txt_TrangThai.Clear();
                    txt_NhanVien.Clear();

                    txt_GhiChu.Enabled = false;

                    // Đặt lại lựa chọn trong ComboBox (về trạng thái không có mục nào được chọn)
                    cb_Kho.SelectedIndex = -1;
                    cb_NhaCC.SelectedIndex = -1;
                    cb_Kho.Enabled = false;
                    cb_NhaCC.Enabled = false;


                    btn_Luu.Enabled = false;
                    btn_ThemSP.Enabled = false;
                    btn_XoaSP.Enabled = false;
                    btn_Them.Enabled = true;
                    btn_Xoa.Enabled = true;

                    gc_SanPham.DataSource = null;

                    dte_NgayNhap.EditValue = DateTime.Today;
                }
                else
                {
                    MessageBox.Show("Tạo phiếu thất bại: ID rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu phiếu nhập: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            // Xóa dữ liệu trong GridControl và tạo một DataTable trống để làm sạch DataSource
            DataTable emptyDataTable = new DataTable();
            emptyDataTable.Columns.Add("Tên thuốc", typeof(string));
            emptyDataTable.Columns.Add("Mã thuốc", typeof(string));
            emptyDataTable.Columns.Add("Ngày sản xuất", typeof(DateTime));
            emptyDataTable.Columns.Add("Ngày hết hạn", typeof(DateTime));
            emptyDataTable.Columns.Add("ĐVT", typeof(string));
            emptyDataTable.Columns.Add("Số lượng", typeof(int));
            emptyDataTable.Columns.Add("Đơn giá", typeof(float));
            emptyDataTable.Columns.Add("Thành tiền", typeof(float));

            gc_SanPham.DataSource = emptyDataTable;
            gv_SanPham.RefreshData(); // Làm mới lại GridView

            // Xóa dữ liệu trong các TextBox
            txt_GhiChu.Clear();
            txt_TongTien.Clear();
            txt_NhanVien.Clear();
            txt_TrangThai.Clear();

            // Đặt lại lựa chọn trong ComboBox
            cb_Kho.SelectedIndex = -1;
            cb_NhaCC.SelectedIndex = -1;

            // Đặt lại DateEdit (xóa giá trị ngày)
            dte_NgayNhap.EditValue = null;

            // Gọi lại AddCot và LoadThuocIntoComboBox để đảm bảo ComboBox vẫn hoạt động như mong muốn
            AddCot();
            LoadThuocIntoComboBox();
        }

        private void LoadDanhSachPhieuNhap()
        {
            try
            {
                DataTable dtPhieuNhap = nhapKhoBLL.HienThiPhieuNhap();
                dgv_PhieuNhap.DataSource = dtPhieuNhap;

                // Ẩn tất cả các cột trước
                foreach (DataGridViewColumn column in dgv_PhieuNhap.Columns)
                {
                    column.Visible = false;
                }

                // Chỉ hiển thị các cột cần thiết
                dgv_PhieuNhap.Columns["IDPhieuNhap"].Visible = true;
                dgv_PhieuNhap.Columns["NgayNhap"].Visible = true;
                dgv_PhieuNhap.Columns["TrangThai"].Visible = true;

                // Đặt tiêu đề cho các cột (nếu cần)
                dgv_PhieuNhap.Columns["IDPhieuNhap"].HeaderText = "Mã Phiếu Nhập";
                dgv_PhieuNhap.Columns["NgayNhap"].HeaderText = "Ngày Nhập";
                dgv_PhieuNhap.Columns["TrangThai"].HeaderText = "Trạng Thái";

                // Canh đều các cột trong DataGridView
                foreach (DataGridViewColumn column in dgv_PhieuNhap.Columns)
                {
                    if (column.Visible)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Tự động giãn đều
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa nội dung
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Căn giữa tiêu đề
                    }
                }

                // Tùy chỉnh thêm nếu cần
                dgv_PhieuNhap.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách phiếu nhập: " + ex.Message);
            }
        }


        private void dgv_PhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy IDPhieuNhap từ dòng được chọn
                string idPhieuNhap = dgv_PhieuNhap.Rows[e.RowIndex].Cells["IDPhieuNhap"].Value.ToString();

                try
                {
                    // Gọi BLL để lấy thông tin phiếu nhập và chi tiết phiếu nhập
                    DataSet dsPhieuNhap = nhapKhoBLL.LayThongTinPhieuNhapTheoID(idPhieuNhap);

                    // Hiển thị thông tin phiếu nhập
                    if (dsPhieuNhap.Tables[0].Rows.Count > 0)
                    {
                        DataRow phieuNhapRow = dsPhieuNhap.Tables[0].Rows[0];

                        // Hiển thị thông tin phiếu nhập lên các điều khiển
                        txt_IDPN.Text = phieuNhapRow["IDPhieuNhap"].ToString();
                        dte_NgayNhap.EditValue = Convert.ToDateTime(phieuNhapRow["NgayNhap"]);

                        // Hiển thị loại kho
                        cb_Kho.SelectedItem = cb_Kho.Items.Cast<KeyValuePair<string, string>>()
                            .FirstOrDefault(item => item.Value == phieuNhapRow["LoaiKho"].ToString());

                        // Hiển thị nhà cung cấp
                        cb_NhaCC.SelectedItem = cb_NhaCC.Items.Cast<KeyValuePair<string, string>>()
                            .FirstOrDefault(item => item.Value == phieuNhapRow["TenNhaCC"].ToString());

                        // Hiển thị tên nhân viên trong TextBox
                        txt_NhanVien.Text = phieuNhapRow["TenNhanVien"].ToString();

                        // Hiển thị ghi chú và tổng tiền
                        txt_GhiChu.Text = phieuNhapRow["GhiChu"].ToString();
                        txt_TongTien.Text = Convert.ToDecimal(phieuNhapRow["TongTien"]).ToString("#,##0 ₫");

                        // Hiển thị trạng thái trong TextBox
                        txt_TrangThai.Text = phieuNhapRow["TrangThai"].ToString();
                    }

                    // Hiển thị chi tiết phiếu nhập
                    if (dsPhieuNhap.Tables[1].Rows.Count > 0)
                    {
                        gc_SanPham.DataSource = dsPhieuNhap.Tables[1];
                        gv_SanPham.PopulateColumns();

                        // Ẩn cột IDChiTietPhieuNhap
                        if (gv_SanPham.Columns["IDChiTietPhieuNhap"] != null)
                        {
                            gv_SanPham.Columns["IDChiTietPhieuNhap"].Visible = false;
                        }

                        // Đặt tên cho các cột trong GridView
                        gv_SanPham.Columns["TenThuoc"].Caption = "Tên thuốc";
                        gv_SanPham.Columns["IDThuoc"].Caption = "Mã thuốc";
                        gv_SanPham.Columns["NgaySanXuat"].Caption = "Ngày sản xuất";
                        gv_SanPham.Columns["NgayHetHan"].Caption = "Ngày hết hạn";
                        gv_SanPham.Columns["QuyCach"].Caption = "Quy cách";
                        gv_SanPham.Columns["SoLuong"].Caption = "Số lượng";
                        gv_SanPham.Columns["GiaDonVi"].Caption = "Giá đơn vị";
                        gv_SanPham.Columns["ThanhTien"].Caption = "Thành tiền";

                        // Định dạng cột Thành tiền trong GridView
                        gv_SanPham.Columns["ThanhTien"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        gv_SanPham.Columns["ThanhTien"].DisplayFormat.FormatString = "#,##0 ₫";
                    }
                    else
                    {
                        gc_SanPham.DataSource = null;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hiển thị chi tiết phiếu nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
