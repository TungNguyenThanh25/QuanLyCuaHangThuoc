namespace QuanLyCuaHang
{
    partial class UC_DoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_doanhthunam = new Guna.UI2.WinForms.Guna2Button();
            this.btn_doanhthuthang = new Guna.UI2.WinForms.Guna2Button();
            this.panel_movingdoanhthu = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_DoanhThuNam1 = new QuanLyCuaHang.UC_DoanhThuNam();
            this.uC_DoanhThuThang1 = new QuanLyCuaHang.UC_DoanhThuThang();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(803, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh thu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(914, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tổng doanh thu trong ngày:\r\n";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(394, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tổng số lượng hóa đơn trong ngày:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(74, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 38);
            this.label8.TabIndex = 9;
            this.label8.Text = "Doanh thu ngày";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2TextBox1.BorderRadius = 5;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(512, 91);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.ReadOnly = true;
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(286, 31);
            this.guna2TextBox1.TabIndex = 12;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2TextBox2.BorderRadius = 5;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(1271, 91);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.ReadOnly = true;
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(372, 33);
            this.guna2TextBox2.TabIndex = 13;
            this.guna2TextBox2.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.chart1);
            this.guna2Panel1.Controls.Add(this.uC_DoanhThuNam1);
            this.guna2Panel1.Controls.Add(this.uC_DoanhThuThang1);
            this.guna2Panel1.Location = new System.Drawing.Point(49, 194);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1720, 559);
            this.guna2Panel1.TabIndex = 14;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btn_doanhthunam
            // 
            this.btn_doanhthunam.BackColor = System.Drawing.Color.Transparent;
            this.btn_doanhthunam.BorderRadius = 5;
            this.btn_doanhthunam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_doanhthunam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_doanhthunam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_doanhthunam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_doanhthunam.FillColor = System.Drawing.Color.LightBlue;
            this.btn_doanhthunam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doanhthunam.ForeColor = System.Drawing.Color.Black;
            this.btn_doanhthunam.Location = new System.Drawing.Point(913, 144);
            this.btn_doanhthunam.Name = "btn_doanhthunam";
            this.btn_doanhthunam.Size = new System.Drawing.Size(856, 39);
            this.btn_doanhthunam.TabIndex = 17;
            this.btn_doanhthunam.Text = "Doanh thu năm";
            this.btn_doanhthunam.Click += new System.EventHandler(this.btn_doanhthunam_Click);
            // 
            // btn_doanhthuthang
            // 
            this.btn_doanhthuthang.BackColor = System.Drawing.Color.Transparent;
            this.btn_doanhthuthang.BorderRadius = 5;
            this.btn_doanhthuthang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_doanhthuthang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_doanhthuthang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_doanhthuthang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_doanhthuthang.FillColor = System.Drawing.Color.LightBlue;
            this.btn_doanhthuthang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doanhthuthang.ForeColor = System.Drawing.Color.Black;
            this.btn_doanhthuthang.Location = new System.Drawing.Point(49, 144);
            this.btn_doanhthuthang.Name = "btn_doanhthuthang";
            this.btn_doanhthuthang.Size = new System.Drawing.Size(856, 39);
            this.btn_doanhthuthang.TabIndex = 18;
            this.btn_doanhthuthang.Text = "Doanh thu tháng";
            this.btn_doanhthuthang.Click += new System.EventHandler(this.btn_doanhthuthang_Click);
            // 
            // panel_movingdoanhthu
            // 
            this.panel_movingdoanhthu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_movingdoanhthu.BorderRadius = 5;
            this.panel_movingdoanhthu.Location = new System.Drawing.Point(49, 184);
            this.panel_movingdoanhthu.Name = "panel_movingdoanhthu";
            this.panel_movingdoanhthu.Size = new System.Drawing.Size(856, 10);
            this.panel_movingdoanhthu.TabIndex = 30;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // uC_DoanhThuNam1
            // 
            this.uC_DoanhThuNam1.BackColor = System.Drawing.Color.Silver;
            this.uC_DoanhThuNam1.Location = new System.Drawing.Point(1118, 6);
            this.uC_DoanhThuNam1.Name = "uC_DoanhThuNam1";
            this.uC_DoanhThuNam1.Size = new System.Drawing.Size(599, 553);
            this.uC_DoanhThuNam1.TabIndex = 1;
            this.uC_DoanhThuNam1.Load += new System.EventHandler(this.uC_DoanhThuNam1_Load);
            // 
            // uC_DoanhThuThang1
            // 
            this.uC_DoanhThuThang1.BackColor = System.Drawing.Color.Silver;
            this.uC_DoanhThuThang1.Location = new System.Drawing.Point(1118, 0);
            this.uC_DoanhThuThang1.Name = "uC_DoanhThuThang1";
            this.uC_DoanhThuThang1.Size = new System.Drawing.Size(599, 874);
            this.uC_DoanhThuThang1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1120, 553);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // UC_DoanhThu
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.panel_movingdoanhthu);
            this.Controls.Add(this.btn_doanhthuthang);
            this.Controls.Add(this.btn_doanhthunam);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "UC_DoanhThu";
            this.Size = new System.Drawing.Size(1798, 777);
            this.Load += new System.EventHandler(this.UC_DoanhThu_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panel_movingdoanhthu;
        private Guna.UI2.WinForms.Guna2Button btn_doanhthuthang;
        private Guna.UI2.WinForms.Guna2Button btn_doanhthunam;
        private UC_DoanhThuThang uC_DoanhThuThang1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private UC_DoanhThuNam uC_DoanhThuNam1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
