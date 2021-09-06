using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Pharmacy_Management;

namespace Pharmacy_Management
{
    public partial class Frm_CapnhatKH : Form
    {
        public delegate void DoEvent();
        public event DoEvent ReFreashDataGrid;
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public Frm_CapnhatKH()
        {
            InitializeComponent();
           
        }
        
        private void Frm_CapnhatKH_Load(object sender, EventArgs e)
        {
            txt_ten.Text = Ten;
            txt_phone.Text = SDT;
            txt_ma.Text = MaKH;
        }
        public string MaKH { set; get; }
        public string Ten { set; get; }
        public string SDT { set; get; }
        
        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            string MaKH = txt_ma.Text.Trim();
            string TenKH = txt_ten.Text.Trim();
            string SDT = txt_phone.Text.Trim();
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "KH_Update", MaKH, TenKH, SDT);
                
                MessageBox.Show("Cập nhật thông tin sản phẩm thành công");
                this.ReFreashDataGrid();
                Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }

        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
        
        
    }
}
