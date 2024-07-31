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

    public class DAL_SanPhamThue : Connect
    {

        public DataTable LoadListSanPham()
        {
            using (_conn)
            {
                SqlCommand cmd = new SqlCommand("DanhSachSanPhamThue", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable ListSPT = new DataTable();
                try
                {
                    _conn.Open();
                    ListSPT.Load(cmd.ExecuteReader());
                }
                catch (Exception ex)
                {
                    throw new Exception("Có lỗi xảy ra: " + ex.Message);
                }
                finally
                {
                    _conn.Close();
                }
                return ListSPT;
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

        public bool ThemSanPhamThue(DTO_SanPhamThue sanphamthue)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaSPThue", sanphamthue.MaSPT),
                new SqlParameter("@TenSPThue", sanphamthue.TenSPT),
                new SqlParameter("@LoaiSP", sanphamthue.Loaisp),
                new SqlParameter("@Hinhanh",sanphamthue.Hinhanh),
                new SqlParameter("@ghichu", sanphamthue.GhiChu),

            };
            return Execute("ThemSanPhamThue", parameters);

        }

        public bool XoaSanPhamThue(string masanphamthue)
        {
            return Execute("XoaSanPhamThue", new SqlParameter("@maspthue", masanphamthue));
        }

        public bool SuaSanPhamThue(string maspt, string tenspt, string loaisp, string hinhanh, string ghichu)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "SuaSanPhamThue",
                    Connection = _conn
                };

                cmd.Parameters.AddWithValue("@MaSPThue", maspt);
                cmd.Parameters.AddWithValue("@tenSPThue", tenspt);
                cmd.Parameters.AddWithValue("@loaisp", loaisp);
                cmd.Parameters.AddWithValue("@HinhAnh", hinhanh);
                cmd.Parameters.AddWithValue("@GhiChu", ghichu);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                return true;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable TimSanPhamThue(string tim)
        {
            using (_conn)
            {
                SqlCommand cmd = new SqlCommand("TimKiemSanPhamThue", _conn);
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
