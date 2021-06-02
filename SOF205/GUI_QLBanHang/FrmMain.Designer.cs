namespace GUI_QLBanHang
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuToolStripMenu = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangNhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoSoNVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeSanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huongDanSuDungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gioiThieuPhanMemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinNVStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTitle = new System.Windows.Forms.Label();
            this.menuToolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuToolStripMenu
            // 
            this.menuToolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuToolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.danhMucToolStripMenuItem,
            this.thongKeToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem,
            this.thongTinNVStripMenuItem});
            this.menuToolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.menuToolStripMenu.Name = "menuToolStripMenu";
            this.menuToolStripMenu.Size = new System.Drawing.Size(1342, 28);
            this.menuToolStripMenu.TabIndex = 0;
            this.menuToolStripMenu.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangNhapToolStripMenuItem,
            this.dangXuatToolStripMenuItem,
            this.hoSoNVToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.heThongToolStripMenuItem.Text = "Hệ Thống";
            // 
            // dangNhapToolStripMenuItem
            // 
            this.dangNhapToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dangNhapToolStripMenuItem.Image")));
            this.dangNhapToolStripMenuItem.Name = "dangNhapToolStripMenuItem";
            this.dangNhapToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dangNhapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.dangNhapToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.dangNhapToolStripMenuItem.Text = "Đăng nhập";
            this.dangNhapToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dangXuatToolStripMenuItem.Image")));
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.dangXuatToolStripMenuItem.Text = "Đăng xuất";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // hoSoNVToolStripMenuItem
            // 
            this.hoSoNVToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hoSoNVToolStripMenuItem.Image")));
            this.hoSoNVToolStripMenuItem.Name = "hoSoNVToolStripMenuItem";
            this.hoSoNVToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.hoSoNVToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.hoSoNVToolStripMenuItem.Text = "Hồ sơ nhân viên";
            this.hoSoNVToolStripMenuItem.Click += new System.EventHandler(this.hoSoNVToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoatToolStripMenuItem.Image")));
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // danhMucToolStripMenuItem
            // 
            this.danhMucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sanPhamToolStripMenuItem,
            this.nhanVienToolStripMenuItem,
            this.khachHangToolStripMenuItem});
            this.danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            this.danhMucToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMucToolStripMenuItem.Text = "Danh mục";
            // 
            // sanPhamToolStripMenuItem
            // 
            this.sanPhamToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sanPhamToolStripMenuItem.Image")));
            this.sanPhamToolStripMenuItem.Name = "sanPhamToolStripMenuItem";
            this.sanPhamToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.sanPhamToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.sanPhamToolStripMenuItem.Text = "Sản phẩm";
            this.sanPhamToolStripMenuItem.Click += new System.EventHandler(this.sanPhamToolStripMenuItem_Click);
            // 
            // nhanVienToolStripMenuItem
            // 
            this.nhanVienToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nhanVienToolStripMenuItem.Image")));
            this.nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            this.nhanVienToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.nhanVienToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.nhanVienToolStripMenuItem.Text = "Nhân viên";
            this.nhanVienToolStripMenuItem.Click += new System.EventHandler(this.nhanVienToolStripMenuItem_Click);
            // 
            // khachHangToolStripMenuItem
            // 
            this.khachHangToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("khachHangToolStripMenuItem.Image")));
            this.khachHangToolStripMenuItem.Name = "khachHangToolStripMenuItem";
            this.khachHangToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.khachHangToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.khachHangToolStripMenuItem.Text = "Khách hàng";
            this.khachHangToolStripMenuItem.Click += new System.EventHandler(this.khachHangToolStripMenuItem_Click);
            // 
            // thongKeToolStripMenuItem
            // 
            this.thongKeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongKeSanPhamToolStripMenuItem});
            this.thongKeToolStripMenuItem.Name = "thongKeToolStripMenuItem";
            this.thongKeToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.thongKeToolStripMenuItem.Text = "Thống kê";
            // 
            // thongKeSanPhamToolStripMenuItem
            // 
            this.thongKeSanPhamToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thongKeSanPhamToolStripMenuItem.Image")));
            this.thongKeSanPhamToolStripMenuItem.Name = "thongKeSanPhamToolStripMenuItem";
            this.thongKeSanPhamToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.thongKeSanPhamToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.thongKeSanPhamToolStripMenuItem.Text = "Thống kê sản phẩm";
            this.thongKeSanPhamToolStripMenuItem.Click += new System.EventHandler(this.thongKeSanPhamToolStripMenuItem_Click);
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.huongDanSuDungToolStripMenuItem,
            this.gioiThieuPhanMemToolStripMenuItem});
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng Dẫn";
            // 
            // huongDanSuDungToolStripMenuItem
            // 
            this.huongDanSuDungToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("huongDanSuDungToolStripMenuItem.Image")));
            this.huongDanSuDungToolStripMenuItem.Name = "huongDanSuDungToolStripMenuItem";
            this.huongDanSuDungToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.huongDanSuDungToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.huongDanSuDungToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            this.huongDanSuDungToolStripMenuItem.Click += new System.EventHandler(this.huongDanSuDungToolStripMenuItem_Click);
            // 
            // gioiThieuPhanMemToolStripMenuItem
            // 
            this.gioiThieuPhanMemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gioiThieuPhanMemToolStripMenuItem.Image")));
            this.gioiThieuPhanMemToolStripMenuItem.Name = "gioiThieuPhanMemToolStripMenuItem";
            this.gioiThieuPhanMemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.gioiThieuPhanMemToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.gioiThieuPhanMemToolStripMenuItem.Text = "Giới thiệu phần mềm";
            this.gioiThieuPhanMemToolStripMenuItem.Click += new System.EventHandler(this.gioiThieuPhanMemToolStripMenuItem_Click);
            // 
            // thongTinNVStripMenuItem
            // 
            this.thongTinNVStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.thongTinNVStripMenuItem.Name = "thongTinNVStripMenuItem";
            this.thongTinNVStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.No;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Red;
            this.labelTitle.Location = new System.Drawing.Point(324, 35);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(640, 38);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "DỰ ÁN MẪU C# - QUẢN LÝ BÁN HÀNG";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1342, 853);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.menuToolStripMenu);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuToolStripMenu;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuToolStripMenu.ResumeLayout(false);
            this.menuToolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangNhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huongDanSuDungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gioiThieuPhanMemToolStripMenuItem;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ToolStripMenuItem hoSoNVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeSanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinNVStripMenuItem;
    }
}

