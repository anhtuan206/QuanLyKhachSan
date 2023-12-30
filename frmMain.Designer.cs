namespace QuanLyKhachSan
{
    partial class frmMain
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
            this.panMainFormControl = new System.Windows.Forms.Panel();
            this.btnFrmQuanLyPhong = new System.Windows.Forms.Button();
            this.btnFrmNhanVien = new System.Windows.Forms.Button();
            this.btnFormBoPhan = new System.Windows.Forms.Button();
            this.panMainFormBody = new System.Windows.Forms.Panel();
            this.btnFrmQuanLyDatPhong = new System.Windows.Forms.Button();
            this.panMainFormControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMainFormControl
            // 
            this.panMainFormControl.Controls.Add(this.btnFrmQuanLyDatPhong);
            this.panMainFormControl.Controls.Add(this.btnFrmQuanLyPhong);
            this.panMainFormControl.Controls.Add(this.btnFrmNhanVien);
            this.panMainFormControl.Controls.Add(this.btnFormBoPhan);
            this.panMainFormControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMainFormControl.Location = new System.Drawing.Point(0, 0);
            this.panMainFormControl.Name = "panMainFormControl";
            this.panMainFormControl.Size = new System.Drawing.Size(127, 623);
            this.panMainFormControl.TabIndex = 0;
            // 
            // btnFrmQuanLyPhong
            // 
            this.btnFrmQuanLyPhong.Location = new System.Drawing.Point(12, 83);
            this.btnFrmQuanLyPhong.Name = "btnFrmQuanLyPhong";
            this.btnFrmQuanLyPhong.Size = new System.Drawing.Size(105, 29);
            this.btnFrmQuanLyPhong.TabIndex = 0;
            this.btnFrmQuanLyPhong.Text = "Quản lý phòng";
            this.btnFrmQuanLyPhong.UseVisualStyleBackColor = true;
            this.btnFrmQuanLyPhong.Click += new System.EventHandler(this.btnFrmQuanLyPhong_Click);
            // 
            // btnFrmNhanVien
            // 
            this.btnFrmNhanVien.Location = new System.Drawing.Point(12, 118);
            this.btnFrmNhanVien.Name = "btnFrmNhanVien";
            this.btnFrmNhanVien.Size = new System.Drawing.Size(105, 29);
            this.btnFrmNhanVien.TabIndex = 0;
            this.btnFrmNhanVien.Text = "Nhân Viên";
            this.btnFrmNhanVien.UseVisualStyleBackColor = true;
            this.btnFrmNhanVien.Click += new System.EventHandler(this.btnFrmNhanVien_Click);
            // 
            // btnFormBoPhan
            // 
            this.btnFormBoPhan.Location = new System.Drawing.Point(12, 153);
            this.btnFormBoPhan.Name = "btnFormBoPhan";
            this.btnFormBoPhan.Size = new System.Drawing.Size(105, 29);
            this.btnFormBoPhan.TabIndex = 0;
            this.btnFormBoPhan.Text = "Bộ Phận";
            this.btnFormBoPhan.UseVisualStyleBackColor = true;
            this.btnFormBoPhan.Click += new System.EventHandler(this.btnFrmBoPhan_Click);
            // 
            // panMainFormBody
            // 
            this.panMainFormBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMainFormBody.Location = new System.Drawing.Point(127, 0);
            this.panMainFormBody.Name = "panMainFormBody";
            this.panMainFormBody.Size = new System.Drawing.Size(1057, 623);
            this.panMainFormBody.TabIndex = 1;
            // 
            // btnFrmQuanLyDatPhong
            // 
            this.btnFrmQuanLyDatPhong.Location = new System.Drawing.Point(12, 13);
            this.btnFrmQuanLyDatPhong.Name = "btnFrmQuanLyDatPhong";
            this.btnFrmQuanLyDatPhong.Size = new System.Drawing.Size(105, 64);
            this.btnFrmQuanLyDatPhong.TabIndex = 1;
            this.btnFrmQuanLyDatPhong.Text = "Quản lý đặt phòng";
            this.btnFrmQuanLyDatPhong.UseVisualStyleBackColor = true;
            this.btnFrmQuanLyDatPhong.Click += new System.EventHandler(this.btnFrmQuanLyDatPhong_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 623);
            this.Controls.Add(this.panMainFormBody);
            this.Controls.Add(this.panMainFormControl);
            this.Name = "frmMain";
            this.Text = "Quản lý khách sạn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panMainFormControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMainFormControl;
        private System.Windows.Forms.Button btnFormBoPhan;
        private System.Windows.Forms.Button btnFrmNhanVien;
        private System.Windows.Forms.Panel panMainFormBody;
        private System.Windows.Forms.Button btnFrmQuanLyPhong;
        private System.Windows.Forms.Button btnFrmQuanLyDatPhong;
    }
}