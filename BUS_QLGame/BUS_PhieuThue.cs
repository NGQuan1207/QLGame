using DAL_QLGame;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLGame
{
    public class BUS_PhieuThue
    {
        public static DataTable TimPhieuthue(string maphieuthue)
        {
            DAL_PhieuThue dalphieuthue = new DAL_PhieuThue();
            return dalphieuthue.TimPhieuThue(maphieuthue);
        }

        public static bool XoaPhieuThue(string maphieuthue)
        {
            DAL_PhieuThue dalphieuthue = new DAL_PhieuThue();
            return dalphieuthue.XoaPhieuThue(maphieuthue);
        }
     
    }
}
