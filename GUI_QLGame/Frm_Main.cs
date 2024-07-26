using BUS_QLGame;
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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        Frm_DangNhap dn;
        frm_QuanLyNhanVien nv;
        frm_DanhSachKH kh;
        frm_ChiTietKH ctkh;
        Frm_BaoCaoThongKe bctk;
        Frm_BaoHanh bh;
        Frm_HoaDon hd;
        Frm_LenDon ld;
        Frm_SanPham sp;
        Frm_SanPhamThue spt;
        frm_chu c;

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
            quảnLýNhânViênToolStripMenuItem.Visible = false;
            thốngKêToolStripMenuItem.Visible = false;
        }

        private void ResetValue()
        {
            if (session == 1)
            {
                quảnLýNhânViênToolStripMenuItem.Visible = true;
                danhMụcToolStripMenuItem.Visible = true;
                đăngXuấtToolStripMenuItem.Enabled = true;
                thốngKêToolStripMenuItem.Visible = true;
                báoCáoToolStripMenuItem.Visible = true;
                đăngNhậpToolStripMenuItem.Enabled = false;
                grb_form.Visible = true;
                
                //if (int.Parse(dn.vaitro) == 0)
                //{
                //    VaiTroNv();
                //}
                

            }
            else
            {
                quảnLýNhânViênToolStripMenuItem.Visible = false;
                danhMụcToolStripMenuItem.Visible = false;
                đăngXuấtToolStripMenuItem.Enabled = false;
                thốngKêToolStripMenuItem.Visible = false;
                báoCáoToolStripMenuItem.Visible = false;
                đăngNhậpToolStripMenuItem.Enabled = true;
                grb_form.Visible = false;
                
            }
        }
        private void Frm_DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            Frm_Main_Load(sender, e);
        }
        private void chiTiếtKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_DanhSachKH"))
            {
                kh = new frm_DanhSachKH();
                //kh.MdiParent = this;
                kh.Show();
                kh.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("frm_DanhSachKH");
            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            ResetValue();
            if (profile == 1) // Nếu vừa cập nhật mật khẩu thì 
                              // phải login lại, mục 'thông tin nhân viên ẩn'
            {
                //thôngTinToolStripMenuItem.Text = null;
                profile = 0;
            }
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dn = new Frm_DangNhap();
            if (!CheckExistForm("Frm_DangNhap"))
            {
                //dn.MdiParent = this;
                dn.Show();
                dn.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
                session = 1;
                ResetValue();
            }
            else
            {
                ActiveChildForm("Frm_DangNhap");
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session = 0;
            ResetValue();
        }

        private void chiTiếtKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_ChiTietKH"))
            {
                ctkh = new frm_ChiTietKH();
                //ctkh.MdiParent = this;
                ctkh.Show();
                ctkh.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("frm_ChiTietKH");
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_QuanLyNhanVien"))
            {
                nv = new frm_QuanLyNhanVien();
                //nv.MdiParent = this;
                nv.Show();
                nv.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("frm_QuanLyNhanVien");
            }
        }

        private void sảnPhẩmThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_SanPhamThue"))
            {
                spt = new Frm_SanPhamThue();
                //spt.MdiParent = this;
                spt.Show();
                spt.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("Frm_SanPhamThue");
            }
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_HoaDon"))
            {
                hd = new Frm_HoaDon();
                //hd.MdiParent = this;
                hd.Show();
                hd.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("Frm_HoaDon");
            }
        }

        private void lênĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_LenDon"))
            {
                ld = new Frm_LenDon();
                //ld.MdiParent = this;
                ld.Show();
                ld.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("Frm_LenDon");
            }
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_BaoCaoThongKe"))
            {
                bctk = new Frm_BaoCaoThongKe();
                //bctk.MdiParent = this;
                bctk.Show();
                bctk.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("Frm_BaoCaoThongKe");
            }
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_SanPham"))
            {
                sp = new Frm_SanPham();
                //sp.MdiParent = this;
                sp.Show();
                sp.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("Frm_SanPham");
            }
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_DSkhachhang_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_DanhSachKH"))
            {
                kh = new frm_DanhSachKH();
                //kh.MdiParent = this;
                kh.Show();
                kh.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("frm_DanhSachKH");
            }
        }

        private void btn_QLnhanvien_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_QuanLyNhanVien"))
            {
                nv = new frm_QuanLyNhanVien();
                //nv.MdiParent = this;
                nv.Show();
                nv.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("frm_QuanLyNhanVien");
            }
        }

        private void btn_Hoadon_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_HoaDon"))
            {
                hd = new Frm_HoaDon();
                //hd.MdiParent = this;
                hd.Show();
                hd.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("Frm_HoaDon");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_BaoHanh"))
            {
                bh = new Frm_BaoHanh();
                //bh.MdiParent = this;
                bh.Show();
                bh.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("Frm_BaoHanh");
            }
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_SanPham"))
            {
                sp = new Frm_SanPham();
                //sp.MdiParent = this;
                sp.Show();
                sp.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("Frm_SanPham");
            }
        }

        private void btn_SanPhamchothue_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_SanPhamThue"))
            {
                spt = new Frm_SanPhamThue();
                //spt.MdiParent = this;
                spt.Show();
                spt.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("Frm_SanPhamThue");
            }
        }

        private void btn_BaocaoThongKe_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_BaoCaoThongKe"))
            {
                bctk = new Frm_BaoCaoThongKe();
                //bctk.MdiParent = this;
                bctk.Show();
                bctk.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("Frm_BaoCaoThongKe");
            }
        }

        private void btn_LenDon_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_LenDon"))
            {
                ld = new Frm_LenDon();
                //ld.MdiParent = this;
                ld.Show();
                ld.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("Frm_LenDon");
            }
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_chu"))
            {
                c = new frm_chu();
                //c.MdiParent = this;
                c.Show();
                c.FormClosed += new FormClosedEventHandler(Frm_DangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("frm_chu");
            }
        }
    }
    
}
