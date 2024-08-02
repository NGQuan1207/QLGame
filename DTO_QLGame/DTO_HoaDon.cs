using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLGame
{
    public class DTO_HoaDon
    {
        // Private fields
        private string mahoaddon;
        private string makhachhang;
        private string manhanvien;
        private DateTime ngaylap;
        private decimal thanhtien;
        private int trangthai;
        private string tenSanPham;
        private int soLuong;
        private decimal tongTien; // New field for total amount

        // Public properties
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

        public DateTime NgayLap
        {
            get => ngaylap;
            set => ngaylap = value;
        }

        public decimal ThanhTien
        {
            get => thanhtien;
            set => thanhtien = value;
        }

        public int TrangThai
        {
            get => trangthai;
            set => trangthai = value;
        }

        public string TenKH { get; set; }

        public string TenSanPham
        {
            get => tenSanPham;
            set => tenSanPham = value;
        }

        public int SoLuong
        {
            get => soLuong;
            set => soLuong = value;
        }

        public string SDT { get; set; }
        public string DiaChi { get; set; }

        public decimal TongTien // New property for total amount
        {
            get => tongTien;
            set => tongTien = value;
        }

        // Default constructor
        public DTO_HoaDon() { }

        // Parameterized constructor
        public DTO_HoaDon(string mahd, string makh, string manv, DateTime ngaylap, decimal thanhtien, int trangthai)
        {
            MaHD = mahd;
            MaKH = makh;
            MaNV = manv;
            NgayLap = ngaylap;
            ThanhTien = thanhtien;
            TrangThai = trangthai;
        }

        public DTO_HoaDon(string tenSanPham, int soLuong)
        {
            TenSanPham = tenSanPham;
            SoLuong = soLuong;
        }
    }
}
