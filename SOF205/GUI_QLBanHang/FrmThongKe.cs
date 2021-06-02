using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBanHang;

namespace GUI_QLBanHang
{
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
        }
        BUS_Hang busHang = new BUS_Hang();
        private void NhapKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGridView_ThongKeHang();
        }
        void LoadGridView_ThongKeHang()
        {
            dgvThongKeHang.DataSource = busHang.ThongKeHang();
            dgvThongKeHang.Columns[0].HeaderText = "Mã nhân viên";
            dgvThongKeHang.Columns[1].HeaderText = "Tên nhân viên";
            dgvThongKeHang.Columns[2].HeaderText = "Số lượng nhập";
        }
        void LoadGridView_ThongKeTonKho()
        {
            dgvThongKeHang.DataSource = busHang.ThongKeTonKho();
            dgvThongKeHang.Columns[0].HeaderText = "Tên hàng";
            dgvThongKeHang.Columns[1].HeaderText = "Số lượng";
        }

        private void TonKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGridView_ThongKeTonKho();
        }
    }
}
