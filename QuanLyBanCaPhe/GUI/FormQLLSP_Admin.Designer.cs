namespace QuanLyBanCaPhe.GUI
{
    partial class FormQLLSP_Admin
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
            label1 = new Label();
            txtMaLSP = new TextBox();
            label2 = new Label();
            txtTenLSP = new TextBox();
            btnNapDS = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnTK = new Button();
            txtTimKiem = new TextBox();
            panel2 = new Panel();
            dgvLSP = new DataGridView();
            dTOLoaiSanPhamBindingSource = new BindingSource(components);
            maLoaiSPDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenLoaiSPDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTOLoaiSanPhamBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMaLSP);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTenLSP);
            panel1.Controls.Add(btnNapDS);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnTK);
            panel1.Controls.Add(txtTimKiem);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1301, 395);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(371, 156);
            label1.Name = "label1";
            label1.Size = new Size(223, 32);
            label1.TabIndex = 24;
            label1.Text = "Mã loại sản phẩm:";
            // 
            // txtMaLSP
            // 
            txtMaLSP.Anchor = AnchorStyles.Top;
            txtMaLSP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaLSP.Location = new Point(613, 153);
            txtMaLSP.Name = "txtMaLSP";
            txtMaLSP.Size = new Size(240, 39);
            txtMaLSP.TabIndex = 25;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(371, 217);
            label2.Name = "label2";
            label2.Size = new Size(227, 32);
            label2.TabIndex = 26;
            label2.Text = "Tên loại sản phẩm:";
            // 
            // txtTenLSP
            // 
            txtTenLSP.Anchor = AnchorStyles.Top;
            txtTenLSP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenLSP.Location = new Point(613, 217);
            txtTenLSP.Name = "txtTenLSP";
            txtTenLSP.Size = new Size(240, 39);
            txtTenLSP.TabIndex = 27;
            // 
            // btnNapDS
            // 
            btnNapDS.Anchor = AnchorStyles.Top;
            btnNapDS.BackColor = Color.FromArgb(235, 136, 10);
            btnNapDS.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNapDS.ForeColor = Color.White;
            btnNapDS.Location = new Point(1033, 314);
            btnNapDS.Name = "btnNapDS";
            btnNapDS.Size = new Size(204, 60);
            btnNapDS.TabIndex = 23;
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
            btnXoa.Location = new Point(734, 314);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(204, 60);
            btnXoa.TabIndex = 22;
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
            btnThem.Location = new Point(63, 314);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(204, 60);
            btnThem.TabIndex = 20;
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
            btnSua.Location = new Point(403, 314);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(204, 60);
            btnSua.TabIndex = 21;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnTK
            // 
            btnTK.Anchor = AnchorStyles.Top;
            btnTK.BackColor = Color.FromArgb(235, 84, 81);
            btnTK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTK.ForeColor = Color.White;
            btnTK.Location = new Point(750, 47);
            btnTK.Name = "btnTK";
            btnTK.Size = new Size(204, 48);
            btnTK.TabIndex = 19;
            btnTK.Text = "Tìm kiếm";
            btnTK.UseVisualStyleBackColor = false;
            btnTK.Click += btnTK_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top;
            txtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(289, 52);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên sản phẩm...";
            txtTimKiem.Size = new Size(442, 39);
            txtTimKiem.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(dgvLSP);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1301, 836);
            panel2.TabIndex = 1;
            // 
            // dgvLSP
            // 
            dgvLSP.AllowUserToAddRows = false;
            dgvLSP.AllowUserToDeleteRows = false;
            dgvLSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dgvLSP.AutoGenerateColumns = false;
            dgvLSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLSP.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLSP.Columns.AddRange(new DataGridViewColumn[] { maLoaiSPDataGridViewTextBoxColumn, tenLoaiSPDataGridViewTextBoxColumn });
            dgvLSP.DataSource = dTOLoaiSanPhamBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLSP.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLSP.EnableHeadersVisualStyles = false;
            dgvLSP.Location = new Point(63, 428);
            dgvLSP.Name = "dgvLSP";
            dgvLSP.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLSP.RowHeadersVisible = false;
            dgvLSP.RowHeadersWidth = 62;
            dgvLSP.RowTemplate.Height = 33;
            dgvLSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLSP.Size = new Size(1174, 382);
            dgvLSP.TabIndex = 0;
            dgvLSP.CellClick += dgvLSP_CellClick;
            // 
            // dTOLoaiSanPhamBindingSource
            // 
            dTOLoaiSanPhamBindingSource.DataSource = typeof(DTO.DTO_LoaiSanPham);
            // 
            // maLoaiSPDataGridViewTextBoxColumn
            // 
            maLoaiSPDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiSP";
            maLoaiSPDataGridViewTextBoxColumn.HeaderText = "Mã loại sản phẩm";
            maLoaiSPDataGridViewTextBoxColumn.MinimumWidth = 8;
            maLoaiSPDataGridViewTextBoxColumn.Name = "maLoaiSPDataGridViewTextBoxColumn";
            maLoaiSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenLoaiSPDataGridViewTextBoxColumn
            // 
            tenLoaiSPDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiSP";
            tenLoaiSPDataGridViewTextBoxColumn.HeaderText = "Tên loại sản phẩm";
            tenLoaiSPDataGridViewTextBoxColumn.MinimumWidth = 8;
            tenLoaiSPDataGridViewTextBoxColumn.Name = "tenLoaiSPDataGridViewTextBoxColumn";
            tenLoaiSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormQLLSP_Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 836);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormQLLSP_Admin";
            Text = "FormQLLSP_Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTOLoaiSanPhamBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnTK;
        private TextBox txtTimKiem;
        private Button btnNapDS;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
        private Label label1;
        private TextBox txtMaLSP;
        private Label label2;
        private TextBox txtTenLSP;
        private DataGridView dgvLSP;
        private BindingSource dTOLoaiSanPhamBindingSource;
        private DataGridViewTextBoxColumn maLoaiSPDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenLoaiSPDataGridViewTextBoxColumn;
    }
}