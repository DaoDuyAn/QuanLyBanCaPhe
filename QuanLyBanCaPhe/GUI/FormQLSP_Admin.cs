using QuanLyBanCaPhe.BUS;
using QuanLyBanCaPhe.DTO;
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
    public partial class FormQLSP_Admin : Form
    {
        BUS_SanPham busSP = new BUS_SanPham();
        BUS_LoaiSanPham busLSP = new BUS_LoaiSanPham();
        public FormQLSP_Admin()
        {
            InitializeComponent();
            LoadDSSP();
            LoadMaLoaiSP();
        }

        void LoadDSSP()
        {
            dgvSP.DataSource = null;
            dgvSP.DataSource = busSP.getAllSanPham();
        }

        void LoadMaLoaiSP()
        {
            DataTable dtLoaiSP = busLSP.getAllLoaiSP();

            // Tạo một DataColumn mới để chứa dữ liệu hiển thị
            DataColumn displayColumn = new DataColumn("DisplayColumn", typeof(string));

            // Thêm cột mới vào DataTable
            dtLoaiSP.Columns.Add(displayColumn);

            // Tạo dữ liệu hiển thị
            foreach (DataRow row in dtLoaiSP.Rows)
            {
                row["DisplayColumn"] = $"{row["MaLoaiSP"]} - {row["TenLoaiSP"]}";
            }

            cbbMaLoaiSP.DataSource = dtLoaiSP;
            cbbMaLoaiSP.DisplayMember = "DisplayColumn";
            cbbMaLoaiSP.ValueMember = "MaLoaiSP";
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = dgvSP.CurrentRow.Cells[0].Value.ToString();
            txtTenSP.Text = dgvSP.CurrentRow.Cells[1].Value.ToString();
            txtGiaBan.Text = dgvSP.CurrentRow.Cells[3].Value.ToString();
            picAnh.ImageLocation = dgvSP.CurrentRow.Cells[2].Value.ToString();
            cbbMaLoaiSP.SelectedValue = Convert.ToInt32(dgvSP.CurrentRow.Cells[4].Value);
        }

        private void picAnh_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog
            {
                Title = "Chọn file ảnh",
                Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All Files (*.*)|*.*"
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var selectedFile = openFile.FileName;
                picAnh.ImageLocation = selectedFile;
            }
        }

        private void FormQLSP_Admin_Load(object sender, EventArgs e)
        {

        }

        public void Reset()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaBan.Text = "";
            cbbMaLoaiSP.SelectedIndex = 0;
            picAnh.ImageLocation = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "" || txtGiaBan.Text == "" || picAnh.Image == null)
            {
                MessageBox.Show("Thông tin cần được điền đầy đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool themSP = busSP.themSanPham(txtTenSP.Text, picAnh.ImageLocation, long.Parse(txtGiaBan.Text), (int)cbbMaLoaiSP.SelectedValue);

            if (themSP)
            {
                MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSSP();
                Reset();
            }
            else
            {
                MessageBox.Show("Thêm không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "" || txtTenSP.Text == "" || txtGiaBan.Text == "" || picAnh.Image == null)
            {
                MessageBox.Show("Thông tin cần được điền đầy đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool suaSP = busSP.suaSanPham(int.Parse(txtMaSP.Text), txtTenSP.Text, picAnh.ImageLocation, long.Parse(txtGiaBan.Text), (int)cbbMaLoaiSP.SelectedValue);
            if (suaSP)
            {
                MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDSSP();
                Reset();
            }
            else
            {
                MessageBox.Show("Sửa không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btnNapDS_Click(object sender, EventArgs e)
        {
            LoadDSSP();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Bạn cần chọn sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var res = MessageBox.Show("Bạn có chắc chắn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                bool xoaSP = busSP.xoaSanPham(int.Parse(txtMaSP.Text));

                if (xoaSP)
                {
                    LoadDSSP();
                    Reset();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

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

            DataTable dt = busSP.getSanPhamByKeyWord(keyword);

            if (dt.Rows.Count > 0)
            {
                dgvSP.DataSource = null;
                dgvSP.DataSource = dt;

                txtTimKiem.Text = "";
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvSP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvSP.Columns["dgvAnhSP"].Index && e.RowIndex >= 0)
            {
                string imageURL = e.Value as string;

                if (!string.IsNullOrEmpty(imageURL))
                {
                    try
                    {
                        Image image = Image.FromFile(imageURL);

                        e.Value = image;
                        e.FormattingApplied = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            dgvSP.RowTemplate.Height = 150;
        }
    }
}
