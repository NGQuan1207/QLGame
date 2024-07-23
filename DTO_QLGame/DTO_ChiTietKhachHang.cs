using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLGame
{
    public class DTO_ChiTietKH
    {
        public string mactkh;
        public string makhachhang;
        public string tenkh;
        public string diachi;
        public string dienthoai;
        public string mahd;
        public string maphieuthue;

        public string MaCTKH
        {
            get => mactkh;
            set => mactkh = value;
        }
        public string MaKH
        {
            get => makhachhang;
            set => makhachhang = value;
        }
        public string TenKH
        {
            get => tenkh;
            set => tenkh = value;
        }
        public string DiaChi
        {
            get => diachi;
            set => diachi = value;
        }
        public string SDT
        {
            get => dienthoai;
            set => dienthoai = value;
        }
        public string MaHD
        {
            get => mahd;
            set => mahd = value;
        }
        public string MaPhieuThue
        {
            get => maphieuthue;
            set => maphieuthue = value;
        }

        public DTO_ChiTietKH() { }
        public DTO_ChiTietKH(string mactkh, string makhachhang, string tenkh, string diachi, string dienthoai, string mahd, string maphieuthue)
        {
            this.MaCTKH = mactkh;
            this.MaKH = makhachhang;
            this.TenKH = tenkh;
            this.DiaChi = diachi;
            this.SDT = dienthoai;
            this.MaHD = mahd;
            this.MaPhieuThue = maphieuthue;

        }
    }
}
