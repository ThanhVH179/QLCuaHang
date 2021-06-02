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
    public class BUS_Khach
    {
        DAL_Khach dalKhach = new DAL_Khach();
        public DataTable GetKhach()
        {
            return dalKhach.getKhach();
        }
        public bool InsertKhach(DTO_Khach khach)
        {
            return dalKhach.insertKhach(khach);
        }
        public bool UpdateKhach(DTO_Khach khach)
        {
            return dalKhach.updateKhach(khach);
        }
        public bool DeleteKhach(string sdt)
        {
            return dalKhach.deleteKhach(sdt);
        }
        public DataTable SearchKhach(string sdt)
        {
            return dalKhach.searchKhach(sdt);
        }
    }
}
