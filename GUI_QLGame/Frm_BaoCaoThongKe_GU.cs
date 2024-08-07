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
    public partial class Frm_BaoCaoThongKe_GU : Form
    {
        public Frm_BaoCaoThongKe_GU()
        {
            InitializeComponent();
        }
        void taibaocao()
        {
            dtgv_spthue.DataSource = BUS_SanPham.ListSPThue();
            dtgv_spthue.Columns[0].HeaderText = "Mã Sản Phẩm Thue";
            dtgv_spthue.Columns[1].HeaderText = "Tên Sản Phẩm Thue ";
            dtgv_spthue.Columns[2].HeaderText = "Loại Sản Phẩm";
            dtgv_spthue.Columns[3].HeaderText = "Ghi Chu";
            dtgv_spthue.Columns[4].HeaderText = "Hinh Anh";
        }
        void TaiHoadonh()
        {
            dtgv_hoadon.DataSource = BUS_HoaDon.ListHoaDon();
            dtgv_hoadon.Columns[0].HeaderText = "Mã Hóa Đơn";
            dtgv_hoadon.Columns[1].HeaderText = "Mã Khách Hàng";
            dtgv_hoadon.Columns[2].HeaderText = "Mã Nhân Viên";
            dtgv_hoadon.Columns[3].HeaderText = "Ngày Lập";
            dtgv_hoadon.Columns[4].HeaderText = "Thành Tiền";

        }
        void tinhTongThuNhap()
        {
            DataTable dtHoaDon = (DataTable)BUS_HoaDon.ListHoaDon();
            decimal tongThuNhap = 0;
            foreach (DataRow row in dtHoaDon.Rows)
            {
                tongThuNhap += Convert.ToDecimal(row["ThanhTien"]);
            }
            txt_Thunhap.Text = tongThuNhap.ToString();
        }

        void tinhTongHoaDon()
        {
            DataTable dtHoaDon = (DataTable)BUS_HoaDon.ListHoaDon();
            int tongHoaDon = dtHoaDon.Rows.Count;
            txt_TongSP.Text = tongHoaDon.ToString();
        }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void Frm_BaoCaoThongKe_GU_Load(object sender, EventArgs e)
        {
            taibaocao();
            TaiHoadonh();
            tinhTongThuNhap();
            tinhTongHoaDon();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
          string maspt = txt_maspt.Text;
            if (!string.IsNullOrEmpty(maspt))
            {
                // Thực hiện lọc sản phẩm


                DataTable dtsanpham = BUS_SanPham.TimSanPhamThue(maspt);
                dtgv_spthue.DataSource = dtsanpham;
                // Điều chỉnh lại tên cột nếu cần thiết
                dtgv_spthue.Columns[0].HeaderText = "Mã Sản Phẩm Thue";
                dtgv_spthue.Columns[1].HeaderText = "Tên Sản Phẩm Thue ";
                dtgv_spthue.Columns[2].HeaderText = "Loại Sản Phẩm";
                dtgv_spthue.Columns[3].HeaderText = "Ghi Chu";
                dtgv_spthue.Columns[4].HeaderText = "Hinh Anh";
            }
        }

        private void txt_hoadon_TextChanged(object sender, EventArgs e)
        {
            string makh = txt_hoadon.Text;
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
        }

        private void dtgv_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_Thunhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TongSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgv_spthue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
