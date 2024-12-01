using QuanLyCuaHang.Database;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyCuaHang
{
    public partial class UC_DoanhThu : UserControl
    {
        public UC_DoanhThu()
        {
            InitializeComponent();
            InitializeUC_XemDoanhThuThang();
        }

        private void InitializeUC_XemDoanhThuThang()
        {
            UC_DoanhThuThang ucXemDoanhThuThang = new UC_DoanhThuThang();
            ucXemDoanhThuThang.OnLoadChartDataThang += UcDoanhThuThang_OnLoadChartDataThang;
        }

        private void UcDoanhThuThang_OnLoadChartDataThang(object sender, Tuple<int, int> e)
        {
            LoadChartDataDoanhThuThang(e.Item1, e.Item2);
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn vừa nhấp vào biểu đồ!");
        }

        private DataTable GetDataThangFromTable(int thang, int nam)
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = "EXEC SP_Select_V_Show_DoanhThu_Thang " + thang + ", " + nam;
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex)
            {
            }
            return dataTable;
        }
        private void LoadChartDataDoanhThuThang(int thang, int nam)
        {
            DataTable dtTable = GetDataThangFromTable(thang, nam);

            // Kiểm tra dữ liệu có tồn tại
            if (dtTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị biểu đồ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Xóa dữ liệu cũ (nếu có)
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            // Thêm ChartArea
            ChartArea chartArea = new ChartArea("DoanhThuArea");
            chart1.ChartAreas.Add(chartArea);

            // Tạo Series và thêm dữ liệu
            Series series = new Series("Doanh thu")
            {
                ChartType = SeriesChartType.Column, // Biểu đồ dạng cột
                IsValueShownAsLabel = true          // Hiển thị giá trị trên cột
            };

            foreach (DataRow row in dtTable.Rows)
            {
                try
                {
                    // Lấy giá trị từ cột
                    string month = row["Ngày"].ToString(); // Thay "MonthColumn" bằng tên cột chứa tháng
                    double revenue = Convert.ToDouble(row["Doanh thu"]); // Thay "RevenueColumn" bằng tên cột chứa doanh thu

                    series.Points.AddXY(month, revenue);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding data point: {ex.Message}");
                }
            }

            // Thêm Series vào biểu đồ
            chart1.Series.Add(series);

            // Tùy chỉnh trục
            chartArea.AxisX.Title = "Ngày";
            chartArea.AxisY.Title = "Doanh thu (VNĐ)";
            chartArea.AxisX.Interval = 1; // Hiển thị từng nhãn trục X

            // Ẩn các control không cần thiết
            uC_DoanhThuThang1.Visible = false;
            uC_DoanhThuNam1.Visible = false;

            // Kích hoạt hành động nhấn nút
            btn_doanhthuthang.PerformClick();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_DoanhThu_Load(object sender, EventArgs e)
        {
            uC_DoanhThuNam1.Visible = false;
            uC_DoanhThuThang1.Visible = false;
            btn_doanhthuthang.PerformClick();
        }

        private void btn_doanhthunam_Click(object sender, EventArgs e)
        {
            uC_DoanhThuThang1.Visible=false;
            panel_movingdoanhthu.Left = btn_doanhthunam.Left;
            uC_DoanhThuNam1.Visible = true;
            uC_DoanhThuNam1.BringToFront();
        }

        private void btn_doanhthuthang_Click(object sender, EventArgs e)
        {
            uC_DoanhThuNam1.Visible=false;
            panel_movingdoanhthu.Left = btn_doanhthuthang.Left;
            uC_DoanhThuThang1.Visible = true;
            uC_DoanhThuThang1.BringToFront();
            uC_DoanhThuThang1.clearComboBox();
            uC_DoanhThuThang1.loadThang();
            uC_DoanhThuThang1.loadNam();
            uC_DoanhThuThang1.OnLoadChartDataThang += UcDoanhThuThang_OnLoadChartDataThang;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void uC_DoanhThuNam1_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void uC_DoanhThuThang1_Load(object sender, EventArgs e)
        {

        }
    }
}
