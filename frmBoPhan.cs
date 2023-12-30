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
    public partial class frmBoPhan : Form
    {
        

        public frmBoPhan()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            HienThiDanhSachBoPhan();
        }

        //Khi click chuột để chọn bộ phận
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBoPhan.SelectedItems.Count > 0) { 
                textBox1.Text = lvBoPhan.SelectedItems[0].SubItems[1].Text;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnSua.Text = "Sửa";
                textBox1.ReadOnly = true;
                btnXoa.Enabled = true;

            }
            else { 
                textBox1.ReadOnly = false;
                textBox1.Text = null;
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        //Click nút sửa và nút lưu khi sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            GlobalFuncs gf = new GlobalFuncs();

            //Click nút sửa
            if (textBox1.ReadOnly == true) { 
                //Cho phép sửa dữ liệu
                textBox1.ReadOnly = false;
                btnSua.Text = "Lưu";
            }
            //Click nút Lưu
            else
            {
                if (textBox1.Text.Length > 0)
                {
                    if (lvBoPhan.SelectedItems.Count > 0)
                    {
                        int IDBoPhan = Int32.Parse(lvBoPhan.SelectedItems[0].SubItems[0].Text);
                        gf.SuaBoPhan("prodSuaBoPhan", "@tenBoPhan", textBox1.Text,IDBoPhan);
                        textBox1.ReadOnly = true;
                        btnSua.Text = "Sửa";
                        lvBoPhan.Items.Clear();
                        HienThiDanhSachBoPhan();
                    }
                }
                else {
                    wlbl_bophan.Text = "Vui lòng nhập tên bộ phận";
                }
            }
        }

        //Hiển thị danh sách bộ phận lên list view
        private void HienThiDanhSachBoPhan()
        {
            GlobalFuncs gf = new GlobalFuncs();

            if (gf.KetnoiCSDL() == true)
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select * from BoPhan";
                sqlCmd.Connection = gf.conn;

                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    int IDBoPhan = reader.GetInt32(0);
                    string TenBoPhan = reader.GetString(1);
                    ListViewItem lvi = new ListViewItem(IDBoPhan.ToString());
                    lvi.SubItems.Add(TenBoPhan);
                    lvBoPhan.Items.Add(lvi);
                }
                reader.Close();
            }
        }

        //Click nút thêm dữ liệu
        private void btnThem_Click(object sender, EventArgs e)
        {
            GlobalFuncs gf = new GlobalFuncs();
            if (textBox1.Text.Length <= 0) {
                wlbl_bophan.Visible = true;
                wlbl_bophan.Text = "Vui lòng nhập tên bộ phận";
            }
            else
            {
                gf.ThemDuLieu("prodThemBoPhan","@tenbophan", textBox1.Text);
                textBox1.Text = null;
                textBox1.ReadOnly = false;
                lvBoPhan.Items.Clear();
                HienThiDanhSachBoPhan();
                wlbl_bophan.Visible = false;
            }
        }

        //Click nút xóa dữ liệu
        private void btnXoa_Click(object sender, EventArgs e)
        {
            GlobalFuncs gf = new GlobalFuncs();
            if (lvBoPhan.SelectedItems.Count > 0)
            {
                int IDBoPhan = Int32.Parse(lvBoPhan.SelectedItems[0].SubItems[0].Text);
                gf.XoadulieuByID("prodXoaBoPhan", "IDBoPhan", IDBoPhan);
                textBox1.Text = null;
                textBox1.ReadOnly = false;
                btnThem.Enabled = true;
                lvBoPhan.Items.Clear();
                HienThiDanhSachBoPhan();
            }
        }
    }
}
