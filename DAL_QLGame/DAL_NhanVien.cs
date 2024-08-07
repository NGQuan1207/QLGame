using DTO_QLGame;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace DAL_QLGame
{
    public class DAL_NhanVien : Connect
    {
        public bool NhanVienDangNhap(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("DangNhap", _conn);
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DangNhap";
                cmd.Parameters.AddWithValue("Email", nv.email);
                cmd.Parameters.AddWithValue("MatKhau", nv.matkhau);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool NhanVienQuenMatKhau(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "QuenMatKhau";
                cmd.Parameters.AddWithValue("Email", email);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }

        public bool TaoMatKhau(string email, string matKhauMoi)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TaoMatKhauMoi";
                cmd.Parameters.AddWithValue("Email", email);
                cmd.Parameters.AddWithValue("MatKhau", matKhauMoi);

                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { _conn.Close(); }
            return false;
        }
        public DataTable GetNhanVienByEmail(string email)
        {

            try
            {
                _conn.Open();
                //connection = new SqlConnection(_conn);
                SqlCommand command = new SqlCommand("LayThongTinNhanVien", _conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@email", email);
                SqlDataAdapter adt = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                // Log the exception (optional)
                throw new ApplicationException("Lỗi khi lấy thông tin nhân viên: " + ex.Message);
            }
            finally
            {
                if (_conn != null && _conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }

        }



        public bool ValidateUser(string email, string password)
        {

            try
            {
                _conn.Open();
                string query = "SELECT COUNT(1) FROM NhanVien WHERE Email = @email";
                SqlCommand command = new SqlCommand(query, _conn);
                command.Parameters.AddWithValue("@Email", email);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count == 1;
            }
            catch (Exception ex)
            {
                // Log the exception (optional)
                throw new ApplicationException("Lỗi khi xác thực người dùng: " + ex.Message);
            }
            finally
            {
                if (_conn != null && _conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }

        public bool InsertNhanVien(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "themNhanVien";
                cmd.Parameters.AddWithValue("@TenNV", nv.Tennv);
                cmd.Parameters.AddWithValue("@Phai", nv.phai);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.ngaysinh);
                cmd.Parameters.AddWithValue("@EmaiL", nv.email);
                cmd.Parameters.AddWithValue("@CCCD", nv.cccd);
                cmd.Parameters.AddWithValue("@SDT", nv.sdt);
                cmd.Parameters.AddWithValue("@DiaChi", nv.diachi);
                cmd.Parameters.AddWithValue("@ChucVu", nv.chucvu);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { _conn.Close(); }
        }

        public bool UpdateNhanVien(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "suaNhanVien";
                cmd.Parameters.AddWithValue("@MaNV", nv.Manv);
                cmd.Parameters.AddWithValue("@TenNV", nv.Tennv);
                cmd.Parameters.AddWithValue("@Phai", nv.phai);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.ngaysinh);
                cmd.Parameters.AddWithValue("@CCCD", nv.cccd);
                cmd.Parameters.AddWithValue("@SDT", nv.sdt);
                cmd.Parameters.AddWithValue("@DiaChi", nv.diachi);
                cmd.Parameters.AddWithValue("@ChucVu", nv.chucvu);
                
                //cmd.Parameters.AddWithValue("MatKhau", nv.matkhau);
                //cmd.Parameters.AddWithValue("TrangThai", nv.trangthai);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool DeleteNhanVien(string id)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "xoaNhanVien";
                cmd.Parameters.AddWithValue("@MaNV", id);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                
            }
            finally { _conn.Close(); }
            return false;
        }

        public bool SreachNhanVien(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "timKiemNhanVien";
                cmd.Parameters.AddWithValue("MaNV", nv.Manv);
                cmd.Parameters.AddWithValue("TenNV", nv.Tennv);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            finally { _conn.Close(); }
        }

        public DataTable getNhanVien()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = "listNhanVien";
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }
        }
        public bool UpdateMatKhau(string email, string matkhaucu, string matkhaumoi)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = "ThayDoimatKhau";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Email", email);
                cmd.Parameters.AddWithValue("@opwd", matkhaucu);
                cmd.Parameters.AddWithValue("@npwd", matkhaumoi);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            finally { _conn.Close(); }
        }

    }
}
