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
            dgvHD = new DataGridView();
            maHoaDonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngayLapDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maNhanVienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dTOHoaDonBindingSource = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTOHoaDonBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvHD
            // 
            dgvHD.AutoGenerateColumns = false;
            dgvHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHD.Columns.AddRange(new DataGridViewColumn[] { maHoaDonDataGridViewTextBoxColumn, ngayLapDataGridViewTextBoxColumn, maNhanVienDataGridViewTextBoxColumn });
            dgvHD.DataSource = dTOHoaDonBindingSource;
            dgvHD.Location = new Point(138, 364);
            dgvHD.Name = "dgvHD";
            dgvHD.RowHeadersWidth = 62;
            dgvHD.Size = new Size(1377, 395);
            dgvHD.TabIndex = 0;
            // 
            // maHoaDonDataGridViewTextBoxColumn
            // 
            maHoaDonDataGridViewTextBoxColumn.DataPropertyName = "MaHoaDon";
            maHoaDonDataGridViewTextBoxColumn.HeaderText = "MaHoaDon";
            maHoaDonDataGridViewTextBoxColumn.MinimumWidth = 8;
            maHoaDonDataGridViewTextBoxColumn.Name = "maHoaDonDataGridViewTextBoxColumn";
            maHoaDonDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            ngayLapDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            ngayLapDataGridViewTextBoxColumn.HeaderText = "NgayLap";
            ngayLapDataGridViewTextBoxColumn.MinimumWidth = 8;
            ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            ngayLapDataGridViewTextBoxColumn.Width = 150;
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            maNhanVienDataGridViewTextBoxColumn.HeaderText = "MaNhanVien";
            maNhanVienDataGridViewTextBoxColumn.MinimumWidth = 8;
            maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            maNhanVienDataGridViewTextBoxColumn.Width = 150;
            // 
            // dTOHoaDonBindingSource
            // 
            dTOHoaDonBindingSource.DataSource = typeof(DTO.DTO_HoaDon);
            // 
            // button1
            // 
            button1.Location = new Point(138, 176);
            button1.Name = "button1";
            button1.Size = new Size(179, 57);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(535, 176);
            button2.Name = "button2";
            button2.Size = new Size(179, 57);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(927, 147);
            button3.Name = "button3";
            button3.Size = new Size(179, 57);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(407, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(416, 31);
            textBox1.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(1171, 176);
            button4.Name = "button4";
            button4.Size = new Size(179, 57);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FormQLHD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 801);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvHD);
            Name = "FormQLHD";
            Text = "FormQLHD";
            ((System.ComponentModel.ISupportInitialize)dgvHD).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTOHoaDonBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHD;
        private BindingSource dTOHoaDonBindingSource;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn maHoaDonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private Button button4;
    }
}