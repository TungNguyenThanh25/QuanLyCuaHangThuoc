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
            InitializeUC_XemDoanhThuNam();
            UC_XemDoanhThu_Load(this, new EventArgs());
        }

        private void UC_XemDoanhThu_Load(object sender, EventArgs e)
        {
            // Ẩn các control không cần thiết
            uC_DoanhThuThang1.Visible = false;
            uC_DoanhThuNam1.Visible = false;

            // Kích hoạt hành động nhấn nút
            btn_doanhthuthang.PerformClick();

            UcDoanhThuThang_OnLoadChartDataThang(sender, Tuple.Create(DateTime.Now.Month, DateTime.Now.Year));
        }

        private void InitializeUC_XemDoanhThuThang()
        {
            var ucXemDoanhThuThang = new UC_DoanhThuThang();
            ucXemDoanhThuThang.OnLoadChartDataThang += UcDoanhThuThang_OnLoadChartDataThang;
        }

        private void UcDoanhThuThang_OnLoadChartDataThang(object sender, Tuple<int, int> e)
        {
            int thang = e.Item1;
            int nam = e.Item2;
            LoadChartDataThang(thang, nam);
        }

        private void InitializeUC_XemDoanhThuNam()
        {
            var ucXemDoanhThuNam = new UC_DoanhThuNam();
            ucXemDoanhThuNam.OnLoadChartDataNam += UcDoanhThuNam_OnLoadChartDataNam;
        }

        private void UcDoanhThuNam_OnLoadChartDataNam(object sender, int e)
        {
            int nam = e;
            LoadChartDataNam(nam);
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
                dbExec.Query = "SELECT * FROM dbo.FUNC_Select_V_Show_DoanhThu_Thang(" + thang + ", " + nam + ");";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex)
            {
                //// Ghi log hoặc hiển thị thông báo lỗi
                //Console.WriteLine($"Error: {ex.Message}");
            }
            return dataTable;
        }

        private void LoadChartDataThang(int thang, int nam)
        {
            DataTable dtTable = GetDataThangFromTable(thang, nam);

            //iểm tra dữ liệu có tồn tại
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
            Series series = new Series("Doanh thu tháng " + thang + " " + nam)
            {
                ChartType = SeriesChartType.Column, // Biểu đồ dạng cột
                IsValueShownAsLabel = true          // Hiển thị giá trị trên cột
            };

            foreach (DataRow row in dtTable.Rows)
            {
                try
                {
                    // Lấy giá trị từ cột
                    string day = row["Ngày"].ToString(); // Thay "MonthColumn" bằng tên cột chứa tháng
                    double revenue = Convert.ToDouble(row["Doanh thu"]); // Thay "RevenueColumn" bằng tên cột chứa doanh thu

                    series.Points.AddXY(day, revenue);
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
        }

        private DataTable GetDataNamFromTable(int nam)
        {
            DataTable dataTable = new DataTable();
            try
            {
                DatabaseExecute dbExec = new DatabaseExecute();
                dbExec.Query = "EXEC SP_Select_V_Show_DoanhThu_Nam " + nam + ";";
                dbExec.executeQueryDataAdapter().Fill(dataTable);
            }
            catch (Exception ex)
            {
                //// Ghi log hoặc hiển thị thông báo lỗi
                //Console.WriteLine($"Error: {ex.Message}");
            }
            return dataTable;
        }

        private void LoadChartDataNam(int nam)
        {
            DataTable dtTable = GetDataNamFromTable(nam);

            //iểm tra dữ liệu có tồn tại
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
            Series series = new Series("Doanh thu năm "  + nam)
            {
                ChartType = SeriesChartType.Column, // Biểu đồ dạng cột
                IsValueShownAsLabel = true          // Hiển thị giá trị trên cột
            };

            foreach (DataRow row in dtTable.Rows)
            {
                try
                {
                    // Lấy giá trị từ cột
                    string day = row["Tháng"].ToString(); // Thay "MonthColumn" bằng tên cột chứa tháng
                    double revenue = Convert.ToDouble(row["Doanh thu"]); // Thay "RevenueColumn" bằng tên cột chứa doanh thu

                    series.Points.AddXY(day, revenue);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding data point: {ex.Message}");
                }
            }

            // Thêm Series vào biểu đồ
            chart1.Series.Add(series);

            // Tùy chỉnh trục
            chartArea.AxisX.Title = "Tháng";
            chartArea.AxisY.Title = "Doanh thu (VNĐ)";
            chartArea.AxisX.Interval = 1; // Hiển thị từng nhãn trục X
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

        }

        private void btn_doanhthunam_Click(object sender, EventArgs e)
        {
            uC_DoanhThuThang1.Visible=false;
            panel_movingdoanhthu.Left = btn_doanhthunam.Left;
            uC_DoanhThuNam1.Visible = true;
            uC_DoanhThuNam1.BringToFront();
            //uC_DoanhThuNam1.
            uC_DoanhThuNam1.OnLoadChartDataNam += UcDoanhThuNam_OnLoadChartDataNam;

            int nam = uC_DoanhThuNam1.getNam();
            LoadChartDataNam(nam);
        }

        private void btn_doanhthuthang_Click(object sender, EventArgs e)
        {
            uC_DoanhThuNam1.Visible=false;
            panel_movingdoanhthu.Left = btn_doanhthuthang.Left;
            uC_DoanhThuThang1.Visible = true;
            uC_DoanhThuThang1.BringToFront();

            uC_DoanhThuThang1.OnLoadChartDataThang += UcDoanhThuThang_OnLoadChartDataThang;

            int thang = uC_DoanhThuThang1.getThang();
            int nam = uC_DoanhThuThang1.getNam();
            LoadChartDataThang(thang, nam);
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
