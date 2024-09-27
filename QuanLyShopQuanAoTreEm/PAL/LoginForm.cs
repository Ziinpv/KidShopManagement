using QuanLyShopQuanAoTreEm.PAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyShopQuanAoTreEm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public void EmptyBox()
        {
            txtUserName.Clear();
            txtPassWord.Clear();
        }
        private void picShow_Click(object sender, EventArgs e)
        {
            if (picShow.Visible == true)
            {
                txtPassWord.UseSystemPasswordChar = false;
                picShow.Visible = false;
                picHide.Visible = true;
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            if (picHide.Visible == true)
            {
                txtPassWord.UseSystemPasswordChar = true;
                picShow.Visible = true;
                picHide.Visible = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HOANGPHUC\\SQLEXPRESS;Initial Catalog=KidShop_Login;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string query = "SELECT COUNT(*) FROM dbo.Login_Form WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtUserName.Text);
            cmd.Parameters.AddWithValue("@password", txtPassWord.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("Đăng Nhập Thành Công", " Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMain formmain = new FormMain();
                formmain.name=txtUserName.Text;
                this.Hide();
                formmain.Show();
            }
            else
            {
                MessageBox.Show("lỗi Đăng Nhập");
            }

            // Thay đổi code liên kết với database SQL
            //if (txtUserName.Text.Trim() == string.Empty)
            //{
            //    MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //else if (txtPassWord.Text.Trim() == string.Empty)
            //{
            //    MessageBox.Show("Vui lòng nhập mật khẩu.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //else
            //{
            //    bool chek = Computer.Computer.IsValidNamePass(txtUserName.Text.Trim(), txtPassWord.Text.Trim());
            //    if (chek)
            //    {
            //        FormMain formMain = new FormMain();
            //        formMain.ShowDialog();
            //        EmptyBox();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
