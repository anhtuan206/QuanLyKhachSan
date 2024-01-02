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

        public static frmQuanLyDatPhong instance;
        public TextBox txt_idkhachdatphong_shared;
        public TextBox txt_tenkhachdatphong_shared;
        public TextBox txt_iddondatphong_shared;
        public bool themkhacho=false;

        public frmQuanLyDatPhong()
        {
            InitializeComponent();
            instance = this;
            txt_idkhachdatphong_shared = txt_idkhachdatphong;
            txt_tenkhachdatphong_shared = txt_tenkhachdatphong;
            LayDuLieuComBoboxNhanVien();
        }

        private void frmQuanLyDatPhong_Load(object sender, EventArgs e)
        {
            DanhSachDichVu();
            DanhSachKhachHang();
            DanhSachDonDatPhong();
            lvKhachO.Columns[0].Width = 0;
            lvChiTietDatPhong.Columns[3].Width = 0;
            lvChiTietDatPhong.Columns[4].Width = 0;
            lvSuDungDichVu.Columns[5].Width = 0;

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
                    lvi.SubItems.Add(reader.GetDateTime(2).ToString("dd/MM/yyyy"));
                    bool GioiTinh = reader.GetBoolean(3);lvi.SubItems.Add(GioiTinh?"Nam":"Nữ");
                    lvi.SubItems.Add(reader.GetString(5).ToString());
                    lvi.SubItems.Add(reader.GetString(4).ToString());
                    lvi.SubItems.Add(reader.GetString(6).ToString());


                    lvKhachHang.Items.Add(lvi);
                }
                reader.Close();
                lvKhachHang.Columns[0].Width = 0;
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
                txt_ngaysinh.Value = DateTime.ParseExact(lvKhachHang.SelectedItems[0].SubItems[2].Text,"dd/MM/yyyy",null);
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

        private void DanhSachChiTietDatPhong()
        {
            lvChiTietDatPhong.Items.Clear();

            GlobalFuncs gf = new GlobalFuncs();
            if (gf.KetnoiCSDL() == false) { return; }
            try
            {
                string queryString = $@"SELECT dbo.ChiTietDatPhong.NgayNhanPhong, dbo.ChiTietDatPhong.NgayTraPhong, dbo.Phong.SoPhong, dbo.ChiTietDatPhong.IDChiTietDatPhong, dbo.ChiTietDatPhong.IDPhong
                        FROM dbo.ChiTietDatPhong INNER JOIN dbo.Phong ON dbo.ChiTietDatPhong.IDPhong = dbo.Phong.IDPhong
                        WHERE dbo.ChiTietDatPhong.IDDonDatPhong = {Int32.Parse(txt_iddondatphong.Text)}";
                SqlCommand cmd = new SqlCommand(queryString, gf.conn);
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem(reader.GetDateTime(0).ToString("dd/MM/yyyy"));
                    lvi.SubItems.Add(reader.GetDateTime(1).ToString("dd/MM/yyyy"));
                    lvi.SubItems.Add(reader.GetString(2).ToString());
                    lvi.SubItems.Add(reader.GetInt32(3).ToString());
                    lvi.SubItems.Add(reader.GetInt32(4).ToString());
                    lvChiTietDatPhong.Items.Add(lvi);
                }
                reader.Close();
                //lvChiTietDatPhong.Columns[3].Width = 0;
                //lvChiTietDatPhong.Columns[4].Width = 0;
            }
            catch { MessageBox.Show("Lỗi lấy danh sách chi tiết đặt phòng", "Thông báo"); }
        }

        private void lvDonDatPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDonDatPhong.SelectedItems.Count > 0) {
                btn_themdondatphong.Enabled = false;
                btn_suadondatphong.Enabled = true;
                btn_xoadondatphong.Enabled = true;
                txt_iddondatphong.Text = lvDonDatPhong.SelectedItems[0].SubItems[0].Text;
                txt_ngaydat.Value = DateTime.ParseExact(lvDonDatPhong.SelectedItems[0].SubItems[1].Text,"dd/MM/yyyy",null);txt_ngaydat.Enabled = false;
                txt_tenkhachdatphong.Text = lvDonDatPhong.Items[0].SubItems[2].Text;btn_chonkhachdat.Enabled= false;
                txt_ghichu.Text = lvDonDatPhong.SelectedItems[0].SubItems[7].Text; txt_ghichu.Enabled=false;
                txt_idkhachdatphong.Text = lvDonDatPhong.Items[0].SubItems[8].Text;
                
                txt_iddondatphong_shared = txt_iddondatphong;

                cbb_nhanviendatphong.SelectedValue = Int32.Parse(lvDonDatPhong.SelectedItems[0].SubItems[9].Text);cbb_nhanviendatphong.Enabled=false;

                btn_themchitietdatphong.Enabled = true;
                DanhSachChiTietDatPhong();
                btn_xoachitietdatphong.Enabled = false;

            } else { resetInputFormDonDatPhong(); }
        }

        private void resetInputFormDonDatPhong()
        {
            btn_themdondatphong.Enabled = true;
            btn_suadondatphong.Enabled=false;
            btn_xoadondatphong.Enabled = false;
            
            txt_iddondatphong.Text=null;
            txt_ngaydat.Text=null; txt_ngaydat.Enabled = true;
            txt_ghichu.Text=null; txt_ghichu.Enabled = true;
            txt_idkhachdatphong.Text=null;
            txt_tenkhachdatphong.Text = null;
            ckb_suadondatphong.Checked = false;
            cbb_nhanviendatphong.SelectedIndex = -1;cbb_nhanviendatphong.Enabled = true;
            

            ckb_suadondatphong.Checked=false;
            
            btn_chonkhachdat.Enabled=true;

            btn_themchitietdatphong.Enabled = false;


            wlbl_ngaydat.Visible=false;
            wlbl_khachdatphong.Visible=false;

            lvChiTietDatPhong.Items.Clear();

            btn_xoachitietdatphong.Enabled = false;
            lvKhachO.Items.Clear();
            btn_themkhacho.Enabled = false;

            lvSuDungDichVu.Items.Clear();
            cbb_themsudungdichvu.Enabled= false;
            txt_soluongsudungdichvu.Enabled = false;
            btn_themsudungdichvu.Enabled=false;
            btn_xoasudungdichvu.Enabled = false;
        }

        private void DanhSachDonDatPhong()
        {
            GlobalFuncs gf = new GlobalFuncs();
            if (gf.KetnoiCSDL() == false) { return; }
            try
            {
                lvDonDatPhong.Items.Clear();
                SqlCommand cmd = new SqlCommand("select * from viewDonDatPhong", gf.conn);
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem(reader.GetInt32(0).ToString());
                    lvi.SubItems.Add(reader.GetDateTime(1).ToString("dd/MM/yyyy"));
                    lvi.SubItems.Add(reader.GetString(2));
                    lvi.SubItems.Add(reader.GetString(3));
                    lvi.SubItems.Add(reader.GetString(4));
                    lvi.SubItems.Add(reader.GetString(5));
                    lvi.SubItems.Add(reader.GetString(6));
                    lvi.SubItems.Add(reader.GetString(7));
                    lvi.SubItems.Add(reader.GetInt32(8).ToString());
                    lvi.SubItems.Add(reader.GetInt32(9).ToString());

                    lvDonDatPhong.Items.Add(lvi);
                }
                reader.Close();
                lvDonDatPhong.Columns[0].Width = 0;
                lvDonDatPhong.Columns[8].Width = 0;
                lvDonDatPhong.Columns[9].Width = 0;

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
                lvDichVu.Columns[0].Width = 0;
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
            if (lvDichVu.SelectedItems.Count <=0) { return; }
            if (!ckb_suadichvu.Checked) { 
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
                if (!gf.KetnoiCSDL()) { return; }

                try
                {
                    SqlCommand cmd = new SqlCommand("prodSuaDichVu", gf.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDDichVu", Int32.Parse(txt_iddichvu.Text));
                    cmd.Parameters.AddWithValue("@TenDichVu", txt_tendichvu.Text);
                    cmd.Parameters.AddWithValue("@DonViTinh", txt_donvitinh.Text);
                    cmd.Parameters.AddWithValue("@Dongia", decimal.Parse(txt_dongia.Text));
                    cmd.ExecuteNonQuery(); cmd.Dispose();
                } catch { MessageBox.Show("Lỗi lưu dịch vụ", "Thông báo"); }

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
                        cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(txt_ngaysinh.Value.ToString("yyyy-MM-dd")));
                        cmd.Parameters.AddWithValue("@GioiTinh", radioNam.Checked);
                        cmd.Parameters.AddWithValue("@SDT", txt_sdt.Text);
                        cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                        cmd.Parameters.AddWithValue("@CMND", txt_cmnd.Text);

                        cmd.ExecuteNonQuery(); cmd.Dispose();
                    }
                    catch { MessageBox.Show("Lỗi cập nhật khách hàng", "Thông báo"); }
                    DanhSachKhachHang();
                    resetInputFormKhachHang();
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
                cmd.Parameters.AddWithValue("@NgaySinh", txt_ngaysinh.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@GioiTinh", radioNam.Checked);
                cmd.Parameters.AddWithValue("@SDT", txt_sdt.Text);
                cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                cmd.Parameters.AddWithValue("@CMND", txt_cmnd.Text);

                cmd.ExecuteNonQuery(); cmd.Dispose();
            }
            catch { MessageBox.Show("Lỗi thêm khách hàng", "Thông báo"); }
            DanhSachKhachHang();
            resetInputFormKhachHang();
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
            frmChonKhachHang frmChonKhachHang = new frmChonKhachHang();
            frmChonKhachHang.ShowDialog();
        }

        private void btn_themdondatphong_Click(object sender, EventArgs e)
        {
            bool validateData = true;
            if (txt_ngaydat.Value == null) { wlbl_ngaydat.Visible = true; validateData = false; }
            if (txt_idkhachdatphong.Text.Length<=0 || txt_tenkhachdatphong.Text.Length<=0) { wlbl_khachdatphong.Visible = true; validateData=false ;}
            if (cbb_nhanviendatphong.SelectedIndex<0) { validateData=false ;}

            if (txt_ngaydat.Value < DateTime.Now.AddDays(-1)) {  validateData=false ; wlbl_ngaydat.Text = "Ngày đặt phòng không hợp lệ";  wlbl_ngaydat.Visible = true; }

            if (!validateData) { return; }
            try
            {
                GlobalFuncs gf = new GlobalFuncs();
                if (!gf.KetnoiCSDL()) { return ; }

                SqlCommand cmd = new SqlCommand("prodThemDonDatPhong", gf.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NgayDat", txt_ngaydat.Value);
                cmd.Parameters.AddWithValue("@IDKhachHang", Int32.Parse(txt_idkhachdatphong.Text));
                cmd.Parameters.AddWithValue("@IDNhanVien", cbb_nhanviendatphong.SelectedValue);
                cmd.Parameters.AddWithValue("@GhiChu", txt_ghichu.Text);

                cmd.ExecuteNonQuery(); cmd.Dispose();
                DanhSachDonDatPhong();
                resetInputFormDonDatPhong();
            } catch
            {
                MessageBox.Show("Có lỗi khi thêm đơn đặt phòng", "Thông báo");
            }
        }

        //Lấy dữ liệu cho commbobox nhân viên tạo đơn đặt phòng
        private void LayDuLieuComBoboxNhanVien()
        {
            try
            {
                GlobalFuncs gf = new GlobalFuncs();
                gf.HienthiDulieutrenComboBox("NhanVien", "IDNhanVien", "HoVaTen", cbb_nhanviendatphong);
                cbb_nhanviendatphong.SelectedIndex = -1;
            } catch {
                MessageBox.Show("Có lỗi khi lấy dữ liệu cho combobox nhân viên tạo đơn đặt phòng", "Thông báo");
            }
        }

        private void btn_suadondatphong_Click(object sender, EventArgs e)
        {
            if (!ckb_suadondatphong.Checked)
            {
                ckb_suadondatphong.Checked = true;
                txt_ngaydat.Enabled = true;
                btn_chonkhachdat.Enabled = true;
                txt_ghichu.Enabled = true;
                cbb_nhanviendatphong.Enabled = true;
                btn_suadondatphong.Text = "Lưu đơn";
            }
            else
            {
                ckb_suadondatphong.Checked = true;
                btn_suadondatphong.Text = "Sửa đơn";
                txt_ngaydat.Enabled = false;
                btn_chonkhachdat.Enabled = false;
                txt_ghichu.Enabled = false;
                cbb_nhanviendatphong.Enabled = false;
                try
                {
                    GlobalFuncs gf = new GlobalFuncs();
                    if (!gf.KetnoiCSDL()) { return; }
                    SqlCommand cmd = new SqlCommand("prodSuaDonDatPhong", gf.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDDonDatPhong", Int32.Parse(txt_iddondatphong.Text));
                    cmd.Parameters.AddWithValue("@NgayDat", DateTime.Parse(txt_ngaydat.Value.ToString("yyyy-MM-dd")));
                    cmd.Parameters.AddWithValue("@IDKhachHang", Int32.Parse(txt_idkhachdatphong.Text));
                    cmd.Parameters.AddWithValue("@IDNhanVien", cbb_nhanviendatphong.SelectedValue);
                    cmd.Parameters.AddWithValue("@GhiChu", txt_ghichu.Text);

                    cmd.ExecuteNonQuery(); cmd.Dispose();
                    lvDonDatPhong.Items.Clear();
                    DanhSachDonDatPhong();
                    resetInputFormDonDatPhong();
                } catch {
                    MessageBox.Show("Có lỗi khi lưu đơn đặt phòng", "Thông báo");
                }
            }

        }

        private void btn_xoadondatphong_Click(object sender, EventArgs e)
        {
            if (lvDonDatPhong.SelectedItems.Count > 0 && txt_iddondatphong.Text != null)
            {
                try
                {
                    GlobalFuncs gf = new GlobalFuncs();
                    if (!gf.KetnoiCSDL()) { return; }
                    SqlCommand cmd = new SqlCommand("prodXoaDonDatPhong", gf.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDDonDatPhong", Int32.Parse(txt_iddondatphong.Text));
                    cmd.ExecuteNonQuery(); cmd.Dispose();
                    

                } catch { MessageBox.Show("Có lỗi khi xóa đơn đặt phòng", "Thông báo"); }
                lvDonDatPhong.Items.Clear();
                DanhSachDonDatPhong();
                resetInputFormDonDatPhong();
            }
        }

        private void btn_themchitietdatphong_Click(object sender, EventArgs e)
        {
            ckb_capnhatchitietdatphong.Checked = false;
            frmThemChiTietDatPhong frmThemChiTietDatPhong = new frmThemChiTietDatPhong();
            frmThemChiTietDatPhong.ShowDialog();
        }

        private void ckb_capnhatchitietdatphong_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_capnhatchitietdatphong.Checked)
            {
                DanhSachChiTietDatPhong();
            }
            
        }

        private void btn_xoachitietdatphong_Click(object sender, EventArgs e)
        {  
            if (lvChiTietDatPhong.SelectedItems.Count>0)
            {
                GlobalFuncs gf = new GlobalFuncs();
                if (!gf.KetnoiCSDL()) { return; }
                try
                {
                    SqlCommand sqlCmd = new SqlCommand("prodXoaChiTietDatPhong", gf.conn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@IDChiTietDatPhong", Int32.Parse(lvChiTietDatPhong.SelectedItems[0].SubItems[3].Text));
                    sqlCmd.ExecuteNonQuery();sqlCmd.Dispose();
                }
                catch { MessageBox.Show("Lỗi xóa nội dung đặt phòng", "Thông báo"); }

                DanhSachChiTietDatPhong();
                btn_xoachitietdatphong.Enabled = false;
            } 
        }

        private void DanhSachKhachO()
        {
            if (lvChiTietDatPhong.SelectedItems.Count > 0 && txt_idchitietdatphong.Text.Length>0)
            {
                lvKhachO.Items.Clear();

                GlobalFuncs gf = new GlobalFuncs();
                if (!gf.KetnoiCSDL()) { return; }
                try
                {
                    string queryString = $@"SELECT KO.IDKhachO,KH.HoVaTen, KH.SDT, KH.CMND
                            FROM KhachO AS KO
                            INNER JOIN ChiTietDatPhong CTDP ON CTDP.IDChiTietDatPhong=KO.IDChiTietDatPhong
                            INNER JOIN KhachHang KH ON KH.IDKhachHang=KO.IDKhachHang
                            WHERE KO.IDChiTietDatPhong={Int32.Parse(txt_idchitietdatphong.Text)}";

                    SqlCommand sqlCmd = new SqlCommand(queryString, gf.conn);
                    sqlCmd.CommandType = CommandType.Text;
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem lvi = new ListViewItem(reader.GetInt32(0).ToString());
                        lvi.SubItems.Add(reader.GetString(1));
                        lvi.SubItems.Add(reader.GetString(2));
                        lvi.SubItems.Add(reader.GetString(3));

                        lvKhachO.Items.Add(lvi);
                    }
                    reader.Close();
                    lvKhachO.Columns[0].Width = 0;

                }
                catch { MessageBox.Show("Lỗi lấy danh sách khách ở phòng", "Thông báo"); }
            }
        }

        private void DanhSachSuDungDichVu()
        {
            if (lvChiTietDatPhong.SelectedItems.Count > 0 && txt_idchitietdatphong.Text.Length > 0)
            {
                lvSuDungDichVu.Items.Clear();

                GlobalFuncs gf = new GlobalFuncs();
                if (!gf.KetnoiCSDL()) { return; }
                try
                {
                    string queryString = $@"SELECT SDDV.NgaySuDung,DV.TenDichVu,SDDV.SoLuong,DV.DonGia,DV.DonGia*SDDV.SoLuong ThanhTien,IDSuDungDichVu
                                FROM SuDungDichVu SDDV
                                INNER JOIN DichVu DV on dv.IDDichVu=SDDV.IDDichVu
                                WHERE SDDV.IDChiTietDatPhong={Int32.Parse(txt_idchitietdatphong.Text)}";

                    SqlCommand sqlCmd = new SqlCommand(queryString, gf.conn);
                    sqlCmd.CommandType = CommandType.Text;
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem lvi = new ListViewItem(reader.GetDateTime(0).ToString("dd/MM/yyyy"));
                        lvi.SubItems.Add(reader.GetString(1));
                        lvi.SubItems.Add(reader.GetInt32(2).ToString());
                        lvi.SubItems.Add(reader.GetDecimal(3).ToString());
                        lvi.SubItems.Add(reader.GetDecimal(4).ToString());
                        lvi.SubItems.Add(reader.GetInt32(5).ToString());

                        lvSuDungDichVu.Items.Add(lvi);
                    }
                    reader.Close();
                    lvSuDungDichVu.Columns[5].Width = 0;

                }
                catch { MessageBox.Show("Lỗi lấy danh sách sử dụng dịch vụ", "Thông báo"); }
            }
        }

        private void CBB_DanhSachDichVu()
        {
            GlobalFuncs gf = new GlobalFuncs();
            if (!gf.KetnoiCSDL()) { return; }
            gf.HienthiDulieutrenComboBox("DichVu", "IDDichVu", "TenDichVu", cbb_themsudungdichvu);
        }

        private void lvChiTietDatPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvChiTietDatPhong.SelectedItems.Count > 0)
            {
                txt_idchitietdatphong.Text = lvChiTietDatPhong.SelectedItems[0].SubItems[3].Text;
                btn_xoachitietdatphong.Enabled = true;
                DanhSachKhachO();
                btn_themkhacho.Enabled = true;

                DanhSachSuDungDichVu();

                cbb_themsudungdichvu.Enabled = true;

                CBB_DanhSachDichVu();
                cbb_themsudungdichvu.SelectedIndex = -1;
                btn_themsudungdichvu.Enabled = false;
                btn_xoasudungdichvu.Enabled = false;
                txt_soluongsudungdichvu.Enabled = false;
            }
            else
            {
                txt_idchitietdatphong.Text = null;
                btn_xoachitietdatphong.Enabled = false;
                
                lvKhachO.Items.Clear();
                btn_xoakhacho.Enabled = false;
                btn_themkhacho.Enabled = false;

                lvSuDungDichVu.Items.Clear();
                cbb_themsudungdichvu.Enabled = false;
                btn_themsudungdichvu.Enabled = false;
                btn_xoasudungdichvu.Enabled=false;
                txt_soluongsudungdichvu.Enabled = false;
            }

        }

        private void lvKhachO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKhachO.SelectedItems.Count > 0)
            {
                btn_xoakhacho.Enabled = true;
            }
            else
            {
                btn_xoakhacho.Enabled=false;
            }
        }

        private void btn_themkhacho_Click(object sender, EventArgs e)
        {
            if (lvChiTietDatPhong.SelectedItems.Count > 0 && txt_idchitietdatphong.Text.Length > 0) {
                ckb_themkhacho.Checked = true;
                frmChonKhachHang frmChonKhachHang = new frmChonKhachHang();
                frmChonKhachHang.ShowDialog();
            }
        }

        private void ckb_themkhacho_CheckedChanged(object sender, EventArgs e)
        {
            btn_xoachitietdatphong.Enabled = false;
            DanhSachKhachO();
        }

        private void btn_xoakhacho_Click(object sender, EventArgs e)
        {
            if (lvKhachO.SelectedItems.Count>0)
            {
                GlobalFuncs gf = new GlobalFuncs();
                if (!gf.KetnoiCSDL()) return;
                try
                {
                    SqlCommand cmd = new SqlCommand("prodXoaKhachO",gf.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDKhachO", Int32.Parse(lvKhachO.SelectedItems[0].SubItems[0].Text));
                    cmd.ExecuteNonQuery();cmd.Dispose();
                } catch { MessageBox.Show("Lỗi xóa khách ở phòng", "Thông báo"); }

                DanhSachKhachO();
                btn_xoakhacho.Enabled=false;
            }
        }

        private void lvSuDungDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSuDungDichVu.SelectedItems.Count>0)
            {
                btn_xoasudungdichvu.Enabled = true;
            }
            else
            {
                btn_xoasudungdichvu.Enabled = false;
            }
        }

        private void btn_xoasudungdichvu_Click(object sender, EventArgs e)
        {
            if (lvSuDungDichVu.SelectedItems.Count > 0)
            {
                GlobalFuncs gf = new GlobalFuncs();
                if (!gf.KetnoiCSDL()) return;
                try
                {
                    SqlCommand cmd = new SqlCommand("prodXoaSuDungDichVu", gf.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDSuDungDichVu", Int32.Parse(lvSuDungDichVu.SelectedItems[0].SubItems[5].Text));
                    cmd.ExecuteNonQuery(); cmd.Dispose();
                } catch { MessageBox.Show("Lỗi xóa sử dụng dịch vụ", "Thông báo"); }

                DanhSachSuDungDichVu();
                btn_xoasudungdichvu.Enabled = false;
            }
        }

        private void btn_themsudungdichvu_Click(object sender, EventArgs e)
        {
            if (cbb_themsudungdichvu.SelectedIndex >=0)
            {
                if (txt_soluongsudungdichvu.Text.Length <= 0 || Int32.Parse(txt_soluongsudungdichvu.Text)<0) { MessageBox.Show("Vui lòng nhập số lượng", "Thông báo"); return; }

                if (txt_ngaysudung.Value.Date < DateTime.ParseExact(lvChiTietDatPhong.SelectedItems[0].SubItems[0].Text,"dd/MM/yyyy",null).Date
                    || txt_ngaysudung.Value.Date > DateTime.ParseExact(lvChiTietDatPhong.SelectedItems[0].SubItems[1].Text, "dd/MM/yyyy", null).Date)
                { MessageBox.Show($@"Ngày sử dụng dịch vụ không hợp lệ", "Thông báo"); return; }

                GlobalFuncs gf = new GlobalFuncs();
                if (!gf.KetnoiCSDL()) return;

                try
                {
                    SqlCommand cmd = new SqlCommand("prodThemSuDungDichVu", gf.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDDichVu", cbb_themsudungdichvu.SelectedValue);
                    cmd.Parameters.AddWithValue("@SoLuong", Int32.Parse(txt_soluongsudungdichvu.Text));
                    cmd.Parameters.AddWithValue("@NgaySuDung", txt_ngaysudung.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@IDChiTietDatPhong", Int32.Parse(txt_idchitietdatphong.Text));
                    cmd.ExecuteNonQuery(); cmd.Dispose();
                } catch { MessageBox.Show("Lỗi thêm sử dụng dịch vụ", "Thông báo"); }

                DanhSachSuDungDichVu();
                txt_soluongsudungdichvu.Text = null;
                txt_soluongsudungdichvu.Enabled = false;
                cbb_themsudungdichvu.SelectedIndex = -1;
                btn_xoasudungdichvu.Enabled = false;
            }
        }

        private void cbb_themsudungdichvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_themsudungdichvu.SelectedIndex > -1)
            {
                txt_soluongsudungdichvu.Enabled = true;
                btn_themsudungdichvu.Enabled = true;
                txt_ngaysudung.Enabled=true;
            }
            else
            {
                txt_soluongsudungdichvu.Enabled = false;
                btn_themsudungdichvu.Enabled = false;
                txt_ngaysudung.Enabled = false;
            }
        }
    }
}
