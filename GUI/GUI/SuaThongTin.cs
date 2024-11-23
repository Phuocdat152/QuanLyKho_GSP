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
    public partial class SuaThongTin : Form
    {
        private UserBLL userBLL;
        private UserDTO selectedUser;
        public SuaThongTin(UserDTO user, UserBLL bll)
        {
            InitializeComponent();
            selectedUser = user;
            userBLL = bll;

            // Tải danh sách chức vụ và đặt vào ComboBox
            LoadChucVuList();

            // Hiển thị thông tin nhân viên lên các control
            txt_upTen.Text = selectedUser.TenNhanVien;
            cb_upchucvu.SelectedValue = selectedUser.ChucVuID; // Đặt chức vụ đã chọn
            dtp_upNgaySinh.Value = selectedUser.NgaySinh;
            cb_SuaTrinhDo.Text = selectedUser.TrinhDo;
            txt_upEmail.Text = selectedUser.Email;
            txt_upDiaChi.Text = selectedUser.DiaChi;
            txt_upSDT.Text = selectedUser.SoDienThoai;

            if (selectedUser.Anh != null)
            {
                using (MemoryStream ms = new MemoryStream(selectedUser.Anh))
                {
                    pb_Anh.Image = Image.FromStream(ms);
                }
            }
        }

        private void btn_upTaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pb_Anh.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btn_LuuTD_Click(object sender, EventArgs e)
        {
            selectedUser.TenNhanVien = txt_upTen.Text;
            selectedUser.ChucVuID = cb_upchucvu.SelectedValue.ToString();
            selectedUser.NgaySinh = dtp_upNgaySinh.Value;
            selectedUser.TrinhDo = cb_SuaTrinhDo.Text;
            selectedUser.Email = txt_upEmail.Text;
            selectedUser.DiaChi = txt_upDiaChi.Text;
            selectedUser.SoDienThoai = txt_upSDT.Text;

            if (pb_Anh.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Tạo bản sao của ảnh để lưu vào MemoryStream
                    using (var tempImage = new Bitmap(pb_Anh.Image))
                    {
                        tempImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    selectedUser.Anh = ms.ToArray();
                }
            }

            // Cập nhật thông tin vào cơ sở dữ liệu
            if (userBLL.UpdateNhanVien(selectedUser))
            {
                MessageBox.Show("Cập nhật thông tin thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật thông tin.");
            }
        }

        private void SuaThongTin_Load(object sender, EventArgs e)
        {

        }
        private void LoadChucVuList()
        {
            try
            {
                DataTable dtChucVu = userBLL.GetChucVuList();
                cb_upchucvu.DataSource = dtChucVu;
                cb_upchucvu.DisplayMember = "TenChucVu";
                cb_upchucvu.ValueMember = "IDChucVu";

                // Đặt chức vụ mặc định (dựa vào ChucVuID của nhân viên)
                cb_upchucvu.SelectedValue = selectedUser.ChucVuID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách chức vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
