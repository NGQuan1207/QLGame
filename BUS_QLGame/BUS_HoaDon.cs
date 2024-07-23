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
            return DAL_ChiTietKhachHang.TimHoaDon(makh);
        }

        public static bool XoaHoaDon(string mahoadon)
        {
            return DAL_HoaDon.XoaHoaDon(mahoadon);
        }
    }
   
}
