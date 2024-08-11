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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        void SetBillInfo(DTO_HoaDon hoaDon)
        {
            lbl_maHD.Text = hoaDon.MaHD;
            lbl_TenKhachHang.Text = hoaDon.TenKH;
            lbl_SDT.Text = hoaDon.SDT;
            lbl_DiaChi.Text = hoaDon.DiaChi;
            lbl_TongTien.Text = hoaDon.ThanhTien.ToString("N0");

            // Clear previous product labels if needed
            ClearPreviousProductLabels();

            // Load the chi tiết from the provided hoaDon details if necessary
            // This requires that you have the chi tiết of the invoice
            // For now, just display the total amount
        }

        public void SetBillDetails(string maHD,string tenKH, string sdt, string diaChi, List<DTO_HoaDon> chiTietHoaDons)
        {
            lbl_maHD.Text = maHD;
            lbl_TenKhachHang.Text = tenKH;
            lbl_SDT.Text = sdt;
            lbl_DiaChi.Text = diaChi;

            // Clear previous labels if needed
            ClearPreviousProductLabels();

            decimal totalAmount = 0;

            for (int i = 0; i < chiTietHoaDons.Count; i++)
            {
                DTO_HoaDon chiTiet = chiTietHoaDons[i];

                switch (i)
                {
                    case 0:
                        lbl_TenSanPham1.Text = chiTiet.TenSanPham;
                        lbl_SoLuong1.Text = chiTiet.SoLuong.ToString();
                        lbl_ThanhTien1.Text = chiTiet.ThanhTien.ToString("N0");
                        totalAmount += chiTiet.ThanhTien;
                        break;
                    case 1:
                        lbl_TenSanPham2.Text = chiTiet.TenSanPham;
                        lbl_SoLuong2.Text = chiTiet.SoLuong.ToString();
                        tbl_ThanhTien2.Text = chiTiet.ThanhTien.ToString("N0");
                        totalAmount += chiTiet.ThanhTien;
                        break;
                    case 2:
                        lbl_TenSanPham3.Text = chiTiet.TenSanPham;
                        lbl_SoLuong3.Text = chiTiet.SoLuong.ToString();
                        lbl_ThanhTien3.Text = chiTiet.ThanhTien.ToString("N0");
                        totalAmount += chiTiet.ThanhTien;
                        break;
                        // Add more cases if there are more labels
                }
            }

            // Set the total amount
            lbl_TongTien.Text = totalAmount.ToString("N0");
        }

        private void ClearPreviousProductLabels()
        {
            lbl_TenSanPham1.Text = string.Empty;
            lbl_SoLuong1.Text = string.Empty;
            lbl_ThanhTien1.Text = string.Empty;
            lbl_TenSanPham2.Text = string.Empty;
            lbl_SoLuong2.Text = string.Empty;
            tbl_ThanhTien2.Text = string.Empty;
            lbl_TenSanPham3.Text = string.Empty;
            lbl_SoLuong3.Text = string.Empty;
            lbl_ThanhTien3.Text = string.Empty;
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }
    }
}
