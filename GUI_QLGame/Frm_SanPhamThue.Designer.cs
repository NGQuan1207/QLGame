﻿namespace GUI_QLGame
{
    partial class Frm_SanPhamThue
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_loc = new System.Windows.Forms.Button();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_thue = new System.Windows.Forms.DataGridView();
            this.txt_loaisp = new System.Windows.Forms.TextBox();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_chonanh = new System.Windows.Forms.Button();
            this.txt_HinhAnh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(283, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Hình ảnh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Loại SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Tên SP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Mã SP ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_loc);
            this.groupBox1.Controls.Add(this.txt_Tim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(499, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(352, 93);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng lựa chọn lọc SP";
            // 
            // btn_loc
            // 
            this.btn_loc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_loc.Location = new System.Drawing.Point(232, 38);
            this.btn_loc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(104, 24);
            this.btn_loc.TabIndex = 44;
            this.btn_loc.Text = "Lọc";
            this.btn_loc.UseVisualStyleBackColor = false;
            this.btn_loc.Click += new System.EventHandler(this.btn_loc_Click);
            // 
            // txt_Tim
            // 
            this.txt_Tim.Location = new System.Drawing.Point(21, 38);
            this.txt_Tim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(144, 26);
            this.txt_Tim.TabIndex = 30;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(730, 32);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(104, 24);
            this.btn_xoa.TabIndex = 59;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(499, 32);
            this.btn_them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(104, 24);
            this.btn_them.TabIndex = 58;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_thue
            // 
            this.dgv_thue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_thue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thue.Location = new System.Drawing.Point(42, 210);
            this.dgv_thue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_thue.Name = "dgv_thue";
            this.dgv_thue.RowHeadersWidth = 62;
            this.dgv_thue.RowTemplate.Height = 28;
            this.dgv_thue.Size = new System.Drawing.Size(809, 203);
            this.dgv_thue.TabIndex = 57;
            this.dgv_thue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thue_CellClick);
            this.dgv_thue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thue_CellContentClick);
            this.dgv_thue.SelectionChanged += new System.EventHandler(this.dgv_thue_SelectionChanged);
            // 
            // txt_loaisp
            // 
            this.txt_loaisp.Location = new System.Drawing.Point(93, 124);
            this.txt_loaisp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_loaisp.Name = "txt_loaisp";
            this.txt_loaisp.Size = new System.Drawing.Size(127, 20);
            this.txt_loaisp.TabIndex = 54;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(93, 171);
            this.txt_ghichu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(127, 20);
            this.txt_ghichu.TabIndex = 53;
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(93, 83);
            this.txt_tensp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(127, 20);
            this.txt_tensp.TabIndex = 52;
            // 
            // txt_masp
            // 
            this.txt_masp.Location = new System.Drawing.Point(93, 41);
            this.txt_masp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(127, 20);
            this.txt_masp.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(49, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 26);
            this.label1.TabIndex = 50;
            this.label1.Text = "Bảng sản phẩm thuê";
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(619, 31);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(97, 26);
            this.btn_sua.TabIndex = 67;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_chonanh
            // 
            this.btn_chonanh.Location = new System.Drawing.Point(258, 172);
            this.btn_chonanh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_chonanh.Name = "btn_chonanh";
            this.btn_chonanh.Size = new System.Drawing.Size(66, 19);
            this.btn_chonanh.TabIndex = 68;
            this.btn_chonanh.Text = "chọn ảnh";
            this.btn_chonanh.UseVisualStyleBackColor = true;
            this.btn_chonanh.Click += new System.EventHandler(this.btn_chonanh_Click);
            // 
            // txt_HinhAnh
            // 
            this.txt_HinhAnh.Location = new System.Drawing.Point(341, 172);
            this.txt_HinhAnh.Name = "txt_HinhAnh";
            this.txt_HinhAnh.Size = new System.Drawing.Size(100, 20);
            this.txt_HinhAnh.TabIndex = 69;
            // 
            // Frm_SanPhamThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(890, 416);
            this.Controls.Add(this.txt_HinhAnh);
            this.Controls.Add(this.btn_chonanh);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_thue);
            this.Controls.Add(this.txt_loaisp);
            this.Controls.Add(this.txt_ghichu);
            this.Controls.Add(this.txt_tensp);
            this.Controls.Add(this.txt_masp);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_SanPhamThue";
            this.Text = "Sản Phẩm Thuê";
            this.Load += new System.EventHandler(this.Frm_SanPhamThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_loc;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_thue;
        private System.Windows.Forms.TextBox txt_loaisp;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_chonanh;
        private System.Windows.Forms.TextBox txt_HinhAnh;
    }
}