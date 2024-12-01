
using QuanLyShopQuanAoTreEm.Models;
using QuanLyShopQuanAoTreEm.PAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyShopQuanAoTreEm.View
{
    public partial class frmUpdateCategory : Form
    {

        
        public frmUpdateCategory()
        {
            InitializeComponent();
            
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Tạo chuỗi kết nối tới cơ sở dữ liệu RestaurantManagement  
            string connectionString = "Data Source=HOANGPHUC;Initial Catalog=KidShopManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            // Tạo đối tượng kết nối  
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Thiết lập lệnh truy vấn cho đối tượng Command  
            string query = "SELECT ID, Name, Type FROM Category";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = query;

            // Mở kết nối cơ sở dữ liệu  
            sqlConnection.Open();

            // Thực thi lệnh bằng phương thức ExecuteReader  
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            // Gọi hàm hiện thị dữ liệu lên màn hình  
            this.DisplayCategory(sqlDataReader);

            // Đóng kết nối  
            sqlConnection.Close();
        }
        private void DisplayCategory(SqlDataReader reader)
        {
            // Xóa tất cả các dòng hiện tại  
            lsvCategory.Items.Clear();

            // Đọc một dòng dữ liệu  
            while (reader.Read())
            {
                // Tạo một dòng mới trong ListView  
                ListViewItem item = new ListViewItem(reader["ID"].ToString());

                // Thêm dòng mới vào ListView  
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());
            }
        }
        private void lvCategory_Click(object sender, EventArgs e)
        {
            // Lấy dòng được chọn trong Listview  
            ListViewItem item = lsvCategory.SelectedItems[0];

            // Hiển thị dữ liệu lên Textbox  
            txtID.Text = item.Text;
            txtCategoryName.Text = item.SubItems[1].Text;
            txtType.Text = item.SubItems[1].Text == "1" ? "Áo" : "Quần";

            // Hiển thị nút cập nhật và xóa  
            btnDelete.Enabled = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng kết nối  
            string connectionString = "Data Source=HOANGPHUC;Initial Catalog=KidShopManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Tạo đối tượng thực thi lệnh  
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            // Thiết lập lệnh truy vấn và cho đối tượng Command  
            sqlCommand.CommandText = "INSERT INTO Category(Name, [Type])" +
                                     "VALUES('" + txtCategoryName.Text + "', '" + txtType.Text + "')";

            // Mở kết nối tới cơ sở dữ liệu  
            sqlConnection.Open();

            // Thực thi lệnh bằng phương thức ExecuteNonQuery  
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            // Đóng kết nối  
            sqlConnection.Close();

            if (numOfRowsEffected == 1)
            {
                MessageBox.Show("Thêm nhóm quần áo thành công");
                // Tải lại dữ liệu  
                btnLoad.PerformClick();
                // Xóa các ô nhập  
                txtCategoryName.Text = "";
                txtType.Text = "";
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }
        }

        

        private void frmUpdateCategory_Load(object sender, EventArgs e)
        {
            
        }
    }
}
