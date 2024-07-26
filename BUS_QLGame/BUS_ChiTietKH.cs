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
            DAL_ChiTietKhachHang chitietkh = new DAL_ChiTietKhachHang();
            return chitietkh.ListCTKhachHang();
        }

        public static DataTable TimHoaDon(string makh)
        {
            DAL_ChiTietKhachHang chitietkh = new DAL_ChiTietKhachHang();
            return chitietkh.TimHoaDon(makh);
        }
        public static DataTable TimKhachHang(string makh)
        {
            DAL_ChiTietKhachHang chitietkh = new DAL_ChiTietKhachHang();
            return chitietkh.TimKhachHang(makh);
        }

    }
}
