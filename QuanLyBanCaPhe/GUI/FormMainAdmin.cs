using FontAwesome.Sharp;
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
    public partial class FormMainAdmin : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public DTO_NhanVien nv { set; get; }
        public FormMainAdmin(DTO_NhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(8, 80);
            panelMenu.Controls.Add(leftBorderBtn);
            this.WindowState = FormWindowState.Maximized;

            labelName.Text = nv.TenNhanVien;
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(81, 56, 43);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                //  currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(136, 33, 6);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

                leftBorderBtn.BackColor = Color.FromArgb(136, 33, 6);
            }
        }

        private void OpenChildForm(Form childForm)
        {
            // Open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            // End

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;


            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

            lblTitleChildForm.Text = childForm.Text;

        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(224, 224, 224);
            lblTitleChildForm.Text = "Trang chủ";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            Reset();
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            FormDangNhap formDN = new FormDangNhap();
            formDN.Show();
            this.Hide();
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 255, 255));
            OpenChildForm(new FormQLSP_Admin());
        }

        private void btnQLLSP_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 255, 255));
          //  OpenChildForm(new FormQLLSP_Admin());
        }
    }
}
