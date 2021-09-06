namespace Pharmacy_Management
{
    partial class Frm_LoaiSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LoaiSP));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_LoaiSP = new System.Windows.Forms.TextBox();
            this.txt_MaLoaiSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_loaisp = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_timnhanh = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaisp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại sản phẩm:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.txt_LoaiSP);
            this.groupBox1.Controls.Add(this.txt_MaLoaiSP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại sản phẩm";
            // 
            // txt_LoaiSP
            // 
            this.txt_LoaiSP.BackColor = System.Drawing.SystemColors.Info;
            this.txt_LoaiSP.Location = new System.Drawing.Point(165, 59);
            this.txt_LoaiSP.Name = "txt_LoaiSP";
            this.txt_LoaiSP.Size = new System.Drawing.Size(136, 22);
            this.txt_LoaiSP.TabIndex = 3;
            // 
            // txt_MaLoaiSP
            // 
            this.txt_MaLoaiSP.BackColor = System.Drawing.SystemColors.Info;
            this.txt_MaLoaiSP.Location = new System.Drawing.Point(165, 19);
            this.txt_MaLoaiSP.Name = "txt_MaLoaiSP";
            this.txt_MaLoaiSP.Size = new System.Drawing.Size(136, 22);
            this.txt_MaLoaiSP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên loại sản phẩm:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.dgv_loaisp);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 195);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách loại sản phẩm";
            // 
            // dgv_loaisp
            // 
            this.dgv_loaisp.AllowUserToAddRows = false;
            this.dgv_loaisp.AllowUserToDeleteRows = false;
            this.dgv_loaisp.AllowUserToResizeColumns = false;
            this.dgv_loaisp.AllowUserToResizeRows = false;
            this.dgv_loaisp.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_loaisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loaisp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaLoai,
            this.LoaiSP});
            this.dgv_loaisp.Location = new System.Drawing.Point(9, 26);
            this.dgv_loaisp.Name = "dgv_loaisp";
            this.dgv_loaisp.RowHeadersVisible = false;
            this.dgv_loaisp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_loaisp.ShowRowErrors = false;
            this.dgv_loaisp.Size = new System.Drawing.Size(350, 145);
            this.dgv_loaisp.TabIndex = 0;
            this.dgv_loaisp.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_loaisp_RowEnter);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = false;
            this.STT.Width = 50;
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Mã loại sản phẩm";
            this.MaLoai.Name = "MaLoai";
            // 
            // LoaiSP
            // 
            this.LoaiSP.DataPropertyName = "LoaiSP";
            this.LoaiSP.HeaderText = "Tên loại sản phẩm";
            this.LoaiSP.Name = "LoaiSP";
            this.LoaiSP.Width = 180;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LightBlue;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(8, 386);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(72, 46);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.LightBlue;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(105, 386);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(79, 46);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.LightBlue;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(206, 386);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(79, 46);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.LightBlue;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(304, 386);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(88, 46);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tìm kiếm nhanh:";
            // 
            // txt_timnhanh
            // 
            this.txt_timnhanh.BackColor = System.Drawing.SystemColors.Info;
            this.txt_timnhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timnhanh.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_timnhanh.Location = new System.Drawing.Point(144, 12);
            this.txt_timnhanh.Name = "txt_timnhanh";
            this.txt_timnhanh.Size = new System.Drawing.Size(178, 20);
            this.txt_timnhanh.TabIndex = 7;
            this.txt_timnhanh.Tag = "";
            this.txt_timnhanh.TextChanged += new System.EventHandler(this.txt_timnhanh_TextChanged);
            // 
            // Frm_LoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(415, 484);
            this.Controls.Add(this.txt_timnhanh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_LoaiSP";
            this.Text = "Quản lý loại sản phẩm";
            this.Load += new System.EventHandler(this.Frm_LoaiSP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaisp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_LoaiSP;
        private System.Windows.Forms.TextBox txt_MaLoaiSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_loaisp;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_timnhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSP;
    }
}