using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using BLL;
using System.IO;

namespace GUI
{
    public partial class KiemKeDoiChieu : Form
    {
        private ThuocBLL thuocBLL;
        private UserBLL userBLL;
        private string _username;
        private string _password;   

        public KiemKeDoiChieu(string username, string password)
        {
            InitializeComponent();

            _username = username;
            _password = password;

            // Khởi tạo các lớp xử lý dữ liệu
            thuocBLL = new ThuocBLL(_username, _password);
            userBLL = new UserBLL(_username, _password);

            LoadLoaiKiemTra();
            SetDefaultValues();
            gv_KiemKe.CellValueChanged += gv_KiemKe_CellValueChanged;

        }
        private void LoadLoaiKiemTra()
        {
            try
            {
                DataTable loaiKiemTra = thuocBLL.GetLoaiKiemTra();
                cb_LoaiKK.DataSource = loaiKiemTra;
                cb_LoaiKK.DisplayMember = "TenLoaiKT";  // Hiển thị tên loại kiểm tra
                cb_LoaiKK.ValueMember = "IDLoaiKT";    // Giá trị là ID
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải loại kiểm tra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                DataTable loaiKiemTra = thuocBLL.GetLoaiKiemTra();
                
                cb_LKK.DataSource = loaiKiemTra;
                cb_LKK.DisplayMember = "TenLoaiKT";
                cb_LKK.ValueMember = "IDLoaiKT";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải loại kiểm tra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGridView()
        {
            // Xóa cột cũ nếu cần
            gv_KiemKe.Columns.Clear();

            // Thêm các cột hiện tại
            gv_KiemKe.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "IDThuoc",
                Caption = "Mã Thuốc",
                Visible = true
            });

            gv_KiemKe.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "TenThuoc",
                Caption = "Tên Thuốc",
                Visible = true
            });

            gv_KiemKe.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "IDChiTietPhieuNhap",
                Caption = "Mã Chi Tiết Phiếu Nhập",
                Visible = true
            });

            gv_KiemKe.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "ThanhPhan",
                Caption = "Thành Phần",
                Visible = true
            });

            gv_KiemKe.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "SLTon",
                Caption = "Số Lượng Tồn",
                Visible = true
            });

            // Thêm cột cho SLThucTe
            gv_KiemKe.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "SLThucTe",
                Caption = "Số Lượng Thực Tế",
                Visible = true,
                OptionsColumn = { AllowEdit = true }, // Cho phép chỉnh sửa
                UnboundType = DevExpress.Data.UnboundColumnType.Integer // Kiểu dữ liệu là số nguyên
            });

            // Thêm cột cho TinhTrang
            gv_KiemKe.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "TinhTrang",
                Caption = "Tình Trạng",
                Visible = true,
                OptionsColumn = { AllowEdit = true }, // Cho phép chỉnh sửa
                UnboundType = DevExpress.Data.UnboundColumnType.String // Kiểu dữ liệu là chuỗi
            });
        }

        private void SetDefaultValues()
        {
            // Hiển thị ngày hiện tại
            de_NgayKK.EditValue = DateTime.Now;

            try
            {
                // Lấy thông tin nhân viên hiện tại dựa trên _username
                UserDTO currentUser = userBLL.GetNhanVienByUsername(_username);

                // Hiển thị tên nhân viên
                txt_NhanVienKK.Text = currentUser?.TenNhanVien ?? "Không xác định";
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show("Lỗi khi lấy thông tin nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NhanVienKK.Text = "Không xác định";
            }
        }


        private void dateEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KiemKeDoiChieu_Load(object sender, EventArgs e)
        {
            try
            {
                // Lấy ID loại kiểm tra đầu tiên (hoặc giá trị mặc định)
                string defaultIDLoaiKT = cb_LoaiKK.SelectedValue?.ToString();

                if (!string.IsNullOrEmpty(defaultIDLoaiKT))
                {
                    // Lấy dữ liệu ban đầu
                    DataTable thuocData = thuocBLL.GetThuocWithKiemTra(defaultIDLoaiKT);

                    // Gán dữ liệu vào GridControl
                    gc_KiemKe.DataSource = thuocData;
                    ConfigureGridView();
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu xảy ra vấn đề
                MessageBox.Show("Lỗi khi tải dữ liệu ban đầu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                // Tải danh sách loại kiểm tra
                LoadLoaiKiemTra();

                // Gắn sự kiện cho cb_LKK
                cb_LKK.SelectedIndexChanged += cb_LKK_SelectedIndexChanged;

                // Hiển thị danh sách kiểm kê mặc định (loại kiểm tra đầu tiên)
                if (cb_LKK.Items.Count > 0)
                {
                    cb_LKK.SelectedIndex = 0; // Chọn giá trị đầu tiên
                    cb_LKK_SelectedIndexChanged(null, null); // Hiển thị dữ liệu mặc định
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu ban đầu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cb_LoaiKK_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    string selectedIDLoaiKT = cb_LoaiKK.SelectedValue.ToString(); // Lấy ID loại kiểm tra
            //    DateTime currentDate = DateTime.Now; // Lấy ngày hiện tại từ hệ thống

            //    // Lấy danh sách thuốc cần kiểm kê
            //    DataTable thuocData = thuocBLL.GetThuocToKiemKe(selectedIDLoaiKT, currentDate);

            //    // Gán dữ liệu vào GridControl
            //    gc_KiemKe.DataSource = thuocData;
            //    ConfigureGridView(); // Cấu hình GridView
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi tải danh sách thuốc cần kiểm kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            try
            {
                string selectedIDLoaiKT = cb_LoaiKK.SelectedValue.ToString();
                LoadThuocData(selectedIDLoaiKT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách thuốc cần kiểm kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataTable GetThuocByLoaiKT(string idLoaiKT)
        {
            try
            {
                return thuocBLL.GetThuocByLoaiKT(idLoaiKT); // Lấy dữ liệu từ BLL
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lọc thuốc theo loại kiểm tra: " + ex.Message);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string nhanVienKT = txt_NhanVienKK.Text;

                for (int i = 0; i < gv_KiemKe.DataRowCount; i++)
                {
                    DataRow row = gv_KiemKe.GetDataRow(i);

                    string idThuoc = row["IDThuoc"].ToString();
                    string tinhTrang = row["TinhTrang"]?.ToString();
                    int slThucTe = row["SLThucTe"] == DBNull.Value ? 0 : Convert.ToInt32(row["SLThucTe"]);
                    int slTon = Convert.ToInt32(row["SLTon"]);
                    string idLoaiKT = cb_LoaiKK.SelectedValue.ToString();

                    string idLuuTru = thuocBLL.GetIDLuuTruByThuocID(idThuoc);
                    string idKiemTra = thuocBLL.GenerateNewIDKiemTra();

                    thuocBLL.SaveKiemTra(idKiemTra, DateTime.Now, idLuuTru, idThuoc, tinhTrang, slThucTe, slTon, idLoaiKT, nhanVienKT);
                    thuocBLL.UpdateSoLuongTon(idThuoc, slThucTe);
                }

                MessageBox.Show("Lưu kiểm kê thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cb_LoaiKK_SelectedIndexChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu kiểm kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDanhSachKiemKe()
        {
            try
            {
                // Lấy dữ liệu từ BLL
                DataTable danhSachKiemKe = thuocBLL.GetDanhSachKiemKe();

                // Gán dữ liệu vào GridControl
                grc_DanhSachKK.DataSource = danhSachKiemKe;

                // Cấu hình các cột
                ConfigureDanhSachKK();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách kiểm kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigureDanhSachKK()
        {
            gv_DanhSachKK.Columns.Clear();

            // Thêm các cột và đặt tên tiếng Việt
            gv_DanhSachKK.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "IDKiemTra",
                Caption = "Mã Kiểm Tra",
                Visible = true
            });

            gv_DanhSachKK.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "TenThuoc",
                Caption = "Tên Thuốc",
                Visible = true
            });

            gv_DanhSachKK.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "ThanhPhan",
                Caption = "Thành Phần",
                Visible = true
            });

            gv_DanhSachKK.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "SLTon",
                Caption = "Số Lượng Tồn",
                Visible = true
            });

            gv_DanhSachKK.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "SLThucTe",
                Caption = "Số Lượng Thực Tế",
                Visible = true
            });

            gv_DanhSachKK.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "TinhTrang",
                Caption = "Tình Trạng",
                Visible = true
            });

            gv_DanhSachKK.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "TenLoaiKT",
                Caption = "Loại Kiểm Tra",
                Visible = true
            });

            gv_DanhSachKK.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "NhanVienKT",
                Caption = "Nhân Viên Kiểm Tra",
                Visible = true
            });

            // Căn chỉnh và cấu hình GridView
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                LoadDanhSachKiemKe();
            }
        }
        private void LoadThuocData(string idLoaiKT)
        {
            try
            {
                // Lấy dữ liệu từ BLL
                DataTable thuocData = thuocBLL.GetThuocToKiemKe(idLoaiKT, DateTime.Now);

                // Thêm cột SLThucTe và TinhTrang nếu chưa có
                if (!thuocData.Columns.Contains("SLThucTe"))
                {
                    thuocData.Columns.Add("SLThucTe", typeof(int)); // Kiểu int
                }
                if (!thuocData.Columns.Contains("TinhTrang"))
                {
                    thuocData.Columns.Add("TinhTrang", typeof(string)); // Kiểu string
                }

                // Gán giá trị mặc định
                foreach (DataRow row in thuocData.Rows)
                {
                    if (row["SLThucTe"] == DBNull.Value) // Nếu chưa có giá trị
                    {
                        row["SLThucTe"] = row["SLTon"]; // SLThucTe mặc định bằng SLTon
                    }
                    if (row["TinhTrang"] == DBNull.Value) // Nếu chưa có giá trị
                    {
                        row["TinhTrang"] = "Bình Thường"; // Giá trị mặc định cho TinhTrang
                    }
                }

                // Gán dữ liệu vào GridControl
                gc_KiemKe.DataSource = thuocData;
                ConfigureGridView(); // Cấu hình GridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu thuốc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gv_KiemKe_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "SLThucTe" || e.Column.FieldName == "TinhTrang")
                {
                    gv_KiemKe.UpdateCurrentRow(); // Cập nhật giá trị vào DataSource
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật giá trị: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Lấy ID của loại kiểm tra được chọn
                string selectedIDLoaiKT = cb_LKK.SelectedValue?.ToString();

                if (!string.IsNullOrEmpty(selectedIDLoaiKT))
                {
                    // Lấy danh sách kiểm kê theo loại kiểm tra
                    DataTable danhSachKiemKe = thuocBLL.GetDanhSachKiemKeByLoaiKT(selectedIDLoaiKT);

                    // Gán dữ liệu vào GridControl
                    grc_DanhSachKK.DataSource = danhSachKiemKe;

                    // Cấu hình lại GridView
                    ConfigureDanhSachKK();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị danh sách kiểm kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_LKK_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Lấy ID của loại kiểm tra được chọn
                string selectedIDLoaiKT = cb_LKK.SelectedValue?.ToString();

                if (!string.IsNullOrEmpty(selectedIDLoaiKT))
                {
                    // Lấy danh sách kiểm kê theo loại kiểm tra
                    DataTable danhSachKiemKe = thuocBLL.GetDanhSachKiemKeByLoaiKT(selectedIDLoaiKT);

                    // Gán dữ liệu vào GridControl
                    grc_DanhSachKK.DataSource = danhSachKiemKe;

                    // Cấu hình lại GridView
                    ConfigureDanhSachKK();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị danh sách kiểm kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_InExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Đặt ngữ cảnh giấy phép cho EPPlus
                OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                // Lấy ngày giờ hiện tại
                string currentDateTime = DateTime.Now.ToString("dd-MM-yyyy HH-mm"); // Định dạng ngày và giờ

                // Hiển thị hộp thoại lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files (*.xlsx)|*.xlsx",
                    FileName = $"Báo Cáo Kiểm Kê Ngày {currentDateTime}.xlsx",
                    Title = "Lưu Báo Cáo Kiểm Kê"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Tạo file Excel
                    using (ExcelPackage package = new ExcelPackage())
                    {
                        // Tạo một sheet mới
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Báo Cáo Kiểm Kê");

                        // Danh sách ánh xạ FieldName -> Tiêu đề tiếng Việt
                        Dictionary<string, string> columnHeaders = new Dictionary<string, string>
                {
                    { "IDKiemTra", "Mã Kiểm Tra" },
                    { "TenThuoc", "Tên Thuốc" },
                    { "ThanhPhan", "Thành Phần" },
                    { "SLTon", "Số Lượng Tồn" },
                    { "SLThucTe", "Số Lượng Thực Tế" },
                    { "TinhTrang", "Tình Trạng" },
                    { "TenLoaiKT", "Loại Kiểm Tra" },
                    { "NhanVienKT", "Nhân Viên Kiểm Tra" }
                };

                        // Thêm tiêu đề cột (tiếng Việt)
                        for (int col = 0; col < gv_DanhSachKK.Columns.Count; col++)
                        {
                            string fieldName = gv_DanhSachKK.Columns[col].FieldName;
                            worksheet.Cells[1, col + 1].Value = columnHeaders.ContainsKey(fieldName)
                                ? columnHeaders[fieldName] // Sử dụng tiêu đề tiếng Việt nếu có
                                : fieldName;              // Nếu không có, giữ nguyên FieldName
                        }

                        // Thêm dữ liệu từ GridView vào file Excel
                        for (int row = 0; row < gv_DanhSachKK.RowCount; row++)
                        {
                            for (int col = 0; col < gv_DanhSachKK.Columns.Count; col++)
                            {
                                var value = gv_DanhSachKK.GetRowCellValue(row, gv_DanhSachKK.Columns[col]);
                                worksheet.Cells[row + 2, col + 1].Value = value?.ToString() ?? string.Empty;
                            }
                        }

                        // Định dạng tự động cho các cột
                        worksheet.Cells.AutoFitColumns();

                        // Lưu file Excel
                        FileInfo fileInfo = new FileInfo(filePath);
                        package.SaveAs(fileInfo);
                    }

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Xuất báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có vấn đề xảy ra
                MessageBox.Show($"Lỗi khi xuất báo cáo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
