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
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();

                // Kiểm tra xem sản phẩm đã tồn tại hay chưa
                cmd.CommandText = "SELECT COUNT(*) FROM Product WHERE ProductID = @productID";
                cmd.Parameters.AddWithValue("@productID", txtID.Text);

                int productExists = (int)cmd.ExecuteScalar();

                // Xử lý hình ảnh (đọc file thành byte[])
                byte[] imageBytes = null;
                if (!string.IsNullOrEmpty(txtImagePath.Text) && File.Exists(txtImagePath.Text))
                {
                    imageBytes = File.ReadAllBytes(txtImagePath.Text);
                }

                if (productExists == 0) // Sản phẩm chưa tồn tại -> Thêm mới
                {
                    cmd.CommandText = @"
                                        INSERT INTO [dbo].[Product] 
                                        ([ProductID], [ProductName], [Size], [Quantity], [ProductCategoryID], [Price], [Image]) 
                                        VALUES (@productID, @productName, @size, @quantity, @productCategory, @price, @image)";
                }
                else // Sản phẩm đã tồn tại -> Cập nhật
                {
                    cmd.CommandText = @"
                UPDATE [dbo].[Product]
                SET [ProductName] = @productName,
                [Size] = @size,
                [Quantity] = @quantity,
                [ProductCategoryID] = @productCategory,
                [Price] = @price,
                [Image] = @image
                WHERE [ProductID] = @productID";
                }

                // Kiểm tra giá trị của cbbSize.SelectedValue
                //var sizeValue = cbbSize.SelectedValue;
                //if (sizeValue == null)
                //{
                //    MessageBox.Show("Vui lòng chọn kích thước sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return; // Thoát nếu không có giá trị hợp lệ
                //}

                // Gán tham số cho câu lệnh SQL
                cmd.Parameters.AddWithValue("@productName", txtName.Text);
                cmd.Parameters.AddWithValue("@size", cbbSize.SelectedValue);
                cmd.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));
                cmd.Parameters.AddWithValue("@productCategory", cbbCategory.SelectedValue);
                cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@image", (object)imageBytes ?? DBNull.Value);

                // Thực thi câu lệnh
                int rowsAffected = cmd.ExecuteNonQuery();

                // Hiển thị thông báo
                if (rowsAffected > 0)
                {
                    MessageBox.Show(productExists == 0 ? "Thêm sản phẩm thành công" : "Cập nhật sản phẩm thành công");
                }
                else
                {
                    MessageBox.Show("Không có thay đổi nào được thực hiện");
                }
            }


        }
        public void ProductInfo(ListViewItem item)
        {
            // Gán thông tin từ ListViewItem vào các control
            txtID.Text = item.SubItems[0].Text; // ProductID
            txtName.Text = item.SubItems[1].Text; // ProductName
            txtQuantity.Text = item.SubItems[3].Text; // Quantity
            txtPrice.Text = item.SubItems[4].Text; // Price
            txtImagePath.Text = item.SubItems[6].Text; // ImagePath

            // Hiển thị dữ liệu cho cbbSize
            string selectedSize = item.SubItems[2].Text; // Size
            cbbSize.SelectedIndex = -1;
            for (int i = 0; i < cbbSize.Items.Count; i++)
            {
                if (cbbSize.Items[i].ToString() == selectedSize)
                {
                    cbbSize.SelectedIndex = i;
                    break;
                }
            }

            // Hiển thị dữ liệu cho cbbCategory
            string selectedCategory = item.SubItems[5].Text; // ProductCategory
            cbbCategory.SelectedIndex = -1;
            for (int i = 0; i < cbbCategory.Items.Count; i++)
            {
                DataRowView category = cbbCategory.Items[i] as DataRowView;
                if (category != null && string.Compare(category["Name"].ToString(), selectedCategory) == 0)
                {
                    cbbCategory.SelectedIndex = i;
                    break;
                }
            }

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
