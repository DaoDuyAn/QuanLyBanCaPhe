using QuanLyBanCaPhe.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanCaPhe.GUI
{
    public partial class FormQLNV_Admin : Form
    {
        BUS_NhanVien busNV = new BUS_NhanVien();
        BUS_ChucVu busCV = new BUS_ChucVu();
        public FormQLNV_Admin()
        {
            InitializeComponent();
            LoadDSNV();
            LoadMaChucVu();
            LoadGioiTinh();
        }

        void LoadDSNV()
        {
            dgvNV.DataSource = null;
            dgvNV.DataSource = busNV.getAllNhanVien();
        }

        void LoadMaChucVu()
        {
            DataTable dtCV = busCV.getAllChucVu();

            // Tạo một DataColumn mới để chứa dữ liệu hiển thị
            DataColumn displayColumn = new DataColumn("DisplayColumn", typeof(string));

            // Thêm cột mới vào DataTable
            dtCV.Columns.Add(displayColumn);

            // Tạo dữ liệu hiển thị
            foreach (DataRow row in dtCV.Rows)
            {
                row["DisplayColumn"] = $"{row["MaChucVu"]} - {row["TenChucVu"]}";
            }

            cbbMaCV.DataSource = dtCV;
            cbbMaCV.DisplayMember = "DisplayColumn";
            cbbMaCV.ValueMember = "MaChucVu";
        }

        void LoadGioiTinh()
        {
            cbbGT.Items.Add(new { Text = "Nam", Value = 0 });
            cbbGT.Items.Add(new { Text = "Nữ", Value = 1 });

            cbbGT.DisplayMember = "Text";
            cbbGT.ValueMember = "Value";

            cbbGT.SelectedIndex = 0;
        }

        public void Reset()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
        }


        private void btnNapDS_Click(object sender, EventArgs e)
        {
            LoadDSNV();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtTenNV.Text == "")
            {
                MessageBox.Show("Thông tin cần được điền đầy đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsMaNVExist(txtMaNV.Text, busNV.getAllNhanVien()))
            {
                MessageBox.Show("Mã nhân viên không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool suaNV = busNV.suaNhanVien(txtMaNV.Text, txtTenNV.Text, dtpNS.Value.Date, Convert.ToBoolean(cbbGT.SelectedIndex), cbbMaCV.SelectedValue.ToString());
            if (suaNV)
            {
                MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSNV();
                Reset();
            }
            else
            {
                MessageBox.Show("Sửa không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn cần chọn nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var res = MessageBox.Show("Bạn có chắc chắn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                bool xoaSP = busNV.xoaNhanVien(txtMaNV.Text);

                if (xoaSP)
                {
                    LoadDSNV();
                    Reset();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private bool IsMaNVExist(string maNV, DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["MaNhanVien"].ToString() == maNV)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtTenNV.Text == "")
            {
                MessageBox.Show("Thông tin cần được điền đầy đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsMaNVExist(txtMaNV.Text, busNV.getAllNhanVien()))
            {
                MessageBox.Show("Trùng mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            bool themNV = busNV.themNhanVien(txtMaNV.Text, txtTenNV.Text, dtpNS.Value.Date, Convert.ToBoolean(cbbGT.SelectedIndex), cbbMaCV.SelectedValue.ToString());

            if (themNV)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSNV();
                Reset();
            }
            else
            {
                MessageBox.Show("Thêm không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (keyword == "")
            {
                MessageBox.Show("Bạn cần nhập thông tin tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = busNV.getNhanVienByKeyWord(keyword);

            if (dt.Rows.Count > 0)
            {
                dgvNV.DataSource = null;
                dgvNV.DataSource = dt;

                txtTimKiem.Text = "";
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvNV.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = dgvNV.CurrentRow.Cells[1].Value.ToString();
            dtpNS.Text = dgvNV.CurrentRow.Cells[2].Value.ToString();

            bool gioiTinhValue = Convert.ToBoolean(dgvNV.CurrentRow.Cells[3].Value);
            cbbGT.SelectedIndex = gioiTinhValue ? 1 : 0;

            cbbMaCV.SelectedValue = dgvNV.CurrentRow.Cells[4].Value;
        }
    }
}
