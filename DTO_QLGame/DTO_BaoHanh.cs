using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLGame
{
    public class DTO_BaoHanh
    {
        public string mabaohanh;
        public string masp;
        public string makh;
        public string startdate;
        public string enddate;
        public string tinhtrang;
        public int trangthai;

        public string MaBaoHanh
        {
            get => mabaohanh;
            set => mabaohanh = value;
        }

        public string MaSP
        {
            get => masp;
            set => masp = value;
        }
        public string MaKH
        {
            get => makh;
            set => makh = value;
        }
        public string Startdate
        {
            get => startdate;
            set => startdate = value;
        }

        public string Enddate
        {
            get => enddate;
            set => enddate = value;
        }
        public string TinhTrang
        {
            get => tinhtrang;
            set => tinhtrang = value;
        }
        public int TrangThai
        {
            get =>trangthai;
            set => trangthai = value;
        }
        public DTO_BaoHanh() { }
        public DTO_BaoHanh(string mabaohanh, string masp, string makh, string startdate, string enddate, string tinhtrang, int trangthai) 
        {
            this.MaBaoHanh = mabaohanh;
            this.MaSP = masp;
            this.MaKH= makh;
            this.Startdate = startdate;
            this.Enddate = enddate;
            this.TinhTrang = tinhtrang;
            this.TrangThai = trangthai;
        }
        public DTO_BaoHanh(string mabaohanh, string masp, string makh, string startdate, string enddate, string tinhtrang)
        {
            this.MaBaoHanh = mabaohanh;
            this.MaSP = masp;
            this.MaKH = makh;
            this.Startdate = startdate;
            this.Enddate = enddate;
            this.TinhTrang = tinhtrang;
          
        }
        public DTO_BaoHanh( string masp, string makh, string startdate, string enddate, string tinhtrang)
        {
           
            this.MaSP = masp;
            this.MaKH = makh;
            this.Startdate = startdate;
            this.Enddate = enddate;
            this.TinhTrang = tinhtrang;

        }
    }
}
