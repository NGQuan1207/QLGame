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
            this.dgv_SanphamLenDon = new System.Windows.Forms.DataGridView();
            this.txt_tenKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date_Ngay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.combb_Loaidon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_GioHang = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ThanhToan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_GiamGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.date_ngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_MaGiamGia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_LenDon = new System.Windows.Forms.Button();
            this.btn_LenDonvaIn = new System.Windows.Forms.Button();
            this.btn_ApDung = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.placeholderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanphamLenDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GioHang)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_SanphamLenDon
            // 
            this.dgv_SanphamLenDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SanphamLenDon.Location = new System.Drawing.Point(10, 29);
            this.dgv_SanphamLenDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_SanphamLenDon.Name = "dgv_SanphamLenDon";
            this.dgv_SanphamLenDon.RowHeadersWidth = 62;
            this.dgv_SanphamLenDon.RowTemplate.Height = 28;
            this.dgv_SanphamLenDon.Size = new System.Drawing.Size(991, 484);
            this.dgv_SanphamLenDon.TabIndex = 39;
            // 
            // txt_tenKH
            // 
            this.txt_tenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenKH.Location = new System.Drawing.Point(352, 111);
            this.txt_tenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.Size = new System.Drawing.Size(616, 34);
            this.txt_tenKH.TabIndex = 27;
            this.txt_tenKH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 38);
            this.label1.TabIndex = 26;
            this.label1.Text = "LÊN ĐƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 29);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tên Khách hàng";
            // 
            // date_Ngay
            // 
            this.date_Ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_Ngay.Location = new System.Drawing.Point(352, 254);
            this.date_Ngay.Name = "date_Ngay";
            this.date_Ngay.Size = new System.Drawing.Size(616, 34);
            this.date_Ngay.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 42;
            this.label3.Text = "Ngày";
            // 
            // combb_Loaidon
            // 
            this.combb_Loaidon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combb_Loaidon.FormattingEnabled = true;
            this.combb_Loaidon.Items.AddRange(new object[] {
            "Đơn Mua",
            "Đơn Thuê"});
            this.combb_Loaidon.Location = new System.Drawing.Point(352, 184);
            this.combb_Loaidon.Name = "combb_Loaidon";
            this.combb_Loaidon.Size = new System.Drawing.Size(616, 37);
            this.combb_Loaidon.TabIndex = 43;
            this.combb_Loaidon.Text = "Loại đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 29);
            this.label4.TabIndex = 44;
            this.label4.Text = "Loại đơn";
            // 
            // txt_maNV
            // 
            this.txt_maNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maNV.Location = new System.Drawing.Point(352, 388);
            this.txt_maNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.Size = new System.Drawing.Size(616, 34);
            this.txt_maNV.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 29);
            this.label5.TabIndex = 46;
            this.label5.Text = "mã nhân viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_SanphamLenDon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 530);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_GioHang);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1022, 451);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(868, 530);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ hàng";
            // 
            // dgv_GioHang
            // 
            this.dgv_GioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GioHang.Location = new System.Drawing.Point(16, 28);
            this.dgv_GioHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_GioHang.Name = "dgv_GioHang";
            this.dgv_GioHang.RowHeadersWidth = 62;
            this.dgv_GioHang.RowTemplate.Height = 28;
            this.dgv_GioHang.Size = new System.Drawing.Size(832, 484);
            this.dgv_GioHang.TabIndex = 39;
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
            this.groupBox3.Location = new System.Drawing.Point(1421, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 260);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin hóa đơn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 29);
            this.label8.TabIndex = 54;
            this.label8.Text = "Thanh toán";
            // 
            // txt_ThanhToan
            // 
            this.txt_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThanhToan.Location = new System.Drawing.Point(168, 185);
            this.txt_ThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ThanhToan.Name = "txt_ThanhToan";
            this.txt_ThanhToan.ReadOnly = true;
            this.txt_ThanhToan.Size = new System.Drawing.Size(281, 34);
            this.txt_ThanhToan.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 29);
            this.label7.TabIndex = 53;
            this.label7.Text = "Giảm giá";
            // 
            // txt_GiamGia
            // 
            this.txt_GiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiamGia.Location = new System.Drawing.Point(168, 116);
            this.txt_GiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_GiamGia.Name = "txt_GiamGia";
            this.txt_GiamGia.ReadOnly = true;
            this.txt_GiamGia.Size = new System.Drawing.Size(281, 34);
            this.txt_GiamGia.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 29);
            this.label6.TabIndex = 51;
            this.label6.Text = "Tổng tiền";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(168, 51);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(281, 34);
            this.txt_TongTien.TabIndex = 51;
            // 
            // date_ngayketthuc
            // 
            this.date_ngayketthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ngayketthuc.Location = new System.Drawing.Point(352, 320);
            this.date_ngayketthuc.Name = "date_ngayketthuc";
            this.date_ngayketthuc.Size = new System.Drawing.Size(616, 34);
            this.date_ngayketthuc.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(113, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 29);
            this.label9.TabIndex = 57;
            this.label9.Text = "Ngày kết thúc";
            // 
            // txt_MaGiamGia
            // 
            this.txt_MaGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaGiamGia.Location = new System.Drawing.Point(1609, 325);
            this.txt_MaGiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaGiamGia.Name = "txt_MaGiamGia";
            this.txt_MaGiamGia.Size = new System.Drawing.Size(281, 34);
            this.txt_MaGiamGia.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1428, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 29);
            this.label10.TabIndex = 56;
            this.label10.Text = "Mã giảm giá";
            // 
            // btn_LenDon
            // 
            this.btn_LenDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LenDon.Location = new System.Drawing.Point(1058, 152);
            this.btn_LenDon.Name = "btn_LenDon";
            this.btn_LenDon.Size = new System.Drawing.Size(301, 69);
            this.btn_LenDon.TabIndex = 58;
            this.btn_LenDon.Text = "Lên Đơn";
            this.btn_LenDon.UseVisualStyleBackColor = true;
            // 
            // btn_LenDonvaIn
            // 
            this.btn_LenDonvaIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LenDonvaIn.Location = new System.Drawing.Point(1058, 285);
            this.btn_LenDonvaIn.Name = "btn_LenDonvaIn";
            this.btn_LenDonvaIn.Size = new System.Drawing.Size(301, 69);
            this.btn_LenDonvaIn.TabIndex = 59;
            this.btn_LenDonvaIn.Text = "Lên Đơn và in";
            this.btn_LenDonvaIn.UseVisualStyleBackColor = true;
            // 
            // btn_ApDung
            // 
            this.btn_ApDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ApDung.Location = new System.Drawing.Point(1499, 379);
            this.btn_ApDung.Name = "btn_ApDung";
            this.btn_ApDung.Size = new System.Drawing.Size(279, 57);
            this.btn_ApDung.TabIndex = 60;
            this.btn_ApDung.Text = "Áp dụng";
            this.btn_ApDung.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeholderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // placeholderToolStripMenuItem
            // 
            this.placeholderToolStripMenuItem.Name = "placeholderToolStripMenuItem";
            this.placeholderToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.placeholderToolStripMenuItem.Text = "placeholder";
            // 
            // Frm_LenDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 992);
            this.Controls.Add(this.btn_ApDung);
            this.Controls.Add(this.btn_LenDonvaIn);
            this.Controls.Add(this.btn_LenDon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_MaGiamGia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.date_ngayketthuc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_maNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combb_Loaidon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_Ngay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tenKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_LenDon";
            this.Text = "Lên Đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanphamLenDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GioHang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_SanphamLenDon;
        private System.Windows.Forms.TextBox txt_tenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_Ngay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combb_Loaidon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_maNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_GioHang;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ThanhToan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_GiamGia;
        private System.Windows.Forms.DateTimePicker date_ngayketthuc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_MaGiamGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_LenDon;
        private System.Windows.Forms.Button btn_LenDonvaIn;
        private System.Windows.Forms.Button btn_ApDung;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem;
    }
}