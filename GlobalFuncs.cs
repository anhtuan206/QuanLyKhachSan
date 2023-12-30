using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    internal class GlobalFuncs
    {
        // SQL Connection String
        public string connStr = @"Data Source=10.72.1.246;Initial Catalog=tuanpa2_QuanLyKhachSan;Persist Security Info=True;User ID=eoffice;Password=.net@123;Encrypt=False;TrustServerCertificate=True";
        public SqlConnection conn = new SqlConnection();
        public bool KetnoiCSDL()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.ConnectionString = connStr;
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu", "Thông báo");
                return false;
            }
            return true;
        }

        //Truyền tên bảng và điều kiện vào strSQL, truyền tên GridView vào dgr
        public void HienthiDulieutrenDatagridView(string strSQL, DataGridView dgr)
        {
            if (KetnoiCSDL() == false)
                return;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from " + strSQL, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgr.DataSource = dt;
                dgr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                da.Dispose();
                dt.Dispose();
            }
            catch
            {
                MessageBox.Show("Lỗi hiển thị dữ liệu", "Thông báo");
                return;
            }
        }

        //Kiểm tra giá trị số thực
        public bool KiemtraDulieuSothuc(string strSo)
        {
            try
            {
                float.Parse(strSo);
            }
            catch
            {
                return false;
            }
            return true;
        }
        //Kiểm tra giá trị số nguyên
        public bool KiemtraDulieuSonguyen(string strSo)
        {
            try
            {
                int.Parse(strSo);
            }
            catch
            {
                return false;
            }
            return true;
        }

        //Kiểm tra dữ liệu ngày tháng
        public bool KiemtraDulieuNgaythang(string strNgaythang)
        {
            try
            {
                DateTime.Parse(strNgaythang);
            }
            catch
            {
                return false;
            }
            return true;
        }

        //Xóa dữ liệu trong bảng
        public void Xoadulieu(string sTenThutuc, string sThamso, string sGiatri)
        {
            if (KetnoiCSDL() == false)
                return;
            try
            {
                SqlCommand cmd = new SqlCommand(sTenThutuc, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(sThamso, sGiatri);
                cmd.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Lỗi xóa dữ liệu", "Thông báo");
            }
        }

        //Xóa dữ liệu trong bảng
        public void XoadulieuByID(string sTenThutuc, string sThamso, int sGiatri)
        {
            if (KetnoiCSDL() == false)
                return;
            try
            {
                SqlCommand cmd = new SqlCommand(sTenThutuc, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(sThamso, sGiatri);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Lỗi xóa dữ liệu", "Thông báo");
            }
        }

        //Sửa dữ liệu trong bảng
        public void SuaBoPhan(string sTenThutuc, string sThamso, string sGiatri, int idBoPhan)
        {
            if (KetnoiCSDL() == false)
                return;
            try
            {
                SqlCommand cmd = new SqlCommand(sTenThutuc, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(sThamso, sGiatri);
                cmd.Parameters.AddWithValue("@idBoPhan", idBoPhan);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Lỗi cập nhật dữ liệu", "Thông báo");
            }
        }

        //Thêm dữ liệu trong bảng
        public void ThemDuLieu(string sTenThutuc, string sThamso, string sGiatri)
        {
            if (KetnoiCSDL() == false)
                return;
            try
            {
                SqlCommand cmd = new SqlCommand(sTenThutuc, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(sThamso, sGiatri);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Lỗi xóa dữ liệu", "Thông báo");
            }
        }
        //Lấy dữ liệu từ bảng và đưa vào ComboBox
        public void HienthiDulieutrenComboBox(string sTenbang, string sTenCotKhoa, string sTenCotHienthi, ComboBox cbo)
        {
            if (KetnoiCSDL() == false)
                return;
            string strSQL = "Select " + sTenCotKhoa + "," + sTenCotHienthi + " From "+sTenbang;
            SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = sTenCotHienthi;
            cbo.ValueMember = sTenCotKhoa;
            da.Dispose();
        }
    }
}
