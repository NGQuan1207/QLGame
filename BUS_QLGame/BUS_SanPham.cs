using DAL_QLGame;
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
    public class BUS_SanPham 

    {
        public static DataTable LoadListSanPham()
        {
            DAL_SanPham dalSanPham = new DAL_SanPham();
            return dalSanPham.LoadListSanPham();
        }

        public static DataTable TimSanPham(string tim)
        {
            DAL_SanPham dalSanPham = new DAL_SanPham();
            return dalSanPham.TimSanPham(tim);
        }

        public static bool ThemSanPham(DTO_SanPham sanpham)
        {
            DAL_SanPham dalSanPham = new DAL_SanPham();
            return dalSanPham.ThemSanPham(sanpham);
        }

        public static bool XoaSanPham(string masanpham)
        {
            DAL_SanPham dalSanPham = new DAL_SanPham();
            return dalSanPham.XoaSanPham(masanpham);
        }

        public static bool SuaSanPham(string masp, string tensp, string loaisp, int soluong, int gia, string hinhanh, string ghichu)
        {
            DAL_SanPham dalSanPham = new DAL_SanPham();
            return dalSanPham.SuaSanPham(masp,tensp, loaisp,soluong,gia, hinhanh, ghichu);
        }
        public static DataTable ListSPThue()
        {
            DAL_SanPham dalSanPhamT = new DAL_SanPham();
            return dalSanPhamT.ListSPThue();
        }
        public static DataTable TimSanPhamThue(string maSPThue)
        {
            return new DAL_SanPham().TimSanPhamThue(maSPThue);
        }
        public DataTable TinhTongSP(DateTime startDate, DateTime endDate)
        {
            DAL_SanPham dALSanPhamT = new DAL_SanPham();
            return dALSanPhamT.TinhTongSP(startDate, endDate);
        }
    }
}
