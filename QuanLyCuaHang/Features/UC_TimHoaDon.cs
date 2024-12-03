using QuanLyCuaHang;
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
    public partial class UC_TimHoaDon : UserControl
    {
        public UC_TimHoaDon()
        {
            InitializeComponent();
        }

        //Lấy dữ liệu từng bảng
        private DataTable GetHoaDon()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Loc_HoaDon_LichSuHoaDon N'{text_tenkhachhangtimhoadon.Text}', '{text_ngaymuahangtimhoadon.Text}'";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex) { }
            return dataTable;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public event EventHandler<DataTable> OnRefreshData;
        private void RefeshData()
        {
            // Khi cần cập nhật dữ liệu, phát sự kiện
            OnRefreshData?.Invoke(this, new DataTable());
        }

        private void btn_huytimhoadon_Click(object sender, EventArgs e)
        {
            text_tenkhachhangtimhoadon.Clear();
            text_ngaymuahangtimhoadon.Clear();
            RefeshData();
        }

        public event EventHandler<DataTable> OnDataUpdated;

        private void UpdateData(DataTable newData)
        {
            // Khi cần cập nhật dữ liệu, phát sự kiện
            OnDataUpdated?.Invoke(this, newData);
        }

        private void btn_timhoadon_Click(object sender, EventArgs e)
        {
            DataTable data = GetHoaDon();
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            UpdateData(data);
        }
    }
}
