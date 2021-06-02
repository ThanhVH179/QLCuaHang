using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DTO_QLBanHang;
using BUS_QLBanHang;

namespace GUI_QLBanHang
{
    public partial class FrmSanPham : Form
    {
        public FrmSanPham()
        {
            InitializeComponent();
        }
        BUS_Hang busHang = new BUS_Hang();
        string emailNV = FrmMain.mail;
        string checkUrlImage;
        string fileName;
        string fileSavePath;
        string fileAddress;

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            LoadGridView_Hang();
            ResetValues();
        }
        void LoadGridView_Hang()
        {
            dgvHang.DataSource = busHang.GetHang();
            dgvHang.Columns[0].HeaderText = "Mã sản phẩm";
            dgvHang.Columns[1].HeaderText = "Tên sản phẩm";
            dgvHang.Columns[2].HeaderText = "Số lượng";
            dgvHang.Columns[3].HeaderText = "Đơn giá nhập";
            dgvHang.Columns[4].HeaderText = "Đơn giá bán";
            dgvHang.Columns[5].HeaderText = "Hình ảnh";
            dgvHang.Columns[6].HeaderText = "Ghi chú";
            dgvHang.Columns[7].Visible = false;
        }
        void ResetValues()
        {
            txtTimKiem.Text = "Mời nhập tên hàng";
            txtTimKiem.BackColor = Color.LightGray;
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGiaBan.Enabled = false;
            txtGiaNhap.Enabled = false;
            txtHinh.Enabled = false;
            txtGhiChu.Enabled = false;
            btThem.Enabled = true;
            btXoa.Enabled = false;
            btSua.Enabled = false;
            btLuu.Enabled = false;
            btMo.Enabled = false;
            txtMa.Text = null;
            txtTen.Text = null;
            txtSoLuong.Text = null;
            txtGiaNhap.Text = null;
            txtGiaBan.Text = null;
            txtHinh.Text = null;
            txtGhiChu.Text = null;
            pbHinh.Image = null;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            txtTen.Enabled = true;
            txtSoLuong.Enabled = true;
            txtGiaBan.Enabled = true;
            txtGiaNhap.Enabled = true;
            txtGhiChu.Enabled = true;
            btThem.Enabled = true;
            btXoa.Enabled = false;
            btSua.Enabled = false;
            btLuu.Enabled = true;
            btMo.Enabled = true;
            txtMa.Text = null;
            txtTen.Text = null;
            txtSoLuong.Text = null;
            txtGiaNhap.Text = null;
            txtGiaBan.Text = null;
            txtHinh.Text = null;
            txtGhiChu.Text = null;
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDanhSach_Click(object sender, EventArgs e)
        {
            LoadGridView_Hang();
            ResetValues();
        }

        private void btBoQua_Click(object sender, EventArgs e)
        {
            LoadGridView_Hang();
            ResetValues();
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = null;
            txtTimKiem.BackColor = Color.White;
        }

        private void btMo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap|*.bmp|JPEG Image|*.jpg|GIF|*.gif|All Files|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn hình minh họa";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                fileAddress = dlgOpen.FileName;
                pbHinh.Image = Image.FromFile(fileAddress);
                fileName = Path.GetFileName(dlgOpen.FileName);
                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                fileSavePath = saveDirectory + "\\Images\\" + fileName;
                txtHinh.Text = "\\Images\\" + fileName;
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            int intSoLuong;
            bool isInt = int.TryParse(txtSoLuong.Text.Trim().ToString(), out intSoLuong);
            float dgNhap;
            bool isFloatNhap = float.TryParse(txtGiaNhap.Text.Trim().ToString(), out dgNhap);
            float dgBan;
            bool isFloatBan = float.TryParse(txtGiaBan.Text.Trim().ToString(), out dgBan);
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mời nhập tên hàng","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }
            else if (!isInt || int.Parse(txtSoLuong.Text) < 0)
            {
                MessageBox.Show("Mời nhập hoặc kiểm tra số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return;
            }
            else if (!isFloatNhap || float.Parse(txtGiaNhap.Text) < 0)
            {
                MessageBox.Show("Mời nhập hoặc kiểm tra giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaNhap.Focus();
                return;
            }
            else if (!isFloatBan || float.Parse(txtGiaBan.Text) < 0)
            {
                MessageBox.Show("Mời nhập hoặc kiểm tra giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaBan.Focus();
                return;
            }
            else if (txtHinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mời upload hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btMo.Focus();
                return;
            }
            else
            {
                DTO_Hang h = new DTO_Hang(txtTen.Text, int.Parse(txtSoLuong.Text), float.Parse(txtGiaNhap.Text),
                    float.Parse(txtGiaBan.Text), "\\Images\\" + fileName, txtGhiChu.Text, emailNV);
                if (busHang.InsertHang(h))
                {
                    MessageBox.Show("Thêm thành công");
                    File.Copy(fileAddress, fileSavePath, true);
                    ResetValues();
                    LoadGridView_Hang();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            
        }

        private void dgvHang_Click(object sender, EventArgs e)
        {
            string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            if (dgvHang.Rows.Count > 0)
            {
                btMo.Enabled = true;
                btLuu.Enabled = false;
                txtTen.Enabled = true;
                txtSoLuong.Enabled = true;
                txtGiaBan.Enabled = true;
                txtGiaNhap.Enabled = true;
                txtGhiChu.Enabled = true;
                txtTen.Focus();
                btXoa.Enabled = true;
                btSua.Enabled = true;
                txtMa.Text = dgvHang.CurrentRow.Cells["maHang"].Value.ToString();
                txtTen.Text = dgvHang.CurrentRow.Cells["tenHang"].Value.ToString();
                txtSoLuong.Text = dgvHang.CurrentRow.Cells["soLuong"].Value.ToString();
                txtGiaNhap.Text = dgvHang.CurrentRow.Cells["donGiaNhap"].Value.ToString();
                txtGiaBan.Text = dgvHang.CurrentRow.Cells["donGiaBan"].Value.ToString();
                txtHinh.Text = dgvHang.CurrentRow.Cells["hinhAnh"].Value.ToString();
                txtGhiChu.Text = dgvHang.CurrentRow.Cells["ghiChu"].Value.ToString();
                checkUrlImage = txtHinh.Text;
                pbHinh.Image = Image.FromFile(saveDirectory + dgvHang.CurrentRow.Cells["hinhAnh"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Không có giá trị");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            int intSoLuong;
            bool isInt = int.TryParse(txtSoLuong.Text.Trim().ToString(), out intSoLuong);
            float dgNhap;
            bool isFloatNhap = float.TryParse(txtGiaNhap.Text.Trim().ToString(), out dgNhap);
            float dgBan;
            bool isFloatBan = float.TryParse(txtGiaBan.Text.Trim().ToString(), out dgBan);
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mời nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }
            else if (!isInt || int.Parse(txtSoLuong.Text) < 0)
            {
                MessageBox.Show("Mời nhập hoặc kiểm tra số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return;
            }
            else if (!isFloatNhap || float.Parse(txtGiaNhap.Text) < 0)
            {
                MessageBox.Show("Mời nhập hoặc kiểm tra giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaNhap.Focus();
                return;
            }
            else if (!isFloatBan || float.Parse(txtGiaBan.Text) < 0)
            {
                MessageBox.Show("Mời nhập hoặc kiểm tra giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaBan.Focus();
                return;
            }
            else if (txtHinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mời upload hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btMo.Focus();
                return;
            }
            else
            {
                DTO_Hang h = new DTO_Hang(int.Parse(txtMa.Text), txtTen.Text, int.Parse(txtSoLuong.Text), float.Parse(txtGiaNhap.Text),
                    float.Parse(txtGiaBan.Text), txtHinh.Text, txtGhiChu.Text);
                if (MessageBox.Show("Bạn có chắc muốn sửa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
                {
                    if (busHang.UpdateHang(h))
                    {
                        if (txtHinh.Text != checkUrlImage)
                            File.Copy(fileAddress, fileSavePath, true);                   
                        MessageBox.Show("Sửa thành công");
                        ResetValues();
                        LoadGridView_Hang();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                else
                {
                    ResetValues();
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int maHang = int.Parse(txtMa.Text);
            if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busHang.DeleteHang(maHang))
                {
                    MessageBox.Show("Xóa thành công");
                    ResetValues();
                    LoadGridView_Hang();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            else
            {
                ResetValues();
            }
        }
    }
}
