
using QuanLyShopQuanAoTreEm.Models;
using QuanLyShopQuanAoTreEm.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Windows.Forms;

namespace QuanLyShopQuanAoTreEm.PAL
{
    public partial class ucProducts : UserControl
    {
        
        public ucProducts()
        {
            InitializeComponent();    
        }

        public void LoadProducts()
        {
            lvwProducts.Items.Clear();
            string constr = "Data Source=HOANGPHUC;Initial Catalog=KidShopManagement;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(constr);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select ProductID,ProductName,Size,Quantity,Price,ProductCategoryID,Image from Product a, Category b where a.ProductCategoryID = b.ID";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["ProductID"].ToString());
                item.SubItems.Add(row["ProductName"].ToString());
                item.SubItems.Add(row["Size"].ToString());
                item.SubItems.Add(row["Quantity"].ToString());
                item.SubItems.Add(row["Price"].ToString());
                item.SubItems.Add(row["ProductCategoryID"].ToString());
                
                if (row["Image"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])row["Image"];
                    if (imageData != null && imageData.Length > 0)
                    {
                        // Chuyển đổi byte[] thành Image
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            Image image = Image.FromStream(ms);
                            // Gắn hình ảnh vào Tag của ListViewItem
                            item.Tag = image;
                        }
                    }
                }
                else
                {
                    // Nếu không có hình ảnh, thêm thông tin mặc định
                    item.SubItems.Add("Không có hình ảnh");
                }

                lvwProducts.Items.Add(item);
            }
        }

        public void LoadCategory()
        {
            // Xóa tất cả các nút hiện tại trong TreeView
            tvwCategory.Nodes.Clear();

            // Tạo nút gốc "Tất cả"
            TreeNode rootNode = tvwCategory.Nodes.Add("Tất cả");

            // Kết nối cơ sở dữ liệu
            string connectionString = "Data Source=HOANGPHUC;Initial Catalog=KidShopManagement;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Truy vấn lấy danh sách loại sản phẩm
                string query = "SELECT ID, Name, Type FROM Category";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Tạo các nút nhóm (Áo, Quần)
                    TreeNode shirtNode = rootNode.Nodes.Add("Áo");
                    shirtNode.Tag = 1; // Type = 1

                    TreeNode pantsNode = rootNode.Nodes.Add("Quần");
                    pantsNode.Tag = 2; // Type = 2

                    // Duyệt qua từng dòng kết quả từ CSDL
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0); // ID
                        string name = reader.GetString(1); // Name
                        int type = reader.GetInt32(2); // Type

                        // Thêm vào nhóm tương ứng
                        TreeNode childNode = new TreeNode(name)
                        {
                            Name = id.ToString(), // ID làm khóa duy nhất
                            Tag = id // Lưu ID vào Tag
                        };

                        if (type == 1) // Áo
                        {
                            shirtNode.Nodes.Add(childNode);
                        }
                        else if (type == 2) // Quần
                        {
                            pantsNode.Nodes.Add(childNode);
                        }
                    }
                }
            }

            // Mở rộng tất cả các nút
            tvwCategory.ExpandAll();

            // Chọn nút gốc
            tvwCategory.SelectedNode = rootNode;
        }

        

        private void btnReloadCategory_Click(object sender, EventArgs e)
        {
            LoadCategory();
        }
        private void picTimKiemSP_MouseHover(object sender, EventArgs e)
        {
         
        }

    // Add Category
    private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var dialog = new frmUpdateCategory();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                LoadProducts();
            }
        }

    

        private void btnReloadProducts_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Nếu không có món ăn nào được chọn, không cần làm gì cả  
            if (lvwProducts.SelectedItems.Count == 0) return;

            // Ngược lại, lấy mã số của món ăn được chọn  
            var dbContext = new ShopContext();
            var selectedFoodId = int.Parse(lvwProducts.SelectedItems[0].Text);
            // Truy vấn để lấy thông tin của món ăn đó  
            var selectedFood = dbContext.Products.Find(selectedFoodId);

            // Nếu tìm thấy thông tin món ăn  
            if (selectedFood != null)
            {
                // Thì xóa khỏi cơ sở dữ liệu  
                dbContext.Products.Remove(selectedFood);
                dbContext.SaveChanges();

                // Và đồng thời xóa khỏi ListView  
                lvwProducts.Items.Remove(lvwProducts.SelectedItems[0]);
            }
        }

        private void ucProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategory();
        }

        private void lvwProducts_DoubleClick(object sender, EventArgs e)
        {
            if (lvwProducts.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = lvwProducts.SelectedItems[0];
                frmUpdateProduct frm = new frmUpdateProduct();
                frm.ProductInfo(selectedRow);
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadProducts();
            }
        }

        private void btnShowAddProduct_Click(object sender, EventArgs e)
        {
            frmUpdateProduct frm = new frmUpdateProduct();
            if (frm.ShowDialog() == DialogResult.OK)
                LoadProducts();
        }
        // Add Category


    }
}
