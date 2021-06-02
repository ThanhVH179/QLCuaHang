using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBanHang
{
    public class DTO_Khach
    {
        public string soDienThoai;
        public string hoTen;
        public string diaChi;
        public string phai;
        public string emailNV;
        public string maNV;

        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }
            set
            {
                soDienThoai = value;
            }
        }
        public string HoTen
        {
            get
            {
                return hoTen;
            }
            set
            {
                hoTen = value;
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
        public string Phai
        {
            get
            {
                return phai;
            }
            set
            {
                phai = value;
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
        public DTO_Khach(string dienThoai, string ten, string diaChi, string phai, string email = null)
        {
            this.soDienThoai = dienThoai;
            this.hoTen = ten;
            this.diaChi = diaChi;
            this.phai = phai;
            this.emailNV = email;
        }
    }
}
