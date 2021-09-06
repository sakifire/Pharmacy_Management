using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Pharmacy_Management;

namespace Pharmacy_Management
{
    public partial class Frm_NhapHang : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public Frm_NhapHang()
        {
            InitializeComponent();
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = widthScreen;
            this.Height = heightScreen;
            float WidthPerscpective = (float)Width / 999;
            float HeightPerscpective = (float)Height / 611;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);
            dgvnhaphang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvnhaphang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
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
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, "NhapHang_Select").Tables[0];
                dgvnhaphang.AutoGenerateColumns = false;
                dgvnhaphang.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.ToString(), "Thông Báo");
            }
        }
        private void FillNO()
        {
            for (int i = 1; i <= dgvnhaphang.Rows.Count; i++)
                dgvnhaphang["STT", i - 1].Value = (i < 10 ? "0" + i : i.ToString());
        }
        private bool CheckValid()
        {
            string strError = "";

            if (numSL.Text.Trim() == "")
            {
                strError = "Bạn chưa nhập số lượng\n\r";
                numSL.Focus();
            } 
            if (cbbNCC.Text.Trim() == "")
            {
                strError = "Bạn chưa nhập tên nhà cung cấp\n\r";
                cbbNCC.Focus();
            }
            if (txtGianhap.Text.Trim() == "")
            {
                strError = "Bạn chưa nhập giá tiền\n\r";
                txtGianhap.Focus();
            }
            if (txtTenSP.Text.Trim() == "")
            {
                strError += "Bạn chưa nhập tên sản phẩm\n\r";
                txtTenSP.Focus();
            }
            if (cbbMaSP.Text.Trim() == "")
            {
                strError = "Bạn chưa nhập mã sản phẩm\n\r";
                cbbMaSP.Focus();
            }
            //if (CheckExist() == true)
            //strError = "Mã sản phẩm này đã tồn tại";

            if (strError != "")
            {
                MessageBox.Show(strError, "Thông Báo");
                return false;
            }
            return true;
        }
        private void btnSave1_Click(object sender, EventArgs e)
        {
            if (dgvnhaphang.DataBindings == null)
                MessageBox.Show("Bạn phải thêm hàng hóa trước khi lưu","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            else
            {
                string SoHDN = txtsoHDN.Text.Trim();
                string NgayNhap = lblDateTime.Text;
                string MaSP = cbbMaSP.Text.Trim();
                string TenSP = txtTenSP.Text.Trim();
                int Gia = Convert.ToInt32(txtGianhap.Text.Trim());
                string NCC = cbbNCC.Text.Trim();
                int SLN = Convert.ToInt32(numSL.Text.Trim());
                string DonViDo = cbbdonvitinh.Text.Trim();
                try
                {
                    SqlHelper.ExecuteNonQuery(strCon, "NhapHang_Insert", SoHDN, NgayNhap, MaSP, TenSP, Gia, NCC, SLN, DonViDo);
                    LoadMaSP();
                    MessageBox.Show("Đã nhập hàng thành công");
                    btnSave1.Visible = false;
                    btnNhapHang.Enabled = true;
                    btnHuy.Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
                }
                SqlHelper.ExecuteNonQuery(strCon, "NhapHang_UpdateToSanPham", MaSP, TenSP, NCC, SLN, DonViDo);
                LoadMaSP();
                //MessageBox.Show("Đã nhập hàng thành công");
                btnSave1.Visible = false;
                btnNhapHang.Enabled = true;
                btnHuy.Visible = false;
            }
            
        }
        private void LoadMaSP()
        {

            string Str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(Str);
            try
            {
                sqlCon.Open();
                string strsql = "Product_Select";
                SqlDataAdapter da = new SqlDataAdapter(strsql, sqlCon);
                DataTable dtMaSP = new DataTable();
                da.Fill(dtMaSP);
                cbbMaSP.DataSource = dtMaSP;
                cbbMaSP.DisplayMember = "MaSP";
                cbbMaSP.ValueMember = "MaSP";

                cbbMaSP.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbbMaSP_SelectedIndexChanged(null, null);

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
                cbbNCC.DataSource = dtNCC;
                cbbNCC.DisplayMember = "NCC";
                cbbNCC.ValueMember = "NCC";

                cbbNCC.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbbNCC_SelectedIndexChanged(null, null);

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
        private void Frm_NhapHang_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            lblDateTime.Text = DateTime.Today.ToShortDateString();
            LoadMaSP();
            LoadNCC();
            MaTuDongTang();
            cbbdonvitinh.SelectedItem = cbbdonvitinh.Items[0];
        }
        DataTable dt;
        private void MaTuDongTang()
        {
            SqlConnection sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            string sql = "tb_NhapHang";
            SqlCommand comd = new SqlCommand(sql, sqlCon);
            comd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(comd);
            dt = new DataTable();
            da.Fill(dt);
            sqlCon.Close();
            string g = "";
            if (dt.Rows.Count <= 0)
            {
                g = "NH01";
            }
            else
            {
                int k;
                g = "NH";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 2));
                k = k + 1;
                if (k < 10)
                    g = g + "0";
                g = g + k.ToString();
            }
            txtsoHDN.Text = g;
        }
        private void cbbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaSP.SelectedValue == null)
                return;

            string Str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCn = new SqlConnection(Str);
            string NCC = cbbMaSP.SelectedValue.ToString();
            try
            {
                sqlCn.Open();
                string s = @"SELECT [MaSP]
                                   ,[TenSP]
                                   ,[NCC]
                                   ,[SoLuong]
                                   ,[Donvidoluong]
                               FROM [SanPham]
                    where MaSP=@MaSP";
                SqlCommand sqlcm = new SqlCommand(s, sqlCn);
                sqlcm.Parameters.AddWithValue("@MaSP", NCC);
                SqlDataReader read = sqlcm.ExecuteReader();

                if (read.Read())
                {

                    txtTenSP.Text = read["TenSP"].ToString();
                    cbbNCC.Text = read["NCC"].ToString();
                    lblsoluongton.Text = read["SoLuong"].ToString();
                    cbbdonvitinh.Text = read["Donvidoluong"].ToString();
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

        private void cbbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNCC.SelectedValue == null)
                return;

            string Str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCn = new SqlConnection(Str);
            string NCC = cbbNCC.SelectedValue.ToString();
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
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckValid() == false)
                return;
            else
            {
                dgvnhaphang.Rows.Add(1);
                int indexRow = dgvnhaphang.Rows.Count - 1;
                dgvnhaphang[1, indexRow].Value = txtsoHDN.Text;
                dgvnhaphang[2, indexRow].Value = cbbMaSP.Text;
                dgvnhaphang[3, indexRow].Value = txtTenSP.Text;
                dgvnhaphang[4, indexRow].Value = lblDateTime.Text;
                dgvnhaphang[5, indexRow].Value = cbbNCC.Text;
                dgvnhaphang[6, indexRow].Value = numSL.Text;
                dgvnhaphang[7, indexRow].Value = txtGianhap.Text;
                dgvnhaphang[8, indexRow].Value = cbbdonvitinh.Text;
                dgvnhaphang[9, indexRow].Value = lblsoluongton.Text;
                FillNO();
            }

            for (int i = 0; i < dgvnhaphang.Rows.Count - 1; i++)
            {
                if (dgvnhaphang.Rows[i].IsNewRow) continue;
                string tmp = dgvnhaphang.Rows[i].Cells["MaSP"].Value.ToString();
                for (int j = dgvnhaphang.Rows.Count - 1; j > i; j--)
                {
                    if (dgvnhaphang.Rows[j].IsNewRow) continue;
                    if (tmp == dgvnhaphang.Rows[j].Cells["MaSP"].Value.ToString())
                    {
                        dgvnhaphang.Rows.RemoveAt(j);
                        int sl;
                        Int32.TryParse(numSL.Text, out sl);
                        for (int a = 0; a < dgvnhaphang.Rows.Count; a++)
                        {
                            if (dgvnhaphang["MaSP", a].Value.ToString() == cbbMaSP.Text)
                            {
                                dgvnhaphang["SoLuongNhap", a].Value = sl + Convert.ToInt32(dgvnhaphang["SoLuongNhap", a].Value.ToString());
                            }
                        }
                        
                    }
                }
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            btnSave1.Visible = true;
            btnHuy.Visible = true;
            txtTenSP.Enabled = true;
            txtGianhap.Enabled = true;
            numSL.Enabled = true;
            btnNhapHang.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            MaTuDongTang();
            dgvnhaphang.Rows.Clear();
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string MaSP = cbbMaSP.Text.Trim();
            string TenSP = txtTenSP.Text.Trim();
            int Gia = Convert.ToInt32(txtGianhap.Text.Trim());
            string NCC = cbbNCC.Text.Trim();
            int SLN = Convert.ToInt32(numSL.Text.Trim());
            string DonViDo = cbbdonvitinh.Text.Trim();
            if (MessageBox.Show("Bạn chắc chắn muốn cập nhập thông tin cho " + MaSP, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "NhapHang_Update", MaSP, TenSP, Gia, NCC, SLN, DonViDo);
                dgvnhaphang["MaSP", rowIndex].Value = MaSP;
                dgvnhaphang["TenSP", rowIndex].Value = TenSP;
                dgvnhaphang["GiaNhap", rowIndex].Value = Gia;
                dgvnhaphang["NCC", rowIndex].Value = NCC;
                dgvnhaphang["SoLuongNhap", rowIndex].Value = SLN;
                dgvnhaphang["Donvidoluong", rowIndex].Value = DonViDo;

                MessageBox.Show("Cập nhật thông tin sản phẩm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }
        private int rowIndex = 1;
        private void dgvnhaphang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 1)
                return;
            rowIndex = e.RowIndex;
            DataGridViewRow row = dgvnhaphang.Rows[e.RowIndex];
            try
            {
                cbbMaSP.Text = row.Cells["MaSP"].Value.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value.ToString();
                txtGianhap.Text = row.Cells["GiaNhap"].Value.ToString();
                cbbNCC.Text = row.Cells["NCC"].Value.ToString();
                numSL.Text = row.Cells["SoLuongNhap"].Value.ToString();
                cbbdonvitinh.Text = row.Cells["Donvidoluong"].Value.ToString();
                lblsoluongton.Text = row.Cells["SoLuong"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            if (this.dgvnhaphang.SelectedRows.Count > 0)
            {

                dgvnhaphang.Rows.RemoveAt(this.dgvnhaphang.SelectedRows[0].Index);
            }
        }
        private bool CheckExist()
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(strCon, "SanPham_SelectByID", cbbMaSP.Text.Trim());
                if (reader.Read())
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
            return false;
        }
        private void cbbMaSP_TextChanged(object sender, EventArgs e)
        {
            if(CheckExist()==false)
            {
                txtTenSP.Text = "";
                lblsoluongton.Text = "";
            }
        }
    }
}
