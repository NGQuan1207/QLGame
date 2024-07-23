using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLGame
{
    public class DAL_HoaDon
    {
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
            return Execute("XoaHD", new SqlParameter("@MaHD", mahoadon));
        }
    }
}
