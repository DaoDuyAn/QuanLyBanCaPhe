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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            CategoryPanel = new Panel();
            dTOLoaiSanPhamBindingSource = new BindingSource(components);
            ProductPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            lblTongTien = new Label();
            numTongTien = new NumericUpDown();
            button1 = new Button();
            cbbPTTT = new ComboBox();
            label5 = new Label();
            numCanTra = new NumericUpDown();
            lblCanTra = new Label();
            numKhachDua = new NumericUpDown();
            lblKhachDua = new Label();
            numTongSL = new NumericUpDown();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dTOLoaiSanPhamBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTongTien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCanTra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numKhachDua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTongSL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1134, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(871, 915);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(lblTongTien);
            panel2.Controls.Add(numTongTien);
            panel2.Controls.Add(button1);
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
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(235, 84, 81);
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(389, 322);
            button2.Name = "button2";
            button2.Size = new Size(219, 63);
            button2.TabIndex = 12;
            button2.Text = "In hóa đơn";
            button2.UseVisualStyleBackColor = false;
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
            numTongTien.Name = "numTongTien";
            numTongTien.Size = new Size(303, 45);
            numTongTien.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(50, 121, 240);
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(32, 322);
            button1.Name = "button1";
            button1.Size = new Size(219, 63);
            button1.TabIndex = 11;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = false;
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
            numCanTra.Name = "numCanTra";
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
            numKhachDua.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            numKhachDua.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numKhachDua.Location = new Point(390, 152);
            numKhachDua.Name = "numKhachDua";
            numKhachDua.Size = new Size(305, 45);
            numKhachDua.TabIndex = 6;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(81, 154, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(871, 915);
            dataGridView1.TabIndex = 0;
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
            // Column1
            // 
            Column1.HeaderText = "STT";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "ID";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tên SP";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Số lượng";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Giá";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "#";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel CategoryPanel;
        private BindingSource dTOLoaiSanPhamBindingSource;
        private FlowLayoutPanel ProductPanel;
        private Panel panel1;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private DataGridView dataGridView1;
        private ComboBox cbbPTTT;
        private Label label5;
        private NumericUpDown numCanTra;
        private Label lblCanTra;
        private NumericUpDown numKhachDua;
        private Label lblKhachDua;
        private NumericUpDown numTongSL;
        private Label label2;
        private NumericUpDown numTongTien;
        private Label lblTongTien;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}