using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using BUS_QLBanHang;
using DTO_QLBanHang;

namespace GUI_QLBanHang
{
    public partial class FrmKhach : Form
    {
        public FrmKhach()
        {
            InitializeComponent();
        }
        BUS_Khach buskhach = new BUS_Khach();
        string emailNV = FrmMain.mail;
        private void FrmKhach_Load(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridView_Khach();
        }
        void LoadGridView_Khach()
        {
            dgvKhachHang.DataSource = buskhach.GetKhach();
            dgvKhachHang.Columns[0].HeaderText = "Điện thoại";
            dgvKhachHang.Columns[1].HeaderText = "Họ và tên";
            dgvKhachHang.Columns[2].HeaderText = " Địa chỉ";
            dgvKhachHang.Columns[3].HeaderText = "Giới tính";
            dgvKhachHang.Columns[4].Visible = false;
        } 
        public void ResetValues()
        {
            txtTimKiem.Text = "Nhập số điện thoại khách hàng...";
            txtSDT.Text = null;
            txtDiaChi.Text = null;
            txtTen.Text = null;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTen.Enabled = false;          
            rdbNam.Enabled = false;
            rdbNu.Enabled = false;
            btThem.Enabled = true;
            btXoa.Enabled = false;
            btSua.Enabled = false;
            btLuu.Enabled = false;

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            txtSDT.Text = null;
            txtDiaChi.Text = null;
            txtTen.Text = null;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            txtTen.Enabled = true;            
            rdbNam.Enabled = true;
            rdbNu.Enabled = true;
            btLuu.Enabled = true;
            btXoa.Enabled = false;
            btSua.Enabled = false;
            txtSDT.Focus();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            float intDienThoai;
            bool isInt = float.TryParse(txtSDT.Text.Trim().ToString(), out intDienThoai);
            string phai = "Nam";
            if (rdbNu.Checked)
                phai = "Nữ";
            if (!isInt || float.Parse(txtSDT.Text) < 0)
            {
                MessageBox.Show("Mời bạn kiểm tra lại số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }
            else if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mời nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            else if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mời nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            else if (rdbNam.Checked == false && rdbNu.Checked == false)
            {
                MessageBox.Show("Mời chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            else
            {
                DTO_Khach kh = new DTO_Khach(txtSDT.Text, txtTen.Text, txtDiaChi.Text, phai, emailNV);
                if (buskhach.InsertKhach(kh))
                {
                    MessageBox.Show("Thêm thành công");
                    ResetValues();
                    LoadGridView_Khach();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mời nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            else if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mời nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }            
            else
            {
                string phai = "Nam";
                if (rdbNu.Checked)
                    phai = "Nữ";
                DTO_Khach kh = new DTO_Khach(txtSDT.Text, txtTen.Text, txtDiaChi.Text, phai);
                if (MessageBox.Show("Bạn có chắc muốn sửa ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (buskhach.UpdateKhach(kh))
                    {
                        MessageBox.Show("Sửa thành công");
                        ResetValues();
                        LoadGridView_Khach();
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
            string soDT = txtSDT.Text;
            if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (buskhach.DeleteKhach(soDT))
                {
                    MessageBox.Show("Xóa thành công");
                    ResetValues();
                    LoadGridView_Khach();
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

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = null;
            txtTimKiem.BackColor = Color.White;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string soDT = txtTimKiem.Text;
            DataTable ds = buskhach.SearchKhach(soDT);
            if (ds.Rows.Count > 0)
            {
                dgvKhachHang.DataSource = ds;
                dgvKhachHang.Columns[0].HeaderText = "Điện thoại";
                dgvKhachHang.Columns[1].HeaderText = "Họ và tên";
                dgvKhachHang.Columns[2].HeaderText = "Địa chỉ";
                dgvKhachHang.Columns[3].HeaderText = "Phái";
                dgvKhachHang.Columns[4].Visible = false;
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtTimKiem.Text = "Mời nhập";
            txtTimKiem.BackColor = Color.LightGray;
            ResetValues();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDanhSach_Click(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridView_Khach();
        }

        private void btBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridView_Khach();
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.Rows.Count > 0)
            {
                btLuu.Enabled = false;
                txtSDT.Enabled = false;
                txtDiaChi.Enabled = true;
                txtTen.Enabled = true;
                rdbNam.Enabled = true;
                rdbNu.Enabled = true;
                btSua.Enabled = true;
                btXoa.Enabled = true;
                //show data
                txtSDT.Text = dgvKhachHang.CurrentRow.Cells["dienThoai"].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells["diaChi"].Value.ToString();
                txtTen.Text = dgvKhachHang.CurrentRow.Cells["tenKhach"].Value.ToString();
                if (dgvKhachHang.CurrentRow.Cells["phai"].Value.ToString().ToLower() == "nam")
                {
                    rdbNam.Checked = true;
                }
                else
                {
                    rdbNu.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
