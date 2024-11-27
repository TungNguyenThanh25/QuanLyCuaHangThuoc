using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHang.All_User_Control
{
    partial class UC_LichSuMua
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.D = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_timhoadon = new Guna.UI2.WinForms.Guna2Button();
            this.panel_movinglichsuhoadon = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_xoahoadon = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_XoaHoaDon2 = new QuanLyCuaHang.Features.UC_XoaHoaDon();
            this.uC_TimHoaDon2 = new QuanLyCuaHang.Features.UC_TimHoaDon();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(592, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch sử hóa đơn";
            // 
            // D
            // 
            this.D.BackColor = System.Drawing.Color.White;
            this.D.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.D.Controls.Add(this.dataGridView1);
            this.D.Location = new System.Drawing.Point(34, 110);
            this.D.Margin = new System.Windows.Forms.Padding(4);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(1177, 639);
            this.D.TabIndex = 4;
            // 
            // dataGridView1
            // 

            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.ScrollBars = ScrollBars.Both;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1173, 631);
            this.dataGridView1.TabIndex = 6;

            // General settings
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke; // Nền sáng đẹp
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None; // Bỏ viền để nhìn thanh thoát hơn

            // Column headers styling
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(33, 150, 243); // Xanh nước biển tươi sáng cho tiêu đề
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); // Phông chữ mượt mà
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White; // Chữ trắng cho tiêu đề
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(33, 150, 243); // Giữ màu khi chọn
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40; // Tiêu đề cột cao hơn để tạo không gian thoáng

            // Cell styling
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White; // Nền trắng cho ô dữ liệu
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F); // Phông chữ hiện đại
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black; // Chữ đen
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue; // Nền màu khi chọn
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black; // Chữ đen khi chọn
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;

            // Row settings
            this.dataGridView1.RowHeadersVisible = false; // Ẩn phần RowHeaders
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray; // Màu lưới sáng tạo
            this.dataGridView1.RowTemplate.Height = 35; // Chiều cao dòng đẹp và mượt mà
            this.dataGridView1.ReadOnly = true; // Không cho phép chỉnh sửa dữ liệu

            // Kích hoạt tiêu đề đẹp hơn
            this.dataGridView1.EnableHeadersVisualStyles = false;

            // Size and position
            this.dataGridView1.Location = new System.Drawing.Point(0, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Size = new System.Drawing.Size(1173, 631);
            this.dataGridView1.TabIndex = 6;

            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btn_timhoadon
            // 
            this.btn_timhoadon.BorderRadius = 5;
            this.btn_timhoadon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_timhoadon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_timhoadon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_timhoadon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_timhoadon.FillColor = System.Drawing.Color.LightBlue;
            this.btn_timhoadon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timhoadon.ForeColor = System.Drawing.Color.Black;
            this.btn_timhoadon.Location = new System.Drawing.Point(1268, 110);
            this.btn_timhoadon.Name = "btn_timhoadon";
            this.btn_timhoadon.Size = new System.Drawing.Size(228, 42);
            this.btn_timhoadon.TabIndex = 7;
            this.btn_timhoadon.Text = "Tìm hóa đơn";
            this.btn_timhoadon.Click += new System.EventHandler(this.btn_timhoadon_Click);
            // 
            // panel_movinglichsuhoadon
            // 
            this.panel_movinglichsuhoadon.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_movinglichsuhoadon.Location = new System.Drawing.Point(1268, 155);
            this.panel_movinglichsuhoadon.Name = "panel_movinglichsuhoadon";
            this.panel_movinglichsuhoadon.Size = new System.Drawing.Size(228, 10);
            this.panel_movinglichsuhoadon.TabIndex = 9;
            this.panel_movinglichsuhoadon.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_movinglíchuhoadon_Paint);
            // 
            // btn_xoahoadon
            // 
            this.btn_xoahoadon.BorderRadius = 5;
            this.btn_xoahoadon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoahoadon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoahoadon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoahoadon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoahoadon.FillColor = System.Drawing.Color.LightBlue;
            this.btn_xoahoadon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoahoadon.ForeColor = System.Drawing.Color.Black;
            this.btn_xoahoadon.Location = new System.Drawing.Point(1502, 110);
            this.btn_xoahoadon.Name = "btn_xoahoadon";
            this.btn_xoahoadon.Size = new System.Drawing.Size(228, 42);
            this.btn_xoahoadon.TabIndex = 10;
            this.btn_xoahoadon.Text = "Xóa hóa đơn";
            this.btn_xoahoadon.Click += new System.EventHandler(this.btn_xoahoadon_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.LightGray;
            this.guna2Panel4.Controls.Add(this.uC_XoaHoaDon2);
            this.guna2Panel4.Controls.Add(this.uC_TimHoaDon2);
            this.guna2Panel4.Location = new System.Drawing.Point(1268, 171);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(463, 578);
            this.guna2Panel4.TabIndex = 0;
            // 
            // uC_XoaHoaDon2
            // 
            this.uC_XoaHoaDon2.Location = new System.Drawing.Point(0, 0);
            this.uC_XoaHoaDon2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uC_XoaHoaDon2.Name = "uC_XoaHoaDon2";
            this.uC_XoaHoaDon2.Size = new System.Drawing.Size(463, 578);
            this.uC_XoaHoaDon2.TabIndex = 1;
            this.uC_XoaHoaDon2.Load += new System.EventHandler(this.uC_XoaHoaDon2_Load);
            // 
            // uC_TimHoaDon2
            // 
            this.uC_TimHoaDon2.Location = new System.Drawing.Point(0, 0);
            this.uC_TimHoaDon2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uC_TimHoaDon2.Name = "uC_TimHoaDon2";
            this.uC_TimHoaDon2.Size = new System.Drawing.Size(463, 578);
            this.uC_TimHoaDon2.TabIndex = 0;
            this.uC_TimHoaDon2.Load += new System.EventHandler(this.uC_TimHoaDon2_Load);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this;
            // 
            // UC_LichSuMua
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.btn_xoahoadon);
            this.Controls.Add(this.panel_movinglichsuhoadon);
            this.Controls.Add(this.btn_timhoadon);
            this.Controls.Add(this.D);
            this.Controls.Add(this.label1);
            this.Name = "UC_LichSuMua";
            this.Size = new System.Drawing.Size(2248, 969);
            this.Load += new System.EventHandler(this.UC_LichSuMua_Load);
            this.D.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CustomizeDataGridView()
        {
            // CellMouseEnter event
            this.dataGridView1.CellMouseEnter += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(173, 216, 230); // Light color on hover
                    this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); // Bold on hover
                }
            };

            // CellMouseLeave event
            this.dataGridView1.CellMouseLeave += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.White; // Return to white color
                    this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F); // Normal font
                }
            };

            // Paint event (to add shadow effect)
            this.dataGridView1.Paint += (s, e) =>
            {
                var graphics = e.Graphics;
                var shadowColor = Color.FromArgb(100, 0, 0, 0); // Light shadow color
                var shadowSize = 8;
                graphics.FillRectangle(new SolidBrush(shadowColor), new Rectangle(this.dataGridView1.Width - shadowSize, this.dataGridView1.Height - shadowSize, shadowSize, shadowSize));
            };

            this.dataGridView1.Scroll += (s, e) =>
            {
                this.dataGridView1.Refresh();
            };
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel D;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btn_xoahoadon;
        private Guna.UI2.WinForms.Guna2Panel panel_movinglichsuhoadon;
        private Guna.UI2.WinForms.Guna2Button btn_timhoadon;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Features.UC_TimHoaDon uC_TimHoaDon1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Features.UC_XoaHoaDon uC_XoaHoaDon1;
        private Features.UC_TimHoaDon uC_TimHoaDon2;
        private Features.UC_XoaHoaDon uC_XoaHoaDon2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
