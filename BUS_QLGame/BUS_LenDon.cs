using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLGame;
using DAL_QLGame;
using System.Data;

namespace BUS_QLGame
{
    public class BUS_LenDon
    {
        private DAL_LenDon dalld = new DAL_LenDon();

        public DataTable Getsanpham()
        {
            return dalld.Getsanpham();
        }
        public decimal GetTong()
        {
            return dalld.GetTong();
        }
    }
}