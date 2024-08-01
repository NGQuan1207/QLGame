using BUS_QLGame;
using DTO_QLGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLGame
{
    public partial class Frm_LenDon : Form
    {

        public event EventHandler<DTO_HoaDon> HoaDonAdded;
        private BUS_LenDon lendon = new BUS_LenDon();
        private BUS_ChiTietSanPham chitietSP = new BUS_ChiTietSanPham();
        private frm_chu frmInFor = new frm_chu();

        public Frm_LenDon()
        {
            InitializeComponent();
            Load += Frm_LenDon_Load;
        }

        private void LoadGridView_SanPham()
        {
            DataTable dtSanPham = lendon.Getsanpham();
            DataTable dtChiTiet = chitietSP.GetChiTietSanPham();

            dtSanPham.Columns.Add("SoLuong", typeof(int));

            foreach (DataRow rowSP in dtSanPham.Rows)
            {
                DataRow[] rowsChiTiet = dtChiTiet.Select($"MaSP = '{rowSP["MaSP"]}'");
                if (rowsChiTiet.Length > 0)
                {
                    rowSP["SoLuong"] = rowsChiTiet[0]["SoLuong"];
                }
            }

            dgv_SanphamLenDon.DataSource = dtSanPham;

            // Check and add columns if not exist
            AddColumnIfNotExist(dgv_SanphamLenDon, "MaSP", "Mã SP");
            AddColumnIfNotExist(dgv_SanphamLenDon, "TenSP", "Tên SP");
            AddColumnIfNotExist(dgv_SanphamLenDon, "LoaiSP", "Loại SP");
            AddColumnIfNotExist(dgv_SanphamLenDon, "HinhAnh", "Hình ảnh");
            AddColumnIfNotExist(dgv_SanphamLenDon, "GhiChu", "Ghi chú");
            AddColumnIfNotExist(dgv_SanphamLenDon, "SoLuong", "Số Lượng");
        }

        private void AddColumnIfNotExist(DataGridView dgv, string columnName, string headerText)
        {
            if (!dgv.Columns.Contains(columnName))
            {
                dgv.Columns.Add(columnName, headerText);
            }
        }

        private void LoadGridviewGioHang()
        {
            if (dgv_GioHang.Columns.Count == 0)
            {
                dgv_GioHang.Columns.Add("MaSP", "Mã SP");
                dgv_GioHang.Columns.Add("TenSP", "Tên SP");
                dgv_GioHang.Columns.Add("LoaiSP", "Loại SP");
                dgv_GioHang.Columns.Add("Gia", "Giá");
                dgv_GioHang.Columns.Add("SoLuong", "Số Lượng");
                dgv_GioHang.Columns.Add("ThanhTien", "Thành Tiền");

                // Add column for decreasing quantity
                DataGridViewButtonColumn btnGiamSoLuong = new DataGridViewButtonColumn
                {
                    HeaderText = "Giảm",
                    Name = "Giảm",
                    Text = "-",
                    UseColumnTextForButtonValue = true
                };
                dgv_GioHang.Columns.Add(btnGiamSoLuong);
            }
        }

        private void Frm_LenDon_Load(object sender, EventArgs e)
        {
            LoadGridView_SanPham();
            LoadGridviewGioHang();
            UpdateTongTien();
        }

       

       

        private void UpdateTongTien()
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dgv_GioHang.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    tongTien += decimal.Parse(row.Cells["ThanhTien"].Value.ToString());
                }
            }

            txt_TongTien.Text = tongTien.ToString("N0");
        }

        private void btn_LenDon_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_KhachHang khachHang = new DTO_KhachHang
                {
                    TenKH = txt_tenKH.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text
                };

                DTO_HoaDon hoaDon = new DTO_HoaDon
                {
                    MaNV = txt_maNV.Text,
                    NgayLap = date_Ngay.Value
                };

                // Validate and convert ThanhTien
                if (decimal.TryParse(txt_TongTien.Text, out decimal thanhTien))
                {
                    hoaDon.ThanhTien = thanhTien;
                }
                else
                {
                    MessageBox.Show("Giá trị tổng tiền không hợp lệ.");
                    return; // Exit if conversion fails
                }

                string maKH = InsertKhachHang(khachHang);
                if (!string.IsNullOrEmpty(maKH))
                {
                    hoaDon.MaKH = maKH;
                    bool result = ThemHoaDon(hoaDon);
                    if (result)
                    {
                        MessageBox.Show("Hóa đơn và khách hàng đã được thêm thành công.");
                        HoaDonAdded?.Invoke(this, hoaDon); // Raise event if needed
                    }
                    else
                    {
                        MessageBox.Show("Thêm hóa đơn thất bại.");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
            ShowDanhSachKH();
            /*ShowHoaDon();*/
        }
        private void ShowDanhSachKH()
        {
            // Tạo và hiển thị frm_DanhSachKH
            frm_DanhSachKH danhSachKH = new frm_DanhSachKH();
            danhSachKH.Show(); // hoặc ShowDialog() nếu bạn muốn form này là modal
        }

        private void ShowHoaDon()
        {
            // Tạo và hiển thị frm_HoaDon
            Frm_HoaDon hoaDonForm = new Frm_HoaDon();
            hoaDonForm.Show(); // hoặc ShowDialog() nếu bạn muốn form này là modal
        }


        private string InsertKhachHang(DTO_KhachHang kh)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LOIBACH\\NVB;Initial Catalog=QL_ThietBiGame;Integrated Security=True;Encrypt=False"))
                {
                    SqlCommand cmd = new SqlCommand("InsertKhachHang", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@tenkh", kh.TenKH);
                    cmd.Parameters.AddWithValue("@diachi", kh.DiaChi);
                    cmd.Parameters.AddWithValue("@sdt", kh.SDT);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm khách hàng: {ex.Message}");
                return null;
            }
        }

        private bool ThemHoaDon(DTO_HoaDon hd)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LOIBACH\\NVB;Initial Catalog=QL_ThietBiGame;Integrated Security=True;Encrypt=False"))
                {
                    conn.Open();

                    // Check if MaNV exists
                    SqlCommand checkMaNV = new SqlCommand("SELECT COUNT(*) FROM NhanVien WHERE MaNV = @manv", conn);
                    checkMaNV.Parameters.AddWithValue("@manv", hd.MaNV);
                    int nvExists = (int)checkMaNV.ExecuteScalar();
                    if (nvExists == 0)
                    {
                        MessageBox.Show("Nhân viên không tồn tại.");
                        return false;
                    }

                    SqlCommand cmd = new SqlCommand("ThemHoaDon", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@makh", hd.MaKH);
                    cmd.Parameters.AddWithValue("@manv", hd.MaNV);
                    cmd.Parameters.AddWithValue("@ngaylap", hd.NgayLap);
                    cmd.Parameters.AddWithValue("@thanhtien", hd.ThanhTien);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm hóa đơn: {ex.Message}");
                return false;
            }
        }

        // Placeholder event handlers
        private void date_Ngay_ValueChanged(object sender, EventArgs e) { }
        private void txt_maNV_TextChanged(object sender, EventArgs e) { }
        private void txt_TongTien_TextChanged(object sender, EventArgs e) { }

        private void btn_LenDon_Click_1(object sender, EventArgs e)
        {

            try
            {
                DTO_KhachHang khachHang = new DTO_KhachHang
                {
                    TenKH = txt_tenKH.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text
                };

                DTO_HoaDon hoaDon = new DTO_HoaDon
                {
                    MaNV = txt_maNV.Text,
                    NgayLap = date_Ngay.Value
                };

                // Validate and convert ThanhTien
                if (decimal.TryParse(txt_TongTien.Text, out decimal thanhTien))
                {
                    hoaDon.ThanhTien = thanhTien;
                }
                else
                {
                    MessageBox.Show("Giá trị tổng tiền không hợp lệ.");
                    return; // Exit if conversion fails
                }

                string maKH = InsertKhachHang(khachHang);
                if (!string.IsNullOrEmpty(maKH))
                {
                    hoaDon.MaKH = maKH;
                    bool result = ThemHoaDon(hoaDon);
                    if (result)
                    {
                        MessageBox.Show("Hóa đơn và khách hàng đã được thêm thành công.");
                        HoaDonAdded?.Invoke(this, hoaDon); // Raise event if needed
                    }
                    else
                    {
                        MessageBox.Show("Thêm hóa đơn thất bại.");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
            ShowDanhSachKH();
            /*ShowHoaDon();*/
        }

        private void dgv_SanphamLenDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_SanphamLenDon.Rows[e.RowIndex];
                string maSP = row.Cells["MaSP"].Value?.ToString();
                string tenSP = row.Cells["TenSP"].Value?.ToString();
                string loaiSP = row.Cells["LoaiSP"].Value?.ToString();
                int soLuongSanPham = int.Parse(row.Cells["SoLuong"].Value?.ToString());

                if (maSP != null && tenSP != null && loaiSP != null)
                {
                    DataTable dt = chitietSP.GetChiTietSanPham();
                    DataRow[] selectedRows = dt.Select($"MaSP = '{maSP}'");

                    if (selectedRows.Length > 0)
                    {
                        string gia = selectedRows[0]["Gia"].ToString();
                        bool exists = false;

                        foreach (DataGridViewRow r in dgv_GioHang.Rows)
                        {
                            if (r.Cells["MaSP"].Value != null && r.Cells["MaSP"].Value.ToString() == maSP)
                            {
                                int currentQuantity = int.Parse(r.Cells["SoLuong"].Value.ToString());
                                if (currentQuantity < soLuongSanPham)
                                {
                                    r.Cells["SoLuong"].Value = (currentQuantity + 1).ToString();
                                    r.Cells["ThanhTien"].Value = (currentQuantity + 1) * decimal.Parse(gia);
                                }
                                else
                                {
                                    MessageBox.Show("Số lượng trong giỏ hàng không được vượt quá số lượng hiện có.");
                                }
                                exists = true;
                                break;
                            }
                        }

                        if (!exists)
                        {
                            if (soLuongSanPham > 0)
                            {
                                dgv_GioHang.Rows.Add(maSP, tenSP, loaiSP, gia, "1", gia);
                            }
                            else
                            {
                                MessageBox.Show("Sản phẩm đã hết hàng.");
                            }
                        }

                        UpdateTongTien();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy giá cho sản phẩm đã chọn.");
                    }
                }
                else
                {
                    MessageBox.Show("Không thể lấy thông tin sản phẩm. Vui lòng thử lại.");
                }
            }
        }

        private void dgv_GioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_GioHang.Columns["Giảm"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_GioHang.Rows[e.RowIndex];
                int currentQuantity = int.Parse(row.Cells["SoLuong"].Value.ToString());

                if (currentQuantity > 1)
                {
                    row.Cells["SoLuong"].Value = (currentQuantity - 1).ToString();
                    row.Cells["ThanhTien"].Value = (currentQuantity - 1) * decimal.Parse(row.Cells["Gia"].Value.ToString());
                }
                else
                {
                    dgv_GioHang.Rows.RemoveAt(e.RowIndex);
                }

                UpdateTongTien();
            }
        }

        private void btn_ApDung_Click(object sender, EventArgs e)
        {

        }
    }
}
