using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; 
            childForm.Dock = DockStyle.Fill;
            panMainFormBody.Controls.Add(childForm);
            panMainFormBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFrmBoPhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBoPhan());
        }

        private void btnFrmNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
        }

        private void btnFrmQuanLyPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyPhong());
        }

        private void btnFrmQuanLyDatPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyDatPhong());

        }
    }
}
