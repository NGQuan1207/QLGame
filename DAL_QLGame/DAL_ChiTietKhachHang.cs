using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLGame;
using System.Security.Policy;

namespace DAL_QLGame
{
    public class DAL_ChiTietKhachHang
    {
        public static DataTable ListCTKhachHang()
        {
            using (SqlConnection con = DataAccess.connect())
            using (SqlCommand cmd = new SqlCommand("ListChiTietKhachHang", con))
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable ListCt = new DataTable();
                ListCt.Load(cmd.ExecuteReader());
                return ListCt;
            }
        }
        public static DataTable TimHoaDon(string makh)
        {
            using (SqlConnection con = DataAccess.connect())
            using (SqlCommand cmd = new SqlCommand("TimHoaDonTheoMaKH", con))
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaKH", makh);
                /* DataTable TimKH = new DataTable();
                 TimKH.Load(cmd.ExecuteReader());
                 return TimKH;
             }*/
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public static DataTable TimKhachHang(string makh)
        {
            DataTable dtKhachHang = new DataTable();
            using (SqlConnection con = DataAccess.connect())
            using (SqlCommand cmd = new SqlCommand("TimKH", con))
            {
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dtKhachHang);
                }
            }
             return dtKhachHang;
        }
        public static bool Execute(string storedProcedureName, params SqlParameter[] parameters)
        {
            using (SqlConnection con = DataAccess.connect())
            using (SqlCommand cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = storedProcedureName;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            return false;
        }
        public static bool XoaHoaDon(string mahoadon)
        {
            return Execute("XoaBaohanh", new SqlParameter("@mabaohanh", mahoadon));
        }
    }
}
