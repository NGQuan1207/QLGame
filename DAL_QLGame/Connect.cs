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
            protected SqlConnection _conn = new SqlConnection("Data Source=LOIBACH\\NVB;Initial Catalog=QL_ThietBiGame;" +
            "Integrated Security=True;Encrypt=False");
        //Data Source=ADMIN-PC\MAYAO;Initial Catalog=QL_ThietBiGame3;
    }
}
