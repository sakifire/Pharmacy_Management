namespace Pharmacy_Management
{
    partial class Frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DangNhap));
            this.link_DangKy = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_dangnhap = new System.Windows.Forms.TextBox();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // link_DangKy
            // 
            this.link_DangKy.AutoSize = true;
            this.link_DangKy.Location = new System.Drawing.Point(133, 139);
            this.link_DangKy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link_DangKy.Name = "link_DangKy";
            this.link_DangKy.Size = new System.Drawing.Size(106, 13);
            this.link_DangKy.TabIndex = 1;
            this.link_DangKy.TabStop = true;
            this.link_DangKy.Text = "Bạn quên mật khẩu?";
            this.link_DangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_DangKy_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "User name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // tb_dangnhap
            // 
            this.tb_dangnhap.Location = new System.Drawing.Point(22, 39);
            this.tb_dangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.tb_dangnhap.Name = "tb_dangnhap";
            this.tb_dangnhap.Size = new System.Drawing.Size(218, 20);
            this.tb_dangnhap.TabIndex = 2;
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Location = new System.Drawing.Point(21, 96);
            this.tb_matkhau.Margin = new System.Windows.Forms.Padding(2);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(217, 20);
            this.tb_matkhau.TabIndex = 3;
            this.tb_matkhau.UseSystemPasswordChar = true;
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.BackColor = System.Drawing.Color.LightBlue;
            this.bt_dangnhap.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_dangnhap.Location = new System.Drawing.Point(78, 199);
            this.bt_dangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(112, 45);
            this.bt_dangnhap.TabIndex = 4;
            this.bt_dangnhap.Text = "LOGIN";
            this.bt_dangnhap.UseVisualStyleBackColor = false;
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_dangnhap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.tb_dangnhap);
            this.groupBox1.Controls.Add(this.link_DangKy);
            this.groupBox1.Controls.Add(this.bt_dangnhap);
            this.groupBox1.Controls.Add(this.tb_matkhau);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 262);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(75, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 41);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "SIGN IN";
            // 
            // Frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(287, 419);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_DangNhap";
            this.Text = "Người Dùng Đăng Nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel link_DangKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_dangnhap;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.Button bt_dangnhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

