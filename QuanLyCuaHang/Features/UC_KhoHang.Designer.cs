namespace QuanLyCuaHang.All_User_Control
{
    partial class UC_KhoHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_themsanphamkhohang = new Guna.UI2.WinForms.Guna2Button();
            this.btn_suasanphamkhohang = new Guna.UI2.WinForms.Guna2Button();
            this.btn_xoasanphamkhohang = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel_movingkhohang = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_SuaSanPham1 = new QuanLyCuaHang.Features.UC_SuaSanPham();
            this.uC_XoaSanPham1 = new QuanLyCuaHang.Features.UC_XoaSanPham();
            this.uC_ThemSanPham1 = new QuanLyCuaHang.Features.UC_ThemSanPham();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(707, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kho Hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 103);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 642);
            this.dataGridView1.TabIndex = 4;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btn_themsanphamkhohang
            // 
            this.btn_themsanphamkhohang.BackColor = System.Drawing.Color.Transparent;
            this.btn_themsanphamkhohang.BorderRadius = 5;
            this.btn_themsanphamkhohang.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_themsanphamkhohang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_themsanphamkhohang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_themsanphamkhohang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_themsanphamkhohang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_themsanphamkhohang.FillColor = System.Drawing.Color.PowderBlue;
            this.btn_themsanphamkhohang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themsanphamkhohang.ForeColor = System.Drawing.Color.Black;
            this.btn_themsanphamkhohang.Location = new System.Drawing.Point(1193, 44);
            this.btn_themsanphamkhohang.Name = "btn_themsanphamkhohang";
            this.btn_themsanphamkhohang.Size = new System.Drawing.Size(185, 45);
            this.btn_themsanphamkhohang.TabIndex = 6;
            this.btn_themsanphamkhohang.Text = "Thêm sản phẩm";
            this.btn_themsanphamkhohang.Click += new System.EventHandler(this.btn_themsanpham_Click);
            // 
            // btn_suasanphamkhohang
            // 
            this.btn_suasanphamkhohang.BorderRadius = 5;
            this.btn_suasanphamkhohang.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_suasanphamkhohang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_suasanphamkhohang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_suasanphamkhohang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_suasanphamkhohang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_suasanphamkhohang.FillColor = System.Drawing.Color.PowderBlue;
            this.btn_suasanphamkhohang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suasanphamkhohang.ForeColor = System.Drawing.Color.Black;
            this.btn_suasanphamkhohang.Location = new System.Drawing.Point(1573, 42);
            this.btn_suasanphamkhohang.Name = "btn_suasanphamkhohang";
            this.btn_suasanphamkhohang.Size = new System.Drawing.Size(185, 45);
            this.btn_suasanphamkhohang.TabIndex = 7;
            this.btn_suasanphamkhohang.Text = "Sửa sản phẩm";
            this.btn_suasanphamkhohang.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btn_xoasanphamkhohang
            // 
            this.btn_xoasanphamkhohang.BorderRadius = 5;
            this.btn_xoasanphamkhohang.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_xoasanphamkhohang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoasanphamkhohang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoasanphamkhohang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoasanphamkhohang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoasanphamkhohang.FillColor = System.Drawing.Color.PowderBlue;
            this.btn_xoasanphamkhohang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoasanphamkhohang.ForeColor = System.Drawing.Color.Black;
            this.btn_xoasanphamkhohang.Location = new System.Drawing.Point(1384, 42);
            this.btn_xoasanphamkhohang.Name = "btn_xoasanphamkhohang";
            this.btn_xoasanphamkhohang.Size = new System.Drawing.Size(185, 45);
            this.btn_xoasanphamkhohang.TabIndex = 8;
            this.btn_xoasanphamkhohang.Text = "Xóa sản phẩm";
            this.btn_xoasanphamkhohang.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.uC_SuaSanPham1);
            this.guna2Panel1.Controls.Add(this.uC_XoaSanPham1);
            this.guna2Panel1.Controls.Add(this.uC_ThemSanPham1);
            this.guna2Panel1.Location = new System.Drawing.Point(1193, 103);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(562, 642);
            this.guna2Panel1.TabIndex = 9;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // panel_movingkhohang
            // 
            this.panel_movingkhohang.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_movingkhohang.BorderRadius = 5;
            this.panel_movingkhohang.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.panel_movingkhohang.Location = new System.Drawing.Point(1195, 91);
            this.panel_movingkhohang.Name = "panel_movingkhohang";
            this.panel_movingkhohang.Size = new System.Drawing.Size(185, 10);
            this.panel_movingkhohang.TabIndex = 11;
            this.panel_movingkhohang.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this;
            // 
            // uC_SuaSanPham1
            // 
            this.uC_SuaSanPham1.Location = new System.Drawing.Point(-5, -9);
            this.uC_SuaSanPham1.Name = "uC_SuaSanPham1";
            this.uC_SuaSanPham1.Size = new System.Drawing.Size(559, 644);
            this.uC_SuaSanPham1.TabIndex = 2;
            this.uC_SuaSanPham1.Load += new System.EventHandler(this.uC_SuaSanPham1_Load);
            // 
            // uC_XoaSanPham1
            // 
            this.uC_XoaSanPham1.Location = new System.Drawing.Point(-6, -10);
            this.uC_XoaSanPham1.Name = "uC_XoaSanPham1";
            this.uC_XoaSanPham1.Size = new System.Drawing.Size(559, 642);
            this.uC_XoaSanPham1.TabIndex = 1;
            this.uC_XoaSanPham1.Load += new System.EventHandler(this.uC_XoaSanPham1_Load);
            // 
            // uC_ThemSanPham1
            // 
            this.uC_ThemSanPham1.Location = new System.Drawing.Point(-6, -8);
            this.uC_ThemSanPham1.Name = "uC_ThemSanPham1";
            this.uC_ThemSanPham1.Size = new System.Drawing.Size(587, 652);
            this.uC_ThemSanPham1.TabIndex = 0;
            this.uC_ThemSanPham1.Load += new System.EventHandler(this.uC_ThemSanPham1_Load);
            // 
            // UC_KhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.panel_movingkhohang);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btn_xoasanphamkhohang);
            this.Controls.Add(this.btn_suasanphamkhohang);
            this.Controls.Add(this.btn_themsanphamkhohang);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_KhoHang";
            this.Size = new System.Drawing.Size(2249, 971);
            this.Load += new System.EventHandler(this.UC_KhoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btn_themsanphamkhohang;
        private Guna.UI2.WinForms.Guna2Button btn_xoasanphamkhohang;
        private Guna.UI2.WinForms.Guna2Button btn_suasanphamkhohang;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Features.UC_ThemSanPham uC_ThemSanPham1;
        private Guna.UI2.WinForms.Guna2Panel panel_movingkhohang;
        private Features.UC_XoaSanPham uC_XoaSanPham1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Features.UC_SuaSanPham uC_SuaSanPham1;
    }
}
