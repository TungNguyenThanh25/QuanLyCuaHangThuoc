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
    public partial class UC_ThemKhachHang : UserControl
    {
        public UC_ThemKhachHang()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_huythemthongtinkhachhang_Click(object sender, EventArgs e)
        {
            txt_diachikhachhangcanthem.Clear();
            txt_emailkhachhangcanthem.Clear();
            txt_sodienthoaikhachhangcanthem.Clear();
            txt_tenkhachhangcanthem.Clear();
            combobox_gioitinhkhachhangcanthem.Items.Clear();
            combobox_loaikhachhangcanthem.Items.Clear();
        }

        private void UC_ThemKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
