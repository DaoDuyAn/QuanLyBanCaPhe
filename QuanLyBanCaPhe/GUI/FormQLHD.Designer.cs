namespace QuanLyBanCaPhe.GUI
{
    partial class FormQLHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLHD));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            dgvHD = new DataGridView();
            dgvMaHD = new DataGridViewTextBoxColumn();
            ngayLapDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maNhanVienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvChiTiet = new DataGridViewImageColumn();
            dTOHoaDonBindingSource = new BindingSource(components);
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            lblTongTien = new Label();
            lblMaHD = new Label();
            label2 = new Label();
            dgvCTHD = new DataGridView();
            maHoaDonDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            maSanPhamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dgvSL = new DataGridViewTextBoxColumn();
            dgvGia = new DataGridViewTextBoxColumn();
            dTOChiTietHoaDonBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvHD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTOHoaDonBindingSource).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTOChiTietHoaDonBindingSource).BeginInit();
            SuspendLayout();
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
            dgvHD.Location = new Point(74, 81);
            dgvHD.Name = "dgvHD";
            dgvHD.ReadOnly = true;
            dgvHD.RowHeadersVisible = false;
            dgvHD.RowHeadersWidth = 62;
            dgvHD.Size = new Size(1450, 455);
            dgvHD.TabIndex = 0;
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
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dgvHD);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1600, 542);
            panel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(567, 19);
            label1.Name = "label1";
            label1.Size = new Size(414, 48);
            label1.TabIndex = 1;
            label1.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lblTongTien);
            panel3.Controls.Add(lblMaHD);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dgvCTHD);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 542);
            panel3.Name = "panel3";
            panel3.Size = new Size(1600, 462);
            panel3.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(74, 87);
            label3.Name = "label3";
            label3.Size = new Size(151, 38);
            label3.TabIndex = 10;
            label3.Text = "Tổng tiền:";
            // 
            // lblTongTien
            // 
            lblTongTien.Anchor = AnchorStyles.Top;
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongTien.Location = new Point(231, 87);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(0, 38);
            lblTongTien.TabIndex = 9;
            // 
            // lblMaHD
            // 
            lblMaHD.Anchor = AnchorStyles.Top;
            lblMaHD.AutoSize = true;
            lblMaHD.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaHD.Location = new Point(928, 31);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(0, 48);
            lblMaHD.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(567, 31);
            label2.Name = "label2";
            label2.Size = new Size(355, 48);
            label2.TabIndex = 2;
            label2.Text = "CHI TIẾT HÓA ĐƠN:";
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
            dgvCTHD.Columns.AddRange(new DataGridViewColumn[] { maHoaDonDataGridViewTextBoxColumn1, maSanPhamDataGridViewTextBoxColumn, dgvSL, dgvGia });
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
            dgvCTHD.Location = new Point(74, 149);
            dgvCTHD.Name = "dgvCTHD";
            dgvCTHD.ReadOnly = true;
            dgvCTHD.RowHeadersVisible = false;
            dgvCTHD.RowHeadersWidth = 62;
            dgvCTHD.RowTemplate.Height = 33;
            dgvCTHD.Size = new Size(1450, 301);
            dgvCTHD.TabIndex = 0;
            // 
            // maHoaDonDataGridViewTextBoxColumn1
            // 
            maHoaDonDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maHoaDonDataGridViewTextBoxColumn1.DataPropertyName = "MaHoaDon";
            maHoaDonDataGridViewTextBoxColumn1.HeaderText = "Mã hóa đơn";
            maHoaDonDataGridViewTextBoxColumn1.MinimumWidth = 8;
            maHoaDonDataGridViewTextBoxColumn1.Name = "maHoaDonDataGridViewTextBoxColumn1";
            maHoaDonDataGridViewTextBoxColumn1.ReadOnly = true;
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
            // dgvSL
            // 
            dgvSL.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSL.DataPropertyName = "SoLuong";
            dgvSL.HeaderText = "Số lượng";
            dgvSL.MinimumWidth = 8;
            dgvSL.Name = "dgvSL";
            dgvSL.ReadOnly = true;
            // 
            // dgvGia
            // 
            dgvGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGia.DataPropertyName = "DonGia";
            dgvGia.HeaderText = "Đơn giá";
            dgvGia.MinimumWidth = 8;
            dgvGia.Name = "dgvGia";
            dgvGia.ReadOnly = true;
            // 
            // dTOChiTietHoaDonBindingSource
            // 
            dTOChiTietHoaDonBindingSource.DataSource = typeof(DTO.DTO_ChiTietHoaDon);
            // 
            // FormQLHD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 1004);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "FormQLHD";
            Text = "FormQLHD";
            ((System.ComponentModel.ISupportInitialize)dgvHD).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTOHoaDonBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTOChiTietHoaDonBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHD;
        private BindingSource dTOHoaDonBindingSource;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private DataGridView dgvCTHD;
        private BindingSource dTOChiTietHoaDonBindingSource;
        private DataGridViewTextBoxColumn dgvMaHD;
        private DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private DataGridViewImageColumn dgvChiTiet;
        private Label label2;
        private Label lblMaHD;
        private Label lblTongTien;
        private Label label3;
        private DataGridViewTextBoxColumn maHoaDonDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn maSanPhamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dgvSL;
        private DataGridViewTextBoxColumn dgvGia;
    }
}