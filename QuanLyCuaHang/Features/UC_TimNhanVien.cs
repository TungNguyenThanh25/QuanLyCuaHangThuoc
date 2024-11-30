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
    public partial class UC_TimNhanVien : UserControl
    {
        public UC_TimNhanVien()
        {
            InitializeComponent();
        }

        private void UC_TimNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btn_huytimthongtinnhanvien_Click(object sender, EventArgs e)
        {
            txt_manhanvientim.Clear();
        }
    }
}
