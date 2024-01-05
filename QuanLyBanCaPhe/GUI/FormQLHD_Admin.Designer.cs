namespace QuanLyBanCaPhe.GUI
{
    partial class FormQLHD_Admin
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLHD_Admin));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dgvHD = new DataGridView();
            dgvMaHD = new DataGridViewTextBoxColumn();
            ngayLapDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maNhanVienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvChiTiet = new DataGridViewImageColumn();
            dTOHoaDonBindingSource = new BindingSource(components);
            label1 = new Label();
            lblMaHD = new Label();
            panel2 = new Panel();
            lblTongTien = new Label();
            label2 = new Label();
            dgvCTHD = new DataGridView();
            dTOChiTietHoaDonBindingSource = new BindingSource(components);
            label3 = new Label();
            maHoaDonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maSanPhamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvSL = new DataGridViewTextBoxColumn();
            dgvGia = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTOHoaDonBindingSource).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTOChiTietHoaDonBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvHD);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1428, 502);
            panel1.TabIndex = 0;
            // 
            // dgvHD
            // 
            dgvHD.AllowUserToAddRows = false;
            dgvHD.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHD.Anchor = AnchorStyles.Top;
            dgvHD.AutoGenerateColumns = false;
            dgvHD.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHD.Columns.AddRange(new DataGridViewColumn[] { dgvMaHD, ngayLapDataGridViewTextBoxColumn, maNhanVienDataGridViewTextBoxColumn, dgvChiTiet });
            dgvHD.DataSource = dTOHoaDonBindingSource;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvHD.DefaultCellStyle = dataGridViewCellStyle4;
            dgvHD.EnableHeadersVisualStyles = false;
            dgvHD.Location = new Point(118, 113);
            dgvHD.Name = "dgvHD";
            dgvHD.ReadOnly = true;
            dgvHD.RowHeadersVisible = false;
            dgvHD.RowHeadersWidth = 62;
            dgvHD.Size = new Size(1208, 362);
            dgvHD.TabIndex = 3;
            dgvHD.CellClick += dgvHD_CellClick;
            // 
            // dgvMaHD
            // 
            dgvMaHD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMaHD.DataPropertyName = "MaHoaDon";
            dgvMaHD.HeaderText = "Mã hóa đơn";
            dgvMaHD.MinimumWidth = 8;
            dgvMaHD.Name = "dgvMaHD";
            dgvMaHD.ReadOnly = true;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            ngayLapDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            ngayLapDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            ngayLapDataGridViewTextBoxColumn.HeaderText = "Ngày lập";
            ngayLapDataGridViewTextBoxColumn.MinimumWidth = 8;
            ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            ngayLapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            maNhanVienDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            maNhanVienDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            maNhanVienDataGridViewTextBoxColumn.MinimumWidth = 8;
            maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            maNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvChiTiet.HeaderText = "Chi tiết";
            dgvChiTiet.Image = (Image)resources.GetObject("dgvChiTiet.Image");
            dgvChiTiet.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvChiTiet.MinimumWidth = 8;
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.ReadOnly = true;
            // 
            // dTOHoaDonBindingSource
            // 
            dTOHoaDonBindingSource.DataSource = typeof(DTO.DTO_HoaDon);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(489, 32);
            label1.Name = "label1";
            label1.Size = new Size(414, 48);
            label1.TabIndex = 2;
            label1.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // lblMaHD
            // 
            lblMaHD.Anchor = AnchorStyles.Top;
            lblMaHD.AutoSize = true;
            lblMaHD.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaHD.Location = new Point(816, 52);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(0, 48);
            lblMaHD.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTongTien);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dgvCTHD);
            panel2.Controls.Add(lblMaHD);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 502);
            panel2.Name = "panel2";
            panel2.Size = new Size(1428, 527);
            panel2.TabIndex = 1;
            // 
            // lblTongTien
            // 
            lblTongTien.Anchor = AnchorStyles.Top;
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongTien.Location = new Point(289, 126);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(0, 38);
            lblTongTien.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(118, 126);
            label2.Name = "label2";
            label2.Size = new Size(151, 38);
            label2.TabIndex = 7;
            label2.Text = "Tổng tiền:";
            // 
            // dgvCTHD
            // 
            dgvCTHD.AllowUserToAddRows = false;
            dgvCTHD.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dgvCTHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvCTHD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dgvCTHD.AutoGenerateColumns = false;
            dgvCTHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTHD.BackgroundColor = Color.White;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvCTHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTHD.Columns.AddRange(new DataGridViewColumn[] { maHoaDonDataGridViewTextBoxColumn, maSanPhamDataGridViewTextBoxColumn, dgvSL, dgvGia });
            dgvCTHD.DataSource = dTOChiTietHoaDonBindingSource;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvCTHD.DefaultCellStyle = dataGridViewCellStyle7;
            dgvCTHD.EnableHeadersVisualStyles = false;
            dgvCTHD.Location = new Point(118, 194);
            dgvCTHD.Name = "dgvCTHD";
            dgvCTHD.ReadOnly = true;
            dgvCTHD.RowHeadersVisible = false;
            dgvCTHD.RowHeadersWidth = 62;
            dgvCTHD.RowTemplate.Height = 33;
            dgvCTHD.Size = new Size(1208, 300);
            dgvCTHD.TabIndex = 6;
            // 
            // dTOChiTietHoaDonBindingSource
            // 
            dTOChiTietHoaDonBindingSource.DataSource = typeof(DTO.DTO_ChiTietHoaDon);
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(455, 52);
            label3.Name = "label3";
            label3.Size = new Size(355, 48);
            label3.TabIndex = 5;
            label3.Text = "CHI TIẾT HÓA ĐƠN:";
            // 
            // maHoaDonDataGridViewTextBoxColumn
            // 
            maHoaDonDataGridViewTextBoxColumn.DataPropertyName = "MaHoaDon";
            maHoaDonDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            maHoaDonDataGridViewTextBoxColumn.MinimumWidth = 8;
            maHoaDonDataGridViewTextBoxColumn.Name = "maHoaDonDataGridViewTextBoxColumn";
            maHoaDonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maSanPhamDataGridViewTextBoxColumn
            // 
            maSanPhamDataGridViewTextBoxColumn.DataPropertyName = "MaSanPham";
            maSanPhamDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            maSanPhamDataGridViewTextBoxColumn.MinimumWidth = 8;
            maSanPhamDataGridViewTextBoxColumn.Name = "maSanPhamDataGridViewTextBoxColumn";
            maSanPhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgvSL
            // 
            dgvSL.DataPropertyName = "SoLuong";
            dgvSL.HeaderText = "Số lượng";
            dgvSL.MinimumWidth = 8;
            dgvSL.Name = "dgvSL";
            dgvSL.ReadOnly = true;
            // 
            // dgvGia
            // 
            dgvGia.DataPropertyName = "DonGia";
            dgvGia.HeaderText = "Đơn giá";
            dgvGia.MinimumWidth = 8;
            dgvGia.Name = "dgvGia";
            dgvGia.ReadOnly = true;
            // 
            // FormQLHD_Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 1029);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormQLHD_Admin";
            Text = "FormQLHD_Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHD).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTOHoaDonBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTOChiTietHoaDonBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private BindingSource dTOHoaDonBindingSource;
        private DataGridView dgvHD;
        private DataGridViewTextBoxColumn dgvMaHD;
        private DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private DataGridViewImageColumn dgvChiTiet;
        private Label lblMaHD;
        private Label label3;
        private DataGridView dgvCTHD;
        private BindingSource dTOChiTietHoaDonBindingSource;
        private Label label2;
        private Label lblTongTien;
        private DataGridViewTextBoxColumn maHoaDonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dgvSL;
        private DataGridViewTextBoxColumn dgvGia;
    }
}