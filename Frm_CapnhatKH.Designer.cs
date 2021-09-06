namespace Pharmacy_Management
{
    partial class Frm_CapnhatKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CapnhatKH));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.btn_huybo = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "SĐT:";
            // 
            // txt_ten
            // 
            this.txt_ten.BackColor = System.Drawing.SystemColors.Info;
            this.txt_ten.Location = new System.Drawing.Point(107, 55);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(175, 20);
            this.txt_ten.TabIndex = 7;
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.SystemColors.Info;
            this.txt_phone.Location = new System.Drawing.Point(107, 101);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(175, 20);
            this.txt_phone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã khách hàng:";
            // 
            // txt_ma
            // 
            this.txt_ma.BackColor = System.Drawing.SystemColors.Info;
            this.txt_ma.Enabled = false;
            this.txt_ma.Location = new System.Drawing.Point(107, 13);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(175, 20);
            this.txt_ma.TabIndex = 1;
            // 
            // btn_huybo
            // 
            this.btn_huybo.BackColor = System.Drawing.Color.LightBlue;
            this.btn_huybo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_huybo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huybo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huybo.Location = new System.Drawing.Point(170, 153);
            this.btn_huybo.Name = "btn_huybo";
            this.btn_huybo.Size = new System.Drawing.Size(112, 42);
            this.btn_huybo.TabIndex = 5;
            this.btn_huybo.Text = "Hủy bỏ";
            this.btn_huybo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_huybo.UseVisualStyleBackColor = false;
            this.btn_huybo.Click += new System.EventHandler(this.btn_huybo_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.BackColor = System.Drawing.Color.LightBlue;
            this.btn_capnhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_capnhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capnhat.Location = new System.Drawing.Point(34, 153);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(112, 42);
            this.btn_capnhat.TabIndex = 4;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capnhat.UseVisualStyleBackColor = false;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // Frm_CapnhatKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(319, 228);
            this.Controls.Add(this.btn_huybo);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CapnhatKH";
            this.Text = "Cập nhật khách hàng";
            this.Load += new System.EventHandler(this.Frm_CapnhatKH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_huybo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ma;
    }
}