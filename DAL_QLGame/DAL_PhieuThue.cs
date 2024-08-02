using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLGame
{
    public class DAL_PhieuThue : Connect
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
        public DataTable TimPhieuThue(string maphieuthue)
        {
            using (SqlConnection con = _conn)
            using (SqlCommand cmd = new SqlCommand("TimPhieuThueTheoMaKhachHang", con))
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaKH", maphieuthue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public bool XoaPhieuThue(string maphieuthue)
        {
            return Execute("XoaPhieuThue", new SqlParameter("@MaPhieuThue", maphieuthue));
        }
    }
}
