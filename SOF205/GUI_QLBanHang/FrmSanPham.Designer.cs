namespace GUI_QLBanHang
{
    partial class FrmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSanPham));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.imgListIcon = new System.Windows.Forms.ImageList(this.components);
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btBoQua = new System.Windows.Forms.Button();
            this.btDanhSach = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.btMo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(494, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(188, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sản phẩm";
            // 
            // lblMaHang
            // 
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMaHang.Location = new System.Drawing.Point(65, 71);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(72, 20);
            this.lblMaHang.TabIndex = 1;
            this.lblMaHang.Text = "Mã hàng";
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTenHang.Location = new System.Drawing.Point(65, 117);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(77, 20);
            this.lblTenHang.TabIndex = 1;
            this.lblTenHang.Text = "Tên hàng";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSoLuong.Location = new System.Drawing.Point(65, 161);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(73, 20);
            this.lblSoLuong.TabIndex = 1;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDiaChi.Location = new System.Drawing.Point(526, 71);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(44, 20);
            this.lblDiaChi.TabIndex = 1;
            this.lblDiaChi.Text = "Hình";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(526, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ghi chú";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(197, 71);
            this.txtMa.Multiline = true;
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(263, 28);
            this.txtMa.TabIndex = 0;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(197, 117);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(263, 28);
            this.txtTen.TabIndex = 1;
            // 
            // txtHinh
            // 
            this.txtHinh.Location = new System.Drawing.Point(615, 63);
            this.txtHinh.Multiline = true;
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.Size = new System.Drawing.Size(218, 57);
            this.txtHinh.TabIndex = 4;
            // 
            // dgvHang
            // 
            this.dgvHang.AllowUserToAddRows = false;
            this.dgvHang.AllowUserToDeleteRows = false;
            this.dgvHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHang.Location = new System.Drawing.Point(12, 313);
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.RowHeadersVisible = false;
            this.dgvHang.RowHeadersWidth = 51;
            this.dgvHang.RowTemplate.Height = 24;
            this.dgvHang.Size = new System.Drawing.Size(1158, 250);
            this.dgvHang.TabIndex = 6;
            this.dgvHang.TabStop = false;
            this.dgvHang.Click += new System.EventHandler(this.dgvHang_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.LightGray;
            this.txtTimKiem.Location = new System.Drawing.Point(347, 590);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(283, 22);
            this.txtTimKiem.TabIndex = 7;
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.ImageIndex = 0;
            this.btTimKiem.ImageList = this.imgListIcon;
            this.btTimKiem.Location = new System.Drawing.Point(646, 581);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(100, 41);
            this.btTimKiem.TabIndex = 8;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimKiem.UseVisualStyleBackColor = true;
            // 
            // imgListIcon
            // 
            this.imgListIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListIcon.ImageStream")));
            this.imgListIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListIcon.Images.SetKeyName(0, "find.png");
            this.imgListIcon.Images.SetKeyName(1, "add-icon.png");
            this.imgListIcon.Images.SetKeyName(2, "Actions-edit-delete-icon.png");
            this.imgListIcon.Images.SetKeyName(3, "edit.png");
            this.imgListIcon.Images.SetKeyName(4, "Save-icon.png");
            this.imgListIcon.Images.SetKeyName(5, "Cancel.png");
            this.imgListIcon.Images.SetKeyName(6, "Data-List-icon.png");
            this.imgListIcon.Images.SetKeyName(7, "Close-icon.png");
            // 
            // btThem
            // 
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.ImageIndex = 1;
            this.btThem.ImageList = this.imgListIcon;
            this.btThem.Location = new System.Drawing.Point(34, 650);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 41);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.ImageIndex = 2;
            this.btXoa.ImageList = this.imgListIcon;
            this.btXoa.Location = new System.Drawing.Point(197, 650);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 41);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.ImageIndex = 3;
            this.btSua.ImageList = this.imgListIcon;
            this.btSua.Location = new System.Drawing.Point(360, 650);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 41);
            this.btSua.TabIndex = 11;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btLuu
            // 
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.ImageIndex = 4;
            this.btLuu.ImageList = this.imgListIcon;
            this.btLuu.Location = new System.Drawing.Point(530, 650);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(100, 41);
            this.btLuu.TabIndex = 12;
            this.btLuu.Text = "Lưu";
            this.btLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btBoQua
            // 
            this.btBoQua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btBoQua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBoQua.ImageIndex = 5;
            this.btBoQua.ImageList = this.imgListIcon;
            this.btBoQua.Location = new System.Drawing.Point(698, 650);
            this.btBoQua.Name = "btBoQua";
            this.btBoQua.Size = new System.Drawing.Size(100, 41);
            this.btBoQua.TabIndex = 13;
            this.btBoQua.Text = "Bỏ qua";
            this.btBoQua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBoQua.UseVisualStyleBackColor = false;
            this.btBoQua.Click += new System.EventHandler(this.btBoQua_Click);
            // 
            // btDanhSach
            // 
            this.btDanhSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDanhSach.ImageIndex = 6;
            this.btDanhSach.ImageList = this.imgListIcon;
            this.btDanhSach.Location = new System.Drawing.Point(865, 650);
            this.btDanhSach.Name = "btDanhSach";
            this.btDanhSach.Size = new System.Drawing.Size(112, 41);
            this.btDanhSach.TabIndex = 14;
            this.btDanhSach.Text = "Danh sách";
            this.btDanhSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDanhSach.UseVisualStyleBackColor = true;
            this.btDanhSach.Click += new System.EventHandler(this.btDanhSach_Click);
            // 
            // btDong
            // 
            this.btDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDong.ImageIndex = 7;
            this.btDong.ImageList = this.imgListIcon;
            this.btDong.Location = new System.Drawing.Point(1033, 650);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(100, 41);
            this.btDong.TabIndex = 15;
            this.btDong.Text = "Đóng";
            this.btDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(197, 161);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(263, 28);
            this.txtSoLuong.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(65, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đơn giá nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(65, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn giá bán";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(197, 205);
            this.txtGiaNhap.Multiline = true;
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(263, 28);
            this.txtGiaNhap.TabIndex = 3;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(197, 247);
            this.txtGiaBan.Multiline = true;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(263, 28);
            this.txtGiaBan.TabIndex = 4;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(598, 149);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(326, 106);
            this.txtGhiChu.TabIndex = 5;
            // 
            // pbHinh
            // 
            this.pbHinh.Location = new System.Drawing.Point(973, 63);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(188, 212);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 9;
            this.pbHinh.TabStop = false;
            // 
            // btMo
            // 
            this.btMo.Image = ((System.Drawing.Image)(resources.GetObject("btMo.Image")));
            this.btMo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMo.Location = new System.Drawing.Point(882, 65);
            this.btMo.Name = "btMo";
            this.btMo.Size = new System.Drawing.Size(90, 35);
            this.btMo.TabIndex = 6;
            this.btMo.Text = "Mở hình";
            this.btMo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMo.UseVisualStyleBackColor = true;
            this.btMo.Click += new System.EventHandler(this.btMo_Click);
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.btMo);
            this.Controls.Add(this.pbHinh);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btDanhSach);
            this.Controls.Add(this.btBoQua);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvHang);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtHinh);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTenHang);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblMaHang);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSanPham";
            this.Load += new System.EventHandler(this.FrmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHinh;
        private System.Windows.Forms.DataGridView dgvHang;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btBoQua;
        private System.Windows.Forms.Button btDanhSach;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.ImageList imgListIcon;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.Button btMo;
    }
}

