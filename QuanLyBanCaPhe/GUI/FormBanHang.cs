using QuanLyBanCaPhe.BUS;
using QuanLyBanCaPhe.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public FormBanHang()
        {
            InitializeComponent();
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
            if (cbbPTTT.SelectedIndex == 1)
            {
                lblKhachDua.Visible = false;
                numKhachDua.Visible = false;

                lblCanTra.Visible = false;
                numCanTra.Visible = false;
            }
        }
    }
}
