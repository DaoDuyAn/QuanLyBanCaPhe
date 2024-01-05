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
    public partial class FormQLLSP_Admin : Form
    {
        BUS_LoaiSanPham busLSP = new BUS_LoaiSanPham();
        public FormQLLSP_Admin()
        {
            InitializeComponent();
            LoadLSP();
        }

        void LoadLSP()
        {
            dgvLSP.DataSource = null;
            dgvLSP.DataSource = busLSP.getAllLoaiSP();
        }

        public void Reset()
        {
            txtMaLSP.Text = "";
            txtTenLSP.Text = "";
        }

        private void dgvLSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLSP.Text = dgvLSP.CurrentRow.Cells[0].Value.ToString();
            txtTenLSP.Text = dgvLSP.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenLSP.Text == "")
            {
                MessageBox.Show("Thông tin cần được điền đầy đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool themLSP = busLSP.themLoaiSP(txtTenLSP.Text);

            if (themLSP)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLSP();
                Reset();
            }
            else
            {
                MessageBox.Show("Thêm không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLSP.Text == "" || txtTenLSP.Text == "")
            {
                MessageBox.Show("Thông tin cần được điền đầy đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool suaSP = busLSP.suaLoaiSP(int.Parse(txtMaLSP.Text), txtTenLSP.Text);
            if (suaSP)
            {
                MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLSP();
                Reset();
            }
            else
            {
                MessageBox.Show("Sửa không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLSP.Text == "")
            {
                MessageBox.Show("Bạn cần chọn loại sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var res = MessageBox.Show("Bạn có chắc chắn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                bool xoaSP = busLSP.xoaLoaiSP(int.Parse(txtMaLSP.Text));

                if (xoaSP)
                {
                    LoadLSP();
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
            LoadLSP();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (keyword == "")
            {
                MessageBox.Show("Bạn cần nhập thông tin tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = busLSP.getLoaiSanPhamByKeyWord(keyword);

            if (dt.Rows.Count > 0)
            {
                dgvLSP.DataSource = null;
                dgvLSP.DataSource = dt;

                txtTimKiem.Text = "";
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
