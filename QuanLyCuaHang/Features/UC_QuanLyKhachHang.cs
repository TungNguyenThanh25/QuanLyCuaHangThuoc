using System;
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
    public partial class UC_QuanLyKhachHang : UserControl
    {
        public UC_QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            panel_movingquanlykhachhang.Left = btn_xoakhachhang.Left;
            uC_XoaKhachHang1.Visible = true;
            uC_XoaKhachHang1.BringToFront();
        }

        private void btn_themkhachhang_Click(object sender, EventArgs e)
        {
            panel_movingquanlykhachhang.Left = btn_themkhachhang.Left;
            uC_ThemKhachHang1.Visible = true;
            uC_ThemKhachHang1.BringToFront();
        }

        private void btn_timkhachang_Click(object sender, EventArgs e)
        {
            panel_movingquanlykhachhang.Left = btn_timkhachang.Left;
            uC_TimKhachHang1.Visible=true;
            uC_TimKhachHang1.BringToFront();
        }

        private void btn_suathongtinkhachhang_Click(object sender, EventArgs e)
        {
            panel_movingquanlykhachhang.Left = btn_suathongtinkhachhang.Left;
            uC_ThayDoiThongTinKhachHang1.Visible = true;   
            uC_ThayDoiThongTinKhachHang1.BringToFront() ;
        }

        private void UC_QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            uC_ThemKhachHang1.Visible = false;
            uC_TimKhachHang1.Visible = false;
            uC_ThayDoiThongTinKhachHang1.Visible = false;
            uC_XoaKhachHang1.Visible = false;
            btn_themkhachhang.PerformClick();
        }
    }
}
