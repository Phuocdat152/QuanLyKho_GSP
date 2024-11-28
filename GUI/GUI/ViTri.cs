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
                Size = new Size(550, 180),
                StartPosition = FormStartPosition.CenterScreen
            };

            int xStart = 20;
            int yStart = 20;
            int oWidth = 80;
            int oHeight = 50;

            for (int i = 0; i < oList.Count; i++)
            {
                string tenO = oList[i]["TenO"].ToString();
                string trangThai = oList[i]["TrangThai"].ToString();

                Button btnO = new Button
                {
                    Name = $"btnO_{i + 1}",
                    Text = $"{tenO}\n{trangThai}",
                    Size = new Size(oWidth, oHeight),
                    Location = new Point(xStart + (i % 5) * (oWidth + 20), yStart + (i / 5) * (oHeight + 20)),
                    BackColor = trangThai == "Còn trống" ? Color.LightYellow : Color.LightCoral
                };

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
            int khuWidth = 300; // Chiều rộng khu
            int khuHeight = 300; // Chiều cao khu
            int spacing = 20; // Khoảng cách giữa các khu
            int columns = groupControlWidth / (khuWidth + spacing); // Số lượng cột hiển thị được

            if (columns == 0) columns = 1; // Đảm bảo ít nhất có 1 cột
            int totalWidth = columns * khuWidth + (columns - 1) * spacing;
            int xStart = (groupControlWidth - totalWidth) / 2; // Căn giữa theo chiều ngang
            int yStart = 70;

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
                    Font = new Font("Arial", 14, FontStyle.Bold),
                    ForeColor = Color.Black,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Height = 40
                };
                pnlKhu.Controls.Add(lblTenKhu);

                var keGroups = dtViTri.AsEnumerable()
                    .Where(rows => rows["IDKhu"].ToString() == khuGroups[i].Key.IDKhu)
                    .GroupBy(rows => new
                    {
                        IDKe = rows["IDKe"].ToString(),
                        TenKe = rows["TenKe"].ToString()
                    }).ToList();

                int keWidth = 70;
                int keHeight = 40;
                int keColumns = 4; // Số cột kệ
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
                        BackColor = Color.LightGreen
                    };

                    var oList = dtViTri.AsEnumerable()
                        .Where(rows => rows["IDKe"].ToString() == keGroups[j].Key.IDKe)
                        .ToList();

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
