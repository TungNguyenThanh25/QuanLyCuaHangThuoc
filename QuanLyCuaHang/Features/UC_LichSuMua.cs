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
    public partial class UC_LichSuMua : UserControl
    {
        public UC_LichSuMua()
        {
            InitializeComponent();
            InitializeUC_TimHoaDon(); // Gọi hàm khởi tạo
            getData();
        }

        private void InitializeUC_TimHoaDon()
        {
            var ucTimHoaDon = new UC_TimHoaDon();
            ucTimHoaDon.OnDataUpdated += UcTimHoaDon_OnDataUpdated;
            ucTimHoaDon.OnRefreshData += UcTimHoaDon_OnRefreshData;
        }

        public void getData()
        {
            guna2DataGridView1.DataSource = GetDataFromTable();
        }
        public void loadData()
        {
            getData();
        }

        private void UcTimHoaDon_OnDataUpdated(object sender, DataTable newData)
        {
            // Cập nhật DataGridView với dữ liệu mới
            guna2DataGridView1.DataSource = newData;

            // Kiểm tra dữ liệu trống
            if (newData.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hóa đơn phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UcTimHoaDon_OnRefreshData(object sender, DataTable newData)
        {
            loadData();
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
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_V_Show_LichSuHoaDon";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex) { }
            return dataTable;
        }

        private void btn_timhoadon_Click(object sender, EventArgs e)
        {
            uC_XoaHoaDon2.Visible = false;
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

            // Đăng ký sự kiện OnDataUpdated
            uC_TimHoaDon2.OnDataUpdated += UcTimHoaDon_OnDataUpdated;
            uC_TimHoaDon2.OnRefreshData += UcTimHoaDon_OnRefreshData;

            //uC_TimHoaDon1.Visible=false;
            //uC_XoaHoaDon1.Visible = false;
            //btn_timhoadon.PerformClick();
        }

        private void btn_xoahoadon_Click(object sender, EventArgs e)
        {
            uC_TimHoaDon2.Visible = false;
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
