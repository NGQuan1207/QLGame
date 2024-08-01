using DTO_QLGame;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLGame
{
    public class DAL_KhachHang : Connect
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
                cmd.Parameters.AddWithValue("@TenKH", khach.TenKH);
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
        public class DataProvider
        {
            private static DataProvider instance;
            private readonly string connectionString;

            // Private constructor to prevent instantiation from outside
            private DataProvider()
            {
                connectionString = "Data Source=DUONGPX;Initial Catalog=QL_ThietBiGame123;Integrated Security=True;Encrypt=False";
            }

            // Public property to access the single instance
            public static DataProvider Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new DataProvider();
                    }
                    return instance;
                }
            }

            // Method to execute a scalar query
            public object ExecuteScalar(string query, SqlParameter[] parameters = null)
            {
                object result = null;

                // Using statement ensures proper disposal of SqlConnection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Using statement ensures proper disposal of SqlCommand
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters if any
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        // Execute the query and get the result
                        result = command.ExecuteScalar();
                    }
                }

                return result;
            }
        }

        public bool IsPhoneNumberUnique(string sdt)
        {
            string query = "SELECT COUNT(*) FROM KhachHang WHERE SDT = @SDT";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@SDT", SqlDbType.VarChar) { Value = sdt }
            };
            object result = DataProvider.Instance.ExecuteScalar(query, parameters);
            int count = result != null ? Convert.ToInt32(result) : 0;

            return count == 0;
        }





    }
}