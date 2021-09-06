namespace Pharmacy_Management
{
    partial class Frm_NhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NhapHang));
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.cbbdonvitinh = new System.Windows.Forms.ComboBox();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbMaSP = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.txtGianhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblsoluongton = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvnhaphang = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHDNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donvidoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsoHDN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhaphang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNhapHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapHang.Location = new System.Drawing.Point(629, 526);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(94, 46);
            this.btnNhapHang.TabIndex = 0;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(310, 526);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(76, 46);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(444, 526);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 46);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Enabled = false;
            this.txtTenSP.Location = new System.Drawing.Point(110, 72);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(146, 20);
            this.txtTenSP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhà cung cấp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số lượng nhập:";
            // 
            // numSL
            // 
            this.numSL.Enabled = false;
            this.numSL.Location = new System.Drawing.Point(450, 74);
            this.numSL.Margin = new System.Windows.Forms.Padding(2);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(62, 20);
            this.numSL.TabIndex = 3;
            // 
            // cbbdonvitinh
            // 
            this.cbbdonvitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbdonvitinh.FormattingEnabled = true;
            this.cbbdonvitinh.Items.AddRange(new object[] {
            "Viên nang cứng",
            "Viên nén bao phim",
            "Viên nang mềm",
            "Dung dịch truyền",
            "Thuốc bột dạng gói",
            "Viên hoàn",
            "Hộp",
            "Túi "});
            this.cbbdonvitinh.Location = new System.Drawing.Point(524, 73);
            this.cbbdonvitinh.Margin = new System.Windows.Forms.Padding(2);
            this.cbbdonvitinh.Name = "cbbdonvitinh";
            this.cbbdonvitinh.Size = new System.Drawing.Size(85, 21);
            this.cbbdonvitinh.TabIndex = 4;
            // 
            // cbbNCC
            // 
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(450, 21);
            this.cbbNCC.Margin = new System.Windows.Forms.Padding(2);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(159, 21);
            this.cbbNCC.TabIndex = 5;
            this.cbbNCC.SelectedIndexChanged += new System.EventHandler(this.cbbNCC_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.cbbMaSP);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnSave1);
            this.groupBox1.Controls.Add(this.cbbNCC);
            this.groupBox1.Controls.Add(this.cbbdonvitinh);
            this.groupBox1.Controls.Add(this.numSL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGianhap);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblsoluongton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(968, 148);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cbbMaSP
            // 
            this.cbbMaSP.FormattingEnabled = true;
            this.cbbMaSP.Location = new System.Drawing.Point(110, 24);
            this.cbbMaSP.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaSP.Name = "cbbMaSP";
            this.cbbMaSP.Size = new System.Drawing.Size(146, 21);
            this.cbbMaSP.TabIndex = 14;
            this.cbbMaSP.SelectedIndexChanged += new System.EventHandler(this.cbbMaSP_SelectedIndexChanged);
            this.cbbMaSP.TextChanged += new System.EventHandler(this.cbbMaSP_TextChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(745, 24);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(56, 62);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Visible = false;
            // 
            // btnSave1
            // 
            this.btnSave1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSave1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave1.Location = new System.Drawing.Point(667, 24);
            this.btnSave1.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(50, 62);
            this.btnSave1.TabIndex = 12;
            this.btnSave1.Text = "Lưu";
            this.btnSave1.UseVisualStyleBackColor = false;
            this.btnSave1.Visible = false;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // txtGianhap
            // 
            this.txtGianhap.Enabled = false;
            this.txtGianhap.Location = new System.Drawing.Point(110, 115);
            this.txtGianhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtGianhap.Name = "txtGianhap";
            this.txtGianhap.Size = new System.Drawing.Size(146, 20);
            this.txtGianhap.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Giá nhập/1 đơn vị:";
            // 
            // lblsoluongton
            // 
            this.lblsoluongton.AutoSize = true;
            this.lblsoluongton.Location = new System.Drawing.Point(446, 119);
            this.lblsoluongton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsoluongton.Name = "lblsoluongton";
            this.lblsoluongton.Size = new System.Drawing.Size(10, 13);
            this.lblsoluongton.TabIndex = 1;
            this.lblsoluongton.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số lượng tồn:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.dgvnhaphang);
            this.groupBox2.Location = new System.Drawing.Point(7, 235);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(966, 275);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hàng nhập";
            // 
            // dgvnhaphang
            // 
            this.dgvnhaphang.AllowUserToAddRows = false;
            this.dgvnhaphang.AllowUserToDeleteRows = false;
            this.dgvnhaphang.AllowUserToResizeColumns = false;
            this.dgvnhaphang.AllowUserToResizeRows = false;
            this.dgvnhaphang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvnhaphang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhaphang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.SoHDNhap,
            this.MaSP,
            this.TenSP,
            this.NgayNhap,
            this.NCC,
            this.SoLuongNhap,
            this.GiaNhap,
            this.Donvidoluong,
            this.SoLuong});
            this.dgvnhaphang.Location = new System.Drawing.Point(4, 17);
            this.dgvnhaphang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvnhaphang.Name = "dgvnhaphang";
            this.dgvnhaphang.ReadOnly = true;
            this.dgvnhaphang.RowHeadersVisible = false;
            this.dgvnhaphang.RowTemplate.Height = 24;
            this.dgvnhaphang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvnhaphang.ShowRowErrors = false;
            this.dgvnhaphang.Size = new System.Drawing.Size(958, 251);
            this.dgvnhaphang.TabIndex = 0;
            this.dgvnhaphang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhaphang_RowEnter);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // SoHDNhap
            // 
            this.SoHDNhap.DataPropertyName = "SoHDNhap";
            this.SoHDNhap.HeaderText = "SHĐN";
            this.SoHDNhap.Name = "SoHDNhap";
            this.SoHDNhap.ReadOnly = true;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 150;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // NCC
            // 
            this.NCC.DataPropertyName = "NCC";
            this.NCC.HeaderText = "Nhà cung cấp";
            this.NCC.Name = "NCC";
            this.NCC.ReadOnly = true;
            this.NCC.Width = 155;
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.DataPropertyName = "SoLuongNhap";
            this.SoLuongNhap.HeaderText = "Số lượng nhập";
            this.SoLuongNhap.Name = "SoLuongNhap";
            this.SoLuongNhap.ReadOnly = true;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá nhập/1 đơn vị";
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            // 
            // Donvidoluong
            // 
            this.Donvidoluong.DataPropertyName = "Donvidoluong";
            this.Donvidoluong.HeaderText = "Đơn vị tính";
            this.Donvidoluong.Name = "Donvidoluong";
            this.Donvidoluong.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng tồn";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.ForeColor = System.Drawing.Color.Red;
            this.lblDateTime.Location = new System.Drawing.Point(484, 26);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(10, 13);
            this.lblDateTime.TabIndex = 9;
            this.lblDateTime.Text = ".";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(164, 526);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 46);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số hóa đơn nhập:";
            // 
            // txtsoHDN
            // 
            this.txtsoHDN.Enabled = false;
            this.txtsoHDN.Location = new System.Drawing.Point(125, 19);
            this.txtsoHDN.Margin = new System.Windows.Forms.Padding(2);
            this.txtsoHDN.Name = "txtsoHDN";
            this.txtsoHDN.Size = new System.Drawing.Size(93, 20);
            this.txtsoHDN.TabIndex = 11;
            // 
            // Frm_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(983, 573);
            this.Controls.Add(this.txtsoHDN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNhapHang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_NhapHang";
            this.Text = "Quản lý nhập hàng";
            this.Load += new System.EventHandler(this.Frm_NhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhaphang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.ComboBox cbbdonvitinh;
        private System.Windows.Forms.ComboBox cbbNCC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvnhaphang;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Label lblsoluongton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbMaSP;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.TextBox txtGianhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsoHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHDNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvidoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}