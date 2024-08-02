using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLGame
{
    public class DTO_ChiTietSPThue
    {
        public class DTO_ChiTietSanPhamThue
        {
            public string _maCTSPT;
            public string _maSPT;
            public int _soluong;
            public float _gia;

            public DTO_ChiTietSanPhamThue(string maCTSPT, string maSPT, int soluong, float gia)
            {
                _maCTSPT = maCTSPT;
                _maSPT = maSPT;
                _soluong = soluong;
                _gia = gia;
            }
        }
    }
}
