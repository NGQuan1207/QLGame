using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLGame;
using DTO_QLGame;

namespace GUI_QLGame
{
    public partial class frm_chu : Form
    {
        BUS_Nhanvien busNV = new BUS_Nhanvien();
        public static string mail;
        public frm_chu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        private void ResetValue()
        {
            LoadEmployeeData();
        }
        private void frm_chu_Load(object sender, EventArgs e)
        {
            ResetValue();
        }
        private void LoadEmployeeData()
        {

            try
            {
                txt_MaNV.Text = busNV.GetNhanVienByEmail(Frm_DangNhap.mail).Rows[0][0].ToString();
                txt_TenNV.Text = busNV.GetNhanVienByEmail(Frm_DangNhap.mail).Rows[0][1].ToString();
                txt_gender.Text = busNV.GetNhanVienByEmail(Frm_DangNhap.mail).Rows[0][2].ToString();
                txt_ngaysinh.Text = busNV.GetNhanVienByEmail(Frm_DangNhap.mail).Rows[0][3].ToString();
                txt_CCCDnv.Text = busNV.GetNhanVienByEmail(Frm_DangNhap.mail).Rows[0][4].ToString();
                txt_sdtNV.Text = busNV.GetNhanVienByEmail(Frm_DangNhap.mail).Rows[0][5].ToString();
                txt_diachiNV.Text = busNV.GetNhanVienByEmail(Frm_DangNhap.mail).Rows[0][6].ToString();
                txt_ChuavuNV.Text = busNV.GetNhanVienByEmail(Frm_DangNhap.mail).Rows[0][7].ToString();

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định: " + ex.Message);
            }
        }
    }
}
