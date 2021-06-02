namespace GUI_QLBanHang
{
    partial class FrmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.pnlVaiTro = new System.Windows.Forms.Panel();
            this.rdbQT = new System.Windows.Forms.RadioButton();
            this.rdbNV = new System.Windows.Forms.RadioButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.pnlTinhTrang = new System.Windows.Forms.Panel();
            this.rdbNHD = new System.Windows.Forms.RadioButton();
            this.rdbHD = new System.Windows.Forms.RadioButton();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
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
            this.pnlVaiTro.SuspendLayout();
            this.pnlTinhTrang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(494, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nhân viên";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEmail.Location = new System.Drawing.Point(63, 63);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTen.Location = new System.Drawing.Point(63, 122);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(111, 20);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Tên nhân viên";
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaiTro.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblVaiTro.Location = new System.Drawing.Point(63, 169);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(57, 20);
            this.lblVaiTro.TabIndex = 1;
            this.lblVaiTro.Text = "Vai trò";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDiaChi.Location = new System.Drawing.Point(526, 63);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(60, 20);
            this.lblDiaChi.TabIndex = 1;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(526, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tình trạng";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(197, 63);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 28);
            this.txtEmail.TabIndex = 0;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(197, 122);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(263, 28);
            this.txtTen.TabIndex = 1;
            // 
            // pnlVaiTro
            // 
            this.pnlVaiTro.Controls.Add(this.rdbQT);
            this.pnlVaiTro.Controls.Add(this.rdbNV);
            this.pnlVaiTro.Location = new System.Drawing.Point(197, 156);
            this.pnlVaiTro.Name = "pnlVaiTro";
            this.pnlVaiTro.Size = new System.Drawing.Size(263, 50);
            this.pnlVaiTro.TabIndex = 3;
            // 
            // rdbQT
            // 
            this.rdbQT.AutoSize = true;
            this.rdbQT.Location = new System.Drawing.Point(137, 14);
            this.rdbQT.Name = "rdbQT";
            this.rdbQT.Size = new System.Drawing.Size(80, 21);
            this.rdbQT.TabIndex = 0;
            this.rdbQT.Text = "Quản trị";
            this.rdbQT.UseVisualStyleBackColor = true;
            // 
            // rdbNV
            // 
            this.rdbNV.AutoSize = true;
            this.rdbNV.Location = new System.Drawing.Point(17, 14);
            this.rdbNV.Name = "rdbNV";
            this.rdbNV.Size = new System.Drawing.Size(93, 21);
            this.rdbNV.TabIndex = 0;
            this.rdbNV.Text = "Nhân viên";
            this.rdbNV.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(615, 63);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(371, 66);
            this.txtDiaChi.TabIndex = 3;
            // 
            // pnlTinhTrang
            // 
            this.pnlTinhTrang.Controls.Add(this.rdbNHD);
            this.pnlTinhTrang.Controls.Add(this.rdbHD);
            this.pnlTinhTrang.Location = new System.Drawing.Point(630, 156);
            this.pnlTinhTrang.Name = "pnlTinhTrang";
            this.pnlTinhTrang.Size = new System.Drawing.Size(356, 50);
            this.pnlTinhTrang.TabIndex = 5;
            // 
            // rdbNHD
            // 
            this.rdbNHD.AutoSize = true;
            this.rdbNHD.Location = new System.Drawing.Point(182, 14);
            this.rdbNHD.Name = "rdbNHD";
            this.rdbNHD.Size = new System.Drawing.Size(139, 21);
            this.rdbNHD.TabIndex = 0;
            this.rdbNHD.Text = "Ngừng hoạt động";
            this.rdbNHD.UseVisualStyleBackColor = true;
            // 
            // rdbHD
            // 
            this.rdbHD.AutoSize = true;
            this.rdbHD.Location = new System.Drawing.Point(34, 14);
            this.rdbHD.Name = "rdbHD";
            this.rdbHD.Size = new System.Drawing.Size(95, 21);
            this.rdbHD.TabIndex = 0;
            this.rdbHD.Text = "Hoạt động";
            this.rdbHD.UseVisualStyleBackColor = true;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(12, 212);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(1158, 195);
            this.dgvNhanVien.TabIndex = 6;
            this.dgvNhanVien.Click += new System.EventHandler(this.dgvNhanVien_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.LightGray;
            this.txtTimKiem.Location = new System.Drawing.Point(334, 425);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(283, 22);
            this.txtTimKiem.TabIndex = 4;
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
            this.btTimKiem.TabIndex = 5;
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
            this.btThem.TabIndex = 6;
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
            this.btXoa.TabIndex = 7;
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
            this.btSua.TabIndex = 8;
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
            this.btLuu.TabIndex = 9;
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
            this.btBoQua.TabIndex = 10;
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
            this.btDanhSach.TabIndex = 11;
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
            this.btDong.TabIndex = 12;
            this.btDong.Text = "Đóng";
            this.btDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // FrmNhanVien
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
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.pnlTinhTrang);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.pnlVaiTro);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblVaiTro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNhanVien";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.pnlVaiTro.ResumeLayout(false);
            this.pnlVaiTro.PerformLayout();
            this.pnlTinhTrang.ResumeLayout(false);
            this.pnlTinhTrang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Panel pnlVaiTro;
        private System.Windows.Forms.RadioButton rdbQT;
        private System.Windows.Forms.RadioButton rdbNV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Panel pnlTinhTrang;
        private System.Windows.Forms.RadioButton rdbNHD;
        private System.Windows.Forms.RadioButton rdbHD;
        private System.Windows.Forms.DataGridView dgvNhanVien;
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

