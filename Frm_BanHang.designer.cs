namespace Pharmacy_Management
{
    partial class Frm_BanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BanHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_donvi = new System.Windows.Forms.Label();
            this.txtsoluongban = new System.Windows.Forms.TextBox();
            this.cbb_masp = new System.Windows.Forms.ComboBox();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.btn_themsp = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.txt_soluongcon = new System.Windows.Forms.TextBox();
            this.txt_loaisp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_kiemtra = new System.Windows.Forms.Button();
            this.lbl_trangthaikh = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_danhsachspban = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.btn_laphoadon = new System.Windows.Forms.Button();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNgayLapHD = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachspban)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lbl_donvi);
            this.groupBox1.Controls.Add(this.txtsoluongban);
            this.groupBox1.Controls.Add(this.cbb_masp);
            this.groupBox1.Controls.Add(this.txt_mota);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txt_dongia);
            this.groupBox1.Controls.Add(this.txt_tensp);
            this.groupBox1.Controls.Add(this.btn_themsp);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.txt_soluongcon);
            this.groupBox1.Controls.Add(this.txt_loaisp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 299);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết sản phẩm bán";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 145);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Giá gốc:";
            this.label11.Visible = false;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lbl_donvi
            // 
            this.lbl_donvi.AutoSize = true;
            this.lbl_donvi.Location = new System.Drawing.Point(449, 73);
            this.lbl_donvi.Name = "lbl_donvi";
            this.lbl_donvi.Size = new System.Drawing.Size(10, 15);
            this.lbl_donvi.TabIndex = 5;
            this.lbl_donvi.Text = ".";
            // 
            // txtsoluongban
            // 
            this.txtsoluongban.BackColor = System.Drawing.SystemColors.Info;
            this.txtsoluongban.Location = new System.Drawing.Point(343, 109);
            this.txtsoluongban.Name = "txtsoluongban";
            this.txtsoluongban.Size = new System.Drawing.Size(100, 22);
            this.txtsoluongban.TabIndex = 4;
            this.txtsoluongban.TextChanged += new System.EventHandler(this.txtsoluongban_TextChanged);
            this.txtsoluongban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // cbb_masp
            // 
            this.cbb_masp.BackColor = System.Drawing.SystemColors.Info;
            this.cbb_masp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_masp.FormattingEnabled = true;
            this.cbb_masp.Location = new System.Drawing.Point(98, 24);
            this.cbb_masp.Name = "cbb_masp";
            this.cbb_masp.Size = new System.Drawing.Size(132, 23);
            this.cbb_masp.TabIndex = 2;
            this.cbb_masp.SelectedIndexChanged += new System.EventHandler(this.cbb_masp_SelectedIndexChanged);
            // 
            // txt_mota
            // 
            this.txt_mota.BackColor = System.Drawing.SystemColors.Info;
            this.txt_mota.Enabled = false;
            this.txt_mota.Location = new System.Drawing.Point(98, 180);
            this.txt_mota.Multiline = true;
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(377, 40);
            this.txt_mota.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(98, 142);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txt_dongia
            // 
            this.txt_dongia.BackColor = System.Drawing.SystemColors.Info;
            this.txt_dongia.Enabled = false;
            this.txt_dongia.Location = new System.Drawing.Point(98, 109);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(132, 22);
            this.txt_dongia.TabIndex = 1;
            // 
            // txt_tensp
            // 
            this.txt_tensp.BackColor = System.Drawing.SystemColors.Info;
            this.txt_tensp.Enabled = false;
            this.txt_tensp.Location = new System.Drawing.Point(98, 70);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(132, 22);
            this.txt_tensp.TabIndex = 1;
            // 
            // btn_themsp
            // 
            this.btn_themsp.BackColor = System.Drawing.Color.LightBlue;
            this.btn_themsp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_themsp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themsp.Image = global::Pharmacy_Management.Properties.Resources.icons8_add_241;
            this.btn_themsp.Location = new System.Drawing.Point(353, 226);
            this.btn_themsp.Name = "btn_themsp";
            this.btn_themsp.Size = new System.Drawing.Size(90, 40);
            this.btn_themsp.TabIndex = 0;
            this.btn_themsp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themsp.UseVisualStyleBackColor = false;
            this.btn_themsp.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.LightBlue;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = global::Pharmacy_Management.Properties.Resources.icons8_delete_bin_241;
            this.btn_xoa.Location = new System.Drawing.Point(129, 226);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(90, 40);
            this.btn_xoa.TabIndex = 0;
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // txt_soluongcon
            // 
            this.txt_soluongcon.BackColor = System.Drawing.SystemColors.Info;
            this.txt_soluongcon.Enabled = false;
            this.txt_soluongcon.Location = new System.Drawing.Point(343, 70);
            this.txt_soluongcon.Name = "txt_soluongcon";
            this.txt_soluongcon.Size = new System.Drawing.Size(100, 22);
            this.txt_soluongcon.TabIndex = 1;
            this.txt_soluongcon.TextChanged += new System.EventHandler(this.txt_soluongcon_TextChanged);
            // 
            // txt_loaisp
            // 
            this.txt_loaisp.BackColor = System.Drawing.SystemColors.Info;
            this.txt_loaisp.Enabled = false;
            this.txt_loaisp.Location = new System.Drawing.Point(343, 24);
            this.txt_loaisp.Name = "txt_loaisp";
            this.txt_loaisp.Size = new System.Drawing.Size(100, 22);
            this.txt_loaisp.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng bán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng còn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại sản phẩm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mô tả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên khách hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_kiemtra);
            this.groupBox2.Controls.Add(this.lbl_trangthaikh);
            this.groupBox2.Controls.Add(this.txt_sdt);
            this.groupBox2.Controls.Add(this.txt_tenkh);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(542, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 293);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(141, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thêm mới";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_kiemtra
            // 
            this.btn_kiemtra.BackColor = System.Drawing.Color.LightBlue;
            this.btn_kiemtra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kiemtra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kiemtra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kiemtra.Location = new System.Drawing.Point(15, 220);
            this.btn_kiemtra.Name = "btn_kiemtra";
            this.btn_kiemtra.Size = new System.Drawing.Size(98, 38);
            this.btn_kiemtra.TabIndex = 3;
            this.btn_kiemtra.Text = "Kiểm tra";
            this.btn_kiemtra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kiemtra.UseVisualStyleBackColor = false;
            this.btn_kiemtra.Click += new System.EventHandler(this.btn_kiemtra_Click);
            // 
            // lbl_trangthaikh
            // 
            this.lbl_trangthaikh.AutoSize = true;
            this.lbl_trangthaikh.ForeColor = System.Drawing.Color.Red;
            this.lbl_trangthaikh.Location = new System.Drawing.Point(12, 136);
            this.lbl_trangthaikh.Name = "lbl_trangthaikh";
            this.lbl_trangthaikh.Size = new System.Drawing.Size(10, 15);
            this.lbl_trangthaikh.TabIndex = 2;
            this.lbl_trangthaikh.Text = ".";
            // 
            // txt_sdt
            // 
            this.txt_sdt.BackColor = System.Drawing.SystemColors.Info;
            this.txt_sdt.Location = new System.Drawing.Point(107, 31);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(146, 22);
            this.txt_sdt.TabIndex = 1;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.BackColor = System.Drawing.SystemColors.Info;
            this.txt_tenkh.Enabled = false;
            this.txt_tenkh.Location = new System.Drawing.Point(107, 79);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(146, 22);
            this.txt_tenkh.TabIndex = 1;
            this.txt_tenkh.TextChanged += new System.EventHandler(this.txt_tenkh_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số điện thoại:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lavender;
            this.groupBox3.Controls.Add(this.dgv_danhsachspban);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 201);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sản phẩm bán";
            // 
            // dgv_danhsachspban
            // 
            this.dgv_danhsachspban.AllowUserToAddRows = false;
            this.dgv_danhsachspban.AllowUserToDeleteRows = false;
            this.dgv_danhsachspban.AllowUserToResizeColumns = false;
            this.dgv_danhsachspban.AllowUserToResizeRows = false;
            this.dgv_danhsachspban.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgv_danhsachspban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachspban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.SoHD,
            this.TenKH,
            this.SDT,
            this.NgayLap,
            this.MaSP,
            this.TenSP,
            this.LoaiSP,
            this.SoLuongBan,
            this.DonGia});
            this.dgv_danhsachspban.Location = new System.Drawing.Point(6, 19);
            this.dgv_danhsachspban.Name = "dgv_danhsachspban";
            this.dgv_danhsachspban.RowHeadersVisible = false;
            this.dgv_danhsachspban.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_danhsachspban.ShowRowErrors = false;
            this.dgv_danhsachspban.Size = new System.Drawing.Size(787, 165);
            this.dgv_danhsachspban.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = false;
            this.STT.Width = 50;
            // 
            // SoHD
            // 
            this.SoHD.DataPropertyName = "SoHD";
            this.SoHD.HeaderText = "Số HĐ";
            this.SoHD.Name = "SoHD";
            this.SoHD.Visible = false;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên KH";
            this.TenKH.Name = "TenKH";
            this.TenKH.Visible = false;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            this.SDT.Visible = false;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày lập HĐ";
            this.NgayLap.Name = "NgayLap";
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 150;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 200;
            // 
            // LoaiSP
            // 
            this.LoaiSP.DataPropertyName = "LoaiSP";
            this.LoaiSP.HeaderText = "Loại SP";
            this.LoaiSP.Name = "LoaiSP";
            this.LoaiSP.Width = 150;
            // 
            // SoLuongBan
            // 
            this.SoLuongBan.DataPropertyName = "SoLuongBan";
            this.SoLuongBan.HeaderText = "Số lượng";
            this.SoLuongBan.Name = "SoLuongBan";
            this.SoLuongBan.Width = 120;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 150;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(481, 619);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tổng tiền:";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Location = new System.Drawing.Point(542, 616);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(110, 20);
            this.txt_tongtien.TabIndex = 4;
            // 
            // btn_laphoadon
            // 
            this.btn_laphoadon.BackColor = System.Drawing.Color.LightBlue;
            this.btn_laphoadon.Enabled = false;
            this.btn_laphoadon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_laphoadon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_laphoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_laphoadon.Location = new System.Drawing.Point(446, 552);
            this.btn_laphoadon.Name = "btn_laphoadon";
            this.btn_laphoadon.Size = new System.Drawing.Size(128, 40);
            this.btn_laphoadon.TabIndex = 0;
            this.btn_laphoadon.Text = "Lập hóa đơn";
            this.btn_laphoadon.UseVisualStyleBackColor = false;
            this.btn_laphoadon.Click += new System.EventHandler(this.btn_laphoadon_Click);
            // 
            // txtSoHD
            // 
            this.txtSoHD.BackColor = System.Drawing.SystemColors.Info;
            this.txtSoHD.Enabled = false;
            this.txtSoHD.Location = new System.Drawing.Point(90, 10);
            this.txtSoHD.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(114, 20);
            this.txtSoHD.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Hóa đơn số:";
            // 
            // lblNgayLapHD
            // 
            this.lblNgayLapHD.AutoSize = true;
            this.lblNgayLapHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLapHD.ForeColor = System.Drawing.Color.Red;
            this.lblNgayLapHD.Location = new System.Drawing.Point(784, 17);
            this.lblNgayLapHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayLapHD.Name = "lblNgayLapHD";
            this.lblNgayLapHD.Size = new System.Drawing.Size(11, 13);
            this.lblNgayLapHD.TabIndex = 12;
            this.lblNgayLapHD.Text = ".";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(103, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 42);
            this.button2.TabIndex = 13;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Frm_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(830, 597);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblNgayLapHD);
            this.Controls.Add(this.txtSoHD);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_laphoadon);
            this.Controls.Add(this.label10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_BanHang";
            this.Text = "Quản lý bán hàng";
            this.Load += new System.EventHandler(this.Frm_BanHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachspban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_laphoadon;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.TextBox txt_soluongcon;
        private System.Windows.Forms.TextBox txt_loaisp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_kiemtra;
        private System.Windows.Forms.Label lbl_trangthaikh;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_danhsachspban;
        private System.Windows.Forms.Button btn_themsp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.ComboBox cbb_masp;
        private System.Windows.Forms.TextBox txtsoluongban;
        private System.Windows.Forms.Label lbl_donvi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNgayLapHD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}