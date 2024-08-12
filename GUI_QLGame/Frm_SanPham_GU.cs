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
using System.IO;
using DAL_QLGame;

namespace GUI_QLGame
{
    public partial class Frm_SanPham_GU : Form
    {
        DTO_SanPham sanpham = new DTO_SanPham();
        private DAL_SanPham dalSanPham = new DAL_SanPham();
        public Frm_SanPham_GU()
        {
            InitializeComponent();
            LoadSanPham();
        }
        private void LoadSanPham()
        {
            DataTable dt = dalSanPham.LoadListSanPham();
            dgv_sanpham.DataSource = dt;
        }
        public void RefreshData()
        {
            LoadSanPham();
        }
        private void Frm_SanPham_GU_Load(object sender, EventArgs e)
        {
            taibaohanh();
            dgv_sanpham.SelectionChanged += dgv_sanpham_SelectionChanged;
        }

        void taibaohanh()
        {
            dgv_sanpham.DataSource = BUS_SanPham.LoadListSanPham();
            dgv_sanpham.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgv_sanpham.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgv_sanpham.Columns[2].HeaderText = "Loại Sản Phẩm";
            dgv_sanpham.Columns[3].HeaderText = "Số Lượng";
            dgv_sanpham.Columns[4].HeaderText = "Giá";
            dgv_sanpham.Columns[5].HeaderText = "Hình ảnh";
            dgv_sanpham.Columns[6].HeaderText = "Ghi chú";

        }

        void HienThongTin()
        {
            if (dgv_sanpham.Rows.Count > 0)
            {
                txt_masp.Text = dgv_sanpham.CurrentRow.Cells["MaSP"].Value.ToString();
                txt_tensp.Text = dgv_sanpham.CurrentRow.Cells["TenSP"].Value.ToString();
                txt_loaisp.Text = dgv_sanpham.CurrentRow.Cells["LoaiSP"].Value.ToString();
                txt_SoLuong.Text = dgv_sanpham.CurrentRow.Cells["SoLuong"].Value.ToString();
                txt_Gia.Text = dgv_sanpham.CurrentRow.Cells["Gia"].Value.ToString();
                txt_HinhAnh.Text = dgv_sanpham.CurrentRow.Cells["HinhAnh"].Value.ToString();
                txt_ghichu.Text = dgv_sanpham.CurrentRow.Cells["GhiChu"].Value.ToString();
            }
            string imagePath = dgv_sanpham.CurrentRow.Cells["HinhAnh"].Value.ToString();
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                pb_SanPham.Image = Image.FromFile(imagePath);
            }
            else
            {
                pb_SanPham.Image = null; 
            }
        }
        void GiaTriBanDau()
        {
            txt_masp.Text = null;
            txt_tensp.Text = null;
            txt_loaisp.Text = null;
            txt_SoLuong.Text = null;
            txt_Gia.Text = null;
            txt_HinhAnh.Text = null;
            txt_ghichu.Text = null;

        }

        private void dgv_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_sanpham.Rows[e.RowIndex];
                txt_masp.Text = row.Cells["MaSp"].Value.ToString();
                txt_tensp.Text = row.Cells["TenSP"].Value.ToString();
                txt_loaisp.Text = row.Cells["LoaiSP"].Value.ToString();
                txt_SoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txt_Gia.Text = row.Cells["Gia"].Value.ToString();
             
                txt_HinhAnh.Text = row.Cells["HinhAnh"].Value.ToString();
                txt_ghichu.Text = row.Cells["GhiChu"].Value.ToString();


            }
        }

        private void dgv_sanpham_SelectionChanged(object sender, EventArgs e)
        {
            HienThongTin();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string tensp = txt_tensp.Text;
            string loaisp = txt_loaisp.Text;
            int soluong = int.Parse(txt_SoLuong.Text);
            int gia = int.Parse(txt_Gia.Text);
            string ghichu = txt_ghichu.Text;
            string hinhanh = txt_HinhAnh.Text;
            DTO_SanPham sanpham = new DTO_SanPham(tensp, loaisp, soluong, gia, hinhanh, ghichu );

            if (BUS_SanPham.ThemSanPham(sanpham))
            {
                MessageBox.Show("Thêm sản phẩm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taibaohanh();
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
                taibaohanh();
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string masp = txt_masp.Text;
            string tensp = txt_tensp.Text;
            string loaisp = txt_loaisp.Text;
            int soluong = int.Parse(txt_SoLuong.Text);
            int gia = int.Parse(txt_Gia.Text);
            string hinhanh = txt_HinhAnh.Text;
            string ghichu = txt_ghichu.Text;

            DTO_SanPham sanpham = new DTO_SanPham(masp, tensp, loaisp, soluong, gia, hinhanh, ghichu);

            if (BUS_SanPham.SuaSanPham(masp, tensp, loaisp, soluong, gia, hinhanh, ghichu))
            {
                MessageBox.Show("Sửa sản phẩm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taibaohanh();
            }
            else
            {
                MessageBox.Show("Sửa sản phẩm thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {

            DataTable danhsach = BUS_SanPham.TimSanPham(txt_Tim.Text);
            if (danhsach.Rows.Count > 0)
            {
                dgv_sanpham.DataSource = danhsach;
                HienThongTin();

            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            GiaTriBanDau();
        }

        private void btn_ChonHinh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\Lap4all\\source\\repos";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string filePath = openFileDialog.FileName;
                    txt_HinhAnh.Text = filePath;


                    if (File.Exists(filePath))
                    {
                        pb_SanPham.Image = Image.FromFile(filePath);
                    }
                    else
                    {
                        pb_SanPham.Image = null;
                    }
                }
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            GiaTriBanDau();
        }
    }
}
