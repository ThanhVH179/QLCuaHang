using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBanHang
{
    public class DTO_Hang
    {
        public int maHang;
        public string tenHang;
        public int soLuong;
        public float donGiaNhap;
        public float donGiaBan;
        public string hinhAnh;
        public string ghiChu;
        public string maNV;
        public string emailNV;

        public int MaHang
        {
            get
            {
                return maHang;
            }
            set
            {
                maHang = value;
            }
        }
        public string TenHang
        {
            get
            {
                return tenHang;
            }
            set
            {
                tenHang = value;
            }
        } public int SoLuong
        {
            get
            {
                return soLuong;
            }
            set
            {
                soLuong = value;
            }
        }
        public float DonGiaNhap
        {
            get
            {
                return donGiaNhap;
            }
            set
            {
                donGiaNhap = value;
            }
        }
        public float DonGiaBan
        {
            get
            {
                return donGiaBan;
            }
            set
            {
                donGiaBan = value;
            }
        }
        public string HinhAnh
        {
            get
            {
                return hinhAnh;
            }
            set
            {
                hinhAnh = value;
            }
        }
        public string GhiChu
        {
            get
            {
                return ghiChu;
            }
            set
            {
                ghiChu = value;
            }
        }
        public string MaNV
        {
            get
            {
                return maNV;
            }
            set
            {
                maNV = value;
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
        public DTO_Hang(int maHang, string tenHang, int soLuong, float donGiaNhap, float donGiaBan, string hinhAnh, string ghiChu)
        {
            this.maHang = maHang;
            this.tenHang = tenHang;
            this.soLuong = soLuong;
            this.donGiaNhap = donGiaNhap;
            this.donGiaBan = donGiaBan;
            this.hinhAnh = hinhAnh;
            this.ghiChu = ghiChu;
        }
        public DTO_Hang(string tenHang, int soLuong, float donGiaNhap, float donGiaBan, string hinhAnh, string ghiChu, string emailNV)
        {
            this.tenHang = tenHang;
            this.soLuong = soLuong;
            this.donGiaNhap = donGiaNhap;
            this.donGiaBan = donGiaBan;
            this.hinhAnh = hinhAnh;
            this.ghiChu = ghiChu;
            this.emailNV = emailNV;
        }
    }
}
