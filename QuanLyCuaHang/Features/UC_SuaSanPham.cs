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
    public partial class UC_SuaSanPham : UserControl
    {
        public UC_SuaSanPham()
        {
            InitializeComponent();
        }

        private void btn_huychinhsuathongtinsanpham_Click(object sender, EventArgs e)
        {
            txt_ghichuchinhsua.Clear();
            txt_giabanchinhsua.Clear();
            txt_gianhapchinhsua.Clear();
            txt_hansudungchinhsua.Clear();
            txt_masanphamchinhsua.Clear();
            txt_ngaysanxuatchinhsua.Clear();
            txt_nhacungungchinhsua.Clear();
            txt_nuocsanxuatchinhsua.Clear();
            txt_quycachdonggoichinhsua.Clear();
            txt_soluongpackchinhsua.Clear();
            txt_soluongsanphamchinhsua.Clear();
        }
    }
}
