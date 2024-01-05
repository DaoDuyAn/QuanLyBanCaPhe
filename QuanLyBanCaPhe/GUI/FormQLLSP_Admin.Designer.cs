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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            btnTK = new Button();
            txtTimKiem = new TextBox();
            btnNapDS = new Button();
            btnXoa = new Button();
            label1 = new Label();
            txtMaSP = new TextBox();
            label2 = new Label();
            txtTenSP = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
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
            panel1.Controls.Add(btnTK);
            panel1.Controls.Add(txtTimKiem);
            panel1.Controls.Add(btnNapDS);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMaSP);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTenSP);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnSua);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1380, 347);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvLSP);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 347);
            panel2.Name = "panel2";
            panel2.Size = new Size(1380, 463);
            panel2.TabIndex = 1;
            // 
            // btnTK
            // 
            btnTK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTK.BackColor = Color.FromArgb(235, 84, 81);
            btnTK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTK.ForeColor = Color.White;
            btnTK.Location = new Point(852, 29);
            btnTK.Name = "btnTK";
            btnTK.Size = new Size(204, 48);
            btnTK.TabIndex = 27;
            btnTK.Text = "Tìm kiếm";
            btnTK.UseVisualStyleBackColor = false;
            btnTK.Click += btnTK_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top;
            txtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(376, 34);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên loại sản phẩm...";
            txtTimKiem.Size = new Size(442, 39);
            txtTimKiem.TabIndex = 26;
            // 
            // btnNapDS
            // 
            btnNapDS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNapDS.BackColor = Color.FromArgb(235, 136, 10);
            btnNapDS.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNapDS.ForeColor = Color.White;
            btnNapDS.Location = new Point(1091, 271);
            btnNapDS.Name = "btnNapDS";
            btnNapDS.Size = new Size(204, 60);
            btnNapDS.TabIndex = 25;
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
            btnXoa.Location = new Point(792, 271);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(204, 60);
            btnXoa.TabIndex = 24;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(396, 131);
            label1.Name = "label1";
            label1.Size = new Size(223, 32);
            label1.TabIndex = 18;
            label1.Text = "Mã loại sản phẩm:";
            // 
            // txtMaSP
            // 
            txtMaSP.Anchor = AnchorStyles.Top;
            txtMaSP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaSP.Location = new Point(682, 124);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(240, 39);
            txtMaSP.TabIndex = 19;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(392, 192);
            label2.Name = "label2";
            label2.Size = new Size(227, 32);
            label2.TabIndex = 20;
            label2.Text = "Tên loại sản phẩm:";
            // 
            // txtTenSP
            // 
            txtTenSP.Anchor = AnchorStyles.Top;
            txtTenSP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenSP.Location = new Point(682, 185);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(240, 39);
            txtTenSP.TabIndex = 21;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.BackColor = Color.FromArgb(50, 121, 240);
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(121, 271);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(204, 60);
            btnThem.TabIndex = 22;
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
            btnSua.Location = new Point(461, 271);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(204, 60);
            btnSua.TabIndex = 23;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // dgvSP
            // 
            dgvLSP.AllowUserToAddRows = false;
            dgvLSP.AllowUserToDeleteRows = false;
            dgvLSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dgvLSP.AutoGenerateColumns = false;
            dgvLSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLSP.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLSP.Columns.AddRange(new DataGridViewColumn[] { maLoaiSPDataGridViewTextBoxColumn, tenLoaiSPDataGridViewTextBoxColumn });
            dgvLSP.DataSource = dTOLoaiSanPhamBindingSource;
            dgvLSP.EnableHeadersVisualStyles = false;
            dgvLSP.Location = new Point(134, 107);
            dgvLSP.Name = "dgvLSP";
            dgvLSP.ReadOnly = true;
            dgvLSP.RowHeadersWidth = 62;
            dgvLSP.RowTemplate.Height = 33;
            dgvLSP.Size = new Size(1104, 276);
            dgvLSP.TabIndex = 1;
            // 
            // dTOLoaiSanPhamBindingSource
            // 
            dTOLoaiSanPhamBindingSource.DataSource = typeof(DTO.DTO_LoaiSanPham);
            // 
            // maLoaiSPDataGridViewTextBoxColumn
            // 
            maLoaiSPDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiSP";
            maLoaiSPDataGridViewTextBoxColumn.HeaderText = "MaLoaiSP";
            maLoaiSPDataGridViewTextBoxColumn.MinimumWidth = 8;
            maLoaiSPDataGridViewTextBoxColumn.Name = "maLoaiSPDataGridViewTextBoxColumn";
            maLoaiSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenLoaiSPDataGridViewTextBoxColumn
            // 
            tenLoaiSPDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiSP";
            tenLoaiSPDataGridViewTextBoxColumn.HeaderText = "TenLoaiSP";
            tenLoaiSPDataGridViewTextBoxColumn.MinimumWidth = 8;
            tenLoaiSPDataGridViewTextBoxColumn.Name = "tenLoaiSPDataGridViewTextBoxColumn";
            tenLoaiSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormQLLSP
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 810);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormQLLSP";
            Text = "FormQLLSP";
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
        private Label label1;
        private TextBox txtMaSP;
        private Label label2;
        private TextBox txtTenSP;
        private Button btnThem;
        private Button btnSua;
        private DataGridView dgvLSP;
        private DataGridViewTextBoxColumn maLoaiSPDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenLoaiSPDataGridViewTextBoxColumn;
        private BindingSource dTOLoaiSanPhamBindingSource;
    }
}