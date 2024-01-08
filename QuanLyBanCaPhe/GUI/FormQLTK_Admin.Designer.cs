namespace QuanLyBanCaPhe.GUI
{
    partial class FormQLTK_Admin
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnTK = new Button();
            txtTimKiem = new TextBox();
            btnNapDS = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            label3 = new Label();
            txtMK = new TextBox();
            label4 = new Label();
            txtMaNV = new TextBox();
            label1 = new Label();
            txtMaTK = new TextBox();
            label2 = new Label();
            txtTenDN = new TextBox();
            panel2 = new Panel();
            dgvTK = new DataGridView();
            maTaiKhoanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenDangNhapDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvMK = new DataGridViewTextBoxColumn();
            maNhanVienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dTOTaiKhoanBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTOTaiKhoanBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnTK);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(btnNapDS);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtMK);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtMaNV);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMaTK);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTenDN);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1333, 412);
            panel1.TabIndex = 0;
            // 
            // btnTK
            // 
            btnTK.Anchor = AnchorStyles.Top;
            btnTK.BackColor = Color.FromArgb(235, 84, 81);
            btnTK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTK.ForeColor = Color.White;
            btnTK.Location = new Point(792, 49);
            btnTK.Name = "btnTK";
            btnTK.Size = new Size(183, 48);
            btnTK.TabIndex = 45;
            btnTK.Text = "Tìm kiếm";
            btnTK.UseVisualStyleBackColor = false;
            btnTK.Click += btnTK_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top;
            txtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(331, 54);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên đăng nhập...";
            txtTimKiem.Size = new Size(442, 39);
            txtTimKiem.TabIndex = 44;
            // 
            // btnNapDS
            // 
            btnNapDS.Anchor = AnchorStyles.Top;
            btnNapDS.BackColor = Color.FromArgb(235, 136, 10);
            btnNapDS.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNapDS.ForeColor = Color.White;
            btnNapDS.Location = new Point(1042, 314);
            btnNapDS.Name = "btnNapDS";
            btnNapDS.Size = new Size(204, 60);
            btnNapDS.TabIndex = 43;
            btnNapDS.Text = "Nạp DS";
            btnNapDS.UseVisualStyleBackColor = false;
            btnNapDS.Click += btnNapDS_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.BackColor = Color.FromArgb(235, 84, 81);
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(743, 314);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(204, 60);
            btnXoa.TabIndex = 42;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.BackColor = Color.FromArgb(50, 121, 240);
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(72, 314);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(204, 60);
            btnThem.TabIndex = 40;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.BackColor = Color.FromArgb(54, 137, 123);
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(412, 314);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(204, 60);
            btnSua.TabIndex = 41;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(680, 141);
            label3.Name = "label3";
            label3.Size = new Size(128, 32);
            label3.TabIndex = 36;
            label3.Text = "Mật khẩu:";
            // 
            // txtMK
            // 
            txtMK.Anchor = AnchorStyles.Top;
            txtMK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMK.Location = new Point(922, 138);
            txtMK.Name = "txtMK";
            txtMK.PasswordChar = '*';
            txtMK.Size = new Size(240, 39);
            txtMK.TabIndex = 37;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(680, 202);
            label4.Name = "label4";
            label4.Size = new Size(176, 32);
            label4.TabIndex = 38;
            label4.Text = "Mã nhân viên:";
            // 
            // txtMaNV
            // 
            txtMaNV.Anchor = AnchorStyles.Top;
            txtMaNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNV.Location = new Point(922, 202);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(240, 39);
            txtMaNV.TabIndex = 39;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(118, 141);
            label1.Name = "label1";
            label1.Size = new Size(170, 32);
            label1.TabIndex = 32;
            label1.Text = "Mã tài khoản:";
            // 
            // txtMaTK
            // 
            txtMaTK.Anchor = AnchorStyles.Top;
            txtMaTK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaTK.Location = new Point(360, 138);
            txtMaTK.Name = "txtMaTK";
            txtMaTK.Size = new Size(240, 39);
            txtMaTK.TabIndex = 33;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(118, 202);
            label2.Name = "label2";
            label2.Size = new Size(190, 32);
            label2.TabIndex = 34;
            label2.Text = "Tên đăng nhập:";
            // 
            // txtTenDN
            // 
            txtTenDN.Anchor = AnchorStyles.Top;
            txtTenDN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenDN.Location = new Point(360, 202);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(240, 39);
            txtTenDN.TabIndex = 35;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(dgvTK);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 412);
            panel2.Name = "panel2";
            panel2.Size = new Size(1333, 468);
            panel2.TabIndex = 1;
            // 
            // dgvTK
            // 
            dgvTK.AllowUserToAddRows = false;
            dgvTK.AllowUserToDeleteRows = false;
            dgvTK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dgvTK.AutoGenerateColumns = false;
            dgvTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTK.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTK.Columns.AddRange(new DataGridViewColumn[] { maTaiKhoanDataGridViewTextBoxColumn, tenDangNhapDataGridViewTextBoxColumn, dgvMK, maNhanVienDataGridViewTextBoxColumn });
            dgvTK.DataSource = dTOTaiKhoanBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTK.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTK.EnableHeadersVisualStyles = false;
            dgvTK.Location = new Point(99, 44);
            dgvTK.Name = "dgvTK";
            dgvTK.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTK.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTK.RowHeadersVisible = false;
            dgvTK.RowHeadersWidth = 62;
            dgvTK.RowTemplate.Height = 33;
            dgvTK.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTK.Size = new Size(1156, 388);
            dgvTK.TabIndex = 0;
            dgvTK.CellClick += dgvTK_CellClick;
            dgvTK.CellFormatting += dgvTK_CellFormatting;
            // 
            // maTaiKhoanDataGridViewTextBoxColumn
            // 
            maTaiKhoanDataGridViewTextBoxColumn.DataPropertyName = "MaTaiKhoan";
            maTaiKhoanDataGridViewTextBoxColumn.HeaderText = "Mã tài khoản";
            maTaiKhoanDataGridViewTextBoxColumn.MinimumWidth = 8;
            maTaiKhoanDataGridViewTextBoxColumn.Name = "maTaiKhoanDataGridViewTextBoxColumn";
            maTaiKhoanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenDangNhapDataGridViewTextBoxColumn
            // 
            tenDangNhapDataGridViewTextBoxColumn.DataPropertyName = "TenDangNhap";
            tenDangNhapDataGridViewTextBoxColumn.HeaderText = "Tên đăng nhập";
            tenDangNhapDataGridViewTextBoxColumn.MinimumWidth = 8;
            tenDangNhapDataGridViewTextBoxColumn.Name = "tenDangNhapDataGridViewTextBoxColumn";
            tenDangNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgvMK
            // 
            dgvMK.DataPropertyName = "MatKhau";
            dgvMK.HeaderText = "Mật khẩu";
            dgvMK.MinimumWidth = 8;
            dgvMK.Name = "dgvMK";
            dgvMK.ReadOnly = true;
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            maNhanVienDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            maNhanVienDataGridViewTextBoxColumn.MinimumWidth = 8;
            maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            maNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTOTaiKhoanBindingSource
            // 
            dTOTaiKhoanBindingSource.DataSource = typeof(DTO.DTO_TaiKhoan);
            // 
            // FormQLTK_Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 880);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormQLTK_Admin";
            Text = "Quản lý tài khoản";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTK).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTOTaiKhoanBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvTK;
        private BindingSource dTOTaiKhoanBindingSource;
        private Label label3;
        private TextBox txtMK;
        private Label label4;
        private TextBox txtMaNV;
        private Label label1;
        private TextBox txtMaTK;
        private Label label2;
        private TextBox txtTenDN;
        private Button btnNapDS;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
        private DataGridViewTextBoxColumn maTaiKhoanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenDangNhapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dgvMK;
        private DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private Button btnTK;
        private TextBox txtTimKiem;
    }
}