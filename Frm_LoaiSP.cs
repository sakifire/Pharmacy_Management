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
    public partial class Frm_LoaiSP : Form
    {
        //string strCon = @"Data Source=DESKTOP-3ERVRAF\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public Frm_LoaiSP()
        {
            //string strCon = @"Data Source=DESKTOP-3ERVRAF\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            InitializeComponent();
        }

        private void Frm_LoaiSP_Load(object sender, EventArgs e)
        {
            
            FillData_sqlHelper();
        }
        private void FillData_sqlHelper()
        {
            //string strCon = @"Data Source=DESKTOP-3ERVRAF\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            try
            {
                string strSQL = "Select MaLoai, LoaiSP From LoaiSP";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                dgv_loaisp.AutoGenerateColumns = false;
                dgv_loaisp.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }
        private void FillNO()
        {
            for (int i = 1; i <= dgv_loaisp.Rows.Count; i++)
                dgv_loaisp["STT", i - 1].Value = (i < 10 ? "0" + i : i.ToString());
        }
        private int rowIndex = 0;
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (CheckValid() == false)
                return;
            string MaLoai = txt_MaLoaiSP.Text.Trim();
            string LoaiSP = txt_LoaiSP.Text.Trim();


            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "LoaiSP_Insert", MaLoai, LoaiSP);
                FillData_sqlHelper();

                MessageBox.Show("Loại sản phẩm đã được thêm thành công");
                Frm_LoaiSP ls = new Frm_LoaiSP();
                ls.Close();
                Frm_SanPham fr = new Frm_SanPham();
                fr.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }
        private bool CheckValid()
        {
            string strError = "";

            if (txt_LoaiSP.Text.Trim() == "")
            {
                strError = "Bạn chưa nhập tên loại sản phẩm";
                txt_LoaiSP.Focus();
            }
            if (txt_MaLoaiSP.Text.Trim() == "")
            {
                strError = "Bạn chưa nhập mã loại sản phẩm";
                txt_MaLoaiSP.Focus();
            }
            if (CheckExist() == true)
                strError = "Mã này đã tồn tại";

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
                SqlDataReader reader = SqlHelper.ExecuteReader(strCon, "LoaiSanPham_SelectByID", txt_MaLoaiSP.Text.Trim());
                if (reader.Read())
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
            return false;
        }
        
        private void btn_edit_Click(object sender, EventArgs e)
        {
            
            string MaLoai = txt_MaLoaiSP.Text.Trim();
            string LoaiSP = txt_LoaiSP.Text.Trim();
           
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "LoaiSPham_Update", MaLoai, LoaiSP);
                dgv_loaisp["MaLoai", rowIndex].Value = MaLoai;
                dgv_loaisp["LoaiSP", rowIndex].Value = LoaiSP;
                
                MessageBox.Show("Cập nhật thông tin loại sản phẩm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }

        private void dgv_loaisp_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_LoaiSP.Text = "";
            txt_MaLoaiSP.Text = "";
            if (e.RowIndex < 0)
                return;
            rowIndex = e.RowIndex;
            DataGridViewRow row = dgv_loaisp.Rows[e.RowIndex];
            try
            {
                txt_MaLoaiSP.Text = row.Cells["MaLoai"].Value.ToString();
                txt_LoaiSP.Text = row.Cells["LoaiSP"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }
        
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string MaLoai = txt_MaLoaiSP.Text.Trim();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa:" + MaLoai, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "LoaiSanPham_delete", MaLoai);
                FillData_SP();
                txt_MaLoaiSP.Refresh();
                txt_LoaiSP.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
            }
        }
        private void FillData_SP()
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, "LoaiSP_select").Tables[0];
                dgv_loaisp.AutoGenerateColumns = false;
                dgv_loaisp.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.ToString(), "Thông Báo");
            }
        }


        private void txt_timnhanh_TextChanged(object sender, EventArgs e)
        {
            //string strCon = @"Data Source=DESKTOP-3ERVRAF\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
           
            SqlDataAdapter sda = new SqlDataAdapter("Select MaLoai, LoaiSP from LoaiSP where LoaiSP like N'" + txt_timnhanh.Text + "%'", sqlCon);
            DataTable da = new DataTable();
            sda.Fill(da);
            dgv_loaisp.DataSource = da;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

    }
}
