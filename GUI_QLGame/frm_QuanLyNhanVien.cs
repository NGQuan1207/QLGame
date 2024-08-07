using BUS_QLGame;
using DTO_QLGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
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
            dgv_nv.Columns[2].HeaderText = "Phái";
            dgv_nv.Columns[3].HeaderText = "Ngày sinh";
            dgv_nv.Columns[4].HeaderText = "Email";
            dgv_nv.Columns[5].HeaderText = "CCCD";
            dgv_nv.Columns[6].HeaderText = "Số Điện Thoại";
            dgv_nv.Columns[7].HeaderText = "Địa Chỉ";
            dgv_nv.Columns[8].HeaderText = "Chức vụ";
        }
        private void frm_QuanLyNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void dgv_nv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_nv.Rows.Count >= 0)
            {
                DataGridViewRow row = dgv_nv.Rows[e.RowIndex];
                txt_manv.Text = row.Cells["MaNV"].Value.ToString();
                txt_tennv.Text = row.Cells["TenNV"].Value.ToString();
                txt_ngaysinh.Text = row.Cells["NgaySinh"].Value.ToString();
                txt_email.Text = row.Cells["Email"].Value.ToString();
                txt_cccd.Text = row.Cells["CCCD"].Value.ToString();
                txt_sdt.Text = row.Cells["SDT"].Value.ToString();
                txt_chucvu.Text = row.Cells["ChucVu"].Value.ToString();
                txt_diachi.Text = row.Cells["DiaChi"].Value.ToString();
                //txt_email.Text = row.Cells["Email"].Value.ToString();
                //Conf nam nữ   
                if (dgv_nv.CurrentRow.Cells["Phai"].Value.ToString() == "Nam")
                {
                    rdbNam.Checked = true;
                    } else
                    {
                        rdbNu.Checked = true;
                        }

                    }
                }


        private void btnThem_Click(object sender, EventArgs e)
        {
            txt_email.Text = null;
            txt_tennv.Text = null;
            txt_diachi.Text = null;
            txt_manv.Text = null;
            txt_ngaysinh.Text = null;
            txt_cccd.Text = null;
            txt_sdt.Text = null;
            txt_chucvu.Text = null;

            txt_tennv.Enabled = true;
            txt_manv.Enabled = false;
            txt_email.Enabled = true;
            txt_ngaysinh.Enabled = true;
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
                string gioitinh = "";
                if (rdbNam.Checked)
                {
                    gioitinh = "Nam";
                }
                if (txt_tennv.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_tennv.Focus();
                    return;
                }
                else if (txt_cccd.Text.Trim().Length == 0)
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
                else
                {
                   // Tạo 1 DTO
                               DTO_NhanVien nv = new DTO_NhanVien( txt_tennv.Text, gioitinh, txt_ngaysinh.Text, txt_email.Text,
                        txt_cccd.Text, txt_sdt.Text, txt_diachi.Text, txt_chucvu.Text);

                    if (busNhanVIen.InsertNhanVien(nv))
                    {
                        MessageBox.Show("Thêm thành công");
                        ResetValues();
                        LoadData();
                        SendMail(nv.email);
                    }
                    else
                    {
                        MessageBox.Show("Thêm ko thành công");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lõi " + ex);
                //     }
            }
         }
        public void SendMail(string email)
        {
            try
            {
                MailMessage Msg = new MailMessage();
                Msg.To.Add(email);
                Msg.From = new MailAddress("baoquy1400@gmail.com");
                Msg.Subject = "Bạn đã sử dụng tính năng thêm nhân viên";

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;

                client.Credentials = new NetworkCredential("tuongdgps38065@gmail.com", "bkgi fhuh sscy dcog");
                client.Send(Msg);
                MessageBox.Show("Gửi mail thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //} 
        private void ResetValues()
        {
            txt_email.Text = null;
            txt_tennv.Text = null;
            txt_diachi.Text = null;
            txt_manv.Text = null;
            txt_ngaysinh.Text = null;
            txt_cccd.Text = null;
            txt_sdt.Text = null;
            txt_chucvu.Text = null;

            txt_tennv.Enabled = true;
            txt_manv.Enabled = true;
            txt_email.Enabled = true;
            txt_ngaysinh.Enabled = true;
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
            string ma = txt_manv.Text;
            if (MessageBox.Show("Bạn có chắc muốn xoá dữ liệu", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                

                if (busNhanVIen.DeleteNhanVien(ma))
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txt_tennv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tennv.Focus();
                return;
            }
            else if (txt_diachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_diachi.Focus();
                return;
            }
            else if (txt_sdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_sdt.Focus();
                return;
            }
            string gioitinh = "";
            if (rdbNam.Checked)
            {
                gioitinh = "Nam";
            }

            DTO_NhanVien nv = new DTO_NhanVien(txt_tennv.Text, gioitinh, txt_ngaysinh.Text, txt_email.Text,
                        txt_cccd.Text, txt_sdt.Text, txt_diachi.Text, txt_chucvu.Text);
            if (MessageBox.Show("Bạn có chắc muốn chỉnh sửa", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busNhanVIen.UpdateNhanVien(nv))
                {
                    MessageBox.Show("Sửa thành công");
                    ResetValues();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Sửa ko thành công");
                }
            }
            else
            {
                ResetValues();
            }
        }
    }
}
