namespace QuanLyKhachSan
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBoPhanFormTitle = new System.Windows.Forms.Label();
            this.panListNhanVien = new System.Windows.Forms.Panel();
            this.lvNhanVien = new System.Windows.Forms.ListView();
            this.manv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tennv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaysinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gioitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sodienthoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenbophan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idnhanvien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idbophan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_idnhanvien = new System.Windows.Forms.TextBox();
            this.wlbl_gioitinh = new System.Windows.Forms.Label();
            this.ckb_Sua = new System.Windows.Forms.CheckBox();
            this.panGioiTinh = new System.Windows.Forms.Panel();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.wlbl_manv = new System.Windows.Forms.Label();
            this.wlbl_hovaten = new System.Windows.Forms.Label();
            this.wlbl_ngaysinh = new System.Windows.Forms.Label();
            this.wlbl_sodienthoai = new System.Windows.Forms.Label();
            this.wlbl_cmnd = new System.Windows.Forms.Label();
            this.wlbl_bophan = new System.Windows.Forms.Label();
            this.txt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbb_bophan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sodienthoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_hovaten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panListNhanVien.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panGioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBoPhanFormTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 51);
            this.panel1.TabIndex = 0;
            // 
            // lblBoPhanFormTitle
            // 
            this.lblBoPhanFormTitle.AutoSize = true;
            this.lblBoPhanFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoPhanFormTitle.Location = new System.Drawing.Point(3, 9);
            this.lblBoPhanFormTitle.Name = "lblBoPhanFormTitle";
            this.lblBoPhanFormTitle.Size = new System.Drawing.Size(202, 29);
            this.lblBoPhanFormTitle.TabIndex = 6;
            this.lblBoPhanFormTitle.Text = "Quản lý nhân viên";
            // 
            // panListNhanVien
            // 
            this.panListNhanVien.Controls.Add(this.lvNhanVien);
            this.panListNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panListNhanVien.Location = new System.Drawing.Point(0, 51);
            this.panListNhanVien.Name = "panListNhanVien";
            this.panListNhanVien.Size = new System.Drawing.Size(1096, 562);
            this.panListNhanVien.TabIndex = 1;
            // 
            // lvNhanVien
            // 
            this.lvNhanVien.AllowColumnReorder = true;
            this.lvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.manv,
            this.tennv,
            this.ngaysinh,
            this.gioitinh,
            this.sodienthoai,
            this.cmnd,
            this.tenbophan,
            this.idnhanvien,
            this.idbophan});
            this.lvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNhanVien.FullRowSelect = true;
            this.lvNhanVien.GridLines = true;
            this.lvNhanVien.HideSelection = false;
            this.lvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.lvNhanVien.Name = "lvNhanVien";
            this.lvNhanVien.Size = new System.Drawing.Size(1096, 562);
            this.lvNhanVien.TabIndex = 0;
            this.lvNhanVien.TabStop = false;
            this.lvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lvNhanVien.View = System.Windows.Forms.View.Details;
            this.lvNhanVien.SelectedIndexChanged += new System.EventHandler(this.lvNhanVien_SelectedIndexChanged);
            // 
            // manv
            // 
            this.manv.Text = "Mã NV";
            // 
            // tennv
            // 
            this.tennv.Text = "Họ và tên";
            this.tennv.Width = 200;
            // 
            // ngaysinh
            // 
            this.ngaysinh.Text = "Ngày sinh";
            this.ngaysinh.Width = 80;
            // 
            // gioitinh
            // 
            this.gioitinh.Text = "Giới tính";
            // 
            // sodienthoai
            // 
            this.sodienthoai.Text = "Số điện thoại";
            this.sodienthoai.Width = 100;
            // 
            // cmnd
            // 
            this.cmnd.Text = "Số CMND";
            this.cmnd.Width = 100;
            // 
            // tenbophan
            // 
            this.tenbophan.Text = "Tên bộ phận";
            this.tenbophan.Width = 200;
            // 
            // idnhanvien
            // 
            this.idnhanvien.Text = "idnhanvien";
            this.idnhanvien.Width = 0;
            // 
            // idbophan
            // 
            this.idbophan.Text = "idbophan";
            this.idbophan.Width = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_idnhanvien);
            this.panel2.Controls.Add(this.wlbl_gioitinh);
            this.panel2.Controls.Add(this.ckb_Sua);
            this.panel2.Controls.Add(this.panGioiTinh);
            this.panel2.Controls.Add(this.wlbl_manv);
            this.panel2.Controls.Add(this.wlbl_hovaten);
            this.panel2.Controls.Add(this.wlbl_ngaysinh);
            this.panel2.Controls.Add(this.wlbl_sodienthoai);
            this.panel2.Controls.Add(this.wlbl_cmnd);
            this.panel2.Controls.Add(this.wlbl_bophan);
            this.panel2.Controls.Add(this.txt_ngaysinh);
            this.panel2.Controls.Add(this.cbb_bophan);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_cmnd);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_sodienthoai);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_hovaten);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_manv);
            this.panel2.Controls.Add(this.lblMaNhanVien);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(810, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 562);
            this.panel2.TabIndex = 2;
            // 
            // txt_idnhanvien
            // 
            this.txt_idnhanvien.Enabled = false;
            this.txt_idnhanvien.Location = new System.Drawing.Point(217, 484);
            this.txt_idnhanvien.Name = "txt_idnhanvien";
            this.txt_idnhanvien.Size = new System.Drawing.Size(56, 20);
            this.txt_idnhanvien.TabIndex = 21;
            this.txt_idnhanvien.TabStop = false;
            this.txt_idnhanvien.Visible = false;
            // 
            // wlbl_gioitinh
            // 
            this.wlbl_gioitinh.AutoSize = true;
            this.wlbl_gioitinh.ForeColor = System.Drawing.Color.Red;
            this.wlbl_gioitinh.Location = new System.Drawing.Point(9, 236);
            this.wlbl_gioitinh.Name = "wlbl_gioitinh";
            this.wlbl_gioitinh.Size = new System.Drawing.Size(113, 13);
            this.wlbl_gioitinh.TabIndex = 20;
            this.wlbl_gioitinh.Text = "Vui lòng chọn giới tính";
            this.wlbl_gioitinh.Visible = false;
            // 
            // ckb_Sua
            // 
            this.ckb_Sua.AutoSize = true;
            this.ckb_Sua.Enabled = false;
            this.ckb_Sua.Location = new System.Drawing.Point(196, 487);
            this.ckb_Sua.Name = "ckb_Sua";
            this.ckb_Sua.Size = new System.Drawing.Size(15, 14);
            this.ckb_Sua.TabIndex = 19;
            this.ckb_Sua.TabStop = false;
            this.ckb_Sua.UseVisualStyleBackColor = true;
            this.ckb_Sua.Visible = false;
            // 
            // panGioiTinh
            // 
            this.panGioiTinh.Controls.Add(this.radioNam);
            this.panGioiTinh.Controls.Add(this.radioNu);
            this.panGioiTinh.Location = new System.Drawing.Point(38, 205);
            this.panGioiTinh.Name = "panGioiTinh";
            this.panGioiTinh.Size = new System.Drawing.Size(200, 28);
            this.panGioiTinh.TabIndex = 18;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Location = new System.Drawing.Point(12, 3);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(47, 17);
            this.radioNam.TabIndex = 4;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Location = new System.Drawing.Point(98, 3);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(39, 17);
            this.radioNu.TabIndex = 5;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // wlbl_manv
            // 
            this.wlbl_manv.AutoSize = true;
            this.wlbl_manv.ForeColor = System.Drawing.Color.Red;
            this.wlbl_manv.Location = new System.Drawing.Point(9, 49);
            this.wlbl_manv.Name = "wlbl_manv";
            this.wlbl_manv.Size = new System.Drawing.Size(139, 13);
            this.wlbl_manv.TabIndex = 17;
            this.wlbl_manv.Text = "Vui lòng nhập mã nhân viên";
            this.wlbl_manv.Visible = false;
            // 
            // wlbl_hovaten
            // 
            this.wlbl_hovaten.AutoSize = true;
            this.wlbl_hovaten.ForeColor = System.Drawing.Color.Red;
            this.wlbl_hovaten.Location = new System.Drawing.Point(8, 109);
            this.wlbl_hovaten.Name = "wlbl_hovaten";
            this.wlbl_hovaten.Size = new System.Drawing.Size(105, 13);
            this.wlbl_hovaten.TabIndex = 16;
            this.wlbl_hovaten.Text = "Vui lòng nhập họ tên";
            this.wlbl_hovaten.Visible = false;
            // 
            // wlbl_ngaysinh
            // 
            this.wlbl_ngaysinh.AutoSize = true;
            this.wlbl_ngaysinh.ForeColor = System.Drawing.Color.Red;
            this.wlbl_ngaysinh.Location = new System.Drawing.Point(9, 170);
            this.wlbl_ngaysinh.Name = "wlbl_ngaysinh";
            this.wlbl_ngaysinh.Size = new System.Drawing.Size(120, 13);
            this.wlbl_ngaysinh.TabIndex = 15;
            this.wlbl_ngaysinh.Text = "Vui lòng chọn ngày sinh";
            this.wlbl_ngaysinh.Visible = false;
            // 
            // wlbl_sodienthoai
            // 
            this.wlbl_sodienthoai.AutoSize = true;
            this.wlbl_sodienthoai.ForeColor = System.Drawing.Color.Red;
            this.wlbl_sodienthoai.Location = new System.Drawing.Point(8, 297);
            this.wlbl_sodienthoai.Name = "wlbl_sodienthoai";
            this.wlbl_sodienthoai.Size = new System.Drawing.Size(136, 13);
            this.wlbl_sodienthoai.TabIndex = 14;
            this.wlbl_sodienthoai.Text = "Vui lòng nhập số điện thoại";
            this.wlbl_sodienthoai.Visible = false;
            // 
            // wlbl_cmnd
            // 
            this.wlbl_cmnd.AutoSize = true;
            this.wlbl_cmnd.ForeColor = System.Drawing.Color.Red;
            this.wlbl_cmnd.Location = new System.Drawing.Point(7, 357);
            this.wlbl_cmnd.Name = "wlbl_cmnd";
            this.wlbl_cmnd.Size = new System.Drawing.Size(121, 13);
            this.wlbl_cmnd.TabIndex = 13;
            this.wlbl_cmnd.Text = "Vui lòng nhập số CMND";
            this.wlbl_cmnd.Visible = false;
            // 
            // wlbl_bophan
            // 
            this.wlbl_bophan.AutoSize = true;
            this.wlbl_bophan.ForeColor = System.Drawing.Color.Red;
            this.wlbl_bophan.Location = new System.Drawing.Point(7, 421);
            this.wlbl_bophan.Name = "wlbl_bophan";
            this.wlbl_bophan.Size = new System.Drawing.Size(114, 13);
            this.wlbl_bophan.TabIndex = 12;
            this.wlbl_bophan.Text = "Vui lòng chọn bộ phận";
            this.wlbl_bophan.Visible = false;
            // 
            // txt_ngaysinh
            // 
            this.txt_ngaysinh.Location = new System.Drawing.Point(12, 147);
            this.txt_ngaysinh.Name = "txt_ngaysinh";
            this.txt_ngaysinh.Size = new System.Drawing.Size(263, 20);
            this.txt_ngaysinh.TabIndex = 3;
            // 
            // cbb_bophan
            // 
            this.cbb_bophan.FormattingEnabled = true;
            this.cbb_bophan.Location = new System.Drawing.Point(10, 397);
            this.cbb_bophan.Name = "cbb_bophan";
            this.cbb_bophan.Size = new System.Drawing.Size(263, 21);
            this.cbb_bophan.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bộ phận";
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Location = new System.Drawing.Point(10, 334);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(263, 20);
            this.txt_cmnd.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số CMND";
            // 
            // txt_sodienthoai
            // 
            this.txt_sodienthoai.Location = new System.Drawing.Point(11, 274);
            this.txt_sodienthoai.Name = "txt_sodienthoai";
            this.txt_sodienthoai.Size = new System.Drawing.Size(263, 20);
            this.txt_sodienthoai.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày sinh";
            // 
            // txt_hovaten
            // 
            this.txt_hovaten.Location = new System.Drawing.Point(11, 86);
            this.txt_hovaten.Name = "txt_hovaten";
            this.txt_hovaten.Size = new System.Drawing.Size(263, 20);
            this.txt_hovaten.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Họ và tên";
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(12, 26);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(263, 20);
            this.txt_manv.TabIndex = 1;
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Location = new System.Drawing.Point(9, 10);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(72, 13);
            this.lblMaNhanVien.TabIndex = 7;
            this.lblMaNhanVien.Text = "Mã nhân viên";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(38, 447);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(119, 447);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(200, 447);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 613);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panListNhanVien);
            this.Controls.Add(this.panel1);
            this.Name = "frmNhanVien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panListNhanVien.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panGioiTinh.ResumeLayout(false);
            this.panGioiTinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBoPhanFormTitle;
        private System.Windows.Forms.Panel panListNhanVien;
        private System.Windows.Forms.ListView lvNhanVien;
        private System.Windows.Forms.ColumnHeader manv;
        private System.Windows.Forms.ColumnHeader tennv;
        private System.Windows.Forms.ColumnHeader ngaysinh;
        private System.Windows.Forms.ColumnHeader gioitinh;
        private System.Windows.Forms.ColumnHeader sodienthoai;
        private System.Windows.Forms.ColumnHeader cmnd;
        private System.Windows.Forms.ColumnHeader tenbophan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cmnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sodienthoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_hovaten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DateTimePicker txt_ngaysinh;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.ComboBox cbb_bophan;
        private System.Windows.Forms.Label wlbl_manv;
        private System.Windows.Forms.Label wlbl_hovaten;
        private System.Windows.Forms.Label wlbl_ngaysinh;
        private System.Windows.Forms.Label wlbl_sodienthoai;
        private System.Windows.Forms.Label wlbl_cmnd;
        private System.Windows.Forms.Label wlbl_bophan;
        private System.Windows.Forms.Panel panGioiTinh;
        private System.Windows.Forms.ColumnHeader idnhanvien;
        private System.Windows.Forms.ColumnHeader idbophan;
        private System.Windows.Forms.CheckBox ckb_Sua;
        private System.Windows.Forms.Label wlbl_gioitinh;
        private System.Windows.Forms.TextBox txt_idnhanvien;
    }
}