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
using System.Runtime.CompilerServices;

namespace QuanLyKhachSan
{
    public partial class frmQuanLyPhong : Form
    {
        public frmQuanLyPhong()
        {
            InitializeComponent();
        }

        private void frmQuanLyPhong_Load(object sender, EventArgs e)
        {
            DanhSachTrangThaiPhong();
            DanhSachLoaiPhong();
            DanhSachPhong();
        }

        private void DanhSachTrangThaiPhong()
        {
            GlobalFuncs gf = new GlobalFuncs();

            if (gf.KetnoiCSDL() == true)
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = "select * from TrangThaiPhong";
                    sqlCmd.Connection = gf.conn;

                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int IDTrangThai = reader.GetInt32(0);
                        string TenTrangThai = reader.GetString(1);

                        ListViewItem lvi = new ListViewItem(IDTrangThai.ToString());
                        lvi.SubItems.Add(TenTrangThai);
                        lvTrangThaiPhong.Items.Add(lvi);
                    }
                    reader.Close();
                }
                catch
                {
                    MessageBox.Show("Lỗi lấy danh sách trạng thái phòng", "Thông báo");
                }
            }
        }

        private void DanhSachLoaiPhong()
        {
            GlobalFuncs gf = new GlobalFuncs();

            if (gf.KetnoiCSDL() == true)
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = "select * from LoaiPhong";
                    sqlCmd.Connection = gf.conn;

                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int IDLoaiPhong = reader.GetInt32(0);
                        string LoaiPhong = reader.GetString(1);
                        string SucChua = reader.GetString(2);
                        decimal DonGia = reader.GetDecimal(3);

                        ListViewItem lvi = new ListViewItem(IDLoaiPhong.ToString());
                        lvi.SubItems.Add(LoaiPhong);
                        lvi.SubItems.Add(SucChua);
                        lvi.SubItems.Add(DonGia.ToString());

                        lvLoaiPhong.Items.Add(lvi);
                    }
                    reader.Close();
                }
                catch
                {
                    MessageBox.Show("Lỗi lấy danh sách loại phòng", "Thông báo");
                }
            }
        }

        private void DanhSachPhong()
        {
            GlobalFuncs gf = new GlobalFuncs();
            if (gf.KetnoiCSDL() == false)
                return;
            gf.HienthiDulieutrenComboBox("TrangThaiPhong", "IDTrangThai", "TenTrangThai", cbb_trangthai);cbb_trangthai.SelectedIndex = -1;
            gf.HienthiDulieutrenComboBox("LoaiPhong", "IDLoaiPhong", "LoaiPhong", cbb_loaiphong);cbb_loaiphong.SelectedIndex = -1;
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select * from viewTrangThaiPhong";
                sqlCmd.Connection = gf.conn;

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
                MessageBox.Show("Lỗi lấy danh sách phòng", "Thông báo");
            }
        }

        private void btnThemTrangThaiPhong_Click(object sender, EventArgs e)
        {
            if (txt_trangthai.Text.Length <= 0)
            {
                wlbl_tentrangthai.Visible = true;
                return;
            }

            GlobalFuncs gf = new GlobalFuncs();

            if (gf.KetnoiCSDL() == true)
            {
                gf.ThemDuLieu("prodThemTrangThaiPhong", "@TenTrangThai", txt_trangthai.Text);
                
                lvTrangThaiPhong.Items.Clear();
                DanhSachTrangThaiPhong();
                
                resetInputTrangThaiPhong();
            }
        }

        private void btnXoaTrangThaiPhong_Click(object sender, EventArgs e)
        {
            if (lvTrangThaiPhong.SelectedItems.Count > 0)
            {
                GlobalFuncs gf = new GlobalFuncs();

                if (gf.KetnoiCSDL() == true)
                {
                    gf.XoadulieuByID("prodXoaTrangThaiPhong", "@IDTrangThai", Int32.Parse(lvTrangThaiPhong.SelectedItems[0].SubItems[0].Text));
                    lvTrangThaiPhong.Items.Clear();
                    DanhSachTrangThaiPhong();
                    resetInputTrangThaiPhong();
                }
            }
        }

        private void btnXoaLoaiPhong_Click(object sender, EventArgs e)
        {
            if (lvLoaiPhong.SelectedItems.Count > 0)
            {
                GlobalFuncs gf = new GlobalFuncs();

                if (gf.KetnoiCSDL() == true)
                {
                    gf.XoadulieuByID("prodXoaLoaiPhong", "@IDLoaiPhong", Int32.Parse(lvLoaiPhong.SelectedItems[0].SubItems[0].Text));
                    lvLoaiPhong.Items.Clear();
                    DanhSachLoaiPhong();
                    resetInputLoaiPhong();
                }
            }
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            if (lvPhong.SelectedItems.Count > 0)
            {
                GlobalFuncs gf = new GlobalFuncs();

                if (gf.KetnoiCSDL() == true)
                {
                    gf.XoadulieuByID("prodXoaPhong", "@IDPhong", Int32.Parse(txt_idphong.Text));
                    lvPhong.Items.Clear();
                    DanhSachPhong();
                    resetInputPhong();
                }
            }
        }

        private void btnSuaTrangThaiPhong_Click(object sender, EventArgs e)
        {
            if (lvTrangThaiPhong.SelectedItems.Count > 0)
            {

                // Click nút sửa trạng thái phòng
                if (ckb_SuaTrangThaiPhong.Checked == false)
                {
                    //cập nhật dữ liệu lên các trường controls
                    txt_idtrangthaiphong.Text = lvTrangThaiPhong.SelectedItems[0].SubItems[0].Text;

                    //cập nhật trạng thái control, cho phép input dữ liệu
                    ckb_SuaTrangThaiPhong.Checked = true;
                    txt_trangthai.ReadOnly = false;
                    btnSuaTrangThaiPhong.Text = "Lưu";
                }
                //Click nút lưu trạng thái phòng
                else
                {
                    //Kiểm tra dữ liệu 
                    if (txt_trangthai.Text.Length <= 0)
                    {
                        wlbl_tentrangthai.Visible = true;
                        return;
                    }

                    try
                    {
                        //Cập nhật dữ liệu vào DB
                        GlobalFuncs gf = new GlobalFuncs();
                        if (gf.KetnoiCSDL() == false)
                            return;
                        SqlCommand cmd = new SqlCommand("prodSuaTrangThaiPhong", gf.conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDTrangThai", Int32.Parse(txt_idtrangthaiphong.Text));
                        cmd.Parameters.AddWithValue("@TenTrangThai", txt_trangthai.Text);

                        cmd.ExecuteNonQuery();cmd.Dispose();

                        //Cập nhật dữ liệu lên listview
                        lvTrangThaiPhong.Items.Clear();
                        DanhSachTrangThaiPhong();

                        //cập nhật trạng thái controls, không cho phép input dữ liệu
                        resetInputTrangThaiPhong();
                    }
                    catch { MessageBox.Show("Lỗi sửa trạng thái phòng", "Thông báo"); }
                }
            }
        }

        private void resetInputTrangThaiPhong()
        {
            btnThemTrangThaiPhong.Enabled = true;
            btnSuaTrangThaiPhong.Enabled = false;
            btnXoaTrangThaiPhong.Enabled=false;

            txt_idtrangthaiphong.Text = null;
            
            ckb_SuaTrangThaiPhong.Checked = false;
            ckb_SuaTrangThaiPhong.Text = "Sửa";
            
            txt_trangthai.ReadOnly = false;
            txt_trangthai.Text=null ; 
            wlbl_tentrangthai.Visible = false;

        }

        private void btnSuaLoaiPhong_Click(object sender, EventArgs e)
        {
            if (lvLoaiPhong.SelectedItems.Count > 0)
            {
                // Click nút sửa trạng thái phòng
                if (ckb_sualoaiphong.Checked == false)
                {
                    //cập nhật dữ liệu lên các trường controls
                    txt_idloaiphong.Text = lvLoaiPhong.SelectedItems[0].SubItems[0].Text;
                    txt_loaiphong.Text = lvLoaiPhong.SelectedItems[0].SubItems[1].Text;
                    txt_succhua.Text = lvLoaiPhong.SelectedItems[0].SubItems[2].Text;
                    txt_dongia.Text = lvLoaiPhong.SelectedItems[0].SubItems[3].Text;

                    //cập nhật trạng thái control, cho phép input dữ liệu
                    txt_idloaiphong.Text = lvLoaiPhong.SelectedItems[0].SubItems[0].Text;
                    ckb_sualoaiphong.Checked = true;
                    txt_loaiphong.ReadOnly = false;
                    txt_succhua.ReadOnly = false;
                    txt_dongia.ReadOnly = false;
                    btnSuaLoaiPhong.Text = "Lưu";

                }
                //Click nút lưu trạng thái phòng
                else
                {
                    //Kiểm tra dữ liệu 
                    bool validateData = true;
                    if (txt_loaiphong.Text.Length <= 0) { wlbl_loaiphong.Visible = true; validateData = false; }
                    if (txt_succhua.Text.Length <= 0) { wlbl_succhua.Visible = true; validateData = false; }
                    if (txt_dongia.Text.Length <= 0) { wlbl_dongia.Visible = true; validateData = false; }

                    if (validateData == false) return;

                    try
                    {
                        //Cập nhật dữ liệu vào DB
                        GlobalFuncs gf = new GlobalFuncs();
                        if (gf.KetnoiCSDL() == false)
                            return;
                        SqlCommand cmd = new SqlCommand("prodSuaLoaiPhong", gf.conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDLoaiPhong", Int32.Parse(txt_idloaiphong.Text));
                        cmd.Parameters.AddWithValue("@LoaiPhong", txt_loaiphong.Text);
                        cmd.Parameters.AddWithValue("@SucChua", txt_succhua.Text);
                        cmd.Parameters.AddWithValue("@DonGia", txt_dongia.Text);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        //Cập nhật dữ liệu lên listview
                        lvLoaiPhong.Items.Clear();
                        DanhSachLoaiPhong();

                        //cập nhật trạng thái controls, không cho phép input dữ liệu
                        //ckb_sualoaiphong.Checked = false;
                        //txt_loaiphong.ReadOnly = true; txt_succhua.ReadOnly = true; txt_dongia.ReadOnly = true; btnSuaLoaiPhong.Text = "Sửa";
                        //wlbl_loaiphong.Visible = false; wlbl_succhua.Visible = false; wlbl_dongia.Visible = false;
                        resetInputLoaiPhong();
                    }
                    catch { MessageBox.Show("Lỗi sửa trạng thái phòng", "Thông báo"); }
                }
            }
        }

        private void resetInputLoaiPhong() {
            txt_idloaiphong.Text = null;
            txt_loaiphong.Text = null;
            txt_succhua.Text = null;
            txt_dongia.Text = null;
            ckb_sualoaiphong.Checked = false;
            txt_loaiphong.ReadOnly = false; txt_succhua.ReadOnly = false; txt_dongia.ReadOnly = false; btnSuaLoaiPhong.Text = "Sửa";
            wlbl_loaiphong.Visible = false; wlbl_succhua.Visible = false; wlbl_dongia.Visible = false;
            btnThemLoaiPhong.Enabled = true;
            btnSuaLoaiPhong.Enabled = false;
            btnXoaLoaiPhong.Enabled = false;
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            if (lvPhong.Items.Count > 0)
            {
                if (ckb_suaphong.Checked == false)
                {
                    //cập nhật dữ liệu lên các trường controls
                    ckb_suaphong.Checked = true;
                    txt_idphong.Text = lvPhong.SelectedItems[0].SubItems[7].Text;
                    txt_sophong.Text = lvPhong.SelectedItems[0].SubItems[0].Text;
                    cbb_trangthai.SelectedValue = lvPhong.SelectedItems[0].SubItems[8].Text;
                    txt_tang.Text = lvPhong.SelectedItems[0].SubItems[2].Text;
                    txt_dienthoai.Text = lvPhong.SelectedItems[0].SubItems[3].Text;
                    cbb_loaiphong.SelectedValue = lvPhong.SelectedItems[0].SubItems[9].Text;

                    //cập nhật trạng thái control, cho phép input dữ liệu
                    txt_sophong.ReadOnly = false; cbb_trangthai.Enabled = true; txt_tang.ReadOnly = false; txt_dienthoai.ReadOnly = false; cbb_loaiphong.Enabled = true;
                    btnSuaPhong.Text = "Lưu";
                }
                else
                {
                    bool validateData = true;
                    if (txt_tang.Text.Length < 0) { validateData = false; wlbl_tang.Visible = true; }
                    if (txt_sophong.Text.Length < 0) { validateData = false; wlbl_tang.Visible = true; }
                    if (txt_dienthoai.Text.Length < 0) { validateData = false; wlbl_tang.Visible = true; }
                    if (cbb_trangthai.SelectedIndex < 0) { validateData = false; wlbl_cbb_trangthai.Visible = true; }
                    if (cbb_loaiphong.SelectedIndex < 0) { validateData = false; wlbl_cbb_loaiphong.Visible = true; }

                    if (validateData == false) return;

                    try
                    {
                        //Cập nhật dữ liệu vào DB
                        GlobalFuncs gf = new GlobalFuncs();
                        if (gf.KetnoiCSDL() == false)
                            return;
                        SqlCommand cmd = new SqlCommand("prodSuaPhong", gf.conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDPhong", Int32.Parse(txt_idphong.Text));
                        cmd.Parameters.AddWithValue("@Tang", txt_tang.Text);
                        cmd.Parameters.AddWithValue("@SoPhong", txt_sophong.Text);
                        cmd.Parameters.AddWithValue("@DienThoai", txt_dienthoai.Text);
                        cmd.Parameters.AddWithValue("@IDTrangThai", cbb_trangthai.SelectedValue);
                        cmd.Parameters.AddWithValue("@IDLoaiPhong", cbb_loaiphong.SelectedValue);

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        //Cập nhật dữ liệu lên listview
                        lvPhong.Items.Clear();
                        DanhSachPhong();

                        //cập nhật trạng thái controls, không cho phép input dữ liệu
                        resetInputPhong();
                    }
                    catch { MessageBox.Show("Lỗi cập nhật thông tin phòng", "Thông báo"); }


                }
            }
        }

        private void resetInputPhong()
        {
            ckb_suaphong.Checked = false;
            txt_idphong.Text = null;
            txt_sophong.Text = null;
            cbb_trangthai.SelectedIndex=-1;
            txt_tang.Text = null;
            txt_dienthoai.Text = null;
            cbb_loaiphong.SelectedIndex = -1;
            txt_sophong.ReadOnly = false; cbb_trangthai.Enabled = true; txt_tang.ReadOnly = false; txt_dienthoai.ReadOnly = false; cbb_loaiphong.Enabled = true; btnSuaPhong.Text = "Sửa";
            wlbl_tang.Visible = false; wlbl_tang.Visible = false; wlbl_tang.Visible = false; wlbl_cbb_trangthai.Visible = false; wlbl_cbb_loaiphong.Visible = false;
            btnThemPhong.Enabled = true;
            btnSuaPhong.Enabled = false;
            btnXoaPhong.Enabled = false;
        }

        private void lvTrangThaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi click chọn 1 dòng trong listview
            if (lvTrangThaiPhong.SelectedItems.Count > 0)
            {
                btnThemTrangThaiPhong.Enabled = false;
                btnSuaTrangThaiPhong.Enabled = true; btnSuaTrangThaiPhong.Text = "Sửa";
                btnXoaTrangThaiPhong.Enabled = true;

                txt_idtrangthaiphong.Text = lvTrangThaiPhong.SelectedItems[0].SubItems[0].Text;
                txt_trangthai.Text = lvTrangThaiPhong.SelectedItems[0].SubItems[1].Text;
                txt_trangthai.ReadOnly = true;
            }
            // Khi không chọn
            else
            {
                resetInputTrangThaiPhong();
            }
        }

        private void lvLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi click chọn 1 dòng trong listview
            if (lvLoaiPhong.SelectedItems.Count > 0)
            {
                btnThemLoaiPhong.Enabled = false;
                btnSuaLoaiPhong.Enabled = true;
                btnXoaLoaiPhong.Enabled = true;
                txt_idloaiphong.Text = lvLoaiPhong.SelectedItems[0].SubItems[0].Text;
                txt_loaiphong.Text = lvLoaiPhong.SelectedItems[0].SubItems[1].Text; txt_loaiphong.ReadOnly = true;
                txt_succhua.Text = lvLoaiPhong.SelectedItems[0].SubItems[2].Text; txt_succhua.ReadOnly = true;
                txt_dongia.Text = lvLoaiPhong.SelectedItems[0].SubItems[3].Text; txt_dongia.ReadOnly = true;
            }
            // Khi không chọn
            else
            {
                resetInputLoaiPhong();
            }
        }

        private void btnThemLoaiPhong_Click(object sender, EventArgs e)
        {
            bool validateData = true;
            if (txt_loaiphong.Text.Length <= 0) { wlbl_loaiphong.Visible = true; validateData = false; }
            if (txt_succhua.Text.Length <= 0) { wlbl_succhua.Visible = true; validateData = false; }
            if (txt_dongia.Text.Length <= 0) { wlbl_dongia.Visible = true; validateData = false; }

            if (!validateData) return;

            GlobalFuncs gf = new GlobalFuncs();

            if (gf.KetnoiCSDL() == false)
                return;
            SqlCommand cmd = new SqlCommand("prodThemLoaiPhong", gf.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@LoaiPhong", txt_loaiphong.Text);
            cmd.Parameters.AddWithValue("@SucChua", txt_succhua.Text);
            cmd.Parameters.AddWithValue("@DonGia", double.Parse(txt_dongia.Text));

            cmd.ExecuteNonQuery(); cmd.Dispose();

            lvLoaiPhong.Items.Clear();
            DanhSachLoaiPhong();
            resetInputLoaiPhong();
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            bool validateData = true;
            if (txt_sophong.Text.Length <= 0) { wlbl_sophong.Visible = true; validateData = false; }
            if (cbb_trangthai.SelectedIndex < 0) { wlbl_cbb_trangthai.Visible = true; validateData = false; }
            if (txt_tang.Text.Length <= 0) { wlbl_tang.Visible = true; validateData = false; }
            if (txt_dienthoai.Text.Length <= 0) { wlbl_sodienthoai.Visible = true; validateData = false; }
            if (cbb_loaiphong.SelectedIndex < 0) { wlbl_cbb_loaiphong.Visible = true; validateData = false; }

            if (!validateData) return;

            GlobalFuncs gf = new GlobalFuncs();

            if (gf.KetnoiCSDL() == false)
                return;
            SqlCommand cmd = new SqlCommand("prodThemPhong", gf.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SoPhong", txt_sophong.Text);
            cmd.Parameters.AddWithValue("@IDTrangThai", cbb_trangthai.SelectedValue);
            cmd.Parameters.AddWithValue("@Tang", txt_tang.Text);
            cmd.Parameters.AddWithValue("@DienThoai", txt_dienthoai.Text);
            cmd.Parameters.AddWithValue("@IDLoaiPhong", cbb_loaiphong.SelectedValue);


            cmd.ExecuteNonQuery(); cmd.Dispose();

            lvPhong.Items.Clear();
            DanhSachPhong();
            resetInputPhong();
            txt_sophong.Focus();
        }

        private void lvPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalFuncs gf = new GlobalFuncs();
            if (gf.KetnoiCSDL() == false)
                return;
            gf.HienthiDulieutrenComboBox("TrangThaiPhong", "IDTrangThai", "TenTrangThai", cbb_trangthai);
            gf.HienthiDulieutrenComboBox("LoaiPhong", "IDLoaiPhong", "LoaiPhong", cbb_loaiphong);

            if (lvPhong.SelectedItems.Count > 0)
            {
                btnThemPhong.Enabled = false;
                btnSuaPhong.Enabled = true;
                btnXoaPhong.Enabled = true;
                txt_idphong.Text = lvPhong.SelectedItems[0].SubItems[7].Text;
                txt_sophong.ReadOnly = true; cbb_trangthai.Enabled = false; txt_tang.ReadOnly = true; txt_dienthoai.ReadOnly = true; cbb_loaiphong.Enabled = false;
                txt_sophong.Text = lvPhong.SelectedItems[0].SubItems[0].Text;
                cbb_trangthai.SelectedValue = lvPhong.SelectedItems[0].SubItems[8].Text;
                txt_tang.Text = lvPhong.SelectedItems[0].SubItems[2].Text;
                txt_dienthoai.Text = lvPhong.SelectedItems[0].SubItems[3].Text;
                cbb_loaiphong.SelectedValue = lvPhong.SelectedItems[0].SubItems[9].Text;
            }
            else
            {
                resetInputPhong();
            }
        }

        private void ckb_SuaTrangThaiPhong_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
