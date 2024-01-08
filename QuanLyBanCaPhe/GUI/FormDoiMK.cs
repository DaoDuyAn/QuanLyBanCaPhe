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
    public partial class FormDoiMK : Form
    {
        public DTO_NhanVien nv { set; get; }
        BUS_TaiKhoan busTK = new BUS_TaiKhoan();

        public FormDoiMK(DTO_NhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;
        }

        void Reset()
        {
            txtMKM.Text = "";
            txtNL.Text = "";
        }

        private void btnDMK_Click(object sender, EventArgs e)
        {
            if (txtMKM.Text == "" || txtNL.Text == "")
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtMKM.Text != txtNL.Text)
            {
                MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                return;
            }
            else
            {
                bool doiMK = busTK.doiMatKhau(nv.MaNhanVien, txtMKM.Text);

                if (doiMK)
                {
                    MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
            }
        }
    }
}
