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
        public FormDangNhap()
        {
            InitializeComponent();
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
    }
}
