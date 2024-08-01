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

        // Default constructor
        public DTO_HoaDon() { }

        // Parameterized constructor
        public DTO_HoaDon(string mahd, string makh, string manv, DateTime ngaylap, decimal thanhtien, int trangthai)
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
