namespace QuanLyBanCaPhe
{
    partial class FormDangNhap
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
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            label1 = new Label();
            btnDN = new Button();
            txtmk = new TextBox();
            txttdn = new TextBox();
            pictureBox1 = new PictureBox();
            fontDialog1 = new FontDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(172, 37, 42);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDN);
            panel1.Controls.Add(txtmk);
            panel1.Controls.Add(txttdn);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 862);
            panel1.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top;
            iconPictureBox1.BackColor = Color.FromArgb(136, 33, 6);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 50;
            iconPictureBox1.Location = new Point(735, 560);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Padding = new Padding(2, 4, 0, 0);
            iconPictureBox1.Size = new Size(56, 50);
            iconPictureBox1.TabIndex = 8;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(403, 501);
            label2.Name = "label2";
            label2.Size = new Size(171, 45);
            label2.TabIndex = 7;
            label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(403, 358);
            label1.Name = "label1";
            label1.Size = new Size(250, 45);
            label1.TabIndex = 6;
            label1.Text = "Tên đăng nhập:";
            // 
            // btnDN
            // 
            btnDN.Anchor = AnchorStyles.Top;
            btnDN.BackColor = Color.FromArgb(136, 33, 6);
            btnDN.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnDN.ForeColor = Color.White;
            btnDN.Location = new Point(402, 652);
            btnDN.Name = "btnDN";
            btnDN.Size = new Size(314, 67);
            btnDN.TabIndex = 5;
            btnDN.Text = "Đăng nhập";
            btnDN.UseVisualStyleBackColor = false;
            btnDN.Click += btnDN_Click;
            // 
            // txtmk
            // 
            txtmk.Anchor = AnchorStyles.Top;
            txtmk.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtmk.Location = new Point(403, 560);
            txtmk.Name = "txtmk";
            txtmk.PasswordChar = '*';
            txtmk.Size = new Size(314, 50);
            txtmk.TabIndex = 4;
            // 
            // txttdn
            // 
            txttdn.Anchor = AnchorStyles.Top;
            txttdn.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txttdn.Location = new Point(403, 416);
            txttdn.Name = "txttdn";
            txttdn.Size = new Size(314, 50);
            txttdn.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.hl_logo;
            pictureBox1.Location = new Point(422, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 862);
            Controls.Add(panel1);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDangNhap";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label2;
        private Label label1;
        private Button btnDN;
        private TextBox txtmk;
        private TextBox txttdn;
        private PictureBox pictureBox1;
        private FontDialog fontDialog1;
    }
}