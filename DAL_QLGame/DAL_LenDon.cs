using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLGame;

namespace DAL_QLGame
{
    public class DAL_LenDon : Connect
    {
        DAL_KhachHang dalKH = new DAL_KhachHang();
        public bool InsertKhachHang(DTO_KhachHang khach)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "InsertKhachHang",
                    Connection = _conn
                };
                cmd.Parameters.AddWithValue("@TenKH", khach.TenKH);
                cmd.Parameters.AddWithValue("@DiaChi", khach.DiaChi);
                cmd.Parameters.AddWithValue("@SDT", khach.SDT);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable Getsanpham()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "listSP",
                    Connection = _conn
                };
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }
        public decimal GetTong()
        {
            decimal tong = 0;
            using (SqlConnection conn = new SqlConnection("Data Source=DUONGPX;Initial Catalog=QL_ThietBiGame1234;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand("Tong", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    tong = (decimal)cmd.ExecuteScalar();
                }
            }
            return tong;
        }
        public bool ThemHoaDon(DTO_HoaDon hd, string tenkh, string diachi, string sdt)
        {
            using (SqlCommand cmd = new SqlCommand("ThemHoaDon", _conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@manv", hd.MaNV);
                cmd.Parameters.AddWithValue("@ngaylap", hd.NgayLap);
                cmd.Parameters.AddWithValue("@thanhtien", hd.ThanhTien);
                /*                cmd.Parameters.AddWithValue("@tenkh", tenkh);
                                cmd.Parameters.AddWithValue("@diachi", diachi);
                                cmd.Parameters.AddWithValue("@sdt", sdt);*/

                try
                {
                    _conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    _conn.Close();
                }
            }
        }
    }
}