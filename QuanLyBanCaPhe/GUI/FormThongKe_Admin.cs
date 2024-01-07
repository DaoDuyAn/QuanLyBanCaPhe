using QuanLyBanCaPhe.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanCaPhe.GUI
{
    public partial class FormThongKe_Admin : Form
    {
        BUS_ThongKe busTK = new BUS_ThongKe();
        public FormThongKe_Admin()
        {
            InitializeComponent();
            LoadCbbNam();
            LoadDSTK(2024);
            TongDT(2024);
        }

        void LoadCbbNam()
        {
            cbbNam.Items.Add("2023");
            cbbNam.Items.Add("2024");

            cbbNam.SelectedIndex = 1;
        }

        void LoadDSTK(int year)
        {
            dgvTK.DataSource = null;
            dgvTK.DataSource = busTK.getThongKeTheoNam(year);
        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedYear = cbbNam.SelectedItem.ToString();

            int year = int.Parse(selectedYear);

            LoadDSTK(year);
            TongDT(year);
        }

        private void TongDT(int year)
        {
            long tongDT = 0;

            DataTable dt = busTK.getThongKeTheoNam(year);

            foreach (DataRow row in dt.Rows)
            {
                if (long.TryParse(row[1].ToString(), out long doanhThu))
                {
                    tongDT += doanhThu;
                }
            }

            lblTongDT.Text = tongDT.ToString("N0") + " đ";
        }

        private void dgvTK_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int cnt = 0;

            foreach (DataGridViewRow row in dgvTK.Rows)
            {
                cnt++;
                row.Cells[0].Value = cnt;
            }

            if (e.ColumnIndex == dgvTK.Columns["dgvDT"].Index && e.RowIndex >= 0)
            {
                if (decimal.TryParse(dgvTK.Rows[e.RowIndex].Cells["dgvDT"].Value.ToString(), out decimal revenue))
                {
                    e.Value = revenue.ToString("N0") + " đ";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
