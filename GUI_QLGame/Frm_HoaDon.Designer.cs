namespace GUI_QLGame
{
    partial class Frm_HoaDon
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
            this.gr_box_InHoaDon = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_loc = new System.Windows.Forms.Button();
            this.btn_InHoaDon = new System.Windows.Forms.Button();
            this.lbl_hoadon = new System.Windows.Forms.Label();
            this.DtGV_InHoaDon = new System.Windows.Forms.DataGridView();
            this.gr_box_InHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGV_InHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // gr_box_InHoaDon
            // 
            this.gr_box_InHoaDon.Controls.Add(this.comboBox3);
            this.gr_box_InHoaDon.Controls.Add(this.comboBox2);
            this.gr_box_InHoaDon.Controls.Add(this.comboBox1);
            this.gr_box_InHoaDon.Controls.Add(this.btn_loc);
            this.gr_box_InHoaDon.Location = new System.Drawing.Point(423, 40);
            this.gr_box_InHoaDon.Name = "gr_box_InHoaDon";
            this.gr_box_InHoaDon.Size = new System.Drawing.Size(376, 187);
            this.gr_box_InHoaDon.TabIndex = 15;
            this.gr_box_InHoaDon.TabStop = false;
            this.gr_box_InHoaDon.Text = "Bảng chọn lọc";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(25, 105);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(181, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // btn_loc
            // 
            this.btn_loc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loc.Location = new System.Drawing.Point(267, 137);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(94, 32);
            this.btn_loc.TabIndex = 4;
            this.btn_loc.Text = "Lọc";
            this.btn_loc.UseVisualStyleBackColor = true;
            // 
            // btn_InHoaDon
            // 
            this.btn_InHoaDon.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHoaDon.Location = new System.Drawing.Point(280, 98);
            this.btn_InHoaDon.Name = "btn_InHoaDon";
            this.btn_InHoaDon.Size = new System.Drawing.Size(137, 60);
            this.btn_InHoaDon.TabIndex = 14;
            this.btn_InHoaDon.Text = "In Hóa Đơn";
            this.btn_InHoaDon.UseVisualStyleBackColor = true;
            // 
            // lbl_hoadon
            // 
            this.lbl_hoadon.AutoSize = true;
            this.lbl_hoadon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoadon.Location = new System.Drawing.Point(51, 109);
            this.lbl_hoadon.Name = "lbl_hoadon";
            this.lbl_hoadon.Size = new System.Drawing.Size(207, 32);
            this.lbl_hoadon.TabIndex = 13;
            this.lbl_hoadon.Text = "Bảng Hóa Đơn";
            // 
            // DtGV_InHoaDon
            // 
            this.DtGV_InHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGV_InHoaDon.Location = new System.Drawing.Point(9, 233);
            this.DtGV_InHoaDon.Name = "DtGV_InHoaDon";
            this.DtGV_InHoaDon.RowHeadersWidth = 51;
            this.DtGV_InHoaDon.RowTemplate.Height = 24;
            this.DtGV_InHoaDon.Size = new System.Drawing.Size(775, 296);
            this.DtGV_InHoaDon.TabIndex = 12;
            // 
            // Frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(809, 568);
            this.Controls.Add(this.gr_box_InHoaDon);
            this.Controls.Add(this.btn_InHoaDon);
            this.Controls.Add(this.lbl_hoadon);
            this.Controls.Add(this.DtGV_InHoaDon);
            this.Name = "Frm_HoaDon";
            this.Text = "Frm_HoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gr_box_InHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtGV_InHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gr_box_InHoaDon;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_loc;
        private System.Windows.Forms.Button btn_InHoaDon;
        private System.Windows.Forms.Label lbl_hoadon;
        private System.Windows.Forms.DataGridView DtGV_InHoaDon;
    }
}