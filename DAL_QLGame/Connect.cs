using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLGame;

namespace DAL_QLGame
{
    public class Connect
    {
            protected SqlConnection _conn = new SqlConnection("Data Source=LAPTOP-ADNOPDCB\\SQLEXPRESS;Initial Catalog=QL_ThietBiGame;" +
            "Integrated Security=True;");
    }
}
