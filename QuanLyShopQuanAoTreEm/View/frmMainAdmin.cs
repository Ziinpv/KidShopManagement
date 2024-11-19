
using QuanLyShopQuanAoTreEm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyShopQuanAoTreEm.Models;

namespace QuanLyShopQuanAoTreEm.PAL
{
    public partial class frmMainAdmin : Form
    {
        public string name = "{?}";

       
        public frmMainAdmin()
        {
            InitializeComponent();
        }

        //Hiển thị chức năng đang sử dụng
        private void MovePanel(Control Btn)
        {
            pnlMovePanle.Top = Btn.Top;
            pnlMovePanle.Height= Btn.Height;
        }

        //Main Form
        private void FormMain_Load(object sender, EventArgs e)
        {
            ucReportCheckOut1.Visible = true;
            ucUsers1.Visible = false;
            ucProducts1.Visible = false;
            lblUserName.Text=name;
            timerDateAndTime.Stop();
        }


        //Thoát Form
        private void btnCLose_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }


        //Hiển thị Thời Gian
        private void lblDateTime_Click(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd-MM-yy  hh:mm:ss tt");
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            ucReports1.Visible= false;
            ucReportCheckOut1.Visible = true;
            ucUsers1.Visible = false;
            ucProducts1.Visible = false;
            MovePanel(btn_HoaDon);
        }

        private void btn_QuanLy_Click(object sender, EventArgs e)
        {
            ucReports1.Visible = false;
            ucUsers1.Visible = true;
            ucReportCheckOut1.Visible = false;
            ucProducts1.Visible = false;
            MovePanel(btn_QuanLy);
        }

        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            ucReports1.Visible = true;
            ucUsers1.Visible = false;
            ucProducts1.Visible = false;
            ucReportCheckOut1.Visible = false;
            MovePanel(btn_BaoCao);
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            ucReports1.Visible = false;
            ucUsers1.Visible = false;
            ucReportCheckOut1.Visible = false;
            ucProducts1.Visible = true;
            MovePanel(btn_SanPham);
        }
    }
}
