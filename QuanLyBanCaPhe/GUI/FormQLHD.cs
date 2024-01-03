using QuanLyBanCaPhe.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanCaPhe.GUI
{
    public partial class FormQLHD : Form
    {
        BUS_HoaDon busHoaDon = new BUS_HoaDon();
        public FormQLHD()
        {
            InitializeComponent();
            LoadHoaDon();
        }

        void LoadHoaDon()
        {
            dgvHD.DataSource = busHoaDon.getAllHoaDon();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool them = busHoaDon.themHoaDon(DateTime.Now, "NV1");
            if (them)
            {
                dgvHD.DataSource = null;
                dgvHD.DataSource = busHoaDon.getAllHoaDon();
            }
            else
            {
                // Xử lý khi thêm không thành công nếu cần
                MessageBox.Show("Thêm hóa đơn không thành công!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool them = busHoaDon.suaHoaDon(15, DateTime.Now, "NV2");
            if (them)
            {
                dgvHD.DataSource = null;
                dgvHD.DataSource = busHoaDon.getAllHoaDon();
            }
            else
            {
                // Xử lý khi thêm không thành công nếu cần
                MessageBox.Show("Thêm hóa đơn không thành công!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool them = busHoaDon.xoaHoaDon(15);
            if (them)
            {
                dgvHD.DataSource = null;
                dgvHD.DataSource = busHoaDon.getAllHoaDon();
            }
            else
            {
                // Xử lý khi thêm không thành công nếu cần
                MessageBox.Show("Thêm hóa đơn không thành công!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvHD.DataSource = null;
            dgvHD.DataSource = busHoaDon.getHoaDonByMaNhanVien("NV1");
        }
    }
}
