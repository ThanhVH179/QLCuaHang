using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO_QLBanHang;

namespace DAL_QLBanHang
{
    public class DAL_Khach : DBConnect
    {
        public DataTable getKhach()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DanhSachKhach";
                DataTable dtKhach = new DataTable();
                dtKhach.Load(cmd.ExecuteReader());
                return dtKhach;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool insertKhach(DTO_Khach khach)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InsertDataIntoKHACHHANG";
                cmd.Parameters.AddWithValue("dienThoai", khach.SoDienThoai);
                cmd.Parameters.AddWithValue("tenKhach", khach.HoTen);
                cmd.Parameters.AddWithValue("diaChi", khach.DiaChi);
                cmd.Parameters.AddWithValue("phai", khach.Phai);
                cmd.Parameters.AddWithValue("email", khach.EmailNV);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool updateKhach(DTO_Khach khach)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UpdateDataIntoKHACHHANG";
                cmd.Parameters.AddWithValue("dienThoai", khach.SoDienThoai);
                cmd.Parameters.AddWithValue("tenKhach", khach.HoTen);
                cmd.Parameters.AddWithValue("diaChi", khach.DiaChi);
                cmd.Parameters.AddWithValue("phai", khach.Phai);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            } 
            return false;
        }
        public bool deleteKhach(string sdt)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DeleteDataFromKHACHHANG";
                cmd.Parameters.AddWithValue("dienThoai", sdt);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public DataTable searchKhach(string sdt)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_SearchKhach";
                cmd.Parameters.AddWithValue("dienThoai", sdt);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
