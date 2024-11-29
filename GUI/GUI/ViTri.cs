using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraCharts;
using DAL;


namespace GUI
{
    public partial class ViTri : Form
    {
        private ViTriBLL viTriBLL;
        private KhoBLL khoBLL;
        private DataTable dtViTri; // Biến toàn cục để lưu trữ dữ liệu vị trí

        public ViTri(string username, string password)
        {
            InitializeComponent();
            viTriBLL = new ViTriBLL(username, password);
            khoBLL = new KhoBLL(username, password);


        }


        private void ViTri_Load(object sender, EventArgs e)
        {
            try
            {
                groupControlKho.AutoScroll = true;

                // Tải danh sách kho vào ComboBox
                LoadKhoToComboBox();

                // Lấy dữ liệu vị trí từ CSDL
                DataTable dtViTri = viTriBLL.GetThongTinViTri1();

                // Lưu dữ liệu vị trí vào biến toàn cục
                this.dtViTri = dtViTri;

                // Hiển thị giao diện ban đầu cho kho đầu tiên (nếu có)
                if (cb_Kho.Items.Count > 0)
                {
                    cb_Kho.SelectedIndex = 0; // Chọn giá trị đầu tiên trong ComboBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                // Gọi hàm tạo kho mới
                var result = viTriBLL.TaoKhoMoi();

                // Hiển thị thông báo thành công
                MessageBox.Show($"Kho mới đã được tạo:\nID: {result.IDKhoMoi}\nTên: {result.TenKhoMoi}",
                                "Thành công",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Sau khi tạo kho mới, tải lại dữ liệu vị trí
                DataTable dtViTri = viTriBLL.GetThongTinViTri1();

                // Lọc dữ liệu chỉ lấy kho mới tạo
                DataTable filteredData = dtViTri.AsEnumerable()
                    .Where(row => row["IDKho"].ToString() == result.IDKhoMoi)
                    .CopyToDataTable();

                // Vẽ giao diện chỉ cho kho mới tạo
                VeGiaoDienTuThongTinViTri(filteredData);

                // Cập nhật ComboBox để thêm kho mới
                LoadKhoToComboBox();
                cb_Kho.SelectedItem = cb_Kho.Items.Cast<KeyValuePair<string, string>>()
                                    .FirstOrDefault(item => item.Key == result.IDKhoMoi);
            }
            catch (Exception ex)
            {
                return;
            }
        }




        private void HienThiOTrongKe(List<DataRow> oList)
        {
            // Tạo form hiển thị ô
            Form formO = new Form
            {
                Text = "Danh sách ô",
                Size = new Size(800, 300), // Tăng kích thước form
                StartPosition = FormStartPosition.CenterScreen
            };

            int xStart = 30; // Khoảng cách bắt đầu
            int yStart = 30;
            int oWidth = 120; // Tăng chiều rộng của ô
            int oHeight = 70; // Tăng chiều cao của ô
            int spacing = 30; // Khoảng cách giữa các ô

            for (int i = 0; i < oList.Count; i++)
            {
                string tenO = oList[i]["TenO"].ToString();
                string trangThai = oList[i]["TrangThai"].ToString();

                Button btnO = new Button
                {
                    Name = $"btnO_{i + 1}",
                    Text = $"{tenO}\n{trangThai}",
                    Size = new Size(oWidth, oHeight),
                    Location = new Point(xStart + (i % 5) * (oWidth + spacing), yStart + (i / 5) * (oHeight + spacing)),
                    BackColor = trangThai == "Còn trống" ? Color.LightGreen : Color.Red
                };

                // Gán tooltip để hiển thị thông tin chi tiết
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(btnO, $"Tên ô: {tenO}\nTrạng thái: {trangThai}");

                formO.Controls.Add(btnO);
            }

            formO.ShowDialog();
        }



        private void VeGiaoDienTuThongTinViTri(DataTable dtViTri)
        {
            // Xóa các thành phần cũ trong GroupControl
            groupControlKho.Controls.Clear();

            if (dtViTri == null || dtViTri.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy danh sách khu thuộc kho
            var khuGroups = dtViTri.AsEnumerable().GroupBy(row => new
            {
                IDKhu = row["IDKhu"].ToString(),
                TenKhu = row["TenKhu"].ToString()
            }).ToList();

            int groupControlWidth = groupControlKho.Width; // Chiều rộng GroupControl
            int khuWidth = 400; // Tăng chiều rộng khu
            int khuHeight = 400; // Tăng chiều cao khu
            int spacing = 30; // Tăng khoảng cách giữa các khu
            int columns = groupControlWidth / (khuWidth + spacing); // Số lượng cột hiển thị được

            if (columns == 0) columns = 1; // Đảm bảo ít nhất có 1 cột
            int totalWidth = columns * khuWidth + (columns - 1) * spacing;
            int xStart = (groupControlWidth - totalWidth) / 2; // Căn giữa theo chiều ngang
            int yStart = 100;

            for (int i = 0; i < khuGroups.Count; i++)
            {
                int row = i / columns;
                int col = i % columns;

                int x = xStart + col * (khuWidth + spacing);
                int y = yStart + row * (khuHeight + spacing);

                Panel pnlKhu = new Panel
                {
                    Name = $"pnlKhu_{khuGroups[i].Key.IDKhu}",
                    BackColor = Color.LightBlue,
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(x, y),
                    Size = new Size(khuWidth, khuHeight)
                };

                Label lblTenKhu = new Label
                {
                    Text = khuGroups[i].Key.TenKhu,
                    Font = new Font("Arial", 18, FontStyle.Bold), // Tăng kích thước font
                    ForeColor = Color.Black,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Height = 50
                };
                pnlKhu.Controls.Add(lblTenKhu);

                var keGroups = dtViTri.AsEnumerable()
                    .Where(rows => rows["IDKhu"].ToString() == khuGroups[i].Key.IDKhu)
                    .GroupBy(rows => new
                    {
                        IDKe = rows["IDKe"].ToString(),
                        TenKe = rows["TenKe"].ToString()
                    }).ToList();

                int keWidth = 100; // Tăng chiều rộng của kệ
                int keHeight = 60; // Tăng chiều cao của kệ
                int keColumns = 3; // Giảm số cột để phù hợp kích thước lớn hơn
                int keSpacingX = (khuWidth - keColumns * keWidth) / (keColumns + 1);
                int keRows = (int)Math.Ceiling((double)keGroups.Count / keColumns);
                int keSpacingY = (khuHeight - lblTenKhu.Height - keRows * keHeight) / (keRows + 1);

                for (int j = 0; j < keGroups.Count; j++)
                {
                    int keRow = j / keColumns;
                    int keCol = j % keColumns;

                    Button btnKe = new Button
                    {
                        Name = $"btnKe_{keGroups[j].Key.IDKe}",
                        Text = keGroups[j].Key.TenKe,
                        Size = new Size(keWidth, keHeight),
                        Location = new Point(keSpacingX + keCol * (keWidth + keSpacingX),
                                             lblTenKhu.Height + keSpacingY + keRow * (keHeight + keSpacingY)),
                        BackColor = Color.LightGreen // Mặc định là màu xanh
                    };

                    // Lấy danh sách ô trong kệ
                    var oList = dtViTri.AsEnumerable()
                        .Where(rows => rows["IDKe"].ToString() == keGroups[j].Key.IDKe)
                        .ToList();

                    // Đếm số lượng ô "Đã có thuốc"
                    int countOCoThuoc = oList.Count(o => o["TrangThai"].ToString() == "Đã có thuốc");

                    // Cập nhật màu kệ dựa trên số lượng ô "Đã có thuốc"
                    if (countOCoThuoc == 1)
                    {
                        btnKe.BackColor = Color.Yellow; // Màu vàng cho 1 ô
                    }
                    else if (countOCoThuoc >= 2 && countOCoThuoc <= 4)
                    {
                        btnKe.BackColor = Color.Orange; // Màu cam cho 2-4 ô
                    }
                    else if (countOCoThuoc >= 5)
                    {
                        btnKe.BackColor = Color.Red; // Màu đỏ cho 5 ô trở lên
                    }

                    btnKe.Click += (s, ev) => HienThiOTrongKe(oList);
                    pnlKhu.Controls.Add(btnKe);
                }

                groupControlKho.Controls.Add(pnlKhu);
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

        private void cb_Kho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Kho.SelectedItem is KeyValuePair<string, string> selectedKho)
            {
                string selectedIDKho = selectedKho.Key;

                // Lọc dữ liệu vị trí theo IDKho
                var filteredRows = dtViTri.AsEnumerable()
                    .Where(row => row["IDKho"].ToString() == selectedIDKho);

                if (filteredRows.Any())
                {
                    DataTable filteredData = filteredRows.CopyToDataTable();

                    // Vẽ lại giao diện theo dữ liệu lọc
                    VeGiaoDienTuThongTinViTri(filteredData);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
