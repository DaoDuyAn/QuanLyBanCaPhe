namespace QuanLyBanCaPhe.GUI
{
    partial class FormThongKe_Admin
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
            label1 = new Label();
            cbbNam = new ComboBox();
            dgvTK = new DataGridView();
            dgvThang = new DataGridViewTextBoxColumn();
            dgvDT = new DataGridViewTextBoxColumn();
            soDonLapDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dTOThongKeBindingSource = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            lblTongDT = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTOThongKeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(559, 198);
            label1.Name = "label1";
            label1.Size = new Size(88, 38);
            label1.TabIndex = 0;
            label1.Text = "Năm:";
            // 
            // cbbNam
            // 
            cbbNam.Anchor = AnchorStyles.Top;
            cbbNam.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbbNam.FormattingEnabled = true;
            cbbNam.Location = new Point(658, 195);
            cbbNam.Name = "cbbNam";
            cbbNam.Size = new Size(206, 46);
            cbbNam.TabIndex = 1;
            cbbNam.SelectedIndexChanged += cbbNam_SelectedIndexChanged;
            // 
            // dgvTK
            // 
            dgvTK.AllowUserToAddRows = false;
            dgvTK.AllowUserToDeleteRows = false;
            dgvTK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dgvTK.AutoGenerateColumns = false;
            dgvTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTK.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(81, 154, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTK.Columns.AddRange(new DataGridViewColumn[] { dgvThang, dgvDT, soDonLapDataGridViewTextBoxColumn });
            dgvTK.DataSource = dTOThongKeBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTK.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTK.EnableHeadersVisualStyles = false;
            dgvTK.Location = new Point(146, 341);
            dgvTK.Name = "dgvTK";
            dgvTK.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTK.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTK.RowHeadersVisible = false;
            dgvTK.RowHeadersWidth = 62;
            dgvTK.Size = new Size(1098, 496);
            dgvTK.TabIndex = 2;
            dgvTK.CellFormatting += dgvTK_CellFormatting;
            // 
            // dgvThang
            // 
            dgvThang.DataPropertyName = "Thang";
            dgvThang.HeaderText = "Tháng";
            dgvThang.MinimumWidth = 8;
            dgvThang.Name = "dgvThang";
            dgvThang.ReadOnly = true;
            // 
            // dgvDT
            // 
            dgvDT.DataPropertyName = "DoanhThu";
            dgvDT.HeaderText = "Doanh thu";
            dgvDT.MinimumWidth = 8;
            dgvDT.Name = "dgvDT";
            dgvDT.ReadOnly = true;
            // 
            // soDonLapDataGridViewTextBoxColumn
            // 
            soDonLapDataGridViewTextBoxColumn.DataPropertyName = "SoDonLap";
            soDonLapDataGridViewTextBoxColumn.HeaderText = "Số đơn lập";
            soDonLapDataGridViewTextBoxColumn.MinimumWidth = 8;
            soDonLapDataGridViewTextBoxColumn.Name = "soDonLapDataGridViewTextBoxColumn";
            soDonLapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTOThongKeBindingSource
            // 
            dTOThongKeBindingSource.DataSource = typeof(DTO.DTO_ThongKe);
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(533, 71);
            label2.Name = "label2";
            label2.Size = new Size(380, 60);
            label2.TabIndex = 3;
            label2.Text = "--- THỐNG KÊ ---";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(146, 280);
            label3.Name = "label3";
            label3.Size = new Size(236, 38);
            label3.TabIndex = 4;
            label3.Text = "Tổng doanh thu:";
            // 
            // lblTongDT
            // 
            lblTongDT.Anchor = AnchorStyles.Top;
            lblTongDT.AutoSize = true;
            lblTongDT.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongDT.Location = new Point(401, 280);
            lblTongDT.Name = "lblTongDT";
            lblTongDT.Size = new Size(0, 38);
            lblTongDT.TabIndex = 5;
            // 
            // FormThongKe_Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 861);
            Controls.Add(lblTongDT);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvTK);
            Controls.Add(cbbNam);
            Controls.Add(label1);
            Name = "FormThongKe_Admin";
            Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)dgvTK).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTOThongKeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbbNam;
        private DataGridView dgvTK;
        private Label label2;
        private BindingSource dTOThongKeBindingSource;
        private DataGridViewTextBoxColumn dgvThang;
        private DataGridViewTextBoxColumn dgvDT;
        private DataGridViewTextBoxColumn soDonLapDataGridViewTextBoxColumn;
        private Label label3;
        private Label lblTongDT;
    }
}