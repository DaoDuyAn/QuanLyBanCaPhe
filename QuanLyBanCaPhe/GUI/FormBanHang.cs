using QuanLyBanCaPhe.BUS;
using QuanLyBanCaPhe.DTO;
using QuanLyBanCaPhe.GUI;
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

namespace QuanLyBanCaPhe
{
    public partial class FormBanHang : Form
    {
        BUS_LoaiSanPham busLoaiSP = new BUS_LoaiSanPham();
        BUS_SanPham busSP = new BUS_SanPham();
        BUS_HoaDon busHD = new BUS_HoaDon();
        BUS_ChiTietHoaDon busCTHD = new BUS_ChiTietHoaDon();

        public DTO_NhanVien nv { set; get; }

        public FormBanHang(DTO_NhanVien nv)
        {
            InitializeComponent();

            this.nv = nv;

            AddCategory();
            ProductPanel.Controls.Clear();
            LoadProducts(1);
            cbbPTTT.SelectedIndex = 0;
        }

        public void AddCategory()
        {
            DataTable dt = busLoaiSP.getAllLoaiSP();

            CategoryPanel.Controls.Clear();

            if (dt.Rows.Count > 0)
            {
                int buttonWidth = 164;
                int marginBetweenButtons = 5;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    Button b = new Button();
                    b.BackColor = Color.FromArgb(213, 47, 68);
                    b.Size = new Size(buttonWidth, 60);
                    b.ForeColor = Color.White;
                    b.Font = new Font(b.Font.FontFamily, 15, FontStyle.Bold);
                    b.Text = dr["TenLoaiSP"].ToString();
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    int xPos = i * (buttonWidth + marginBetweenButtons);

                    b.Location = new Point(xPos, 0);

                    b.Tag = dr["MaLoaiSP"];

                    b.Click += CategoryButtonClick;

                    CategoryPanel.Controls.Add(b);
                }
            }
        }

        private void CategoryButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                int categoryId = Convert.ToInt32(clickedButton.Tag);
                ProductPanel.Controls.Clear();
                LoadProducts(categoryId);

                foreach (Control control in CategoryPanel.Controls)
                {
                    if (control is Button)
                    {
                        Button categoryButton = (Button)control;
                        if (categoryButton == clickedButton)
                        {
                            categoryButton.BackColor = Color.FromArgb(175, 37, 32);
                        }
                        else
                        {
                            categoryButton.BackColor = Color.FromArgb(213, 47, 68);
                        }
                    }
                }
            }
        }

        public void AddItems(string id, string name, string cat, string pimg, string price)
        {

            var product = new ucProduct()
            {
                MaSP = Convert.ToInt32(id),
                MaLoaiSP = cat,
                GiaBan = Convert.ToInt64(price),
                GiaBan2 = price,
                TenSP = name,
                AnhSP = Image.FromFile(pimg),
            };

            ProductPanel.Controls.Add(product);

            product.onSelect += (sender, e) =>
            {
                var wdg = (ucProduct)sender;
                foreach (DataGridViewRow item in dgvGioHang.Rows)
                {
                    // Nếu sản phẩm đã tồn tại thì tăng số lượng lên 1
                    if (Convert.ToInt32(item.Cells["dgvID"].Value) == wdg.MaSP)
                    {
                        item.Cells["dgvSL"].Value = int.Parse(item.Cells["dgvSL"].Value.ToString()) + 1;

                        return;
                    }
                }

                dgvGioHang.Rows.Add(new object[] { 0, wdg.MaSP, wdg.TenSP, wdg.GiaBan, 1 });
                TinhTongTienVaSoLuong();
            };
        }

        public void LoadProducts(int MaLoaiSP)
        {
            DataTable dt = busSP.getSanPhamByMaLoaiSP(MaLoaiSP);

            foreach (DataRow dr in dt.Rows)
            {
                AddItems(dr["MaSanPham"].ToString(), dr["TenSanPham"].ToString(),
                    dr["MaLoaiSP"].ToString(), dr["AnhSanPham"].ToString(), dr["GiaBan"].ToString());
            }
        }

        private void cbbPTTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Thanh toán bằng tiền mặt
            if (cbbPTTT.SelectedIndex == 0)
            {
                lblKhachDua.Visible = true;
                numKhachDua.Visible = true;

                lblCanTra.Visible = true;
                numCanTra.Visible = true;
            }

            // Thanh toán bằng thẻ
            if (cbbPTTT.SelectedIndex == 1)
            {
                lblKhachDua.Visible = false;
                numKhachDua.Visible = false;

                lblCanTra.Visible = false;
                numCanTra.Visible = false;
            }


        }

        private void dgvGioHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int cnt = 0;

            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                cnt++;
                row.Cells[0].Value = cnt;
            }
        }

        private void dgvGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvGioHang.Columns[e.ColumnIndex].Name;

            if (columnName == "dgvXoa")
            {
                DataGridViewRow selectedRow = dgvGioHang.Rows[e.RowIndex];
                dgvGioHang.Rows.Remove(selectedRow);

            }

            if (columnName == "dgvTang")
            {
                int currentQuantity = Convert.ToInt32(dgvGioHang.Rows[e.RowIndex].Cells["dgvSL"].Value);
                dgvGioHang.Rows[e.RowIndex].Cells["dgvSL"].Value = currentQuantity + 1;
            }

            if (columnName == "dgvGiam")
            {
                int currentQuantity = Convert.ToInt32(dgvGioHang.Rows[e.RowIndex].Cells["dgvSL"].Value);

                if (currentQuantity > 1)
                {
                    dgvGioHang.Rows[e.RowIndex].Cells["dgvSL"].Value = currentQuantity - 1;
                }
            }

            TinhTongTienVaSoLuong();
        }

        private void TinhTongTienVaSoLuong()
        {
            long tongTien = 0;
            int tongSoLuong = 0;

            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                int soLuong = Convert.ToInt32(row.Cells["dgvSL"].Value);
                long donGia = Convert.ToInt64(row.Cells["dgvGia"].Value);

                tongSoLuong += soLuong;
                tongTien += soLuong * donGia;
            }

            numTongSL.Text = tongSoLuong.ToString();
            numTongTien.Text = tongTien.ToString();
        }

        private void numKhachDua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                long tongTien = (long)numTongTien.Value;
                long khachDua = (long)numKhachDua.Value;

                numCanTra.Value = khachDua - tongTien;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Lưu không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            bool themHD = busHD.themHoaDon(DateTime.Now, nv.MaNhanVien);
            int maHD = busHD.getMaxMaHoaDon();

            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                if (!row.IsNewRow)
                {
                    int maSanPham = Convert.ToInt32(row.Cells["dgvID"].Value);
                    int soLuong = Convert.ToInt32(row.Cells["dgvSL"].Value);
                    long donGia = Convert.ToInt64(row.Cells["dgvGia"].Value);

                    bool themCTHD = busCTHD.themCTHD(maHD, maSanPham, soLuong, donGia);
                }
            }

            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            numTongTien.Value = 0;
            numTongSL.Value = 0;
            numCanTra.Value = 0;
            numKhachDua.Value = 0;

            dgvGioHang.Rows.Clear();
        }
    }
}
