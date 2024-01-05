namespace QuanLyBanCaPhe
{
    partial class FormBanHang
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanHang));
            CategoryPanel = new Panel();
            dTOLoaiSanPhamBindingSource = new BindingSource(components);
            ProductPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            btnIn = new Button();
            lblTongTien = new Label();
            numTongTien = new NumericUpDown();
            btnLuu = new Button();
            cbbPTTT = new ComboBox();
            label5 = new Label();
            numCanTra = new NumericUpDown();
            lblCanTra = new Label();
            numKhachDua = new NumericUpDown();
            lblKhachDua = new Label();
            numTongSL = new NumericUpDown();
            label2 = new Label();
            dgvGioHang = new DataGridView();
            dgvSTT = new DataGridViewTextBoxColumn();
            dgvID = new DataGridViewTextBoxColumn();
            dgvTenSP = new DataGridViewTextBoxColumn();
            dgvGia = new DataGridViewTextBoxColumn();
            dgvSL = new DataGridViewTextBoxColumn();
            dgvTang = new DataGridViewImageColumn();
            dgvGiam = new DataGridViewImageColumn();
            dgvXoa = new DataGridViewImageColumn();
            iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            ((System.ComponentModel.ISupportInitialize)dTOLoaiSanPhamBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTongTien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCanTra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numKhachDua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTongSL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            SuspendLayout();
            // 
            // CategoryPanel
            // 
            CategoryPanel.Location = new Point(83, 75);
            CategoryPanel.Name = "CategoryPanel";
            CategoryPanel.Size = new Size(1045, 73);
            CategoryPanel.TabIndex = 3;
            // 
            // dTOLoaiSanPhamBindingSource
            // 
            dTOLoaiSanPhamBindingSource.DataSource = typeof(DTO.DTO_LoaiSanPham);
            // 
            // ProductPanel
            // 
            ProductPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductPanel.AutoScroll = true;
            ProductPanel.Location = new Point(12, 154);
            ProductPanel.Name = "ProductPanel";
            ProductPanel.Size = new Size(1116, 761);
            ProductPanel.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvGioHang);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1134, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(871, 915);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnIn);
            panel2.Controls.Add(lblTongTien);
            panel2.Controls.Add(numTongTien);
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(cbbPTTT);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(numCanTra);
            panel2.Controls.Add(lblCanTra);
            panel2.Controls.Add(numKhachDua);
            panel2.Controls.Add(lblKhachDua);
            panel2.Controls.Add(numTongSL);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 505);
            panel2.Name = "panel2";
            panel2.Size = new Size(871, 410);
            panel2.TabIndex = 13;
            // 
            // btnIn
            // 
            btnIn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnIn.BackColor = Color.FromArgb(235, 84, 81);
            btnIn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnIn.ForeColor = Color.White;
            btnIn.Location = new Point(389, 322);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(219, 63);
            btnIn.TabIndex = 12;
            btnIn.Text = "In hóa đơn";
            btnIn.UseVisualStyleBackColor = false;
            // 
            // lblTongTien
            // 
            lblTongTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongTien.Location = new Point(27, 51);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(151, 38);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "Tổng tiền:";
            // 
            // numTongTien
            // 
            numTongTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numTongTien.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numTongTien.Location = new Point(392, 51);
            numTongTien.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numTongTien.Name = "numTongTien";
            numTongTien.Size = new Size(303, 45);
            numTongTien.TabIndex = 2;
            numTongTien.UseWaitCursor = true;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLuu.BackColor = Color.FromArgb(50, 121, 240);
            btnLuu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(32, 322);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(219, 63);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // cbbPTTT
            // 
            cbbPTTT.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cbbPTTT.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbPTTT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbbPTTT.FormattingEnabled = true;
            cbbPTTT.Items.AddRange(new object[] { "Tiền mặt", "Thẻ tín dụng" });
            cbbPTTT.Location = new Point(389, 259);
            cbbPTTT.Name = "cbbPTTT";
            cbbPTTT.Size = new Size(308, 46);
            cbbPTTT.TabIndex = 10;
            cbbPTTT.SelectedIndexChanged += cbbPTTT_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 261);
            label5.Name = "label5";
            label5.Size = new Size(351, 38);
            label5.TabIndex = 9;
            label5.Text = "Phương thức thanh toán:";
            // 
            // numCanTra
            // 
            numCanTra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numCanTra.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numCanTra.Location = new Point(390, 205);
            numCanTra.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            numCanTra.Minimum = new decimal(new int[] { -727379969, 232, 0, int.MinValue });
            numCanTra.Name = "numCanTra";
            numCanTra.ReadOnly = true;
            numCanTra.Size = new Size(305, 45);
            numCanTra.TabIndex = 8;
            // 
            // lblCanTra
            // 
            lblCanTra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCanTra.AutoSize = true;
            lblCanTra.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblCanTra.Location = new Point(27, 205);
            lblCanTra.Name = "lblCanTra";
            lblCanTra.Size = new Size(215, 38);
            lblCanTra.TabIndex = 7;
            lblCanTra.Text = "Số tiền cần trả:";
            // 
            // numKhachDua
            // 
            numKhachDua.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numKhachDua.Location = new Point(390, 152);
            numKhachDua.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numKhachDua.Name = "numKhachDua";
            numKhachDua.Size = new Size(305, 45);
            numKhachDua.TabIndex = 6;
            numKhachDua.KeyDown += numKhachDua_KeyDown;
            // 
            // lblKhachDua
            // 
            lblKhachDua.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblKhachDua.AutoSize = true;
            lblKhachDua.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblKhachDua.Location = new Point(27, 152);
            lblKhachDua.Name = "lblKhachDua";
            lblKhachDua.Size = new Size(263, 38);
            lblKhachDua.TabIndex = 5;
            lblKhachDua.Text = "Số tiền khách đưa:";
            // 
            // numTongSL
            // 
            numTongSL.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numTongSL.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numTongSL.Location = new Point(390, 102);
            numTongSL.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numTongSL.Name = "numTongSL";
            numTongSL.Size = new Size(305, 45);
            numTongSL.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 102);
            label2.Name = "label2";
            label2.Size = new Size(216, 38);
            label2.TabIndex = 3;
            label2.Text = "Tổng số lượng:";
            // 
            // dgvGioHang
            // 
            dgvGioHang.AllowUserToAddRows = false;
            dgvGioHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvGioHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGioHang.BackgroundColor = Color.White;
            dgvGioHang.BorderStyle = BorderStyle.None;
            dgvGioHang.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvGioHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGioHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGioHang.ColumnHeadersHeight = 50;
            dgvGioHang.Columns.AddRange(new DataGridViewColumn[] { dgvSTT, dgvID, dgvTenSP, dgvGia, dgvSL, dgvTang, dgvGiam, dgvXoa });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvGioHang.DefaultCellStyle = dataGridViewCellStyle4;
            dgvGioHang.Dock = DockStyle.Fill;
            dgvGioHang.EnableHeadersVisualStyles = false;
            dgvGioHang.Location = new Point(0, 0);
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.ReadOnly = true;
            dgvGioHang.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvGioHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvGioHang.RowHeadersVisible = false;
            dgvGioHang.RowHeadersWidth = 62;
            dgvGioHang.RowTemplate.Height = 50;
            dgvGioHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGioHang.Size = new Size(871, 915);
            dgvGioHang.TabIndex = 0;
            dgvGioHang.CellClick += dgvGioHang_CellClick;
            dgvGioHang.CellFormatting += dgvGioHang_CellFormatting;
            // 
            // dgvSTT
            // 
            dgvSTT.FillWeight = 63.63634F;
            dgvSTT.HeaderText = "STT";
            dgvSTT.MinimumWidth = 8;
            dgvSTT.Name = "dgvSTT";
            dgvSTT.ReadOnly = true;
            // 
            // dgvID
            // 
            dgvID.FillWeight = 61.8998528F;
            dgvID.HeaderText = "ID";
            dgvID.MinimumWidth = 8;
            dgvID.Name = "dgvID";
            dgvID.ReadOnly = true;
            // 
            // dgvTenSP
            // 
            dgvTenSP.FillWeight = 215.023224F;
            dgvTenSP.HeaderText = "Tên SP";
            dgvTenSP.MinimumWidth = 8;
            dgvTenSP.Name = "dgvTenSP";
            dgvTenSP.ReadOnly = true;
            // 
            // dgvGia
            // 
            dgvGia.FillWeight = 155.206375F;
            dgvGia.HeaderText = "Giá";
            dgvGia.MinimumWidth = 8;
            dgvGia.Name = "dgvGia";
            dgvGia.ReadOnly = true;
            // 
            // dgvSL
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "1";
            dgvSL.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSL.FillWeight = 125.919884F;
            dgvSL.HeaderText = "Số lượng";
            dgvSL.MinimumWidth = 8;
            dgvSL.Name = "dgvSL";
            dgvSL.ReadOnly = true;
            // 
            // dgvTang
            // 
            dgvTang.FillWeight = 55.3187675F;
            dgvTang.HeaderText = "T";
            dgvTang.Image = (Image)resources.GetObject("dgvTang.Image");
            dgvTang.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvTang.MinimumWidth = 8;
            dgvTang.Name = "dgvTang";
            dgvTang.ReadOnly = true;
            // 
            // dgvGiam
            // 
            dgvGiam.FillWeight = 51.1113739F;
            dgvGiam.HeaderText = "G";
            dgvGiam.Image = (Image)resources.GetObject("dgvGiam.Image");
            dgvGiam.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvGiam.MinimumWidth = 8;
            dgvGiam.Name = "dgvGiam";
            dgvGiam.ReadOnly = true;
            // 
            // dgvXoa
            // 
            dgvXoa.FillWeight = 71.88393F;
            dgvXoa.HeaderText = "#";
            dgvXoa.Image = (Image)resources.GetObject("dgvXoa.Image");
            dgvXoa.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvXoa.MinimumWidth = 8;
            dgvXoa.Name = "dgvXoa";
            dgvXoa.ReadOnly = true;
            dgvXoa.Resizable = DataGridViewTriState.True;
            dgvXoa.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // iconSplitButton1
            // 
            iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSplitButton1.IconColor = Color.Black;
            iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSplitButton1.IconSize = 48;
            iconSplitButton1.Name = "iconSplitButton1";
            iconSplitButton1.Rotation = 0D;
            iconSplitButton1.Size = new Size(23, 23);
            iconSplitButton1.Text = "iconSplitButton1";
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2005, 915);
            Controls.Add(panel1);
            Controls.Add(ProductPanel);
            Controls.Add(CategoryPanel);
            Name = "FormBanHang";
            Text = "FormBanHang";
            ((System.ComponentModel.ISupportInitialize)dTOLoaiSanPhamBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTongTien).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCanTra).EndInit();
            ((System.ComponentModel.ISupportInitialize)numKhachDua).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTongSL).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel CategoryPanel;
        private BindingSource dTOLoaiSanPhamBindingSource;
        private FlowLayoutPanel ProductPanel;
        private Panel panel1;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private DataGridView dgvGioHang;
        private ComboBox cbbPTTT;
        private Label label5;
        private NumericUpDown numCanTra;
        private Label lblCanTra;
        private Label lblKhachDua;
        private NumericUpDown numTongSL;
        private Label label2;
        private NumericUpDown numTongTien;
        private Label lblTongTien;
        private Button btnIn;
        private Button btnLuu;
        private Panel panel2;
        private DataGridViewTextBoxColumn dgvSTT;
        private DataGridViewTextBoxColumn dgvID;
        private DataGridViewTextBoxColumn dgvTenSP;
        private DataGridViewTextBoxColumn dgvGia;
        private DataGridViewTextBoxColumn dgvSL;
        private DataGridViewImageColumn dgvTang;
        private DataGridViewImageColumn dgvGiam;
        private DataGridViewImageColumn dgvXoa;
        private NumericUpDown numKhachDua;
    }
}