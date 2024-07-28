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
    public partial class Frm_SanPham : Form
    {
        DTO_SanPham sanpham = new DTO_SanPham();
        public Frm_SanPham()
        {
            InitializeComponent();
        }

        private void Frm_SanPham_Load(object sender, EventArgs e)
        {
            taibaohanh();
        }

        void taibaohanh()
        {
            dgv_sanpham.DataSource = BUS_SanPham.LoadListSanPham();
            dgv_sanpham.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgv_sanpham.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgv_sanpham.Columns[2].HeaderText = "Loại Sản Phẩm";
            dgv_sanpham.Columns[3].HeaderText = "Hình ảnh";
            dgv_sanpham.Columns[4].HeaderText = "Ghi chú";
        }

        void HienThongTin()
        {
            if (dgv_sanpham.Rows.Count > 0)
            {
                txt_masp.Text = dgv_sanpham.CurrentRow.Cells["MaSP"].Value.ToString();
                txt_tensp.Text = dgv_sanpham.CurrentRow.Cells["TenSP"].Value.ToString();
                txt_loaisp.Text = dgv_sanpham.CurrentRow.Cells["LoaiSP"].Value.ToString();
                txt_ghichu.Text = dgv_sanpham.CurrentRow.Cells["GhiChu"].Value.ToString();
                txt_HinhAnh.Text = dgv_sanpham.CurrentRow.Cells["HinhAnh"].Value.ToString();
        
            }
        }


        void GiaTriBanDau()
        {
            txt_masp.Text = null;
            txt_tensp.Text = null;
            txt_loaisp.Text = null;
            txt_ghichu.Text = null;
            txt_HinhAnh.Text = null;

        }

        private void btn_them_Click(object sender, EventArgs e)
        {

          
            string tensp = txt_tensp.Text;
            string loaisp = txt_loaisp.Text; 
            string ghichu = txt_ghichu.Text;
            string hinhanh = txt_HinhAnh.Text;
            DTO_SanPham sanpham = new DTO_SanPham(tensp, loaisp, ghichu, hinhanh);

            if (BUS_SanPham.ThemSanPham(sanpham))
            {
                MessageBox.Show("Thêm sản phẩm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taibaohanh(); // Cập nhật lại danh sách bảo hành
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string masp = txt_masp.Text;
            if (BUS_SanPham.XoaSanPham(masp))
            {
                MessageBox.Show("Xóa sản phẩm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taibaohanh(); // Cập nhật lại danh sách bảo hành
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
