using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopQuanAoTreEm.PAL
{
    public partial class FormMain : Form
    {
        public string name = "{?}";
        public FormMain()
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
            lblUserName.Text=name;
            timerDateAndTime.Stop();
        }


        //Thoát Form
        private void btnCLose_Click(object sender, EventArgs e)
        {

            Close();
        }


        //Hiển thị Thời Gian
        private void lblDateTime_Click(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd-MM-yy  hh:mm:ss tt");
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            MovePanel(btn_HoaDon);
        }

        private void btn_QuanLy_Click(object sender, EventArgs e)
        {
            MovePanel(btn_QuanLy);
        }

        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            MovePanel(btn_BaoCao);
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
            MovePanel(btn_SanPham);
        }
    }
}
