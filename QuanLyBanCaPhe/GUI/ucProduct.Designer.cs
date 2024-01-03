namespace QuanLyBanCaPhe.GUI
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            lblName = new Label();
            panel2 = new Panel();
            lblPrice = new Label();
            txtImg = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtImg).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtImg);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 374);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblName);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 266);
            panel3.Name = "panel3";
            panel3.Size = new Size(308, 56);
            panel3.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(0, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(308, 53);
            lblName.TabIndex = 0;
            lblName.Text = "ProductName";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblPrice);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 322);
            panel2.Name = "panel2";
            panel2.Size = new Size(308, 52);
            panel2.TabIndex = 1;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice.Location = new Point(109, 3);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(78, 38);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "Price";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtImg
            // 
            txtImg.Location = new Point(30, 16);
            txtImg.Name = "txtImg";
            txtImg.Size = new Size(250, 232);
            txtImg.SizeMode = PictureBoxSizeMode.Zoom;
            txtImg.TabIndex = 0;
            txtImg.TabStop = false;
            txtImg.Click += txtImg_Click;
            // 
            // ucProduct
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "ucProduct";
            Size = new Size(308, 374);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox txtImg;
        private Panel panel3;
        private Label lblName;
        private Panel panel2;
        private Label lblPrice;
    }
}
