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
    public partial class frm_QuanLyNhanVien : Form
    {
        private BUS_Nhanvien busNhanVIen = new BUS_Nhanvien();
        public frm_QuanLyNhanVien()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgv_nv.DataSource = busNhanVIen.getNhanVien();
            dgv_nv.Columns[0].HeaderText = "Mã Nhân Viên";
            dgv_nv.Columns[1].HeaderText = "Tên Nhân Viên";
            dgv_nv.Columns[2].HeaderText = "Email";
            dgv_nv.Columns[3].HeaderText = "Ngày sinh";
            dgv_nv.Columns[4].HeaderText = "CCCD";
            dgv_nv.Columns[5].HeaderText = "Số Điện Thoại";
            dgv_nv.Columns[6].HeaderText = "Phái";
            dgv_nv.Columns[7].HeaderText = "Chức vụ";
            dgv_nv.Columns[8].HeaderText = "Địa Chỉ";
            dgv_nv.Columns[9].HeaderText = "Mật Khẩu";

        }
        private void frm_QuanLyNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void dgv_nv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_nv.Rows.Count >= 0)
            {
                DataGridViewRow row = dgv_nv.Rows[e.RowIndex];
                txt_email.Text = row.Cells["Email"].Value.ToString();
                txt_manv.Text = row.Cells["MaNV"].Value.ToString();
                txt_tennv.Text = row.Cells["TenNV"].Value.ToString();
                dt_ngaysinh.Text = row.Cells["NgaySinh"].Value.ToString();
                txt_cccd.Text = row.Cells["CCCD"].Value.ToString();
                txt_sdt.Text = row.Cells["SDT"].Value.ToString();
                txt_chucvu.Text = row.Cells["ChucVu"].Value.ToString();
                txt_diachi.Text = row.Cells["DiaChi"].Value.ToString();
                //txt_email.Text = row.Cells["Email"].Value.ToString();
                //Conf nam nữ   
                //    if (int.Parse(dgv_nv.CurrentRow.Cells["Phai"].Value.ToString()) == 1)
                //        rdbNam.Checked = true;
                //}
                //else { rdbNu.Checked = true; }  
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txt_email.Text = null;
            txt_tennv.Text = null;
            txt_diachi.Text = null;
            txt_manv.Text = null;
            dt_ngaysinh.Text = null;
            txt_cccd.Text = null;
            txt_sdt.Text = null;
            txt_chucvu.Text = null;

            txt_tennv.Enabled = true;
            txt_manv.Enabled = true;
            txt_email.Enabled = true;
            dt_ngaysinh.Enabled = true;
            txt_diachi.Enabled = true;
            txt_chucvu.Enabled = true;
            txt_cccd.Enabled = true;
            txt_sdt.Enabled = true;

            rdbNam.Enabled = true;
            rdbNu.Enabled = true;
            btn_luu.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txt_tennv.Focus();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tennv.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_tennv.Focus();
                    return;
                }
                  else  if (txt_cccd.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập căn cước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_tennv.Focus();
                    return;
                }
                else if (txt_email.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_diachi.Focus();
                    return;
                }

                else if (txt_sdt.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_tennv.Focus();
                    return;
                }

                else if (txt_diachi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_diachi.Focus();
                    return;
                }

                else if (txt_chucvu.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_tennv.Focus();
                    return;
                }

                //if (chkQuanTri.Checked == false && chkNhanVien.Checked == false)
                //{
                //    MessageBox.Show("Bạn phải nhập tình trạng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    txtTenNV.Focus();
                //    return;
                //}
                //   else
                //   {
                //       // Tạo 1 DTO
                //       DTO_NhanVien nv = new DTO_NhanVien ( txt_tennv.Text,  dt_ngaysinh.Text,  txt_email.Text,
                //cCCD,  sDT,  diaChi,  chucVu, strng matKhau,  trangThai)

                //       if (busNV.InsertNhanVien(nv))
                //       {
                //           MessageBox.Show("Thêm thành công");
                //           ResetValues();
                //           LoadGridView_NhanVien();
                //           SendMail(nv.EmailNv);
                //       }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
                //      }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lõi " + ex);
            }
        }
    //} 
        private void ResetValues()
        {
            txt_email.Text = null;
            txt_tennv.Text = null;
            txt_diachi.Text = null;
            txt_manv.Text = null;
            dt_ngaysinh.Text = null;
            txt_cccd.Text = null;
            txt_sdt.Text = null;
            txt_chucvu.Text = null;

            txt_tennv.Enabled = true;
            txt_manv.Enabled = true;
            txt_email.Enabled = true;
            dt_ngaysinh.Enabled = true;
            txt_diachi.Enabled = true;
            txt_chucvu.Enabled = true;
            txt_cccd.Enabled = true;
            txt_sdt.Enabled = true;

            rdbNam.Enabled = true;
            rdbNu.Enabled = true;
            btn_luu.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            if (MessageBox.Show("Bạn có chắc muốn xoá dữ liệu", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DTO_NhanVien nhanVien = new DTO_NhanVien();
                nhanVien.email = email;

                if (busNhanVIen.DeleteNhanVien(nhanVien))
                {
                    MessageBox.Show("Xoá thành công");
                    ResetValues();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xoá không thành công");
                }
            }
            else
            {
                ResetValues();
            }
        }
    }
}
