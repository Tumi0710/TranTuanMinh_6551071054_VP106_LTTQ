using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLySanPham.Models;

namespace QuanLySanPham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnThoat.Enabled = true;

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (var db = new DuLieuContext())
                {
                    var list = db.SanPhams
                        .Select(sp => new
                        {
                            MaSanPham = sp.MaSanPham,
                            TenSanPham = sp.TenSanPham,
                            GiaBan = sp.GiaBan
                        })
                        .ToList();

                    dgvSanPham.DataSource = list;
                    dgvSanPham.Columns[0].HeaderText = "Mã Sản Phẩm";
                    dgvSanPham.Columns[1].HeaderText = "Tên Sản Phẩm";
                    dgvSanPham.Columns[2].HeaderText = "Giá Bán (VND)";
                    dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XoaRongTextBox()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGiaBan.Clear();
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') && !txtGiaBan.Text.Contains(".") && !txtGiaBan.Text.Contains(","))
            {
                return;
            }

            e.Handled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) ||
                string.IsNullOrWhiteSpace(txtTenSP.Text) ||
                string.IsNullOrWhiteSpace(txtGiaBan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào các ô TextBox!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSP = txtMaSP.Text.Trim();
            string tenSP = txtTenSP.Text.Trim();
            string giaBan = txtGiaBan.Text.Trim();

            try
            {
                using (var db = new DuLieuContext())
                {
                    bool exists = db.SanPhams.Any(sp => sp.MaSanPham == maSP);
                    if (exists)
                    {
                        MessageBox.Show("Mã sản phẩm đã tồn tại, vui lòng nhập lại!", "Thông báo trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaSP.Focus();
                        return;
                    }

                    var spMoi = new SanPham
                    {
                        MaSanPham = maSP,
                        TenSanPham = tenSP,
                        GiaBan = giaBan
                    };

                    db.SanPhams.Add(spMoi);
                    db.SaveChanges();
                }

                LoadData();
                XoaRongTextBox();
                btnThem.Enabled = false;

                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSanPham.Rows.Count)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                if (row.Cells[0].Value != null)
                {
                    txtMaSP.Text = row.Cells[0].Value.ToString();
                    txtTenSP.Text = row.Cells[1].Value.ToString();
                    txtGiaBan.Text = row.Cells[2].Value.ToString();

                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var db = new DuLieuContext())
                    {
                        var sp = db.SanPhams.Find(txtMaSP.Text.Trim());
                        if (sp != null)
                        {
                            db.SanPhams.Remove(sp);
                            db.SaveChanges();
                        }
                    }
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            XoaRongTextBox();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new DuLieuContext())
                {
                    var sp = db.SanPhams.Find(txtMaSP.Text.Trim());
                    if (sp != null)
                    {
                        sp.TenSanPham = txtTenSP.Text.Trim();
                        sp.GiaBan = txtGiaBan.Text.Trim();
                        db.SaveChanges();
                    }
                }

                LoadData();
                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            XoaRongTextBox();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }
    }
}