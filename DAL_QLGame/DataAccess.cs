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
            SqlConnection con = new SqlConnection(@"Data Source=LOIBACH\NVB;Initial Catalog=QL_ThietBiGame;Integrated Security=True;Encrypt=False");
            return con;
        }
    }
}
