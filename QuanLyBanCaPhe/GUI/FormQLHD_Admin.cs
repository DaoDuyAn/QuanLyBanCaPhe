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
    public partial class FormQLHD_Admin : Form
    {
        BUS_HoaDon busHoaDon = new BUS_HoaDon();
        BUS_ChiTietHoaDon busCTHD = new BUS_ChiTietHoaDon();
        public FormQLHD_Admin()
        {
            InitializeComponent();
            LoadDSHD();
        }


        void LoadDSHD()
        {
            dgvHD.DataSource = null;
            dgvHD.DataSource = busHoaDon.getAllHoaDon();
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvHD.Columns[e.ColumnIndex].Name;

            if (columnName == "dgvChiTiet")
            {
                int maHD = Convert.ToInt32(dgvHD.Rows[e.RowIndex].Cells["dgvMaHD"].Value);

                lblMaHD.Text = maHD.ToString();
                dgvCTHD.DataSource = null;
                dgvCTHD.DataSource = busCTHD.getCTHD(maHD);

                long tongTien = 0;

                foreach (DataGridViewRow row in dgvCTHD.Rows)
                {
                    int soLuong = Convert.ToInt32(row.Cells["dgvSL"].Value);
                    long donGia = Convert.ToInt64(row.Cells["dgvGia"].Value);

                    tongTien += soLuong * donGia;
                }

                lblTongTien.Text = tongTien.ToString("N0") + " đ";
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (keyword == "")
            {
                MessageBox.Show("Bạn cần nhập mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = busHoaDon.getHoaDonByMaNhanVien(keyword);

            if (dt.Rows.Count > 0)
            {
                dgvHD.DataSource = null;
                dgvHD.DataSource = dt;

                txtTimKiem.Text = "";
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
