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
using System.IO;
using System.Drawing.Imaging;
using System.Configuration;
using System.Globalization;

namespace Pharmacy_Management
{
    public partial class Frm_SanPham : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public Frm_SanPham()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            InitializeComponent();
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = widthScreen;
            this.Height = heightScreen;
            float WidthPerscpective = (float)Width / 915;
            float HeightPerscpective = (float)Height / 647;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);
            dgv_danhsachsp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_danhsachsp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
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
        private void FillData_SP()
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, "Product_Select").Tables[0];
                dgv_danhsachsp.AutoGenerateColumns = false;
                dgv_danhsachsp.DataSource = dtData;
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
                string strSQL = "Select MaSP, TenSP, Gia, NCC, LoaiSP, MoTa, SoLuong, Donvidoluong From SanPham order by MaSP asc";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                dgv_danhsachsp.AutoGenerateColumns = false;
                dgv_danhsachsp.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }

        private void FillNO()
        {
            for (int i = 1; i <= dgv_danhsachsp.Rows.Count; i++)
                dgv_danhsachsp["STT", i - 1].Value = (i < 10 ? "0" + i : i.ToString());
        }
      
       private void LoadNCC()
       {
            
            string Str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(Str);
            try
            {
                sqlCon.Open();
                string strsql = "NCC_select";
                SqlDataAdapter da = new SqlDataAdapter(strsql, sqlCon);
                DataTable dtNCC = new DataTable();
                da.Fill(dtNCC);
                cbb_NCC.DataSource = dtNCC;
                cbb_NCC.DisplayMember = "NCC";
                cbb_NCC.ValueMember = "NCC";
                
                cbb_NCC.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbb_NCC_SelectedIndexChanged(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void cbb_NCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_NCC.SelectedValue == null)
                return;
            
            string Str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCn = new SqlConnection(Str);
            string NCC = cbb_NCC.SelectedValue.ToString();
            try
            {
                sqlCn.Open();
                string s = @"SELECT [MaNCC]
                                   ,[NCC]
                               FROM [NhaCC]
                    where NCC=@NCC";
                SqlCommand sqlcm = new SqlCommand(s, sqlCn);
                sqlcm.Parameters.AddWithValue("@NCC", NCC);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
            }
            finally
            {
                sqlCn.Close();
            }
        }
        private void LoadLoaiSP()
        {
            
            string Str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(Str);
            try
            {
                sqlCon.Open();
                string strsql = "LoaiSP_select";
                SqlDataAdapter da = new SqlDataAdapter(strsql, sqlCon);
                DataTable dtLoaiSP = new DataTable();
                da.Fill(dtLoaiSP);
                DataRow dr = dtLoaiSP.NewRow();
                dr["LoaiSP"] = "All";
                dtLoaiSP.Rows.InsertAt(dr, 0);
                
                DataTable dtLoaiSP1 = new DataTable();
                da.Fill(dtLoaiSP1);
                cbb_loaisp1.DataSource = dtLoaiSP1;
                cbb_loaisp1.DisplayMember = "LoaiSP";
                cbb_loaisp1.ValueMember = "LoaiSP";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
            }
            finally
            {
                sqlCon.Close();
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            cbbmasp.Visible = false;
            txtIDSP.Enabled = true;
            txtIDSP.Text = "";
            txt_tenSP.Enabled = true;
            txt_tenSP.Text = "";
            txt_giatien.Enabled = true;
            txt_giatien.Text = "";
            num_soluong.Enabled = true;
            num_soluong.Text = "0";
            txt_mota.Enabled = true;
            txt_mota.Text = "";
            cbb_donvidoluong.Enabled = true;
            cbb_loaisp1.Enabled = true;
            cbb_NCC.Enabled = true;
            btnSave1.Visible = false;
            btnHuy.Visible = true;
        }

        private bool CheckValid()
        {
            string strError = "";
            if (cbb_loaisp1.Text.Trim() == "")
                strError = "Bạn chưa nhập loại sản phẩm\n\r";
            if (txt_giatien.Text.Trim() == "")
                strError = "Bạn chưa nhập giá tiền\n\r";
            if (txt_tenSP.Text.Trim() == "")
                strError += "Bạn chưa nhập tên sản phẩm\n\r";
            if (txtIDSP.Text.Trim() == "")
                strError = "Bạn chưa nhập mã sản phẩm\n\r";
            //if (CheckExist() == true)
                //strError = "Mã sản phẩm này đã tồn tại";

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
                SqlDataReader reader = SqlHelper.ExecuteReader(strCon, "SanPham_SelectByID", txtIDSP.Text.Trim());
                if (reader.Read())
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
            return false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            string sl = num_soluong.Value.ToString();
            lbl_trangthai.Text = "";
            if (sl == "0")
            {
                lbl_trangthai.ForeColor = Color.Red;
                lbl_trangthai.Text = "Hết hàng";
                num_soluong.ForeColor = Color.Red;
            }
            else
            {
                lbl_trangthai.ForeColor = Color.Blue;
                lbl_trangthai.Text = "Còn hàng";
                num_soluong.ForeColor = Color.Blue;
            }
        }

        private void txt_giatien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Frm_SanPham_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            LoadLoaiSP();
            LoadNCC();
            LoadIDSP();
            FillData_sqlHelper();
            lblDateTime.Text = DateTime.Today.ToShortDateString();
            
       

        }
        private int rowIndex = 0;
        private void dgv_danhsachsp_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            rowIndex = e.RowIndex;
            DataGridViewRow row = dgv_danhsachsp.Rows[e.RowIndex];
            try
            {
                cbbmasp.Text = row.Cells["MaSP"].Value.ToString();
                txt_tenSP.Text = row.Cells["TenSP"].Value.ToString();
                txt_giatien.Text = row.Cells["Gia"].Value.ToString();
                cbb_loaisp1.Text = row.Cells["LoaiSP"].Value.ToString();
                cbb_NCC.Text = row.Cells["NCC"].Value.ToString();
                num_soluong.Text = row.Cells["SoLuong"].Value.ToString();
                cbb_donvidoluong.Text = row.Cells["Donvidoluong"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            btnSave1.Visible = true;
            btnSave1.Enabled = true;
            btn_capnhat.Enabled = false;
            txt_tenSP.Enabled = true;
            txt_giatien.Enabled = true;
            cbb_loaisp1.Enabled = true;
            cbb_NCC.Enabled = true;
            cbb_donvidoluong.Enabled = true;
            txt_mota.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            string MaSP = cbbmasp.Text.Trim();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa:" + MaSP, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "SanPham_delete", MaSP);
                FillData_SP();
                LoadIDSP();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_LoaiSP fm_LSP = new Frm_LoaiSP();
            fm_LSP.ShowDialog();
            Frm_SanPham fm = new Frm_SanPham();
            fm.Close();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from SanPham where TenSP like  N'%" + txtTimkiem.Text + "%'", sqlCon);
            DataTable da = new DataTable();
            sda.Fill(da);
            dgv_danhsachsp.DataSource = da;
            FillNO();
        }

        

        private void btnSave1_Click(object sender, EventArgs e)
        {
            string MaSP = cbbmasp.Text.Trim();
            string TenSP = txt_tenSP.Text.Trim();
            string GiaTien = txt_giatien.Text.Trim();
            string NCC = cbb_NCC.Text.Trim();
            string LoaiSP = cbb_loaisp1.Text.Trim();
            string Mota = txt_mota.Text.Trim();
            string SoLuong = num_soluong.Text.Trim();
            string Donvi = cbb_donvidoluong.Text.Trim();
            if (MessageBox.Show("Bạn chắc chắn muốn cập nhập thông tin cho " + MaSP, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "SPham_Update", MaSP, TenSP, GiaTien, NCC, LoaiSP, Mota, SoLuong, Donvi);
                dgv_danhsachsp["MaSP", rowIndex].Value = MaSP;
                dgv_danhsachsp["TenSP", rowIndex].Value = TenSP;
                dgv_danhsachsp["LoaiSP", rowIndex].Value = LoaiSP;
                dgv_danhsachsp["NCC", rowIndex].Value = NCC;
                dgv_danhsachsp["MoTa", rowIndex].Value = Mota;
                dgv_danhsachsp["Gia", rowIndex].Value = GiaTien;
                dgv_danhsachsp["SoLuong", rowIndex].Value = SoLuong;
                dgv_danhsachsp["Donvidoluong", rowIndex].Value = Donvi;
                MessageBox.Show("Cập nhật thông tin sản phẩm thành công");
                btnSave1.Visible = false;
                btnHuy.Visible = false;
                btn_capnhat.Enabled = true;
                txt_tenSP.Enabled = false;
                txt_giatien.Enabled = false;
                cbb_loaisp1.Enabled = false;
                cbb_NCC.Enabled = false;
                num_soluong.Enabled = false;
                cbb_donvidoluong.Enabled = false;
                txt_mota.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }
        private void LoadIDSP()
        {
            string Str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(Str);
            try
            {
                sqlCon.Open();
                string strsql = "Product_Select";
                SqlDataAdapter da = new SqlDataAdapter(strsql, sqlCon);
                DataTable dtNCC = new DataTable();
                da.Fill(dtNCC);
                cbbmasp.DataSource = dtNCC;
                cbbmasp.DisplayMember = "MaSP";
                cbbmasp.ValueMember = "MaSP";
                cbbmasp.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbbmasp_SelectedIndexChanged(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
            }
            finally
            {
                sqlCon.Close();
            }
        }
            private void cbbmasp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbmasp.SelectedValue == null)
                return;
            string str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCn = new SqlConnection(str);
            string ID = cbbmasp.SelectedValue.ToString();
            try
            {
                sqlCn.Open();
                string s = @"SELECT
                                  [MaSP]
                                  ,[TenSP]
                                  ,[Gia]
                                  ,[NCC]
                                  ,[LoaiSP]
                                  ,[MoTa]
                                  ,[SoLuong]
                                  ,[Donvidoluong]
                                 
                              FROM [SanPham]
                    where MaSP=@MaSP";
                SqlCommand sqlcm = new SqlCommand(s, sqlCn);
                sqlcm.Parameters.AddWithValue("@MaSP", ID);
                SqlDataReader read = sqlcm.ExecuteReader();
                if (read.Read())
                {

                    txt_tenSP.Text = read["TenSP"].ToString();
                    cbb_loaisp1.Text = read["LoaiSP"].ToString();
                    txt_mota.Text = read["MoTa"].ToString();
                    num_soluong.Text = read["SoLuong"].ToString();
                    txt_giatien.Text = read["Gia"].ToString();
                    cbb_donvidoluong.Text = read["Donvidoluong"].ToString();

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
            }
            finally
            {
                sqlCn.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Visible = false;
            btnSave1.Visible = false;
            btn_capnhat.Enabled = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cbb_donvidoluong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
