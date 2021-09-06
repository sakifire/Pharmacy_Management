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

namespace Pharmacy_Management
{
    public partial class Fm_UserManage : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public Fm_UserManage()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            InitializeComponent();
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = widthScreen;
            this.Height = heightScreen;
            float WidthPerscpective = (float)Width / 645;
            float HeightPerscpective = (float)Height / 543;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);
            dgvdanhsachnhanvien .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdanhsachnhanvien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
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
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, "User_Select").Tables[0];
                dgvdanhsachnhanvien.AutoGenerateColumns = false;
                dgvdanhsachnhanvien.DataSource = dtData;
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
                string strSQL = "Select UserName, NameOfUser, Phone, Status From DangKyNDangNhap";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                dgvdanhsachnhanvien.AutoGenerateColumns = false;
                dgvdanhsachnhanvien.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }
        private void FillNO()
        {
            for (int i = 1; i <= dgvdanhsachnhanvien.Rows.Count; i++)
                dgvdanhsachnhanvien["STT", i - 1].Value = (i < 10 ? "0" + i : i.ToString());
        }
        private void Fm_User_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            FillData_sqlHelper();
            LoadSTT();
        }
        private void btnPheduyet_Click(object sender, EventArgs e)
        {
            Frm_Approve frm_Approve = new Frm_Approve();
            frm_Approve.ReFreshDataGrid += new Frm_Approve.DoEvent(RefreshGrid);
            frm_Approve.TenDangNhap = dgvdanhsachnhanvien.CurrentRow.Cells["UserName"].Value.ToString();
            frm_Approve.TenNhanVien = dgvdanhsachnhanvien.CurrentRow.Cells["NameOfUser"].Value.ToString();
            frm_Approve.SDT = dgvdanhsachnhanvien.CurrentRow.Cells["Phone"].Value.ToString();
            frm_Approve.Status = dgvdanhsachnhanvien.CurrentRow.Cells["Status"].Value.ToString();
            frm_Approve.ShowDialog();
            FillNO();
        }
        public void RefreshGrid()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqCon = new SqlConnection(strCon);
            SqlDataAdapter sd = new SqlDataAdapter("Select * from DangKyNDangNhap", sqCon);
            DataTable da = new DataTable();
            sd.Fill(da);
            dgvdanhsachnhanvien.DataSource = da;
        }
        private void LoadSTT()
        {

            string Str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(Str);
            try
            {
                sqlCon.Open();
                string strsql = "User_Select";
                SqlDataAdapter da = new SqlDataAdapter(strsql, sqlCon);
                DataTable dtSTT = new DataTable();
                da.Fill(dtSTT);
                cbb_Status.DisplayMember = "Status";
                cbb_Status.ValueMember = "Status";
                cbb_Status.DataSource = dtSTT;

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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string UserName = txt_UserName.Text.Trim();
            string NameUser = txt_NameOfUser.Text.Trim();
            string SDT = txt_SDT.Text.Trim();
            string SST = cbb_Status.SelectedValue.ToString();
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(strCon, "SearchNhanVien", UserName, NameUser, SDT, SST);
                dgvdanhsachnhanvien.DataSource = ds.Tables[0];
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string MaNV = dgvdanhsachnhanvien.CurrentRow.Cells["UserName"].Value.ToString();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa:" + MaNV, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "NhanVien_Delete", MaNV);
                FillData_SP();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
            }
        }

        private void dgvdanhsachnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
