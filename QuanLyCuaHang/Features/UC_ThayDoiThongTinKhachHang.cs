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
    public partial class UC_ThayDoiThongTinKhachHang : UserControl
    {
        public UC_ThayDoiThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void btn_huythemthongtinkhachhang_Click(object sender, EventArgs e)
        {
            txt_diachikhachhangcanthaydoi.Clear();
            txt_emailkhachhangcanthaydoi.Clear();
            txt_makhachhangcantimthaydoi.Clear();
            txt_sodienthoaikhachhangcanthaydoi.Clear();
            txt_tenkhachhangcanthaydoi.Clear();
            combobox_gioitinhkhachhangcanthaydoi.Items.Clear();
            combobox_loaikhachhangcanthaydoi.Items.Clear();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
