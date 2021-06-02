using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUI_QLBanHang
{
    public partial class FrmMain : Form
    {
        public static int session = 0;
        public static int profile = 0;
        public static string mail;
        FrmLogin dn;
        public FrmMain()
        {
            InitializeComponent();
        }

        void FrmLogin_Closed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
            labelTitle.Visible = true;
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            Resetvalue();
            if (profile == 1)
            {
                menuToolStripMenu.Text = null;
                profile = 0;
            }
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dn = new FrmLogin();
            if (!CheckExistForm("FrmLogin"))
            {
                dn.MdiParent = this;
                dn.Show();
                dn.FormClosed += new FormClosedEventHandler(FrmLogin_Closed);
                labelTitle.Visible = false;
            }
            else
            {
                ActiveChildForm("FrmLogin");
            }
        }

        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        void VaiTroNV()
        {
            nhanVienToolStripMenuItem.Visible = false;
            thongKeToolStripMenuItem.Visible = false;
        }
        private void Resetvalue()
        {
            if (session == 1)
            {
                thongTinNVStripMenuItem.Text = "Chào " + FrmMain.mail;
                nhanVienToolStripMenuItem.Visible = true;
                danhMucToolStripMenuItem.Visible = true;
                dangXuatToolStripMenuItem.Enabled = true;
                thongKeToolStripMenuItem.Visible = true;
                thongKeSanPhamToolStripMenuItem.Visible = true;
                hoSoNVToolStripMenuItem.Visible = true;
                dangNhapToolStripMenuItem.Enabled = false;
                if (int.Parse(dn.vaiTro) == 0)
                {
                    VaiTroNV();
                }
            }
            else
            {
                nhanVienToolStripMenuItem.Visible = false;
                danhMucToolStripMenuItem.Visible = false;
                dangXuatToolStripMenuItem.Enabled = false;
                thongKeToolStripMenuItem.Visible = false;
                thongKeSanPhamToolStripMenuItem.Visible = false;
                hoSoNVToolStripMenuItem.Visible = false;
                dangNhapToolStripMenuItem.Enabled = true;
            }
        }

        private void hoSoNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePW doiMK = new FrmChangePW(FrmMain.mail);
            if (!CheckExistForm("FrmChangePW"))
            {
                doiMK.MdiParent = this;
                doiMK.Show();
                doiMK.FormClosed += new FormClosedEventHandler(FrmChangePW_FormClosed);
                labelTitle.Visible = false;
            }
        }
        void FrmChangePW_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
            labelTitle.Visible = true;
        }
        void FrmNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
            labelTitle.Visible = true;
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (int.Parse(dn.tinhTrang) == 0)
            {
                MessageBox.Show("Tài khoản đang ngừng hoạt động. Không thể sử dụng chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmNhanVien nv = new FrmNhanVien();
                if (!CheckExistForm("FrmNhanVien"))
                {
                    nv.MdiParent = this;
                    nv.Show();
                    nv.FormClosed += new FormClosedEventHandler(FrmNhanVien_FormClosed);
                    labelTitle.Visible = false;
                }
                else
                {
                    ActiveChildForm("FrmNhanVien");
                }
            }   
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void FrmKhach_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
            labelTitle.Visible = true;
        }
        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (int.Parse(dn.tinhTrang) == 0)
            {
                MessageBox.Show("Tài khoản đang ngừng hoạt động. Không thể sử dụng chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmKhach fkhach = new FrmKhach();
                if (!CheckExistForm("FrmKhach"))
                {
                    fkhach.MdiParent = this;
                    fkhach.Show();
                    fkhach.FormClosed += new FormClosedEventHandler(FrmKhach_FormClosed);
                    labelTitle.Visible = false;
                }
                else
                {
                    ActiveChildForm("FrmKhach");
                }
            }            
        }
        void FrmSanPham_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
            labelTitle.Visible = true;
        }
        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (int.Parse(dn.tinhTrang) == 0)
            {
                MessageBox.Show("Tài khoản đang ngừng hoạt động. Không thể sử dụng chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmSanPham fSP = new FrmSanPham();
                if (!CheckExistForm("FrmSanPham"))
                {
                    fSP.MdiParent = this;
                    fSP.Show();
                    fSP.FormClosed += new FormClosedEventHandler(FrmSanPham_FormClosed);
                    labelTitle.Visible = false;
                }
                else
                {
                    ActiveChildForm("FrmSanPham");
                }
            }           
        }
        void FrmThongKe_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMain_Load(sender, e);
            labelTitle.Visible = true;
        }
        private void thongKeSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (int.Parse(dn.tinhTrang) == 0)
            {
                MessageBox.Show("Tài khoản đang ngừng hoạt động. Không thể sử dụng chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmThongKe fThongKe = new FrmThongKe();
                if (!CheckExistForm("FrmThongKe"))
                {
                    fThongKe.MdiParent = this;
                    fThongKe.Show();
                    fThongKe.FormClosed += new FormClosedEventHandler(FrmThongKe_FormClosed);
                    labelTitle.Visible = false;
                }
                else
                {
                    ActiveChildForm("FrmThongKe");
                }
            }           
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session = 0;
            thongTinNVStripMenuItem.Text = null;
            Resetvalue();
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void huongDanSuDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "HuongDan.pdf");
                System.Diagnostics.Process.Start(path);
            }
            catch (Exception)
            {
                MessageBox.Show("The file is not found");
            }
        }

        private void gioiThieuPhanMemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "ThongTin.pdf");
                System.Diagnostics.Process.Start(path);
            }
            catch (Exception)
            {
                MessageBox.Show("The file is not found");
            }
        }
    }
}
