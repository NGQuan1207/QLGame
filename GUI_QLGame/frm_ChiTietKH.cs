using BUS_QLGame;
using DTO_QLGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLGame
{
    public partial class frm_ChiTietKH : Form
    {
        private string selectedMaKH; // Biến lưu mã khách hàng đã chọn
        private string MaKH, HoTen, DiaChi, SDT;
        DTO_ChiTietKH ctkh = new DTO_ChiTietKH();
        public frm_ChiTietKH()
        {
            InitializeComponent();
        }
        public frm_ChiTietKH(string maKH, string Hoten, string Diachi, string Dienthoai)
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
        private void GiaTriBanDau()
        {
            txt_makh.Text = null;
            txt_tenkh.Text = null;
            txt_diachi.Text = null;
            txt_dienthoai.Text = null;
            txt_hoadon.Text = null;
            txt_mathue.Text = null;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        }
        /* private void LoadCustomerData(string maKH)
         {
             string connectionString = "Data Source=LAPTOP-PDIC30NO\\MISASME2019;Initial Catalog=QL_ThietBiGame3;Integrated Security=True;Encrypt=False"; // Cập nhật với chuỗi kết nối của bạn
             string query = "GetKhachHangByMaKH"; // Tên của stored procedure

             using (SqlConnection conn = new SqlConnection(connectionString))
             {
                 using (SqlCommand cmd = new SqlCommand(query, conn))
 {
                     cmd.CommandType = CommandType.StoredProcedure;
                     cmd.Parameters.AddWithValue("@MaKH", maKH);

                     SqlDataAdapter da = new SqlDataAdapter(cmd);
                     DataTable dt = new DataTable();
                     da.Fill(dt);

                     if (dt.Rows.Count > 0)
                     {
                         DataRow row = dt.Rows[0];
                         txt_makh.Text = row["MaKH"].ToString();
                         txt_tenkh.Text = row["TenKH"].ToString();
                         txt_diachi.Text = row["DiaChi"].ToString();
                         txt_dienthoai.Text = row["SDT"].ToString();
                         txt_hoadon.Text = row["MaCTHD"].ToString();
                         txt_mathue.Text = row["MaPhieuThue"].ToString();
                     }
                     else
                     {
                         // Clear textboxes if no data found
                         txt_tenkh.Clear();
                         txt_diachi.Clear();
                         txt_dienthoai.Clear();
                         txt_hoadon.Clear();
                         txt_mathue.Clear();
                     }
                 }
             }

         }*/


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }


        private void frm_ChiTietKH_Load(object sender, EventArgs e)
        {
            txt_makh.Text = MaKH;
            txt_tenkh.Text = HoTen;
            txt_diachi.Text = DiaChi;
            txt_dienthoai.Text = SDT;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            frm_DanhSachKH khachhang = new frm_DanhSachKH();
            khachhang.ShowDialog();
            this.Close();
        }

        private void dtgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv_hoadon.Rows[e.RowIndex];
                selectedMaKH = row.Cells[0].Value.ToString();
                txt_hoadon.Text = row.Cells[0].Value.ToString();
                btn_QuayLai.Enabled = true;
                btn_sua.Enabled = true;
            }
        }

        private void dtgv_kh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgv_kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string mahoadon = txt_hoadon.Text;
            if (BUS_HoaDon.XoaHoaDon(mahoadon))
            {
                MessageBox.Show("Xóa Hóa Đơn thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiHoadonh(); // Cập nhật lại danh sách bảo hành
            }
            else
            {
                MessageBox.Show("Xóa Hóa Đơn thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {

        }
    }
}
