using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLGame
{
    public class DTO_HoaDon
    {

        public string mahoaddon;
        public string makhachhang;
        public string manhanvien;
        public string ngaylap;
        public int thanhtien;
        public int trangthai;


        public string MaHD
        {
            get => mahoaddon;
            set => mahoaddon = value;
        }
        public string MaKH
        {
            get => makhachhang;
            set => makhachhang = value;
        }
        public string MaNV
        {
            get => manhanvien;
            set => manhanvien = value;
        }
        public string NgayLap
        {
            get => ngaylap;
            set => ngaylap = value;
        }
        public int ThanhTien
        {
            get => thanhtien;
            set => thanhtien = value;
        }
        public int TrangThai
        {
            get => trangthai;
            set => trangthai = value;
        }

        public DTO_HoaDon() { }
        public DTO_HoaDon(string mahd, string makh, string manv, string ngaylap, int thanhtien, int trangthai)
        {
            this.MaHD = mahd;
            this.MaKH = makh;
            this.MaNV = manv;
            this.NgayLap = ngaylap;
            this.ThanhTien = thanhtien;
            this.TrangThai = trangthai;

        }
    }
}
