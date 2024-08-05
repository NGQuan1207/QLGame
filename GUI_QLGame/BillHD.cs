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
    public partial class BillHD : Form
    {
        public BillHD()
        {
            InitializeComponent();
        }
        void Billhoadon(DTO_HoaDon hoaDon)
        {

            lbl_mahoadon.Text = hoaDon.MaHD;
            lbl_makh.Text = hoaDon.MaKH;



            // Clear previous product labels if needed
            ClearPreviousProductLabels();

            // Load the chi tiết from the provided hoaDon details if necessary
            // This requires that you have the chi tiết of the invoice
            // For now, just display the total amount
        }
        public void Billshow(string makh, string mahd, List<DTO_HoaDon> chiTietHoaDons)
        {
            lbl_mahoadon.Text = mahd;
            lbl_makh.Text = makh;

            ClearPreviousProductLabels();

            for (int i = 0; i < chiTietHoaDons.Count; i++)
            {
                DTO_HoaDon chiTiet = chiTietHoaDons[i];

                switch (i)
                {
                    case 0:
                        lbl_mahd1.Text = chiTiet.MaHD;
                        lbl_makh1.Text = chiTiet.MaKH;
                        lbl_thanhtien1.Text = chiTiet.ThanhTien.ToString("N0");
                        break;
                    case 1:
                        lbl_mahd2.Text = chiTiet.MaHD;
                        lbl_makh2.Text = chiTiet.MaKH;
                        lbl_thanhtien2.Text = chiTiet.ThanhTien.ToString("N0");
                        break;
                    case 2:
                        lbl_mahd3.Text = chiTiet.MaHD;
                        lbl_makh3.Text = chiTiet.MaKH;
                        lbl_thanhtien3.Text = chiTiet.ThanhTien.ToString("N0");
                        break;
                }
            }

            lbl_totalAmount.Text = chiTietHoaDons.Sum(x => x.ThanhTien).ToString("N0");

            // Tính và hiển thị tổng số tiền nếu cần
            /* lbl_totalAmount.Text = chiTietHoaDons.Sum(x => x.ThanhTien).ToString("N0");*/
        }
        private void ClearPreviousProductLabels()
        {
            lbl_mahd1.Text = string.Empty;
            lbl_makh1.Text = string.Empty;
            lbl_thanhtien1.Text = string.Empty;
            lbl_mahd2.Text = string.Empty;
            lbl_makh2.Text = string.Empty;
            lbl_thanhtien2.Text = string.Empty;
            lbl_mahd3.Text = string.Empty;
            lbl_makh3.Text = string.Empty;
            lbl_thanhtien3.Text = string.Empty;
        }
        private void BillHD_Load(object sender, EventArgs e)
        {

        }
    }
}
