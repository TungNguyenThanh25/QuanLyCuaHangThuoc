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
    public partial class UC_XoaNhanVien : UserControl
    {
        public UC_XoaNhanVien()
        {
            InitializeComponent();
        }

        private void btn_huyxoathongtinnhanvien_Click(object sender, EventArgs e)
        {
            txt_manhanvienxoa.Clear();
        }
    }
}
