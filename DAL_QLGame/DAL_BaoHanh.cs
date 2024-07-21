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
    public class DAL_BaoHanh
    {


        public static DataTable LoadListBaoHanh()
        {
            using (SqlConnection con = DataAccess.connect())
            using (SqlCommand cmd = new SqlCommand("DanhSachBaoHanh", con))
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable ListKH = new DataTable();
                ListKH.Load(cmd.ExecuteReader());
                return ListKH;
            }
        }

        public static DataTable TimBaoHanh(string tim)
        {
            using (SqlConnection con = DataAccess.connect())
            using (SqlCommand cmd = new SqlCommand("TimKiemBaoHanh", con))
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kiem", tim);
                DataTable TimNV = new DataTable();
                TimNV.Load(cmd.ExecuteReader());
                con.Close();
                return TimNV;
            }
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
        public static bool ThemBaoHanh(DTO_BaoHanh baohanh)
        {
            SqlParameter[] parameters =
            {
               
                new SqlParameter("@MaSP", baohanh.MaSP),
                new SqlParameter("@MaKH", baohanh.MaKH),
                new SqlParameter("@startdate", baohanh.Startdate),
                new SqlParameter("@enddate", baohanh.Enddate),
                 new SqlParameter("@TinhTrang", baohanh.TinhTrang)
            };
            return Execute("ThemBaoHanh", parameters);
        }

        public static bool XoaBaoHanh(string mabaohanh)
        {
            return Execute("XoaBaohanh", new SqlParameter("@mabaohanh", mabaohanh));
        }
    }
}
