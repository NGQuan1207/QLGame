using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLGame;
using DTO_QLGame;

namespace GUI_QLGame
{
    public partial class Frm_BaoHanh : Form
    {
        DTO_BaoHanh baohanh=new DTO_BaoHanh();
        public Frm_BaoHanh()
        {
            InitializeComponent();
        }

        void taibaohanh()
        {
            dtgv_Baohanh.DataSource = BUS_BaoHanh.LoadListBaoHanh();
            dtgv_Baohanh.Columns[0].HeaderText = "Mã Bảo Hành";
            dtgv_Baohanh.Columns[1].HeaderText = "Mã Sản Phẩm";
            dtgv_Baohanh.Columns[2].HeaderText = "Mã Khách Hàng";
            dtgv_Baohanh.Columns[3].HeaderText = "Bắt đầu";
            dtgv_Baohanh.Columns[4].HeaderText = "Kết thúc";
            dtgv_Baohanh.Columns[5].HeaderText = "Tình Trạng";
        }
        void HienThongTin()
        {
            if (dtgv_Baohanh.Rows.Count > 0)
            {
                txt_MaBaoHanh.Text = dtgv_Baohanh.CurrentRow.Cells["MaBaoHanh"].Value.ToString();
                txt_MaSP.Text = dtgv_Baohanh.CurrentRow.Cells["MaSP"].Value.ToString();
                txt_MaKH.Text = dtgv_Baohanh.CurrentRow.Cells["MaKH"].Value.ToString();
                txt_BatDau.Text = dtgv_Baohanh.CurrentRow.Cells["startdate"].Value.ToString();
                txt_KetThuc.Text = dtgv_Baohanh.CurrentRow.Cells["enddate"].Value.ToString();
                txt_TinhTrang.Text = dtgv_Baohanh.CurrentRow.Cells["TinhTrang"].Value.ToString();

            }
        }

        void GiaTriBanDau()
        {
            txt_MaBaoHanh.Text = null;
            txt_MaSP.Text = null ;
            txt_MaKH.Text = null;
            txt_BatDau.Text = null;
            txt_KetThuc.Text = null;
            txt_TinhTrang.Text = null;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_LocSP_Click(object sender, EventArgs e)
        {

            DataTable danhsach = BUS_BaoHanh.TimBaoHanh(txt_TimBaoHanh.Text);
            if (danhsach.Rows.Count > 0)
            {
                dtgv_Baohanh.DataSource = danhsach;
                HienThongTin();
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            GiaTriBanDau();
        }

        private void Frm_BaoHanh_Load(object sender, EventArgs e)
        {
            taibaohanh();
        }

        private void txt_tinhtrang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThemBH_Click(object sender, EventArgs e)
        {

           
            string maSP = txt_MaSP.Text;
            string maKH = txt_MaKH.Text;
            string batDau = txt_BatDau.Text;
           string ketThuc = txt_KetThuc.Text;
            string tinhTrang = txt_TinhTrang.Text;

            DTO_BaoHanh baohanh = new DTO_BaoHanh( maSP, maKH, batDau, ketThuc, tinhTrang);

            if (BUS_BaoHanh.ThemBaoHanh(baohanh))
            {
                MessageBox.Show("Thêm bảo hành thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taibaohanh(); // Cập nhật lại danh sách bảo hành
            }
            else
            {
                MessageBox.Show("Thêm bảo hành thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_XoaBH_Click(object sender, EventArgs e)
        {
            string maBaoHanh = txt_MaBaoHanh.Text;
            if (BUS_BaoHanh.XoaBaoHanh(maBaoHanh))
            {
                MessageBox.Show("Xóa bảo hành thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taibaohanh(); // Cập nhật lại danh sách bảo hành
            }
            else
            {
                MessageBox.Show("Xóa bảo hành thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgv_Baohanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Đảm bảo không click vào tiêu đề cột
            {
                DataGridViewRow row = dtgv_Baohanh.Rows[e.RowIndex];
                txt_MaBaoHanh.Text = row.Cells["MaBaoHanh"].Value.ToString();
                txt_MaSP.Text = row.Cells["MaSP"].Value.ToString();
                txt_MaKH.Text = row.Cells["MaKH"].Value.ToString();
                txt_BatDau.Text = row.Cells["startdate"].Value.ToString();
                txt_KetThuc.Text = row.Cells["enddate"].Value.ToString();
                txt_TinhTrang.Text = row.Cells["TinhTrang"].Value.ToString();
            }
        }

        private void dtgv_Baohanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            GiaTriBanDau();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string mabh = txt_MaBaoHanh.Text;
            string masp = txt_MaSP.Text;
            string makh = txt_MaKH.Text;
            string batdau = txt_BatDau.Text;
            string ketthuc = txt_KetThuc.Text;
            string tinhtrang = txt_TinhTrang.Text;


            DTO_BaoHanh sanpham = new DTO_BaoHanh(mabh, masp, makh, batdau, ketthuc, tinhtrang);


            if (BUS_BaoHanh.SuaBaoHanh(mabh, masp, makh, batdau, ketthuc, tinhtrang))
            {
                MessageBox.Show("Sửa Bảo Hành thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taibaohanh();
            }
            else
            {
                MessageBox.Show("Sửa Bảo Hành thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
