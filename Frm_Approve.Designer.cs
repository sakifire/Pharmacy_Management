namespace Pharmacy_Management
{
    partial class Frm_Approve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Approve));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttennhanvien = new System.Windows.Forms.TextBox();
            this.cbbstatus = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lbltendangnhap = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.txttennhanvien);
            this.groupBox1.Controls.Add(this.cbbstatus);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.lbltendangnhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.BackColor = System.Drawing.SystemColors.Info;
            this.txttennhanvien.Enabled = false;
            this.txttennhanvien.Location = new System.Drawing.Point(130, 47);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.Size = new System.Drawing.Size(136, 22);
            this.txttennhanvien.TabIndex = 3;
            // 
            // cbbstatus
            // 
            this.cbbstatus.BackColor = System.Drawing.SystemColors.Info;
            this.cbbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbstatus.FormattingEnabled = true;
            this.cbbstatus.Items.AddRange(new object[] {
            "Đã kích hoạt",
            "Chưa kích hoạt"});
            this.cbbstatus.Location = new System.Drawing.Point(130, 132);
            this.cbbstatus.Name = "cbbstatus";
            this.cbbstatus.Size = new System.Drawing.Size(136, 23);
            this.cbbstatus.TabIndex = 2;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.Info;
            this.txtSDT.Location = new System.Drawing.Point(130, 90);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(136, 22);
            this.txtSDT.TabIndex = 1;
            // 
            // lbltendangnhap
            // 
            this.lbltendangnhap.AutoSize = true;
            this.lbltendangnhap.Location = new System.Drawing.Point(127, 21);
            this.lbltendangnhap.Name = "lbltendangnhap";
            this.lbltendangnhap.Size = new System.Drawing.Size(10, 15);
            this.lbltendangnhap.TabIndex = 0;
            this.lbltendangnhap.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhân viên:";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.LightBlue;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Image = global::Pharmacy_Management.Properties.Resources.done_all;
            this.btnupdate.Location = new System.Drawing.Point(29, 179);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(88, 49);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.LightBlue;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Image = global::Pharmacy_Management.Properties.Resources.back;
            this.btnback.Location = new System.Drawing.Point(192, 179);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(91, 49);
            this.btnback.TabIndex = 2;
            this.btnback.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Frm_Approve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(307, 242);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Approve";
            this.Text = "Phê duyệt nhân viên";
            this.Load += new System.EventHandler(this.Frm_Approve_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbltendangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbstatus;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txttennhanvien;
    }
}