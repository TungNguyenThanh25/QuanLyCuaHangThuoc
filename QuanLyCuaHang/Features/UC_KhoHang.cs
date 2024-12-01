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
    public partial class UC_KhoHang : UserControl
    {
        public UC_KhoHang()
        {
            InitializeComponent();
        }

        private void getData()
        {
            guna2DataGridView1.DataSource = GetDataFromTable();
        }

        public void loadUcKhoHang()
        {
            getData();
        }

        private void UC_KhoHang_Load(object sender, EventArgs e)
        {
            uC_ThemSanPham1.Visible = false;
            uC_XoaSanPham1.Visible=false;
            uC_SuaSanPham1.Visible=false;
            btn_themsanphamkhohang.PerformClick();
        }

        private DataTable GetDataFromTable()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_V_Show_Kho";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex) { }
            return dataTable;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_ThemSanPham1.Visible = false;
            //uC_XoaSanPham1.Visible = false;
            uC_SuaSanPham1.Visible = false;
            panel_movingkhohang.Left = btn_xoasanphamkhohang.Left;
            uC_XoaSanPham1.Visible = true;
            uC_XoaSanPham1.BringToFront();
            getData();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_ThemSanPham1.Visible = false;
            uC_XoaSanPham1.Visible = false;
            //uC_SuaSanPham1.Visible = false;
            panel_movingkhohang.Left = btn_suasanphamkhohang.Left;
            uC_SuaSanPham1.Visible=true;
            uC_SuaSanPham1.BringToFront();
            getData();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_ThemSanPham1_Load(object sender, EventArgs e)
        {

        }

        private void btn_themsanpham_Click(object sender, EventArgs e)
        {
            //uC_ThemSanPham1.Visible = false;
            uC_XoaSanPham1.Visible = false;
            uC_SuaSanPham1.Visible = false;
            panel_movingkhohang.Left = btn_themsanphamkhohang.Left;
            uC_ThemSanPham1.Visible = true;
            uC_ThemSanPham1.BringToFront();
            getData();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_XoaSanPham1_Load(object sender, EventArgs e)
        {

        }

        private void uC_SuaSanPham1_Load(object sender, EventArgs e)
        {

        }
    }
}
