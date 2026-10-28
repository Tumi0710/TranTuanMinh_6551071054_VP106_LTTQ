namespace QuanLySanPham
{
    partial class Form1 : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.GroupBox gbThaoTac;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox gbDanhSach;
        private System.Windows.Forms.DataGridView dgvSanPham;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.gbThaoTac = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gbDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.gbThongTin.SuspendLayout();
            this.gbThaoTac.SuspendLayout();
            this.gbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();

            this.gbThongTin.Controls.Add(this.lblMaSP);
            this.gbThongTin.Controls.Add(this.lblTenSP);
            this.gbThongTin.Controls.Add(this.lblGiaBan);
            this.gbThongTin.Controls.Add(this.txtMaSP);
            this.gbThongTin.Controls.Add(this.txtTenSP);
            this.gbThongTin.Controls.Add(this.txtGiaBan);
            this.gbThongTin.Location = new System.Drawing.Point(12, 12);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(430, 120);
            this.gbThongTin.TabIndex = 0;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin sản phẩm";

            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(16, 25);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(74, 13);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã sản phẩm:";

            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(16, 55);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(78, 13);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "Tên sản phẩm:";

            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Location = new System.Drawing.Point(16, 85);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(75, 13);
            this.lblGiaBan.TabIndex = 2;
            this.lblGiaBan.Text = "Giá bán (VND):";

            this.txtMaSP.Location = new System.Drawing.Point(110, 22);
            this.txtMaSP.MaxLength = 10;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(120, 20);
            this.txtMaSP.TabIndex = 3;

            this.txtTenSP.Location = new System.Drawing.Point(110, 52);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(300, 20);
            this.txtTenSP.TabIndex = 4;

            this.txtGiaBan.Location = new System.Drawing.Point(110, 82);
            this.txtGiaBan.MaxLength = 12;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(120, 20);
            this.txtGiaBan.TabIndex = 5;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);

            this.gbThaoTac.Controls.Add(this.btnThem);
            this.gbThaoTac.Controls.Add(this.btnSua);
            this.gbThaoTac.Controls.Add(this.btnXoa);
            this.gbThaoTac.Controls.Add(this.btnThoat);
            this.gbThaoTac.Location = new System.Drawing.Point(455, 12);
            this.gbThaoTac.Name = "gbThaoTac";
            this.gbThaoTac.Size = new System.Drawing.Size(317, 120);
            this.gbThaoTac.TabIndex = 1;
            this.gbThaoTac.TabStop = false;
            this.gbThaoTac.Text = "Thao tác";

            this.btnThem.Location = new System.Drawing.Point(12, 45);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(68, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Location = new System.Drawing.Point(86, 45);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(68, 30);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Location = new System.Drawing.Point(160, 45);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnThoat.Location = new System.Drawing.Point(234, 45);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(68, 30);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            this.gbDanhSach.Controls.Add(this.dgvSanPham);
            this.gbDanhSach.Location = new System.Drawing.Point(12, 140);
            this.gbDanhSach.Name = "gbDanhSach";
            this.gbDanhSach.Size = new System.Drawing.Size(760, 260);
            this.gbDanhSach.TabIndex = 2;
            this.gbDanhSach.TabStop = false;
            this.gbDanhSach.Text = "Danh sách sản phẩm";

            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(3, 16);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(754, 241);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.gbDanhSach);
            this.Controls.Add(this.gbThaoTac);
            this.Controls.Add(this.gbThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Sản phẩm / Hàng hóa - VP106";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.gbThaoTac.ResumeLayout(false);
            this.gbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
        }
    }
}