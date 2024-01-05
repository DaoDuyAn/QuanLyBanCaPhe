namespace QuanLyBanCaPhe.GUI
{
    partial class FormQLCV_Admin
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
            txtMaCV = new TextBox();
            label2 = new Label();
            txtTenCV = new TextBox();
            btnNapDS = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnTK = new Button();
            txtTimKiem = new TextBox();
            panel2 = new Panel();
            dgvCV = new DataGridView();
            maChucVuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenChucVuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dTOChucVuBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTOChucVuBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMaCV);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTenCV);
            panel1.Controls.Add(btnNapDS);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnTK);
            panel1.Controls.Add(txtTimKiem);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1485, 424);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(468, 167);
            label1.Name = "label1";
            label1.Size = new Size(153, 32);
            label1.TabIndex = 28;
            label1.Text = "Mã chức vụ:";
            // 
            // txtMaCV
            // 
            txtMaCV.Anchor = AnchorStyles.Top;
            txtMaCV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaCV.Location = new Point(710, 164);
            txtMaCV.Name = "txtMaCV";
            txtMaCV.Size = new Size(240, 39);
            txtMaCV.TabIndex = 29;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(468, 228);
            label2.Name = "label2";
            label2.Size = new Size(157, 32);
            label2.TabIndex = 30;
            label2.Text = "Tên chức vụ:";
            // 
            // txtTenCV
            // 
            txtTenCV.Anchor = AnchorStyles.Top;
            txtTenCV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenCV.Location = new Point(710, 228);
            txtTenCV.Name = "txtTenCV";
            txtTenCV.Size = new Size(240, 39);
            txtTenCV.TabIndex = 31;
            // 
            // btnNapDS
            // 
            btnNapDS.Anchor = AnchorStyles.Top;
            btnNapDS.BackColor = Color.FromArgb(235, 136, 10);
            btnNapDS.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNapDS.ForeColor = Color.White;
            btnNapDS.Location = new Point(1117, 335);
            btnNapDS.Name = "btnNapDS";
            btnNapDS.Size = new Size(204, 60);
            btnNapDS.TabIndex = 27;
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
            btnXoa.Location = new Point(818, 335);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(204, 60);
            btnXoa.TabIndex = 26;
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
            btnThem.Location = new Point(147, 335);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(204, 60);
            btnThem.TabIndex = 24;
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
            btnSua.Location = new Point(487, 335);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(204, 60);
            btnSua.TabIndex = 25;
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
            btnTK.Location = new Point(853, 47);
            btnTK.Name = "btnTK";
            btnTK.Size = new Size(183, 48);
            btnTK.TabIndex = 23;
            btnTK.Text = "Tìm kiếm";
            btnTK.UseVisualStyleBackColor = false;
            btnTK.Click += btnTK_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top;
            txtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(392, 52);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên hoặc mã chức vụ..";
            txtTimKiem.Size = new Size(442, 39);
            txtTimKiem.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(dgvCV);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 424);
            panel2.Name = "panel2";
            panel2.Size = new Size(1485, 433);
            panel2.TabIndex = 1;
            // 
            // dgvCV
            // 
            dgvCV.AllowUserToAddRows = false;
            dgvCV.AllowUserToDeleteRows = false;
            dgvCV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dgvCV.AutoGenerateColumns = false;
            dgvCV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCV.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCV.Columns.AddRange(new DataGridViewColumn[] { maChucVuDataGridViewTextBoxColumn, tenChucVuDataGridViewTextBoxColumn });
            dgvCV.DataSource = dTOChucVuBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCV.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCV.EnableHeadersVisualStyles = false;
            dgvCV.Location = new Point(275, 37);
            dgvCV.Name = "dgvCV";
            dgvCV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCV.RowHeadersVisible = false;
            dgvCV.RowHeadersWidth = 62;
            dgvCV.RowTemplate.Height = 33;
            dgvCV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCV.Size = new Size(991, 362);
            dgvCV.TabIndex = 0;
            dgvCV.CellClick += dgvCV_CellClick;
            // 
            // maChucVuDataGridViewTextBoxColumn
            // 
            maChucVuDataGridViewTextBoxColumn.DataPropertyName = "MaChucVu";
            maChucVuDataGridViewTextBoxColumn.HeaderText = "Mã chức vụ";
            maChucVuDataGridViewTextBoxColumn.MinimumWidth = 8;
            maChucVuDataGridViewTextBoxColumn.Name = "maChucVuDataGridViewTextBoxColumn";
            maChucVuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenChucVuDataGridViewTextBoxColumn
            // 
            tenChucVuDataGridViewTextBoxColumn.DataPropertyName = "TenChucVu";
            tenChucVuDataGridViewTextBoxColumn.HeaderText = "Tên chức vụ";
            tenChucVuDataGridViewTextBoxColumn.MinimumWidth = 8;
            tenChucVuDataGridViewTextBoxColumn.Name = "tenChucVuDataGridViewTextBoxColumn";
            tenChucVuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTOChucVuBindingSource
            // 
            dTOChucVuBindingSource.DataSource = typeof(DTO.DTO_ChucVu);
            // 
            // FormQLCV_Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1485, 857);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormQLCV_Admin";
            Text = "FormQLCV_Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTOChucVuBindingSource).EndInit();
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
        private TextBox txtMaCV;
        private Label label2;
        private TextBox txtTenCV;
        private DataGridView dgvCV;
        private DataGridViewTextBoxColumn maChucVuDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenChucVuDataGridViewTextBoxColumn;
        private BindingSource dTOChucVuBindingSource;
    }
}