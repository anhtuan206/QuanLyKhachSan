namespace QuanLyKhachSan
{
    partial class frmBoPhan
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
            this.components = new System.ComponentModel.Container();
            this.lvBoPhan = new System.Windows.Forms.ListView();
            this.lvBoPhan_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBoPhan_Ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.boPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.wlbl_bophan = new System.Windows.Forms.Label();
            this.panListBoPhan = new System.Windows.Forms.Panel();
            this.panControlBoPhan = new System.Windows.Forms.Panel();
            this.lblBoPhanFormTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boPhanBindingSource)).BeginInit();
            this.panListBoPhan.SuspendLayout();
            this.panControlBoPhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvBoPhan
            // 
            this.lvBoPhan.AllowColumnReorder = true;
            this.lvBoPhan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvBoPhan_ID,
            this.lvBoPhan_Ten});
            this.lvBoPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBoPhan.FullRowSelect = true;
            this.lvBoPhan.GridLines = true;
            this.lvBoPhan.HideSelection = false;
            this.lvBoPhan.Location = new System.Drawing.Point(0, 106);
            this.lvBoPhan.Name = "lvBoPhan";
            this.lvBoPhan.Size = new System.Drawing.Size(687, 224);
            this.lvBoPhan.TabIndex = 1;
            this.lvBoPhan.UseCompatibleStateImageBehavior = false;
            this.lvBoPhan.View = System.Windows.Forms.View.Details;
            this.lvBoPhan.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lvBoPhan_ID
            // 
            this.lvBoPhan_ID.Text = "ID";
            // 
            // lvBoPhan_Ten
            // 
            this.lvBoPhan_Ten.Text = "Tên bộ phận";
            this.lvBoPhan_Ten.Width = 200;
            // 
            // tuanpa2_QuanLyKhachSanDataSet
            // 
            // 
            // boPhanBindingSource
            // 
            this.boPhanBindingSource.DataMember = "BoPhan";
            // 
            // boPhanTableAdapter
            // 
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(440, 50);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(521, 50);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(602, 50);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // wlbl_bophan
            // 
            this.wlbl_bophan.AutoSize = true;
            this.wlbl_bophan.ForeColor = System.Drawing.Color.Red;
            this.wlbl_bophan.Location = new System.Drawing.Point(16, 79);
            this.wlbl_bophan.Name = "wlbl_bophan";
            this.wlbl_bophan.Size = new System.Drawing.Size(35, 13);
            this.wlbl_bophan.TabIndex = 4;
            this.wlbl_bophan.Text = "label1";
            this.wlbl_bophan.Visible = false;
            // 
            // panListBoPhan
            // 
            this.panListBoPhan.Controls.Add(this.lvBoPhan);
            this.panListBoPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panListBoPhan.Location = new System.Drawing.Point(0, 0);
            this.panListBoPhan.Name = "panListBoPhan";
            this.panListBoPhan.Padding = new System.Windows.Forms.Padding(0, 106, 0, 0);
            this.panListBoPhan.Size = new System.Drawing.Size(687, 330);
            this.panListBoPhan.TabIndex = 5;
            // 
            // panControlBoPhan
            // 
            this.panControlBoPhan.Controls.Add(this.lblBoPhanFormTitle);
            this.panControlBoPhan.Controls.Add(this.btnThem);
            this.panControlBoPhan.Controls.Add(this.btnSua);
            this.panControlBoPhan.Controls.Add(this.wlbl_bophan);
            this.panControlBoPhan.Controls.Add(this.btnXoa);
            this.panControlBoPhan.Controls.Add(this.textBox1);
            this.panControlBoPhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panControlBoPhan.Location = new System.Drawing.Point(0, 0);
            this.panControlBoPhan.Name = "panControlBoPhan";
            this.panControlBoPhan.Size = new System.Drawing.Size(687, 105);
            this.panControlBoPhan.TabIndex = 6;
            // 
            // lblBoPhanFormTitle
            // 
            this.lblBoPhanFormTitle.AutoSize = true;
            this.lblBoPhanFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoPhanFormTitle.Location = new System.Drawing.Point(14, 13);
            this.lblBoPhanFormTitle.Name = "lblBoPhanFormTitle";
            this.lblBoPhanFormTitle.Size = new System.Drawing.Size(187, 29);
            this.lblBoPhanFormTitle.TabIndex = 5;
            this.lblBoPhanFormTitle.Text = "Quản lý bộ phận";
            // 
            // frmBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 330);
            this.Controls.Add(this.panControlBoPhan);
            this.Controls.Add(this.panListBoPhan);
            this.Name = "frmBoPhan";
            this.Text = "Quản Lý Bộ Phận";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boPhanBindingSource)).EndInit();
            this.panListBoPhan.ResumeLayout(false);
            this.panControlBoPhan.ResumeLayout(false);
            this.panControlBoPhan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvBoPhan;
        private System.Windows.Forms.ColumnHeader lvBoPhan_ID;
        private System.Windows.Forms.ColumnHeader lvBoPhan_Ten;
        private System.Windows.Forms.BindingSource boPhanBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label wlbl_bophan;
        private System.Windows.Forms.Panel panListBoPhan;
        private System.Windows.Forms.Panel panControlBoPhan;
        private System.Windows.Forms.Label lblBoPhanFormTitle;
    }
}