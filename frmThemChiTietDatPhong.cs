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

namespace QuanLyKhachSan
{
    public partial class frmThemChiTietDatPhong : Form
    {
        public frmThemChiTietDatPhong()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        private void DanhSachPhongTrong()
        {
            lvPhong.Items.Clear();

            if (txt_tungay.Value==null || txt_denngay.Value==null) { MessageBox.Show("Thời gian không hợp lệ", "Thông báo"); return; }

            GlobalFuncs gf = new GlobalFuncs();
            if (gf.KetnoiCSDL() == false)
                return;
            try
            {
                string queryString = $@"SELECT dbo.Phong.SoPhong, dbo.TrangThaiPhong.TenTrangThai, dbo.Phong.Tang, dbo.Phong.DienThoai, dbo.LoaiPhong.LoaiPhong, dbo.LoaiPhong.SucChua, dbo.LoaiPhong.DonGia, dbo.Phong.IDPhong, dbo.TrangThaiPhong.IDTrangThai, dbo.LoaiPhong.IDLoaiPhong
                                        FROM dbo.TrangThaiPhong
                                        INNER JOIN dbo.Phong ON dbo.TrangThaiPhong.IDTrangThai = dbo.Phong.IDTrangThai 
                                        INNER JOIN dbo.LoaiPhong ON dbo.Phong.IDLoaiPhong = dbo.LoaiPhong.IDLoaiPhong
                                        WHERE dbo.Phong.IDPhong NOT IN 
	                                        (
		                                        SELECT dbo.ChiTietDatPhong.IDPhong from ChiTietDatPhong 
		                                        WHERE 1=1 
			                                        AND ('{txt_tungay.Value.ToString("yyyy-MM-dd")}' > dbo.ChiTietDatPhong.NgayNhanPhong AND '{txt_denngay.Value.ToString("yyyy-MM-dd")}' < dbo.ChiTietDatPhong.NgayTraPhong)
			                                        OR ('{txt_denngay.Value.ToString("yyyy-MM-dd")}' > dbo.ChiTietDatPhong.NgayNhanPhong AND '{txt_tungay.Value.ToString("yyyy-MM-dd")}' < dbo.ChiTietDatPhong.NgayTraPhong)
                                            )";
                SqlCommand sqlCmd = new SqlCommand(queryString, gf.conn);
                sqlCmd.CommandType = CommandType.Text;

                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    string SoPhong = reader.GetString(0);
                    string TenTrangThai = reader.GetString(1);
                    string Tang = reader.GetString(2);
                    string DienThoai = reader.GetString(3);
                    string LoaiPhong = reader.GetString(4);
                    string SucChua = reader.GetString(5);
                    decimal DonGia = reader.GetDecimal(6);
                    int IDPhong = reader.GetInt32(7);
                    int IDTrangThai = reader.GetInt32(8);
                    int IDLoaiPhong = reader.GetInt32(9);
                    
                    ListViewItem lvi = new ListViewItem(SoPhong);
                    lvi.SubItems.Add(TenTrangThai);
                    lvi.SubItems.Add(Tang);
                    lvi.SubItems.Add(DienThoai);
                    lvi.SubItems.Add(LoaiPhong);
                    lvi.SubItems.Add(SucChua);
                    lvi.SubItems.Add(DonGia.ToString());
                    lvi.SubItems.Add(IDPhong.ToString());
                    lvi.SubItems.Add(IDTrangThai.ToString());
                    lvi.SubItems.Add(IDLoaiPhong.ToString());
                    
                    lvPhong.Items.Add(lvi);
                }
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi lấy danh sách phòng trống", "Thông báo");
            }
            lvPhong.Columns[7].Width = 0;
            lvPhong.Columns[8].Width = 0;
            lvPhong.Columns[9].Width = 0;
        }

        private void lvPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPhong.SelectedItems.Count > 0)
            {
                btn_chonphong.Enabled = true;
                txt_idphong.Text = lvPhong.SelectedItems[0].SubItems[7].Text;
            }
            else
            {
                btn_chonphong.Enabled=false;
                txt_idphong.Text = null;
            }
        }

        private void frmThemChiTietDatPhong_Load(object sender, EventArgs e)
        {
            DanhSachPhongTrong();
            txt_iddondatphong.Text = frmQuanLyDatPhong.instance.txt_iddondatphong_shared.Text;
            
        }

        private void btn_chonphong_Click(object sender, EventArgs e)
        {
            bool validateData = true;
            if (txt_iddondatphong.Text.Length<0) { MessageBox.Show("Lỗi lấy thông tin đơn đặt phòng", "Thông báo"); validateData = false; }
            if (txt_idphong.Text.Length < 0) { MessageBox.Show("Lỗi lấy thông tin phòng", "Thông báo"); validateData = false; }
            if (!validateData) return;

            try
            {
                if (txt_tungay.Value.Date >= txt_denngay.Value.Date) { MessageBox.Show("Ngày trả phòng phải lớn hơn ngày nhận phòng", "Thông báo"); return; }

                GlobalFuncs gf = new GlobalFuncs();
                if (!gf.KetnoiCSDL()) { return; }

                SqlCommand cmd = new SqlCommand("prodThemChiTietDatPhong", gf.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NgayNhanPhong", txt_tungay.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@NgayTraPhong", txt_denngay.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@IDDonDatPhong", Int32.Parse(txt_iddondatphong.Text));
                cmd.Parameters.AddWithValue("@IDPhong", Int32.Parse(txt_idphong.Text));

                cmd.ExecuteNonQuery(); cmd.Dispose();
                this.Close();
                frmQuanLyDatPhong.instance.ckb_capnhatchitietdatphong.Checked = true;
            }
            catch
            {

                MessageBox.Show("Có lỗi khi thêm chi tiết đặt phòng", "Thông báo");
            }
        }

        private void txt_tungay_ValueChanged(object sender, EventArgs e)
        {
            DanhSachPhongTrong();
        }

        private void txt_denngay_ValueChanged(object sender, EventArgs e)
        {
            DanhSachPhongTrong();
        }
    }
}
