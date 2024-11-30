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
    public partial class UC_ThemNhanVien : UserControl
    {
        public UC_ThemNhanVien()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void combobox_loainhanviencanthem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_huythemthongtinnhanvien_Click(object sender, EventArgs e)
        {
            txt_luongnhanviencanthem.Clear();
            txt_maquanlynhanvienthem.Clear();
            txt_sodienthoainhanviencanthem.Clear();
            txt_tennhanviencanthem.Clear();
            combobox_gioitinhnhanviencanthem.Items.Clear();
            combobox_loainhanviencanthem.Items.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
