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
        /* public static DataTable TimHoaDon(string makh)
         {
             DAL_HoaDon dalhoadon = new DAL_HoaDon();
             return dalhoadon.TimHoaDon(makh);
         }

         public static bool XoaHoaDon(string mahoadon)
         {
             DAL_HoaDon dalhoadon = new DAL_HoaDon();
             return dalhoadon.XoaHoaDon(mahoadon);
         }*/

        public DataTable GetHoaDon()
        {
            DAL_HoaDon dalhoadon = new DAL_HoaDon();
            return dalhoadon.GetHoaDon();
        }

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

        public bool ThemHoaDon(DTO_HoaDon hd)
        {
            DAL_HoaDon dalhoadon = new DAL_HoaDon();
            return dalhoadon.ThemHoaDon(hd);
        }
        public static DataTable SearchHoaDon(string manv)
        {
            DAL_HoaDon dalhoadon = new DAL_HoaDon();
            return dalhoadon.SearchHoaDon(manv);
        }

        public static object ListHoaDon(DateTime startDate, DateTime endDate)
        {
            DAL_HoaDon dALHoaDon = new DAL_HoaDon();
            return dALHoaDon.ListHoaDon();
        }
        public static object ListHoaDon()
        {
            DAL_HoaDon dALHoaDon = new DAL_HoaDon();
            return dALHoaDon.ListHoaDon();
        }
        private DAL_HoaDon dalHoaDon = new DAL_HoaDon();

        public DataTable TinhTongThuNhap(DateTime startDate, DateTime endDate)
        {
            return dalHoaDon.TinhTongThanhTien(startDate, endDate);
        }
    }
   
}
