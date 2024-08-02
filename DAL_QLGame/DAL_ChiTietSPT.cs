using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLGame;

namespace DAL_QLGame
{
    public class DAL_ChiTietSPT : Connect
    {
        public DataTable GetChiTietSanPham()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "ListChiTietSPThue",
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
        public bool SuaChiTietSPT(string mactspt, string maspt, int soluong, int gia)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "SuaChiTietSPT",
                    Connection = _conn
                };

                cmd.Parameters.AddWithValue("@MaCTSPT", mactspt);
                cmd.Parameters.AddWithValue("@MaSPT", maspt);
                cmd.Parameters.AddWithValue("@SoLuong", soluong);
                cmd.Parameters.AddWithValue("@Gia", gia);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                return true;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
