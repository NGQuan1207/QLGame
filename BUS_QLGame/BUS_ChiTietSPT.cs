using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLGame;

namespace BUS_QLGame
{
    
    public class BUS_ChiTietSPT
    {
        DAL_ChiTietSPT dal_ChiTietSPT = new DAL_ChiTietSPT();

        public DataTable GetChiTietSanPham()
        {
            return dal_ChiTietSPT.GetChiTietSanPham();
        }
        public static bool SuaChiTietSPT(string mactspt, string maspt, int soluong, int gia)
        {
            DAL_ChiTietSPT dalSanPham = new DAL_ChiTietSPT();
            return dalSanPham.SuaChiTietSPT(mactspt, maspt, soluong, gia);
        }
    }
}
