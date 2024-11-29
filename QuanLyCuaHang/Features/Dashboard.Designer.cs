﻿namespace QuanLyCuaHang
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_kho = new Guna.UI2.WinForms.Guna2Button();
            this.btn_hoadon = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_moving = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_lichsumua = new Guna.UI2.WinForms.Guna2Button();
            this.button_doanhthu = new Guna.UI2.WinForms.Guna2Button();
            this.button_khuyenmai = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cuahang = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_HoaDon2 = new QuanLyCuaHang.UC_HoaDon();
            this.uC_LichSuMua1 = new QuanLyCuaHang.UC_LichSuMua();
            this.uC_DoanhThu1 = new QuanLyCuaHang.UC_DoanhThu();
            this.uC_KhuyenMai1 = new QuanLyCuaHang.UC_KhuyenMai();
            this.uC_KhoHang2 = new QuanLyCuaHang.UC_KhoHang();
            this.uC_CuaHang3 = new QuanLyCuaHang.UC_CuaHang();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_dangxuat = new Guna.UI2.WinForms.Guna2Button();
            this.timer_logout = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.FillColor = System.Drawing.Color.Transparent;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_exit.Location = new System.Drawing.Point(-1, -1);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(49, 47);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_kho
            // 
            this.btn_kho.BackColor = System.Drawing.Color.Transparent;
            this.btn_kho.BorderRadius = 3;
            this.btn_kho.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_kho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_kho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_kho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_kho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_kho.FillColor = System.Drawing.Color.LightBlue;
            this.btn_kho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kho.ForeColor = System.Drawing.Color.Black;
            this.btn_kho.Location = new System.Drawing.Point(607, 4);
            this.btn_kho.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kho.Name = "btn_kho";
            this.btn_kho.Size = new System.Drawing.Size(300, 43);
            this.btn_kho.TabIndex = 1;
            this.btn_kho.Text = "Kho";
            this.btn_kho.Click += new System.EventHandler(this.btn_kho_Click);
            // 
            // btn_hoadon
            // 
            this.btn_hoadon.BackColor = System.Drawing.Color.Transparent;
            this.btn_hoadon.BorderRadius = 3;
            this.btn_hoadon.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_hoadon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_hoadon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_hoadon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_hoadon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_hoadon.FillColor = System.Drawing.Color.LightBlue;
            this.btn_hoadon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hoadon.ForeColor = System.Drawing.Color.Black;
            this.btn_hoadon.Location = new System.Drawing.Point(304, 4);
            this.btn_hoadon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hoadon.Name = "btn_hoadon";
            this.btn_hoadon.Size = new System.Drawing.Size(300, 43);
            this.btn_hoadon.TabIndex = 2;
            this.btn_hoadon.Text = "Hóa Đơn";
            this.btn_hoadon.Click += new System.EventHandler(this.btn_hoadon_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel1.Controls.Add(this.btn_kho);
            this.guna2Panel1.Controls.Add(this.panel_moving);
            this.guna2Panel1.Controls.Add(this.btn_hoadon);
            this.guna2Panel1.Controls.Add(this.btn_lichsumua);
            this.guna2Panel1.Controls.Add(this.button_doanhthu);
            this.guna2Panel1.Controls.Add(this.button_khuyenmai);
            this.guna2Panel1.Controls.Add(this.btn_cuahang);
            this.guna2Panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(19, 64);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1816, 71);
            this.guna2Panel1.TabIndex = 2;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // panel_moving
            // 
            this.panel_moving.BackColor = System.Drawing.Color.Transparent;
            this.panel_moving.BorderRadius = 3;
            this.panel_moving.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_moving.Location = new System.Drawing.Point(1, 50);
            this.panel_moving.Margin = new System.Windows.Forms.Padding(4);
            this.panel_moving.Name = "panel_moving";
            this.panel_moving.Size = new System.Drawing.Size(300, 12);
            this.panel_moving.TabIndex = 6;
            this.panel_moving.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_moving_Paint);
            // 
            // btn_lichsumua
            // 
            this.btn_lichsumua.BackColor = System.Drawing.Color.Transparent;
            this.btn_lichsumua.BorderRadius = 3;
            this.btn_lichsumua.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_lichsumua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_lichsumua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_lichsumua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_lichsumua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_lichsumua.FillColor = System.Drawing.Color.LightBlue;
            this.btn_lichsumua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lichsumua.ForeColor = System.Drawing.Color.Black;
            this.btn_lichsumua.Location = new System.Drawing.Point(1213, 4);
            this.btn_lichsumua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lichsumua.Name = "btn_lichsumua";
            this.btn_lichsumua.Size = new System.Drawing.Size(300, 43);
            this.btn_lichsumua.TabIndex = 8;
            this.btn_lichsumua.Text = "Lịch sử hóa đơn";
            this.btn_lichsumua.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // button_doanhthu
            // 
            this.button_doanhthu.BackColor = System.Drawing.Color.Transparent;
            this.button_doanhthu.BorderRadius = 3;
            this.button_doanhthu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.button_doanhthu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_doanhthu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_doanhthu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_doanhthu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_doanhthu.FillColor = System.Drawing.Color.LightBlue;
            this.button_doanhthu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_doanhthu.ForeColor = System.Drawing.Color.Black;
            this.button_doanhthu.Location = new System.Drawing.Point(1516, 4);
            this.button_doanhthu.Margin = new System.Windows.Forms.Padding(4);
            this.button_doanhthu.Name = "button_doanhthu";
            this.button_doanhthu.Size = new System.Drawing.Size(300, 43);
            this.button_doanhthu.TabIndex = 7;
            this.button_doanhthu.Text = "Doanh Thu";
            this.button_doanhthu.Click += new System.EventHandler(this.button_doanhthu_Click);
            // 
            // button_khuyenmai
            // 
            this.button_khuyenmai.BackColor = System.Drawing.Color.Transparent;
            this.button_khuyenmai.BorderRadius = 3;
            this.button_khuyenmai.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.button_khuyenmai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_khuyenmai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_khuyenmai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_khuyenmai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_khuyenmai.FillColor = System.Drawing.Color.LightBlue;
            this.button_khuyenmai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_khuyenmai.ForeColor = System.Drawing.Color.Black;
            this.button_khuyenmai.Location = new System.Drawing.Point(909, 4);
            this.button_khuyenmai.Margin = new System.Windows.Forms.Padding(4);
            this.button_khuyenmai.Name = "button_khuyenmai";
            this.button_khuyenmai.Size = new System.Drawing.Size(300, 43);
            this.button_khuyenmai.TabIndex = 6;
            this.button_khuyenmai.Text = "Khuyến mãi";
            this.button_khuyenmai.Click += new System.EventHandler(this.button_khuyenmai_Click);
            // 
            // btn_cuahang
            // 
            this.btn_cuahang.BackColor = System.Drawing.Color.Transparent;
            this.btn_cuahang.BorderRadius = 3;
            this.btn_cuahang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_cuahang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cuahang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cuahang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cuahang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cuahang.FillColor = System.Drawing.Color.LightBlue;
            this.btn_cuahang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cuahang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cuahang.Location = new System.Drawing.Point(1, 4);
            this.btn_cuahang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cuahang.Name = "btn_cuahang";
            this.btn_cuahang.Size = new System.Drawing.Size(300, 43);
            this.btn_cuahang.TabIndex = 4;
            this.btn_cuahang.Text = "Cửa Hàng";
            this.btn_cuahang.Click += new System.EventHandler(this.btn_cuahang_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Panel2.Controls.Add(this.uC_HoaDon2);
            this.guna2Panel2.Controls.Add(this.uC_LichSuMua1);
            this.guna2Panel2.Controls.Add(this.uC_DoanhThu1);
            this.guna2Panel2.Controls.Add(this.uC_KhuyenMai1);
            this.guna2Panel2.Controls.Add(this.uC_KhoHang2);
            this.guna2Panel2.Controls.Add(this.uC_CuaHang3);
            this.guna2Panel2.Location = new System.Drawing.Point(19, 139);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1798, 798);
            this.guna2Panel2.TabIndex = 3;
            // 
            // uC_HoaDon2
            // 
            this.uC_HoaDon2.BackColor = System.Drawing.Color.LightBlue;
            this.uC_HoaDon2.Location = new System.Drawing.Point(0, -7);
            this.uC_HoaDon2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_HoaDon2.Name = "uC_HoaDon2";
            this.uC_HoaDon2.Size = new System.Drawing.Size(1797, 807);
            this.uC_HoaDon2.TabIndex = 7;
            this.uC_HoaDon2.Load += new System.EventHandler(this.uC_HoaDon2_Load);
            // 
            // uC_LichSuMua1
            // 
            this.uC_LichSuMua1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uC_LichSuMua1.Location = new System.Drawing.Point(-1, -7);
            this.uC_LichSuMua1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_LichSuMua1.Name = "uC_LichSuMua1";
            this.uC_LichSuMua1.Size = new System.Drawing.Size(1812, 812);
            this.uC_LichSuMua1.TabIndex = 5;
            this.uC_LichSuMua1.Load += new System.EventHandler(this.uC_LichSuMua1_Load);
            // 
            // uC_DoanhThu1
            // 
            this.uC_DoanhThu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uC_DoanhThu1.Location = new System.Drawing.Point(-1, -7);
            this.uC_DoanhThu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_DoanhThu1.Name = "uC_DoanhThu1";
            this.uC_DoanhThu1.Size = new System.Drawing.Size(1799, 812);
            this.uC_DoanhThu1.TabIndex = 4;
            // 
            // uC_KhuyenMai1
            // 
            this.uC_KhuyenMai1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uC_KhuyenMai1.Location = new System.Drawing.Point(-3, 0);
            this.uC_KhuyenMai1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_KhuyenMai1.Name = "uC_KhuyenMai1";
            this.uC_KhuyenMai1.Size = new System.Drawing.Size(1797, 805);
            this.uC_KhuyenMai1.TabIndex = 3;
            this.uC_KhuyenMai1.Load += new System.EventHandler(this.uC_KhuyenMai1_Load);
            // 
            // uC_KhoHang2
            // 
            this.uC_KhoHang2.BackColor = System.Drawing.Color.AliceBlue;
            this.uC_KhoHang2.Location = new System.Drawing.Point(0, 2);
            this.uC_KhoHang2.Margin = new System.Windows.Forms.Padding(5);
            this.uC_KhoHang2.Name = "uC_KhoHang2";
            this.uC_KhoHang2.Size = new System.Drawing.Size(1797, 807);
            this.uC_KhoHang2.TabIndex = 2;
            // 
            // uC_CuaHang3
            // 
            this.uC_CuaHang3.BackColor = System.Drawing.Color.AliceBlue;
            this.uC_CuaHang3.Location = new System.Drawing.Point(3, 2);
            this.uC_CuaHang3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_CuaHang3.Name = "uC_CuaHang3";
            this.uC_CuaHang3.Size = new System.Drawing.Size(1797, 796);
            this.uC_CuaHang3.TabIndex = 0;
            this.uC_CuaHang3.Load += new System.EventHandler(this.uC_CuaHang3_Load);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.BorderRadius = 5;
            this.btn_dangxuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dangxuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dangxuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dangxuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dangxuat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_dangxuat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_dangxuat.ForeColor = System.Drawing.Color.Black;
            this.btn_dangxuat.Location = new System.Drawing.Point(1637, 10);
            this.btn_dangxuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(180, 46);
            this.btn_dangxuat.TabIndex = 4;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // timer_logout
            // 
            this.timer_logout.Tick += new System.EventHandler(this.timer_logout_Tick);
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
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.BorderRadius = 5;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.IconLeftSize = new System.Drawing.Size(40, 30);
            this.guna2TextBox1.Location = new System.Drawing.Point(1316, 12);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.ReadOnly = true;
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(318, 44);
            this.guna2TextBox1.TabIndex = 5;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.TargetControl = this;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1860, 974);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.btn_dangxuat);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2Button btn_kho;
        private Guna.UI2.WinForms.Guna2Button btn_hoadon;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_cuahang;
        private Guna.UI2.WinForms.Guna2Panel panel_moving;
        private UC_KhoHang uC_KhoHang1;
       


        private Guna.UI2.WinForms.Guna2Button button_khuyenmai;
        private Guna.UI2.WinForms.Guna2Button button_doanhthu;
        private Guna.UI2.WinForms.Guna2Button btn_lichsumua;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

        private UC_CuaHang uC_CuaHang2;
        private UC_CuaHang uC_CuaHang1;
        private Guna.UI2.WinForms.Guna2Button btn_dangxuat;
        private System.Windows.Forms.Timer timer_logout;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private UC_CuaHang uC_CuaHang3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private UC_KhoHang uC_KhoHang2;
        private UC_KhuyenMai uC_KhuyenMai1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private UC_DoanhThu uC_DoanhThu1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private UC_LichSuMua uC_LichSuMua1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private UC_HoaDon uC_HoaDon2;
    }
}