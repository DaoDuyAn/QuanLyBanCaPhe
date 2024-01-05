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
            LoadDSLSP();
        }

        void LoadDSLSP()
        {
            dgvLSP.DataSource = null;
            dgvLSP.DataSource = busLSP.getAllLoaiSP();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
        }

        private void btnNapDS_Click(object sender, EventArgs e)
        {
            LoadDSLSP();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {

        }
    }
}
