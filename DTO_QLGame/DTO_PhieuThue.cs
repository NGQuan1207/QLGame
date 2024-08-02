using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLGame
{
    public class DTO_PhieuThue
    {
        public string maphieuthue;
        public string maspthue;
        public string makh;
        public string ngaydau;
        public string ngaytra;
        public int tiencoc;
        public int phitre;
        public int trangthai;


        public string MaPT
        {
            get => maphieuthue;
            set => maphieuthue = value;
        }
        public string MaSPThue
        {
            get => maspthue;
            set => maspthue = value;
        }
        public string MaKH
        {
            get => makh;
            set => makh = value;
        }
        public string NgayDau
        {
            get => ngaydau;
            set => ngaydau = value;
        }
        public string NgayTra
        {
            get => ngaytra;
            set => ngaytra = value;
        }
        public int TienCoc
        {
            get => tiencoc;
            set => tiencoc = value;
        }
        public int PhiTre
        {
            get => phitre;
            set => phitre = value;
        }
        public int TrangThai
        {
            get => trangthai;
            set => trangthai = value;
        }

        public DTO_PhieuThue() { }
        public DTO_PhieuThue(string mapt, string maspthue, string makh, string ngaydau, string ngaytra, int tiencoc, int phitre, int trangthai)
        {
            this.MaPT = mapt;
            this.MaSPThue = maspthue;
            this.MaKH = makh;
            this.NgayDau = ngaydau;
            this.NgayTra = ngaytra;
            this.TienCoc = tiencoc;
            this.PhiTre = phitre;
            this.TrangThai = trangthai;

        }
    }
}

