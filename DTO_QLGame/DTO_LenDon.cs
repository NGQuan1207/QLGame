using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLGame
{
    public class DTO_LenDon
    {
        public DTO_LenDon(string maKH, string hoTen, string diaChi, string sDT, string loaiDon, string ngay, string ngayKetThuc, string maNV, string tongTien, string giamGia, string thanhToan, string maGiamGia)
        {
            MaKH = maKH;
            HoTen = hoTen;
            DiaChi = diaChi;
            SDT = sDT;
            this.loaiDon = loaiDon;
            this.ngay = ngay;
            this.ngayKetThuc = ngayKetThuc;
            this.maNV = maNV;
            this.tongTien = tongTien;
            this.giamGia = giamGia;
            this.thanhToan = thanhToan;
            this.maGiamGia = maGiamGia;
        }

        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string loaiDon { get; set; }
        public string ngay { get; set; }
        public string ngayKetThuc { get; set; }
        public string maNV { get; set; }
        public string tongTien { get; set; }

        public string giamGia { get; set; }
        public string thanhToan { get; set; }
        public string maGiamGia { get; set; }
    }
}
