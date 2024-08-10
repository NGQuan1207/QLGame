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
    public partial class Frm_DangNhap_GU : Form
    {
        BUS_Nhanvien busnv = new BUS_Nhanvien();
        private bool isPasswordHidden = true;
        public string vaitro { get; set; }
        public static string mail;
        public Frm_DangNhap_GU()
        {
            InitializeComponent();
            txt_matkhau.UseSystemPasswordChar = false;

            pb_matkhau.Image = Image.FromFile("img/hide.png");
            //pb_matkhau.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void Frm_DangNhap_GU_Load(object sender, EventArgs e)
        {
            guna2Panel1.BackColor = Color.FromArgb(150,0,0,0);


            btn_quenmatkhau.FillColor = Color.FromArgb(170, 0, 0, 0);
            btn_dangnhap.FillColor = Color.FromArgb(170, 0, 0, 0);
            txt_ID.BackColor = Color.FromArgb(200, 0, 0, 0);
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_NhanVien nv = new DTO_NhanVien();
                nv.email = txt_ID.Text;
                nv.matkhau = busnv.encryption(txt_matkhau.Text);
                mail = nv.email;

                if (busnv.NhanVienDangNhap(nv)) // successfull login
                {
                    //login = true
                    Frm_Main.mail = nv.email; // truyền email đăng nhập cho frmMain
                    DataTable dt = busnv.VaiTroNhanVien(nv.email);
                    vaitro = dt.Rows[0][0].ToString();  // lấy vai trò của nhân viên, hiển thị các chức năng mã nhân viên có thể thao tác
                    Frm_Main.session = 1; // cập nhật trạng thái đã đăng nhập thành công
                    this.Close();
                    MessageBox.Show("Đăng nhập thành công", "Thông Báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công, kiểm tra lại email hoặc mật khẩu", "Thông Báo");
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


        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_quenmatkhau_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text != "")
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
                    MessageBox.Show("Email không tồn tại, vui lòng nhập lại email", "Thông Báo");

                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập email nhận thông tin hồi phục mật khẩu", "Thông Báo");
            }
        }

        private void pb_matkhau_Click(object sender, EventArgs e)
        {
            if (isPasswordHidden)
            {
                txt_matkhau.UseSystemPasswordChar = true;
                pb_matkhau.Image = Image.FromFile("img/view.png");
            }
            else
            {
                txt_matkhau.UseSystemPasswordChar = false;
                pb_matkhau.Image = Image.FromFile("img/hide.png");
            }
            isPasswordHidden = !isPasswordHidden;

        }
    }
}
