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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        public bool isValid(string mail)
        {
            try
            {
                var email = new MailAddress(mail);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public void ResetValues()
        {
            txtTimKiem.Text = "Nhập tên nhân viên...";
            txtEmail.Text = null;
            txtDiaChi.Text = null;
            txtTen.Text = null;
            txtEmail.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTen.Enabled = false;
            rdbNV.Enabled = false;
            rdbQT.Enabled = false;
            rdbHD.Enabled = false;
            rdbNHD.Enabled = false;
            btThem.Enabled = true;
            btXoa.Enabled = false;
            btSua.Enabled = false;
            btLuu.Enabled = false;

        }
        public void SendMail(string email)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
                NetworkCredential cred = new NetworkCredential("thanhhoangvo179@gmail.com", "thanhhjhj113");
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("thanhhoangvo179@gmail.com");
                msg.To.Add(email);
                msg.Subject = "Bạn đã tạo tài khoản thành công";
                msg.Body = "Chào anh/chị. Mật khẩu là : thanh123. Anh/Chị vui lòng đăng nhập vào phần mềm và đổi mật khẩu";
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(msg);
                MessageBox.Show("Một email đã được gửi tới bạn");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void GridViewLoad_NhanVien()
        {
            dgvNhanVien.DataSource = busNhanVien.GetNhanVien();
            dgvNhanVien.Columns[0].HeaderText = "Email";
            dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns[2].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[3].HeaderText = "Vai trò";
            dgvNhanVien.Columns[4].HeaderText = "Tình trạng";
        }
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            ResetValues();
            GridViewLoad_NhanVien();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            txtEmail.Text = null;
            txtDiaChi.Text = null;
            txtTen.Text = null;
            txtEmail.Enabled = true;
            txtDiaChi.Enabled = true;
            txtTen.Enabled = true;
            rdbNV.Enabled = true;
            rdbQT.Enabled = true;
            rdbHD.Enabled = true;
            rdbNHD.Enabled = true;
            btLuu.Enabled = true;
            btXoa.Enabled = false;
            btSua.Enabled = false;
            txtEmail.Focus();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            int role = 0;
            if (rdbQT.Checked)
            {
                role = 1;
            }
            int tinhTrang = 0;
            if (rdbHD.Checked)
            {
                tinhTrang = 1;
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mời nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            else if (!isValid(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mời nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            else if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mời nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            if (rdbNV.Checked == false && rdbQT.Checked == false)
            {
                MessageBox.Show("Mời chọn vai trò", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            else if (rdbHD.Checked == false && rdbNHD.Checked == false)
            {
                MessageBox.Show("Mời chọn tình trạng nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            else
            {
                DTO_NhanVien nv = new DTO_NhanVien(txtEmail.Text, txtTen.Text, txtDiaChi.Text, role, tinhTrang);
                if (busNhanVien.InsertNhanVien(nv))
                {
                    MessageBox.Show("Thêm thành công");
                    ResetValues();
                    GridViewLoad_NhanVien();
                    SendMail(nv.EmailNV);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.Rows.Count > 0)
            {
                btLuu.Enabled = false;
                txtEmail.Enabled = false;
                txtDiaChi.Enabled = true;
                txtTen.Enabled = true;
                rdbNV.Enabled = true;
                rdbQT.Enabled = true;
                rdbHD.Enabled = true;
                rdbNHD.Enabled = true;
                btSua.Enabled = true;
                btXoa.Enabled = true;
                //show data
                txtEmail.Text = dgvNhanVien.CurrentRow.Cells["email"].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells["diaChi"].Value.ToString();
                txtTen.Text = dgvNhanVien.CurrentRow.Cells["tenNV"].Value.ToString();
                if (int.Parse(dgvNhanVien.CurrentRow.Cells["vaiTro"].Value.ToString()) == 1)
                {
                    rdbQT.Checked = true;
                }
                else
                {
                    rdbNV.Checked = true;
                }
                if (int.Parse(dgvNhanVien.CurrentRow.Cells["tinhTrang"].Value.ToString()) == 1)
                {
                    rdbHD.Checked = true;
                }
                else
                {
                    rdbNHD.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mời nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                int role = 0;
                if (rdbQT.Checked)
                    role = 1;

                int tinhTrang = 0;
                if (rdbHD.Checked)
                    tinhTrang = 1;

                DTO_NhanVien nv = new DTO_NhanVien(txtEmail.Text, txtTen.Text, txtDiaChi.Text, role, tinhTrang);
                if (MessageBox.Show("Bạn có chắc muốn sửa ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busNhanVien.UpdateNhanVien(nv))
                    {
                        MessageBox.Show("Sửa thành công!");
                        ResetValues();
                        GridViewLoad_NhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công!");
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
            string email = txtEmail.Text;
            if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busNhanVien.DeleteNhanVien(email))
                {
                    MessageBox.Show("Xóa thành công!");
                    ResetValues();
                    GridViewLoad_NhanVien();
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
            string tenNV = txtTimKiem.Text;
            DataTable ds = busNhanVien.SearchNhanVien(tenNV);
            if (ds.Rows.Count > 0)
            {
                dgvNhanVien.DataSource = ds;
                dgvNhanVien.Columns[0].HeaderText = "Email";
                dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
                dgvNhanVien.Columns[2].HeaderText = "Địa chỉ";
                dgvNhanVien.Columns[3].HeaderText = "Vai trò";
                dgvNhanVien.Columns[4].HeaderText = "Tình trạng";
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            GridViewLoad_NhanVien();
        }

        private void btBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            GridViewLoad_NhanVien();
        }
    }
}
