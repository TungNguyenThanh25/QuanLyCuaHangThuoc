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
    public partial class UC_XoaKhuyenMaiHoaDon : UserControl
    {
        public UC_XoaKhuyenMaiHoaDon()
        {
            InitializeComponent();
        }

        private void btn_huyxoamakhuyenmaihoadon_Click(object sender, EventArgs e)
        {
            txt_xoamakhuyenmaihoadon.Clear();
        }
    }
}
