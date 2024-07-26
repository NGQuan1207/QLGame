namespace GUI_QLGame
{
    partial class frm_DanhSachKH
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.dtgDanhSachKH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnChiTietKhachHang = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachKH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(633, 83);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 40);
            this.btnXoa.TabIndex = 59;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(205, 228);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(201, 28);
            this.txtSDT.TabIndex = 50;
            this.txtSDT.Text = "Số Điện thoại";
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.Location = new System.Drawing.Point(123, 107);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(282, 28);
            this.txtTenKhachHang.TabIndex = 49;
            this.txtTenKhachHang.Text = "Họ tên";
            this.txtTenKhachHang.TextChanged += new System.EventHandler(this.txtTenKhachHang_TextChanged);
            // 
            // dtgDanhSachKH
            // 
            this.dtgDanhSachKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDanhSachKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhSachKH.Location = new System.Drawing.Point(9, 283);
            this.dtgDanhSachKH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtgDanhSachKH.Name = "dtgDanhSachKH";
            this.dtgDanhSachKH.ReadOnly = true;
            this.dtgDanhSachKH.RowHeadersWidth = 51;
            this.dtgDanhSachKH.RowTemplate.Height = 24;
            this.dtgDanhSachKH.Size = new System.Drawing.Size(897, 283);
            this.dtgDanhSachKH.TabIndex = 48;
            this.dtgDanhSachKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachKH_CellClick);
            this.dtgDanhSachKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachKH_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-1, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 29);
            this.label1.TabIndex = 47;
            this.label1.Text = "Danh sách khách hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLocSDT
            // 
            this.txtLocSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocSDT.Location = new System.Drawing.Point(49, 44);
            this.txtLocSDT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLocSDT.Name = "txtLocSDT";
            this.txtLocSDT.Size = new System.Drawing.Size(213, 24);
            this.txtLocSDT.TabIndex = 7;
            this.txtLocSDT.Text = "SĐT";
            this.txtLocSDT.TextChanged += new System.EventHandler(this.txtLocSDT_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(16, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "SĐT";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(123, 167);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(282, 28);
            this.txtDiaChi.TabIndex = 51;
            this.txtDiaChi.Text = "Địa chỉ";
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoc.Location = new System.Drawing.Point(287, 32);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(101, 38);
            this.btnLoc.TabIndex = 0;
            this.btnLoc.Text = "Tìm kiếm";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(760, 83);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 40);
            this.btnSua.TabIndex = 58;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnChiTietKhachHang
            // 
            this.btnChiTietKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietKhachHang.Location = new System.Drawing.Point(546, 138);
            this.btnChiTietKhachHang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnChiTietKhachHang.Name = "btnChiTietKhachHang";
            this.btnChiTietKhachHang.Size = new System.Drawing.Size(250, 40);
            this.btnChiTietKhachHang.TabIndex = 57;
            this.btnChiTietKhachHang.Text = "CHI TIẾT KHÁCH HÀNG";
            this.btnChiTietKhachHang.UseVisualStyleBackColor = true;
            this.btnChiTietKhachHang.Click += new System.EventHandler(this.btnChiTietKhachHang_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(506, 83);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 40);
            this.btnThem.TabIndex = 56;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(4, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 26);
            this.label4.TabIndex = 55;
            this.label4.Text = "SỐ ĐIỆN THOẠI";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(4, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 54;
            this.label3.Text = "ĐỊA CHỈ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(4, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 53;
            this.label2.Text = "HỌ TÊN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.txtLocSDT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnLoc);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(473, 184);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(405, 94);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frm_DanhSachKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(910, 540);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.dtgDanhSachKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnChiTietKhachHang);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "frm_DanhSachKH";
            this.Text = "Danh Sách Khách Hàng";
            this.Load += new System.EventHandler(this.frm_DanhSachKH_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachKH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.DataGridView dtgDanhSachKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        protected internal System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnChiTietKhachHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}