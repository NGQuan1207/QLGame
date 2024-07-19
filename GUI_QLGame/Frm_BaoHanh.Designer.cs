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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BaoHanh));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataG_Baohanh = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combb_Gia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combb_LoaiSP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date_spBaohanh = new System.Windows.Forms.DateTimePicker();
            this.btn_LocSP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tinhtrang = new System.Windows.Forms.TextBox();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.btn_Xuathoadon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_Baohanh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1187, 553);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1187, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(2, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "BẢO HÀNH";
            // 
            // dataG_Baohanh
            // 
            this.dataG_Baohanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG_Baohanh.Location = new System.Drawing.Point(32, 81);
            this.dataG_Baohanh.Name = "dataG_Baohanh";
            this.dataG_Baohanh.RowHeadersWidth = 51;
            this.dataG_Baohanh.RowTemplate.Height = 24;
            this.dataG_Baohanh.Size = new System.Drawing.Size(683, 315);
            this.dataG_Baohanh.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.combb_Gia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.combb_LoaiSP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.date_spBaohanh);
            this.groupBox1.Controls.Add(this.btn_LocSP);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(32, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 132);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc SP đã bán";
            // 
            // combb_Gia
            // 
            this.combb_Gia.FormattingEnabled = true;
            this.combb_Gia.Location = new System.Drawing.Point(75, 96);
            this.combb_Gia.Name = "combb_Gia";
            this.combb_Gia.Size = new System.Drawing.Size(365, 24);
            this.combb_Gia.TabIndex = 6;
            this.combb_Gia.Text = "GIÁ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(27, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(9, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại SP";
            // 
            // combb_LoaiSP
            // 
            this.combb_LoaiSP.FormattingEnabled = true;
            this.combb_LoaiSP.Location = new System.Drawing.Point(75, 58);
            this.combb_LoaiSP.Name = "combb_LoaiSP";
            this.combb_LoaiSP.Size = new System.Drawing.Size(365, 24);
            this.combb_LoaiSP.TabIndex = 3;
            this.combb_LoaiSP.Text = "LOẠI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(27, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày";
            // 
            // date_spBaohanh
            // 
            this.date_spBaohanh.Location = new System.Drawing.Point(75, 21);
            this.date_spBaohanh.Name = "date_spBaohanh";
            this.date_spBaohanh.Size = new System.Drawing.Size(365, 22);
            this.date_spBaohanh.TabIndex = 1;
            // 
            // btn_LocSP
            // 
            this.btn_LocSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_LocSP.Location = new System.Drawing.Point(493, 47);
            this.btn_LocSP.Name = "btn_LocSP";
            this.btn_LocSP.Size = new System.Drawing.Size(134, 46);
            this.btn_LocSP.TabIndex = 0;
            this.btn_LocSP.Text = "LỌC";
            this.btn_LocSP.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(806, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 36);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tình trạng bảo hành";
            // 
            // txt_tinhtrang
            // 
            this.txt_tinhtrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tinhtrang.Location = new System.Drawing.Point(789, 135);
            this.txt_tinhtrang.Name = "txt_tinhtrang";
            this.txt_tinhtrang.ReadOnly = true;
            this.txt_tinhtrang.Size = new System.Drawing.Size(322, 38);
            this.txt_tinhtrang.TabIndex = 25;
            this.txt_tinhtrang.Text = "TÌNH TRẠNG";
            this.txt_tinhtrang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKH.Location = new System.Drawing.Point(789, 269);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.ReadOnly = true;
            this.txt_TenKH.Size = new System.Drawing.Size(322, 30);
            this.txt_TenKH.TabIndex = 26;
            this.txt_TenKH.Text = "Tên khách hàng";
            this.txt_TenKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(789, 319);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.ReadOnly = true;
            this.txt_sdt.Size = new System.Drawing.Size(322, 30);
            this.txt_sdt.TabIndex = 27;
            this.txt_sdt.Text = "Số điện thoại";
            this.txt_sdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Xuathoadon
            // 
            this.btn_Xuathoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xuathoadon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Xuathoadon.Location = new System.Drawing.Point(803, 398);
            this.btn_Xuathoadon.Name = "btn_Xuathoadon";
            this.btn_Xuathoadon.Size = new System.Drawing.Size(295, 46);
            this.btn_Xuathoadon.TabIndex = 7;
            this.btn_Xuathoadon.Text = "Xuất Hóa đơn Bảo hành";
            this.btn_Xuathoadon.UseVisualStyleBackColor = true;
            // 
            // Frm_BaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1187, 546);
            this.Controls.Add(this.btn_Xuathoadon);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_TenKH);
            this.Controls.Add(this.txt_tinhtrang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataG_Baohanh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_BaoHanh";
            this.Text = "Frm_BaoHanh";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_Baohanh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataG_Baohanh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combb_Gia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combb_LoaiSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_spBaohanh;
        private System.Windows.Forms.Button btn_LocSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tinhtrang;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Button btn_Xuathoadon;
    }
}