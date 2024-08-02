using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLGame;
using DTO_QLGame;



namespace BUS_QLGame
{
    public class BUS_BaoHanh
    {
        public static DataTable LoadListBaoHanh()
        {
            DAL_BaoHanh dalBaoHanh = new DAL_BaoHanh();
            return dalBaoHanh.LoadListBaoHanh();
        }

        public static DataTable TimBaoHanh(string tim)
        {
            DAL_BaoHanh dalBaoHanh = new DAL_BaoHanh();
            return dalBaoHanh.TimBaoHanh(tim);
        }

        public static bool ThemBaoHanh(DTO_BaoHanh baohanh)
        {
            DAL_BaoHanh dalBaoHanh = new DAL_BaoHanh();
            return dalBaoHanh.ThemBaoHanh(baohanh);
        }

        public static bool XoaBaoHanh(string mabaohanh)
        {
            DAL_BaoHanh dalBaoHanh = new DAL_BaoHanh();
            return dalBaoHanh.XoaBaoHanh(mabaohanh);
        }
        public static bool SuaBaoHanh(string mabaohanh, string masp, string makh, string startdate, string enddate, string tinhtrang)
        {
            DAL_BaoHanh dalbaohanh = new DAL_BaoHanh();
            return dalbaohanh.SuaBaoHanh(mabaohanh, masp, makh, startdate, enddate, tinhtrang);
        }
    }
}
