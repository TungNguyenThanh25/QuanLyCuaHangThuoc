using QuanLyCuaHang.Database;
using QuanLyCuaHang.LoginRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class UC_HoaDon : UserControl
    {
        public UC_HoaDon()
        {
            InitializeComponent();
            
        }

        public void getData()
        {
            guna2DataGridView1.DataSource = GetDataFromTable();
        }
        public void clearData()
        {
            txt_SoDienThoai_HD.Clear();
            txt_TenKhachHang.Clear();
            txt_MaKhuyenMai.Clear();
            txt_thanhtien.Clear();
            txt_tongtien.Clear();
            txt_tongsoluongmathang.Clear();
            getData();
        }

        //Lấy dữ liệu từng bảng
        private DataTable GetDataFromTable()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_V_Show_GioHang_Detail '{User.username}'";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex) { }
            return dataTable;
        }

        private void UC_HoaDon_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = GetDataFromTable();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void text_ngaymuahang_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void txt_thanhtoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
