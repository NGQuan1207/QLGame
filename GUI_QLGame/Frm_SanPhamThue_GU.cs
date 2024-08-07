using BUS_QLGame;
using DTO_QLGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLGame
{
    public partial class Frm_SanPhamThue_GU : Form
    {
        DTO_SanPhamThue sanphamthue = new DTO_SanPhamThue();
        public Frm_SanPhamThue_GU()
        {
            InitializeComponent();
            /*dgv_thue.CellDoubleClick += dgv_thue_CellDoubleClick;*/
        }

        private void Frm_SanPhamThue_GU_Load(object sender, EventArgs e)
        {
            taibaohanh();
            dgv_thue.SelectionChanged += dgv_thue_SelectionChanged;
        }
        void taibaohanh()
        {
            dgv_thue.DataSource = BUS_SanPhamThue.LoadListSanPham();
            dgv_thue.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgv_thue.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgv_thue.Columns[2].HeaderText = "Loại Sản Phẩm";
            dgv_thue.Columns[3].HeaderText = "Hình ảnh";
            dgv_thue.Columns[3].HeaderText = "Ghi chú";
        }

        void HienThongTin()
        {
            if (dgv_thue.Rows.Count > 0)
            {
                txt_masp.Text = dgv_thue.CurrentRow.Cells["MaSPThue"].Value.ToString();
                txt_tensp.Text = dgv_thue.CurrentRow.Cells["TenSPThue"].Value.ToString();
                txt_loaisp.Text = dgv_thue.CurrentRow.Cells["LoaiSP"].Value.ToString();
                txt_ghichu.Text = dgv_thue.CurrentRow.Cells["GhiChu"].Value.ToString();
                txt_HinhAnh.Text = dgv_thue.CurrentRow.Cells["HinhAnh"].Value.ToString();

            }
            string imagePath = dgv_thue.CurrentRow.Cells["HinhAnh"].Value.ToString();
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
            else
            {
                pictureBox1.Image = null; // Hoặc một hình ảnh mặc định nếu không tìm thấy tệp
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

        private void dgv_thue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_thue.Rows[e.RowIndex];
                txt_masp.Text = row.Cells["MaSPThue"].Value.ToString();
                txt_tensp.Text = row.Cells["TenSPThue"].Value.ToString();
                txt_loaisp.Text = row.Cells["LoaiSP"].Value.ToString();
                txt_HinhAnh.Text = row.Cells["HinhAnh"].Value.ToString();
                txt_ghichu.Text = row.Cells["GhiChu"].Value.ToString();

            }
        }

        private void dgv_thue_SelectionChanged(object sender, EventArgs e)
        {
            HienThongTin();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string maspt = txt_masp.Text;
            string tenspt = txt_tensp.Text;
            string loaispt = txt_loaisp.Text;
            string ghichu = txt_ghichu.Text;
            string hinhanh = txt_HinhAnh.Text;
            DTO_SanPhamThue sanphamthue = new DTO_SanPhamThue(maspt, tenspt, loaispt, hinhanh, ghichu);

            if (BUS_SanPhamThue.ThemSanPhamThue(sanphamthue))
            {
                MessageBox.Show("Thêm sản phẩm thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                /*MessageBox.Show("Thêm sản phẩm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                taibaohanh();
                /*MessageBox.Show("Thêm sản phẩm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taibaohanh();*/
            }
            else
            {
                /*MessageBox.Show("Thêm sản phẩm thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                *//*MessageBox.Show("Thêm sản phẩm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);*//*
                taibaohanh();*/
                MessageBox.Show("Thêm sản phẩm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taibaohanh();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maspt = txt_masp.Text;
            if (BUS_SanPhamThue.XoaSanPhamThue(maspt))
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
            string maspt = txt_masp.Text;
            string tenspt = txt_tensp.Text;
            string loaisp = txt_loaisp.Text;
            string hinhanh = txt_HinhAnh.Text;
            string ghichu = txt_ghichu.Text;

            DTO_SanPhamThue sanphamthue = new DTO_SanPhamThue(maspt, tenspt, loaisp, hinhanh, ghichu);

            if (BUS_SanPhamThue.SuaSanPhamThue(maspt, tenspt, loaisp, hinhanh, ghichu))
            {
                /*MessageBox.Show("Sửa sản phẩm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taibaohanh();*/
                MessageBox.Show("Sửa sản phẩm thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                taibaohanh();
            }
            else
            {
                /*MessageBox.Show("Sửa sản phẩm thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                taibaohanh();*/
                MessageBox.Show("Sửa sản phẩm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taibaohanh();
            }
        }

       
        private void btn_chonanh_Click(object sender, EventArgs e)
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
                        pictureBox1.Image = Image.FromFile(filePath);
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
            }
        }

        private void dgv_thue_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_thue.Rows[e.RowIndex];
                txt_masp.Text = row.Cells["MaSPThue"].Value.ToString();
                txt_tensp.Text = row.Cells["TenSPThue"].Value.ToString();
                txt_loaisp.Text = row.Cells["LoaiSP"].Value.ToString();
                txt_HinhAnh.Text = row.Cells["HinhAnh"].Value.ToString();
                txt_ghichu.Text = row.Cells["GhiChu"].Value.ToString();
                this.Close();
                Frm_ChiTietSanPhamThue ctspt = new Frm_ChiTietSanPhamThue();
                ctspt.ShowDialog();

            }
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            DataTable danhsach = BUS_SanPhamThue.TimSanPhamThue(txt_Tim.Text);
            if (danhsach.Rows.Count > 0)
            {
                dgv_thue.DataSource = danhsach;
                HienThongTin();

            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            GiaTriBanDau();
        }
    }
}
