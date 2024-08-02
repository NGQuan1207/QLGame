using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BUS_QLGame;


namespace GUI_QLGame
{
    public partial class Frm_ThayDoiMatKhau : Form
    {
        Thread th;
        public static string mail;
        BUS_Nhanvien busnv = new BUS_Nhanvien();
        Frm_DangNhap DN = new Frm_DangNhap();

        public Frm_ThayDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            {
                if (txt_matkhaucu.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_matkhaucu.Focus();
                    return;
                }
                else if (txt_nhapmatkhaumoi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_nhapmatkhaumoi.Focus();
                    return;
                }
                else if (txt_nhaplaimatkhaumoi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_nhaplaimatkhaumoi.Focus();
                    return;
                }
                else
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn đổi mật khẩu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        string matkhaumoi = busnv.encryption(txt_nhapmatkhaumoi.Text);
                        string matkhaucu = busnv.encryption(txt_matkhaucu.Text);
                        if (busnv.UpdateMatKhau(txt_email.Text, matkhaucu, matkhaumoi))
                        {
                            Frm_Main.profile = 1;
                            Frm_Main.session = 0;
                            DN.SendMail(Frm_DangNhap.mail, txt_nhapmatkhaumoi.Text);
                            MessageBox.Show("Cập nhật mật khẩu thành công, bạn cần phải đăng nhập lại");
                            this.Close();
                            
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu cũ không đúng, Cập nhật mật khẩu không thành công");
                            txt_matkhaucu.Text = null;
                            txt_nhapmatkhaumoi.Text = null;
                            txt_nhaplaimatkhaumoi.Text = null;
                        }
                    }
                    else
                    {
                        txt_matkhaucu.Text = null;
                        txt_nhapmatkhaumoi.Text = null;
                        txt_nhaplaimatkhaumoi.Text = null;
                    }
                }
            }
        }
        
        private void Frm_ThayDoiMatKhau_Load(object sender, EventArgs e)
        {
           
        }
    }
}

