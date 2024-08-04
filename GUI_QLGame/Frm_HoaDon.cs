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
    public partial class Frm_HoaDon : Form
    {
        public Frm_HoaDon()
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
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Frm_HoaDon_Load(object sender, EventArgs e)
        {
            TaiHoadon();
        }

        private void dataG_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            BillHoaDon billForm = new BillHoaDon();
            billForm.Billshow(hoaDon.MaHD, hoaDon.MaKH, chiTietHoaDons);
            billForm.Show();

        }
        private void btn_InHoaDon_Click(object sender, EventArgs e)
        {
            // Lấy thông tin hóa đơn từ DataGridView (Giả sử bạn chọn một dòng từ dtgv_hoadon)
            if (dtgv_hoadon.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgv_hoadon.SelectedRows[0];

                // Tạo một đối tượng DTO_HoaDon từ dữ liệu của dòng được chọn
                DTO_HoaDon hoaDon = new DTO_HoaDon
                {
                    MaHD = selectedRow.Cells["MaHD"].Value.ToString(),
                    MaKH = selectedRow.Cells["MaKH"].Value.ToString(),
                    // Cần lấy thêm thông tin chi tiết nếu có
                };

                // Tạo danh sách chi tiết hóa đơn
                List<DTO_HoaDon> chiTietHoaDons = new List<DTO_HoaDon>();
                foreach (DataGridViewRow row in dtgv_hoadon.Rows)
                {
                    if (row.Cells["MaHD"].Value != null)
                    {
                        chiTietHoaDons.Add(new DTO_HoaDon
                        {
                            MaHD = row.Cells["MaHD"].Value.ToString(),
                            MaKH = row.Cells["MaKH"].Value.ToString(),
                            // Thêm các thuộc tính khác nếu cần
                        });
                    }
                }

                // Tạo và hiển thị form BillHoaDon với dữ liệu hóa đơn
                BillHoaDon billForm = new BillHoaDon();
                billForm.Billshow(hoaDon.MaKH, hoaDon.MaHD, chiTietHoaDons);
                billForm.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để in.");
            }
        }
    }
}

        /*   public void AddBill(DTO_HoaDon hoaDon)
           {
               DataTable dt = (DataTable)dtgv_hoadon.DataSource;
               if (dt == null)
               {
                   dt = new DataTable();
                   dt.Columns.Add("MaHD");
                   dt.Columns.Add("MaKH");
                   dt.Columns.Add("MaNV");
                   dt.Columns.Add("NgayLap");
                   dt.Columns.Add("ThanhTien");
                   dataG_HoaDon.DataSource = dt;
               }

               DataRow newRow = dt.dtgv_hoadon();
               newRow["MaHD"] = hoaDon.MaHD; // Ensure you set MaHD after inserting it into the database
               newRow["MaKH"] = hoaDon.MaKH;
               newRow["MaNV"] = hoaDon.MaNV;
               newRow["NgayLap"] = hoaDon.NgayLap;
               newRow["ThanhTien"] = hoaDon.ThanhTien;
               dt.Rows.Add(newRow);
           }*/
    }
}
