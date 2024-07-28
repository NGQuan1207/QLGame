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
    public class DAL_SanPham :Connect
    {

        public DataTable LoadListSanPham()
        {
            using (_conn)
            {
                SqlCommand cmd = new SqlCommand("DanhSachSanPham", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable ListSP = new DataTable();
                try
                {
                    _conn.Open();
                    ListSP.Load(cmd.ExecuteReader());
                }
                catch (Exception ex)
                {
                    throw new Exception("Có lỗi xảy ra: " + ex.Message);
                }
                finally
                {
                    _conn.Close();
                }
                return ListSP;
            }
        }

        public bool Execute(string storedProcedureName, params SqlParameter[] parameters)
        {
            using (_conn)
            {
                SqlCommand cmd = new SqlCommand(storedProcedureName, _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters);
                try
                {
                    _conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Có lỗi xảy ra: " + ex.Message);
                }
                finally
                {
                    _conn.Close();
                }
            }
        }

        public bool ThemSanPham(DTO_SanPham sanpham)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenSp", sanpham.TenSP),
                new SqlParameter("@LoaiSP", sanpham.Loaisp),
                new SqlParameter("@Hinhanh",sanpham.Hinhanh),
                new SqlParameter("@ghichu", sanpham.GhiChu),
               
            };
            return Execute("themsanpham", parameters);
        }

        public bool XoaSanPham(string masanpham)
        {
            return Execute("XoaSanPham", new SqlParameter("@masp",masanpham));
        }

        public bool SuaSanPham(string masp,string tensp, string loaisp, string hinhanh, string ghichu)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "SuaSanPham",
                    Connection = _conn
                };

                cmd.Parameters.AddWithValue("@Masp", masp);
                cmd.Parameters.AddWithValue("@tensp", tensp);
                cmd.Parameters.AddWithValue("@loaisp", loaisp);
                cmd.Parameters.AddWithValue("@HinhAnh", hinhanh);
                cmd.Parameters.AddWithValue("@GhiChu", ghichu);

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

        public DataTable TimSanPham(string tim)
        {
            using (_conn)
            {
                SqlCommand cmd = new SqlCommand("TimKiemSanPham", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kiem", tim);
                DataTable Tim = new DataTable();
                try
                {
                    _conn.Open();
                    Tim.Load(cmd.ExecuteReader());
                }
                catch (Exception ex)
                {
                    throw new Exception("Có lỗi xảy ra: " + ex.Message);
                }
                finally
                {
                    _conn.Close();
                }
                return Tim;
            }
        }
    }
}
