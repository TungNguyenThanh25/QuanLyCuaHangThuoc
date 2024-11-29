using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class UC_XoaSanPham : UserControl
    {
        public UC_XoaSanPham()
        {
            InitializeComponent();
        }

        private void btn_XoaSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btn_huyxoakhoikho_Click(object sender, EventArgs e)
        {
            txt_masanphamxoa.Clear();
        }
    }
}
