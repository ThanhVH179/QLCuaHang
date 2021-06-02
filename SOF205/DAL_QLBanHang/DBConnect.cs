using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL_QLBanHang
{
    public class DBConnect
    {
        //protected SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLBanHang;Integrated Security=True");
        static string connstr = ConfigurationManager.ConnectionStrings["QLBH"].ToString();
        protected SqlConnection conn = new SqlConnection(connstr);
    } 
}
