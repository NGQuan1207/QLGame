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
            return DAL_BaoHanh.LoadListBaoHanh();
        }
        public static DataTable TimBaoHanh(string tim)
        {
            return DAL_BaoHanh.TimBaoHanh(tim);
        }

        public static bool ThemBaoHanh(DTO_BaoHanh baohanh)
        {
            return DAL_BaoHanh.ThemBaoHanh(baohanh);
        }
        public static bool XoaBaoHanh(string mabaohanh)
        {
            return DAL_BaoHanh.XoaBaoHanh(mabaohanh);
        }
    }
}
