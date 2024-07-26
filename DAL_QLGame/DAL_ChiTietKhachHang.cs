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
    public class DAL_ChiTietKhachHang : Connect
    {
        public DataTable ListCTKhachHang()
        {
            using (SqlConnection con = new SqlConnection(_conn.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("ListHoaDon", con))
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable ListCt = new DataTable();
                ListCt.Load(cmd.ExecuteReader());
                return ListCt;
            }
        }

        public DataTable TimKhachHang(string makh)
        {
            using (SqlConnection con = new SqlConnection(_conn.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("TimKH", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaKH", makh);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dtKhachHang = new DataTable();
                adapter.Fill(dtKhachHang);
                return dtKhachHang;
            }
        }

        public DataTable TimHoaDon(string makh)
        {
            using (SqlConnection con = new SqlConnection(_conn.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("TimHoaDonTheoMaKH", con))
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

        public bool Execute(string storedProcedureName, params SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(_conn.ConnectionString))
            using (SqlCommand cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = storedProcedureName;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaHoaDon(string mahoadon)
        {
            return Execute("XoaHD", new SqlParameter("@MaHD", mahoadon));
        }
    }
}
