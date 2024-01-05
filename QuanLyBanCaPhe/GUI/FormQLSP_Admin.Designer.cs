namespace QuanLyBanCaPhe.GUI
{
    partial class FormQLSP_Admin
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
            dgvSP = new DataGridView();
            maSanPhamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenSanPhamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anhSanPhamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaBanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maLoaiSPDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dTOSanPhamBindingSource = new BindingSource(components);
            label1 = new Label();
            txtMaSP = new TextBox();
            txtTenSP = new TextBox();
            label2 = new Label();
            txtGiaBan = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            picAnh = new PictureBox();
            btnThem = new Button();
            btnSua = new Button();
            panel1 = new Panel();
            btnTK = new Button();
            txtTimKiem = new TextBox();
            btnNapDS = new Button();
            cbbMaLoaiSP = new ComboBox();
            btnXoa = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTOSanPhamBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSP
            // 
            dgvSP.AllowUserToAddRows = false;
            dgvSP.AllowUserToDeleteRows = false;
            dgvSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dgvSP.AutoGenerateColumns = false;
            dgvSP.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSP.Columns.AddRange(new DataGridViewColumn[] { maSanPhamDataGridViewTextBoxColumn, tenSanPhamDataGridViewTextBoxColumn, anhSanPhamDataGridViewTextBoxColumn, giaBanDataGridViewTextBoxColumn, maLoaiSPDataGridViewTextBoxColumn });
            dgvSP.DataSource = dTOSanPhamBindingSource;
            dgvSP.EnableHeadersVisualStyles = false;
            dgvSP.Location = new Point(88, 543);
            dgvSP.Name = "dgvSP";
            dgvSP.ReadOnly = true;
            dgvSP.RowHeadersWidth = 62;
            dgvSP.RowTemplate.Height = 33;
            dgvSP.Size = new Size(1407, 381);
            dgvSP.TabIndex = 0;
            dgvSP.CellClick += dgvSP_CellClick;
            // 
            // maSanPhamDataGridViewTextBoxColumn
            // 
            maSanPhamDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maSanPhamDataGridViewTextBoxColumn.DataPropertyName = "MaSanPham";
            maSanPhamDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            maSanPhamDataGridViewTextBoxColumn.MinimumWidth = 8;
            maSanPhamDataGridViewTextBoxColumn.Name = "maSanPhamDataGridViewTextBoxColumn";
            maSanPhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenSanPhamDataGridViewTextBoxColumn
            // 
            tenSanPhamDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenSanPhamDataGridViewTextBoxColumn.DataPropertyName = "TenSanPham";
            tenSanPhamDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            tenSanPhamDataGridViewTextBoxColumn.MinimumWidth = 8;
            tenSanPhamDataGridViewTextBoxColumn.Name = "tenSanPhamDataGridViewTextBoxColumn";
            tenSanPhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anhSanPhamDataGridViewTextBoxColumn
            // 
            anhSanPhamDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            anhSanPhamDataGridViewTextBoxColumn.DataPropertyName = "AnhSanPham";
            anhSanPhamDataGridViewTextBoxColumn.HeaderText = "Ảnh sản phẩm";
            anhSanPhamDataGridViewTextBoxColumn.MinimumWidth = 8;
            anhSanPhamDataGridViewTextBoxColumn.Name = "anhSanPhamDataGridViewTextBoxColumn";
            anhSanPhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            giaBanDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            giaBanDataGridViewTextBoxColumn.HeaderText = "Giá bán";
            giaBanDataGridViewTextBoxColumn.MinimumWidth = 8;
            giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            giaBanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maLoaiSPDataGridViewTextBoxColumn
            // 
            maLoaiSPDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maLoaiSPDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiSP";
            maLoaiSPDataGridViewTextBoxColumn.HeaderText = "Mã loại SP";
            maLoaiSPDataGridViewTextBoxColumn.MinimumWidth = 8;
            maLoaiSPDataGridViewTextBoxColumn.Name = "maLoaiSPDataGridViewTextBoxColumn";
            maLoaiSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTOSanPhamBindingSource
            // 
            dTOSanPhamBindingSource.DataSource = typeof(DTO.DTO_SanPham);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(151, 223);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 1;
            label1.Text = "Mã sản phẩm:";
            // 
            // txtMaSP
            // 
            txtMaSP.Anchor = AnchorStyles.Top;
            txtMaSP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaSP.Location = new Point(369, 229);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(240, 39);
            txtMaSP.TabIndex = 2;
            // 
            // txtTenSP
            // 
            txtTenSP.Anchor = AnchorStyles.Top;
            txtTenSP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenSP.Location = new Point(369, 293);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(240, 39);
            txtTenSP.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(151, 291);
            label2.Name = "label2";
            label2.Size = new Size(178, 32);
            label2.TabIndex = 3;
            label2.Text = "Tên sản phẩm:";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Anchor = AnchorStyles.Top;
            txtGiaBan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGiaBan.Location = new Point(920, 229);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(240, 39);
            txtGiaBan.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(685, 229);
            label3.Name = "label3";
            label3.Size = new Size(108, 32);
            label3.TabIndex = 5;
            label3.Text = "Giá bán:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(685, 295);
            label4.Name = "label4";
            label4.Size = new Size(223, 32);
            label4.TabIndex = 7;
            label4.Text = "Mã loại sản phẩm:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1277, 114);
            label5.Name = "label5";
            label5.Size = new Size(184, 32);
            label5.TabIndex = 9;
            label5.Text = "Ảnh sản phẩm:";
            // 
            // picAnh
            // 
            picAnh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picAnh.BorderStyle = BorderStyle.FixedSingle;
            picAnh.Location = new Point(1277, 165);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(218, 207);
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picAnh.TabIndex = 10;
            picAnh.TabStop = false;
            picAnh.Click += picAnh_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.BackColor = Color.FromArgb(50, 121, 240);
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(189, 410);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(204, 60);
            btnThem.TabIndex = 11;
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
            btnSua.Location = new Point(529, 410);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(204, 60);
            btnSua.TabIndex = 12;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnTK);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(btnNapDS);
            panel1.Controls.Add(cbbMaLoaiSP);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMaSP);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTenSP);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtGiaBan);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(picAnh);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnSua);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1582, 498);
            panel1.TabIndex = 13;
            // 
            // btnTK
            // 
            btnTK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTK.BackColor = Color.FromArgb(235, 84, 81);
            btnTK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTK.ForeColor = Color.White;
            btnTK.Location = new Point(860, 102);
            btnTK.Name = "btnTK";
            btnTK.Size = new Size(204, 48);
            btnTK.TabIndex = 17;
            btnTK.Text = "Tìm kiếm";
            btnTK.UseVisualStyleBackColor = false;
            btnTK.Click += btnTK_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top;
            txtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(399, 107);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên sản phẩm...";
            txtTimKiem.Size = new Size(442, 39);
            txtTimKiem.TabIndex = 16;
            // 
            // btnNapDS
            // 
            btnNapDS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNapDS.BackColor = Color.FromArgb(235, 136, 10);
            btnNapDS.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNapDS.ForeColor = Color.White;
            btnNapDS.Location = new Point(1159, 410);
            btnNapDS.Name = "btnNapDS";
            btnNapDS.Size = new Size(204, 60);
            btnNapDS.TabIndex = 15;
            btnNapDS.Text = "Nạp DS";
            btnNapDS.UseVisualStyleBackColor = false;
            btnNapDS.Click += btnNapDS_Click;
            // 
            // cbbMaLoaiSP
            // 
            cbbMaLoaiSP.Anchor = AnchorStyles.Top;
            cbbMaLoaiSP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbMaLoaiSP.FormattingEnabled = true;
            cbbMaLoaiSP.Location = new Point(920, 293);
            cbbMaLoaiSP.Name = "cbbMaLoaiSP";
            cbbMaLoaiSP.Size = new Size(240, 40);
            cbbMaLoaiSP.TabIndex = 14;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.BackColor = Color.FromArgb(235, 84, 81);
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(860, 410);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(204, 60);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(dgvSP);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1582, 959);
            panel2.TabIndex = 14;
            // 
            // FormQLSP_Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 959);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormQLSP_Admin";
            Text = "FormQLSP_Admin";
            ((System.ComponentModel.ISupportInitialize)dgvSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTOSanPhamBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSP;
        private BindingSource dTOSanPhamBindingSource;
        private Label label1;
        private TextBox txtMaSP;
        private TextBox txtTenSP;
        private Label label2;
        private TextBox txtGiaBan;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox picAnh;
        private Button btnThem;
        private Button btnSua;
        private Panel panel1;
        private DataGridViewTextBoxColumn maSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anhSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maLoaiSPDataGridViewTextBoxColumn;
        private Panel panel2;
        private Button btnXoa;
        private ComboBox cbbMaLoaiSP;
        private Button btnNapDS;
        private Button btnTK;
        private TextBox txtTimKiem;
    }
}