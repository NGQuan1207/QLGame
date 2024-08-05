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
    public partial class Frm_DangNhap_GU : Form
    {
        public Frm_DangNhap_GU()
        {
            InitializeComponent();
        }

        private void Frm_DangNhap_GU_Load(object sender, EventArgs e)
        {
            guna2Panel1.BackColor = Color.FromArgb(150,0,0,0);


            btn_quenmatkhau.FillColor = Color.FromArgb(170, 0, 0, 0);
            btn_dangnhap.FillColor = Color.FromArgb(170, 0, 0, 0);
            txt_ID.BackColor = Color.FromArgb(200, 0, 0, 0);
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
