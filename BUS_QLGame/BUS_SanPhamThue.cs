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
    public class BUS_SanPhamThue
    {
        public static DataTable LoadListSanPham()
        {
            DAL_SanPhamThue dalSanPham = new DAL_SanPhamThue();
            return dalSanPham.LoadListSanPham();
        }

        public static DataTable TimSanPhamThue(string tim)
        {
            DAL_SanPhamThue dalSanPham = new DAL_SanPhamThue();
            return dalSanPham.TimSanPhamThue(tim);
        }

        public static bool ThemSanPhamThue(DTO_SanPhamThue sanphamthue)
        {
            DAL_SanPhamThue dalSanPham = new DAL_SanPhamThue();
            return dalSanPham.ThemSanPhamThue(sanphamthue);
        }

        public static bool XoaSanPhamThue(string masanpham)
        {
            DAL_SanPhamThue dalSanPham = new DAL_SanPhamThue();
            return dalSanPham.XoaSanPhamThue(masanpham);
        }

        public static bool SuaSanPhamThue(string maspt, string tenspt, string loaisp, string hinhanh, string ghichu)
        {
            DAL_SanPhamThue dalSanPham = new DAL_SanPhamThue();
            return dalSanPham.SuaSanPhamThue(maspt, tenspt, loaisp, hinhanh, ghichu);
        }
    }
}
