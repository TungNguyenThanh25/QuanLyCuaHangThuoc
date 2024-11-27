using QuanLyCuaHang.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.All_User_Control
{
    public partial class UC_CuaHang : UserControl
    {
        public UC_CuaHang()
        {
            InitializeComponent();
            CustomizeDataGridView();
            //dataGridView1.AutoResizeColumns();
        }

        //Lấy dữ liệu từng bảng
        private DataTable GetDataFromTable()
        {
            DataTable dataTable = new DataTable();
            DatabaseExecute dbExec = new DatabaseExecute();
            dbExec.Query = $"EXEC SP_Xuat_CuaHang";
            dbExec.executeQueryDataAdapter().Fill(dataTable);
            return dataTable;
        }

        private void UC_CuaHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetDataFromTable();
        }

        private void btn_xoakhoikho_Click(object sender, EventArgs e)
        {
            text_tensanphamcanthem.Clear();
            text_masanphamcanthem.Clear();
            text_soluongsanphamcanthem.Clear();

        }
    }
}
