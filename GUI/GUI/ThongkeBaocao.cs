using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ThongkeBaocao : Form
    {
        private string _username;
        private string _password;

        public ThongkeBaocao(string username, string password)
        {
            InitializeComponent();

            // Lưu trữ thông tin đăng nhập
            _username = username;
            _password = password;
            gv_DanhSachTK.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gv_DanhSachTK.OptionsBehavior.Editable = false;
            cb_ChonLTK.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadStoredMedicines()
        {
            try
            {
                // Sử dụng username và password để khởi tạo BLL
                LuuTruBLL luuTruBLL = new LuuTruBLL(_username, _password);

                // Lấy dữ liệu từ BLL
                DataTable storedMedicines = luuTruBLL.GetStoredMedicines();
                gc_DanhSach.DataSource = storedMedicines; // Gán dữ liệu vào GridControl

                // Tùy chỉnh tên cột trong GridView (gv_DanhSachTK)
                gv_DanhSachTK.Columns["IDLuuTru"].Caption = "Mã Lưu Trữ";
                gv_DanhSachTK.Columns["IDThuoc"].Caption = "Mã Thuốc";
                gv_DanhSachTK.Columns["TenThuoc"].Caption = "Tên Thuốc";
                gv_DanhSachTK.Columns["ThanhPhan"].Caption = "Thành Phần";
                gv_DanhSachTK.Columns["SLton"].Caption = "Số Lượng";
                gv_DanhSachTK.Columns["NgayHetHan"].Caption = "Ngày Hết Hạn";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gv_DanhSachTK_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int rowHandle = e.FocusedRowHandle;
            if (rowHandle >= 0)
            {
                // Lấy giá trị từ dòng được chọn
                lb_MaLuuTru.Text = gv_DanhSachTK.GetRowCellValue(rowHandle, "IDLuuTru")?.ToString() ?? "";
                lb_MaThuoc.Text = gv_DanhSachTK.GetRowCellValue(rowHandle, "IDThuoc")?.ToString() ?? "";
                lb_TenThuoc.Text = gv_DanhSachTK.GetRowCellValue(rowHandle, "TenThuoc")?.ToString() ?? "";
                lb_ThanhPhan.Text = gv_DanhSachTK.GetRowCellValue(rowHandle, "ThanhPhan")?.ToString() ?? "";
                lb_SoLuong.Text = gv_DanhSachTK.GetRowCellValue(rowHandle, "SLton")?.ToString() ?? "";
            }
        }

        private void ThongkeBaocao_Load(object sender, EventArgs e)
        {
            LoadStoredMedicines();
        }

        private void cb_ChonLTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cb_ChonLTK.SelectedItem.ToString();

            if (selectedValue == "Theo tên")
            {
                // Disable DateEdit, Enable TextBox
                de_TuNgay.Enabled = false;
                de_DenNgay.Enabled = false;
                txt_TimThuoc.Enabled = true;

                // Clear DateEdit
                de_TuNgay.EditValue = null;
                de_DenNgay.EditValue = null;
            }
            else if (selectedValue == "Theo hạn sử dụng")
            {
                // Enable DateEdit, Disable TextBox
                de_TuNgay.Enabled = true;
                de_DenNgay.Enabled = true;
                txt_TimThuoc.Enabled = false;

                // Clear TextBox
                txt_TimThuoc.Text = string.Empty;
            }
        }

        private void txt_TimThuoc_TextChanged(object sender, EventArgs e)
        {
            if (cb_ChonLTK.SelectedItem != null && cb_ChonLTK.SelectedItem.ToString() == "Theo tên")
            {
                string keyword = txt_TimThuoc.Text.Trim();

                LuuTruBLL luuTruBLL = new LuuTruBLL(_username, _password);

                DataTable result = luuTruBLL.SearchMedicineByName(keyword);

                gc_DanhSach.DataSource = result;

                gv_DanhSachTK.Columns["IDLuuTru"].Caption = "Mã Lưu Trữ";
                gv_DanhSachTK.Columns["IDThuoc"].Caption = "Mã Thuốc";
                gv_DanhSachTK.Columns["TenThuoc"].Caption = "Tên Thuốc";
                gv_DanhSachTK.Columns["ThanhPhan"].Caption = "Thành Phần";
                gv_DanhSachTK.Columns["SLton"].Caption = "Số Lượng";
                gv_DanhSachTK.Columns["NgayHetHan"].Caption = "Ngày Hết Hạn";

                gv_DanhSachTK.BestFitColumns();
            }
        }
        private void FilterMedicinesByDate()
        {
            if (cb_ChonLTK.SelectedItem != null && cb_ChonLTK.SelectedItem.ToString() == "Theo hạn sử dụng")
            {
                DateTime? fromDate = de_TuNgay.EditValue as DateTime?;
                DateTime? toDate = de_DenNgay.EditValue as DateTime?;

                if (!fromDate.HasValue || !toDate.HasValue)
                {
                    MessageBox.Show("Vui lòng chọn khoảng thời gian hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (fromDate > toDate)
                {
                    MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    // Gọi BLL để lấy dữ liệu theo khoảng thời gian
                    LuuTruBLL luuTruBLL = new LuuTruBLL(_username, _password);
                    DataTable result = luuTruBLL.LayThuocTheoKhoangThoiGian(fromDate.Value, toDate.Value);

                    // Gán dữ liệu vào GridControl
                    gc_DanhSach.DataSource = result;

                    // Đặt tên cột
                    gv_DanhSachTK.Columns["IDLuuTru"].Caption = "Mã Lưu Trữ";
                    gv_DanhSachTK.Columns["IDThuoc"].Caption = "Mã Thuốc";
                    gv_DanhSachTK.Columns["TenThuoc"].Caption = "Tên Thuốc";
                    gv_DanhSachTK.Columns["ThanhPhan"].Caption = "Thành Phần";
                    gv_DanhSachTK.Columns["SLton"].Caption = "Số Lượng";
                    gv_DanhSachTK.Columns["NgayHetHan"].Caption = "Ngày Hết Hạn";

                    gv_DanhSachTK.BestFitColumns();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void de_TuNgay_EditValueChanged(object sender, EventArgs e)
        {
            FilterMedicinesByDate();
        }

        private void de_DenNgay_EditValueChanged(object sender, EventArgs e)
        {
            FilterMedicinesByDate();
        }
        private void ExportToExcel(DataTable data, string folderPath)
        {
            try
            {
                // Tên file mặc định với ngày và thời gian hiện tại
                string fileName = $"Thống kê thuốc ngày {DateTime.Now:dd-MM-yyyy HH-mm}.xlsx";
                string filePath = Path.Combine(folderPath, fileName);

                // Thiết lập giấy phép cho EPPlus
                OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                using (var package = new OfficeOpenXml.ExcelPackage())
                {
                    // Tạo worksheet
                    var worksheet = package.Workbook.Worksheets.Add("Báo cáo");

                    // Ghi tiêu đề cột tiếng Việt
                    var columnHeaders = new Dictionary<string, string>
            {
                { "IDLuuTru", "Mã Lưu Trữ" },
                { "IDThuoc", "Mã Thuốc" },
                { "TenThuoc", "Tên Thuốc" },
                { "ThanhPhan", "Thành Phần" },
                { "SLton", "Số Lượng" },
                { "NgayHetHan", "Ngày Hết Hạn" }
            };

                    // Ghi tiêu đề cột vào dòng đầu tiên
                    int colIndex = 1;
                    foreach (var column in data.Columns.Cast<DataColumn>())
                    {
                        if (columnHeaders.ContainsKey(column.ColumnName))
                        {
                            worksheet.Cells[1, colIndex].Value = columnHeaders[column.ColumnName];
                        }
                        else
                        {
                            worksheet.Cells[1, colIndex].Value = column.ColumnName; // Trường hợp không có cột trong từ điển
                        }

                        // Định dạng tiêu đề cột
                        worksheet.Cells[1, colIndex].Style.Font.Bold = true;
                        worksheet.Cells[1, colIndex].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        colIndex++;
                    }

                    // Ghi dữ liệu từ DataTable
                    for (int row = 0; row < data.Rows.Count; row++)
                    {
                        for (int col = 0; col < data.Columns.Count; col++)
                        {
                            if (data.Columns[col].ColumnName == "NgayHetHan") // Kiểm tra cột "Ngày Hết Hạn"
                            {
                                if (DateTime.TryParse(data.Rows[row][col]?.ToString(), out DateTime ngayHetHan))
                                {
                                    worksheet.Cells[row + 2, col + 1].Value = ngayHetHan; // Gán giá trị ngày
                                    worksheet.Cells[row + 2, col + 1].Style.Numberformat.Format = "dd/MM/yyyy"; // Định dạng ngày
                                }
                            }
                            else
                            {
                                worksheet.Cells[row + 2, col + 1].Value = data.Rows[row][col];
                            }
                        }
                    }

                    // Tự động điều chỉnh kích thước cột
                    worksheet.Cells.AutoFitColumns();

                    // Lưu file
                    package.SaveAs(new FileInfo(filePath));
                }

                MessageBox.Show($"Xuất báo cáo thành công!\nĐường dẫn: {filePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_InBaoCao_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ GridControl
            DataTable reportData = (DataTable)gc_DanhSach.DataSource;

            if (reportData == null || reportData.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị hộp thoại chọn thư mục
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Chọn thư mục để lưu báo cáo";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderBrowserDialog.SelectedPath;

                    // Gọi phương thức xuất Excel
                    ExportToExcel(reportData, folderPath);
                }
            }
        }
    }
}
