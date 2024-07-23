namespace DTO_QLGame
{
    public class DTO_KhachHang
    {
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }

        public DTO_KhachHang(string maKH, string hoTen, string diaChi, string sDT)
        {
            MaKH = maKH;
            HoTen = hoTen;
            DiaChi = diaChi;
            SDT = sDT;
        }
    }
}
