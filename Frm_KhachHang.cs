using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pharmacy_Management;
using System.Data.SqlClient;
using System.Configuration;

namespace Pharmacy_Management
{
    public partial class Frm_KhachHang : Form
    {
        public delegate void EventHandler(object sender, EventArgs e);


        
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public Frm_KhachHang()
        {
            
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            InitializeComponent();
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = widthScreen;
            this.Height = heightScreen;
            float WidthPerscpective = (float)Width / 935;
            float HeightPerscpective = (float)Height / 482;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);
            dgv_khachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_khachhang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void ResizeAllControls(Control recussiveControl, float WidthPerscpective, float HeightPerscpective)
        {

            foreach (Control control in recussiveControl.Controls)
            {

                if (control.Controls.Count != 0)

                    ResizeAllControls(control, WidthPerscpective, HeightPerscpective);

                control.Left = (int)(control.Left * WidthPerscpective);

                control.Top = (int)(control.Top * HeightPerscpective);

                control.Width = (int)(control.Width * WidthPerscpective);

                control.Height = (int)(control.Height * HeightPerscpective);

            }
        }
        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            FillData_sqlHelper();
            MaTuDongTang();
            //UpDateTongTien();
            string MaKH = txt_maKH.Text.Trim();
            string TenKH = txt_tenKH.Text.Trim();       
        }
        
        private void FillData_SP()
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, "KhachHang_select").Tables[0];
                dgv_khachhang.AutoGenerateColumns = false;
                dgv_khachhang.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.ToString(), "Thông Báo");
            }
        }
        private void FillData_sqlHelper()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            try
            {
                string strSQL = "SELECT MaKH, TenKH, SDT, TongTien, TichDiem FROM KhachHang";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                dgv_khachhang.AutoGenerateColumns = false;
                dgv_khachhang.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }
        private void FillNO()
        {
            for (int i = 1; i <= dgv_khachhang.Rows.Count; i++)
                dgv_khachhang["STT", i - 1].Value = (i < 10 ? "0" + i : i.ToString());
        }
        private bool CheckValid()
        {
            string strError = "";
            if (txt_SDT.Text.Trim() == "")
            {
                strError = "Bạn chưa số điện thoại\n\r";
                txt_SDT.Focus();
            }
            if (txt_tenKH.Text.Trim() == "")
            {
                strError = "Bạn chưa nhập tên khách hàng\n\r";
                txt_tenKH.Focus();
            }
            if (CheckExist()==true)
                strError = "Khách hàng này đã tồn tại\n\r";

            if (strError != "")
            {
                MessageBox.Show(strError, "Thông Báo");
                return false;
            }
            return true;
        }
        private bool CheckExist()
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(strCon, "KhachHang_SelectBySDT", txt_SDT.Text.Trim());
                if (reader.Read())
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
            return false;
        }
        

        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            
            if (CheckValid() == false)
                return;
            string MaKH = txt_maKH.Text.Trim();
            string TenKH = txt_tenKH.Text.Trim();
            string SDT = txt_SDT.Text.Trim();
            try
            {

                SqlHelper.ExecuteNonQuery(strCon, "KH_Insert", MaKH, TenKH, SDT);
                FillData_sqlHelper();
                
                txt_maKH.Refresh();
                txt_tenKH.Clear();
                txt_tenKH.Focus();
                txt_SDT.Clear();
                MaTuDongTang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        
        }
        DataTable dt;
        private void MaTuDongTang()
        {
            SqlConnection sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            string sql = "tb_KhachHang";
            SqlCommand comd = new SqlCommand(sql, sqlCon);
            comd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(comd);
            dt = new DataTable();
            da.Fill(dt);
            sqlCon.Close();
            string g = "";
            if (dt.Rows.Count <= 0)
            {
                g = "KH01";
            }
            else
            {
                int k;
                g = "KH";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 2));
                k = k + 1;
                if (k <= 10)
                    g = g + "0";
                g = g + k.ToString();
            }
            txt_maKH.Text = g;
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            txt_SDT.MaxLength = 11;
        }
        
        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            Frm_CapnhatKH capnhatkh = new Frm_CapnhatKH();
            capnhatkh.ReFreashDataGrid += new Frm_CapnhatKH.DoEvent(RefreshGrid);
            capnhatkh.MaKH = dgv_khachhang.CurrentRow.Cells["MaKH"].Value.ToString();
            capnhatkh.Ten = dgv_khachhang.CurrentRow.Cells["TenKH"].Value.ToString();
            capnhatkh.SDT = dgv_khachhang.CurrentRow.Cells["SDT"].Value.ToString();
            capnhatkh.ShowDialog();
            FillNO();
            
        }
        public void RefreshGrid()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqCon = new SqlConnection(strCon);
            SqlDataAdapter sd = new SqlDataAdapter("Select * from KhachHang", sqCon);
            DataTable da = new DataTable();
            sd.Fill(da);
            dgv_khachhang.DataSource = da;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string MaKH = dgv_khachhang.CurrentRow.Cells["MaKH"].Value.ToString();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa:" + MaKH, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "KhachHang_delete", MaKH);
                FillData_SP();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
            }
        }
      private void btn_lammoi_Click(object sender, EventArgs e)
        {
           
                
        }

        private void txt_timkiem_TextChanged_1(object sender, EventArgs e)
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from KhachHang where TenKH like  N'%" + txt_timkiem.Text + "%'", sqlCon);
            DataTable da = new DataTable();
            sda.Fill(da);
            dgv_khachhang.DataSource = da;
            FillNO();
        }
    }
}
