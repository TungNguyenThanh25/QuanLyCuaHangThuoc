using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyCuaHang.Database;
using QuanLyCuaHang.LoginRegister;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class UC_ThemSanPham : UserControl
    {
        public UC_ThemSanPham()
        {
            InitializeComponent();
        }

        private void UC_ThemSanPham_Load(object sender, EventArgs e)
        {

        }

        private void btn_huythemsanpham_Click(object sender, EventArgs e)
        {
            txt_ghichuthem.Clear();
            txt_giabanthem.Clear();
            txt_gianhapthem.Clear();
            txt_hansudungthem.Clear();
            txt_ngaysanxuatthem.Clear();
            txt_nuocsanxuatthem.Clear();
            txt_quycachdonggoithem.Clear();
            txt_soluongpackthem.Clear();
            txt_soluongsanphamthem.Clear();
            txt_tensanphamthem.Clear();
            txt_nhacungungthem.Clear();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_themkho_Click(object sender, EventArgs e)
        {
            //if (!Validate())
            //{
            //    return;
            //}
            //string tenSanPham = txt_tensanphamthem.Text.Trim();
            //string nhaCungCap = txt_nhacungungthem.Text.Trim();
            //string nuocSanXuat = txt_nuocsanxuatthem.Text.Trim();
            //string quyCachDongGoi = txt_quycachdonggoithem.Text.Trim();
            //int soLuongPack = int.Parse(txt_soluongpackthem.Text.Trim());
            //int soLuongSanPham = int.Parse(txt_soluongsanphamthem.Text.Trim());
            //decimal giaBan = decimal.Parse(txt_giabanthem.Text.Trim());
            //decimal giaNhap = decimal.Parse(txt_gianhapthem.Text.Trim());
            ////DateTime ngaySanXuat = DateTime.Parse(txt_ngaysanxuatthem.Text.Trim());
            //DateTime hanSuDung = DateTime.Parse(txt_hansudungthem.Text.Trim());
            //string ghiChu = txt_ghichuthem.Text.Trim();
            //try
            //{
            //    // Kết nối đến cơ sở dữ liệu và thực thi lệnh thêm sản phẩm
            //    using (SqlConnection conn = new SqlConnection("Server=localhost; Database=QL_CUAHANG_THUOC; Integrated Security=True;"))
            //    {
            //        conn.Open();

            //        // Câu lệnh SQL để gọi Stored Procedure
            //        using (SqlCommand cmd = new SqlCommand("SP_ThemSanPham", conn))
            //        {
            //            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //            // Thêm các tham số vào câu lệnh
            //            cmd.Parameters.AddWithValue("@TenSanPham", tenSanPham);
            //            cmd.Parameters.AddWithValue("@NhaCungCap", nhaCungCap);
            //            cmd.Parameters.AddWithValue("@NuocSanXuat", nuocSanXuat);
            //            cmd.Parameters.AddWithValue("@QuyCachDongGoi", quyCachDongGoi);
            //            cmd.Parameters.AddWithValue("@SoLuongPack", soLuongPack);
            //            cmd.Parameters.AddWithValue("@SoLuongSanPham", soLuongSanPham);
            //            cmd.Parameters.AddWithValue("@GiaBan", giaBan);
            //            cmd.Parameters.AddWithValue("@GiaNhap", giaNhap);
            //            cmd.Parameters.AddWithValue("@HanSuDung", hanSuDung);
            //            cmd.Parameters.AddWithValue("@GhiChu", ghiChu);

            //            // Thực thi câu lệnh SQL
            //            cmd.ExecuteNonQuery();
            //        }
            //    }

            //    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo");

            //    // Reset form sau khi lưu thành công
            //    txt_ghichuthem.Clear();
            //    txt_giabanthem.Clear();
            //    txt_gianhapthem.Clear();
            //    txt_hansudungthem.Clear();
            //    txt_ngaysanxuatthem.Clear();
            //    txt_nuocsanxuatthem.Clear();
            //    txt_quycachdonggoithem.Clear();
            //    txt_soluongpackthem.Clear();
            //    txt_soluongsanphamthem.Clear();
            //    txt_tensanphamthem.Clear();
            //    txt_nhacungungthem.Clear();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Lỗi thêm sản phẩm: {ex.Message}", "Lỗi");
            //}

        }
        // Hàm kiểm tra dữ liệu nhập vào
        //private bool ValidateInput()
        //{
        //    if (string.IsNullOrEmpty(txt_tensanphamthem.Text.Trim()))
        //    {
        //        MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Lỗi");
        //        return false;
        //    }
        //    if (string.IsNullOrEmpty(txt_nhacungungthem.Text.Trim()))
        //    {
        //        MessageBox.Show("Vui lòng nhập nhà cung cấp!", "Lỗi");
        //        return false;
        //    }
        //    if (string.IsNullOrEmpty(txt_nuocsanxuatthem.Text.Trim()))
        //    {
        //        MessageBox.Show("Vui lòng nhập nước sản xuất!", "Lỗi");
        //        return false;
        //    }
        //    if (string.IsNullOrEmpty(txt_quycachdonggoithem.Text.Trim()))
        //    {
        //        MessageBox.Show("Vui lòng nhập quy cách đóng gói!", "Lỗi");
        //        return false;
        //    }
        //    if (!int.TryParse(txt_soluongpackthem.Text.Trim(), out _))
        //    {
        //        MessageBox.Show("Vui lòng nhập số lượng pack hợp lệ!", "Lỗi");
        //        return false;
        //    }
        //    if (!int.TryParse(txt_soluongsanphamthem.Text.Trim(), out _))
        //    {
        //        MessageBox.Show("Vui lòng nhập số lượng sản phẩm hợp lệ!", "Lỗi");
        //        return false;
        //    }
        //    if (!decimal.TryParse(txt_giabanthem.Text.Trim(), out _))
        //    {
        //        MessageBox.Show("Vui lòng nhập giá bán hợp lệ!", "Lỗi");
        //        return false;
        //    }
        //    if (!decimal.TryParse(txt_gianhapthem.Text.Trim(), out _))
        //    {
        //        MessageBox.Show("Vui lòng nhập giá nhập hợp lệ!", "Lỗi");
        //        return false;
        //    }
        //    if (!DateTime.TryParse(txt_hansudungthem.Text.Trim(), out _))
        //    {
        //        MessageBox.Show("Vui lòng nhập hạn sử dụng hợp lệ!", "Lỗi");
        //        return false;
        //    }

        //    return true;
        //}

    }
}





