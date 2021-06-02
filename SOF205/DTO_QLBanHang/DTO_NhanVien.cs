using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBanHang
{
    public class DTO_NhanVien
    {
        private string tenNhanVien;
        private string diaChi;
        private int vaiTro;
        private int tinhTrang;
        private string emailNV;
        private string matKhau;

        public string TenNhanVien
        {
            get
            {
                return tenNhanVien;
            }
            set
            {
                tenNhanVien = value;
            }
        }
        public string DiaChi
        {
            get
            {
                return diaChi;
            }
            set
            {
                diaChi = value;
            }
        }
        public int VaiTro
        {
            get
            {
                return vaiTro;
            }
            set
            {
                vaiTro = value;
            }
        }
        public int TinhTrang
        {
            get
            {
                return tinhTrang;
            }
            set
            {
                tinhTrang = value;
            }
        }
        public string EmailNV
        {
            get
            {
                return emailNV;
            }
            set
            {
                emailNV = value;
            }
        }
        public string MatKhau
        {
            get
            {
                return matKhau;
            }
            set
            {
                matKhau = value;
            }
        }

        public DTO_NhanVien(string email, string ten, string diaChi, string matKhau, int vaiTro, int tinhTrang)
        {
            this.emailNV = email;
            this.tenNhanVien = ten;
            this.diaChi = diaChi;
            this.matKhau = matKhau;
            this.vaiTro = vaiTro;
            this.tinhTrang = tinhTrang;
        }
        public DTO_NhanVien(string email, string ten, string diaChi, int vaiTro, int tinhTrang)
        {
            this.emailNV = email;
            this.tenNhanVien = ten;
            this.diaChi = diaChi;
            this.vaiTro = vaiTro;
            this.tinhTrang = tinhTrang;
        }
        public DTO_NhanVien() { }
    }
}
