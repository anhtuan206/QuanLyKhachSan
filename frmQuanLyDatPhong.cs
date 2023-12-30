using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmQuanLyDatPhong : Form
    {
        public frmQuanLyDatPhong()
        {
            InitializeComponent();
        }

        private void frmQuanLyDatPhong_Load(object sender, EventArgs e)
        {
            DanhSachDichVu();
            DanhSachKhachHang();
            DanhSachDonDatPhong();
        }

        private void DanhSachKhachHang()
        {
            lvKhachHang.Items.Clear();

            GlobalFuncs gf = new GlobalFuncs();
            if (gf.KetnoiCSDL() == false) { return; }
            try
            {
                SqlCommand cmd = new SqlCommand("select * from KhachHang", gf.conn);
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem(reader.GetInt32(0).ToString());
                    lvi.SubItems.Add(reader.GetString(1));
                    lvi.SubItems.Add(reader.GetDateTime(2).ToString());
                    bool GioiTinh = reader.GetBoolean(3);lvi.SubItems.Add(GioiTinh?"Nam":"Nữ");
                    lvi.SubItems.Add(reader.GetString(4).ToString());
                    lvi.SubItems.Add(reader.GetString(5).ToString());
                    lvi.SubItems.Add(reader.GetString(6).ToString());


                    lvKhachHang.Items.Add(lvi);
                }
                reader.Close();
            }
            catch { MessageBox.Show("Lỗi lấy danh sách khách hàng", "Thông báo"); }
        }

        private void lvKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKhachHang.SelectedItems.Count > 0)
            {
                btn_themkhachhang.Enabled = false;
                btn_suakhachhang.Enabled = true;
                btn_xoakhachhang.Enabled = true;
                
                ckb_suakhachhang.Checked = false;

                txt_hovaten.ReadOnly = true;
                txt_ngaysinh.Enabled = false;
                radioNam.Enabled = false;
                radioNu.Enabled = false;
                txt_sdt.ReadOnly = true;
                txt_email.ReadOnly = true;
                txt_cmnd.ReadOnly = true;

                txt_idkhachhang.Text = lvKhachHang.SelectedItems[0].SubItems[0].Text;
                txt_hovaten.Text = lvKhachHang.SelectedItems[0].SubItems[1].Text;
                txt_ngaysinh.Value = DateTime.Parse(lvKhachHang.SelectedItems[0].SubItems[2].Text);
                if (lvKhachHang.SelectedItems[0].SubItems[3].Text=="Nam") radioNam.Checked = true; else radioNu.Checked = true;
                txt_sdt.Text = lvKhachHang.SelectedItems[0].SubItems[4].Text;
                txt_email.Text = lvKhachHang.SelectedItems[0].SubItems[5].Text;
                txt_cmnd.Text = lvKhachHang.SelectedItems[0].SubItems[6].Text;

            }
            else
            {
                resetInputFormKhachHang();
            }
        }

        private void resetInputFormKhachHang()
        {
            btn_themkhachhang.Enabled = true ;
            btn_suakhachhang.Enabled = false;
            btn_xoakhachhang.Enabled = false;
            ckb_suakhachhang.Checked = false;
            
            txt_idkhachhang.Text = null;
            txt_hovaten.Text = null;
            txt_ngaysinh.Text = null;
            radioNam.Checked = false;
            radioNu.Checked = false;
            txt_sdt.Text = null;
            txt_email.Text = null;
            txt_cmnd.Text = null;
            
            txt_hovaten.ReadOnly=false;
            txt_ngaysinh.Enabled = true;
            radioNam.Enabled = true;
            radioNu.Enabled=true;
            txt_sdt.ReadOnly = false;
            txt_email.ReadOnly=false;
            txt_cmnd.ReadOnly = false;
            
            wlbl_email.Visible = false;
            wlbl_cmnd.Visible = false;
            wlbl_sodienthoai.Visible = false;
            wlbl_ngaysinh.Visible   = false;
            wlbl_gioitinh.Visible = false;
            wlbl_hoten.Visible = false;
            
        }

        private void lvDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDichVu.SelectedItems.Count > 0)
            {
                btn_themdichvu.Enabled = false;
                btn_suadichvu.Enabled = true;
                btn_xoadichvu.Enabled = true;

                txt_iddichvu.Text = lvDichVu.SelectedItems[0].SubItems[0].Text;
                txt_tendichvu.ReadOnly = true; txt_tendichvu.Text = lvDichVu.SelectedItems[0].SubItems[1].Text;
                txt_donvitinh.ReadOnly = true; txt_donvitinh.Text = lvDichVu.SelectedItems[0].SubItems[2].Text;
                txt_dongia.ReadOnly = true; txt_dongia.Text = lvDichVu.SelectedItems[0].SubItems[3].Text;
            }
            else
            {
                resetInputFormDichVu();
            }

        }
        private void resetInputFormDichVu()
        {
            btn_themdichvu.Enabled = true;
            btn_suadichvu.Enabled = false;btn_suadichvu.Text = "Sửa";
            btn_xoadichvu.Enabled = false;

            txt_tendichvu.ReadOnly = false;txt_tendichvu.Text = null;
            txt_donvitinh.ReadOnly = false;txt_donvitinh.Text=null;
            txt_dongia.ReadOnly = false;txt_dongia.Text = null;

            wlbl_tendichvu.Visible = false;
            wlbl_donvitinh.Visible = false;
            wlbl_dongia.Visible = false;

            ckb_suadichvu.Checked= false;
            txt_iddichvu.Text = null;
        }

        private void lvDonDatPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resetInputFormDonDatPhong()
        {
            btn_themdondatphong.Enabled = true;
            btn_suadondatphong.Enabled=false;
            btn_xoadondatphong.Enabled = false;

        }

        private void DanhSachDonDatPhong()
        {
            GlobalFuncs gf = new GlobalFuncs();
            if (gf.KetnoiCSDL() == false) { return; }
            try
            {
                SqlCommand cmd = new SqlCommand("select * from viewDonDatPhong", gf.conn);
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem(reader.GetInt32(0).ToString());
                    lvi.SubItems.Add(reader.GetString(1));
                    lvi.SubItems.Add(reader.GetString(2));
                    lvi.SubItems.Add(reader.GetString(3));
                    lvi.SubItems.Add(reader.GetString(4));
                    lvi.SubItems.Add(reader.GetString(5));
                    lvi.SubItems.Add(reader.GetString(6));
                    lvi.SubItems.Add(reader.GetInt32(7).ToString());
                    lvi.SubItems.Add(reader.GetInt32(6).ToString());

                    lvDonDatPhong.Items.Add(lvi);
                }
                reader.Close();
            }
            catch { MessageBox.Show("Lỗi lấy danh sách đơn đặt phòng", "Thông báo"); }
        }

        private void DanhSachDichVu() {
            lvDichVu.Items.Clear();

            GlobalFuncs gf = new GlobalFuncs();
            if (gf.KetnoiCSDL() == false) { return; }
            try { 
                SqlCommand cmd = new SqlCommand("select * from DichVu",gf.conn);
                cmd.CommandType= CommandType.Text;
            
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem(reader.GetInt32(0).ToString());
                    lvi.SubItems.Add(reader.GetString(1));
                    lvi.SubItems.Add(reader.GetString(2));
                    lvi.SubItems.Add(reader.GetDecimal(3).ToString());

                    lvDichVu.Items.Add(lvi);
                }
                reader.Close();
            }
            catch { MessageBox.Show("Lỗi lấy danh sách dịch vụ", "Thông báo"); }
        }

        private void btn_themdichvu_Click(object sender, EventArgs e)
        {
            bool validateData = true;
            if (txt_tendichvu.Text.Length <=0) { wlbl_tendichvu.Visible = true; validateData = false; }
            if (txt_donvitinh.Text.Length<=0) { wlbl_donvitinh.Visible=true; validateData = false; }
            if (txt_dongia.Text.Length<=0) {  txt_dongia.Visible=true;validateData = false; }
            if (!validateData) { return; }
            
            try { decimal.Parse(txt_dongia.Text); } catch { wlbl_dongia.Text = "Đơn giá không hợp lệ"; wlbl_dongia.Visible=true; return; };
            
            GlobalFuncs gf = new GlobalFuncs();
            if (gf.KetnoiCSDL()==false) { return; }

            
            SqlCommand cmd = new SqlCommand("prodThemDichVu",gf.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDichVu", txt_tendichvu.Text);
            cmd.Parameters.AddWithValue("@DonViTinh", txt_donvitinh.Text);
            cmd.Parameters.AddWithValue("@DonGia", decimal.Parse(txt_dongia.Text));
            cmd.ExecuteNonQuery(); cmd.Dispose();

            DanhSachDichVu();
            resetInputFormDichVu();
        }

        private void btn_suadichvu_Click(object sender, EventArgs e)
        {
            if (ckb_suadichvu.Checked == false && txt_iddichvu.Text!=null) { 
                ckb_suadichvu.Checked = true;
                btn_suadichvu.Text = "Lưu";
                txt_iddichvu.Text = lvDichVu.SelectedItems[0].SubItems[0].Text;
                txt_tendichvu.Text = lvDichVu.SelectedItems[0].SubItems[1].Text;txt_tendichvu.ReadOnly = false;
                txt_donvitinh.Text = lvDichVu.SelectedItems[0].SubItems[2].Text;txt_donvitinh.ReadOnly = false;
                txt_dongia.Text = lvDichVu.SelectedItems[0].SubItems[3].Text;txt_dongia.ReadOnly = false;
            }
            else
            {
                bool validateData = true;
                if (txt_tendichvu.Text.Length <= 0) { wlbl_tendichvu.Visible = true; validateData = false; }
                if (txt_donvitinh.Text.Length <= 0) { wlbl_donvitinh.Visible = true; validateData = false; }
                if (txt_dongia.Text.Length <= 0) { txt_dongia.Visible = true; validateData = false; }
                if (!validateData) { return; }

                try { decimal.Parse(txt_dongia.Text); } catch { wlbl_dongia.Text = "Đơn giá không hợp lệ"; wlbl_dongia.Visible = true; return; };


                GlobalFuncs gf = new GlobalFuncs();
                if (gf.KetnoiCSDL() != false) { return; }

                SqlCommand cmd = new SqlCommand("prodSuaDichVu", gf.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TenDichVu", txt_tendichvu.Text);
                cmd.Parameters.AddWithValue("@DonViTinh", txt_donvitinh.Text);
                cmd.Parameters.AddWithValue("@Dongia", decimal.Parse(txt_dongia.Text));
                cmd.ExecuteNonQuery(); cmd.Dispose();

                DanhSachDichVu();
                resetInputFormDichVu();

            }
        }

        private void btn_xoadichvu_Click(object sender, EventArgs e)
        {
            if (lvDichVu.SelectedItems.Count > 0 && txt_iddichvu.Text!=null )
            {
                GlobalFuncs gf = new GlobalFuncs();
                if (!gf.KetnoiCSDL()) { return; }
                try { 
                    SqlCommand cmd = new SqlCommand("prodXoaDichVu", gf.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDDichVu", Int32.Parse(txt_iddichvu.Text));
                    cmd.ExecuteNonQuery(); cmd.Dispose();
                    DanhSachDichVu();
                    resetInputFormDichVu();
                } catch { MessageBox.Show("Lỗi xóa dịch vụ", "Thông báo"); }

            }
            else { MessageBox.Show("Lỗi xóa dịch vụ", "Thông báo"); }
        }

        private void btn_suakhachhang_Click(object sender, EventArgs e)
        {
            //Click nút sửa dữ liệu
            if (ckb_suakhachhang.Checked == false) { 
                ckb_suakhachhang.Checked = true;
                txt_hovaten.ReadOnly = false;
                txt_ngaysinh.Enabled = true;
                radioNam.Enabled = true;
                radioNu.Enabled = true;
                txt_sdt.ReadOnly = false;
                txt_email.ReadOnly = false;
                txt_cmnd.ReadOnly = false;
                btn_suakhachhang.Text = "Lưu";
            }
            //Click nút Lưu dữ liệu
            else
            {
                if (lvKhachHang.SelectedItems.Count > 0 && txt_idkhachhang.Text != null)
                {
                    GlobalFuncs gf = new GlobalFuncs();
                    if (!gf.KetnoiCSDL()) { return; }
                    try
                    {
                        SqlCommand cmd = new SqlCommand("prodSuaKhachHang", gf.conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDKhachHang", Int32.Parse(txt_idkhachhang.Text));
                        cmd.Parameters.AddWithValue("@HoVaten", txt_hovaten.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(txt_ngaysinh.Text));
                        cmd.Parameters.AddWithValue("@GioiTinh", radioNam.Checked);
                        cmd.Parameters.AddWithValue("@SDT", txt_sdt.Text);
                        cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                        cmd.Parameters.AddWithValue("@CMND", txt_cmnd.Text);

                        cmd.ExecuteNonQuery(); cmd.Dispose();
                        DanhSachKhachHang();
                        resetInputFormKhachHang();
                    }
                    catch { MessageBox.Show("Lỗi cập nhật khách hàng", "Thông báo"); }

                }
                else { MessageBox.Show("Lỗi cập nhật khách hàng", "Thông báo"); }
            }

        }

        private void btn_themkhachhang_Click(object sender, EventArgs e)
        {
            bool validateData = true;
            if (txt_hovaten.Text.Trim().Length<=0) { validateData = false; wlbl_hoten.Visible = true; }
            if (txt_ngaysinh.Text.Trim().Length <= 0) { validateData = false; wlbl_ngaysinh.Visible = true; }
            if (!radioNam.Checked && !radioNu.Checked) { validateData = false; wlbl_gioitinh.Visible = true; }
            if (txt_sdt.Text.Trim().Length <= 0) { validateData = false; wlbl_sodienthoai.Visible = true; }
            if (txt_email.Text.Trim().Length <= 0) { validateData = false; wlbl_email.Visible = true; }
            if (txt_cmnd.Text.Trim().Length <= 0) { validateData = false; wlbl_cmnd.Visible = true; }
            if (!validateData) return;


            GlobalFuncs gf = new GlobalFuncs();
            if (!gf.KetnoiCSDL()) { return; }
            try
            {
                SqlCommand cmd = new SqlCommand("prodThemKhachHang", gf.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HoVaten", txt_hovaten.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", txt_ngaysinh.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", radioNam.Checked);
                cmd.Parameters.AddWithValue("@SDT", txt_sdt.Text);
                cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                cmd.Parameters.AddWithValue("@CMND", txt_cmnd.Text);

                cmd.ExecuteNonQuery(); cmd.Dispose();
                DanhSachKhachHang();
                resetInputFormKhachHang();
            }
            catch { MessageBox.Show("Lỗi thêm khách hàng", "Thông báo"); }


        }

        private void btn_xoakhachhang_Click(object sender, EventArgs e)
        {
            if (lvKhachHang.SelectedItems.Count > 0 && txt_idkhachhang.Text != null)
            {
                GlobalFuncs gf = new GlobalFuncs();
                if (!gf.KetnoiCSDL()) { return; }
                try
                {
                    SqlCommand cmd = new SqlCommand("prodXoaKhachHang", gf.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDKhachHang", Int32.Parse(txt_idkhachhang.Text));
                    cmd.ExecuteNonQuery(); cmd.Dispose();
                    DanhSachKhachHang();
                    resetInputFormKhachHang();
                }
                catch { MessageBox.Show("Lỗi xóa khách hàng", "Thông báo"); }

            }
            else { MessageBox.Show("Lỗi xóa khách hàng", "Thông báo"); }
        }

        private void btn_khachdat_Click(object sender, EventArgs e)
        {
            //frmChonKhachHang frmChonKhachHang = new frmChonKhachHang();
            //frmChonKhachHang.ShowDialog();
        }
    }
}
