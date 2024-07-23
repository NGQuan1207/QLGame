using DAL_QLGame;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLGame;
using DAL_QLGame;

namespace BUS_QLGame
{

    public class BUS_ChiTietKH
    {
        public static object ListCTKhachHang()
        {
            return DAL_ChiTietKhachHang.ListCTKhachHang();
        }

        public static DataTable TimHoaDon(string makh)
        {
            return DAL_ChiTietKhachHang.TimHoaDon(makh);
        }
        public static DataTable TimKhachHang(string makh)
        {
            return DAL_ChiTietKhachHang.TimKhachHang(makh);
        }
       
    }
}
