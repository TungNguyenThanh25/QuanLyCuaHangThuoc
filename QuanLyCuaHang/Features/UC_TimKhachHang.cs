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
    public partial class UC_TimKhachHang : UserControl
    {
        public UC_TimKhachHang()
        {
            InitializeComponent();
        }

        private void btn_huytimthongtinkhachhang_Click(object sender, EventArgs e)
        {
            txt_sodienthoaikhachhangcantim.Clear();
            txt_tenkhachhangcantim.Clear();
            combobox_gioitinhkhachhangcantim.Items.Clear();
        }
    }
}
