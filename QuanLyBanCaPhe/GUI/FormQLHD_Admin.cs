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

                lblTongTien.Text = tongTien.ToString() + " đ";
            }
        }
    }
}
