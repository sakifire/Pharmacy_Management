using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;


namespace Pharmacy_Management
{
    public partial class Frm_Approve : Form
    {
        public delegate void DoEvent();
        public event DoEvent ReFreshDataGrid;
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public Frm_Approve()
        {
            InitializeComponent();
        }

        private void Frm_Approve_Load(object sender, EventArgs e)
        {
            lbltendangnhap.Text = TenDangNhap;
            txttennhanvien.Text = TenNhanVien;
            txtSDT.Text = SDT;
            cbbstatus.Text = Status;
        }
        public string TenDangNhap { set; get; }
        public string TenNhanVien { set; get; }
        public string SDT { set; get; }
        public string Status { set; get; }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string UserName = lbltendangnhap.Text;
            string NameUser = txttennhanvien.Text;
            string PhoneNo = txtSDT.Text.Trim();
            string TT = cbbstatus.Text;
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "NhanVien_Update", UserName, NameUser, PhoneNo, TT);

                MessageBox.Show("Cập nhật thông tin nhân viên thành công");
                this.ReFreshDataGrid();
                Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
