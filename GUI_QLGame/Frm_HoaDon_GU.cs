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
    public partial class Frm_HoaDon_GU : Form
    {
        public Frm_HoaDon_GU()
        {
            InitializeComponent();
        }
        private string selectedMaKH;
        private void TaiHoadon()
        {
            dtgv_hoadon.DataSource = BUS_HoaDon.ListHoaDon();
            dtgv_hoadon.Columns[0].HeaderText = "Mã Hóa Đơn";
            dtgv_hoadon.Columns[1].HeaderText = "Mã Khách Hàng";
            dtgv_hoadon.Columns[2].HeaderText = "Mã Nhân Viên";
            dtgv_hoadon.Columns[3].HeaderText = "Ngày Lập";
            dtgv_hoadon.Columns[4].HeaderText = "Thành Tiền";

        }
        private void Frm_HoaDon_GU_Load(object sender, EventArgs e)
        {
            TaiHoadon();
        }

        private void txt_MaHoaDon_TextChanged(object sender, EventArgs e)
        {
           string makh = txt_MaHoaDon.Text;
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
                
            }
        }
        private void ShowBill(DTO_HoaDon hoaDon)
        {
            BillHD billForm = new BillHD();
            billForm.Billshow(hoaDon);
            billForm.Show();
        }
        private void btn_InHoaDon_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_InHoaDon_Click_1(object sender, EventArgs e)
        {
            if (dtgv_hoadon.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgv_hoadon.SelectedRows[0];

                DTO_HoaDon hoaDon = new DTO_HoaDon
                {
                    MaHD = selectedRow.Cells["MaHD"].Value.ToString(),
                    MaKH = selectedRow.Cells["MaKH"].Value.ToString(),
                    ThanhTien = Convert.ToDecimal(selectedRow.Cells["ThanhTien"].Value)
                };

                ShowBill(hoaDon); // Sử dụng ShowBill để hiển thị hóa đơn
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để in.");
            }
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void dtgv_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgv_hoadon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem một hàng hợp lệ có được chọn
            {
                DataGridViewRow selectedRow = dtgv_hoadon.Rows[e.RowIndex];

                // Tạo DTO_HoaDon từ hàng đã chọn
                DTO_HoaDon selectedHoaDon = new DTO_HoaDon
                {
                    MaHD = selectedRow.Cells["MaHD"].Value.ToString(),
                    MaKH = selectedRow.Cells["MaKH"].Value.ToString(),
                    ThanhTien = Convert.ToDecimal(selectedRow.Cells["ThanhTien"].Value)
                };

                // Gọi ShowBill để hiển thị hóa đơn
                ShowBill(selectedHoaDon);
            }
        }
    }
}
