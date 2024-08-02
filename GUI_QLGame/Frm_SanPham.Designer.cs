namespace GUI_QLGame
{
    partial class Frm_SanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_sanpham = new System.Windows.Forms.DataGridView();
            this.txt_loaisp = new System.Windows.Forms.TextBox();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.txt_HinhAnh = new System.Windows.Forms.TextBox();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.btn_ChonHinh = new System.Windows.Forms.Button();
            this.pb_SanPham = new System.Windows.Forms.PictureBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(611, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 66;
            this.label6.Text = "Hình ảnh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "Loại SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "Tên SP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "Mã SP ";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(884, 84);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(139, 30);
            this.btn_xoa.TabIndex = 60;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click_1);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(884, 47);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(139, 30);
            this.btn_them.TabIndex = 59;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
            // 
            // dgv_sanpham
            // 
            this.dgv_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sanpham.Location = new System.Drawing.Point(48, 265);
            this.dgv_sanpham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_sanpham.Name = "dgv_sanpham";
            this.dgv_sanpham.RowHeadersWidth = 62;
            this.dgv_sanpham.RowTemplate.Height = 28;
            this.dgv_sanpham.Size = new System.Drawing.Size(975, 250);
            this.dgv_sanpham.TabIndex = 58;
            this.dgv_sanpham.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sanpham_CellContentDoubleClick);
            // 
            // txt_loaisp
            // 
            this.txt_loaisp.Location = new System.Drawing.Point(132, 162);
            this.txt_loaisp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_loaisp.Name = "txt_loaisp";
            this.txt_loaisp.Size = new System.Drawing.Size(168, 22);
            this.txt_loaisp.TabIndex = 55;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(132, 220);
            this.txt_ghichu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(168, 22);
            this.txt_ghichu.TabIndex = 54;
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(132, 113);
            this.txt_tensp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(168, 22);
            this.txt_tensp.TabIndex = 53;
            // 
            // txt_masp
            // 
            this.txt_masp.Enabled = false;
            this.txt_masp.Location = new System.Drawing.Point(132, 60);
            this.txt_masp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(168, 22);
            this.txt_masp.TabIndex = 52;
            this.txt_masp.TextChanged += new System.EventHandler(this.txt_masp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(69, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 51;
            this.label1.Text = "Bảng sản phẩm";
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(884, 119);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(139, 28);
            this.btn_sua.TabIndex = 68;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click_1);
            // 
            // txt_HinhAnh
            // 
            this.txt_HinhAnh.Location = new System.Drawing.Point(683, 219);
            this.txt_HinhAnh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_HinhAnh.Name = "txt_HinhAnh";
            this.txt_HinhAnh.Size = new System.Drawing.Size(159, 22);
            this.txt_HinhAnh.TabIndex = 69;
            // 
            // txt_Tim
            // 
            this.txt_Tim.Location = new System.Drawing.Point(884, 219);
            this.txt_Tim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(137, 22);
            this.txt_Tim.TabIndex = 70;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(884, 187);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(139, 28);
            this.btn_Tim.TabIndex = 71;
            this.btn_Tim.Text = "Tìm Kiếm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            // 
            // btn_ChonHinh
            // 
            this.btn_ChonHinh.Location = new System.Drawing.Point(635, 219);
            this.btn_ChonHinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ChonHinh.Name = "btn_ChonHinh";
            this.btn_ChonHinh.Size = new System.Drawing.Size(40, 28);
            this.btn_ChonHinh.TabIndex = 72;
            this.btn_ChonHinh.Text = "Mở";
            this.btn_ChonHinh.UseVisualStyleBackColor = true;
            this.btn_ChonHinh.Click += new System.EventHandler(this.btn_ChonHinh_Click);
            // 
            // pb_SanPham
            // 
            this.pb_SanPham.Location = new System.Drawing.Point(683, 50);
            this.pb_SanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_SanPham.Name = "pb_SanPham";
            this.pb_SanPham.Size = new System.Drawing.Size(160, 162);
            this.pb_SanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_SanPham.TabIndex = 67;
            this.pb_SanPham.TabStop = false;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(413, 57);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(167, 22);
            this.txt_SoLuong.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 74;
            this.label7.Text = "Số lương";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 118);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 16);
            this.label8.TabIndex = 76;
            this.label8.Text = "Giá";
            // 
            // txt_Gia
            // 
            this.txt_Gia.Location = new System.Drawing.Point(413, 114);
            this.txt_Gia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(167, 22);
            this.txt_Gia.TabIndex = 75;
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Location = new System.Drawing.Point(884, 151);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(139, 28);
            this.btn_LamMoi.TabIndex = 77;
            this.btn_LamMoi.Text = "Làm Mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // Frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1077, 543);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Gia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.btn_ChonHinh);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.txt_Tim);
            this.Controls.Add(this.txt_HinhAnh);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.pb_SanPham);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_sanpham);
            this.Controls.Add(this.txt_loaisp);
            this.Controls.Add(this.txt_ghichu);
            this.Controls.Add(this.txt_tensp);
            this.Controls.Add(this.txt_masp);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_SanPham";
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.Frm_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_SanPham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_sanpham;
        private System.Windows.Forms.TextBox txt_loaisp;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.TextBox txt_HinhAnh;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.Button btn_ChonHinh;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.Button btn_LamMoi;
    }
}