namespace GUI
{
    partial class TrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_NhapKho = new DevExpress.XtraBars.BarButtonItem();
            this.btn_CapPhat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ViTri = new DevExpress.XtraBars.BarButtonItem();
            this.btn_LuuTru = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.btn_TraCuuThuoc = new DevExpress.XtraBars.BarButtonItem();
            this.btn_HuyThuoc = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_KiemKe = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ThongKe = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_NhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_NhomThuoc = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Thuoc = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NhaCC = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btn_NhapKho,
            this.btn_CapPhat,
            this.btn_ViTri,
            this.btn_LuuTru,
            this.btn_DangXuat,
            this.btn_TraCuuThuoc,
            this.btn_HuyThuoc,
            this.btn_KiemKe,
            this.btn_ThongKe,
            this.btn_NhanVien,
            this.btn_NhomThuoc,
            this.btn_Thuoc,
            this.btn_NhaCC});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 14;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.btn_DangXuat);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbon.Size = new System.Drawing.Size(1341, 141);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_NhapKho
            // 
            this.btn_NhapKho.Caption = "Nhập kho";
            this.btn_NhapKho.Hint = "Nhập kho";
            this.btn_NhapKho.Id = 1;
            this.btn_NhapKho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_NhapKho.ImageOptions.LargeImage")));
            this.btn_NhapKho.Name = "btn_NhapKho";
            this.btn_NhapKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NhapKho_ItemClick);
            // 
            // btn_CapPhat
            // 
            this.btn_CapPhat.Caption = "Cấp phát";
            this.btn_CapPhat.Hint = "Cấp phát";
            this.btn_CapPhat.Id = 2;
            this.btn_CapPhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapPhat.ImageOptions.Image")));
            this.btn_CapPhat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_CapPhat.ImageOptions.LargeImage")));
            this.btn_CapPhat.Name = "btn_CapPhat";
            this.btn_CapPhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_CapPhat_ItemClick);
            // 
            // btn_ViTri
            // 
            this.btn_ViTri.Caption = "Vị trí";
            this.btn_ViTri.Hint = "Vị trí";
            this.btn_ViTri.Id = 3;
            this.btn_ViTri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_ViTri.ImageOptions.LargeImage")));
            this.btn_ViTri.Name = "btn_ViTri";
            this.btn_ViTri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ViTri_ItemClick);
            // 
            // btn_LuuTru
            // 
            this.btn_LuuTru.Caption = "Lưu trữ";
            this.btn_LuuTru.Hint = "Lưu trữ";
            this.btn_LuuTru.Id = 4;
            this.btn_LuuTru.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_LuuTru.ImageOptions.LargeImage")));
            this.btn_LuuTru.Name = "btn_LuuTru";
            this.btn_LuuTru.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_LuuTru_ItemClick);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Caption = "Đăng xuất";
            this.btn_DangXuat.Hint = "Đăng xuất";
            this.btn_DangXuat.Id = 5;
            this.btn_DangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.ImageOptions.Image")));
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DangXuat_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chức năng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_NhapKho);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_CapPhat, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_ViTri, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_LuuTru, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_TraCuuThuoc, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_HuyThuoc, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 838);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1341, 24);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // btn_TraCuuThuoc
            // 
            this.btn_TraCuuThuoc.Caption = "Tra cứu thuốc";
            this.btn_TraCuuThuoc.Hint = "Tra cứu thuốc";
            this.btn_TraCuuThuoc.Id = 6;
            this.btn_TraCuuThuoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_TraCuuThuoc.ImageOptions.LargeImage")));
            this.btn_TraCuuThuoc.Name = "btn_TraCuuThuoc";
            this.btn_TraCuuThuoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TraCuuThuoc_ItemClick);
            // 
            // btn_HuyThuoc
            // 
            this.btn_HuyThuoc.Caption = "Hủy thuốc";
            this.btn_HuyThuoc.Hint = "Hủy thuốc";
            this.btn_HuyThuoc.Id = 7;
            this.btn_HuyThuoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btn_HuyThuoc.Name = "btn_HuyThuoc";
            this.btn_HuyThuoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_HuyThuoc_ItemClick);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_KiemKe);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_ThongKe, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // btn_KiemKe
            // 
            this.btn_KiemKe.Caption = "Kiểm kê";
            this.btn_KiemKe.Hint = "Kiểm kê";
            this.btn_KiemKe.Id = 8;
            this.btn_KiemKe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_KiemKe.ImageOptions.LargeImage")));
            this.btn_KiemKe.Name = "btn_KiemKe";
            this.btn_KiemKe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_KiemKe_ItemClick);
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Caption = "Thống kê";
            this.btn_ThongKe.Hint = "Thống kê";
            this.btn_ThongKe.Id = 9;
            this.btn_ThongKe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_ThongKe.ImageOptions.LargeImage")));
            this.btn_ThongKe.Name = "btn_ThongKe";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Danh mục";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_NhanVien);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_NhaCC, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.Caption = "Quản lý nhân viên";
            this.btn_NhanVien.Id = 10;
            this.btn_NhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_NhanVien.ImageOptions.LargeImage")));
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NhanVien_ItemClick);
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_NhomThuoc);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_Thuoc, true);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // btn_NhomThuoc
            // 
            this.btn_NhomThuoc.Caption = "Nhóm thuốc";
            this.btn_NhomThuoc.Id = 11;
            this.btn_NhomThuoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_NhomThuoc.ImageOptions.LargeImage")));
            this.btn_NhomThuoc.Name = "btn_NhomThuoc";
            this.btn_NhomThuoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NhomThuoc_ItemClick);
            // 
            // btn_Thuoc
            // 
            this.btn_Thuoc.Caption = "Thuốc";
            this.btn_Thuoc.Id = 12;
            this.btn_Thuoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Thuoc.ImageOptions.LargeImage")));
            this.btn_Thuoc.Name = "btn_Thuoc";
            this.btn_Thuoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Thuoc_ItemClick);
            // 
            // btn_NhaCC
            // 
            this.btn_NhaCC.Caption = "Nhà cung cấp";
            this.btn_NhaCC.Id = 13;
            this.btn_NhaCC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_NhaCC.ImageOptions.SvgImage")));
            this.btn_NhaCC.Name = "btn_NhaCC";
            this.btn_NhaCC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NhaCC_ItemClick);
            // 
            // TrangChu
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 862);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "TrangChu";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Phần mềm quản lý kho dược theo chuẩn GSP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TrangChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btn_NhapKho;
        private DevExpress.XtraBars.BarButtonItem btn_CapPhat;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem btn_ViTri;
        private DevExpress.XtraBars.BarButtonItem btn_LuuTru;
        private DevExpress.XtraBars.BarButtonItem btn_DangXuat;
        private DevExpress.XtraBars.BarButtonItem btn_TraCuuThuoc;
        private DevExpress.XtraBars.BarButtonItem btn_HuyThuoc;
        private DevExpress.XtraBars.BarButtonItem btn_KiemKe;
        private DevExpress.XtraBars.BarButtonItem btn_ThongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btn_NhanVien;
        private DevExpress.XtraBars.BarButtonItem btn_NhomThuoc;
        private DevExpress.XtraBars.BarButtonItem btn_Thuoc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btn_NhaCC;
    }
}