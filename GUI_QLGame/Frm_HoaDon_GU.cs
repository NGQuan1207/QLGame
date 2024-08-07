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
            string manv = txt_MaHoaDon.Text;
            if (!string.IsNullOrEmpty(manv))
            {
                DataTable dtHoaDon = BUS_HoaDon.SearchHoaDon(manv);
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
            List<DTO_HoaDon> chiTietHoaDons = new List<DTO_HoaDon>();

            foreach (DataGridViewRow row in dtgv_hoadon.Rows)
            {
                if (row.Cells["MaHD"].Value != null)
                {
                    chiTietHoaDons.Add(new DTO_HoaDon
                    {
                        MaHD = row.Cells["MaHD"].Value.ToString(),
                        MaKH = row.Cells["MaKH"].Value.ToString(),

                    });
                }
            }
            BillHD billForm = new BillHD();
            billForm.Billshow(hoaDon.MaHD, hoaDon.MaKH, chiTietHoaDons);
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

                List<DTO_HoaDon> chiTietHoaDons = new List<DTO_HoaDon>();
                foreach (DataGridViewRow row in dtgv_hoadon.Rows)
                {
                    if (row.Cells["MaHD"].Value != null)
                    {
                        chiTietHoaDons.Add(new DTO_HoaDon
                        {
                            MaHD = row.Cells["MaHD"].Value.ToString(),
                            MaKH = row.Cells["MaKH"].Value.ToString(),
                            ThanhTien = Convert.ToDecimal(row.Cells["ThanhTien"].Value)
                        });
                    }
                }

                BillHD billForm = new BillHD();
                billForm.Billshow(hoaDon.MaKH, hoaDon.MaHD, chiTietHoaDons);
                billForm.Show();
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
    }
}
