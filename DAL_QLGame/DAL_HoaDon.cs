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
        private bool Execute(string storedProcedureName, params SqlParameter[] parameters)
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
        }
    }
}
