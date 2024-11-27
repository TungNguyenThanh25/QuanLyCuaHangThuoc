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
    public partial class UC_KhuyenMai : UserControl
    {
        public UC_KhuyenMai()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void UC_KhuyenMai_Load(object sender, EventArgs e)
        {
            uC_ThemMaKhuyenMaiSanPham1.Visible = false;
            uC_XoaMaKhuyenMaiSanPham1.Visible=false;
            uC_ThemKhuyenMaiHoaDon1.Visible = false;
            uC_XoaKhuyenMaiHoaDon1.Visible=false;
            btn_themkhuyenmaisanpham.PerformClick();

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //uC_ThemMaKhuyenMaiSanPham1.Visible = false;
            uC_XoaMaKhuyenMaiSanPham1.Visible = false;
            uC_ThemKhuyenMaiHoaDon1.Visible = false;
            uC_XoaKhuyenMaiHoaDon1.Visible = false;

            panel_movingkhuyenmai.Left = btn_themkhuyenmaisanpham.Left;
            uC_ThemMaKhuyenMaiSanPham1.Visible = true;
            uC_ThemMaKhuyenMaiSanPham1.BringToFront();
        }

        private void btn_xoakhuyenmaisanpham_Click(object sender, EventArgs e)
        {
            uC_ThemMaKhuyenMaiSanPham1.Visible = false;
            //uC_XoaMaKhuyenMaiSanPham1.Visible = false;
            uC_ThemKhuyenMaiHoaDon1.Visible = false;
            uC_XoaKhuyenMaiHoaDon1.Visible = false;

            panel_movingkhuyenmai.Left = btn_xoakhuyenmaisanpham.Left;
            uC_XoaMaKhuyenMaiSanPham1.Visible=true;
            uC_XoaMaKhuyenMaiSanPham1.BringToFront();
        }

        private void btn_themkhuyenmaihoadon_Click(object sender, EventArgs e)
        {
            uC_ThemMaKhuyenMaiSanPham1.Visible = false;
            uC_XoaMaKhuyenMaiSanPham1.Visible = false;
            //uC_ThemKhuyenMaiHoaDon1.Visible = false;
            uC_XoaKhuyenMaiHoaDon1.Visible = false;

            panel_movingkhuyenmai.Left = btn_themkhuyenmaihoadon.Left;
            uC_ThemKhuyenMaiHoaDon1.Visible = true;
            uC_ThemKhuyenMaiHoaDon1.BringToFront();
        }

        private void btn_xoakhuyenmaihoadon_Click(object sender, EventArgs e)
        {
            uC_ThemMaKhuyenMaiSanPham1.Visible = false;
            uC_XoaMaKhuyenMaiSanPham1.Visible = false;
            uC_ThemKhuyenMaiHoaDon1.Visible = false;
            //uC_XoaKhuyenMaiHoaDon1.Visible = false;

            panel_movingkhuyenmai.Left = btn_xoakhuyenmaihoadon.Left;
            uC_XoaKhuyenMaiHoaDon1.Visible=true;
            uC_XoaKhuyenMaiHoaDon1.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
