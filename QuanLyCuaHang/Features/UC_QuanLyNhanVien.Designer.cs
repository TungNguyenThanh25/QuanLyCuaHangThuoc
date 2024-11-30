namespace QuanLyCuaHang.Features
{
    partial class UC_QuanLyNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btn_xoanhanvien = new Guna.UI2.WinForms.Guna2Button();
            this.btn_suathongtinnhanvien = new Guna.UI2.WinForms.Guna2Button();
            this.btn_timnhanvien = new Guna.UI2.WinForms.Guna2Button();
            this.btn_themnhanvien = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panel_movingquanlynhanvien = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_XoaNhanVien1 = new QuanLyCuaHang.Features.UC_XoaNhanVien();
            this.uC_ThayDoiThongTinNhanVien1 = new QuanLyCuaHang.Features.UC_ThayDoiThongTinNhanVien();
            this.uC_TimNhanVien1 = new QuanLyCuaHang.Features.UC_TimNhanVien();
            this.uC_ThemNhanVien1 = new QuanLyCuaHang.Features.UC_ThemNhanVien();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(733, 15);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(255, 35);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Quản lý nhân viên";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(31, 83);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(994, 683);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.panel_movingquanlynhanvien);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_xoanhanvien);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_suathongtinnhanvien);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_timnhanvien);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_themnhanvien);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(1031, 83);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(743, 54);
            this.guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // btn_xoanhanvien
            // 
            this.btn_xoanhanvien.BorderRadius = 5;
            this.btn_xoanhanvien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoanhanvien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoanhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoanhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoanhanvien.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_xoanhanvien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoanhanvien.ForeColor = System.Drawing.Color.Black;
            this.btn_xoanhanvien.Location = new System.Drawing.Point(561, 3);
            this.btn_xoanhanvien.Name = "btn_xoanhanvien";
            this.btn_xoanhanvien.Size = new System.Drawing.Size(181, 40);
            this.btn_xoanhanvien.TabIndex = 3;
            this.btn_xoanhanvien.Text = "Xóa nhân viên";
            this.btn_xoanhanvien.Click += new System.EventHandler(this.btn_xoanhanvien_Click);
            // 
            // btn_suathongtinnhanvien
            // 
            this.btn_suathongtinnhanvien.BorderRadius = 5;
            this.btn_suathongtinnhanvien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_suathongtinnhanvien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_suathongtinnhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_suathongtinnhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_suathongtinnhanvien.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_suathongtinnhanvien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suathongtinnhanvien.ForeColor = System.Drawing.Color.Black;
            this.btn_suathongtinnhanvien.Location = new System.Drawing.Point(374, 3);
            this.btn_suathongtinnhanvien.Name = "btn_suathongtinnhanvien";
            this.btn_suathongtinnhanvien.Size = new System.Drawing.Size(181, 40);
            this.btn_suathongtinnhanvien.TabIndex = 2;
            this.btn_suathongtinnhanvien.Text = "Thay đổi thông tin";
            this.btn_suathongtinnhanvien.Click += new System.EventHandler(this.btn_suathongtinnhanvien_Click);
            // 
            // btn_timnhanvien
            // 
            this.btn_timnhanvien.BorderRadius = 5;
            this.btn_timnhanvien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_timnhanvien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_timnhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_timnhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_timnhanvien.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_timnhanvien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timnhanvien.ForeColor = System.Drawing.Color.Black;
            this.btn_timnhanvien.Location = new System.Drawing.Point(187, 3);
            this.btn_timnhanvien.Name = "btn_timnhanvien";
            this.btn_timnhanvien.Size = new System.Drawing.Size(181, 40);
            this.btn_timnhanvien.TabIndex = 1;
            this.btn_timnhanvien.Text = "Tìm nhân viên";
            this.btn_timnhanvien.Click += new System.EventHandler(this.btn_timnhanvien_Click);
            // 
            // btn_themnhanvien
            // 
            this.btn_themnhanvien.BorderRadius = 5;
            this.btn_themnhanvien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_themnhanvien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_themnhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_themnhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_themnhanvien.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_themnhanvien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themnhanvien.ForeColor = System.Drawing.Color.Black;
            this.btn_themnhanvien.Location = new System.Drawing.Point(1, 3);
            this.btn_themnhanvien.Name = "btn_themnhanvien";
            this.btn_themnhanvien.Size = new System.Drawing.Size(181, 40);
            this.btn_themnhanvien.TabIndex = 0;
            this.btn_themnhanvien.Text = "Thêm nhân viên";
            this.btn_themnhanvien.Click += new System.EventHandler(this.btn_themnhanvien_Click);
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.uC_XoaNhanVien1);
            this.guna2CustomGradientPanel2.Controls.Add(this.uC_ThayDoiThongTinNhanVien1);
            this.guna2CustomGradientPanel2.Controls.Add(this.uC_TimNhanVien1);
            this.guna2CustomGradientPanel2.Controls.Add(this.uC_ThemNhanVien1);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(1031, 143);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(743, 623);
            this.guna2CustomGradientPanel2.TabIndex = 3;
            // 
            // panel_movingquanlynhanvien
            // 
            this.panel_movingquanlynhanvien.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_movingquanlynhanvien.Location = new System.Drawing.Point(3, 44);
            this.panel_movingquanlynhanvien.Name = "panel_movingquanlynhanvien";
            this.panel_movingquanlynhanvien.Size = new System.Drawing.Size(182, 10);
            this.panel_movingquanlynhanvien.TabIndex = 0;
            this.panel_movingquanlynhanvien.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_movingquanlynhanvien_Paint);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this;
            // 
            // uC_XoaNhanVien1
            // 
            this.uC_XoaNhanVien1.BackColor = System.Drawing.Color.LightGray;
            this.uC_XoaNhanVien1.Location = new System.Drawing.Point(1, 0);
            this.uC_XoaNhanVien1.Name = "uC_XoaNhanVien1";
            this.uC_XoaNhanVien1.Size = new System.Drawing.Size(743, 623);
            this.uC_XoaNhanVien1.TabIndex = 3;
            // 
            // uC_ThayDoiThongTinNhanVien1
            // 
            this.uC_ThayDoiThongTinNhanVien1.BackColor = System.Drawing.Color.LightGray;
            this.uC_ThayDoiThongTinNhanVien1.Location = new System.Drawing.Point(1, -2);
            this.uC_ThayDoiThongTinNhanVien1.Name = "uC_ThayDoiThongTinNhanVien1";
            this.uC_ThayDoiThongTinNhanVien1.Size = new System.Drawing.Size(743, 623);
            this.uC_ThayDoiThongTinNhanVien1.TabIndex = 2;
            // 
            // uC_TimNhanVien1
            // 
            this.uC_TimNhanVien1.BackColor = System.Drawing.Color.LightGray;
            this.uC_TimNhanVien1.Location = new System.Drawing.Point(3, -3);
            this.uC_TimNhanVien1.Name = "uC_TimNhanVien1";
            this.uC_TimNhanVien1.Size = new System.Drawing.Size(740, 623);
            this.uC_TimNhanVien1.TabIndex = 1;
            this.uC_TimNhanVien1.Load += new System.EventHandler(this.uC_TimNhanVien1_Load);
            // 
            // uC_ThemNhanVien1
            // 
            this.uC_ThemNhanVien1.BackColor = System.Drawing.Color.LightGray;
            this.uC_ThemNhanVien1.Location = new System.Drawing.Point(0, 0);
            this.uC_ThemNhanVien1.Name = "uC_ThemNhanVien1";
            this.uC_ThemNhanVien1.Size = new System.Drawing.Size(743, 623);
            this.uC_ThemNhanVien1.TabIndex = 0;
            // 
            // UC_QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "UC_QuanLyNhanVien";
            this.Size = new System.Drawing.Size(1796, 800);
            this.Load += new System.EventHandler(this.UC_QuanLyNhanVien_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2Button btn_xoanhanvien;
        private Guna.UI2.WinForms.Guna2Button btn_suathongtinnhanvien;
        private Guna.UI2.WinForms.Guna2Button btn_timnhanvien;
        private Guna.UI2.WinForms.Guna2Button btn_themnhanvien;
        private Guna.UI2.WinForms.Guna2Panel panel_movingquanlynhanvien;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private UC_ThemNhanVien uC_ThemNhanVien1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private UC_TimNhanVien uC_TimNhanVien1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private UC_ThayDoiThongTinNhanVien uC_ThayDoiThongTinNhanVien1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private UC_XoaNhanVien uC_XoaNhanVien1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
    }
}
