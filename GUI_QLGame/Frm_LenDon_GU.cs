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
    public partial class Frm_LenDon_GU : Form
    {
        public event EventHandler<DTO_HoaDon> HoaDonAdded;
        private BUS_LenDon lendon = new BUS_LenDon();
        private BUS_ChiTietSanPham chitietSP = new BUS_ChiTietSanPham();
        private frm_chu frmInFor = new frm_chu();
        public Frm_LenDon_GU()
        {
            InitializeComponent();
            Load += Frm_LenDon_GU_Load;
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

        private void Frm_LenDon_GU_Load(object sender, EventArgs e)
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
            // Kiểm tra thông tin bắt buộc
            if (string.IsNullOrEmpty(txt_tenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.");
                return;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.");
                return;
            }
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.");
                return;
            }
            if (dgv_GioHang.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm.");
                return;
            }

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

                if (decimal.TryParse(txt_TongTien.Text, out decimal thanhTien))
                {
                    hoaDon.ThanhTien = thanhTien;
                }
                else
                {
                    MessageBox.Show("Giá trị tổng tiền không hợp lệ.");
                    return;
                }

                string maKH = lendon.CheckIfCustomerExists(khachHang.TenKH, khachHang.DiaChi, khachHang.SDT);
                if (!string.IsNullOrEmpty(maKH))
                {
                    // Khách hàng đã tồn tại
                    hoaDon.MaKH = maKH;
                }
                else
                {
                    // Thêm mới khách hàng
                    maKH = InsertKhachHang(khachHang);
                    if (!string.IsNullOrEmpty(maKH))
                    {
                        hoaDon.MaKH = maKH;
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng thất bại.");
                        return;
                    }
                }

                hoaDon.TenKH = khachHang.TenKH;
                hoaDon.DiaChi = khachHang.DiaChi;
                hoaDon.SDT = khachHang.SDT;

                bool result = ThemHoaDon(hoaDon);
                if (result)
                {
                    MessageBox.Show("Lên đơn thành công.");
                    HoaDonAdded?.Invoke(this, hoaDon);
                    ShowBill(hoaDon);
                    ShowDanhSachKH();
                    ShowHoaDon();
                    // Update product quantity
                    UpdateProductQuantityInGrid();

                    // Add the bill to frm_HoaDon
                    Frm_HoaDon frmHoaDon = Application.OpenForms.OfType<Frm_HoaDon>().FirstOrDefault();
                    if (frmHoaDon != null)
                    {
                        /* frmHoaDon.AddBill(hoaDon);*/
                    }
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
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
        private void UpdateProductQuantityInGrid()
        {
            foreach (DataGridViewRow gioHangRow in dgv_GioHang.Rows)
            {
                if (gioHangRow.Cells["MaSP"].Value != null)
                {
                    string maSP = gioHangRow.Cells["MaSP"].Value.ToString();
                    int quantityInCart = int.Parse(gioHangRow.Cells["SoLuong"].Value.ToString());

                    foreach (DataGridViewRow sanPhamRow in dgv_SanphamLenDon.Rows)
                    {
                        if (sanPhamRow.Cells["MaSP"].Value != null && sanPhamRow.Cells["MaSP"].Value.ToString() == maSP)
                        {
                            int currentQuantity = int.Parse(sanPhamRow.Cells["SoLuong"].Value.ToString());
                            sanPhamRow.Cells["SoLuong"].Value = currentQuantity - quantityInCart;
                            break;
                        }
                    }
                }
            }
        }
        private void ShowBill(DTO_HoaDon hoaDon)
        {
            List<DTO_HoaDon> chiTietHoaDons = new List<DTO_HoaDon>();

            foreach (DataGridViewRow row in dgv_GioHang.Rows)
            {
                if (row.Cells["MaSP"].Value != null)
                {
                    chiTietHoaDons.Add(new DTO_HoaDon
                    {
                        TenSanPham = row.Cells["TenSP"].Value.ToString(),
                        SoLuong = int.Parse(row.Cells["SoLuong"].Value.ToString()),
                        ThanhTien = decimal.Parse(row.Cells["ThanhTien"].Value.ToString())
                    });
                }
            }

            Bill billForm = new Bill();
            billForm.SetBillDetails(hoaDon.TenKH, hoaDon.SDT, hoaDon.DiaChi, chiTietHoaDons);
            billForm.Show();
        }
        private string InsertKhachHang(DTO_KhachHang kh)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DUONGPX;Initial Catalog=QL_ThietBiGame1234;Integrated Security=True;Encrypt=False"))
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
                using (SqlConnection conn = new SqlConnection("Data Source=DUONGPX;Initial Catalog=QL_ThietBiGame1234;Integrated Security=True;Encrypt=False"))
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
    }
}
