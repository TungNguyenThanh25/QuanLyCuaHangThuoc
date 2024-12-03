using QuanLyCuaHang.Database;
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
    public partial class UC_XoaHoaDon : UserControl
    {
        public UC_XoaHoaDon()
        {
            InitializeComponent();
        }

        private void btn_huyxoahoadon_Click(object sender, EventArgs e)
        {
            text_mahoadonxoahoadon.Clear();
        }

        //private void XoaHoaDon()
        //{
        //    try
        //    {
        //        DatabaseExecute dbExec = new DatabaseExecute();
        //        dbExec.Query = $"EXEC SP_Delete_ChiTietHoaDon N'{text_mahoadonxoahoadon.Text}', '{text_ngaymuahangtimhoadon.Text}'";
        //        dbExec.executeQueryCommand();
        //        dbExec.Query = $"EXEC SP_Delete_HoaDon N'{text_tenkhachhangtimhoadon.Text}', '{text_ngaymuahangtimhoadon.Text}'";
        //        dbExec.executeQueryCommand();
        //    }
        //    catch (Exception ex) { }
        //}

        private void btn_xoahoadonhoadon_Click(object sender, EventArgs e)
        {

        }
    }
}
