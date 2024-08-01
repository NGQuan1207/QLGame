namespace DTO_QLGame
{
    public class DTO_KhachHang
    {
        public string makhachhang;
        public string tenkhachhang;
        public string diachi;
        public string sdt;

        public string MaKH
        {
            get => makhachhang;
            set => makhachhang = value;
        }
        public string TenKH
        {
            get => tenkhachhang;
            set => tenkhachhang = value;
        }
        public string DiaChi
        {
            get => diachi;
            set => diachi = value;
        }
        public string SDT
        {
            get => sdt;
            set => sdt = value;
        }

        public DTO_KhachHang() { }

        public DTO_KhachHang(string makh, string tenkh, string diachi, string sdt)
        {
            this.MaKH = makh;
            this.TenKH = tenkh;
            this.DiaChi = diachi;
            this.SDT = sdt;
        }
    }
}
