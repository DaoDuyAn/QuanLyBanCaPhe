namespace QuanLyBanCaPhe
{
    partial class FormMain
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
            panelMenu = new Panel();
            btnDX = new FontAwesome.Sharp.IconButton();
            btnTK = new FontAwesome.Sharp.IconButton();
            btnQLHD = new FontAwesome.Sharp.IconButton();
            btnBH = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panel1 = new Panel();
            labelName = new Label();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(136, 33, 6);
            panelMenu.Controls.Add(btnDX);
            panelMenu.Controls.Add(btnTK);
            panelMenu.Controls.Add(btnQLHD);
            panelMenu.Controls.Add(btnBH);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(376, 900);
            panelMenu.TabIndex = 0;
            // 
            // btnDX
            // 
            btnDX.Dock = DockStyle.Top;
            btnDX.FlatAppearance.BorderSize = 0;
            btnDX.FlatStyle = FlatStyle.Flat;
            btnDX.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnDX.ForeColor = Color.Gainsboro;
            btnDX.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnDX.IconColor = Color.Gainsboro;
            btnDX.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDX.IconSize = 50;
            btnDX.ImageAlign = ContentAlignment.MiddleLeft;
            btnDX.Location = new Point(0, 420);
            btnDX.Name = "btnDX";
            btnDX.Padding = new Padding(10, 0, 20, 0);
            btnDX.Size = new Size(376, 80);
            btnDX.TabIndex = 7;
            btnDX.Text = "Đăng xuất";
            btnDX.TextAlign = ContentAlignment.MiddleLeft;
            btnDX.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDX.UseVisualStyleBackColor = true;
            // 
            // btnTK
            // 
            btnTK.Dock = DockStyle.Top;
            btnTK.FlatAppearance.BorderSize = 0;
            btnTK.FlatStyle = FlatStyle.Flat;
            btnTK.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnTK.ForeColor = Color.Gainsboro;
            btnTK.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnTK.IconColor = Color.Gainsboro;
            btnTK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTK.IconSize = 50;
            btnTK.ImageAlign = ContentAlignment.MiddleLeft;
            btnTK.Location = new Point(0, 340);
            btnTK.Name = "btnTK";
            btnTK.Padding = new Padding(10, 0, 20, 0);
            btnTK.Size = new Size(376, 80);
            btnTK.TabIndex = 5;
            btnTK.Text = "Thống kê";
            btnTK.TextAlign = ContentAlignment.MiddleLeft;
            btnTK.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTK.UseVisualStyleBackColor = true;
            // 
            // btnQLHD
            // 
            btnQLHD.Dock = DockStyle.Top;
            btnQLHD.FlatAppearance.BorderSize = 0;
            btnQLHD.FlatStyle = FlatStyle.Flat;
            btnQLHD.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLHD.ForeColor = Color.Gainsboro;
            btnQLHD.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
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
            btnQLHD.Click += btnQLHD_Click;
            // 
            // btnBH
            // 
            btnBH.BackColor = Color.FromArgb(136, 33, 6);
            btnBH.Dock = DockStyle.Top;
            btnBH.FlatAppearance.BorderSize = 0;
            btnBH.FlatStyle = FlatStyle.Flat;
            btnBH.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnBH.ForeColor = Color.Gainsboro;
            btnBH.IconChar = FontAwesome.Sharp.IconChar.CircleNotch;
            btnBH.IconColor = Color.Gainsboro;
            btnBH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBH.IconSize = 50;
            btnBH.ImageAlign = ContentAlignment.MiddleLeft;
            btnBH.Location = new Point(0, 180);
            btnBH.Name = "btnBH";
            btnBH.Padding = new Padding(10, 0, 20, 0);
            btnBH.Size = new Size(376, 80);
            btnBH.TabIndex = 3;
            btnBH.Text = "Bán hàng";
            btnBH.TextAlign = ContentAlignment.MiddleLeft;
            btnBH.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBH.UseVisualStyleBackColor = false;
            btnBH.Click += btnBH_Click;
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
            btnHome.Click += btnHome_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(136, 33, 6);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(lblTitleChildForm);
            panel1.Controls.Add(iconCurrentChildForm);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(376, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1404, 114);
            panel1.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(1240, 54);
            labelName.Name = "labelName";
            labelName.Size = new Size(131, 45);
            labelName.TabIndex = 4;
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
            panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(172, 37, 42);
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(376, 180);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1404, 720);
            panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.ban1;
            pictureBox1.Location = new Point(6, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1395, 468);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormMain
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
            Name = "FormMain";
            Text = "FormMain";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnDX;
        private FontAwesome.Sharp.IconButton btnTK;
        private FontAwesome.Sharp.IconButton btnQLHD;
        private FontAwesome.Sharp.IconButton btnBH;
        private PictureBox btnHome;
        private Panel panel1;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private PictureBox pictureBox1;
        private Label labelName;
    }
}