namespace GUI_QLGame
{
    partial class Frm_ThayDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ThayDoiMatKhau));
            this.picImgDN = new System.Windows.Forms.PictureBox();
            this.lbl_TieuDe = new System.Windows.Forms.Label();
            this.lblNhapMKM = new System.Windows.Forms.Label();
            this.txt_matkhaucu = new System.Windows.Forms.TextBox();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.lblMatKhauCu = new System.Windows.Forms.Label();
            this.lblEmailDN = new System.Windows.Forms.Label();
            this.btn_DoiMK = new System.Windows.Forms.Button();
            this.txt_nhaplaimatkhaumoi = new System.Windows.Forms.TextBox();
            this.txt_nhapmatkhaumoi = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImgDN)).BeginInit();
            this.SuspendLayout();
            // 
            // picImgDN
            // 
            this.picImgDN.Image = ((System.Drawing.Image)(resources.GetObject("picImgDN.Image")));
            this.picImgDN.InitialImage = ((System.Drawing.Image)(resources.GetObject("picImgDN.InitialImage")));
            this.picImgDN.Location = new System.Drawing.Point(29, 20);
            this.picImgDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picImgDN.Name = "picImgDN";
            this.picImgDN.Size = new System.Drawing.Size(85, 64);
            this.picImgDN.TabIndex = 78;
            this.picImgDN.TabStop = false;
            // 
            // lbl_TieuDe
            // 
            this.lbl_TieuDe.AutoSize = true;
            this.lbl_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe.Location = new System.Drawing.Point(120, 46);
            this.lbl_TieuDe.Name = "lbl_TieuDe";
            this.lbl_TieuDe.Size = new System.Drawing.Size(375, 38);
            this.lbl_TieuDe.TabIndex = 77;
            this.lbl_TieuDe.Text = "Đổi Mật Khẩu Nhân Viên";
            // 
            // lblNhapMKM
            // 
            this.lblNhapMKM.AutoSize = true;
            this.lblNhapMKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapMKM.Location = new System.Drawing.Point(122, 401);
            this.lblNhapMKM.Name = "lblNhapMKM";
            this.lblNhapMKM.Size = new System.Drawing.Size(261, 29);
            this.lblNhapMKM.TabIndex = 76;
            this.lblNhapMKM.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // txt_matkhaucu
            // 
            this.txt_matkhaucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhaucu.Location = new System.Drawing.Point(128, 239);
            this.txt_matkhaucu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_matkhaucu.Name = "txt_matkhaucu";
            this.txt_matkhaucu.Size = new System.Drawing.Size(439, 38);
            this.txt_matkhaucu.TabIndex = 75;
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhauMoi.Location = new System.Drawing.Point(122, 299);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(159, 29);
            this.lblMatKhauMoi.TabIndex = 74;
            this.lblMatKhauMoi.Text = "Mật Khẩu Mới";
            // 
            // lblMatKhauCu
            // 
            this.lblMatKhauCu.AutoSize = true;
            this.lblMatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhauCu.Location = new System.Drawing.Point(122, 207);
            this.lblMatKhauCu.Name = "lblMatKhauCu";
            this.lblMatKhauCu.Size = new System.Drawing.Size(149, 29);
            this.lblMatKhauCu.TabIndex = 73;
            this.lblMatKhauCu.Text = "Mật Khẩu Cũ";
            // 
            // lblEmailDN
            // 
            this.lblEmailDN.AutoSize = true;
            this.lblEmailDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailDN.Location = new System.Drawing.Point(122, 107);
            this.lblEmailDN.Name = "lblEmailDN";
            this.lblEmailDN.Size = new System.Drawing.Size(201, 29);
            this.lblEmailDN.TabIndex = 72;
            this.lblEmailDN.Text = "Email Đăng Nhập";
            // 
            // btn_DoiMK
            // 
            this.btn_DoiMK.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_DoiMK.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiMK.Location = new System.Drawing.Point(204, 502);
            this.btn_DoiMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DoiMK.Name = "btn_DoiMK";
            this.btn_DoiMK.Size = new System.Drawing.Size(300, 64);
            this.btn_DoiMK.TabIndex = 71;
            this.btn_DoiMK.Text = "Thay Đổi Mật Khẩu";
            this.btn_DoiMK.UseVisualStyleBackColor = false;
            this.btn_DoiMK.Click += new System.EventHandler(this.btn_DoiMK_Click);
            // 
            // txt_nhaplaimatkhaumoi
            // 
            this.txt_nhaplaimatkhaumoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhaplaimatkhaumoi.Location = new System.Drawing.Point(128, 433);
            this.txt_nhaplaimatkhaumoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nhaplaimatkhaumoi.Name = "txt_nhaplaimatkhaumoi";
            this.txt_nhaplaimatkhaumoi.Size = new System.Drawing.Size(439, 38);
            this.txt_nhaplaimatkhaumoi.TabIndex = 70;
            // 
            // txt_nhapmatkhaumoi
            // 
            this.txt_nhapmatkhaumoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhapmatkhaumoi.Location = new System.Drawing.Point(128, 331);
            this.txt_nhapmatkhaumoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nhapmatkhaumoi.Name = "txt_nhapmatkhaumoi";
            this.txt_nhapmatkhaumoi.Size = new System.Drawing.Size(439, 38);
            this.txt_nhapmatkhaumoi.TabIndex = 69;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(128, 139);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(439, 38);
            this.txt_email.TabIndex = 68;
            // 
            // Frm_ThayDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(705, 595);
            this.Controls.Add(this.picImgDN);
            this.Controls.Add(this.lbl_TieuDe);
            this.Controls.Add(this.lblNhapMKM);
            this.Controls.Add(this.txt_matkhaucu);
            this.Controls.Add(this.lblMatKhauMoi);
            this.Controls.Add(this.lblMatKhauCu);
            this.Controls.Add(this.lblEmailDN);
            this.Controls.Add(this.btn_DoiMK);
            this.Controls.Add(this.txt_nhaplaimatkhaumoi);
            this.Controls.Add(this.txt_nhapmatkhaumoi);
            this.Controls.Add(this.txt_email);
            this.Name = "Frm_ThayDoiMatKhau";
            this.Text = "Thay Đổi Mật Khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.picImgDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImgDN;
        private System.Windows.Forms.Label lbl_TieuDe;
        private System.Windows.Forms.Label lblNhapMKM;
        private System.Windows.Forms.TextBox txt_matkhaucu;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.Label lblMatKhauCu;
        private System.Windows.Forms.Label lblEmailDN;
        private System.Windows.Forms.Button btn_DoiMK;
        private System.Windows.Forms.TextBox txt_nhaplaimatkhaumoi;
        private System.Windows.Forms.TextBox txt_nhapmatkhaumoi;
        private System.Windows.Forms.TextBox txt_email;
    }
}