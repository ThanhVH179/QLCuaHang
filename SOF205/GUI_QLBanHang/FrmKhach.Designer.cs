namespace GUI_QLBanHang
{
    partial class FrmKhach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhach));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDT = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.pnlPhai = new System.Windows.Forms.Panel();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
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
            this.pnlPhai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(471, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Khách hàng";
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDT.Location = new System.Drawing.Point(63, 71);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(83, 20);
            this.lblDT.TabIndex = 1;
            this.lblDT.Text = "Điện thoại";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHoTen.Location = new System.Drawing.Point(63, 122);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(58, 20);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDiaChi.Location = new System.Drawing.Point(526, 71);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(60, 20);
            this.lblDiaChi.TabIndex = 1;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGT.Location = new System.Drawing.Point(526, 122);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(83, 20);
            this.lblGT.TabIndex = 1;
            this.lblGT.Text = "Tình trạng";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(197, 71);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(263, 28);
            this.txtSDT.TabIndex = 0;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(197, 122);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(263, 28);
            this.txtTen.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(621, 71);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(371, 28);
            this.txtDiaChi.TabIndex = 2;
            // 
            // pnlPhai
            // 
            this.pnlPhai.Controls.Add(this.rdbNu);
            this.pnlPhai.Controls.Add(this.rdbNam);
            this.pnlPhai.Location = new System.Drawing.Point(621, 111);
            this.pnlPhai.Name = "pnlPhai";
            this.pnlPhai.Size = new System.Drawing.Size(356, 50);
            this.pnlPhai.TabIndex = 5;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(182, 14);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(47, 21);
            this.rdbNu.TabIndex = 0;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(34, 14);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(58, 21);
            this.rdbNam.TabIndex = 0;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(12, 181);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(1158, 226);
            this.dgvKhachHang.TabIndex = 6;
            this.dgvKhachHang.Click += new System.EventHandler(this.dgvKhachHang_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.LightGray;
            this.txtTimKiem.Location = new System.Drawing.Point(334, 425);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(283, 22);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.ImageIndex = 0;
            this.btTimKiem.ImageList = this.imgListIcon;
            this.btTimKiem.Location = new System.Drawing.Point(648, 416);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(100, 41);
            this.btTimKiem.TabIndex = 4;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
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
            this.btThem.Location = new System.Drawing.Point(34, 485);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 41);
            this.btThem.TabIndex = 5;
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
            this.btXoa.Location = new System.Drawing.Point(197, 485);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 41);
            this.btXoa.TabIndex = 6;
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
            this.btSua.Location = new System.Drawing.Point(360, 485);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 41);
            this.btSua.TabIndex = 7;
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
            this.btLuu.Location = new System.Drawing.Point(530, 485);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(100, 41);
            this.btLuu.TabIndex = 8;
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
            this.btBoQua.Location = new System.Drawing.Point(698, 485);
            this.btBoQua.Name = "btBoQua";
            this.btBoQua.Size = new System.Drawing.Size(100, 41);
            this.btBoQua.TabIndex = 9;
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
            this.btDanhSach.Location = new System.Drawing.Point(865, 485);
            this.btDanhSach.Name = "btDanhSach";
            this.btDanhSach.Size = new System.Drawing.Size(112, 41);
            this.btDanhSach.TabIndex = 10;
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
            this.btDong.Location = new System.Drawing.Point(1033, 485);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(100, 41);
            this.btDong.TabIndex = 11;
            this.btDong.Text = "Đóng";
            this.btDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // FrmKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btDanhSach);
            this.Controls.Add(this.btBoQua);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.pnlPhai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblGT);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblDT);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmKhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKhach";
            this.Load += new System.EventHandler(this.FrmKhach_Load);
            this.pnlPhai.ResumeLayout(false);
            this.pnlPhai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Panel pnlPhai;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.DataGridView dgvKhachHang;
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
    }
}

