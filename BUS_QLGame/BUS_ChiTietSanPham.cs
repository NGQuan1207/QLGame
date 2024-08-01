using DAL_QLGame;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLGame
{
    public class BUS_ChiTietSanPham
    {
        DAL_ChiTietSanPham dalCTSP = new DAL_ChiTietSanPham();
        public DataTable GetChiTietSanPham()
        {
            return dalCTSP.GetChiTietSanPham();
        }
    }
}
