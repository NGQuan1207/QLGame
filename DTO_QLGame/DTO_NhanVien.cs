using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLGame
{
    public class DTO_NhanVien
    {
        private string MaNV;
        private string TenNV;
        private string Phai;
        private string NgaySinh;
        private string Email;
        private string CCCD;
        private string SDT;
        private string DiaChi;
        private string ChucVu;
        private string MatKhau;
        private int TrangThai;

        public string Manv
        {
            get { return MaNV; }
            set { value = MaNV; }
        }

        public string Tennv
        {
            get {return TenNV; }
            set { value = TenNV; }
        }

        public string phai
        {
            get { return Phai; }
            set {  Phai = value; }
        }

        public string ngaysinh
        {
            get { return NgaySinh; }
            set {  NgaySinh = value; }
        }

        public string email
        {
            get { return Email; }
            set { Email = value; }
        }

        public string cccd
        {

            get {return CCCD; }
            set {cccd = value; }
        }

        public string sdt
        {
            get { return SDT; }
            set { sdt = value; }
        }

        public string diachi
        {
            get { return DiaChi; }
            set { diachi = value; }
        }

        public string chucvu
        {
            get { return ChucVu; }
            set { chucvu = value; }
        }

        public string matkhau
        {
            get { return MatKhau; }
            set { matkhau = value; }
        }

        public int trangthai
        {
            get { return TrangThai; }
            set { trangthai = value; }
        }

        public DTO_NhanVien (string manv
            ,string tenNV, string phai, string ngaySinh, string email, 
            string cCCD, string sDT, string diaChi, string chucVu)
        {
            this.MaNV = manv;
            this.TenNV = tenNV;
            this.Phai = phai;
            this.NgaySinh = ngaySinh;
            this.Email = email;
            this.CCCD = cCCD;
            this.SDT = sDT;
            this.DiaChi = diaChi;
            this.ChucVu = chucVu;
            //this.TrangThai = trangThai;
        }

        public DTO_NhanVien() { }
    }
}
