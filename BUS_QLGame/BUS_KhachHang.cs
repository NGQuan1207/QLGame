using System;
using System.Collections.Generic;
using System.Data;
using DAL_QLGame;
using DTO_QLGame;

namespace BUS_QLGame
{
    public class BUS_KhachHang
    {
        private DAL_KhachHang dalKH = new DAL_KhachHang();

        public DataTable GetKhach()
        {
            return dalKH.GetKhachHang();
        }

        public bool InsertKhach(DTO_KhachHang khach)
        {
            return dalKH.InsertKhachHang(khach);
        }

        public bool UpdateKhach(string makh, string tenkh, string diachi, string sdt)
        {
            return dalKH.UpdateKhachHang(makh, tenkh, diachi, sdt);
        }

        public bool DeleteKhach(string makh)
        {
            return dalKH.DeleteKhachHang(makh);
        }

        public DataTable TimKhachHang(string soDT)
        {
            return dalKH.TimKhachHang(soDT);
        }


    }
}
