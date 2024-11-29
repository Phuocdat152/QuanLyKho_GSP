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
            dataTable.Columns.Add("IDChiTietPhieuNhap", typeof(string));           
            dataTable.Columns.Add("IDThuoc", typeof(string));
            dataTable.Columns.Add("TenThuoc", typeof(string));
            dataTable.Columns.Add("ThanhPhan", typeof(string));
            dataTable.Columns.Add("LoaiThuoc", typeof(string));
            dataTable.Columns.Add("NgayNhap", typeof(DateTime));
            dataTable.Columns.Add("NgayHetHan", typeof(DateTime));
            dataTable.Columns.Add("QuyCach", typeof(string));
            dataTable.Columns.Add("SoLuong", typeof(int));          
            dataTable.Columns.Add("ViTri", typeof(string));   // Thêm cột mới "Vị trí"
            
            
            

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



        private void LoadChiTietPhieuNhap()
        {
            try
            {
                // Lấy dữ liệu từ BLL
                DataTable dtChiTietPhieuNhap = luuTruBLL.HienThiTatCaChiTietNhapKho();

                if (dtChiTietPhieuNhap != null && dtChiTietPhieuNhap.Rows.Count > 0)
                {
                    // Gán dữ liệu vào DataTable chính
                    dataTable = dtChiTietPhieuNhap.Copy();

                    // Kiểm tra và thêm cột "Vị trí" nếu chưa tồn tại
                    if (!dataTable.Columns.Contains("ViTri"))
                    {
                        dataTable.Columns.Add("ViTri", typeof(string)); // Cột "Vị trí" hiển thị
                    }

                    // Gán DataTable vào GridControl
                    gc_ThuocChuaSapXep.DataSource = dataTable;

                    // Tùy chỉnh hiển thị cột
                    gv_ThuocChuaSapXep.PopulateColumns();

                    // Đặt tiêu đề cho các cột
                    if (gv_ThuocChuaSapXep.Columns["IDChiTietPhieuNhap"] != null)
                        gv_ThuocChuaSapXep.Columns["IDChiTietPhieuNhap"].Caption = "Mã CTPN";

                    if (gv_ThuocChuaSapXep.Columns["IDThuoc"] != null)
                        gv_ThuocChuaSapXep.Columns["IDThuoc"].Caption = "Mã Thuốc";

                    if (gv_ThuocChuaSapXep.Columns["TenThuoc"] != null)
                        gv_ThuocChuaSapXep.Columns["TenThuoc"].Caption = "Tên Thuốc";

                    if (gv_ThuocChuaSapXep.Columns["ThanhPhan"] != null)
                        gv_ThuocChuaSapXep.Columns["ThanhPhan"].Caption = "Thành Phần";

                    if (gv_ThuocChuaSapXep.Columns["QuyCach"] != null)
                        gv_ThuocChuaSapXep.Columns["QuyCach"].Caption = "Đơn Vị Tính";

                    if (gv_ThuocChuaSapXep.Columns["SoLuong"] != null)
                        gv_ThuocChuaSapXep.Columns["SoLuong"].Caption = "Số lượng";

                    if (gv_ThuocChuaSapXep.Columns["GiaDonVi"] != null)
                        gv_ThuocChuaSapXep.Columns["GiaDonVi"].Visible = false;

                    if (gv_ThuocChuaSapXep.Columns["NgayNhap"] != null)
                        gv_ThuocChuaSapXep.Columns["NgayNhap"].Caption = "Ngày Nhập";

                    if (gv_ThuocChuaSapXep.Columns["NgayHetHan"] != null)
                        gv_ThuocChuaSapXep.Columns["NgayHetHan"].Caption = "Ngày Hết Hạn";

                    // Cột "Loại thuốc"
                    if (gv_ThuocChuaSapXep.Columns["LoaiThuoc"] != null)
                    {
                        gv_ThuocChuaSapXep.Columns["LoaiThuoc"].Caption = "Loại Thuốc";
                        gv_ThuocChuaSapXep.Columns["LoaiThuoc"].OptionsColumn.AllowEdit = false; // Không cho chỉnh sửa
                    }

                    // Cột "Vị trí"
                    if (gv_ThuocChuaSapXep.Columns["ViTri"] != null)
                    {
                        gv_ThuocChuaSapXep.Columns["ViTri"].Caption = "Vị Trí";
                        gv_ThuocChuaSapXep.Columns["ViTri"].OptionsColumn.AllowEdit = true; // Cho phép chỉnh sửa
                    }

                    ConfigureViTriColumn(); // Cấu hình cột "Vị trí" với ComboBox
                }
                else
                {
                    gc_ThuocChuaSapXep.DataSource = null;
                    gv_ThuocChuaSapXep.Columns["IDChiTietPhieuNhap"].Caption = "Mã CTPN";
                    gv_ThuocChuaSapXep.Columns["IDThuoc"].Caption = "Mã Thuốc";
                    gv_ThuocChuaSapXep.Columns["TenThuoc"].Caption = "Tên Thuốc";
                    gv_ThuocChuaSapXep.Columns["ThanhPhan"].Caption = "Thành Phần";
                    gv_ThuocChuaSapXep.Columns["LoaiThuoc"].Caption = "Loại Thuốc";
                    gv_ThuocChuaSapXep.Columns["QuyCach"].Caption = "Đơn Vị Tính";
                    gv_ThuocChuaSapXep.Columns["SoLuong"].Caption = "Số lượng";
                    gv_ThuocChuaSapXep.Columns["NgayNhap"].Caption = "Ngày Nhập";
                    gv_ThuocChuaSapXep.Columns["NgayHetHan"].Caption = "Ngày Hết Hạn";
                    gv_ThuocChuaSapXep.Columns["ViTri"].Caption = "Vị Trí";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu chi tiết nhập kho: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ConfigureViTriColumn()
        {
            // Tạo RepositoryItemLookUpEdit
            RepositoryItemLookUpEdit repoViTri = new RepositoryItemLookUpEdit();
            repoViTri.DisplayMember = "Vị Trí"; // Tên cột hiển thị trong ComboBox
            repoViTri.ValueMember = "Mã Vị Trí"; // Giá trị thực lưu trữ
            repoViTri.NullText = "Chọn vị trí";




            // Gán RepositoryItemLookUpEdit cho cột "ViTri"
            if (gv_ThuocChuaSapXep.Columns["ViTri"] != null)
            {
                gv_ThuocChuaSapXep.Columns["ViTri"].ColumnEdit = repoViTri;
                gv_ThuocChuaSapXep.Columns["ViTri"].Caption = "Vị trí";

                // Đảm bảo cột "ViTri" có thể chỉnh sửa
                gv_ThuocChuaSapXep.Columns["ViTri"].OptionsColumn.AllowEdit = true;

                // Sự kiện CustomRowCellEdit để cập nhật dữ liệu ComboBox theo giá trị Loại thuốc
                gv_ThuocChuaSapXep.CustomRowCellEdit += (sender, e) =>
                {
                    if (e.Column.FieldName == "ViTri")
                    {
                        // Lấy giá trị Loại thuốc từ hàng hiện tại
                        string loaiThuoc = gv_ThuocChuaSapXep.GetRowCellValue(e.RowHandle, "LoaiThuoc")?.ToString();

                        if (!string.IsNullOrEmpty(loaiThuoc))
                        {
                            DataTable dtViTri = null;

                            // Lấy dữ liệu vị trí theo Loại thuốc
                            if (loaiThuoc == "Thuốc thường")
                            {
                                dtViTri = viTriBLL.GetViTriTheoLoaiThuocThuong(loaiThuoc);
                            }
                            else if (loaiThuoc == "Thuốc kiểm soát đặt biệt")
                            {
                                dtViTri = viTriBLL.GetViTriTheoLoaiThuocKSDB(loaiThuoc);
                            }

                            // Gán dữ liệu cho LookUpEdit
                            if (dtViTri != null)
                            {
                                repoViTri.DataSource = dtViTri;
                            }
                        }

                        // Gán LookUpEdit vào cột hiện tại
                        e.RepositoryItem = repoViTri;
                    }
                };
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

                ConfigureBandedColumns(); // Cấu hình nếu cần
                HienThiThongTinLuuTru(); // Hiển thị thông tin
                LoadChiTietPhieuNhap(); // Load dữ liệu vào GridControl

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
                    // Kiểm tra xem các cột có giá trị hợp lệ không
                    if (row["IDThuoc"] == DBNull.Value || string.IsNullOrEmpty(row["IDThuoc"].ToString()) ||
                        row["IDChiTietPhieuNhap"] == DBNull.Value || string.IsNullOrEmpty(row["IDChiTietPhieuNhap"].ToString()) ||
                        row["SoLuong"] == DBNull.Value ||
                        row["NgayNhap"] == DBNull.Value ||
                        row["ViTri"] == DBNull.Value || string.IsNullOrEmpty(row["ViTri"].ToString())) // Sửa từ IDViTri thành ViTri
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi lưu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Chuyển dữ liệu từ DataRow sang DTO (Data Transfer Object)
                    LuuTruDTO luuTruDTO = new LuuTruDTO
                    {
                        IDThuoc = row["IDThuoc"].ToString(),
                        IDChiTietPhieuNhap = row["IDChiTietPhieuNhap"].ToString(),
                        SLton = Convert.ToInt32(row["SoLuong"]),
                        NgayNhap = Convert.ToDateTime(row["NgayNhap"]),
                        IDViTri = row["ViTri"].ToString() // Lưu cột ViTri
                    };

                    // Lưu thông tin vào cơ sở dữ liệu
                    bool isSuccess = luuTruBLL.ThemLuuTru(
                        luuTruDTO.IDThuoc,
                        luuTruDTO.IDChiTietPhieuNhap,
                        luuTruDTO.SLton,
                        luuTruDTO.NgayNhap,
                        luuTruDTO.IDViTri
                    );

                    // Kiểm tra nếu lưu thất bại
                    if (!isSuccess)
                    {
                        MessageBox.Show($"Lưu thất bại cho thuốc ID: {luuTruDTO.IDThuoc}.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        hasErrors = true;
                    }
                }

                // Nếu không có lỗi, thông báo thành công và làm mới dữ liệu
                if (!hasErrors)
                {
                    MessageBox.Show("Lưu thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Làm mới dữ liệu trong GridControl
                    dataTable.Clear();
                    HienThiThongTinLuuTru(); // Hiển thị lại dữ liệu đã được lưu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lưu thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
