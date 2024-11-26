using BLL;
using DAL;
using DevExpress.XtraEditors.Repository;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class SapXepThuoc : Form
    {
        private LuuTruBLL luuTruBLL;
        private KhoBLL khoBLL;
        private ViTriBLL viTriBLL;
        private DataTable dataTable;
        public SapXepThuoc(string username, string password)
        {
            InitializeComponent();
            luuTruBLL = new LuuTruBLL(username, password);
            khoBLL = new KhoBLL(username, password);
            viTriBLL = new ViTriBLL(username, password);
            InitializeDataTable();
            Load += SapXepThuoc_Load;

        }

        private void InitializeDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("TenThuoc", typeof(string));
            dataTable.Columns.Add("IDThuoc", typeof(string));
            dataTable.Columns.Add("IDChiTietPhieuNhap", typeof(string));
            dataTable.Columns.Add("SLTon", typeof(int));
            dataTable.Columns.Add("NgayNhap", typeof(DateTime));
            dataTable.Columns.Add("IDViTri", typeof(string)); // Đảm bảo cột này tồn tại

            gc_ThuocChuaSapXep.DataSource = dataTable;
        }


        private void ConfigureBandedColumns()
        {
            // Đảm bảo GridControl đang sử dụng BandedGridView
            var bandedView = gc_ThuocDaSapXep.MainView as DevExpress.XtraGrid.Views.BandedGrid.BandedGridView;

            
                bandedView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView(gc_ThuocDaSapXep);
                gc_ThuocDaSapXep.MainView = bandedView;
            

            // Tạo các bands (nhóm cột) và căn giữa tiêu đề
            var thongTinThuocBand = new DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            {
                Caption = "                                                                                     Thông tin thuốc",
                AppearanceHeader =
        {
            TextOptions = { HAlignment = DevExpress.Utils.HorzAlignment.Center },
            Options = { UseBackColor = true, UseForeColor = true },
            BackColor = Color.LightSkyBlue,
            ForeColor = Color.Black
        }
            };

            var viTriLuuTruBand = new DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            {
                Caption = "                                                              Vị trí lưu trữ",
                AppearanceHeader =
        {
            TextOptions = { HAlignment = DevExpress.Utils.HorzAlignment.Center },
            Options = { UseBackColor = true, UseForeColor = true },
            BackColor = Color.LightSkyBlue,
            ForeColor = Color.Black
        }
            };

            // Thêm các bands vào BandedGridView
            bandedView.Bands.AddRange(new[] { thongTinThuocBand, viTriLuuTruBand });

            // Tạo và thêm các cột vào band "Thông tin thuốc" với căn giữa nội dung
            var colIDChiTietPhieuNhap = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            {
                Caption = "Mã CTPN",
                FieldName = "IDChiTietPhieuNhap",
                Visible = true,
                AppearanceCell = { TextOptions = { HAlignment = DevExpress.Utils.HorzAlignment.Center } }
            };

            var colIDThuoc = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            {
                Caption = "Mã thuốc",
                FieldName = "IDThuoc",
                Visible = true,
                AppearanceCell = { TextOptions = { HAlignment = DevExpress.Utils.HorzAlignment.Center } }
            };

            var colTenThuoc = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            {
                Caption = "Tên thuốc",
                FieldName = "TenThuoc",
                Visible = true,
                AppearanceCell = { TextOptions = { HAlignment = DevExpress.Utils.HorzAlignment.Center } }
            };

            var colSLTon = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            {
                Caption = "SL tồn",
                FieldName = "SLTon",
                Visible = true,
                AppearanceCell = { TextOptions = { HAlignment = DevExpress.Utils.HorzAlignment.Center } }
            };

            var colNgayNhap = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            {
                Caption = "Ngày nhập",
                FieldName = "NgayNhap",
                Visible = true,
                AppearanceCell = { TextOptions = { HAlignment = DevExpress.Utils.HorzAlignment.Center } }
            };

            thongTinThuocBand.Columns.Add(colIDChiTietPhieuNhap);
            thongTinThuocBand.Columns.Add(colIDThuoc);
            thongTinThuocBand.Columns.Add(colTenThuoc);
            thongTinThuocBand.Columns.Add(colSLTon);
            thongTinThuocBand.Columns.Add(colNgayNhap);

            // Tạo và thêm các cột vào band "Vị trí lưu trữ" với căn giữa nội dung
            var colKhu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            {
                Caption = "Khu",
                FieldName = "Khu",
                Visible = true,
                AppearanceCell = { TextOptions = { HAlignment = DevExpress.Utils.HorzAlignment.Center } }
            };

            var colKe = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            {
                Caption = "Kệ",
                FieldName = "Ke",
                Visible = true,
                AppearanceCell = { TextOptions = { HAlignment = DevExpress.Utils.HorzAlignment.Center } }
            };

            var colO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            {
                Caption = "Ô",
                FieldName = "O",
                Visible = true,
                AppearanceCell = { TextOptions = { HAlignment = DevExpress.Utils.HorzAlignment.Center } }
            };

            viTriLuuTruBand.Columns.Add(colKhu);
            viTriLuuTruBand.Columns.Add(colKe);
            viTriLuuTruBand.Columns.Add(colO);
        }




        private void AddColumnsToGridView()
        {
            var captions = new[] { "Tên thuốc", "Mã thuốc", "Mã CTPN", "SL nhập", "Ngày nhập", "Vị trí" };
            int captionCount = captions.Length;

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                var column = gv_ThuocChuaSapXep.Columns[dataTable.Columns[i].ColumnName];
                if (column != null && i < captionCount)
                {
                    column.Caption = captions[i];
                    column.Visible = true;
                }
            }
        }


        private void LoadChiTietPhieuNhap()
        {
            try
            {
                // Lấy dữ liệu từ BLL
                DataTable dtChiTietPhieuNhap = luuTruBLL.HienThiTatCaChiTietNhapKho();

                if (dtChiTietPhieuNhap != null && dtChiTietPhieuNhap.Rows.Count > 0)
                {
                    // Gán dữ liệu vào GridControl
                    gc_ThuocChuaSapXep.DataSource = dtChiTietPhieuNhap;

                    // Tùy chỉnh hiển thị cột
                    gv_ThuocChuaSapXep.PopulateColumns();

                    // Đặt tên tiêu đề cho các cột
                    if (gv_ThuocChuaSapXep.Columns["IDChiTietNhapKho"] != null)
                        gv_ThuocChuaSapXep.Columns["IDChiTietNhapKho"].Caption = "Mã CTPN";

                    if (gv_ThuocChuaSapXep.Columns["IDThuoc"] != null)
                        gv_ThuocChuaSapXep.Columns["IDThuoc"].Caption = "Mã Thuốc";

                    if (gv_ThuocChuaSapXep.Columns["TenThuoc"] != null)
                        gv_ThuocChuaSapXep.Columns["TenThuoc"].Caption = "Tên Thuốc";

                    if (gv_ThuocChuaSapXep.Columns["SoLuong"] != null)
                        gv_ThuocChuaSapXep.Columns["SoLuong"].Caption = "Số Lượng";

                    if (gv_ThuocChuaSapXep.Columns["DonGia"] != null)
                        gv_ThuocChuaSapXep.Columns["DonGia"].Caption = "Đơn Giá";

                    if (gv_ThuocChuaSapXep.Columns["ThanhTien"] != null)
                        gv_ThuocChuaSapXep.Columns["ThanhTien"].Caption = "Thành Tiền";

                    if (gv_ThuocChuaSapXep.Columns["NgaySanXuat"] != null)
                        gv_ThuocChuaSapXep.Columns["NgaySanXuat"].Caption = "Ngày Sản Xuất";

                    if (gv_ThuocChuaSapXep.Columns["NgayHetHan"] != null)
                        gv_ThuocChuaSapXep.Columns["NgayHetHan"].Caption = "Ngày Hết Hạn";

                    // Thêm cột "Vị trí" với combobox
                    AddViTriColumn();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu chi tiết nhập kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gc_ThuocChuaSapXep.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu chi tiết nhập kho: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        //private void LoadComboBoxInTenThuocColumn()
        //{
        //    try
        //    {
        //        // Lấy danh sách IDChiTietPhieuNhap đã lưu từ BLL
        //        List<string> savedIDs = luuTruBLL.GetSavedIDChiTietPhieuNhap();

        //        // Lấy dữ liệu từ bảng ChiTietPhieuNhap qua BLL
        //        DataTable dtChiTietPhieuNhap = luuTruBLL.HienThiTatCaChiTietNhapKho();

        //        // Kiểm tra nếu không có dữ liệu hoặc không có dữ liệu sau khi lọc
        //        if (dtChiTietPhieuNhap == null || dtChiTietPhieuNhap.Rows.Count == 0)
        //        {
        //            // Tạo DataTable trống với các cột cần thiết
        //            dtChiTietPhieuNhap = new DataTable();
        //            dtChiTietPhieuNhap.Columns.Add("IDChiTietPhieuNhap", typeof(string));
        //            dtChiTietPhieuNhap.Columns.Add("IDThuoc", typeof(string));
        //            dtChiTietPhieuNhap.Columns.Add("TenThuoc", typeof(string));
        //            dtChiTietPhieuNhap.Columns.Add("SoLuong", typeof(int));
        //            dtChiTietPhieuNhap.Columns.Add("NgayNhap", typeof(DateTime));
        //            dtChiTietPhieuNhap.Columns.Add("NgayHetHan", typeof(DateTime));
        //            dtChiTietPhieuNhap.Columns.Add("QuyCach", typeof(string));
        //            dtChiTietPhieuNhap.Columns.Add("GiaDonVi", typeof(decimal));
        //        }
        //        else
        //        {
        //            // Lọc dữ liệu để loại bỏ các IDChiTietPhieuNhap đã lưu
        //            dtChiTietPhieuNhap = dtChiTietPhieuNhap.AsEnumerable()
        //                .Where(row => !savedIDs.Contains(row["IDChiTietPhieuNhap"].ToString()))
        //                .CopyToDataTable();
        //        }

        //        // Thêm cột UniqueID để làm khóa duy nhất, kết hợp IDThuoc và IDChiTietPhieuNhap
        //        dtChiTietPhieuNhap.Columns.Add("UniqueID", typeof(string), "IDThuoc + '-' + IDChiTietPhieuNhap");

        //        // Tạo RepositoryItemLookUpEdit cho cột "Tên thuốc"
        //        RepositoryItemLookUpEdit lookUpEditTenThuoc = new RepositoryItemLookUpEdit
        //        {
        //            DataSource = dtChiTietPhieuNhap,
        //            DisplayMember = "TenThuoc",  // Hiển thị tên thuốc trong ComboBox
        //            ValueMember = "UniqueID",    // Sử dụng UniqueID để phân biệt các dòng
        //            NullText = "Chọn tên thuốc"
        //        };

        //        // Thiết lập các cột hiển thị trong dropdown của LookUpEdit
        //        lookUpEditTenThuoc.PopulateColumns();
        //        lookUpEditTenThuoc.Columns["IDChiTietPhieuNhap"].Caption = "Mã CTPN";
        //        lookUpEditTenThuoc.Columns["IDThuoc"].Caption = "Mã Thuốc";
        //        lookUpEditTenThuoc.Columns["NgayHetHan"].Caption = "Ngày Hết Hạn";
        //        lookUpEditTenThuoc.Columns["QuyCach"].Caption = "Quy Cách";
        //        lookUpEditTenThuoc.Columns["SoLuong"].Caption = "Số Lượng";
        //        lookUpEditTenThuoc.Columns["GiaDonVi"].Caption = "Giá Đơn Vị";
        //        lookUpEditTenThuoc.Columns["NgayNhap"].Caption = "Ngày Nhập";
        //        lookUpEditTenThuoc.Columns["TenThuoc"].Caption = "Tên Thuốc";
        //        lookUpEditTenThuoc.Columns["UniqueID"].Visible = false; // Ẩn UniqueID

        //        // Xử lý sự kiện EditValueChanged để tự động điền dữ liệu khi chọn một dòng
        //        lookUpEditTenThuoc.EditValueChanged += (s, e) =>
        //        {
        //            var editor = s as DevExpress.XtraEditors.LookUpEdit;
        //            if (editor?.EditValue == null) return;

        //            // Lấy thông tin từ dòng được chọn dựa trên UniqueID
        //            DataRow selectedRow = (editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue) as DataRowView)?.Row;
        //            if (selectedRow != null)
        //            {
        //                // Điền dữ liệu vào các cột tương ứng trong GridView
        //                gv_ThuocChuaSapXep.SetFocusedRowCellValue("IDThuoc", selectedRow["IDThuoc"]);
        //                gv_ThuocChuaSapXep.SetFocusedRowCellValue("IDChiTietPhieuNhap", selectedRow["IDChiTietPhieuNhap"]);
        //                gv_ThuocChuaSapXep.SetFocusedRowCellValue("SLTon", selectedRow["SoLuong"]);
        //                gv_ThuocChuaSapXep.SetFocusedRowCellValue("NgayNhap", selectedRow["NgayNhap"]);
        //            }
        //        };

        //        // Gán LookUpEdit vào cột "Tên thuốc"
        //        var colTenThuoc = gv_ThuocChuaSapXep.Columns["TenThuoc"];
        //        if (colTenThuoc != null)
        //        {
        //            colTenThuoc.ColumnEdit = lookUpEditTenThuoc;
        //        }

        //        gv_ThuocChuaSapXep.RefreshData();
        //    }
        //    catch (Exception ex)
        //    {
        //        // Bỏ qua lỗi, không hiện thông báo
        //    }
        //}




        //private void LoadComboBoxInViTriColumn()
        //{
        //    try
        //    {
        //        // Lấy dữ liệu vị trí theo loại khu nhập từ ViTriBLL
        //        DataTable dtViTri = viTriBLL.GetViTriTheoLoaiKhuNhap(); // Gọi hàm mới

        //        // Kiểm tra nếu không có dữ liệu
        //        if (dtViTri == null || dtViTri.Rows.Count == 0)
        //        {
        //            MessageBox.Show("Không có dữ liệu vị trí để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        // Tạo RepositoryItemLookUpEdit cho cột "Vị trí"
        //        RepositoryItemLookUpEdit lookUpEditViTri = new RepositoryItemLookUpEdit
        //        {
        //            DataSource = dtViTri,
        //            DisplayMember = "Mã Vị Trí",  // Tên cột hiển thị trong ComboBox
        //            ValueMember = "Mã Vị Trí",    // Tên cột làm giá trị lưu trữ
        //            NullText = "Chọn vị trí",
        //            BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit // Tự động điều chỉnh kích thước
        //        };

        //        // Cấu hình các cột hiển thị trong LookUpEdit
        //        lookUpEditViTri.PopulateColumns();

        //        // Đặt tên hiển thị cho các cột
        //        if (lookUpEditViTri.Columns["Mã Vị Trí"] != null)
        //            lookUpEditViTri.Columns["Mã Vị Trí"].Caption = "Mã Vị Trí";
        //        if (lookUpEditViTri.Columns["Tên Khu"] != null)
        //            lookUpEditViTri.Columns["Tên Khu"].Caption = "Tên Khu";
        //        if (lookUpEditViTri.Columns["Tên Kệ"] != null)
        //            lookUpEditViTri.Columns["Tên Kệ"].Caption = "Tên Kệ";
        //        if (lookUpEditViTri.Columns["Tên Ô"] != null)
        //            lookUpEditViTri.Columns["Tên Ô"].Caption = "Tên Ô";

        //        // Ẩn các cột không cần thiết (nếu có)
        //        if (lookUpEditViTri.Columns["Trạng Thái"] != null)
        //            lookUpEditViTri.Columns["Trạng Thái"].Visible = false;
        //        if (lookUpEditViTri.Columns["Loại Khu"] != null)
        //            lookUpEditViTri.Columns["Loại Khu"].Caption = "Loại khu";

        //        // Gán RepositoryItemLookUpEdit vào cột "IDViTri" trên GridView
        //        var colViTri = gv_ThuocChuaSapXep.Columns["IDViTri"];
        //        if (colViTri != null)
        //        {
        //            colViTri.ColumnEdit = lookUpEditViTri;
        //        }

        //        // Làm mới GridView
        //        gv_ThuocChuaSapXep.RefreshData();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi khi tải dữ liệu vào ComboBox Vị trí: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void AddViTriColumn()
        {
            try
            {
                // Lấy dữ liệu vị trí từ BLL
                DataTable dtViTri = viTriBLL.GetViTriTheoLoaiKhuNhap();

                if (dtViTri == null || dtViTri.Columns.Count == 0)
                {
                    MessageBox.Show("Dữ liệu vị trí bị rỗng hoặc không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo RepositoryItemLookUpEdit cho cột "Vị trí"
                RepositoryItemLookUpEdit lookUpEditViTri = new RepositoryItemLookUpEdit
                {
                    DataSource = dtViTri,
                    DisplayMember = "TenViTri",  // Hiển thị tên vị trí
                    ValueMember = "IDViTri",     // Giá trị lưu trữ là ID vị trí
                    NullText = "Chọn vị trí"
                };

                // Tùy chỉnh hiển thị các cột trong combobox
                lookUpEditViTri.PopulateColumns();

                if (lookUpEditViTri.Columns["IDViTri"] != null)
                    lookUpEditViTri.Columns["IDViTri"].Caption = "Mã Vị Trí";

                if (lookUpEditViTri.Columns["TenViTri"] != null)
                    lookUpEditViTri.Columns["TenViTri"].Caption = "Tên Vị Trí";

                if (lookUpEditViTri.Columns["LoaiKhu"] != null)
                    lookUpEditViTri.Columns["LoaiKhu"].Caption = "Loại Khu";

                if (lookUpEditViTri.Columns["TrangThai"] != null)
                    lookUpEditViTri.Columns["TrangThai"].Visible = false;

                // Thêm cột "Vị trí" vào GridView
                var colViTri = new DevExpress.XtraGrid.Columns.GridColumn
                {
                    Caption = "Vị Trí",
                    FieldName = "IDViTri",
                    Visible = true,
                    ColumnEdit = lookUpEditViTri
                };

                gv_ThuocChuaSapXep.Columns.Add(colViTri);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm cột Vị trí: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void HienThiThongTinLuuTru()
        {
            try
            {
                // Gọi phương thức BLL để lấy dữ liệu
                DataTable dt = luuTruBLL.HienThiThongTinLuuTru();

                // Gán DataTable vào GridControl
                gc_ThuocDaSapXep.DataSource = dt;

                // Làm mới lại GridView để hiển thị dữ liệu
                gv_ThuocDaSapXep.RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị thông tin lưu trữ: " + ex.Message);
            }
        }

        private void SapXepThuoc_Load(object sender, EventArgs e)
        {
            try
            {
                AddColumnsToGridView(); // Thêm cột
                ConfigureBandedColumns(); // Cấu hình nếu cần
                HienThiThongTinLuuTru(); // Hiển thị thông tin

                LoadChiTietPhieuNhap(); // Load dữ liệu vào GridControl

                // Chỉ định cột nếu tồn tại
                if (gv_ThuocChuaSapXep.Columns["IDThuoc"] != null)
                    gv_ThuocChuaSapXep.Columns["IDThuoc"].OptionsColumn.AllowEdit = false;

                if (gv_ThuocChuaSapXep.Columns["IDChiTietPhieuNhap"] != null)
                    gv_ThuocChuaSapXep.Columns["IDChiTietPhieuNhap"].OptionsColumn.AllowEdit = false;

                if (gv_ThuocChuaSapXep.Columns["SLTon"] != null)
                    gv_ThuocChuaSapXep.Columns["SLTon"].OptionsColumn.AllowEdit = false;

                if (gv_ThuocChuaSapXep.Columns["NgayNhap"] != null)
                    gv_ThuocChuaSapXep.Columns["NgayNhap"].OptionsColumn.AllowEdit = false;

                var bandedView = gc_ThuocDaSapXep.MainView as DevExpress.XtraGrid.Views.BandedGrid.BandedGridView;
                if (bandedView != null)
                {
                    bandedView.OptionsBehavior.Editable = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải form: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_Luu_Click(object sender, EventArgs e)
        {
            // Đảm bảo rằng GridView ghi nhận các thay đổi
            gv_ThuocChuaSapXep.CloseEditor();
            gv_ThuocChuaSapXep.UpdateCurrentRow();

            try
            {
                bool hasErrors = false;

                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["IDThuoc"] == DBNull.Value || string.IsNullOrEmpty(row["IDThuoc"].ToString()) ||
                        row["IDChiTietPhieuNhap"] == DBNull.Value || string.IsNullOrEmpty(row["IDChiTietPhieuNhap"].ToString()) ||
                        row["SLTon"] == DBNull.Value ||
                        row["NgayNhap"] == DBNull.Value ||
                        row["IDViTri"] == DBNull.Value || string.IsNullOrEmpty(row["IDViTri"].ToString()))
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi lưu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    LuuTruDTO luuTruDTO = new LuuTruDTO
                    {
                        IDThuoc = row["IDThuoc"].ToString(),
                        IDChiTietPhieuNhap = row["IDChiTietPhieuNhap"].ToString(),
                        SLton = Convert.ToInt32(row["SLTon"]),
                        NgayNhap = Convert.ToDateTime(row["NgayNhap"]),
                        IDViTri = row["IDViTri"].ToString()
                    };

                    bool isSuccess = luuTruBLL.ThemLuuTru(
                        luuTruDTO.IDThuoc,
                        luuTruDTO.IDChiTietPhieuNhap,
                        luuTruDTO.SLton,
                        luuTruDTO.NgayNhap,
                        luuTruDTO.IDViTri
                    );

                    if (!isSuccess)
                    {
                        MessageBox.Show($"Lưu thất bại cho thuốc ID: {luuTruDTO.IDThuoc}.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        hasErrors = true;
                    }
                }

                if (!hasErrors)
                {
                    MessageBox.Show("Lưu thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Đặt lại trạng thái của các nút
                    btn_Luu.Enabled = false;

                    // Làm mới dữ liệu trong GridControl nếu cần
                    dataTable.Clear();
                    HienThiThongTinLuuTru();

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lưu thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
