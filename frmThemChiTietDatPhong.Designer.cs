namespace QuanLyKhachSan
{
    partial class frmThemChiTietDatPhong
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
            this.lvPhong = new System.Windows.Forms.ListView();
            this.vsophong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vtrangthaiphong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vtang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vdienthoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vtenloaiphong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vsucchua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vdongia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vidphong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vidtrangthai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vidloaiphong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_idphong = new System.Windows.Forms.TextBox();
            this.txt_iddondatphong = new System.Windows.Forms.TextBox();
            this.txt_tungay = new System.Windows.Forms.DateTimePicker();
            this.btn_chonphong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_denngay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách phòng trống";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 451);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lvPhong);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(913, 384);
            this.panel4.TabIndex = 6;
            // 
            // lvPhong
            // 
            this.lvPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vsophong,
            this.vtrangthaiphong,
            this.vtang,
            this.vdienthoai,
            this.vtenloaiphong,
            this.vsucchua,
            this.vdongia,
            this.vidphong,
            this.vidtrangthai,
            this.vidloaiphong});
            this.lvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPhong.FullRowSelect = true;
            this.lvPhong.GridLines = true;
            this.lvPhong.HideSelection = false;
            this.lvPhong.Location = new System.Drawing.Point(0, 0);
            this.lvPhong.Name = "lvPhong";
            this.lvPhong.Size = new System.Drawing.Size(913, 384);
            this.lvPhong.TabIndex = 4;
            this.lvPhong.UseCompatibleStateImageBehavior = false;
            this.lvPhong.View = System.Windows.Forms.View.Details;
            this.lvPhong.SelectedIndexChanged += new System.EventHandler(this.lvPhong_SelectedIndexChanged);
            // 
            // vsophong
            // 
            this.vsophong.Text = "Số phòng";
            // 
            // vtrangthaiphong
            // 
            this.vtrangthaiphong.Text = "Trạng Thái Phòng";
            this.vtrangthaiphong.Width = 120;
            // 
            // vtang
            // 
            this.vtang.Text = "Tầng";
            this.vtang.Width = 40;
            // 
            // vdienthoai
            // 
            this.vdienthoai.Text = "Điện thoại";
            // 
            // vtenloaiphong
            // 
            this.vtenloaiphong.Text = "Loại Phòng";
            this.vtenloaiphong.Width = 120;
            // 
            // vsucchua
            // 
            this.vsucchua.Text = "Sức Chứa";
            this.vsucchua.Width = 120;
            // 
            // vdongia
            // 
            this.vdongia.Text = "Đơn giá";
            this.vdongia.Width = 120;
            // 
            // vidphong
            // 
            this.vidphong.Text = "ID Phòng";
            // 
            // vidtrangthai
            // 
            this.vidtrangthai.Text = "ID Trạng Thái";
            // 
            // vidloaiphong
            // 
            this.vidloaiphong.Text = "ID Loại Phòng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_idphong);
            this.panel3.Controls.Add(this.txt_iddondatphong);
            this.panel3.Controls.Add(this.txt_tungay);
            this.panel3.Controls.Add(this.btn_chonphong);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_denngay);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(913, 67);
            this.panel3.TabIndex = 5;
            // 
            // txt_idphong
            // 
            this.txt_idphong.Location = new System.Drawing.Point(700, 32);
            this.txt_idphong.Name = "txt_idphong";
            this.txt_idphong.Size = new System.Drawing.Size(100, 20);
            this.txt_idphong.TabIndex = 6;
            // 
            // txt_iddondatphong
            // 
            this.txt_iddondatphong.Location = new System.Drawing.Point(604, 33);
            this.txt_iddondatphong.Name = "txt_iddondatphong";
            this.txt_iddondatphong.Size = new System.Drawing.Size(56, 20);
            this.txt_iddondatphong.TabIndex = 5;
            // 
            // txt_tungay
            // 
            this.txt_tungay.Location = new System.Drawing.Point(12, 33);
            this.txt_tungay.Name = "txt_tungay";
            this.txt_tungay.Size = new System.Drawing.Size(200, 20);
            this.txt_tungay.TabIndex = 2;
            this.txt_tungay.ValueChanged += new System.EventHandler(this.txt_tungay_ValueChanged);
            // 
            // btn_chonphong
            // 
            this.btn_chonphong.Enabled = false;
            this.btn_chonphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chonphong.Location = new System.Drawing.Point(469, 10);
            this.btn_chonphong.Name = "btn_chonphong";
            this.btn_chonphong.Size = new System.Drawing.Size(92, 43);
            this.btn_chonphong.TabIndex = 4;
            this.btn_chonphong.Text = "Chọn phòng";
            this.btn_chonphong.UseVisualStyleBackColor = true;
            this.btn_chonphong.Click += new System.EventHandler(this.btn_chonphong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ ngày";
            // 
            // txt_denngay
            // 
            this.txt_denngay.Location = new System.Drawing.Point(249, 33);
            this.txt_denngay.Name = "txt_denngay";
            this.txt_denngay.Size = new System.Drawing.Size(200, 20);
            this.txt_denngay.TabIndex = 3;
            this.txt_denngay.ValueChanged += new System.EventHandler(this.txt_denngay_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đến ngày";
            // 
            // frmThemChiTietDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 495);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmThemChiTietDatPhong";
            this.Text = "Thêm nội dung đặt phòng";
            this.Load += new System.EventHandler(this.frmThemChiTietDatPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker txt_tungay;
        private System.Windows.Forms.Button btn_chonphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txt_denngay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lvPhong;
        private System.Windows.Forms.ColumnHeader vsophong;
        private System.Windows.Forms.ColumnHeader vtrangthaiphong;
        private System.Windows.Forms.ColumnHeader vtang;
        private System.Windows.Forms.ColumnHeader vdienthoai;
        private System.Windows.Forms.ColumnHeader vtenloaiphong;
        private System.Windows.Forms.ColumnHeader vsucchua;
        private System.Windows.Forms.ColumnHeader vdongia;
        private System.Windows.Forms.ColumnHeader vidphong;
        private System.Windows.Forms.ColumnHeader vidtrangthai;
        private System.Windows.Forms.ColumnHeader vidloaiphong;
        private System.Windows.Forms.TextBox txt_iddondatphong;
        private System.Windows.Forms.TextBox txt_idphong;
    }
}