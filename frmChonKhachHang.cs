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
using System.Net.NetworkInformation;

namespace QuanLyKhachSan
{
    
    public partial class frmChonKhachHang : Form
    {
        public static frmChonKhachHang instance;

        public frmChonKhachHang()
        {
            InitializeComponent();
            instance = this;
        }

        private void frmChonKhachHang_Load(object sender, EventArgs e)
        {
            DanhSachKhachHang();

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
                    bool GioiTinh = reader.GetBoolean(3); lvi.SubItems.Add(GioiTinh ? "Nam" : "Nữ");
                    lvi.SubItems.Add(reader.GetString(4).ToString());
                    lvi.SubItems.Add(reader.GetString(5).ToString());
                    lvi.SubItems.Add(reader.GetString(6).ToString());


                    lvKhachHang.Items.Add(lvi);
                }
                reader.Close();
            }
            catch { MessageBox.Show("Lỗi lấy danh sách khách hàng", "Thông báo"); }
        }

        private void btn_themkhachhang_Click(object sender, EventArgs e)
        {
            bool validateData = true;
            if (txt_hovaten.Text.Trim().Length <= 0) { validateData = false; wlbl_hoten.Visible = true; }
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
        private void resetInputFormKhachHang()
        {
            btn_themkhachhang.Enabled = true;
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

            txt_hovaten.ReadOnly = false;
            txt_ngaysinh.Enabled = true;
            radioNam.Enabled = true;
            radioNu.Enabled = true;
            txt_sdt.ReadOnly = false;
            txt_email.ReadOnly = false;
            txt_cmnd.ReadOnly = false;

            wlbl_email.Visible = false;
            wlbl_cmnd.Visible = false;
            wlbl_sodienthoai.Visible = false;
            wlbl_ngaysinh.Visible = false;
            wlbl_gioitinh.Visible = false;
            wlbl_hoten.Visible = false;

        }

        private void lvKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKhachHang.SelectedItems.Count>0)
            {
                txt_idkhachhang.Text = lvKhachHang.SelectedItems[0].SubItems[0].Text;
                btn_chonkhachhang.Enabled = true;
            }
            else
            {
                txt_idkhachhang.Text=null;
                btn_chonkhachhang.Enabled = false;
            }
        }

        private void btn_chonkhachhang_Click(object sender, EventArgs e)
        {
            if (frmQuanLyDatPhong.instance.ckb_themkhacho.Checked) {
                GlobalFuncs gf = new GlobalFuncs();
                if (!gf.KetnoiCSDL()) { return; }
                try
                {
                    SqlCommand sqlCmd = new SqlCommand("prodThemKhachO", gf.conn);
                    sqlCmd.CommandType = CommandType.StoredProcedure; 
                    sqlCmd.Parameters.AddWithValue("@IDChiTietDatPhong",Int32.Parse(frmQuanLyDatPhong.instance.txt_idchitietdatphong.Text));
                    sqlCmd.Parameters.AddWithValue("@IDKhachHang", Int32.Parse(lvKhachHang.SelectedItems[0].SubItems[0].Text));

                    sqlCmd.ExecuteNonQuery();sqlCmd.Dispose();
                    frmQuanLyDatPhong.instance.ckb_themkhacho.Checked = false;
                    this.Close();

                } catch { MessageBox.Show("Có lỗi thêm khách ở phòng", "Thông báo"); }

            }
            else
            {
                frmQuanLyDatPhong.instance.txt_idkhachdatphong_shared.Text = lvKhachHang.SelectedItems[0].SubItems[0].Text;
                frmQuanLyDatPhong.instance.txt_tenkhachdatphong_shared.Text = lvKhachHang.SelectedItems[0].SubItems[1].Text;
                this.Close();
            }
        }
    }
}
