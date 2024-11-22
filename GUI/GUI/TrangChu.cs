using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string username, password;
        public TrangChu(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        void OpenForm<T>() where T : Form
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm is T)
                {
                    frm.Activate();
                    return;
                }
            }

            // Khởi tạo form với constructor có tham số
            Form f = (Form)Activator.CreateInstance(typeof(T), username, password);
            f.MdiParent = this;
            f.Show();
        }



        private void TrangChu_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_CapPhat_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<XuatKho>();
        }

        private void btn_NhapKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm<NhapKho>();
        }
    }
}