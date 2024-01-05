using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;

namespace QuanLyBanCaPhe.GUI
{
    public partial class ucProduct : UserControl
    {
        public event EventHandler onSelect = null;
        public ucProduct()
        {
            InitializeComponent();
        }

        public int MaSP { get; set; }

        public string MaLoaiSP { get; set; }
        public long GiaBan
        { get; set; }

        public string GiaBan2
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value + " đ"; }
        }
        /*  public string GiaBan2
          {
              get { return long.TryParse(lblPrice.Text, out long giaBan) ? giaBan : 0; }
              set { lblPrice.Text = value.ToString() + " đ"; }
          }*/

        public string TenSP
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public Image AnhSP
        {
            get { return txtImg.Image; }
            set { txtImg.Image = value; }
        }



        private void txtImg_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }

}
