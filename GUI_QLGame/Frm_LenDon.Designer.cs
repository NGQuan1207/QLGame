namespace GUI_QLGame
{
    partial class Frm_LenDon
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.placeholderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_GioHang = new System.Windows.Forms.DataGridView();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btn_LenDon = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_MaGiamGia = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ThanhToan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_GiamGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_SanphamLenDon = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_maNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date_Ngay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GioHang)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanphamLenDon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeholderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1443, 24);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // placeholderToolStripMenuItem
            // 
            this.placeholderToolStripMenuItem.Name = "placeholderToolStripMenuItem";
            this.placeholderToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.placeholderToolStripMenuItem.Text = "placeholder";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(181, 139);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 24);
            this.label11.TabIndex = 88;
            this.label11.Text = "Địa Chỉ";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(300, 187);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(463, 28);
            this.txtSDT.TabIndex = 86;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_GioHang);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(773, 405);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(543, 310);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ hàng";
            // 
            // dgv_GioHang
            // 
            this.dgv_GioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_GioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GioHang.Location = new System.Drawing.Point(13, 16);
            this.dgv_GioHang.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_GioHang.Name = "dgv_GioHang";
            this.dgv_GioHang.ReadOnly = true;
            this.dgv_GioHang.RowHeadersWidth = 62;
            this.dgv_GioHang.RowTemplate.Height = 28;
            this.dgv_GioHang.Size = new System.Drawing.Size(517, 290);
            this.dgv_GioHang.TabIndex = 39;
            this.dgv_GioHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GioHang_CellClick);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(300, 139);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(463, 28);
            this.txtDiaChi.TabIndex = 87;
            // 
            // btn_LenDon
            // 
            this.btn_LenDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LenDon.Location = new System.Drawing.Point(856, 346);
            this.btn_LenDon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LenDon.Name = "btn_LenDon";
            this.btn_LenDon.Size = new System.Drawing.Size(143, 38);
            this.btn_LenDon.TabIndex = 83;
            this.btn_LenDon.Text = "Lên Đơn";
            this.btn_LenDon.UseVisualStyleBackColor = true;
            this.btn_LenDon.Click += new System.EventHandler(this.btn_LenDon_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(953, 307);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 24);
            this.label10.TabIndex = 81;
            this.label10.Text = "Mã giảm giá";
            // 
            // txt_MaGiamGia
            // 
            this.txt_MaGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaGiamGia.Location = new System.Drawing.Point(1089, 307);
            this.txt_MaGiamGia.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaGiamGia.Name = "txt_MaGiamGia";
            this.txt_MaGiamGia.Size = new System.Drawing.Size(212, 28);
            this.txt_MaGiamGia.TabIndex = 80;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_ThanhToan);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_GiamGia);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_TongTien);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(949, 77);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(352, 211);
            this.groupBox3.TabIndex = 78;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin hóa đơn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 153);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 24);
            this.label8.TabIndex = 54;
            this.label8.Text = "Thanh toán";
            // 
            // txt_ThanhToan
            // 
            this.txt_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThanhToan.Location = new System.Drawing.Point(126, 150);
            this.txt_ThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ThanhToan.Name = "txt_ThanhToan";
            this.txt_ThanhToan.ReadOnly = true;
            this.txt_ThanhToan.Size = new System.Drawing.Size(212, 28);
            this.txt_ThanhToan.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 53;
            this.label7.Text = "Giảm giá";
            // 
            // txt_GiamGia
            // 
            this.txt_GiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiamGia.Location = new System.Drawing.Point(126, 94);
            this.txt_GiamGia.Margin = new System.Windows.Forms.Padding(2);
            this.txt_GiamGia.Name = "txt_GiamGia";
            this.txt_GiamGia.ReadOnly = true;
            this.txt_GiamGia.Size = new System.Drawing.Size(212, 28);
            this.txt_GiamGia.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 51;
            this.label6.Text = "Tổng tiền";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(126, 41);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(212, 28);
            this.txt_TongTien.TabIndex = 51;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_SanphamLenDon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(177, 405);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(508, 310);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản phẩm";
            // 
            // dgv_SanphamLenDon
            // 
            this.dgv_SanphamLenDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SanphamLenDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SanphamLenDon.Location = new System.Drawing.Point(8, 22);
            this.dgv_SanphamLenDon.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_SanphamLenDon.Name = "dgv_SanphamLenDon";
            this.dgv_SanphamLenDon.ReadOnly = true;
            this.dgv_SanphamLenDon.RowHeadersWidth = 62;
            this.dgv_SanphamLenDon.RowTemplate.Height = 28;
            this.dgv_SanphamLenDon.Size = new System.Drawing.Size(486, 284);
            this.dgv_SanphamLenDon.TabIndex = 39;
            this.dgv_SanphamLenDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SanphamLenDon_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 75;
            this.label5.Text = "mã nhân viên";
            // 
            // txt_maNV
            // 
            this.txt_maNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maNV.Location = new System.Drawing.Point(300, 294);
            this.txt_maNV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.Size = new System.Drawing.Size(463, 28);
            this.txt_maNV.TabIndex = 74;
            this.txt_maNV.Text = "NV003";
            this.txt_maNV.TextChanged += new System.EventHandler(this.txt_maNV_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 71;
            this.label3.Text = "Ngày";
            // 
            // date_Ngay
            // 
            this.date_Ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_Ngay.Location = new System.Drawing.Point(300, 241);
            this.date_Ngay.Margin = new System.Windows.Forms.Padding(2);
            this.date_Ngay.Name = "date_Ngay";
            this.date_Ngay.Size = new System.Drawing.Size(463, 28);
            this.date_Ngay.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 69;
            this.label2.Text = "Tên Khách hàng";
            // 
            // txt_tenKH
            // 
            this.txt_tenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenKH.Location = new System.Drawing.Point(300, 90);
            this.txt_tenKH.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.Size = new System.Drawing.Size(463, 28);
            this.txt_tenKH.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(44, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 67;
            this.label1.Text = "LÊN ĐƠN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 89;
            this.label4.Text = "SĐT";
            // 
            // Frm_LenDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1443, 806);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.btn_LenDon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_MaGiamGia);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_maNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_Ngay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tenKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_LenDon";
            this.Text = "Lên Đơn";
            this.Load += new System.EventHandler(this.Frm_LenDon_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GioHang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanphamLenDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_GioHang;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btn_LenDon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_MaGiamGia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ThanhToan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_GiamGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_SanphamLenDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_maNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_Ngay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}