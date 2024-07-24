using DAL_QLGame;
using DTO_QLGame;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLGame
{
    public class BUS_HoaDon
    {
        public static DataTable TimHoaDon(string makh)
        {
            DAL_HoaDon dalhoadon = new DAL_HoaDon();
            return dalhoadon.TimHoaDon(makh);
        }

        public static bool XoaHoaDon(string mahoadon)
        {
            DAL_HoaDon dalhoadon = new DAL_HoaDon();
            return dalhoadon.XoaHoaDon(mahoadon);
        }
    }
   
}
