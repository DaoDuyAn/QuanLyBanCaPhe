namespace QuanLyBanCaPhe.GUI
{
    partial class FormMainAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelDesktop = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu = new Panel();
            btnDX = new FontAwesome.Sharp.IconButton();
            btnTK = new FontAwesome.Sharp.IconButton();
            btnQLSP = new FontAwesome.Sharp.IconButton();
            btnQLLSP = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btnQLCV = new FontAwesome.Sharp.IconButton();
            btnQLHD = new FontAwesome.Sharp.IconButton();
            btnQLTK = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            labelName = new Label();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            SuspendLayout();
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(172, 37, 42);
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(376, 180);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1404, 720);
            panelDesktop.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.ban1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1404, 720);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(136, 33, 6);
            panelMenu.Controls.Add(btnDX);
            panelMenu.Controls.Add(btnTK);
            panelMenu.Controls.Add(btnQLSP);
            panelMenu.Controls.Add(btnQLLSP);
            panelMenu.Controls.Add(iconButton2);
            panelMenu.Controls.Add(btnQLCV);
            panelMenu.Controls.Add(btnQLHD);
            panelMenu.Controls.Add(btnQLTK);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(376, 900);
            panelMenu.TabIndex = 4;
            // 
            // btnDX
            // 
            btnDX.Dock = DockStyle.Top;
            btnDX.FlatAppearance.BorderSize = 0;
            btnDX.FlatStyle = FlatStyle.Flat;
            btnDX.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnDX.ForeColor = Color.Gainsboro;
            btnDX.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            btnDX.IconColor = Color.Gainsboro;
            btnDX.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDX.IconSize = 50;
            btnDX.ImageAlign = ContentAlignment.MiddleLeft;
            btnDX.Location = new Point(0, 740);
            btnDX.Name = "btnDX";
            btnDX.Padding = new Padding(10, 0, 20, 0);
            btnDX.Size = new Size(376, 80);
            btnDX.TabIndex = 7;
            btnDX.Text = "Đăng xuất";
            btnDX.TextAlign = ContentAlignment.MiddleLeft;
            btnDX.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDX.UseVisualStyleBackColor = true;
            btnDX.Click += btnDX_Click;
            // 
            // btnTK
            // 
            btnTK.Dock = DockStyle.Top;
            btnTK.FlatAppearance.BorderSize = 0;
            btnTK.FlatStyle = FlatStyle.Flat;
            btnTK.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnTK.ForeColor = Color.Gainsboro;
            btnTK.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            btnTK.IconColor = Color.Gainsboro;
            btnTK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTK.IconSize = 50;
            btnTK.ImageAlign = ContentAlignment.MiddleLeft;
            btnTK.Location = new Point(0, 660);
            btnTK.Name = "btnTK";
            btnTK.Padding = new Padding(10, 0, 20, 0);
            btnTK.Size = new Size(376, 80);
            btnTK.TabIndex = 5;
            btnTK.Text = "Thống kê";
            btnTK.TextAlign = ContentAlignment.MiddleLeft;
            btnTK.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTK.UseVisualStyleBackColor = true;
            // 
            // btnQLSP
            // 
            btnQLSP.BackColor = Color.FromArgb(136, 33, 6);
            btnQLSP.Dock = DockStyle.Top;
            btnQLSP.FlatAppearance.BorderSize = 0;
            btnQLSP.FlatStyle = FlatStyle.Flat;
            btnQLSP.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLSP.ForeColor = Color.Gainsboro;
            btnQLSP.IconChar = FontAwesome.Sharp.IconChar.CubesStacked;
            btnQLSP.IconColor = Color.Gainsboro;
            btnQLSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQLSP.IconSize = 50;
            btnQLSP.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLSP.Location = new Point(0, 580);
            btnQLSP.Name = "btnQLSP";
            btnQLSP.Padding = new Padding(10, 0, 20, 0);
            btnQLSP.Size = new Size(376, 80);
            btnQLSP.TabIndex = 11;
            btnQLSP.Text = "Quản lý sản phẩm";
            btnQLSP.TextAlign = ContentAlignment.MiddleLeft;
            btnQLSP.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQLSP.UseVisualStyleBackColor = false;
            btnQLSP.Click += btnQLSP_Click;
            // 
            // btnQLLSP
            // 
            btnQLLSP.BackColor = Color.FromArgb(136, 33, 6);
            btnQLLSP.Dock = DockStyle.Top;
            btnQLLSP.FlatAppearance.BorderSize = 0;
            btnQLLSP.FlatStyle = FlatStyle.Flat;
            btnQLLSP.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLLSP.ForeColor = Color.Gainsboro;
            btnQLLSP.IconChar = FontAwesome.Sharp.IconChar.FillDrip;
            btnQLLSP.IconColor = Color.Gainsboro;
            btnQLLSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQLLSP.IconSize = 50;
            btnQLLSP.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLLSP.Location = new Point(0, 500);
            btnQLLSP.Name = "btnQLLSP";
            btnQLLSP.Padding = new Padding(10, 0, 20, 0);
            btnQLLSP.Size = new Size(376, 80);
            btnQLLSP.TabIndex = 10;
            btnQLLSP.Text = "Quản lý loại SP";
            btnQLLSP.TextAlign = ContentAlignment.MiddleLeft;
            btnQLLSP.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQLLSP.UseVisualStyleBackColor = false;
            btnQLLSP.Click += btnQLLSP_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(136, 33, 6);
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.Gainsboro;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            iconButton2.IconColor = Color.Gainsboro;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 50;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 420);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(10, 0, 20, 0);
            iconButton2.Size = new Size(376, 80);
            iconButton2.TabIndex = 9;
            iconButton2.Text = "Quản lý nhân viên";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // btnQLCV
            // 
            btnQLCV.BackColor = Color.FromArgb(136, 33, 6);
            btnQLCV.Dock = DockStyle.Top;
            btnQLCV.FlatAppearance.BorderSize = 0;
            btnQLCV.FlatStyle = FlatStyle.Flat;
            btnQLCV.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLCV.ForeColor = Color.Gainsboro;
            btnQLCV.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            btnQLCV.IconColor = Color.Gainsboro;
            btnQLCV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQLCV.IconSize = 50;
            btnQLCV.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLCV.Location = new Point(0, 340);
            btnQLCV.Name = "btnQLCV";
            btnQLCV.Padding = new Padding(10, 0, 20, 0);
            btnQLCV.Size = new Size(376, 80);
            btnQLCV.TabIndex = 8;
            btnQLCV.Text = "Quản lý chức vụ";
            btnQLCV.TextAlign = ContentAlignment.MiddleLeft;
            btnQLCV.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQLCV.UseVisualStyleBackColor = false;
            // 
            // btnQLHD
            // 
            btnQLHD.Dock = DockStyle.Top;
            btnQLHD.FlatAppearance.BorderSize = 0;
            btnQLHD.FlatStyle = FlatStyle.Flat;
            btnQLHD.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLHD.ForeColor = Color.Gainsboro;
            btnQLHD.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            btnQLHD.IconColor = Color.Gainsboro;
            btnQLHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQLHD.IconSize = 50;
            btnQLHD.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLHD.Location = new Point(0, 260);
            btnQLHD.Name = "btnQLHD";
            btnQLHD.Padding = new Padding(10, 0, 20, 0);
            btnQLHD.Size = new Size(376, 80);
            btnQLHD.TabIndex = 4;
            btnQLHD.Text = "Quản lý hóa đơn";
            btnQLHD.TextAlign = ContentAlignment.MiddleLeft;
            btnQLHD.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQLHD.UseVisualStyleBackColor = true;
            // 
            // btnQLTK
            // 
            btnQLTK.BackColor = Color.FromArgb(136, 33, 6);
            btnQLTK.Dock = DockStyle.Top;
            btnQLTK.FlatAppearance.BorderSize = 0;
            btnQLTK.FlatStyle = FlatStyle.Flat;
            btnQLTK.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLTK.ForeColor = Color.Gainsboro;
            btnQLTK.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            btnQLTK.IconColor = Color.Gainsboro;
            btnQLTK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQLTK.IconSize = 50;
            btnQLTK.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLTK.Location = new Point(0, 180);
            btnQLTK.Name = "btnQLTK";
            btnQLTK.Padding = new Padding(10, 0, 20, 0);
            btnQLTK.Size = new Size(376, 80);
            btnQLTK.TabIndex = 3;
            btnQLTK.Text = "Quản lý tài khoản";
            btnQLTK.TextAlign = ContentAlignment.MiddleLeft;
            btnQLTK.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQLTK.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(376, 180);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = Properties.Resources.hl_logo;
            btnHome.Location = new Point(0, 13);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(376, 154);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(136, 33, 6);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(lblTitleChildForm);
            panel1.Controls.Add(iconCurrentChildForm);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(376, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1404, 114);
            panel1.TabIndex = 5;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Right;
            iconPictureBox1.BackColor = Color.FromArgb(136, 33, 6);
            iconPictureBox1.ForeColor = Color.FromArgb(224, 224, 224);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PersonBreastfeeding;
            iconPictureBox1.IconColor = Color.FromArgb(224, 224, 224);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 59;
            iconPictureBox1.Location = new Point(1173, 43);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(69, 59);
            iconPictureBox1.TabIndex = 7;
            iconPictureBox1.TabStop = false;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(1236, 51);
            labelName.Name = "labelName";
            labelName.Size = new Size(131, 45);
            labelName.TabIndex = 6;
            labelName.Text = "Duy An";
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleChildForm.ForeColor = Color.FromArgb(224, 224, 224);
            lblTitleChildForm.Location = new Point(114, 51);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(186, 48);
            lblTitleChildForm.TabIndex = 3;
            lblTitleChildForm.Text = "Trang chủ";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(136, 33, 6);
            iconCurrentChildForm.ForeColor = Color.FromArgb(224, 224, 224);
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconCurrentChildForm.IconColor = Color.FromArgb(224, 224, 224);
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 59;
            iconCurrentChildForm.Location = new Point(39, 48);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(69, 59);
            iconCurrentChildForm.TabIndex = 2;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(136, 33, 6);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(376, 114);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1404, 66);
            panelShadow.TabIndex = 6;
            // 
            // FormMainAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1780, 900);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMainAdmin";
            Text = "FormMainAdmin";
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDesktop;
        private PictureBox pictureBox1;
        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDX;
        private FontAwesome.Sharp.IconButton btnTK;
        private FontAwesome.Sharp.IconButton btnQLHD;
        private FontAwesome.Sharp.IconButton btnQLTK;
        private Panel panelLogo;
        private PictureBox btnHome;
        private Panel panel1;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Panel panelShadow;
        private FontAwesome.Sharp.IconButton btnQLSP;
        private FontAwesome.Sharp.IconButton btnQLLSP;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnQLCV;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label labelName;
    }
}