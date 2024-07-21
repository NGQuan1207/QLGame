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
using BUS_QLGame;
using DTO_QLGame;

namespace GUI_QLGame
{
    public partial class Frm_DangNhap : Form
    {
        BUS_Nhanvien busnv = new BUS_Nhanvien();

        public string vaitro {  get; set; }
        public Frm_DangNhap()
        {
            //pb_logo.BackColor = Color.Transparent;
            InitializeComponent();
        }

        private void Frm_DangNhap_Load(object sender, EventArgs e)
        {
            //Fm_Main.session = 0; // not yet login

        }

        private void lbl_tennhom_Click(object sender, EventArgs e)
        {

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_NhanVien nv = new DTO_NhanVien();
                nv.email = txt_ID.Text;
                nv.matkhau = busnv.encryption(txt_matkhau.Text);

                if (busnv.NhanVienDangNhap(nv)) // successfull login
                {
                    ////login = true
                    //FmMain. = nv.EmailNv; // truyền email đăng nhập cho frmMain
                    //DataTable dt = busNV.VaiTroNhanVien(nv.EmailNv);
                    //vaitro = dt.Rows[0][0].ToString();  // lấy vai trò của nhân viên, hiển thị các chức năng mã nhân viên có thể thao tác
                    //MessageBox.Show("Đăng nhập thành công");
                    //FmMain.session = 1; // cập nhật trạng thái đã đăng nhập thành công
                    //this.Close();
                    MessageBox.Show("Đăng nhập thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công, kiểm tra lại email hoặc mật khẩu");
                    txt_ID.Text = null;
                    txt_matkhau.Text = null;
                    txt_ID.Focus();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi" + ex);
            }

        }
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
            {
                return builder.ToString().ToLower();
            }
            return builder.ToString();
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }


        public void SendMail(string email, string matkhau)
        {
            try
            {
                MailMessage Msg = new MailMessage();
                Msg.Body = "Chào anh/ chị. Mật khẩu mới: " + matkhau;
                Msg.To.Add(email);
                Msg.From = new MailAddress("baoquy1400@gmail.com");
                Msg.Subject = "Bạn đã sử dụng tính năng quên mật khẩu";

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


        private void btn_quenmatkhau_Click(object sender, EventArgs e)
        {
            if(txt_ID.Text != "")
            {
                if (busnv.NhanVienQuenMatKhau(txt_ID.Text))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(RandomString(4, true));
                    builder.Append(RandomNumber(1000, 9999));
                    builder.Append(RandomString(2, false));
                    string matkhaumoi = busnv.encryption(builder.ToString());
                    busnv.TaoMatKhau(txt_ID.Text, matkhaumoi);
                    SendMail(txt_ID.Text, builder.ToString());
                }
                else
                {
                    MessageBox.Show("Email không tồn tại, vui lòng nhập lại email");
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập email nhận thông tin hồi phục mật khẩu");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {

        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
