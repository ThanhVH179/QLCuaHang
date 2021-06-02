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

namespace GUI_QLBanHang
{
    public partial class FrmChangePW : Form
    {
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        string strmail;

        public FrmChangePW(string mail)
        {
            InitializeComponent();
            strmail = mail;
            txtEmail.Text = strmail;
            txtEmail.Enabled = false;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SendMail(string email, string matkhau)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                NetworkCredential cred = new NetworkCredential("thanhhoangvo179@gmail.com", "thanhhjhj113");
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("thanhhoangvo179@gmail.com");
                msg.To.Add(email);
                msg.Subject = "Bạn đã sử dụng tính năng đổi mật khẩu";
                msg.Body = "Chào anh/chị. Mật khẩu mới là : " + matkhau;
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(msg);
                MessageBox.Show("Một email đổi mật khẩu đã được gửi tới bạn");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void btChangePW_Click(object sender, EventArgs e)
        {
            if (txtMKCu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mời nhập mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKCu.Focus();
                return;
            }
            else if (txtMKMoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mời nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKMoi.Focus();
                return;
            }
            else if (txtNhapLaiMK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mời nhập lại mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhapLaiMK.Focus();
                return;
            }
            else if (txtNhapLaiMK.Text.Trim() != txtMKMoi.Text.Trim())
            {
                MessageBox.Show("Nhập lại chưa đúng. Mời nhập lại mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhapLaiMK.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc muốn đổi mật khẩu ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string matkhaumoi = busNhanVien.encryption(txtMKMoi.Text);
                    string matkhaucu = busNhanVien.encryption(txtMKCu.Text);
                    if (busNhanVien.UpdateMatKhau(txtEmail.Text, matkhaucu, matkhaumoi))
                    {
                        FrmMain.profile = 1;
                        FrmMain.session = 0;
                        SendMail(strmail, txtMKMoi.Text);
                        MessageBox.Show("Đổi mật khẩu thành công. Bạn cần phải đăng nhập lại");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng. Đổi mật khẩu không thành công");
                        txtMKCu.Text = null;
                        txtMKMoi.Text = null;
                        txtNhapLaiMK.Text = null;
                    }
                }
                else
                {
                    txtMKCu.Text = null;
                    txtMKMoi.Text = null;
                    txtNhapLaiMK.Text = null;
                }
            }
        }
    }
}
