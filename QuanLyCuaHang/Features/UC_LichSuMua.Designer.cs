using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.D = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_timhoadon = new Guna.UI2.WinForms.Guna2Button();
            this.panel_movinglichsuhoadon = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_xoahoadon = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_XoaHoaDon2 = new QuanLyCuaHang.UC_XoaHoaDon();
            this.uC_TimHoaDon2 = new QuanLyCuaHang.UC_TimHoaDon();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
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
            this.D.Controls.Add(this.guna2DataGridView1);
            this.D.Location = new System.Drawing.Point(34, 110);
            this.D.Margin = new System.Windows.Forms.Padding(4);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(921, 520);
            this.D.TabIndex = 4;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(3, 11);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(903, 506);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.btn_timhoadon.Location = new System.Drawing.Point(977, 96);
            this.btn_timhoadon.Name = "btn_timhoadon";
            this.btn_timhoadon.Size = new System.Drawing.Size(165, 42);
            this.btn_timhoadon.TabIndex = 7;
            this.btn_timhoadon.Text = "Tìm hóa đơn";
            this.btn_timhoadon.Click += new System.EventHandler(this.btn_timhoadon_Click);
            // 
            // panel_movinglichsuhoadon
            // 
            this.panel_movinglichsuhoadon.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_movinglichsuhoadon.Location = new System.Drawing.Point(976, 141);
            this.panel_movinglichsuhoadon.Name = "panel_movinglichsuhoadon";
            this.panel_movinglichsuhoadon.Size = new System.Drawing.Size(165, 10);
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
            this.btn_xoahoadon.Location = new System.Drawing.Point(1156, 97);
            this.btn_xoahoadon.Name = "btn_xoahoadon";
            this.btn_xoahoadon.Size = new System.Drawing.Size(165, 42);
            this.btn_xoahoadon.TabIndex = 10;
            this.btn_xoahoadon.Text = "Xóa hóa đơn";
            this.btn_xoahoadon.Click += new System.EventHandler(this.btn_xoahoadon_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.LightGray;
            this.guna2Panel4.Controls.Add(this.uC_XoaHoaDon2);
            this.guna2Panel4.Controls.Add(this.uC_TimHoaDon2);
            this.guna2Panel4.Location = new System.Drawing.Point(975, 157);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(349, 473);
            this.guna2Panel4.TabIndex = 0;
            // 
            // uC_XoaHoaDon2
            // 
            this.uC_XoaHoaDon2.Location = new System.Drawing.Point(2, 2);
            this.uC_XoaHoaDon2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uC_XoaHoaDon2.Name = "uC_XoaHoaDon2";
            this.uC_XoaHoaDon2.Size = new System.Drawing.Size(353, 473);
            this.uC_XoaHoaDon2.TabIndex = 1;
            this.uC_XoaHoaDon2.Load += new System.EventHandler(this.uC_XoaHoaDon2_Load);
            // 
            // uC_TimHoaDon2
            // 
            this.uC_TimHoaDon2.Location = new System.Drawing.Point(2, 2);
            this.uC_TimHoaDon2.Margin = new System.Windows.Forms.Padding(2);
            this.uC_TimHoaDon2.Name = "uC_TimHoaDon2";
            this.uC_TimHoaDon2.Size = new System.Drawing.Size(353, 473);
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
            this.Size = new System.Drawing.Size(1347, 650);
            this.Load += new System.EventHandler(this.UC_LichSuMua_Load);
            this.D.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private UC_TimHoaDon uC_TimHoaDon1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private UC_XoaHoaDon uC_XoaHoaDon1;
        private UC_TimHoaDon uC_TimHoaDon2;
        private UC_XoaHoaDon uC_XoaHoaDon2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    }
}
