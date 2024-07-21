using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLGame;
using System.Security.Policy;

namespace DAL_QLGame
{
    public class DAL_ChiTietKhachHang
    {
        public static bool UpdateKhachHang(string maKH, string tenKH, string diaChi, string sdt, string email, int trangThai)
        {
            try
            {
                using (SqlConnection con = DataAccess.connect())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UpdateKhachHang", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@MaKH", maKH);
                        cmd.Parameters.AddWithValue("@TenKH", tenKH);
                        cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                        cmd.Parameters.AddWithValue("@SDT", sdt);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Trả về true nếu cập nhật thành công

                    }
                }


            }
               catch (Exception ex)
            {
                // Xử lý ngoại lệ (nếu có)
                Console.WriteLine("đã xảy ra lỗi: " + ex.Message);
                return false;
            }

        }
    }
}
