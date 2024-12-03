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

namespace QuanLyCuaHang.Features
{
    public partial class UC_TimNhanVien : UserControl
    {
        public UC_TimNhanVien()
        {
            InitializeComponent();
        }

        private void UC_TimNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btn_huytimthongtinnhanvien_Click(object sender, EventArgs e)
        {
            txt_manhanvientim.Clear();
            RefreshData();
        }

        //Lấy dữ liệu từng bảng
        private DataTable GetNhanVienDataByMaNV()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Loc_NhanVien_QuanLyNhanVien '{txt_manhanvientim.Text}'";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex) { }
            return dataTable;
        }

        public event EventHandler<DataTable> OnRefreshData;
        private void RefreshData()
        {
            // Khi cần cập nhật dữ liệu, phát sự kiện
            OnRefreshData?.Invoke(this, new DataTable());
        }

        public event EventHandler<DataTable> OnDataUpdated;

        private void UpdateData(DataTable newData)
        {
            // Khi cần cập nhật dữ liệu, phát sự kiện
            OnDataUpdated?.Invoke(this, newData);
        }

        private void btn_timthongtinnhanvien_Click(object sender, EventArgs e)
        {
            DataTable data = GetNhanVienDataByMaNV();
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            UpdateData(data);
        }
    }
}
