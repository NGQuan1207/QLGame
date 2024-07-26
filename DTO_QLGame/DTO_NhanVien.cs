using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLGame
{
    public class DTO_NhanVien
    {
        private string MaNV
        private string TenNV;
        private string Phai;
        private DateTime NgaySinh;
        private string Email;
        private string CCCD;
        private string SDT;
        private string DiaChi;
        private string ChucVu;
        private string MatKhau;
        private int TrangThai;

        public string Manv
        {
            get; set;
        }

        public string Tennv
        {
            get; set;
        }

        public string phai
        {
            get; set;
        }

        public DateTime ngaysinh
        {
            get; set;
        }

        public string email
        {
            get; set;
        }

        public string cccd
        {

            get; set;
        }

        public string sdt
        {
            get; set;
        }

        public string diachi
        {
            get; set;
        }

        public string chucvu
        {
            get; set;
        }

        public string matkhau
        {
            get; set;
        }

        public int trangthai
        {
            get; set;
        }

        public DTO_NhanVien (string tenNV, string phai, DateTime ngaySinh, string email, 
            string cCCD, string sDT, string diaChi, string chucVu, string matKhau, int trangThai)
        {
            this.TenNV = tenNV;
            this.Phai = phai;
            this.NgaySinh = ngaySinh;
            this.Email = email;
            this.CCCD = cCCD;
            this.SDT = sDT;
            this.DiaChi = diaChi;
            this.ChucVu = chucVu;
            this.MatKhau = matKhau;
            this.TrangThai = trangThai;
        }

        public DTO_NhanVien() { }
    }
}
