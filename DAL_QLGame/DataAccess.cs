using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLGame
{
    internal class DataAccess
    {
        public static SqlConnection connect()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-PDIC30NO\MISASME2019;Initial Catalog=QL_ThietBiGame3;Integrated Security=True;Encrypt=False");
            return con;
        }
    }
}
