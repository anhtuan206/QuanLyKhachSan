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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNhanVien();
            LayDuLieuComBoboxBoPhan();
        }

        //Lấy dữ liệu cho commbobox bộ phận
        private void LayDuLieuComBoboxBoPhan()
        {
            GlobalFuncs gf = new GlobalFuncs();
            gf.HienthiDulieutrenComboBox("BoPhan", "IDBoPhan", "TenBoPhan", cbb_bophan);
            cbb_bophan.SelectedIndex = -1;
        }

        //Hiển thị danh sách bộ phận lên list view
        private void HienThiDanhSachNhanVien()
        {
            GlobalFuncs gf = new GlobalFuncs();

            if (gf.KetnoiCSDL() == true)
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select * from viewNhanVien";
                sqlCmd.Connection = gf.conn;

                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    int IDNhanVien = reader.GetInt32(0);
                    string MaNV = reader.GetString(1);
                    string HoVaTen = reader.GetString(2);
                    DateTime NgaySinh = reader.GetDateTime(3);
                    Boolean GioiTinh = reader.GetBoolean(4);
                    string SoDienThoai = reader.GetString(5);
                    int IDBoPhan = reader.GetInt32(6);
                    string CMND = reader.GetString(7);
                    string TenBoPhan = reader.GetString(8);

                    string GioiTinhText = "Nữ";
                    if (GioiTinh) { GioiTinhText = "Nam"; };

                    ListViewItem lvi = new ListViewItem(MaNV.ToString());
                    lvi.SubItems.Add(HoVaTen);
                    lvi.SubItems.Add(NgaySinh.ToString());
                    lvi.SubItems.Add(GioiTinhText);
                    lvi.SubItems.Add(SoDienThoai);
                    lvi.SubItems.Add(CMND);
                    lvi.SubItems.Add(TenBoPhan);
                    lvi.SubItems.Add(IDNhanVien.ToString());
                    lvi.SubItems.Add(IDBoPhan.ToString());

                    lvNhanVien.Items.Add(lvi);
                }
                reader.Close();
            }
        }

        // Khi click chuột để chọn nhân viên trong danh sách
        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi click chọn 1 nhân viên trong danh sách
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                //Thay đổi trạng thái các nút thêm sửa xóa
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnSua.Text = "Sửa";
                btnXoa.Enabled = true;

                //Thay đổi trạng thái và cập nhật thông tin vào các text box
                txt_manv.ReadOnly = true;
                txt_manv.Text = lvNhanVien.SelectedItems[0].SubItems[0].Text;

                txt_hovaten.ReadOnly = true;
                txt_hovaten.Text = lvNhanVien.SelectedItems[0].SubItems[1].Text;

                txt_ngaysinh.Enabled = false;
                txt_ngaysinh.Value = DateTime.Parse(lvNhanVien.SelectedItems[0].SubItems[2].Text);

                radioNam.Enabled = false; radioNu.Enabled = false;
                if (lvNhanVien.SelectedItems[0].SubItems[3].Text == "Nam") radioNam.Checked = true; else radioNu.Checked = true; 

                txt_sodienthoai.ReadOnly = true;
                txt_sodienthoai.Text = lvNhanVien.SelectedItems[0].SubItems[4].Text;

                txt_cmnd.ReadOnly = true;
                txt_cmnd.Text = lvNhanVien.SelectedItems[0].SubItems[5].Text;

                txt_idnhanvien.Text = lvNhanVien.SelectedItems[0].SubItems[7].Text;

                cbb_bophan.Enabled = false;
                cbb_bophan.SelectedValue = Int32.Parse(lvNhanVien.SelectedItems[0].SubItems[8].Text);
            }
            // Khi không chọn
            else
            {
                reset_InputForm();
            }
        }

        private void reset_InputForm()
        {
            //Ẩn các label
            wlbl_manv.Visible = false;
            wlbl_hovaten.Visible = false;
            wlbl_gioitinh.Visible = false;
            wlbl_ngaysinh.Visible = false;
            wlbl_sodienthoai.Visible = false;
            wlbl_cmnd.Visible = false;
            wlbl_bophan.Visible = false;

            // Thay đổi trạng thái và giá trị các trường nhập dữ liệu
            ckb_Sua.Checked = false;
            txt_idnhanvien.Text = null;

            txt_manv.ReadOnly = false;
            txt_manv.Text = null;

            txt_hovaten.ReadOnly = false;
            txt_hovaten.Text = null;

            txt_ngaysinh.Enabled = true;
            txt_ngaysinh.Text = null;

            radioNam.Enabled = true;
            radioNam.Checked = false;
            radioNu.Enabled = true;
            radioNu.Checked = false;

            txt_sodienthoai.ReadOnly = false;
            txt_sodienthoai.Text = null;

            txt_cmnd.ReadOnly = false;
            txt_cmnd.Text = null;

            cbb_bophan.Enabled = true;
            cbb_bophan.SelectedValue = -1;

            //Thay đổi trạng thái các nut thêm sửa xóa
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ckb_Sua.Checked == false)
            {
                ckb_Sua.Checked = true;

                // Thay đổi trạng thái các textbox
                txt_manv.ReadOnly = false;
                txt_hovaten.ReadOnly = false;
                txt_ngaysinh.Enabled = true;
                radioNam.Enabled = true;
                radioNu.Enabled = true;
                txt_sodienthoai.ReadOnly = false;
                txt_cmnd.ReadOnly = false;
                cbb_bophan.Enabled = true;

                // Thay đổi trạng thái nút sửa thành lưu
                btnSua.Text = "Lưu";
            }
            else
            {
                // Kiểm tra dữ liệu trước khi cập nhật
                if (txt_manv.Text.Length <= 0) wlbl_manv.Visible = true; else wlbl_manv.Visible = false;
                if (txt_hovaten.Text.Length <= 0) wlbl_hovaten.Visible = true; else wlbl_hovaten.Visible = false;
                if (radioNam.Checked == false && radioNu.Checked == false) wlbl_gioitinh.Visible = true; else wlbl_gioitinh.Visible = false;
                if (txt_ngaysinh.Text.Length <= 0) wlbl_ngaysinh.Visible = true; else wlbl_ngaysinh.Visible = false;    
                if (txt_sodienthoai.Text.Length <= 0) wlbl_sodienthoai.Visible = true; else wlbl_sodienthoai.Visible = false;
                if (txt_cmnd.Text.Length <= 0) wlbl_cmnd.Visible = true; else wlbl_cmnd.Visible = false;
                if (cbb_bophan.SelectedIndex < 0) wlbl_bophan.Visible = true; else wlbl_bophan.Visible = false;

                if (wlbl_manv.Visible == false && wlbl_hovaten.Visible == false && wlbl_gioitinh.Visible == false && wlbl_ngaysinh.Visible == false && wlbl_sodienthoai.Visible == false && wlbl_cmnd.Visible == false && wlbl_bophan.Visible == false)
                {
                    // Cập nhật vào cơ sở dữ liệu
                    if (lvNhanVien.SelectedItems.Count > 0)
                    {
                        try
                        {
                            GlobalFuncs gf = new GlobalFuncs();
                            if (gf.KetnoiCSDL() == false)
                                return;
                            SqlCommand cmd = new SqlCommand("prodSuaNhanVien", gf.conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaNV", txt_manv.Text);
                            cmd.Parameters.AddWithValue("@HoVaten", txt_hovaten.Text);
                            cmd.Parameters.AddWithValue("@NgaySinh", txt_ngaysinh.Value);
                            if (radioNam.Checked == false)
                                cmd.Parameters.AddWithValue("@GioiTinh", 0);
                            else cmd.Parameters.AddWithValue("@GioiTinh", 1);
                            cmd.Parameters.AddWithValue("@SoDienThoai", txt_sodienthoai.Text);
                            cmd.Parameters.AddWithValue("@CMND", txt_cmnd.Text);
                            cmd.Parameters.AddWithValue("@IDBoPhan", cbb_bophan.SelectedValue);
                            cmd.Parameters.AddWithValue("@IDNhanVien", lvNhanVien.SelectedItems[0].SubItems[7].Text);


                            cmd.ExecuteNonQuery(); cmd.Dispose();
                            lvNhanVien.Items.Clear();
                            HienThiDanhSachNhanVien();
                        }
                        catch
                        {
                            MessageBox.Show("Lỗi sửa nhân viên", "Thông báo");
                        }
                        ckb_Sua.Checked = false;
                        // Thay đổi trạng thái nút lưu thành sửa
                        btnSua.Text = "Sửa";

                        // Thay đổi trạng thái các textbox
                        txt_manv.ReadOnly = true;
                        txt_hovaten.ReadOnly = true;
                        txt_ngaysinh.Enabled = false;
                        radioNam.Enabled = false;
                        radioNu.Enabled = false;
                        txt_sodienthoai.ReadOnly = true;
                        txt_cmnd.ReadOnly = true;
                        cbb_bophan.Enabled = false;
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txt_manv.Text.Length <= 0) wlbl_manv.Visible = true; else wlbl_manv.Visible = false;
            if (txt_hovaten.Text.Length <= 0) wlbl_hovaten.Visible = true; else wlbl_hovaten.Visible = false;
            if (radioNam.Checked == false && radioNu.Checked == false) wlbl_gioitinh.Visible = true; else wlbl_gioitinh.Visible = false;
            if (txt_ngaysinh.Text.Length <= 0) wlbl_ngaysinh.Visible = true; else wlbl_ngaysinh.Visible = false;
            if (txt_sodienthoai.Text.Length <= 0) wlbl_sodienthoai.Visible = true; else wlbl_sodienthoai.Visible = false;
            if (txt_cmnd.Text.Length <= 0) wlbl_cmnd.Visible = true; else wlbl_cmnd.Visible = false;
            if (cbb_bophan.SelectedIndex < 0) wlbl_bophan.Visible = true; else wlbl_bophan.Visible = false;
            if (wlbl_manv.Visible == false && wlbl_hovaten.Visible == false && wlbl_gioitinh.Visible == false && wlbl_ngaysinh.Visible == false && wlbl_sodienthoai.Visible == false && wlbl_cmnd.Visible == false && wlbl_bophan.Visible == false)
            {
                GlobalFuncs gf = new GlobalFuncs();
                try
                {
                    if (gf.KetnoiCSDL() == false)
                        return;
                    SqlCommand cmd = new SqlCommand("prodThemNhanVien", gf.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", txt_manv.Text);
                    cmd.Parameters.AddWithValue("@HoVaten", txt_hovaten.Text);
                    if (radioNam.Checked == false)
                        cmd.Parameters.AddWithValue("@GioiTinh", 0);
                    else cmd.Parameters.AddWithValue("@GioiTinh", 1);
                    cmd.Parameters.AddWithValue("@NgaySinh", txt_ngaysinh.Value);
                    cmd.Parameters.AddWithValue("@SoDienThoai", txt_sodienthoai.Text);
                    cmd.Parameters.AddWithValue("@CMND", txt_cmnd.Text);
                    cmd.Parameters.AddWithValue("@IDBoPhan", cbb_bophan.SelectedValue);

                    cmd.ExecuteNonQuery();
                    lvNhanVien.Items.Clear();
                    HienThiDanhSachNhanVien();
                    cmd.Dispose();
                }
                catch
                {
                    MessageBox.Show("Lỗi thêm dữ liệu", "Thông báo");
                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Khi có chọn
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                GlobalFuncs gf = new GlobalFuncs();
                try
                {
                    if (gf.KetnoiCSDL() == false)
                        return;
                    gf.Xoadulieu("prodXoaNhanVien", "@IDNhanVien", lvNhanVien.SelectedItems[0].SubItems[7].Text);
                    lvNhanVien.Items.Clear();
                    HienThiDanhSachNhanVien();
                    reset_InputForm();
                }
                catch
                {
                    MessageBox.Show("Lỗi xóa nhân viên", "Thông báo");
                }
            }
        }

    }
    
}
