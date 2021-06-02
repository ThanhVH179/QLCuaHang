using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_QLBanHang;

namespace DAL_QLBanHang
{
    public class DAL_Hang : DBConnect
    {
        public DataTable getHang()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DanhSachHANG";
                DataTable dtHang = new DataTable();
                dtHang.Load(cmd.ExecuteReader());
                return dtHang;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool insertHang(DTO_Hang hang)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InsertDataIntoHANG";
                cmd.Parameters.AddWithValue("tenHang", hang.TenHang);
                cmd.Parameters.AddWithValue("soLuong", hang.SoLuong);
                cmd.Parameters.AddWithValue("donGiaNhap", hang.DonGiaNhap);
                cmd.Parameters.AddWithValue("donGiaBan", hang.DonGiaBan);
                cmd.Parameters.AddWithValue("hinhAnh", hang.HinhAnh);
                cmd.Parameters.AddWithValue("ghiChu", hang.GhiChu);
                cmd.Parameters.AddWithValue("email", hang.EmailNV);
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
        public bool updateHang(DTO_Hang hang)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UpdateDataIntoHANG";
                cmd.Parameters.AddWithValue("maHang", hang.MaHang);
                cmd.Parameters.AddWithValue("tenHang", hang.TenHang);
                cmd.Parameters.AddWithValue("soLuong", hang.SoLuong);
                cmd.Parameters.AddWithValue("donGiaNhap", hang.DonGiaNhap);
                cmd.Parameters.AddWithValue("donGiaBan", hang.DonGiaBan);
                cmd.Parameters.AddWithValue("hinhAnh", hang.HinhAnh);
                cmd.Parameters.AddWithValue("ghiChu", hang.GhiChu);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
            }
            finally { conn.Close(); }
            return false;
        }
        public bool deleteHang(int maHang)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DeleteDataFromHANG";
                cmd.Parameters.AddWithValue("maHang", maHang);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
            }
            finally { conn.Close(); }
            return false;
        }
        public DataTable searchHang(string tenHang)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_SearchHANG";
                cmd.Parameters.AddWithValue("tenHang", tenHang);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable thongKeHang()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ThongKeSP";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable thongKeTonKho()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ThongKeTonKho";
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
