using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLGame
{
    public class DTO_ChiTietKhachHang
    {
        public string makhachhang;
        public string tenkh;
        public string diachi;
        public string dienthoai;
        public string macthd;
        public string maphieuthue;
        public int trangthai;

        public string MaKH {
            get => makhachhang;
            set => makhachhang = value;
        }
        public string TenKH {  
            get => tenkh;
            set => tenkh = value;
        }
        public string DiaChi { 
            get => diachi;
            set => diachi = value;
        }
        public string SDT {  
            get => dienthoai;
            set => dienthoai = value;
        }
        public string MaCTHD { 
            get => macthd;
            set => macthd = value; 
        }
        public string MaPhieuThue {
            get => maphieuthue;
            set => maphieuthue = value;
        }
        public int TrangThai { 
            get => trangthai;
            set => trangthai = value;
        }
        public DTO_ChiTietKhachHang() { }
        public DTO_ChiTietKhachHang(string makhachhang, string tenkh, string diachi, string dienthoai, string macthd, string maphieuthue, int trangthai)
        {
            this.MaKH = makhachhang;
            this.TenKH = tenkh;
            this.DiaChi = diachi;
            this.SDT = dienthoai;
            this.MaCTHD = macthd;
            this.MaPhieuThue = maphieuthue;
            this.TrangThai = trangthai;
        }
    }
}
