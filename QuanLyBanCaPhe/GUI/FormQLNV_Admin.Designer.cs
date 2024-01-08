namespace QuanLyBanCaPhe.GUI
{
    partial class FormQLNV_Admin
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
            btnNapDS = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            cbbMaCV = new ComboBox();
            label5 = new Label();
            cbbGT = new ComboBox();
            label4 = new Label();
            dtpNS = new DateTimePicker();
            label3 = new Label();
            txtTenNV = new TextBox();
            label2 = new Label();
            txtMaNV = new TextBox();
            label1 = new Label();
            btnTK = new Button();
            txtTimKiem = new TextBox();
            panel2 = new Panel();
            dgvNV = new DataGridView();
            dgvMaNV = new DataGridViewTextBoxColumn();
            tenNhanVienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngaySinhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gioiTinhDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            maChucVuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dTONhanVienBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTONhanVienBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnNapDS);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(cbbMaCV);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbbGT);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtpNS);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTenNV);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtMaNV);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnTK);
            panel1.Controls.Add(txtTimKiem);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1467, 460);
            panel1.TabIndex = 0;
            // 
            // btnNapDS
            // 
            btnNapDS.Anchor = AnchorStyles.Top;
            btnNapDS.BackColor = Color.FromArgb(235, 136, 10);
            btnNapDS.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNapDS.ForeColor = Color.White;
            btnNapDS.Location = new Point(1105, 345);
            btnNapDS.Name = "btnNapDS";
            btnNapDS.Size = new Size(204, 60);
            btnNapDS.TabIndex = 35;
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
            btnXoa.Location = new Point(806, 345);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(204, 60);
            btnXoa.TabIndex = 34;
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
            btnThem.Location = new Point(135, 345);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(204, 60);
            btnThem.TabIndex = 32;
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
            btnSua.Location = new Point(475, 345);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(204, 60);
            btnSua.TabIndex = 33;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // cbbMaCV
            // 
            cbbMaCV.Anchor = AnchorStyles.Top;
            cbbMaCV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbMaCV.FormattingEnabled = true;
            cbbMaCV.Location = new Point(1118, 176);
            cbbMaCV.Name = "cbbMaCV";
            cbbMaCV.Size = new Size(262, 40);
            cbbMaCV.TabIndex = 31;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(959, 179);
            label5.Name = "label5";
            label5.Size = new Size(153, 32);
            label5.TabIndex = 30;
            label5.Text = "Mã chức vụ:";
            // 
            // cbbGT
            // 
            cbbGT.Anchor = AnchorStyles.Top;
            cbbGT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbGT.FormattingEnabled = true;
            cbbGT.Location = new Point(647, 235);
            cbbGT.Name = "cbbGT";
            cbbGT.Size = new Size(262, 40);
            cbbGT.TabIndex = 29;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(503, 238);
            label4.Name = "label4";
            label4.Size = new Size(119, 32);
            label4.TabIndex = 28;
            label4.Text = "Giới tính:";
            // 
            // dtpNS
            // 
            dtpNS.Anchor = AnchorStyles.Top;
            dtpNS.CustomFormat = "dd/MM/yyyy";
            dtpNS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNS.Format = DateTimePickerFormat.Custom;
            dtpNS.Location = new Point(647, 178);
            dtpNS.Name = "dtpNS";
            dtpNS.Size = new Size(262, 39);
            dtpNS.TabIndex = 27;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(503, 179);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 26;
            label3.Text = "Ngày sinh:";
            // 
            // txtTenNV
            // 
            txtTenNV.Anchor = AnchorStyles.Top;
            txtTenNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenNV.Location = new Point(234, 236);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(224, 39);
            txtTenNV.TabIndex = 25;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(48, 238);
            label2.Name = "label2";
            label2.Size = new Size(180, 32);
            label2.TabIndex = 24;
            label2.Text = "Tên nhân viên:";
            // 
            // txtMaNV
            // 
            txtMaNV.Anchor = AnchorStyles.Top;
            txtMaNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNV.Location = new Point(234, 175);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(224, 39);
            txtMaNV.TabIndex = 23;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 175);
            label1.Name = "label1";
            label1.Size = new Size(176, 32);
            label1.TabIndex = 22;
            label1.Text = "Mã nhân viên:";
            // 
            // btnTK
            // 
            btnTK.Anchor = AnchorStyles.Top;
            btnTK.BackColor = Color.FromArgb(235, 84, 81);
            btnTK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTK.ForeColor = Color.White;
            btnTK.Location = new Point(849, 56);
            btnTK.Name = "btnTK";
            btnTK.Size = new Size(183, 48);
            btnTK.TabIndex = 21;
            btnTK.Text = "Tìm kiếm";
            btnTK.UseVisualStyleBackColor = false;
            btnTK.Click += btnTK_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top;
            txtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(388, 61);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên hoặc mã nhân viên...";
            txtTimKiem.Size = new Size(442, 39);
            txtTimKiem.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(dgvNV);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 460);
            panel2.Name = "panel2";
            panel2.Size = new Size(1467, 557);
            panel2.TabIndex = 1;
            // 
            // dgvNV
            // 
            dgvNV.AllowUserToAddRows = false;
            dgvNV.AllowUserToDeleteRows = false;
            dgvNV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dgvNV.AutoGenerateColumns = false;
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNV.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNV.Columns.AddRange(new DataGridViewColumn[] { dgvMaNV, tenNhanVienDataGridViewTextBoxColumn, ngaySinhDataGridViewTextBoxColumn, gioiTinhDataGridViewCheckBoxColumn, maChucVuDataGridViewTextBoxColumn });
            dgvNV.DataSource = dTONhanVienBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNV.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNV.EnableHeadersVisualStyles = false;
            dgvNV.Location = new Point(80, 33);
            dgvNV.Name = "dgvNV";
            dgvNV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvNV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvNV.RowHeadersVisible = false;
            dgvNV.RowHeadersWidth = 62;
            dgvNV.RowTemplate.Height = 33;
            dgvNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNV.Size = new Size(1299, 500);
            dgvNV.TabIndex = 0;
            dgvNV.CellClick += dgvNV_CellClick;
            // 
            // dgvMaNV
            // 
            dgvMaNV.DataPropertyName = "MaNhanVien";
            dgvMaNV.HeaderText = "Mã nhân viên";
            dgvMaNV.MinimumWidth = 8;
            dgvMaNV.Name = "dgvMaNV";
            dgvMaNV.ReadOnly = true;
            // 
            // tenNhanVienDataGridViewTextBoxColumn
            // 
            tenNhanVienDataGridViewTextBoxColumn.DataPropertyName = "TenNhanVien";
            tenNhanVienDataGridViewTextBoxColumn.HeaderText = "Tên nhân viên";
            tenNhanVienDataGridViewTextBoxColumn.MinimumWidth = 8;
            tenNhanVienDataGridViewTextBoxColumn.Name = "tenNhanVienDataGridViewTextBoxColumn";
            tenNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gioiTinhDataGridViewCheckBoxColumn
            // 
            gioiTinhDataGridViewCheckBoxColumn.DataPropertyName = "GioiTinh";
            gioiTinhDataGridViewCheckBoxColumn.HeaderText = "Giới tính";
            gioiTinhDataGridViewCheckBoxColumn.MinimumWidth = 8;
            gioiTinhDataGridViewCheckBoxColumn.Name = "gioiTinhDataGridViewCheckBoxColumn";
            gioiTinhDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // maChucVuDataGridViewTextBoxColumn
            // 
            maChucVuDataGridViewTextBoxColumn.DataPropertyName = "MaChucVu";
            maChucVuDataGridViewTextBoxColumn.HeaderText = "Mã chức vụ";
            maChucVuDataGridViewTextBoxColumn.MinimumWidth = 8;
            maChucVuDataGridViewTextBoxColumn.Name = "maChucVuDataGridViewTextBoxColumn";
            maChucVuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTONhanVienBindingSource
            // 
            dTONhanVienBindingSource.DataSource = typeof(DTO.DTO_NhanVien);
            // 
            // FormQLNV_Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1467, 1017);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormQLNV_Admin";
            Text = "Quản lý nhân viên";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTONhanVienBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnTK;
        private TextBox txtTimKiem;
        private TextBox txtTenNV;
        private Label label2;
        private TextBox txtMaNV;
        private Label label1;
        private DateTimePicker dtpNS;
        private Label label3;
        private ComboBox cbbGT;
        private Label label4;
        private ComboBox cbbMaCV;
        private Label label5;
        private Button btnNapDS;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
        private DataGridView dgvNV;
        private BindingSource dTONhanVienBindingSource;
        private DataGridViewTextBoxColumn dgvMaNV;
        private DataGridViewTextBoxColumn tenNhanVienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn gioiTinhDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn maChucVuDataGridViewTextBoxColumn;
    }
}