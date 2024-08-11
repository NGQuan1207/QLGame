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
            protected SqlConnection _conn = new SqlConnection("Data Source=DUONGPX;Initial Catalog=QL_ThietBiGame1234;Integrated Security=True;Encrypt=False");
       
    }
}
