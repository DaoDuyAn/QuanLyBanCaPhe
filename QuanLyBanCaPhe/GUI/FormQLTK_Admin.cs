using QuanLyBanCaPhe.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanCaPhe.GUI
{
    public partial class FormQLTK_Admin : Form
    {
        BUS_TaiKhoan busTK = new BUS_TaiKhoan();
        BUS_NhanVien busNV = new BUS_NhanVien();
        public FormQLTK_Admin()
        {
            InitializeComponent();
            LoadDSTK();
        }

        void LoadDSTK()
        {
            dgvTK.DataSource = null;
            dgvTK.DataSource = busTK.getAllTaiKhoan();
        }

        public void Reset()
        {
            txtMaTK.Text = "";
            txtTenDN.Text = "";
            txtMK.Text = "";
            txtMaNV.Text = "";
        }

        private bool IsMaTKExist(string maTK, DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["MaTaiKhoan"].ToString() == maTK)
                {
                    return true;
                }
            }
            return false;
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


        private void btnNapDS_Click(object sender, EventArgs e)
        {
            LoadDSTK();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaTK.Text == "" || txtTenDN.Text == "" || txtMK.Text == "" || txtMaNV.Text == "")
            {
                MessageBox.Show("Thông tin cần được điền đầy đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsMaTKExist(txtMaTK.Text, busTK.getAllTaiKhoan()))
            {
                MessageBox.Show("Mã tài khoản không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!IsMaNVExist(txtMaNV.Text, busNV.getAllNhanVien()))
            {
                MessageBox.Show("Mã nhân viên không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool suaTK = busTK.suaTaiKhoan(txtMaTK.Text, txtTenDN.Text, txtMK.Text, txtMaNV.Text);
            if (suaTK)
            {
                MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSTK();
                Reset();
            }
            else
            {
                MessageBox.Show("Sửa không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTK.Text == "")
            {
                MessageBox.Show("Bạn cần chọn tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var res = MessageBox.Show("Bạn có chắc chắn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                bool xoaTK = busTK.xoaTaiKhoan(txtMaTK.Text);

                if (xoaTK)
                {
                    LoadDSTK();
                    Reset();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaTK.Text == "" || txtTenDN.Text == "" || txtMK.Text == "" || txtMaNV.Text == "")
            {
                MessageBox.Show("Thông tin cần được điền đầy đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsMaTKExist(txtMaTK.Text, busTK.getAllTaiKhoan()))
            {
                MessageBox.Show("Trùng mã tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!IsMaNVExist(txtMaNV.Text, busNV.getAllNhanVien()))
            {
                MessageBox.Show("Mã nhân viên không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            bool themTK = busTK.themTaiKhoan(txtMaTK.Text, txtTenDN.Text, txtMK.Text, txtMaNV.Text);

            if (themTK)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSTK();
                Reset();
            }
            else
            {
                MessageBox.Show("Thêm không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTK.Text = dgvTK.CurrentRow.Cells[0].Value.ToString();
            txtTenDN.Text = dgvTK.CurrentRow.Cells[1].Value.ToString();
            txtMK.Text = dgvTK.CurrentRow.Cells[2].Value.ToString();
            txtMaNV.Text = dgvTK.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgvTK_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvTK.Columns[e.ColumnIndex].Name == "dgvMK" && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
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

            DataTable dt = busTK.getTaiKhoanByKeyWord(keyword);

            if (dt.Rows.Count > 0)
            {
                dgvTK.DataSource = null;
                dgvTK.DataSource = dt;

                txtTimKiem.Text = "";
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
