using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLGame
{
    public class KHConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=LAPTOP-PDIC30NO\MISASME2019;Initial Catalog=QL_ThietBiGame;Integrated Security=True;Encrypt=False");
    }
}
