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
    public partial class frmForgotPassWord : Form
    {
        public frmForgotPassWord()
        {
            InitializeComponent();
        }

       

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRSPass_Click(object sender, EventArgs e)
        {
            //if (txtUserName.Text.Trim() == string.Empty)
            //{
            //    MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //else if (txtSoCCCD.Text.Trim() == string.Empty)
            //{
            //    MessageBox.Show("Vui lòng nhập số Căn Cước Công Dân.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //else
            //{
            //    string pass = Computer.Computer.ForgotPassword(txtUserName.Text.Trim(), txtSoCCCD.Text.Trim());
            //    if (pass != string.Empty)
            //    {
            //        MessageBox.Show($"Mật khẩu mới của bạn là: {pass}.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;

            //    }
            //    else
            //    {
            //        MessageBox.Show("Tên đăng nhập hoặc số Căn Cước Công Dân không chính xác.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
        }
    }
}
