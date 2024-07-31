using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLGame
{
    public class DTO_SanPham
    {
        string masp;
        string tensp;
        string loaisp;
        int soluong;
        int gia;
        string hinhanh;
        string ghichu;
        int trangthai;

        public string MaSP
        {
            set { masp = value; }
            get { return masp; }
        }
        public string TenSP
        {
            set { tensp = value; }
            get { return tensp; }
        }

        public string Loaisp
        {
            set { loaisp = value; }
            get { return loaisp; }
        }

        public int SoLuong
        {
            set { soluong = value; }
            get { return soluong; }
        }
        public int Gia
        {
            set { gia = value; }
            get { return gia; }
        }
        public string Hinhanh
        {
            set { hinhanh = value; }
            get { return hinhanh; }
        }
        public string GhiChu
        {
            set => ghichu = value;
            get { return ghichu; }
        }
        public int Trangthai
        {
            set { trangthai = value; }
            get { return trangthai; }
        }
        public DTO_SanPham() { }

        public DTO_SanPham(string masp, string tensp, string loaisp,int soluong,int gia, string hinhanh, string ghichu, int trangthai)
        {
           
             this.MaSP = masp;
            this.TenSP = tensp;
            this.Loaisp = loaisp;
            this.SoLuong=soluong;
            this.Gia = gia;
            this.Hinhanh = hinhanh;
            this.GhiChu = ghichu;
            this.Trangthai = trangthai;
        }
        public DTO_SanPham(string masp, string tensp, string loaisp, int soluong, int gia, string hinhanh, string ghichu)
        {

            this.MaSP = masp;
            this.TenSP = tensp;
            this.Loaisp = loaisp;
            this.SoLuong = soluong;
            this.Gia = gia;
            this.Hinhanh = hinhanh;
            this.GhiChu = ghichu;
       
        }
        public DTO_SanPham( string tensp, string loaisp, int soluong, int gia, string hinhanh, string ghichu)
        {

           
            this.TenSP = tensp;
            this.Loaisp = loaisp;
            this.SoLuong = soluong;
            this.Gia = gia;
            this.Hinhanh = hinhanh;
            this.GhiChu = ghichu;

        }
    }
}
