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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp;
using System.Configuration;
using System.Drawing.Printing;

namespace Pharmacy_Management
{
    public partial class Frm_BanHang : Form
    {

        public delegate void delPassData(TextBox text, TextBox text2);
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

        public Frm_BanHang()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            InitializeComponent();
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = widthScreen;
            this.Height = heightScreen;
            float WidthPerscpective = (float)Width / 845;
            float HeightPerscpective = (float)Height / 647;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);
            dgv_danhsachspban.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_danhsachspban.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
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

        
        private void Frm_BanHang_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            LoadIDSP();
            lblNgayLapHD.Text = DateTime.Today.ToShortDateString();
            MaTuDongTang();
            button1.Enabled = false;
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
                cbb_masp.DataSource = dtNCC;
                cbb_masp.DisplayMember = "MaSP";
                cbb_masp.ValueMember = "MaSP";
                cbb_masp.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbb_masp_SelectedIndexChanged(null, null);

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
        private void cbb_masp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_masp.SelectedValue == null)
                return;
            string str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCn = new SqlConnection(str);
            string ID = cbb_masp.SelectedValue.ToString();
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

                    txt_tensp.Text = read["TenSP"].ToString();
                    txt_loaisp.Text = read["LoaiSP"].ToString();
                    txt_mota.Text = read["MoTa"].ToString();
                    txt_soluongcon.Text = read["SoLuong"].ToString();
                    textBox1.Text = read["Gia"].ToString();
                    lbl_donvi.Text = read["Donvidoluong"].ToString();

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
            txtsoluongban.Clear();
            txtsoluongban.Focus();
        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void FillNO()
        {
            for (int i = 1; i <= dgv_danhsachspban.Rows.Count; i++)
                dgv_danhsachspban["STT", i - 1].Value = (i < 10 ? "0" + i : i.ToString());
        }
        private bool CheckValid()
        {
            string strError = "";
            if (txtsoluongban.Text.Trim() == "")
                strError = "Bạn chưa nhập số lượng sản phẩm bán";
            txtsoluongban.Focus();
            if (strError != "")
            {
                MessageBox.Show(strError, "Thông Báo");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckValid() == false)
                return;
            else
            {
                dgv_danhsachspban.Rows.Add(1);
                int indexRow = dgv_danhsachspban.Rows.Count - 1;
                dgv_danhsachspban[1, indexRow].Value = txtSoHD.Text;
                dgv_danhsachspban[2, indexRow].Value = txt_tenkh.Text;
                dgv_danhsachspban[3, indexRow].Value = txt_sdt.Text;
                dgv_danhsachspban[4, indexRow].Value = lblNgayLapHD.Text;
                dgv_danhsachspban[5, indexRow].Value = cbb_masp.Text;
                dgv_danhsachspban[6, indexRow].Value = txt_tensp.Text;
                dgv_danhsachspban[7, indexRow].Value = txt_loaisp.Text;
                dgv_danhsachspban[8, indexRow].Value = txtsoluongban.Text;
                dgv_danhsachspban[9, indexRow].Value = txt_dongia.Text;
                FillNO();
            }

            for (int i = 0; i < dgv_danhsachspban.Rows.Count - 1; i++)
            {
                if (dgv_danhsachspban.Rows[i].IsNewRow) continue;
                string tmp = dgv_danhsachspban.Rows[i].Cells["MaSP"].Value.ToString();
                for (int j = dgv_danhsachspban.Rows.Count - 1; j > i; j--)
                {
                    if (dgv_danhsachspban.Rows[j].IsNewRow) continue;
                    if (tmp == dgv_danhsachspban.Rows[j].Cells["MaSP"].Value.ToString())
                    {
                        dgv_danhsachspban.Rows.RemoveAt(j);
                        int sl;
                        Int32.TryParse(txtsoluongban.Text, out sl);
                        for (int a = 0; a < dgv_danhsachspban.Rows.Count; a++)
                        {
                            if (dgv_danhsachspban["MaSP", a].Value.ToString() == cbb_masp.Text)
                            {
                                dgv_danhsachspban["SoLuongBan", a].Value = sl + Convert.ToInt32(dgv_danhsachspban["SoLuongBan", a].Value.ToString());
                            }
                        }
                        int dgia;
                        Int32.TryParse(txt_dongia.Text, out dgia);
                        for (int b = 0; b < dgv_danhsachspban.Rows.Count; b++)
                        {
                            if (dgv_danhsachspban["MaSP", b].Value.ToString() == cbb_masp.Text)
                            {
                                dgv_danhsachspban["DonGia", b].Value = dgia + Convert.ToInt32(dgv_danhsachspban["DonGia", b].Value.ToString());
                            }
                        }
                    }
                }

            }

            //int slb = string.IsNullOrEmpty(txtsoluongban.Text) ? 0 : Convert.ToInt32(txtsoluongban.Text);
            int slb;
            Int32.TryParse(txt_dongia.Text, out slb);
            for (int c = 0; c < dgv_danhsachspban.Rows.Count; c++)
            {
                slb = Convert.ToInt32(dgv_danhsachspban["SoLuongBan", c].Value);
            }
                int slc = string.IsNullOrEmpty(txt_soluongcon.Text) ? 0 : Convert.ToInt32(txt_soluongcon.Text);
            string str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCn = new SqlConnection(str);
            try

            {
                sqlCn.Open();

                string sql = "Select SoLuong from SanPham where MaSP=@MaSP";
                SqlCommand sqlcm = new SqlCommand(sql, sqlCn);
                sqlcm.Parameters.AddWithValue("@MaSP", cbb_masp.SelectedValue.ToString());
                SqlDataReader read = sqlcm.ExecuteReader();
                if (read.Read())
                {
                    slc = Convert.ToInt32(read["SoLuong"].ToString());
                    int slcnew = slc - slb;
                    txt_soluongcon.Text = slcnew.ToString();
                }
            }
            catch
            {

            }
            int t = dgv_danhsachspban.Rows.Count;
            int tongtien = 0;
            for (int i = 0; i < t; i++)
            {
                tongtien += int.Parse(dgv_danhsachspban.Rows[i].Cells["DonGia"].Value.ToString());
                txt_tongtien.Text = tongtien.ToString();
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            if (this.dgv_danhsachspban.SelectedRows.Count > 0)
            {

                dgv_danhsachspban.Rows.RemoveAt(this.dgv_danhsachspban.SelectedRows[0].Index);
            }

        }

        private void txt_soluongcon_TextChanged(object sender, EventArgs e)
        {
            if (txt_soluongcon.Text == "0")
            {
                btn_themsp.Enabled = false;
                btn_themsp.BackColor = Color.LightGray;
            }
            else
            {
                btn_themsp.Enabled = true;
                btn_themsp.BackColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_KhachHang khachhang = new Frm_KhachHang();
            khachhang.Show();
            dgv_danhsachspban.Refresh();
        }

        private void btn_kiemtra_Click(object sender, EventArgs e)
        {
            if (txt_sdt.Text == null)
                return;
            string str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCn = new SqlConnection(str);
            string sdt = txt_sdt.Text.Trim();
            try
            {
                sqlCn.Open();

                string s = @"Select [TenKH] from [KhachHang] where SDT=@SDT";
                //txt_tenkh.Text = s;

                SqlCommand sqlcm = new SqlCommand(s, sqlCn);
                sqlcm.Parameters.AddWithValue("@SDT", sdt);
                SqlDataReader read = sqlcm.ExecuteReader();
                if (read.Read())
                {
                    txt_tenkh.Text = read["TenKH"].ToString();
                    lbl_trangthaikh.Text = "";
                }
                if (KiemTraTonTai() == false)
                {
                    txt_tenkh.Text = "";
                    lbl_trangthaikh.Text = "Khách hàng này chưa có dữ liệu";
                }
                if(txt_tenkh.Text.ToString()=="")
                {
                    button1.Enabled = true;
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
        private bool KiemTraTonTai()
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(strCon, "KhachHang_SelectBySDT", txt_sdt.Text.Trim());
                if (reader.Read())
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
            return false;
        }

        private void btn_laphoadon_Click(object sender, EventArgs e)
        {
            Frm_KhachHang fm = new Frm_KhachHang();


            MessageBox.Show("Thanh toán hóa đơn thành công", "Thông báo", MessageBoxButtons.OK);
            fm.ShowDialog();
            MaTuDongTang();
            for(int i=0;i<dgv_danhsachspban.Rows.Count;i++)
            {
                string SoHD = dgv_danhsachspban.Rows[i].Cells["SoHD"].Value.ToString();
                string TenKH = txt_tenkh.Text.ToString();
                string SDT = txt_sdt.Text.ToString();
                string MaSP = dgv_danhsachspban.Rows[i].Cells["MaSP"].Value.ToString();
                string TenSP = dgv_danhsachspban.Rows[i].Cells["TenSP"].Value.ToString();
                string LoaiSP = dgv_danhsachspban.Rows[i].Cells["LoaiSP"].Value.ToString();
                int SoLuong = Convert.ToInt32(dgv_danhsachspban.Rows[i].Cells["SoLuongBan"].Value.ToString());
                int DonGia = Convert.ToInt32(dgv_danhsachspban.Rows[i].Cells["DonGia"].Value.ToString());
                string NgayLap = dgv_danhsachspban.Rows[i].Cells["NgayLap"].Value.ToString();
                try
                {
                    SqlHelper.ExecuteNonQuery(strCon, "BanHang_Insert", SoHD, TenKH, SDT, MaSP, TenSP, LoaiSP, SoLuong, DonGia, NgayLap);
                    SqlHelper.ExecuteNonQuery(strCon, "ProductAfterSell_Update", MaSP, SoLuong);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
                }
            }
            
        }

        private void txt_tenkh_TextChanged(object sender, EventArgs e)
        {
            if (txt_tenkh.Text.Trim() != "")
                btn_laphoadon.Enabled = true;
            else
                btn_laphoadon.Enabled = false;
        }

        private void txtsoluongban_TextChanged(object sender, EventArgs e)
        {
            int slb = string.IsNullOrEmpty(txtsoluongban.Text) ? 0 : Convert.ToInt32(txtsoluongban.Text);
            int gia = string.IsNullOrEmpty(textBox1.Text) ? 0 : Convert.ToInt32(textBox1.Text);
            int dg = slb * gia;
            txt_dongia.Text = dg.ToString();
            int slc = string.IsNullOrEmpty(txt_soluongcon.Text) ? 0 : Convert.ToInt32(txt_soluongcon.Text);

            if (slb > slc)
            {
                MessageBox.Show("Sản phẩm này không đủ để bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoluongban.Clear();
                txtsoluongban.Focus();
                return;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (txtsoluongban.Text != "")
            {
                int slb = Convert.ToInt32(txtsoluongban.Text);
                int gia = Convert.ToInt32(textBox1.Text);
                int dg = slb * gia;
                txt_dongia.Text = dg.ToString();
            }
        }
        DataTable dt;
        private void MaTuDongTang()
        {
            SqlConnection sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            string sql = "tb_BanHang";
            SqlCommand comd = new SqlCommand(sql, sqlCon);
            comd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(comd);
            dt = new DataTable();
            da.Fill(dt);
            sqlCon.Close();
            string g = "";
            if (dt.Rows.Count <= 0)
            {
                g = "HD01";
            }
            else
            {
                int k;
                g = "HD";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 2));
                k = k + 1;
                if (k < 10)
                    g = g + "0";
                g = g + k.ToString();
            }
            txtSoHD.Text = g;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                PrintDialog printDlg = new PrintDialog();
                PrintDocument printDoc = new PrintDocument();
                printDoc.DocumentName = "Print Document";
                printDlg.Document = printDoc;
                printDlg.AllowSelection = true;
                printDlg.AllowSomePages = true;
                if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
            }
        }
    }
}
