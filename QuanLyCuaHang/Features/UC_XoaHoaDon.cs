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
    public partial class UC_XoaHoaDon : UserControl
    {
        public UC_XoaHoaDon()
        {
            InitializeComponent();
        }

        private void btn_huyxoahoadon_Click(object sender, EventArgs e)
        {
            text_tenkhachhangxoahoadon.Clear();
            text_mahoadonxoahoadon.Clear();
            text_ngaymuahangxoahoadon.Clear();

        }
    }
}
