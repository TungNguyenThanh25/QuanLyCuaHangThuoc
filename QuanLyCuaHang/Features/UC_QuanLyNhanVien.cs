﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.Features
{
    public partial class UC_QuanLyNhanVien : UserControl
    {
        public UC_QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void UC_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            uC_ThemNhanVien1.Visible = false;
            uC_TimNhanVien1.Visible=false;
            uC_ThayDoiThongTinNhanVien1.Visible = false;
            uC_XoaNhanVien1.Visible = false;
            btn_themnhanvien.PerformClick();

        }

        private void uC_TimNhanVien1_Load(object sender, EventArgs e)
        {

        }

        private void btn_themnhanvien_Click(object sender, EventArgs e)
        {
            //uC_ThemNhanVien1.Visible = false;
            uC_TimNhanVien1.Visible = false;
            uC_ThayDoiThongTinNhanVien1.Visible = false;
            uC_XoaNhanVien1.Visible = false;

            panel_movingquanlynhanvien.Left = btn_themnhanvien.Left;
            uC_ThemNhanVien1.Visible = true;
            uC_ThemNhanVien1.BringToFront();
        }

        private void btn_timnhanvien_Click(object sender, EventArgs e)
        {
            uC_ThemNhanVien1.Visible = false;
           // uC_TimNhanVien1.Visible = false;
            uC_ThayDoiThongTinNhanVien1.Visible = false;
            uC_XoaNhanVien1.Visible = false;
            panel_movingquanlynhanvien.Left = btn_timnhanvien.Left;
            uC_TimNhanVien1.Visible=true;
            uC_TimNhanVien1.BringToFront();
        }

        private void btn_suathongtinnhanvien_Click(object sender, EventArgs e)
        {
            uC_ThemNhanVien1.Visible = false;
            uC_TimNhanVien1.Visible = false;
           //uC_ThayDoiThongTinNhanVien1.Visible = false;
            uC_XoaNhanVien1.Visible = false;
            panel_movingquanlynhanvien.Left = btn_suathongtinnhanvien.Left;
            uC_ThayDoiThongTinNhanVien1.Visible = true;
            uC_ThayDoiThongTinNhanVien1.BringToFront();
        }

        private void btn_xoanhanvien_Click(object sender, EventArgs e)
        {
            uC_ThemNhanVien1.Visible = false;
            uC_TimNhanVien1.Visible = false;
            uC_ThayDoiThongTinNhanVien1.Visible = false;
            //uC_XoaNhanVien1.Visible = false;
            panel_movingquanlynhanvien.Left = btn_xoanhanvien.Left;
            uC_XoaNhanVien1.Visible = true;
            uC_XoaNhanVien1.BringToFront();
        }

        private void panel_movingquanlynhanvien_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}