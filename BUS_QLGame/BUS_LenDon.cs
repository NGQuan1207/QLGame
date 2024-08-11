using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLGame;
using DAL_QLGame;
using System.Data;
using System.Data.SqlClient;

namespace BUS_QLGame
{
    public class BUS_LenDon
    {
        private DAL_LenDon dalld = new DAL_LenDon();

        public DataTable Getsanpham()
        {
            return dalld.Getsanpham();
        }
        public decimal GetTong()
        {
            return dalld.GetTong();
        }

        public string CheckIfCustomerExists(string tenKH, string diaChi, string sdt)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DUONGPX;Initial Catalog=QL_ThietBiGame1234;Integrated Security=True;Encrypt=False"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT MaKH FROM KhachHang WHERE TenKH = @tenKH AND DiaChi = @diaChi AND SDT = @sdt", conn);
                    cmd.Parameters.AddWithValue("@tenKH", tenKH);
                    cmd.Parameters.AddWithValue("@diaChi", diaChi);
                    cmd.Parameters.AddWithValue("@sdt", sdt);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
            catch (Exception ex)
            {
                /*MessageBox.Show($"Lỗi khi kiểm tra khách hàng: {ex.Message}");*/
                return null;
            }
        }
    }
}