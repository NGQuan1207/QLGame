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
    public class DAL_BaoHanh : Connect
    {
        public DataTable LoadListBaoHanh()
        {
            using (_conn)
            {
                SqlCommand cmd = new SqlCommand("DanhSachBaoHanh", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable ListKH = new DataTable();
                try
                {
                    _conn.Open();
                    ListKH.Load(cmd.ExecuteReader());
                }
                catch (Exception ex)    
                {
                    throw new Exception("Có lỗi xảy ra: " + ex.Message);
                }
                finally
                {
                    _conn.Close();
                }
                return ListKH;
            }
        }

        public DataTable TimBaoHanh(string tim)
        {
            using (_conn)
            {
                SqlCommand cmd = new SqlCommand("TimKiemBaoHanh", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kiem", tim);
                DataTable TimNV = new DataTable();
                try
                {
                    _conn.Open();
                    TimNV.Load(cmd.ExecuteReader());
                }
                catch (Exception ex)
                {
                    throw new Exception("Có lỗi xảy ra: " + ex.Message);
                }
                finally
                {
                    _conn.Close();
                }
                return TimNV;
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

        public bool ThemBaoHanh(DTO_BaoHanh baohanh)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaSP", baohanh.MaSP),
                new SqlParameter("@MaKH", baohanh.MaKH),
                new SqlParameter("@startdate", baohanh.Startdate),
                new SqlParameter("@enddate", baohanh.Enddate),
                new SqlParameter("@TinhTrang", baohanh.TinhTrang)
            };
            return Execute("ThemBaoHanh", parameters);
        }

        public bool XoaBaoHanh(string mabaohanh)
        {
            return Execute("XoaBaohanh", new SqlParameter("@mabaohanh", mabaohanh));
        }

        public bool SuaBaoHanh(string mabaohanh, string masp, string makh, string startdate, string enddate, string tinhtrang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "SuaBaoHanh",
                    Connection = _conn
                };
                cmd.Parameters.AddWithValue("@mabaohanh", mabaohanh);
                cmd.Parameters.AddWithValue("@Masp", masp);

                cmd.Parameters.AddWithValue("@makh", makh);
                cmd.Parameters.AddWithValue("@startdate", startdate);
                cmd.Parameters.AddWithValue("@enddate", enddate);
                cmd.Parameters.AddWithValue("@tinhtrang", tinhtrang);

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

