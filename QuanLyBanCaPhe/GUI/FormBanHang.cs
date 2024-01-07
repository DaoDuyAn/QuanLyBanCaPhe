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
using Excel = Microsoft.Office.Interop.Excel;

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
                GiaBan2 = Convert.ToInt64(price).ToString("N0"),
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

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Khai báo và khởi tạo các thành phần của các đối tượng M.O.I.Excel
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1]; // Đưa con trỏ vào ô A1

            // Định dạng cho file Excel
            exRange.Font.Bold = true;
            exRange.Font.Size = 15;
            exRange.Font.Color = Color.DarkRed;
            exRange.Value = "HIGHLANDS COFFEE";

            Excel.Range dc = (Excel.Range)exSheet.Cells[2, 1]; // hàng 2 cột 1
            dc.Font.Size = 13;
            dc.Font.Color = Color.DarkRed;
            dc.Value = "38 Lê Lợi - Huế";

            Excel.Range sdt = (Excel.Range)exSheet.Cells[3, 1]; // hàng
            sdt.Font.Size = 13;
            sdt.Font.Color = Color.DarkRed;
            sdt.Value = "0235 3757 585";


            // In chữ Hóa đơn
            exSheet.Range["C5"].Font.Size = 20;
            exSheet.Range["C5"].Font.Bold = true;
            exSheet.Range["C5"].Font.Color = Color.DarkRed;
            exSheet.Range["C5"].Value = "HÓA ĐƠN";

            // In các thông tin chung
            exSheet.Range["A6:A8"].Font.Size = 12;
            exSheet.Range["A6"].Value = "Mã hóa đơn: " + busHD.getMaxMaHoaDon().ToString();
            exSheet.Range["A7"].Value = "Tên nhân viên: " + nv.TenNhanVien;
            exSheet.Range["A8"].Value = "Ngày lập: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            // In dòng tiêu đề
            exSheet.Range["A10:E10"].Font.Size = 12;
            exSheet.Range["A10:E10"].Font.Bold = true;

            exSheet.Range["A10"].Value = "STT";
            exSheet.Range["A10"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            exSheet.Range["B10"].Value = "Tên sản phẩm";
            exSheet.Range["B10"].ColumnWidth = 25;
            exSheet.Range["B10"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            exSheet.Range["C10"].Value = "Số lượng";
            exSheet.Range["C10"].ColumnWidth = 20;
            exSheet.Range["C10"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            exSheet.Range["D10"].Value = "Đơn giá";
            exSheet.Range["D10"].ColumnWidth = 20;
            exSheet.Range["D10"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            exSheet.Range["E10"].Value = "Thành tiền";
            exSheet.Range["E10"].ColumnWidth = 20;
            exSheet.Range["E10"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // In chi tiết hóa đơn
            int line = 11;
            for (int i = 0; i < dgvGioHang.Rows.Count; ++i)
            {
                exSheet.Range["A" + (line).ToString()].Value = dgvGioHang.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["A" + (line).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                exSheet.Range["B" + (line).ToString()].Value = dgvGioHang.Rows[i].Cells[2].Value.ToString();
                exSheet.Range["B" + (line).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                exSheet.Range["C" + (line).ToString()].Value = dgvGioHang.Rows[i].Cells[4].Value.ToString();
                exSheet.Range["C" + (line).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                exSheet.Range["D" + (line).ToString()].Value = long.Parse(dgvGioHang.Rows[i].Cells[3].Value.ToString()).ToString("N0") + " đ";
                exSheet.Range["D" + (line).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                int SL = int.Parse(dgvGioHang.Rows[i].Cells[4].Value.ToString());
                long Gia = long.Parse(dgvGioHang.Rows[i].Cells[3].Value.ToString());
                long ThanhTien = SL * Gia;

                exSheet.Range["E" + (line).ToString()].Value = ThanhTien.ToString("N0") + " đ";
                exSheet.Range["E" + (line).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                line++;
            }

            line = line + dgvGioHang.Rows.Count;
            exSheet.Range["D" + line.ToString()].Value = "Tổng tiền: " + numTongTien.Value.ToString("N0") + " đ";
            exSheet.Range["D" + line.ToString()].Font.Bold = true;

            // Đặt tên cho Sheet
            exSheet.Name = busHD.getMaxMaHoaDon().ToString();

            // Kích hoạt cho file Excel hoạt động
            exBook.Activate();

            // Lưu file Excel
            SaveFileDialog save = new SaveFileDialog();

            // Thiết lập bộ lọc cho các tệp
            save.Filter = "Excel Workbook (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(save.FileName.ToLower());
            }

            // Thoát khỏi ứng dụng
            exApp.Quit();

            MessageBox.Show("In thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            numTongTien.Value = 0;
            numTongSL.Value = 0;
            numCanTra.Value = 0;
            numKhachDua.Value = 0;

            // Xóa giỏ hàng
            dgvGioHang.Rows.Clear();
        }
    }
}
