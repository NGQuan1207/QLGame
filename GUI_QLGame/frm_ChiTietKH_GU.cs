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
    public partial class frm_ChiTietKH_GU : Form
    {
        private string selectedMaKH; // Biến lưu mã khách hàng đã chọn
        private string MaKH, HoTen, DiaChi, SDT;
        DTO_ChiTietKH ctkh = new DTO_ChiTietKH();
        public frm_ChiTietKH_GU()
        {
            InitializeComponent();
        }
        public frm_ChiTietKH_GU(string maKH, string Hoten, string Diachi, string Dienthoai)
        {
            InitializeComponent();
            this.MaKH = maKH;
            this.HoTen = Hoten;
            this.DiaChi = Diachi;
            this.SDT = Dienthoai;
        }
        private void TaiHoadonh()
        {
            dtgv_hoadon.DataSource = BUS_ChiTietKH.ListCTKhachHang();
            dtgv_hoadon.Columns[0].HeaderText = "Mã Hóa Đơn";
            dtgv_hoadon.Columns[1].HeaderText = "Mã Khách Hàng";
            dtgv_hoadon.Columns[2].HeaderText = "Mã Nhân Viên";
            dtgv_hoadon.Columns[3].HeaderText = "Ngày Lập";
            dtgv_hoadon.Columns[4].HeaderText = "Thành Tiền";
            dtgv_hoadon.Columns[5].HeaderText = "Trạng Thái";
        }

        private void txt_makh_TextChanged(object sender, EventArgs e)
        {
            string makh = txt_makh.Text;
            if (!string.IsNullOrEmpty(makh))
            {
                DataTable dtHoaDon = BUS_HoaDon.TimHoaDon(makh);
                dtgv_hoadon.DataSource = dtHoaDon;
                // Điều chỉnh lại tên cột nếu cần thiết
                dtgv_hoadon.Columns[0].HeaderText = "Mã Hóa Đơn";
                dtgv_hoadon.Columns[1].HeaderText = "Mã Khách Hàng";
                dtgv_hoadon.Columns[2].HeaderText = "Mã Nhân Viên";
                dtgv_hoadon.Columns[3].HeaderText = "Ngày Lập";
                dtgv_hoadon.Columns[4].HeaderText = "Thành Tiền";
                dtgv_hoadon.Columns[5].HeaderText = "Trạng Thái";
            }
            string maphieuthue = txt_makh.Text;
            if (!string.IsNullOrEmpty(maphieuthue))
            {
                DataTable dtPhieuThue = BUS_PhieuThue.TimPhieuthue(maphieuthue);
                dtgv_phieuthue.DataSource = dtPhieuThue;
                // Điều chỉnh lại tên cột nếu cần thiết
                dtgv_phieuthue.Columns[0].HeaderText = "Mã Phiếu Thuê";
                dtgv_phieuthue.Columns[1].HeaderText = "Mã SP Thuê";
                dtgv_phieuthue.Columns[2].HeaderText = "Mã Khách Hàng";
                dtgv_phieuthue.Columns[3].HeaderText = " Ngày Đầu";
                dtgv_phieuthue.Columns[4].HeaderText = " Ngày Trả";
                dtgv_phieuthue.Columns[5].HeaderText = "Tiền Cọc";

            }
        }

        private void TaiPhieuThue()
        {
            dtgv_phieuthue.DataSource = BUS_ChiTietKH.ListCTKhachHang();
            dtgv_phieuthue.Columns[0].HeaderText = "Mã Phiếu Thuê";
            dtgv_phieuthue.Columns[1].HeaderText = "Mã SP Thuê";
            dtgv_phieuthue.Columns[2].HeaderText = "Mã Khách Hàng";
            dtgv_phieuthue.Columns[3].HeaderText = " Ngày Đầu";
            dtgv_phieuthue.Columns[4].HeaderText = " Ngày Trả";
            dtgv_phieuthue.Columns[5].HeaderText = "Tiền Cọc";

        }
        private void GiaTriBanDau()
        {
            txt_makh.Text = null;
            txt_tenkh.Text = null;
            txt_diachi.Text = null;
            txt_dienthoai.Text = null;
            txt_hoadon.Text = null;
            txt_mathue.Text = null;

        }
        private void frm_ChiTietKH_GU_Load(object sender, EventArgs e)
        {
            TaiHoadonh();
            TaiPhieuThue();
            txt_makh.Text = MaKH;
            txt_tenkh.Text = HoTen;
            txt_diachi.Text = DiaChi;
            txt_dienthoai.Text = SDT;
        }
        private void dtgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_hoadon.Rows[e.RowIndex];
                selectedMaKH = row.Cells[0].Value.ToString();
                txt_hoadon.Text = row.Cells[0].Value.ToString();
                btn_QuayLai.Enabled = true;

            }
        }
        private void dtgv_phieuthue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_phieuthue.Rows[e.RowIndex];
                selectedMaKH = row.Cells[0].Value.ToString();
                txt_mathue.Text = row.Cells[0].Value.ToString();
                btn_QuayLai.Enabled = true;

            }
        }
        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            frm_DanhSachKH khachhang = new frm_DanhSachKH();
            khachhang.ShowDialog();
            this.Hide();
        }
        private void btn_xoaphieu_Click(object sender, EventArgs e)
        {
            string maphieuthue = txt_mathue.Text;
            if (BUS_PhieuThue.XoaPhieuThue(maphieuthue))
            {
                MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiPhieuThue(); // Cập nhật lại danh sách bảo hành
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string mahoadon = txt_hoadon.Text;
            if (BUS_HoaDon.XoaHoaDon(mahoadon))
            {
                MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiHoadonh(); // Cập nhật lại danh sách bảo hành
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
