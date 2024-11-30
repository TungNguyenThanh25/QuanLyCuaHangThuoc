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
    public partial class UC_ThayDoiThongTinNhanVien : UserControl
    {
        public UC_ThayDoiThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void btn_huythaydoithongtinnhanvien_Click(object sender, EventArgs e)
        {
            txt_luongnhanviencanthaydoi.Clear();
            txt_manhanvientimthaydoi.Clear();
            
            txt_sodienthoainhanvienthaydoi.Clear();
            
            combobox_loainhanvienthaydoi.Items.Clear();
        }

        private void UC_ThayDoiThongTinNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
