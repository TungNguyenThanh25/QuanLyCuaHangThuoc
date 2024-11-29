using QuanLyCuaHang.Database;
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
        }

        //Lấy dữ liệu từng bảng
        private DataTable GetDataFromTable()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Xuat_CuaHang";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");
            }
            return dataTable;
        }

        // Lấy dữ liệu cho tìm sản phẩm
        private DataTable GetDataFromTimSanPham()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Tim_SanPham_CuaHang N'{txt_tensanphamcantim.Text.Trim()}'";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");
            }
            return dataTable;
        }

        private void UC_CuaHang_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = GetDataFromTable();
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
            guna2DataGridView1.DataSource = GetDataFromTimSanPham();
        }

        private void btn_theogiohang_Click(object sender, EventArgs e)
        {
            //text_tensanphamcanthem
            //text_masanphamcanthem
            //text_soluongsanphamcanthem;
        }
    }
}
