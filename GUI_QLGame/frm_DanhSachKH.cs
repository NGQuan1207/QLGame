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
    public partial class frm_DanhSachKH : Form
    {
        private BUS_KhachHang busKH = new BUS_KhachHang();
        private string selectedMaKH; // Biến lưu mã khách hàng đã chọn
        public frm_DanhSachKH()
        {
            InitializeComponent();
            Load += new EventHandler(Frm_KhachHang_Load);
        }
        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            LoadGridView_Khach();
            ResetValues();
        }
        private void ResetValues()
        {
            txtTenKhachHang.Text = null;
            txtSDT.Text = null;
            txtDiaChi.Text = null;
            txtLocSDT.Text = null;

            txtTenKhachHang.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            txtLocSDT.Enabled = true;
            dtgDanhSachKH.Enabled = true;

            btnThem.Enabled = true;
            btnLoc.Enabled = false;
            btnChiTietKhachHang.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtSDT.Focus();
        }
        private void LoadGridView_Khach()
        {
            dtgDanhSachKH.DataSource = busKH.GetKhach();
            dtgDanhSachKH.Columns[0].HeaderText = "Mã KH";
            dtgDanhSachKH.Columns[1].HeaderText = "Họ và Tên";
            dtgDanhSachKH.Columns[2].HeaderText = "Địa Chỉ";
            dtgDanhSachKH.Columns[3].HeaderText = "SDT";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgDanhSachKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSDT.Text) || string.IsNullOrWhiteSpace(txtTenKhachHang.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(txtSDT.Text.Trim(), out long intDienThoai) || intDienThoai <= 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại hợp lệ, số nguyên dương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }

            // Use individual parameters instead of DTO_KhachHang object
            string tenKhachHang = txtTenKhachHang.Text;
            string diaChi = txtDiaChi.Text;
            string sdt = txtSDT.Text;

            if (busKH.UpdateKhach(selectedMaKH, tenKhachHang, diaChi, sdt))
            {
                MessageBox.Show("Cập nhật thành công");
                ResetValues();
                LoadGridView_Khach(); // refresh DataGridView
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChiTietKhachHang_Click(object sender, EventArgs e)
        {
            frm_ChiTietKH ctkh = new frm_ChiTietKH(selectedMaKH, txtTenKhachHang.Text, txtDiaChi.Text, txtSDT.Text);
            ctkh.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSDT.Text) || string.IsNullOrWhiteSpace(txtTenKhachHang.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(txtSDT.Text.Trim(), out long intDienThoai) || intDienThoai <= 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại hợp lệ, số nguyên dương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }

            DTO_KhachHang kh = new DTO_KhachHang("", txtTenKhachHang.Text, txtDiaChi.Text, txtSDT.Text); // Assuming MaKH is auto-generated in DB
            if (busKH.InsertKhach(kh))
            {
                MessageBox.Show("Thêm thành công");
                ResetValues();
                LoadGridView_Khach(); // refresh DataGridView
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (busKH.DeleteKhach(selectedMaKH))
                {
                    MessageBox.Show("Xóa thành công");
                    ResetValues();
                    LoadGridView_Khach(); // refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frm_DanhSachKH_Load(object sender, EventArgs e)
        {

        }

        private void txtLocSDT_TextChanged(object sender, EventArgs e)
        {
            btnLoc.Enabled = true;
        }

        private void dtgDanhSachKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgDanhSachKH.Rows[e.RowIndex];
                selectedMaKH = row.Cells[0].Value.ToString();
                txtTenKhachHang.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtSDT.Text = row.Cells[3].Value.ToString();
                btnChiTietKhachHang.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string soDT = txtLocSDT.Text;
            DataTable ds = busKH.TimKhachHang(soDT);
            if (ds.Rows.Count > 0)
            {
                dtgDanhSachKH.DataSource = ds;
                dtgDanhSachKH.Columns[0].HeaderText = "Mã KH";
                dtgDanhSachKH.Columns[1].HeaderText = "Họ và Tên";
                dtgDanhSachKH.Columns[2].HeaderText = "Địa Chỉ";
                dtgDanhSachKH.Columns[3].HeaderText = "SDT";
                /*dtgDanhSachKH.Columns[4].Visible = false;*/
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng nào phù hợp tiêu chí tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLocSDT.Focus();
            }
            txtLocSDT.Text = "Nhập số điện thoại khach hàng";
            txtLocSDT.BackColor = Color.LightGray;
            ResetValues();
        }
    }
}
