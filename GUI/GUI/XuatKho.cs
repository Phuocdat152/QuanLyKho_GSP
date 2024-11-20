using BLL;
using DAL;
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

namespace GUI
{
    public partial class XuatKho : Form
    {
        private KhoBLL khoBLL;
        private XuatKhoBLL xuatKhoBLL;
        private ThuocBLL thuocBLL;
        private UserBLL userBLL;
        public XuatKho(string username, string password)
        {
            InitializeComponent();
            khoBLL = new KhoBLL(username, password);
            xuatKhoBLL = new XuatKhoBLL(username, password);
            thuocBLL = new ThuocBLL(username,password);
            userBLL = new UserBLL(username, password);
            HienThiTenNhanVien(username);
            txt_IDNhanVien.Visible = false;


            var gridView = gc_SanPham.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (gridView != null)
            {
                gridView.CellValueChanged += gv_SanPham_CellValueChanged; // Thêm sự kiện
            }
        }

        private void LoadKhoToComboBox()
        {
            try
            {
                Dictionary<string, string> loaiKhoList = khoBLL.GetAllLoaiKho();

                cb_KhoXuat.Items.Clear();

                foreach (var item in loaiKhoList)
                {
                    cb_KhoXuat.Items.Add(new KeyValuePair<string, string>(item.Key, item.Value));
                }

                cb_KhoXuat.DisplayMember = "Value";
                cb_KhoXuat.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải loại kho: " + ex.Message);
            }
        }


        private void LoadKhoDenToComboBox()
        {
            try
            {
                // Gọi phương thức từ BLL để lấy danh sách Kho Đến
                DataTable khoDenData = xuatKhoBLL.HienThiThongTinKhoDen();

                if (khoDenData != null && khoDenData.Rows.Count > 0)
                {
                    cb_KhoNhan.DataSource = khoDenData;
                    cb_KhoNhan.DisplayMember = "TenKhoDen"; // Hiển thị Tên Kho Đến
                    cb_KhoNhan.ValueMember = "IDKhoDen";    // Lưu giá trị là IDKhoDen
                    cb_KhoNhan.SelectedIndex = -1;          // Đặt mặc định là chưa chọn
                }
                else
                {
                    cb_KhoNhan.DataSource = null; // Xóa dữ liệu nếu không có gì
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu Kho Nhận: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LoadThuocToComboBox()
        {
            try
            {
                // Gọi phương thức từ BLL để lấy danh sách thuốc
                DataTable thuocData = thuocBLL.GetThuocInfo();

                if (thuocData != null && thuocData.Rows.Count > 0)
                {
                    // Gán dữ liệu vào ComboBox
                    cb_ChonThuoc.DataSource = thuocData;
                    cb_ChonThuoc.DisplayMember = "TenThuoc"; // Tên cột hiển thị
                    cb_ChonThuoc.ValueMember = "IDThuoc";   // Tên cột giá trị
                    cb_ChonThuoc.SelectedIndex = -1; // Đặt mặc định là chưa chọn
                }
                else
                {
                    // Xóa dữ liệu nếu không có gì
                    cb_ChonThuoc.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu thuốc vào ComboBox: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ConfigureGridColumnHeaders()
        {
            var gridView = gc_SanPham.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            if (gridView != null)
            {
                // Đặt tên tiêu đề cho cột nếu cột tồn tại
                if (gridView.Columns["IDLuuTru"] != null)
                    gridView.Columns["IDLuuTru"].Caption = "Mã Lưu Trữ";

                if (gridView.Columns["IDChiTietPhieuNhap"] != null)
                    gridView.Columns["IDChiTietPhieuNhap"].Caption = "Mã CTPN";

                if (gridView.Columns["TenThuoc"] != null)
                    gridView.Columns["TenThuoc"].Caption = "Tên Thuốc";

                if (gridView.Columns["IDThuoc"] != null)
                    gridView.Columns["IDThuoc"].Caption = "Mã Thuốc";

                if (gridView.Columns["ViTri"] != null)
                    gridView.Columns["ViTri"].Caption = "Vị Trí";

                if (gridView.Columns["SLTon"] != null)
                    gridView.Columns["SLTon"].Caption = "SL Tồn";

                if (gridView.Columns["NgayNhap"] != null)
                    gridView.Columns["NgayNhap"].Caption = "Ngày Nhập";

                if (gridView.Columns["SoLuongXuat"] != null)
                    gridView.Columns["SoLuongXuat"].Caption = "SL Xuất";

                if (gridView.Columns["QuyCach"] != null)
                    gridView.Columns["QuyCach"].Caption = "ĐVT";

                if (gridView.Columns["GiaDonVi"] != null)
                    gridView.Columns["GiaDonVi"].Caption = "Đơn giá";

                if (gridView.Columns["ThanhTien"] != null)
                    gridView.Columns["ThanhTien"].Caption = "Thành tiền";

                // Căn giữa tiêu đề của tất cả các cột
                foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                {
                    column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                }

                // Làm mới GridView để áp dụng các cài đặt
                gridView.RefreshData();
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

                    txt_NguoiLap.Text = tenNhanVien;   // Hiển thị tên nhân viên
                    txt_IDNhanVien.Text = idNhanVien; // Lưu ID nhân viên vào TextBox ẩn
                }
                else
                {
                    txt_NguoiLap.Text = "Không tìm thấy tên nhân viên";
                    txt_IDNhanVien.Text = ""; // Xóa giá trị nếu không tìm thấy
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị tên nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void EnableAllControls()
        {
            cb_KhoXuat.Enabled = true;
            cb_KhoNhan.Enabled = true;
            txt_GhiChu.Enabled = true;
            cb_ChonThuoc.Enabled = true;
            num_SoLuong.Enabled = true;
            btn_ThemSP.Enabled = true;
            btn_XoaSP.Enabled = true;
            btn_Luu.Enabled = true;
            btn_Them.Enabled = false;
        }

        private void DisEnableAllControls()
        {
            cb_KhoXuat.Enabled = false;
            cb_KhoNhan.Enabled = false;
            txt_GhiChu.Enabled = false;
            cb_ChonThuoc.Enabled = false;
            num_SoLuong.Enabled = false;
            btn_ThemSP.Enabled = false;
            btn_XoaSP.Enabled = false;
            btn_Luu.Enabled = false;
            btn_Them.Enabled = true;
        }


        private void gv_SanPham_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var gridView = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (gridView != null && (e.Column.FieldName == "SoLuongXuat" || e.Column.FieldName == "GiaDonVi"))
            {
                int rowIndex = e.RowHandle;

                // Kiểm tra và cập nhật Thành tiền nếu cả hai cột đều đã có giá trị
                object soLuongValue = gridView.GetRowCellValue(rowIndex, "SoLuongXuat");
                object giaDonViValue = gridView.GetRowCellValue(rowIndex, "GiaDonVi");

                if (soLuongValue != DBNull.Value && giaDonViValue != DBNull.Value)
                {
                    int soLuongXuat = int.TryParse(soLuongValue.ToString(), out int sl) ? sl : 0;
                    float giaDonVi = float.TryParse(giaDonViValue.ToString(), out float gdv) ? gdv : 0;

                    // Tính Thành tiền
                    float thanhTien = soLuongXuat * giaDonVi;

                    // Ghi lại giá trị Thành tiền vào GridView
                    gridView.SetRowCellValue(rowIndex, "ThanhTien", thanhTien);

                    // Cập nhật lại Tổng tiền
                    CapNhatTongTien();
                }
            }
        }


        private void CapNhatTongTien()
        {
            var gridView = gc_SanPham.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (gridView != null)
            {
                float tongTien = 0;

                // Duyệt qua tất cả các dòng trong GridView
                for (int i = 0; i < gridView.RowCount; i++)
                {
                    object thanhTienValue = gridView.GetRowCellValue(i, "ThanhTien");

                    if (thanhTienValue != DBNull.Value && float.TryParse(thanhTienValue.ToString(), out float thanhTien))
                    {
                        tongTien += thanhTien;
                    }
                }

                // Hiển thị Tổng tiền vào TextBox
                txt_TongTien.Text = tongTien.ToString("#,##0 ₫"); // Định dạng tiền tệ
            }
        }






        private DataTable CreateDataSource()
        {
            DataTable table = new DataTable();
            table.Columns.Add("IDLuuTru", typeof(string));
            table.Columns.Add("IDChiTietPhieuNhap", typeof(string));
            table.Columns.Add("TenThuoc", typeof(string));
            table.Columns.Add("IDThuoc", typeof(string));
            table.Columns.Add("ViTri", typeof(string));
            table.Columns.Add("SLTon", typeof(int));
            table.Columns.Add("NgayNhap", typeof(DateTime));
            table.Columns.Add("SoLuongXuat", typeof(int)); // Đặt giá trị mặc định là 0
            table.Columns.Add("QuyCach", typeof(string));
            table.Columns.Add("GiaDonVi", typeof(float)); // Đặt giá trị mặc định là 0
            table.Columns.Add("ThanhTien", typeof(float));
            return table;
        }




        private void XuatKho_Load(object sender, EventArgs e)
        {
            dte_NgayXuat.DateTime = DateTime.Now;

            // Khởi tạo dữ liệu
            gc_SanPham.DataSource = CreateDataSource();

            // Cấu hình tiêu đề cột
            ConfigureGridColumnHeaders();

            // Nạp dữ liệu cho ComboBox
            LoadKhoToComboBox();
            LoadKhoDenToComboBox();
            LoadThuocToComboBox();
            LoadDanhSachPhieuXuat();

            // Đảm bảo sự kiện được gắn
            var gridView = gc_SanPham.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (gridView != null)
            {
                gridView.CellValueChanged += gv_SanPham_CellValueChanged; // Gắn sự kiện
            }
        }

        private void btn_ThemSP_Click(object sender, EventArgs e)
        {
            try
            {
                string idThuoc = cb_ChonThuoc.SelectedValue?.ToString();
                if (string.IsNullOrEmpty(idThuoc))
                {
                    MessageBox.Show("Vui lòng chọn thuốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int soLuongYeuCau = (int)num_SoLuong.Value;
                if (soLuongYeuCau <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy thông tin thuốc
                DataTable thuocInfo = xuatKhoBLL.LayThongTinThuocXuatTheoID(idThuoc, soLuongYeuCau);

                if (thuocInfo != null && thuocInfo.Rows.Count > 0)
                {
                    DataTable currentData = gc_SanPham.DataSource as DataTable;
                    if (currentData == null) currentData = CreateDataSource();

                    int remainingQuantity = soLuongYeuCau;

                    // Xóa tất cả các dòng liên quan đến thuốc hiện tại trước khi thêm lại
                    var rowsToRemove = currentData.AsEnumerable()
                        .Where(row => row["IDThuoc"].ToString() == idThuoc)
                        .ToList();

                    foreach (var row in rowsToRemove)
                    {
                        currentData.Rows.Remove(row);
                    }

                    // Thêm lại dữ liệu từ đầu
                    foreach (DataRow newRow in thuocInfo.Rows)
                    {
                        if (remainingQuantity <= 0) break;

                        string newIDThuoc = newRow["IDThuoc"].ToString();
                        DateTime ngayNhap = Convert.ToDateTime(newRow["NgayNhap"]);
                        int availableQuantity = Convert.ToInt32(newRow["SLTon"]);
                        float giaDonVi = Convert.ToSingle(newRow["GiaDonVi"]);

                        if (availableQuantity <= 0) continue; // Bỏ qua lô hàng không còn tồn

                        // Kiểm tra nếu số lượng yêu cầu lớn hơn số lượng tồn
                        int quantityToExport = Math.Min(remainingQuantity, availableQuantity);
                        remainingQuantity -= quantityToExport;

                        // Thêm dòng mới
                        DataRow newExportRow = currentData.NewRow();
                        newExportRow["IDLuuTru"] = newRow["IDLuuTru"];
                        newExportRow["IDChiTietPhieuNhap"] = newRow["IDChiTietPhieuNhap"];
                        newExportRow["TenThuoc"] = newRow["TenThuoc"];
                        newExportRow["IDThuoc"] = newRow["IDThuoc"];
                        newExportRow["ViTri"] = newRow["ViTri"];
                        newExportRow["SLTon"] = newRow["SLTon"];
                        newExportRow["NgayNhap"] = newRow["NgayNhap"];
                        newExportRow["SoLuongXuat"] = quantityToExport;
                        newExportRow["QuyCach"] = newRow["QuyCach"];
                        newExportRow["GiaDonVi"] = newRow["GiaDonVi"];
                        newExportRow["ThanhTien"] = quantityToExport * giaDonVi;

                        currentData.Rows.Add(newExportRow);
                    }

                    if (remainingQuantity > 0)
                    {
                        MessageBox.Show("Không đủ số lượng để xuất theo yêu cầu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    gc_SanPham.DataSource = currentData; // Cập nhật dữ liệu nguồn
                    CapNhatTongTien(); // Tính lại Tổng tiền
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin thuốc hoặc số lượng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ giao diện
                DateTime ngayXuat = dte_NgayXuat.DateTime;

                // Lấy idKho từ ComboBox
                var selectedKhoXuat = cb_KhoXuat.SelectedItem as KeyValuePair<string, string>?;
                string idKho = selectedKhoXuat?.Key;

                var selectedKhoDen = cb_KhoNhan.SelectedValue?.ToString();
                string idKhoDen = selectedKhoDen;

                string ghiChu = txt_GhiChu.Text.Trim();
                float tongTien = 0; // Tổng tiền sẽ được tính tự động từ chi tiết
                string trangThai = "Đã xác nhận";

                // Lấy IDNhanVien từ TextBox ẩn
                string idNhanVien = txt_IDNhanVien.Text;

                // Kiểm tra giá trị của các ComboBox
                if (string.IsNullOrEmpty(idKho))
                {
                    MessageBox.Show("Vui lòng chọn Kho Xuất!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(idKhoDen))
                {
                    MessageBox.Show("Vui lòng chọn Kho Nhận!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(idNhanVien))
                {
                    MessageBox.Show("Không thể xác định ID Nhân Viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy dữ liệu từ GridControl
                DataTable chiTietPhieuXuatSource = gc_SanPham.DataSource as DataTable;

                if (chiTietPhieuXuatSource == null || chiTietPhieuXuatSource.Rows.Count == 0)
                {
                    MessageBox.Show("Vui lòng nhập chi tiết phiếu xuất trước khi lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo DataTable khớp với ChiTietPhieuXuatType
                DataTable chiTietPhieuXuat = new DataTable();
                chiTietPhieuXuat.Columns.Add("IDLuuTru", typeof(string));
                chiTietPhieuXuat.Columns.Add("IDThuoc", typeof(string));
                chiTietPhieuXuat.Columns.Add("DVT", typeof(string));
                chiTietPhieuXuat.Columns.Add("SoLuong", typeof(int));
                chiTietPhieuXuat.Columns.Add("GiaDonVi", typeof(float));
                chiTietPhieuXuat.Columns.Add("ThanhTien", typeof(float));

                foreach (DataRow row in chiTietPhieuXuatSource.Rows)
                {
                    DataRow newRow = chiTietPhieuXuat.NewRow();
                    newRow["IDLuuTru"] = row["IDLuuTru"];
                    newRow["IDThuoc"] = row["IDThuoc"];
                    newRow["DVT"] = row["QuyCach"];
                    newRow["SoLuong"] = row["SoLuongXuat"];
                    newRow["GiaDonVi"] = row["GiaDonVi"];
                    newRow["ThanhTien"] = row["ThanhTien"];
                    tongTien += Convert.ToSingle(row["ThanhTien"]); // Tính tổng tiền từ chi tiết phiếu
                    chiTietPhieuXuat.Rows.Add(newRow);
                }

                // Gọi BLL để thêm phiếu xuất
                bool result = xuatKhoBLL.ThemPhieuXuat(
                    ngayXuat,
                    idKho,
                    idKhoDen,
                    idNhanVien, // Truyền IDNhanVien
                    ghiChu,
                    tongTien,
                    trangThai,
                    chiTietPhieuXuat
                );

                if (result)
                {
                    MessageBox.Show("Thêm phiếu xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset lại giao diện
                    ResetForm();
                    DisEnableAllControls();
                    LoadDanhSachPhieuXuat();
                }
                else
                {
                    MessageBox.Show("Thêm phiếu xuất thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu phiếu xuất: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            // Xóa các trường dữ liệu
            txt_TongTien.Text = "0";
            txt_GhiChu.Text = "";
            txt_IDPX.Text = "";
            txt_GhiChu.Text = "";
            txt_TrangThai.Text = "";
            cb_KhoXuat.SelectedIndex = -1;
            cb_KhoNhan.SelectedIndex = -1;
            cb_ChonThuoc.SelectedIndex = -1;
            

            // Xóa dữ liệu trong GridControl
            gc_SanPham.DataSource = CreateDataSource();

            // Đặt ngày xuất về ngày hiện tại
            dte_NgayXuat.DateTime = DateTime.Now;
        }

        private void btn_XoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy GridView từ GridControl
                var gridView = gc_SanPham.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

                if (gridView != null && gridView.FocusedRowHandle >= 0)
                {
                    // Xác nhận trước khi xóa
                    var confirmResult = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa dòng này không?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (confirmResult == DialogResult.Yes)
                    {
                        // Xóa dòng hiện tại
                        gridView.DeleteRow(gridView.FocusedRowHandle);

                        // Cập nhật lại tổng tiền
                        CapNhatTongTien();
                    }
                }
                else
                {
                    MessageBox.Show("Không có dòng nào được chọn để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachPhieuXuat()
        {
            try
            {
                // Lấy dữ liệu từ BLL
                DataTable dataTable = xuatKhoBLL.GetDanhSachPhieuXuat();

                // Gán dữ liệu vào DataGridView
                dgv_PhieuXuat.DataSource = dataTable;

                // Chỉ hiển thị các cột cần thiết
                dgv_PhieuXuat.Columns["IDPhieuXuat"].HeaderText = "Mã Phiếu Xuất";
                dgv_PhieuXuat.Columns["NgayXuat"].HeaderText = "Ngày Xuất";
                dgv_PhieuXuat.Columns["TrangThai"].HeaderText = "Trạng Thái";

                // Ẩn các cột không cần thiết nếu tồn tại
                foreach (DataGridViewColumn col in dgv_PhieuXuat.Columns)
                {
                    if (col.Name != "IDPhieuXuat" && col.Name != "NgayXuat" && col.Name != "TrangThai")
                    {
                        col.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách phiếu xuất: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_PhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra để tránh lỗi khi nhấn vào tiêu đề cột
            {
                // Lấy IDPhieuXuat từ dòng được chọn
                string idPhieuXuat = dgv_PhieuXuat.Rows[e.RowIndex].Cells["IDPhieuXuat"].Value.ToString();

                try
                {
                    // Gọi BLL để lấy thông tin phiếu xuất và chi tiết phiếu xuất
                    DataSet dsPhieuXuat = xuatKhoBLL.LayThongTinPhieuXuatTheoID(idPhieuXuat);

                    // Hiển thị thông tin phiếu xuất
                    if (dsPhieuXuat.Tables[0].Rows.Count > 0)
                    {
                        DataRow phieuXuatRow = dsPhieuXuat.Tables[0].Rows[0];

                        // Hiển thị thông tin phiếu xuất lên các điều khiển
                        txt_IDPX.Text = phieuXuatRow["IDPhieuXuat"].ToString();
                        dte_NgayXuat.EditValue = Convert.ToDateTime(phieuXuatRow["NgayXuat"]);

                        // Set giá trị cho ComboBox Kho Xuất
                        cb_KhoXuat.SelectedItem = cb_KhoXuat.Items.Cast<KeyValuePair<string, string>>()
                            .FirstOrDefault(item => item.Value == phieuXuatRow["KhoXuat"].ToString());

                        // Set giá trị cho ComboBox Kho Nhận
                        cb_KhoNhan.SelectedIndex = cb_KhoNhan.FindStringExact(phieuXuatRow["KhoNhan"].ToString());


                        txt_NguoiLap.Text = phieuXuatRow["TenNhanVien"].ToString();
                        txt_GhiChu.Text = phieuXuatRow["GhiChu"].ToString();
                        txt_TongTien.Text = Convert.ToDecimal(phieuXuatRow["TongTien"]).ToString("#,##0 ₫");
                        txt_TrangThai.Text = phieuXuatRow["TrangThai"].ToString();
                    }

                    // Hiển thị chi tiết phiếu xuất
                    if (dsPhieuXuat.Tables[1].Rows.Count > 0)
                    {
                        gc_SanPham.DataSource = dsPhieuXuat.Tables[1];
                        gv_SanPham.PopulateColumns();





                        // Đặt tên cho các cột trong GridView
                        gv_SanPham.Columns["IDLuuTru"].Caption = "Mã Lưu trữ";
                        gv_SanPham.Columns["IDChiTietPhieuNhap"].Caption= "Mã CTPN";
                        gv_SanPham.Columns["TenThuoc"].Caption = "Tên thuốc";
                        gv_SanPham.Columns["IDThuoc"].Caption = "Mã thuốc";
                        gv_SanPham.Columns["ViTri"].Caption = "Vị trí";
                        gv_SanPham.Columns["SLTon"].Caption = "SL tồn";
                        gv_SanPham.Columns["NgayNhap"].Caption = "Ngày nhập";
                        gv_SanPham.Columns["SoLuong"].Caption = "SL xuất";
                        gv_SanPham.Columns["DVT"].Caption = "ĐVT";
                        gv_SanPham.Columns["GiaDonVi"].Caption = "Đơn giá";
                        gv_SanPham.Columns["ThanhTien"].Caption = "Thành tiền";

                        // Định dạng cột Thành tiền trong GridView
                        gv_SanPham.Columns["ThanhTien"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        gv_SanPham.Columns["ThanhTien"].DisplayFormat.FormatString = "#,##0 ₫";
                    }
                    else
                    {
                        gc_SanPham.DataSource = null; // Nếu không có chi tiết phiếu xuất, xóa dữ liệu cũ
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hiển thị chi tiết phiếu xuất: " + ex.Message);
                }
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            EnableAllControls();
            ResetForm();
            ResetGridColumnHeaders();
        }

        private void ResetGridColumnHeaders()
        {
            var gridView = gc_SanPham.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            if (gridView != null)
            {
                // Xóa tất cả các cột trong GridView
                gridView.Columns.Clear();

                // Thêm lại các cột với định nghĩa ban đầu
                gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "IDLuuTru", Caption = "Mã Lưu Trữ", Visible = true });
                gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "IDChiTietPhieuNhap", Caption = "Mã CTPN", Visible = true });
                gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "TenThuoc", Caption = "Tên Thuốc", Visible = true });
                gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "IDThuoc", Caption = "Mã Thuốc", Visible = true });
                gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "ViTri", Caption = "Vị Trí", Visible = true });
                gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "SLTon", Caption = "SL Tồn", Visible = true });
                gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "NgayNhap", Caption = "Ngày Nhập", Visible = true });
                gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "SoLuongXuat", Caption = "SL Xuất", Visible = true });
                gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "QuyCach", Caption = "ĐVT", Visible = true });
                gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "GiaDonVi", Caption = "Đơn giá", Visible = true });
                gridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn() { FieldName = "ThanhTien", Caption = "Thành tiền", Visible = true });

                // Căn giữa tiêu đề cột
                foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                {
                    column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                }

                // Làm mới lại giao diện GridView
                gridView.RefreshData();
            }
        }


    }
}
