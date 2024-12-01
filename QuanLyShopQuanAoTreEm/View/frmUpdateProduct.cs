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

        private void ResetText()
        {
            txtID.ResetText();
            txtName.ResetText();
            txtQuantity.ResetText();
            cbbSize.ResetText();
            cbbCategory.ResetText();
            txtPrice.ResetText();
            txtImagePath.ResetText();
            
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
            try
            {
                string connectionString = "Data Source=HOANGPHUC;Initial Catalog=KidShopManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE InsertProduct @id OUTPUT, @Name, @Size, @Quantity, @ProductCategoryID, @Price";

                // Thêm tham số vào đối tượng Command  
                cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@size", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@quantity", SqlDbType.Int); // Sửa kiểu từ NVarChar thành Int nếu Quantity là số
                cmd.Parameters.Add("@productCategoryID", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);

                // Truyền giá trị vào các tham số  
                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@size"].Value = cbbSize.SelectedValue.ToString(); // Kiểm tra giá trị của cbbSize
                cmd.Parameters["@quantity"].Value = int.Parse(txtQuantity.Text); // Chuyển đổi số lượng thành kiểu Int
                cmd.Parameters["@productCategoryID"].Value = cbbCategory.SelectedValue;
                cmd.Parameters["@price"].Value = decimal.Parse(txtPrice.Text); // Nếu cần, chuyển đổi giá thành decimal

                // Kết nối  
                conn.Open();
                int numRowAffected = cmd.ExecuteNonQuery();

                // Thông báo kết quả  
                if (numRowAffected > 0)
                {
                    string foodID = cmd.Parameters["@id"].Value.ToString();
                    MessageBox.Show("Successfully adding new food. Food ID: " + foodID, "message");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Adding food failed");
                }

                // đóng kết nối  
                conn.Close();
                conn.Dispose();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL Error");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=HOANGPHUC;Initial Catalog=KidShopManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE UpdateProduct @id OUTPUT, @Name, @Size, @Quantity, @ProductCategoryID, @Price, @Image";

                // Thêm tham số vào đối tượng Command  
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@size", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@quantity", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@productCategoryID", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters.Add("@image", SqlDbType.NVarChar, 3000);

                cmd.Parameters["@id"].Direction = ParameterDirection.Output;

                // Truyền giá trị vào các tham số  
                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@size"].Value = cbbSize.SelectedValue;
                cmd.Parameters["@quantity"].Value = txtQuantity.Text;
                cmd.Parameters["@productCategoryID"].Value = cbbCategory.SelectedValue;
                cmd.Parameters["@price"].Value = txtPrice.Text;
                cmd.Parameters["@image"].Value = txtImagePath.Text;

                // Kết nối  
                conn.Open();
                int numRowAffected = cmd.ExecuteNonQuery();
                // Thông báo kết quả  
                if (numRowAffected > 0)
                {
                    MessageBox.Show("Successfully_updating_food", "Message");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Updating food failed");
                }

                // đóng kết nối  
                conn.Close();
                conn.Dispose();
            }
            // Bắt lỗi SQL và các lỗi khác  
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL_Error");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        public void DeleteProduct()
        {
            string connectionString = "server=; database=RestaurantManagement; Integrated Security=true; ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            // Thiết lập lệnh truy vấn cho đối tượng Command  
            sqlCommand.CommandText = "DELETE FROM Category " +
                "WHERE ID = " + txtID.Text;

            sqlConnection.Open();

            // Thực thi lệnh bằng phương thức ExecuteReader  
            int numOfRowsAffected = sqlCommand.ExecuteNonQuery();

            // Đóng kết nối  
            sqlConnection.Close();
            
        }
    }
}
