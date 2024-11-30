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
    public partial class UC_XoaKhachHang : UserControl
    {
        public UC_XoaKhachHang()
        {
            InitializeComponent();
        }

        private void btn_huyxoathongtinkhachhang_Click(object sender, EventArgs e)
        {
            txt_sodienthoaikhachhangcanxoa.Clear();
            txt_tenkhachhangcanxoa.Clear();
            combobox_gioitinhkhachhangcanxoa.Items.Clear();
        }
    }
}
