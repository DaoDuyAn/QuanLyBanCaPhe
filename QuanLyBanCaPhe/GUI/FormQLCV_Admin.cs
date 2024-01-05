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
    public partial class FormQLCV_Admin : Form
    {
        BUS_ChucVu busCV = new BUS_ChucVu();
        public FormQLCV_Admin()
        {
            InitializeComponent();
            LoadDSCV();
        }

        void LoadDSCV()
        {
            dgvCV.DataSource = null;
            dgvCV.DataSource = busCV.getAllChucVu();
        }

        public void Reset()
        {
            txtMaCV.Text = "";
            txtTenCV.Text = "";
        }

        private void dgvCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCV.Text = dgvCV.CurrentRow.Cells[0].Value.ToString();
            txtTenCV.Text = dgvCV.CurrentRow.Cells[1].Value.ToString();
        }

        private bool IsMaCVExist(string maCV, DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["MaChucVu"].ToString() == maCV)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (keyword == "")
            {
                MessageBox.Show("Bạn cần nhập thông tin tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = busCV.getChucVuByKeyWord(keyword);

            if (dt.Rows.Count > 0)
            {
                dgvCV.DataSource = null;
                dgvCV.DataSource = dt;

                txtTimKiem.Text = "";
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaCV.Text == "" || txtTenCV.Text == "")
            {
                MessageBox.Show("Thông tin cần được điền đầy đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsMaCVExist(txtMaCV.Text, busCV.getAllChucVu()))
            {
                MessageBox.Show("Mã chức vụ không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool suaCV = busCV.suaChucVu(txtMaCV.Text, txtTenCV.Text);
            if (suaCV)
            {
                MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSCV();
                Reset();
            }
            else
            {
                MessageBox.Show("Sửa không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaCV.Text == "")
            {
                MessageBox.Show("Bạn cần chọn chức vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var res = MessageBox.Show("Bạn có chắc chắn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                bool xoaCV = busCV.xoaChucVu(txtMaCV.Text);

                if (xoaCV)
                {
                    LoadDSCV();
                    Reset();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnNapDS_Click(object sender, EventArgs e)
        {
            LoadDSCV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaCV.Text == "" || txtTenCV.Text == "")
            {
                MessageBox.Show("Thông tin cần được điền đầy đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsMaCVExist(txtMaCV.Text, busCV.getAllChucVu()))
            {
                MessageBox.Show("Trùng mã chức vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool themCV = busCV.themChucVu(txtMaCV.Text, txtTenCV.Text);

            if (themCV)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSCV();
                Reset();
            }
            else
            {
                MessageBox.Show("Thêm không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
