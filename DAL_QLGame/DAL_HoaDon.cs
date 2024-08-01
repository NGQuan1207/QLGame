using DTO_QLGame;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLGame
{
    public class DAL_HoaDon : Connect
    {
        /* private bool Execute(string storedProcedureName, params SqlParameter[] parameters)
         {
             using (SqlCommand cmd = _conn.CreateCommand())
             {
                 _conn.Open();
                 cmd.CommandText = storedProcedureName;
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.AddRange(parameters);

                 bool result = cmd.ExecuteNonQuery() > 0;
                 _conn.Close();
                 return result;
             }
         }

         public DataTable TimHoaDon(string makh)
         {
             using (SqlConnection con = _conn)
             using (SqlCommand cmd = new SqlCommand("TimHoaDonTheoMaKhachHang", con))
             {
                 con.Open();
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.AddWithValue("@MaKH", makh);
                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 DataTable dt = new DataTable();
                 da.Fill(dt);
                 return dt;
             }
         }
         public bool XoaHoaDon(string mahoadon)
         {
             return Execute("XoaHD", new SqlParameter("@MaHD", mahoadon));
         }*/


        private bool Execute(string storedProcedureName, params SqlParameter[] parameters)
        {
            using (SqlCommand cmd = _conn.CreateCommand())
            {
                cmd.CommandText = storedProcedureName;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters);

                try
                {
                    _conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                finally
                {
                    _conn.Close();
                }
            }
        }

        public DataTable GetHoaDon()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "ListHoaDon",
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

        public DataTable TimHoaDon(string makh)
        {
            using (SqlCommand cmd = new SqlCommand("TimHoaDonTheoMaKhachHang", _conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaKH", makh);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool XoaHoaDon(string mahoadon)
        {
            return Execute("XoaHD", new SqlParameter("@MaHD", mahoadon));
        }

        public bool ThemHoaDon(DTO_HoaDon hd)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LOIBACH\\NVB;Initial Catalog=QL_ThietBiGame;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand cmd = new SqlCommand("ThemHoaDon", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaNV", hd.MaNV);
                cmd.Parameters.AddWithValue("@NgayLap", hd.NgayLap);
                cmd.Parameters.AddWithValue("@ThanhTien", hd.ThanhTien);

                // Adding the missing parameter @tenkh
                /* cmd.Parameters.AddWithValue("@tenkh", hd.TenKH); // Assuming hd has a property TenKH*/

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
