using QuanLyBanCaPhe.BUS;
using QuanLyBanCaPhe.DTO;
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
    public partial class FormDangNhap : Form
    {
        BUS_TaiKhoan busTK = new BUS_TaiKhoan();
        BUS_NhanVien busNV = new BUS_NhanVien();

        ErrorProvider errorProvider;
        public FormDangNhap()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if (txtmk.PasswordChar == '*')
            {
                // Đổi sang hiển thị mật khẩu dưới dạng chữ
                txtmk.PasswordChar = '\0';
            }
            else
            {
                txtmk.PasswordChar = '*';
            }
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (string.IsNullOrEmpty(txttdn.Text.Trim()))
            {
                errorProvider.SetError(txttdn, "Vui lòng nhập tên đăng nhập!");
                txttdn.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtmk.Text.Trim()))
            {
                errorProvider.SetError(txtmk, "Vui lòng nhập mật khẩu!");
                txtmk.Focus();
                return;
            }

            DTO_TaiKhoan tk = busTK.kiemTraDN(txttdn.Text, txtmk.Text);
            if (tk != null)
            {
                DTO_NhanVien nv = busNV.getNhanVienByMaNhanVien(tk.MaNhanVien);

                if (nv.MaChucVu.Equals("CV2"))
                {
                    FormMain formMain = new FormMain(nv);
                    formMain.Show();
                    this.Hide();
                }
                else
                {
                    FormMainAdmin formMainAdmin = new FormMainAdmin(nv);
                    formMainAdmin.Show();
                    this.Hide();
                }


            }
            else
            {
                DTO_TaiKhoan _tk = busTK.getTKByTenDN(txttdn.Text);
                if (_tk != null)
                {
                    MessageBox.Show("Mật khẩu không chính xác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmk.Text = "";
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttdn.Text = "";
                    txtmk.Text = "";
                }
            }
        }
    }
}
