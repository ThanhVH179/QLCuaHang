using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL_QLBanHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLBanHang;

namespace DAL_QLBanHang.Tests
{
    [TestClass()]
    public class DAL_NhanVienTests : DBConnect
    {
        [TestMethod()]
        public void NhanVienDangNhap001()
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien dal = new DAL_NhanVien();
            nv.EmailNV = "";
            nv.MatKhau = "abcd";
            bool result = dal.NhanVienDangNhap(nv);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void ThemNhanVienThanhCong()
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien dal = new DAL_NhanVien();
            nv.EmailNV = "b@b.b";
            nv.TenNhanVien = "b";
            nv.VaiTro = 1;
            nv.TinhTrang = 1;
            nv.DiaChi = "hcm";
            bool result = dal.insertNhanVien(nv);
            Assert.IsTrue(result);
        }
    }
}