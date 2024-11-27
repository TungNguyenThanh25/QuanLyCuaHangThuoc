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

namespace QuanLyCuaHang.All_User_Control
{
    public partial class UC_LichSuMua : UserControl
    {
        public UC_LichSuMua()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void text_ngaymuahangtimhoadon_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Lấy dữ liệu từng bảng
        private DataTable GetDataFromTable()
        {
            DataTable dataTable = new DataTable();
            DatabaseExecute dbExec = new DatabaseExecute();
            dbExec.Query = $"EXEC SP_Select_HoaDon";
            dbExec.executeQueryDataAdapter().Fill(dataTable);
            return dataTable;
        }

        private void btn_timhoadon_Click(object sender, EventArgs e)
        {
            //uC_XoaHoaDon1.Visible = false;
            //panel_movinglíchuhoadon.Left = btn_timhoadon.Left;
            //uC_TimHoaDon1.Visible = true;
            //uC_TimHoaDon1.BringToFront();
            panel_movinglichsuhoadon.Left = btn_timhoadon.Left;
            uC_TimHoaDon2.Visible = true;
            uC_TimHoaDon2.BringToFront();
        }

        private void uC_XoaHoaDon1_Load(object sender, EventArgs e)
        {

        }

        private void UC_LichSuMua_Load(object sender, EventArgs e)
        {
            uC_TimHoaDon2.Visible=false;
            uC_XoaHoaDon2.Visible = false;
            btn_timhoadon.PerformClick();

            guna2DataGridView2.DataSource = GetDataFromTable();

            //uC_TimHoaDon1.Visible=false;
            //uC_XoaHoaDon1.Visible = false;
            //btn_timhoadon.PerformClick();
        }

        private void btn_xoahoadon_Click(object sender, EventArgs e)
        {
            //uC_TimHoaDon1.Visible = false;
            //panel_movinglíchuhoadon.Left = btn_xoahoadon.Left;
            //uC_XoaHoaDon1.Visible = true;
            //uC_XoaHoaDon1.BringToFront();
            panel_movinglichsuhoadon.Left = btn_xoahoadon.Left;
            uC_XoaHoaDon2.Visible = true;
            uC_XoaHoaDon2.BringToFront();
        }

        private void panel_movinglíchuhoadon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_TimHoaDon2_Load(object sender, EventArgs e)
        {

        }

        private void uC_XoaHoaDon2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
