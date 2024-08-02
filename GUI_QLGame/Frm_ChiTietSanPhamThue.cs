using BUS_QLGame;
using DTO_QLGame;
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
    public partial class Frm_ChiTietSanPhamThue : Form
    {
        private string MaCTSPT, MaSPT, SoLuong, Gia;
        private string selectedMaCTSPT; // Biến lưu mã khách hàng đã chọn
        DTO_ChiTietSPThue ctspt = new DTO_ChiTietSPThue();
        BUS_ChiTietSPT chitietspt = new BUS_ChiTietSPT();
        public Frm_ChiTietSanPhamThue()
        {
            InitializeComponent();
            dtgv_chitietsanphamthue.CellDoubleClick += dtgv_chitietsanphamthue_CellDoubleClic;
        }
        public Frm_ChiTietSanPhamThue(string maCTSPT, string maSPT, string soLuong, string gia)
        {
            InitializeComponent();
            this.MaCTSPT = maCTSPT;
            this.MaSPT = maSPT;
            this.SoLuong = soLuong;
            this.Gia = gia;
        }

        private void dtgv_chitietsanphamthue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_chitietsanphamthue.Rows[e.RowIndex];
                selectedMaCTSPT = row.Cells[0].Value.ToString();
                txt_mactspt.Text = row.Cells[0].Value.ToString();
                txt_maspt.Text = row.Cells[1].Value.ToString();
                txt_soluong.Text = row.Cells[2].Value.ToString();
                txt_gia.Text = row.Cells[3].Value.ToString();
                btn_QuayLai.Enabled = true;
                btn_sua.Enabled = true;
            }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgv_chitietsanphamthue_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_chitietsanphamthue.Rows[e.RowIndex];
                selectedMaCTSPT = row.Cells[0].Value.ToString();
                string maSPT = row.Cells[1].Value.ToString();
                string soLuong = row.Cells[2].Value.ToString();
                string gia = row.Cells[3].Value.ToString();

                Frm_ChiTietSanPhamThue ctspt = new Frm_ChiTietSanPhamThue(selectedMaCTSPT, maSPT, soLuong, gia);
                ctspt.ShowDialog();
            }*/
        }

        private void dtgv_chitietsanphamthue_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TaiHoadonh()
        {
            dtgv_chitietsanphamthue.DataSource = chitietspt.GetChiTietSanPham();
            dtgv_chitietsanphamthue.Columns[0].HeaderText = "Mã Chi Tiết Sản Phẩm Thuê";
            dtgv_chitietsanphamthue.Columns[1].HeaderText = "Mã Sản Phẩm Thuê";
            dtgv_chitietsanphamthue.Columns[2].HeaderText = "Số Lượng";
            dtgv_chitietsanphamthue.Columns[3].HeaderText = "Giá";
            
        }
        private void GiaTriBanDau()
        {
            txt_mactspt.Text = null;
            txt_soluong.Text = null;
            
            txt_maspt.Text = null;
            txt_gia.Text = null;
            

        }

        private void Frm_ChiTietSanPhamThue_Load(object sender, EventArgs e)
        {
            TaiHoadonh();
        }
    }
}
