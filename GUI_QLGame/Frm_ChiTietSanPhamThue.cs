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
            Frm_SanPhamThue sanPhamThue = new Frm_SanPhamThue();
            sanPhamThue.ShowDialog();
            
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string mactspt = txt_mactspt.Text;
            string maspt = txt_maspt.Text;
            int soluong;
            int gia;
            // Kiểm tra và chuyển đổi số lượng
            if (int.TryParse(txt_soluong.Text, out soluong))
            {
                // Chuyển đổi thành công, bạn có thể sử dụng biến soluong
            }
            else
            {
                // Xử lý lỗi khi chuyển đổi thất bại
                MessageBox.Show("Số lượng không hợp lệ.");
            }

            // Kiểm tra và chuyển đổi giá
            if (int.TryParse(txt_gia.Text, out gia))
            {
                // Chuyển đổi thành công, bạn có thể sử dụng biến gia
            }
            else
            {
                // Xử lý lỗi khi chuyển đổi thất bại
                MessageBox.Show("Giá không hợp lệ.");
            }

            DTO_ChiTietSPThue sanphamthue = new DTO_ChiTietSPThue();

            if (BUS_ChiTietSPT.SuaChiTietSPT(mactspt, maspt, soluong, gia))
            {
                /*MessageBox.Show("Sửa sản phẩm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taibaohanh();*/
                MessageBox.Show("Sửa sản phẩm thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TaiHoadonh();
            }
            else
            {
                /*MessageBox.Show("Sửa sản phẩm thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                taibaohanh();*/
                MessageBox.Show("Sửa sản phẩm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiHoadonh();
            }
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
