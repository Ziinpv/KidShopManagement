using QuanLyShopQuanAoTreEm.PAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopQuanAoTreEm.View
{
    public partial class frmUpdateProduct : Form
    {

        int selectedIndex = 1;
        public frmUpdateProduct()
        {
            InitializeComponent();
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }
        public void LoadCategory()
        {
            string constr = "Data Source=HOANGPHUC;Initial Catalog=KidShopManagement;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(constr);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select ID, Name from Category";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();
            cbbCategory.DataSource = dt;
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "ID";
            cbbCategory.SelectedIndex = selectedIndex;
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtQuantity.Text = "";
            if (cbbSize.Items.Count > 0)
                cbbSize.SelectedIndex = 0;
            else
                cbbSize.SelectedIndex = -1; // Không chọn gì nếu danh sách trống

            if (cbbCategory.Items.Count > 0)
                cbbCategory.SelectedIndex = 0;
            else
                cbbCategory.SelectedIndex = -1; // Không chọn gì nếu danh sách trống
            txtPrice.Text= "";
            picInfo.Image = null;
            txtImagePath.Text = "";
        }

        private void txtImagePath_TextChanged(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(txtImagePath.Text))
            {
                picInfo.ImageLocation = txtImagePath.Text;
            }
        }

        private void btnImageSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picInfo.Image = new Bitmap(open.FileName);
                txtImagePath.Text = open.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=HOANGPHUC;Initial Catalog=KidShopManagement;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(constr);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select ProductID from Product where ProductID = '" + txtID.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                cmd.CommandText = "INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Quantity], [ProductCategoryID],[Price],[Image]) VALUES (@productid, @productname,@size, @quantity,@productcategory,@price,@image)";
                cmd.Parameters.Add("@productid", SqlDbType.Int);
                cmd.Parameters.Add("@productname", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@size", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@quantity", SqlDbType.Int);
                cmd.Parameters.Add("@productcategory", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters.Add("@image", SqlDbType.Image);

                cmd.Parameters["@productid"].Value = txtID.Text;
                cmd.Parameters["@productname"].Value = txtName.Text;
                cmd.Parameters["@size"].Value = cbbSize.SelectedValue;
                cmd.Parameters["@quantity"].Value = txtName.Text;
                cmd.Parameters["@productcategory"].Value = cbbCategory.SelectedValue;
                cmd.Parameters["@price"].Value = txtName.Text;
                cmd.Parameters["@image"].Value = txtImagePath.Text;
                int numRowChanged = cmd.ExecuteNonQuery();
                if (numRowChanged == 1) { MessageBox.Show("Thêm thành công sản phẩm mới"); }
                else
                {
                    MessageBox.Show("Thêm sản phẩm mới bị lỗi");
                }
            }
            else
            {
                cmd.CommandText = "execute UPDATE Product @productID, @productName,@Size, @Quantity,@productCategory,@Price,@Image";
                cmd.Parameters.Add("@productID", SqlDbType.Int);
                cmd.Parameters.Add("@productName", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@Size", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@Quantity", SqlDbType.Int);
                cmd.Parameters.Add("@productCategory", SqlDbType.Int);
                cmd.Parameters.Add("@Price", SqlDbType.Int);
                cmd.Parameters.Add("@Image", SqlDbType.Image);

                cmd.Parameters["@productID"].Value = txtID.Text;
                cmd.Parameters["@productName"].Value = txtName.Text;
                cmd.Parameters["@Size"].Value = cbbSize.SelectedValue;
                cmd.Parameters["@Quantity"].Value = txtName.Text;
                cmd.Parameters["@productCategory"].Value = cbbCategory.SelectedValue;
                cmd.Parameters["@Price"].Value = txtName.Text;
                cmd.Parameters["@Image"].Value = txtImagePath.Text;
                int numRowChanged = cmd.ExecuteNonQuery();
                if (numRowChanged == 1) { MessageBox.Show("Cập nhật thành công sản phẩm mới"); }
                else
                {
                    MessageBox.Show("Cập nhật sản phẩm mới bị lỗi");
                }
            }

            conn.Close();
            conn.Dispose();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public void ProductInfo(ListViewItem item)
        {
            LoadCategory();
            txtID.Text = item.SubItems[0].Text;
            txtName.Text = item.SubItems[1].Text;
            txtQuantity.Text = item.SubItems[2].Text;
            cbbSize.SelectedIndex = -1;
            for (int i = 0; i < cbbSize.Items.Count; i++)
            {
                DataRowView ct = cbbCategory.Items[i] as DataRowView;
                if (string.Compare(ct["Size"].ToString(), item.SubItems[2].Text) == 0)
                {
                    selectedIndex = i;
                    break;
                }
            }
            cbbCategory.SelectedIndex = -1;
            for (int i = 0; i < cbbCategory.Items.Count; i++)
            {
                DataRowView ct = cbbCategory.Items[i] as DataRowView;
                if (string.Compare(ct["Name"].ToString(), item.SubItems[2].Text) == 0)
                {
                    selectedIndex = i;
                    break;
                }
            }
            txtPrice.Text = item.SubItems[3].Text;
            txtImagePath.Text = item.SubItems[4].Text;
            txtImagePath.Text = item.SubItems[4].Text;

            // Hiển thị hình ảnh trong PictureBox
            string imagePath = txtImagePath.Text;
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                try
                {
                    picInfo.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải hình ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    picInfo.Image = null; // Xóa hình ảnh nếu lỗi
                }
            }
            else
            {
                picInfo.Image = null; // Xóa hình ảnh nếu đường dẫn không tồn tại
            }
        }

       
    }
}
