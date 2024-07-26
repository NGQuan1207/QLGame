namespace GUI_QLGame
{
    partial class Frm_BaoHanh
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
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_Baohanh = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TimBaoHanh = new System.Windows.Forms.TextBox();
            this.btn_TimBaoHanh = new System.Windows.Forms.Button();
            this.txt_MaBaoHanh = new System.Windows.Forms.TextBox();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.txt_BatDau = new System.Windows.Forms.TextBox();
            this.txt_KetThuc = new System.Windows.Forms.TextBox();
            this.txt_TinhTrang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_ThemBH = new System.Windows.Forms.Button();
            this.btn_XoaBH = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Baohanh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1051, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "BẢO HÀNH";
            // 
            // dtgv_Baohanh
            // 
            this.dtgv_Baohanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Baohanh.Location = new System.Drawing.Point(24, 67);
            this.dtgv_Baohanh.Margin = new System.Windows.Forms.Padding(2);
            this.dtgv_Baohanh.Name = "dtgv_Baohanh";
            this.dtgv_Baohanh.RowHeadersWidth = 51;
            this.dtgv_Baohanh.RowTemplate.Height = 24;
            this.dtgv_Baohanh.Size = new System.Drawing.Size(653, 286);
            this.dtgv_Baohanh.TabIndex = 3;
            this.dtgv_Baohanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Baohanh_CellClick);
            this.dtgv_Baohanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Baohanh_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.txt_TimBaoHanh);
            this.groupBox1.Controls.Add(this.btn_TimBaoHanh);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(24, 374);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(512, 60);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Bảo Hành";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_TimBaoHanh
            // 
            this.txt_TimBaoHanh.Location = new System.Drawing.Point(17, 26);
            this.txt_TimBaoHanh.Name = "txt_TimBaoHanh";
            this.txt_TimBaoHanh.Size = new System.Drawing.Size(362, 20);
            this.txt_TimBaoHanh.TabIndex = 1;
            // 
            // btn_TimBaoHanh
            // 
            this.btn_TimBaoHanh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_TimBaoHanh.Location = new System.Drawing.Point(399, 17);
            this.btn_TimBaoHanh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TimBaoHanh.Name = "btn_TimBaoHanh";
            this.btn_TimBaoHanh.Size = new System.Drawing.Size(100, 37);
            this.btn_TimBaoHanh.TabIndex = 0;
            this.btn_TimBaoHanh.Text = "TÌM KIẾM";
            this.btn_TimBaoHanh.UseVisualStyleBackColor = true;
            this.btn_TimBaoHanh.Click += new System.EventHandler(this.btn_LocSP_Click);
            // 
            // txt_MaBaoHanh
            // 
            this.txt_MaBaoHanh.Enabled = false;
            this.txt_MaBaoHanh.Location = new System.Drawing.Point(818, 80);
            this.txt_MaBaoHanh.Name = "txt_MaBaoHanh";
            this.txt_MaBaoHanh.Size = new System.Drawing.Size(168, 20);
            this.txt_MaBaoHanh.TabIndex = 24;
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Location = new System.Drawing.Point(818, 117);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(168, 20);
            this.txt_MaSP.TabIndex = 25;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(818, 154);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(168, 20);
            this.txt_MaKH.TabIndex = 26;
            // 
            // txt_BatDau
            // 
            this.txt_BatDau.Location = new System.Drawing.Point(818, 197);
            this.txt_BatDau.Name = "txt_BatDau";
            this.txt_BatDau.Size = new System.Drawing.Size(168, 20);
            this.txt_BatDau.TabIndex = 27;
            // 
            // txt_KetThuc
            // 
            this.txt_KetThuc.Location = new System.Drawing.Point(818, 242);
            this.txt_KetThuc.Name = "txt_KetThuc";
            this.txt_KetThuc.Size = new System.Drawing.Size(168, 20);
            this.txt_KetThuc.TabIndex = 28;
            // 
            // txt_TinhTrang
            // 
            this.txt_TinhTrang.Location = new System.Drawing.Point(818, 280);
            this.txt_TinhTrang.Name = "txt_TinhTrang";
            this.txt_TinhTrang.Size = new System.Drawing.Size(168, 20);
            this.txt_TinhTrang.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(728, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mã Bảo Hành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(728, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Mã Sản Phảm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(728, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Mã Khách Hành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(728, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Bắt Đầu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(728, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Kết Thúc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(728, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tình Trạng";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btn_ThemBH
            // 
            this.btn_ThemBH.Location = new System.Drawing.Point(750, 346);
            this.btn_ThemBH.Name = "btn_ThemBH";
            this.btn_ThemBH.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemBH.TabIndex = 36;
            this.btn_ThemBH.Text = "Thêm";
            this.btn_ThemBH.UseVisualStyleBackColor = true;
            this.btn_ThemBH.Click += new System.EventHandler(this.btn_ThemBH_Click);
            // 
            // btn_XoaBH
            // 
            this.btn_XoaBH.Location = new System.Drawing.Point(910, 346);
            this.btn_XoaBH.Name = "btn_XoaBH";
            this.btn_XoaBH.Size = new System.Drawing.Size(75, 23);
            this.btn_XoaBH.TabIndex = 37;
            this.btn_XoaBH.Text = "Xóa";
            this.btn_XoaBH.UseVisualStyleBackColor = true;
            this.btn_XoaBH.Click += new System.EventHandler(this.btn_XoaBH_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(910, 397);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 38;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Location = new System.Drawing.Point(750, 398);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(75, 23);
            this.btn_LamMoi.TabIndex = 39;
            this.btn_LamMoi.Text = "Làm Mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // Frm_BaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1051, 444);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_XoaBH);
            this.Controls.Add(this.btn_ThemBH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TinhTrang);
            this.Controls.Add(this.txt_KetThuc);
            this.Controls.Add(this.txt_BatDau);
            this.Controls.Add(this.txt_MaKH);
            this.Controls.Add(this.txt_MaSP);
            this.Controls.Add(this.txt_MaBaoHanh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgv_Baohanh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_BaoHanh";
            this.Text = "Bảo Hành";
            this.Load += new System.EventHandler(this.Frm_BaoHanh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Baohanh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv_Baohanh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_TimBaoHanh;
        private System.Windows.Forms.TextBox txt_TimBaoHanh;
        private System.Windows.Forms.TextBox txt_MaBaoHanh;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.TextBox txt_BatDau;
        private System.Windows.Forms.TextBox txt_KetThuc;
        private System.Windows.Forms.TextBox txt_TinhTrang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_ThemBH;
        private System.Windows.Forms.Button btn_XoaBH;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_LamMoi;
    }
}