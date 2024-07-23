using DTO_QLGame;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLGame
{
    public class DAL_KhachHang : KHConnect
    {
        public DataTable GetKhachHang()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "ListKhachHang",
                    Connection = _conn
                };
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool InsertKhachHang(DTO_KhachHang khach)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "InsertKhachHang",
                    Connection = _conn
                };
                cmd.Parameters.AddWithValue("@TenKH", khach.HoTen);
                cmd.Parameters.AddWithValue("@DiaChi", khach.DiaChi);
                cmd.Parameters.AddWithValue("@SDT", khach.SDT);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool UpdateKhachHang(string makh, string tenkh, string diachi, string sdt)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "UpdateKhachHang",
                    Connection = _conn
                };
                cmd.Parameters.AddWithValue("@MaKH", makh);
                cmd.Parameters.AddWithValue("@TenKH", tenkh);
                cmd.Parameters.AddWithValue("@DiaChi", diachi);
                cmd.Parameters.AddWithValue("@SDT", sdt);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool DeleteKhachHang(string makh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "DeleteKhachHang",
                    Connection = _conn
                };
                cmd.Parameters.AddWithValue("@MaKH", makh);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable TimKhachHang(string soDT)
        {
            // using store procedure
            try
            {
                // Ket noi
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "timkhachhang";
                cmd.Parameters.AddWithValue("SDT", soDT);
                cmd.Connection = _conn;
                DataTable dtKhach = new DataTable();
                dtKhach.Load(cmd.ExecuteReader());
                return dtKhach;
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
        }


    }
}
