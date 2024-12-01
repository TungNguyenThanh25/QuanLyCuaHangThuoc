using QuanLyCuaHang.Database;
using QuanLyCuaHang.LoginRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class UC_CuaHang : UserControl
    {
        public UC_CuaHang()
        {
            InitializeComponent();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Insert_GioHang '{User.username}'";
                dbExec.executeQueryCommand();
            }
            catch (Exception ex) { }
        }

        private void AddCart()
        {
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Insert_ChiTietGioHang '{User.username}', '{text_masanphamcanthem.Text.Trim()}', {text_soluongsanphamcanthem.Text.Trim()}";
                dbExec.executeQueryCommand();

                MessageBox.Show("Thêm vào giỏ hàng thành công!");
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");
            }
        }

        //Lấy dữ liệu từng bảng
        private DataTable GetDataFromTable()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_V_Show_CuaHang";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");
            }
            return dataTable;
        }

        // Lấy dữ liệu cho tìm sản phẩm
        private DataTable GetDataFromLocSanPham()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Loc_SanPham_CuaHang N'{txt_tensanphamcantim.Text.Trim()}'";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");
            }
            return dataTable;
        }

        public void getData()
        {
            guna2DataGridView1.DataSource = GetDataFromTable();
        }
        public void loadUcCuaHang()
        {
            txt_tensanphamcantim.Clear();
            text_masanphamcanthem.Clear();
            text_soluongsanphamcanthem.Clear();
            getData();
        }

        private void UC_CuaHang_Load(object sender, EventArgs e)
        {
        }

        private void btn_xoakhoikho_Click(object sender, EventArgs e)
        {
            text_masanphamcanthem.Clear();
            text_soluongsanphamcanthem.Clear();
            txt_tensanphamcantim.Clear();
            UC_CuaHang_Load(sender, e);
        }

        private void bnt_timsanpham_Click(object sender, EventArgs e)
        {
            DataTable dataTable = GetDataFromLocSanPham();
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy tên sản phẩm cần tìm");
                return;
            }
            guna2DataGridView1.DataSource = dataTable;
        }

        private void btn_theogiohang_Click(object sender, EventArgs e)
        {
            AddCart();
            text_masanphamcanthem.Clear();
            text_soluongsanphamcanthem.Clear();
        }
    }
}
