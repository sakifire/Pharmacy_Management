using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Pharmacy_Management;
using System.Configuration;

namespace Pharmacy_Management
{
    public partial class Frm_DangNhap : Form
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        public SqlConnection getConnect()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
            //return new SqlConnection(@"Data Source=DESKTOP-3ERVRAF\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True");
        }
        public DataTable checkLog(string user, string pass)
        {
            string sql = "Select UserName, Password From DangKyNDangNhap where UserName='" + user + "' and Password='" + pass + "' and Status=N'Đã kích hoạt'";
            SqlConnection con = getConnect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {
            //Xử lý khi nhấn enter
            this.AcceptButton = bt_dangnhap;
            try
            {
                //kiểm tra xem Form đã kết nối cơ sở dữ liệu chưa
                SqlConnection con = getConnect();
            }
            catch
            {
            }
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
                DataTable dt = new DataTable();
                dt=checkLog(this.tb_dangnhap.Text, this.tb_matkhau.Text);
                if (dt.Rows.Count > 0)
                {
                    //đăng nhập thành công, mở Frm_Main, đóng frm_Dangnhap
                    this.Hide();
                    Frm_Main main = new Frm_Main();
                    
                    main.UserPermision = tb_dangnhap.Text;
                    main.ShowDialog();
                }
        }

        private void link_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
