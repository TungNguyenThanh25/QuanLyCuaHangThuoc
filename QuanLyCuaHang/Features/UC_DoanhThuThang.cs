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
    public partial class UC_DoanhThuThang : UserControl
    {
        public UC_DoanhThuThang()
        {
            InitializeComponent();
        }

        public void clearComboBox()
        {
            guna2ComboBox1.Items.Clear();
            guna2ComboBox2.Items.Clear();
        }
        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        //Lấy dữ liệu từng bảng
        private string[] GetYear()
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = $"EXEC SP_Select_Year_HD";  // Gọi Stored Procedure để lấy năm
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex)
            {
                // MessageBox.Show($"Error: {ex.Message}");  // Xử lý lỗi nếu có
            }

            // Nếu dữ liệu có sẵn, chuyển đổi các năm vào mảng string[]
            if (dataTable.Rows.Count > 0)
            {
                // Thay "Năm" bằng tên cột thực tế trong bảng của bạn
                string[] years = dataTable.AsEnumerable()
                                          .Select(row => row.Field<int>("Năm").ToString())
                                          .ToArray();
                return years;
            }

            return new string[] { }; // Trả về mảng rỗng nếu không có dữ liệu
        }

        public void loadThang()
        {
            string[] thang = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            guna2ComboBox1.Items.AddRange(thang);
        }

        public void loadNam()
        {
            // Gán các năm cho ComboBox từ dữ liệu đã lấy
            string[] years = GetYear();
            if (years.Length > 0)
            {
                guna2ComboBox2.Items.AddRange(years);
            }
            else
            {
                // Nếu không có năm nào, bạn có thể hiển thị một thông báo hoặc xử lý theo cách khác
                guna2ComboBox2.DataSource = new string[] { "No data available" };
            }
        }
        public int getThang()
        {
            return int.Parse(guna2ComboBox1.SelectedItem.ToString());
        }

        public int getNam()
        {
            return int.Parse(guna2ComboBox2.SelectedItem.ToString());
        }

        public event EventHandler<Tuple<int, int>> OnLoadChartDataThang;
        private void LoadChartDataThang()
        {
            int thang = getThang();
            int nam = getNam();

            
            // Kích hoạt sự kiện và truyền dữ liệu bằng Tuple
            OnLoadChartDataThang?.Invoke(this, Tuple.Create(thang, nam));
        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadChartDataThang();
        }
    }
}
