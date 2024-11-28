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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class SaoLuuPhucHoi : Form
    {
        private SaoLuuPhucHoiBLL saoLuuPhucHoiBLL;

        public SaoLuuPhucHoi(string username, string password)
        {
            InitializeComponent();
            saoLuuPhucHoiBLL = new SaoLuuPhucHoiBLL(username, password);
        }
        private void btn_ChonFile_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_ViTriLuu.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void btn_SaoLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txt_TenFile.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên file sao lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_ViTriLuu.Text))
                {
                    MessageBox.Show("Vui lòng chọn vị trí lưu file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đường dẫn file sao lưu
                string backupFilePath = Path.Combine(txt_ViTriLuu.Text, $"{txt_TenFile.Text}.bak");

                // Gọi BLL để thực hiện sao lưu
                saoLuuPhucHoiBLL.BackupDatabase(backupFilePath);

                MessageBox.Show("Sao lưu cơ sở dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sao lưu cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ChonFileRestore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Backup Files|*.bak";
                openFileDialog.Title = "Chọn file phục hồi";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_ViTriPH.Text = openFileDialog.FileName; // Hiển thị đường dẫn file đã chọn
                }
            }
        }

        private void btn_PhucHoi_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu file chưa được chọn
                if (string.IsNullOrWhiteSpace(txt_ViTriPH.Text))
                {
                    MessageBox.Show("Vui lòng chọn file phục hồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string restoreFilePath = txt_ViTriPH.Text;

                // Gọi BLL để thực hiện phục hồi
                saoLuuPhucHoiBLL.RestoreDatabase(restoreFilePath);

                MessageBox.Show("Phục hồi cơ sở dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi phục hồi cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
