namespace GUI_QLGame
{
    partial class Frm_ChiTietSanPhamThue
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
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_maspt = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_mactspt = new System.Windows.Forms.TextBox();
            this.dtgv_chitietsanphamthue = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_chitietsanphamthue)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(825, 23);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(207, 63);
            this.btn_sua.TabIndex = 40;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(825, 103);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(207, 63);
            this.btn_xoa.TabIndex = 39;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(12, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 22);
            this.label6.TabIndex = 37;
            this.label6.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 22);
            this.label5.TabIndex = 36;
            this.label5.Text = "Mã Sản Phẩm Thuê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "Số Lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mã Chi Tiết Sản Phẩm Thuê";
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayLai.Location = new System.Drawing.Point(825, 184);
            this.btn_QuayLai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(207, 63);
            this.btn_QuayLai.TabIndex = 32;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // txt_gia
            // 
            this.txt_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gia.Location = new System.Drawing.Point(149, 206);
            this.txt_gia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(252, 27);
            this.txt_gia.TabIndex = 30;
            // 
            // txt_maspt
            // 
            this.txt_maspt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maspt.Location = new System.Drawing.Point(252, 89);
            this.txt_maspt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_maspt.Name = "txt_maspt";
            this.txt_maspt.Size = new System.Drawing.Size(252, 27);
            this.txt_maspt.TabIndex = 29;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.Location = new System.Drawing.Point(149, 153);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(252, 27);
            this.txt_soluong.TabIndex = 27;
            // 
            // txt_mactspt
            // 
            this.txt_mactspt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mactspt.Location = new System.Drawing.Point(322, 36);
            this.txt_mactspt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_mactspt.Name = "txt_mactspt";
            this.txt_mactspt.Size = new System.Drawing.Size(252, 27);
            this.txt_mactspt.TabIndex = 26;
            // 
            // dtgv_chitietsanphamthue
            // 
            this.dtgv_chitietsanphamthue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_chitietsanphamthue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_chitietsanphamthue.Location = new System.Drawing.Point(34, 306);
            this.dtgv_chitietsanphamthue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgv_chitietsanphamthue.Name = "dtgv_chitietsanphamthue";
            this.dtgv_chitietsanphamthue.RowHeadersWidth = 51;
            this.dtgv_chitietsanphamthue.RowTemplate.Height = 24;
            this.dtgv_chitietsanphamthue.Size = new System.Drawing.Size(1155, 326);
            this.dtgv_chitietsanphamthue.TabIndex = 25;
            this.dtgv_chitietsanphamthue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_chitietsanphamthue_CellClick);
            this.dtgv_chitietsanphamthue.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_chitietsanphamthue_CellContentDoubleClick);
            this.dtgv_chitietsanphamthue.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_chitietsanphamthue_CellDoubleClick);
            // 
            // Frm_ChiTietSanPhamThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 661);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.txt_maspt);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.txt_mactspt);
            this.Controls.Add(this.dtgv_chitietsanphamthue);
            this.Name = "Frm_ChiTietSanPhamThue";
            this.Text = "Chi Tiết Sản Phẩm Thuê";
            this.Load += new System.EventHandler(this.Frm_ChiTietSanPhamThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_chitietsanphamthue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_maspt;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_mactspt;
        private System.Windows.Forms.DataGridView dtgv_chitietsanphamthue;
    }
}