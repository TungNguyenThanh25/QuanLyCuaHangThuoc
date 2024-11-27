using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyCuaHang.All_User_Control
{
    public partial class UC_DoanhThu : UserControl
    {
        public UC_DoanhThu()
        {
            InitializeComponent();
            LoadChartData(); // Gọi hàm để tải dữ liệu khi khởi tạo
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn vừa nhấp vào biểu đồ!");
        }

        private void LoadChartData()
        {
            //// Xóa dữ liệu cũ (nếu có)
            //chart1.Series.Clear();
            //chart1.ChartAreas.Clear();

            //// Thêm ChartArea
            //ChartArea chartArea = new ChartArea("DoanhThuArea");
            //chart1.ChartAreas.Add(chartArea);

            //// Tạo Series và thêm dữ liệu
            //Series series = new Series("Doanh thu")
            //{
            //    ChartType = SeriesChartType.Column, // Biểu đồ dạng cột
            //    IsValueShownAsLabel = true          // Hiển thị giá trị trên cột
            //};

            //// Thêm dữ liệu mẫu
            //series.Points.AddXY("Tháng 1", 1000);
            //series.Points.AddXY("Tháng 2", 1200);
            //series.Points.AddXY("Tháng 3", 900);
            //series.Points.AddXY("Tháng 4", 1500);
            //series.Points.AddXY("Tháng 5", 1300);

            //// Thêm Series vào biểu đồ
            //chart1.Series.Add(series);

            //// Tùy chỉnh trục
            //chartArea.AxisX.Title = "Tháng";
            //chartArea.AxisY.Title = "Doanh thu (VNĐ)";
            //chartArea.AxisX.Interval = 1; // Hiển thị từng nhãn trục X
            uC_DoanhThuThang1.Visible = false;
            uC_DoanhThuNam1.Visible = false;
            
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
    }
}
