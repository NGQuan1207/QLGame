using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLGame
{
    public class DTO_ChiTietSanPham
    {
        public string _maSP;
        public string _tenSP;
        public int _soluong;
        public float _gia;

        public DTO_ChiTietSanPham(string maSP, string tenSP, int soluong, float gia)
        {
            _maSP = maSP;
            _tenSP = tenSP;
            _soluong = soluong;
            _gia = gia;
        }
    }
}
