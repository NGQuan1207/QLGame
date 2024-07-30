using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLGame
{
    public class DTO_SanPhamThue
    {
        string maspt;
        string tenspt;
        string loaisp;
        string hinhanh;
        string ghichu;
        int trangthai;

        public string MaSPT
        {
            set { maspt = value; }
            get { return maspt; }
        }
        public string TenSPT
        {
            set { tenspt = value; }
            get { return tenspt; }
        }

        public string Loaisp
        {
            set { loaisp = value; }
            get { return loaisp; }
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
        public DTO_SanPhamThue() { }

        public DTO_SanPhamThue(string maspt, string tenspt, string loaisp/*, string hinhanh*/, string ghichu, int trangthai)
        {

            this.MaSPT = maspt;
            this.TenSPT = tenspt;
            this.Loaisp = loaisp;
            this.Hinhanh = hinhanh;
            this.GhiChu = ghichu;
            this.Trangthai = trangthai;
        }
        public DTO_SanPhamThue(string maspt, string tenspt, string loaisp/*, string hinhanh*/, string ghichu)
        {

            this.MaSPT = maspt;
            this.TenSPT = tenspt;
            this.Loaisp = loaisp;
            this.Hinhanh = hinhanh;
            this.GhiChu = ghichu;

        }
        public DTO_SanPhamThue(string tenspt, string loaisp/*, string hinhanh*/, string ghichu)
        {


            this.TenSPT = tenspt;
            this.Loaisp = loaisp;
            //this.Hinhanh = hinhanh;
            this.GhiChu = ghichu;

        }
    }
}
