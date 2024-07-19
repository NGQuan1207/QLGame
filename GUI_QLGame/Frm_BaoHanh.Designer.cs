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
            this.btn_LocSP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.btn_Xuathoadon = new System.Windows.Forms.Button();
            this.txt_tinhtrang = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 449);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(890, 24);
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
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(2, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "BẢO HÀNH";
            // 
            // dataG_Baohanh
            // 
            this.dataG_Baohanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG_Baohanh.Location = new System.Drawing.Point(24, 66);
            this.dataG_Baohanh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataG_Baohanh.Name = "dataG_Baohanh";
            this.dataG_Baohanh.RowHeadersWidth = 51;
            this.dataG_Baohanh.RowTemplate.Height = 24;
            this.dataG_Baohanh.Size = new System.Drawing.Size(512, 286);
            this.dataG_Baohanh.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btn_LocSP);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(24, 374);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(512, 60);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Bảo Hành";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_LocSP
            // 
            this.btn_LocSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_LocSP.Location = new System.Drawing.Point(399, 17);
            this.btn_LocSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_LocSP.Name = "btn_LocSP";
            this.btn_LocSP.Size = new System.Drawing.Size(100, 37);
            this.btn_LocSP.TabIndex = 0;
            this.btn_LocSP.Text = "TÌM KIẾM";
            this.btn_LocSP.UseVisualStyleBackColor = true;
            this.btn_LocSP.Click += new System.EventHandler(this.btn_LocSP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(604, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tình trạng bảo hành";
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKH.Location = new System.Drawing.Point(592, 239);
            this.txt_TenKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.ReadOnly = true;
            this.txt_TenKH.Size = new System.Drawing.Size(242, 26);
            this.txt_TenKH.TabIndex = 26;
            this.txt_TenKH.Text = "Tên khách hàng";
            this.txt_TenKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(592, 311);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.ReadOnly = true;
            this.txt_sdt.Size = new System.Drawing.Size(242, 26);
            this.txt_sdt.TabIndex = 27;
            this.txt_sdt.Text = "Số điện thoại";
            this.txt_sdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Xuathoadon
            // 
            this.btn_Xuathoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xuathoadon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Xuathoadon.Location = new System.Drawing.Point(592, 374);
            this.btn_Xuathoadon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Xuathoadon.Name = "btn_Xuathoadon";
            this.btn_Xuathoadon.Size = new System.Drawing.Size(242, 37);
            this.btn_Xuathoadon.TabIndex = 7;
            this.btn_Xuathoadon.Text = "Xuất Hóa đơn Bảo hành";
            this.btn_Xuathoadon.UseVisualStyleBackColor = true;
            // 
            // txt_tinhtrang
            // 
            this.txt_tinhtrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tinhtrang.Location = new System.Drawing.Point(592, 165);
            this.txt_tinhtrang.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tinhtrang.Name = "txt_tinhtrang";
            this.txt_tinhtrang.ReadOnly = true;
            this.txt_tinhtrang.Size = new System.Drawing.Size(242, 32);
            this.txt_tinhtrang.TabIndex = 25;
            this.txt_tinhtrang.Text = "TÌNH TRẠNG";
            this.txt_tinhtrang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Frm_BaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(890, 444);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btn_LocSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Button btn_Xuathoadon;
        private System.Windows.Forms.TextBox txt_tinhtrang;
        private System.Windows.Forms.TextBox textBox1;
    }
}