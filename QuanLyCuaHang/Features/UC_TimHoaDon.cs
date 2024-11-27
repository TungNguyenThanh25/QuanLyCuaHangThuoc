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
    public partial class UC_TimHoaDon : UserControl
    {
        public UC_TimHoaDon()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_huytimhoadon_Click(object sender, EventArgs e)
        {
            text_tenkhachhangtimhoadon.Clear();
            text_ngaymuahangtimhoadon.Clear();

        }
    }
}
