﻿namespace QuanLyBanCaPhe.GUI
{
    partial class FormDoiMK_Admin
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
            btnDMK = new Button();
            txtNL = new TextBox();
            txtMKM = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDMK
            // 
            btnDMK.Anchor = AnchorStyles.Top;
            btnDMK.BackColor = Color.FromArgb(235, 84, 81);
            btnDMK.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnDMK.ForeColor = Color.White;
            btnDMK.Location = new Point(597, 367);
            btnDMK.Name = "btnDMK";
            btnDMK.Size = new Size(300, 61);
            btnDMK.TabIndex = 9;
            btnDMK.Text = "Đổi mật khẩu";
            btnDMK.UseVisualStyleBackColor = false;
            btnDMK.Click += btnDMK_Click;
            // 
            // txtNL
            // 
            txtNL.Anchor = AnchorStyles.Top;
            txtNL.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtNL.Location = new Point(597, 283);
            txtNL.Name = "txtNL";
            txtNL.PasswordChar = '*';
            txtNL.Size = new Size(300, 45);
            txtNL.TabIndex = 8;
            // 
            // txtMKM
            // 
            txtMKM.Anchor = AnchorStyles.Top;
            txtMKM.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtMKM.Location = new Point(597, 228);
            txtMKM.Name = "txtMKM";
            txtMKM.PasswordChar = '*';
            txtMKM.Size = new Size(300, 45);
            txtMKM.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(257, 290);
            label2.Name = "label2";
            label2.Size = new Size(268, 38);
            label2.TabIndex = 6;
            label2.Text = "Nhập lại mật khẩu:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(257, 235);
            label1.Name = "label1";
            label1.Size = new Size(289, 38);
            label1.TabIndex = 5;
            label1.Text = "Nhập mật khẩu mới:";
            // 
            // FormDoiMK_Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 663);
            Controls.Add(btnDMK);
            Controls.Add(txtNL);
            Controls.Add(txtMKM);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDoiMK_Admin";
            Text = "Đổi mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDMK;
        private TextBox txtNL;
        private TextBox txtMKM;
        private Label label2;
        private Label label1;
    }
}