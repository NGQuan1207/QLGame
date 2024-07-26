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
            this.combb_LocGia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comb_LocLoaiSP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date_locSP = new System.Windows.Forms.DateTimePicker();
            this.btn_LocSP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combb_Trangthai = new System.Windows.Forms.ComboBox();
            this.combb_LocGiathue = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_locSPthue = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.date_locSPthue = new System.Windows.Forms.DateTimePicker();
            this.comb_LocLoaiSPthue = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataG_SPdaBan = new System.Windows.Forms.DataGridView();
            this.dataG_SPdaThue = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_SPdaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_SPdaThue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 26);
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
            this.menuStrip1.Size = new System.Drawing.Size(890, 24);
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
            this.txt_Thunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Thunhap.Location = new System.Drawing.Point(117, 68);
            this.txt_Thunhap.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Thunhap.Name = "txt_Thunhap";
            this.txt_Thunhap.ReadOnly = true;
            this.txt_Thunhap.Size = new System.Drawing.Size(183, 26);
            this.txt_Thunhap.TabIndex = 15;
            this.txt_Thunhap.Text = "Thu Nhập";
            // 
            // txt_TongSP
            // 
            this.txt_TongSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongSP.Location = new System.Drawing.Point(117, 106);
            this.txt_TongSP.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TongSP.Name = "txt_TongSP";
            this.txt_TongSP.ReadOnly = true;
            this.txt_TongSP.Size = new System.Drawing.Size(183, 26);
            this.txt_TongSP.TabIndex = 16;
            this.txt_TongSP.Text = "Tổng SP đã bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Thu nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(9, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tổng SP bán";
            // 
            // combb_DateThunhap
            // 
            this.combb_DateThunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combb_DateThunhap.FormattingEnabled = true;
            this.combb_DateThunhap.Items.AddRange(new object[] {
            "7 ngày trước",
            "30 ngày trước",
            "90 ngày trước",
            "1 năm trước"});
            this.combb_DateThunhap.Location = new System.Drawing.Point(304, 68);
            this.combb_DateThunhap.Margin = new System.Windows.Forms.Padding(2);
            this.combb_DateThunhap.Name = "combb_DateThunhap";
            this.combb_DateThunhap.Size = new System.Drawing.Size(121, 28);
            this.combb_DateThunhap.TabIndex = 19;
            this.combb_DateThunhap.Text = "X ngày trước";
            // 
            // combb_DateSP
            // 
            this.combb_DateSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combb_DateSP.FormattingEnabled = true;
            this.combb_DateSP.Items.AddRange(new object[] {
            "7 ngày trước",
            "30 ngày trước",
            "90 ngày trước",
            "1 năm trước"});
            this.combb_DateSP.Location = new System.Drawing.Point(304, 104);
            this.combb_DateSP.Margin = new System.Windows.Forms.Padding(2);
            this.combb_DateSP.Name = "combb_DateSP";
            this.combb_DateSP.Size = new System.Drawing.Size(121, 28);
            this.combb_DateSP.TabIndex = 20;
            this.combb_DateSP.Text = "X ngày trước";
            // 
            // btn_xuatfile
            // 
            this.btn_xuatfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuatfile.Location = new System.Drawing.Point(576, 68);
            this.btn_xuatfile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xuatfile.Name = "btn_xuatfile";
            this.btn_xuatfile.Size = new System.Drawing.Size(147, 52);
            this.btn_xuatfile.TabIndex = 21;
            this.btn_xuatfile.Text = "Xuất file";
            this.btn_xuatfile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.combb_LocGia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comb_LocLoaiSP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.date_locSP);
            this.groupBox1.Controls.Add(this.btn_LocSP);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(8, 136);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(434, 107);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc SP đã bán";
            // 
            // combb_LocGia
            // 
            this.combb_LocGia.FormattingEnabled = true;
            this.combb_LocGia.Location = new System.Drawing.Point(56, 78);
            this.combb_LocGia.Margin = new System.Windows.Forms.Padding(2);
            this.combb_LocGia.Name = "combb_LocGia";
            this.combb_LocGia.Size = new System.Drawing.Size(236, 21);
            this.combb_LocGia.TabIndex = 6;
            this.combb_LocGia.Text = "GIÁ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(7, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại SP";
            // 
            // comb_LocLoaiSP
            // 
            this.comb_LocLoaiSP.FormattingEnabled = true;
            this.comb_LocLoaiSP.Location = new System.Drawing.Point(56, 47);
            this.comb_LocLoaiSP.Margin = new System.Windows.Forms.Padding(2);
            this.comb_LocLoaiSP.Name = "comb_LocLoaiSP";
            this.comb_LocLoaiSP.Size = new System.Drawing.Size(236, 21);
            this.comb_LocLoaiSP.TabIndex = 3;
            this.comb_LocLoaiSP.Text = "LOẠI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày";
            // 
            // date_locSP
            // 
            this.date_locSP.Location = new System.Drawing.Point(56, 17);
            this.date_locSP.Margin = new System.Windows.Forms.Padding(2);
            this.date_locSP.Name = "date_locSP";
            this.date_locSP.Size = new System.Drawing.Size(236, 20);
            this.date_locSP.TabIndex = 1;
            // 
            // btn_LocSP
            // 
            this.btn_LocSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_LocSP.Location = new System.Drawing.Point(315, 37);
            this.btn_LocSP.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LocSP.Name = "btn_LocSP";
            this.btn_LocSP.Size = new System.Drawing.Size(100, 37);
            this.btn_LocSP.TabIndex = 0;
            this.btn_LocSP.Text = "LỌC";
            this.btn_LocSP.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combb_Trangthai);
            this.groupBox2.Controls.Add(this.combb_LocGiathue);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btn_locSPthue);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.date_locSPthue);
            this.groupBox2.Controls.Add(this.comb_LocLoaiSPthue);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(447, 136);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(434, 107);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc sản phẩm thuê";
            // 
            // combb_Trangthai
            // 
            this.combb_Trangthai.FormattingEnabled = true;
            this.combb_Trangthai.Location = new System.Drawing.Point(328, 22);
            this.combb_Trangthai.Margin = new System.Windows.Forms.Padding(2);
            this.combb_Trangthai.Name = "combb_Trangthai";
            this.combb_Trangthai.Size = new System.Drawing.Size(72, 21);
            this.combb_Trangthai.TabIndex = 14;
            this.combb_Trangthai.Text = "Trạng thái";
            // 
            // combb_LocGiathue
            // 
            this.combb_LocGiathue.FormattingEnabled = true;
            this.combb_LocGiathue.Location = new System.Drawing.Point(57, 80);
            this.combb_LocGiathue.Margin = new System.Windows.Forms.Padding(2);
            this.combb_LocGiathue.Name = "combb_LocGiathue";
            this.combb_LocGiathue.Size = new System.Drawing.Size(236, 21);
            this.combb_LocGiathue.TabIndex = 13;
            this.combb_LocGiathue.Text = "GIÁ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Giá";
            // 
            // btn_locSPthue
            // 
            this.btn_locSPthue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_locSPthue.Location = new System.Drawing.Point(314, 60);
            this.btn_locSPthue.Margin = new System.Windows.Forms.Padding(2);
            this.btn_locSPthue.Name = "btn_locSPthue";
            this.btn_locSPthue.Size = new System.Drawing.Size(100, 37);
            this.btn_locSPthue.TabIndex = 7;
            this.btn_locSPthue.Text = "LỌC";
            this.btn_locSPthue.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(8, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Loại SP";
            // 
            // date_locSPthue
            // 
            this.date_locSPthue.Location = new System.Drawing.Point(57, 20);
            this.date_locSPthue.Margin = new System.Windows.Forms.Padding(2);
            this.date_locSPthue.Name = "date_locSPthue";
            this.date_locSPthue.Size = new System.Drawing.Size(236, 20);
            this.date_locSPthue.TabIndex = 8;
            // 
            // comb_LocLoaiSPthue
            // 
            this.comb_LocLoaiSPthue.FormattingEnabled = true;
            this.comb_LocLoaiSPthue.Location = new System.Drawing.Point(57, 50);
            this.comb_LocLoaiSPthue.Margin = new System.Windows.Forms.Padding(2);
            this.comb_LocLoaiSPthue.Name = "comb_LocLoaiSPthue";
            this.comb_LocLoaiSPthue.Size = new System.Drawing.Size(236, 21);
            this.comb_LocLoaiSPthue.TabIndex = 10;
            this.comb_LocLoaiSPthue.Text = "LOẠI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(21, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ngày";
            // 
            // dataG_SPdaBan
            // 
            this.dataG_SPdaBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG_SPdaBan.Location = new System.Drawing.Point(8, 248);
            this.dataG_SPdaBan.Margin = new System.Windows.Forms.Padding(2);
            this.dataG_SPdaBan.Name = "dataG_SPdaBan";
            this.dataG_SPdaBan.RowHeadersWidth = 51;
            this.dataG_SPdaBan.RowTemplate.Height = 24;
            this.dataG_SPdaBan.Size = new System.Drawing.Size(435, 232);
            this.dataG_SPdaBan.TabIndex = 24;
            // 
            // dataG_SPdaThue
            // 
            this.dataG_SPdaThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG_SPdaThue.Location = new System.Drawing.Point(446, 248);
            this.dataG_SPdaThue.Margin = new System.Windows.Forms.Padding(2);
            this.dataG_SPdaThue.Name = "dataG_SPdaThue";
            this.dataG_SPdaThue.RowHeadersWidth = 51;
            this.dataG_SPdaThue.RowTemplate.Height = 24;
            this.dataG_SPdaThue.Size = new System.Drawing.Size(435, 232);
            this.dataG_SPdaThue.TabIndex = 25;
            // 
            // Frm_BaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(890, 490);
            this.Controls.Add(this.dataG_SPdaThue);
            this.Controls.Add(this.dataG_SPdaBan);
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
            this.Load += new System.EventHandler(this.Frm_BaoCaoThongKe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_SPdaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_SPdaThue)).EndInit();
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
        private System.Windows.Forms.DateTimePicker date_locSP;
        private System.Windows.Forms.Button btn_LocSP;
        private System.Windows.Forms.DataGridView dataG_SPdaBan;
        private System.Windows.Forms.DataGridView dataG_SPdaThue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combb_LocGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comb_LocLoaiSP;
        private System.Windows.Forms.ComboBox combb_Trangthai;
        private System.Windows.Forms.ComboBox combb_LocGiathue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_locSPthue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker date_locSPthue;
        private System.Windows.Forms.ComboBox comb_LocLoaiSPthue;
        private System.Windows.Forms.Label label9;
    }
}