namespace QuanLyKhachSan
{
    partial class frmChonKhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lvKhachHang = new System.Windows.Forms.ListView();
            this.idkhachhang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hovaten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaysinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gioitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sodienthoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_chonkhachhang = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_idkhachhang = new System.Windows.Forms.TextBox();
            this.ckb_suakhachhang = new System.Windows.Forms.CheckBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.txt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_hovaten = new System.Windows.Forms.TextBox();
            this.wlbl_cmnd = new System.Windows.Forms.Label();
            this.wlbl_email = new System.Windows.Forms.Label();
            this.wlbl_sodienthoai = new System.Windows.Forms.Label();
            this.wlbl_gioitinh = new System.Windows.Forms.Label();
            this.wlbl_ngaysinh = new System.Windows.Forms.Label();
            this.wlbl_hoten = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_xoakhachhang = new System.Windows.Forms.Button();
            this.btn_suakhachhang = new System.Windows.Forms.Button();
            this.btn_themkhachhang = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn khách hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1086, 545);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1086, 509);
            this.panel4.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lvKhachHang);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(767, 509);
            this.panel6.TabIndex = 1;
            // 
            // lvKhachHang
            // 
            this.lvKhachHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idkhachhang,
            this.hovaten,
            this.ngaysinh,
            this.gioitinh,
            this.sodienthoai,
            this.email,
            this.cmnd});
            this.lvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvKhachHang.FullRowSelect = true;
            this.lvKhachHang.GridLines = true;
            this.lvKhachHang.HideSelection = false;
            this.lvKhachHang.Location = new System.Drawing.Point(0, 0);
            this.lvKhachHang.MultiSelect = false;
            this.lvKhachHang.Name = "lvKhachHang";
            this.lvKhachHang.Size = new System.Drawing.Size(767, 435);
            this.lvKhachHang.TabIndex = 2;
            this.lvKhachHang.TabStop = false;
            this.lvKhachHang.UseCompatibleStateImageBehavior = false;
            this.lvKhachHang.View = System.Windows.Forms.View.Details;
            this.lvKhachHang.SelectedIndexChanged += new System.EventHandler(this.lvKhachHang_SelectedIndexChanged);
            // 
            // idkhachhang
            // 
            this.idkhachhang.Text = "ID Khách Hàng";
            // 
            // hovaten
            // 
            this.hovaten.Text = "Họ và tên";
            this.hovaten.Width = 120;
            // 
            // ngaysinh
            // 
            this.ngaysinh.Text = "Ngày sinh";
            this.ngaysinh.Width = 90;
            // 
            // gioitinh
            // 
            this.gioitinh.Text = "Giới tính";
            // 
            // sodienthoai
            // 
            this.sodienthoai.Text = "Số điện thoại";
            this.sodienthoai.Width = 120;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 120;
            // 
            // cmnd
            // 
            this.cmnd.Text = "Số CCCD";
            this.cmnd.Width = 90;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_chonkhachhang);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 435);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(767, 74);
            this.panel7.TabIndex = 0;
            // 
            // btn_chonkhachhang
            // 
            this.btn_chonkhachhang.Enabled = false;
            this.btn_chonkhachhang.Location = new System.Drawing.Point(12, 6);
            this.btn_chonkhachhang.Name = "btn_chonkhachhang";
            this.btn_chonkhachhang.Size = new System.Drawing.Size(135, 59);
            this.btn_chonkhachhang.TabIndex = 0;
            this.btn_chonkhachhang.Text = "Chọn";
            this.btn_chonkhachhang.UseVisualStyleBackColor = true;
            this.btn_chonkhachhang.Click += new System.EventHandler(this.btn_chonkhachhang_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_idkhachhang);
            this.panel5.Controls.Add(this.ckb_suakhachhang);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.txt_ngaysinh);
            this.panel5.Controls.Add(this.txt_cmnd);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.txt_email);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txt_sdt);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txt_hovaten);
            this.panel5.Controls.Add(this.wlbl_cmnd);
            this.panel5.Controls.Add(this.wlbl_email);
            this.panel5.Controls.Add(this.wlbl_sodienthoai);
            this.panel5.Controls.Add(this.wlbl_gioitinh);
            this.panel5.Controls.Add(this.wlbl_ngaysinh);
            this.panel5.Controls.Add(this.wlbl_hoten);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.btn_xoakhachhang);
            this.panel5.Controls.Add(this.btn_suakhachhang);
            this.panel5.Controls.Add(this.btn_themkhachhang);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(767, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(319, 509);
            this.panel5.TabIndex = 0;
            // 
            // txt_idkhachhang
            // 
            this.txt_idkhachhang.Location = new System.Drawing.Point(158, 445);
            this.txt_idkhachhang.Name = "txt_idkhachhang";
            this.txt_idkhachhang.Size = new System.Drawing.Size(100, 20);
            this.txt_idkhachhang.TabIndex = 29;
            this.txt_idkhachhang.TabStop = false;
            this.txt_idkhachhang.Visible = false;
            // 
            // ckb_suakhachhang
            // 
            this.ckb_suakhachhang.AutoSize = true;
            this.ckb_suakhachhang.Location = new System.Drawing.Point(127, 448);
            this.ckb_suakhachhang.Name = "ckb_suakhachhang";
            this.ckb_suakhachhang.Size = new System.Drawing.Size(15, 14);
            this.ckb_suakhachhang.TabIndex = 28;
            this.ckb_suakhachhang.TabStop = false;
            this.ckb_suakhachhang.UseVisualStyleBackColor = true;
            this.ckb_suakhachhang.Visible = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.radioNu);
            this.panel10.Controls.Add(this.radioNam);
            this.panel10.Location = new System.Drawing.Point(6, 169);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(306, 29);
            this.panel10.TabIndex = 27;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Location = new System.Drawing.Point(143, 4);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(39, 17);
            this.radioNu.TabIndex = 4;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Location = new System.Drawing.Point(25, 4);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(47, 17);
            this.radioNam.TabIndex = 3;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // txt_ngaysinh
            // 
            this.txt_ngaysinh.Location = new System.Drawing.Point(6, 97);
            this.txt_ngaysinh.Name = "txt_ngaysinh";
            this.txt_ngaysinh.Size = new System.Drawing.Size(306, 20);
            this.txt_ngaysinh.TabIndex = 2;
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Location = new System.Drawing.Point(6, 360);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(306, 20);
            this.txt_cmnd.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Số căn cước công dân";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(6, 298);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(306, 20);
            this.txt_email.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Email";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(6, 236);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(306, 20);
            this.txt_sdt.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ngày sinh";
            // 
            // txt_hovaten
            // 
            this.txt_hovaten.Location = new System.Drawing.Point(6, 26);
            this.txt_hovaten.Name = "txt_hovaten";
            this.txt_hovaten.Size = new System.Drawing.Size(306, 20);
            this.txt_hovaten.TabIndex = 1;
            // 
            // wlbl_cmnd
            // 
            this.wlbl_cmnd.AutoSize = true;
            this.wlbl_cmnd.ForeColor = System.Drawing.Color.Red;
            this.wlbl_cmnd.Location = new System.Drawing.Point(5, 383);
            this.wlbl_cmnd.Name = "wlbl_cmnd";
            this.wlbl_cmnd.Size = new System.Drawing.Size(118, 13);
            this.wlbl_cmnd.TabIndex = 16;
            this.wlbl_cmnd.Text = "Vui lòng nhập số CCCD";
            this.wlbl_cmnd.Visible = false;
            // 
            // wlbl_email
            // 
            this.wlbl_email.AutoSize = true;
            this.wlbl_email.ForeColor = System.Drawing.Color.Red;
            this.wlbl_email.Location = new System.Drawing.Point(6, 321);
            this.wlbl_email.Name = "wlbl_email";
            this.wlbl_email.Size = new System.Drawing.Size(99, 13);
            this.wlbl_email.TabIndex = 15;
            this.wlbl_email.Text = "Vui lòng nhập email";
            this.wlbl_email.Visible = false;
            // 
            // wlbl_sodienthoai
            // 
            this.wlbl_sodienthoai.AutoSize = true;
            this.wlbl_sodienthoai.ForeColor = System.Drawing.Color.Red;
            this.wlbl_sodienthoai.Location = new System.Drawing.Point(6, 259);
            this.wlbl_sodienthoai.Name = "wlbl_sodienthoai";
            this.wlbl_sodienthoai.Size = new System.Drawing.Size(136, 13);
            this.wlbl_sodienthoai.TabIndex = 14;
            this.wlbl_sodienthoai.Text = "Vui lòng nhập số điện thoại";
            this.wlbl_sodienthoai.Visible = false;
            // 
            // wlbl_gioitinh
            // 
            this.wlbl_gioitinh.AutoSize = true;
            this.wlbl_gioitinh.ForeColor = System.Drawing.Color.Red;
            this.wlbl_gioitinh.Location = new System.Drawing.Point(6, 201);
            this.wlbl_gioitinh.Name = "wlbl_gioitinh";
            this.wlbl_gioitinh.Size = new System.Drawing.Size(113, 13);
            this.wlbl_gioitinh.TabIndex = 13;
            this.wlbl_gioitinh.Text = "Vui lòng chọn giới tính";
            this.wlbl_gioitinh.Visible = false;
            // 
            // wlbl_ngaysinh
            // 
            this.wlbl_ngaysinh.AutoSize = true;
            this.wlbl_ngaysinh.ForeColor = System.Drawing.Color.Red;
            this.wlbl_ngaysinh.Location = new System.Drawing.Point(5, 120);
            this.wlbl_ngaysinh.Name = "wlbl_ngaysinh";
            this.wlbl_ngaysinh.Size = new System.Drawing.Size(120, 13);
            this.wlbl_ngaysinh.TabIndex = 12;
            this.wlbl_ngaysinh.Text = "Vui lòng chọn ngày sinh";
            this.wlbl_ngaysinh.Visible = false;
            // 
            // wlbl_hoten
            // 
            this.wlbl_hoten.AutoSize = true;
            this.wlbl_hoten.ForeColor = System.Drawing.Color.Red;
            this.wlbl_hoten.Location = new System.Drawing.Point(5, 49);
            this.wlbl_hoten.Name = "wlbl_hoten";
            this.wlbl_hoten.Size = new System.Drawing.Size(150, 13);
            this.wlbl_hoten.TabIndex = 11;
            this.wlbl_hoten.Text = "Vui lòng nhập tên khách hàng";
            this.wlbl_hoten.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên khách hàng";
            // 
            // btn_xoakhachhang
            // 
            this.btn_xoakhachhang.Location = new System.Drawing.Point(237, 407);
            this.btn_xoakhachhang.Name = "btn_xoakhachhang";
            this.btn_xoakhachhang.Size = new System.Drawing.Size(75, 23);
            this.btn_xoakhachhang.TabIndex = 10;
            this.btn_xoakhachhang.Text = "Xóa";
            this.btn_xoakhachhang.UseVisualStyleBackColor = true;
            this.btn_xoakhachhang.Visible = false;
            // 
            // btn_suakhachhang
            // 
            this.btn_suakhachhang.Location = new System.Drawing.Point(118, 407);
            this.btn_suakhachhang.Name = "btn_suakhachhang";
            this.btn_suakhachhang.Size = new System.Drawing.Size(75, 23);
            this.btn_suakhachhang.TabIndex = 9;
            this.btn_suakhachhang.Text = "Sửa";
            this.btn_suakhachhang.UseVisualStyleBackColor = true;
            this.btn_suakhachhang.Visible = false;
            // 
            // btn_themkhachhang
            // 
            this.btn_themkhachhang.Location = new System.Drawing.Point(2, 407);
            this.btn_themkhachhang.Name = "btn_themkhachhang";
            this.btn_themkhachhang.Size = new System.Drawing.Size(75, 23);
            this.btn_themkhachhang.TabIndex = 8;
            this.btn_themkhachhang.Text = "Thêm";
            this.btn_themkhachhang.UseVisualStyleBackColor = true;
            this.btn_themkhachhang.Click += new System.EventHandler(this.btn_themkhachhang_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1086, 36);
            this.panel3.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            // 
            // frmChonKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 590);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmChonKhachHang";
            this.Text = "Chọn khách hàng";
            this.Load += new System.EventHandler(this.frmChonKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_idkhachhang;
        private System.Windows.Forms.CheckBox ckb_suakhachhang;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.DateTimePicker txt_ngaysinh;
        private System.Windows.Forms.TextBox txt_cmnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_hovaten;
        private System.Windows.Forms.Label wlbl_cmnd;
        private System.Windows.Forms.Label wlbl_email;
        private System.Windows.Forms.Label wlbl_sodienthoai;
        private System.Windows.Forms.Label wlbl_gioitinh;
        private System.Windows.Forms.Label wlbl_ngaysinh;
        private System.Windows.Forms.Label wlbl_hoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_xoakhachhang;
        private System.Windows.Forms.Button btn_suakhachhang;
        private System.Windows.Forms.Button btn_themkhachhang;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ListView lvKhachHang;
        private System.Windows.Forms.ColumnHeader idkhachhang;
        private System.Windows.Forms.ColumnHeader hovaten;
        private System.Windows.Forms.ColumnHeader ngaysinh;
        private System.Windows.Forms.ColumnHeader gioitinh;
        private System.Windows.Forms.ColumnHeader sodienthoai;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader cmnd;
        private System.Windows.Forms.Button btn_chonkhachhang;
    }
}