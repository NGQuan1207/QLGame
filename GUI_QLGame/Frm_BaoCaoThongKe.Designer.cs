namespace GUI_QLGame
{
    partial class Frm_BaoCaoThongKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Thunhap = new System.Windows.Forms.TextBox();
            this.txt_TongSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combb_DateThunhap = new System.Windows.Forms.ComboBox();
            this.combb_DateSP = new System.Windows.Forms.ComboBox();
            this.btn_xuatfile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_hoadon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_maspt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgv_hoadon = new System.Windows.Forms.DataGridView();
            this.dtgv_spthue = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_spthue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, -23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Báo cáo thống kê";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1844, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // txt_Thunhap
            // 
            this.txt_Thunhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Thunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Thunhap.Location = new System.Drawing.Point(265, 64);
            this.txt_Thunhap.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Thunhap.Name = "txt_Thunhap";
            this.txt_Thunhap.ReadOnly = true;
            this.txt_Thunhap.Size = new System.Drawing.Size(366, 26);
            this.txt_Thunhap.TabIndex = 15;
            this.txt_Thunhap.Text = "Thu Nhập";
            // 
            // txt_TongSP
            // 
            this.txt_TongSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TongSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongSP.Location = new System.Drawing.Point(265, 156);
            this.txt_TongSP.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TongSP.Name = "txt_TongSP";
            this.txt_TongSP.ReadOnly = true;
            this.txt_TongSP.Size = new System.Drawing.Size(366, 26);
            this.txt_TongSP.TabIndex = 16;
            this.txt_TongSP.Text = "Tổng SP đã bán";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(111, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Thu nhập";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(68, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tổng SP bán";
            // 
            // combb_DateThunhap
            // 
            this.combb_DateThunhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combb_DateThunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combb_DateThunhap.FormattingEnabled = true;
            this.combb_DateThunhap.Items.AddRange(new object[] {
            "7 ngày trước",
            "30 ngày trước",
            "90 ngày trước",
            "1 năm trước"});
            this.combb_DateThunhap.Location = new System.Drawing.Point(655, 62);
            this.combb_DateThunhap.Margin = new System.Windows.Forms.Padding(2);
            this.combb_DateThunhap.Name = "combb_DateThunhap";
            this.combb_DateThunhap.Size = new System.Drawing.Size(264, 28);
            this.combb_DateThunhap.TabIndex = 19;
            this.combb_DateThunhap.Text = "X ngày trước";
            // 
            // combb_DateSP
            // 
            this.combb_DateSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combb_DateSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combb_DateSP.FormattingEnabled = true;
            this.combb_DateSP.Items.AddRange(new object[] {
            "7 ngày trước",
            "30 ngày trước",
            "90 ngày trước",
            "1 năm trước"});
            this.combb_DateSP.Location = new System.Drawing.Point(655, 154);
            this.combb_DateSP.Margin = new System.Windows.Forms.Padding(2);
            this.combb_DateSP.Name = "combb_DateSP";
            this.combb_DateSP.Size = new System.Drawing.Size(264, 28);
            this.combb_DateSP.TabIndex = 20;
            this.combb_DateSP.Text = "X ngày trước";
            // 
            // btn_xuatfile
            // 
            this.btn_xuatfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_xuatfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuatfile.Location = new System.Drawing.Point(1319, 64);
            this.btn_xuatfile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xuatfile.Name = "btn_xuatfile";
            this.btn_xuatfile.Size = new System.Drawing.Size(147, 52);
            this.btn_xuatfile.TabIndex = 21;
            this.btn_xuatfile.Text = "Xuất file";
            this.btn_xuatfile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.txt_hoadon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(22, 221);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(908, 51);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_hoadon
            // 
            this.txt_hoadon.Location = new System.Drawing.Point(134, 18);
            this.txt_hoadon.Name = "txt_hoadon";
            this.txt_hoadon.Size = new System.Drawing.Size(758, 20);
            this.txt_hoadon.TabIndex = 16;
            this.txt_hoadon.TextChanged += new System.EventHandler(this.txt_hoadon_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(2, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Khách Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txt_maspt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(946, 221);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(898, 51);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm";
            // 
            // txt_maspt
            // 
            this.txt_maspt.Location = new System.Drawing.Point(93, 18);
            this.txt_maspt.Name = "txt_maspt";
            this.txt_maspt.Size = new System.Drawing.Size(786, 20);
            this.txt_maspt.TabIndex = 15;
            this.txt_maspt.TextChanged += new System.EventHandler(this.txt_maspt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(12, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Mã sp";
            // 
            // dtgv_hoadon
            // 
            this.dtgv_hoadon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgv_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_hoadon.Location = new System.Drawing.Point(22, 287);
            this.dtgv_hoadon.Margin = new System.Windows.Forms.Padding(2);
            this.dtgv_hoadon.Name = "dtgv_hoadon";
            this.dtgv_hoadon.RowHeadersWidth = 51;
            this.dtgv_hoadon.RowTemplate.Height = 24;
            this.dtgv_hoadon.Size = new System.Drawing.Size(908, 317);
            this.dtgv_hoadon.TabIndex = 24;
            // 
            // dtgv_spthue
            // 
            this.dtgv_spthue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgv_spthue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_spthue.Location = new System.Drawing.Point(946, 287);
            this.dtgv_spthue.Margin = new System.Windows.Forms.Padding(2);
            this.dtgv_spthue.Name = "dtgv_spthue";
            this.dtgv_spthue.RowHeadersWidth = 51;
            this.dtgv_spthue.RowTemplate.Height = 24;
            this.dtgv_spthue.Size = new System.Drawing.Size(898, 317);
            this.dtgv_spthue.TabIndex = 25;
            // 
            // Frm_BaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1844, 661);
            this.Controls.Add(this.dtgv_spthue);
            this.Controls.Add(this.dtgv_hoadon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_xuatfile);
            this.Controls.Add(this.combb_DateSP);
            this.Controls.Add(this.combb_DateThunhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TongSP);
            this.Controls.Add(this.txt_Thunhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_BaoCaoThongKe";
            this.Text = "Báo Cáo Thống Kê";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_BaoCaoThongKe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_spthue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_Thunhap;
        private System.Windows.Forms.TextBox txt_TongSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combb_DateThunhap;
        private System.Windows.Forms.ComboBox combb_DateSP;
        private System.Windows.Forms.Button btn_xuatfile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgv_hoadon;
        private System.Windows.Forms.DataGridView dtgv_spthue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_hoadon;
        private System.Windows.Forms.TextBox txt_maspt;
    }
}