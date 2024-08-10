using BUS_QLGame;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLGame
{
    public partial class Frm_Main_GU : Form
    {
        public Frm_Main_GU()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        Frm_DangNhap_GU dn;
        frm_QuanLyNhanVien_GU nv;
        frm_DanhSachKH_GU kh;
        
        Frm_BaoCaoThongKe_GU bctk;
        Frm_BaoHanh_GU bh;
        Frm_HoaDon_GU hd;
        Frm_LenDon_GU ld;
        Frm_SanPham_GU sp;
        Frm_SanPhamThue_GU spt;
        frm_chu c;
        Frm_ThayDoiMatKhau_GU tdmk;


        BUS_Nhanvien busNV = new BUS_Nhanvien();

        public static int session = 0;
        public static int profile = 0;
        public static string mail;

        // CheckExistForm để kiẻm tra xem 1 form với tên nào đó đã hiển thị trong 
        // Form Cha (Login) chưa? => Trả về True (đã hiển thị) hoặc False (nếu chưa hiển thị)
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        // ActiveChildForm dùng để kích hoạt hiện thị lên trên 
        // cùng các trong số các form con nếu nó đã hiện mà ko phải tạo thể hiện mới
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        private void VaiTroNv()
        {
            hToolStripMenuItem.Visible = false;
            btn_QLnhanvien.Visible = true;
        }
        private void vaitroql()
        {
            hToolStripMenuItem.Visible = false;
            btn_QLnhanvien.Visible=false;
        }

        private void ResetValue()
        {
            if (session == 1)
            {
                guna2Panel1.Visible = true;
                đổiMậtKhẩuToolStripMenuItem.Enabled = true;
                if (int.Parse(dn.vaitro) == 0)
                {
                    VaiTroNv();
                }
            }
            else
            {
              //  đăngNhậpToolStripMenuItem.Enabled = true;
                guna2Panel1.Visible = false;
                đổiMậtKhẩuToolStripMenuItem.Enabled = false;

            }
        }
        private void Frm_DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            Frm_Main_GU_Load(sender, e);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
          /*  guna2Panel1.BackColor = Color.FromArgb(150, 0, 0, 0);*/

        }

        private void dwadwaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btn_DSkhachhang_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_DanhSachKH_GU"))
            {
                kh = new frm_DanhSachKH_GU();
                //kh.MdiParent = this;
                kh.ShowDialog();
                kh.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("frm_DanhSachKH_GU");
            }
        }

        private void Frm_Main_GU_Load(object sender, EventArgs e)
        {

            guna2Panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
            pb_logo.BackColor = Color.FromArgb(150, 0, 0, 0);



            ResetValue();
            if (profile == 1) // Nếu vừa cập nhật mật khẩu thì 
            {
                profile = 0;
            }
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dn = new Frm_DangNhap_GU();
            if (!CheckExistForm("Frm_DangNhap_GU"))
            {
                //dn.MdiParent = this;
                dn.ShowDialog();
                dn.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
                session = 1;
                ResetValue();
            }
            else
            {
                ActiveChildForm("Frm_DangNhap_GU");
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session = 0;
            ResetValue();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_chu"))
            {
                c = new frm_chu();
                //c.MdiParent = this;
                c.ShowDialog();
                c.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("frm_chu");
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_ThayDoiMatKhau_GU"))
            {
                tdmk = new Frm_ThayDoiMatKhau_GU();
                //c.MdiParent = this;
                tdmk.ShowDialog();
                tdmk.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("frm_chu_GU");
            }
        }

        private void btn_QLnhanvien_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_QuanLyNhanVien_GU"))
            {
                nv = new frm_QuanLyNhanVien_GU();
                //nv.MdiParent = this;
                nv.ShowDialog();
                nv.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("frm_QuanLyNhanVien_GU");
            }
        }

        private void btn_Hoadon_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_HoaDon_GU"))
            {
                hd = new Frm_HoaDon_GU();
                //hd.MdiParent = this;
                hd.ShowDialog();
                hd.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("Frm_HoaDon_GU");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_BaoHanh_GU"))
            {
                bh = new Frm_BaoHanh_GU();
                //bh.MdiParent = this;
                bh.ShowDialog();
                bh.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("Frm_BaoHanh_GU");
            }
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_SanPham_GU"))
            {
                sp = new Frm_SanPham_GU();
                //sp.MdiParent = this;
                sp.ShowDialog();
                sp.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("Frm_SanPham_GU");
            }
        }

        private void btn_BaocaoThongKe_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_BaoCaoThongKe_GU"))
            {
                bctk = new Frm_BaoCaoThongKe_GU();
                //bctk.MdiParent = this;
                bctk.ShowDialog();
                bctk.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("Frm_BaoCaoThongKe_GU");
            }
        }

        private void btn_SanPhamchothue_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_SanPhamThue_GU"))
            {
                spt = new Frm_SanPhamThue_GU();
                //spt.MdiParent = this;
                spt.ShowDialog();
                spt.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("Frm_SanPhamThue_GU");
            }
        }

        private void btn_LenDon_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_LenDon_GU"))
            {
                ld = new Frm_LenDon_GU();
                //ld.MdiParent = this;
                ld.ShowDialog();
                ld.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("Frm_LenDon_GU");
            }
        }

        private void pb_logo_Click(object sender, EventArgs e)
        {

        }
    }
}
