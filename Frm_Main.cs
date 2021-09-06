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
    public partial class Frm_Main : Form
    {
        public delegate void DoEvent();
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void quảnLýLoạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_LoaiSP"))
            {
                Frm_LoaiSP frm_loaisp = new Frm_LoaiSP();
                frm_loaisp.MdiParent = this;
                frm_loaisp.Show();
            }
            else
            {
                ActiveChildForm("Frm_LoaiSP");
            }
            
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckExistForm("Frm_SanPham"))
            {
                Frm_SanPham frm_SP = new Frm_SanPham();
                frm_SP.MdiParent = this;
                frm_SP.Show();
            }
            else
            {
                ActiveChildForm("Frm_SanPham");
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_KhachHang"))
            {
                Frm_KhachHang fm_KH = new Frm_KhachHang();
                fm_KH.MdiParent = this;
                fm_KH.Show();
            }
            else
            {
                ActiveChildForm("Frm_KhachHang");
            }
        }
        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_BanHang"))
            {
                Frm_BanHang fm_BH = new Frm_BanHang();
                fm_BH.MdiParent = this;
                fm_BH.Show();
            }
            else
            {
                ActiveChildForm("Frm_BanHang");
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Fm_UserManage"))
            {
                Fm_UserManage fm_User = new Fm_UserManage();
                fm_User.MdiParent = this;
                fm_User.Show();
            }
            else
            {
                ActiveChildForm("Fm_UserManage");
            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            lbluser.Text = UserPermision;
            if(lbluser.Text=="admin")
            {
                quảnLýNhânViênToolStripMenuItem.Visible = true;
            }
            else
            {
                quảnLýNhânViênToolStripMenuItem.Visible = false;
            }
            WindowState = FormWindowState.Maximized;
        }
        public string UserPermision { set; get; }
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name==name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name==name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void nhậpHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmNhapHang"))
            {
                Frm_NhapHang fm_nhaphang = new Frm_NhapHang();
                fm_nhaphang.MdiParent = this;
                fm_nhaphang.Show();
            }
            else
            {
                ActiveChildForm("FrmNhapHang");
            }
        }
    }
}
