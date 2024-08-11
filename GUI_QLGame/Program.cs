using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLGame
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*Application.Run(new Frm_SanPham());*/
            /*Application.Run(new frm_QuanLyNhanVien_GU());*/
            Application.Run(new Frm_LenDon_GU());
            //Application.Run(new Frm_SanPhamThue_GU());
            /*Application.Run(new Frm_ChiTietSanPhamThue());*/
            //Application.Run(new Frm_DangNhap_GU());



        }
    }
}
