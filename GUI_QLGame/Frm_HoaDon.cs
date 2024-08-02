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
