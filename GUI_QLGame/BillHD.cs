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
        public void Billshow(DTO_HoaDon selectedHoaDon)
        {
            // Hiển thị thông tin hóa đơn được chọn
            lbl_mahoadon.Text = selectedHoaDon.MaHD;
            lbl_makh.Text = selectedHoaDon.MaKH;

            ClearPreviousProductLabels();

            // Hiển thị chi tiết của hóa đơn được chọn
            lbl_mahd1.Text = selectedHoaDon.MaHD;
            lbl_makh1.Text = selectedHoaDon.MaKH;
            lbl_thanhtien1.Text = selectedHoaDon.ThanhTien.ToString("N0");

            // Hiển thị tổng số tiền (chỉ có một hóa đơn, nên tổng là thành tiền của chính hóa đơn đó)
            lbl_totalAmount.Text = selectedHoaDon.ThanhTien.ToString("N0");

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
