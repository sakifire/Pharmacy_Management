namespace Pharmacy_Management
{
    partial class Frm_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_KhachHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_khachhang = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TichDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maKH = new System.Windows.Forms.TextBox();
            this.txt_tenKH = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_tichdiem = new System.Windows.Forms.TextBox();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_themmoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.dgv_khachhang);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 308);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thông tin khách hàng";
            // 
            // dgv_khachhang
            // 
            this.dgv_khachhang.AllowUserToAddRows = false;
            this.dgv_khachhang.AllowUserToDeleteRows = false;
            this.dgv_khachhang.AllowUserToResizeColumns = false;
            this.dgv_khachhang.AllowUserToResizeRows = false;
            this.dgv_khachhang.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgv_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaKH,
            this.TenKH,
            this.SDT,
            this.TongTien,
            this.TichDiem});
            this.dgv_khachhang.Location = new System.Drawing.Point(6, 19);
            this.dgv_khachhang.Name = "dgv_khachhang";
            this.dgv_khachhang.RowHeadersVisible = false;
            this.dgv_khachhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_khachhang.ShowRowErrors = false;
            this.dgv_khachhang.Size = new System.Drawing.Size(531, 282);
            this.dgv_khachhang.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = false;
            this.STT.Width = 50;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 80;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 150;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền mua hàng";
            this.TongTien.Name = "TongTien";
            // 
            // TichDiem
            // 
            this.TichDiem.DataPropertyName = "TichDiem";
            this.TichDiem.HeaderText = "Tích điểm";
            this.TichDiem.Name = "TichDiem";
            this.TichDiem.Width = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm nhanh:";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.BackColor = System.Drawing.SystemColors.Info;
            this.txt_timkiem.Location = new System.Drawing.Point(126, 24);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(262, 20);
            this.txt_timkiem.TabIndex = 1;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "SĐT:";
            // 
            // txt_maKH
            // 
            this.txt_maKH.BackColor = System.Drawing.SystemColors.Info;
            this.txt_maKH.Enabled = false;
            this.txt_maKH.Location = new System.Drawing.Point(112, 30);
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.Size = new System.Drawing.Size(150, 22);
            this.txt_maKH.TabIndex = 1;
            // 
            // txt_tenKH
            // 
            this.txt_tenKH.BackColor = System.Drawing.SystemColors.Info;
            this.txt_tenKH.Location = new System.Drawing.Point(112, 76);
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.Size = new System.Drawing.Size(150, 22);
            this.txt_tenKH.TabIndex = 3;
            // 
            // txt_SDT
            // 
            this.txt_SDT.BackColor = System.Drawing.SystemColors.Info;
            this.txt_SDT.Location = new System.Drawing.Point(112, 117);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(150, 22);
            this.txt_SDT.TabIndex = 5;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.txt_tichdiem);
            this.groupBox2.Controls.Add(this.txt_tongtien);
            this.groupBox2.Controls.Add(this.txt_SDT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_tenKH);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_maKH);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(555, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 308);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // txt_tichdiem
            // 
            this.txt_tichdiem.BackColor = System.Drawing.SystemColors.Info;
            this.txt_tichdiem.Location = new System.Drawing.Point(112, 202);
            this.txt_tichdiem.Name = "txt_tichdiem";
            this.txt_tichdiem.Size = new System.Drawing.Size(150, 22);
            this.txt_tichdiem.TabIndex = 5;
            this.txt_tichdiem.Text = "0";
            this.txt_tichdiem.Visible = false;
            this.txt_tichdiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.BackColor = System.Drawing.SystemColors.Info;
            this.txt_tongtien.Location = new System.Drawing.Point(112, 157);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(150, 22);
            this.txt_tongtien.TabIndex = 5;
            this.txt_tongtien.Text = "0";
            this.txt_tongtien.Visible = false;
            this.txt_tongtien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tích điểm:";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng tiền:";
            this.label5.Visible = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.LightBlue;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(575, 382);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(80, 51);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.BackColor = System.Drawing.Color.LightBlue;
            this.btn_capnhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_capnhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capnhat.Location = new System.Drawing.Point(369, 382);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(80, 51);
            this.btn_capnhat.TabIndex = 3;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = false;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.BackColor = System.Drawing.Color.LightBlue;
            this.btn_themmoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_themmoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themmoi.Location = new System.Drawing.Point(168, 382);
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Size = new System.Drawing.Size(80, 51);
            this.btn_themmoi.TabIndex = 2;
            this.btn_themmoi.Text = "Thêm mới";
            this.btn_themmoi.UseVisualStyleBackColor = false;
            this.btn_themmoi.Click += new System.EventHandler(this.btn_themmoi_Click);
            // 
            // Frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(859, 451);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.btn_themmoi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_KhachHang";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.Frm_KhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_themmoi;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_khachhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_maKH;
        private System.Windows.Forms.TextBox txt_tenKH;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_tichdiem;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TichDiem;
    }
}