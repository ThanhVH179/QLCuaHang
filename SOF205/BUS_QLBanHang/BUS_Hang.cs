using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL_QLBanHang;
using DTO_QLBanHang;

namespace BUS_QLBanHang
{
    public class BUS_Hang
    {
        DAL_Hang dalHang = new DAL_Hang();
        public DataTable GetHang()
        {
            return dalHang.getHang();
        }
        public bool InsertHang(DTO_Hang hang)
        {
            return dalHang.insertHang(hang);
        }
        public bool UpdateHang(DTO_Hang hang)
        {
            return dalHang.updateHang(hang);
        }
        public bool DeleteHang(int maHang)
        {
            return dalHang.deleteHang(maHang);
        }
        public DataTable SearchHang(string ten)
        {
            return dalHang.searchHang(ten);
        }
        public DataTable ThongKeHang()
        {
            return dalHang.thongKeHang();
        }
        public DataTable ThongKeTonKho()
        {
            return dalHang.thongKeTonKho();
        }
    }
}
