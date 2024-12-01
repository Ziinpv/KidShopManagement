
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
using System.Management;
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
            var categoryMap = new Dictionary<int, string>()
            {
                {1, "Áo Thun"},
                {2, "Áo Khoác"},
                {3, "Áo Polo"},
                {4, "Quần Dài"},
                {5, "Quần Đùi"},
                {6, "Quần Short"}
            };
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["ProductID"].ToString());
                item.SubItems.Add(row["ProductName"].ToString());
                item.SubItems.Add(row["Size"].ToString());
                item.SubItems.Add(row["Quantity"].ToString());
                item.SubItems.Add(row["Price"].ToString());
                // Lấy ID loại sản phẩm
                int categoryId = Convert.ToInt32(row["ProductCategoryID"]);
                // Lấy tên loại sản phẩm từ ánh xạ
                string categoryName = categoryMap.ContainsKey(categoryId) ? categoryMap[categoryId] : "Loại không xác định";
                item.SubItems.Add(categoryName);

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
            var updateCategoryForm = new frmUpdateCategory();
            updateCategoryForm.ShowDialog();
        }
        

    

        private void btnReloadProducts_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    // Nếu không có món ăn nào được chọn, không cần làm gì cả  
        //    if (lvwProducts.SelectedItems.Count == 0) return;

        //    // Ngược lại, lấy mã số của món ăn được chọn  
        //    var dbContext = new ShopContext();
        //    var selectedFoodId = int.Parse(lvwProducts.SelectedItems[0].Text);
        //    // Truy vấn để lấy thông tin của món ăn đó  
        //    var selectedFood = dbContext.Products.Find(selectedFoodId);

        //    // Nếu tìm thấy thông tin món ăn  
        //    if (selectedFood != null)
        //    {
        //        // Thì xóa khỏi cơ sở dữ liệu  
        //        dbContext.Products.Remove(selectedFood);
        //        dbContext.SaveChanges();

        //        // Và đồng thời xóa khỏi ListView  
        //        lvwProducts.Items.Remove(lvwProducts.SelectedItems[0]);
        //    }
        //}

        private void ucProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategory();
        }

        private void lvwProducts_DoubleClick(object sender, EventArgs e)
        {
            //if (lvwProducts.SelectedItems.Count > 0)
            //{
            //    ListViewItem selectedItem = lvwProducts.SelectedItems[0];
            //    DataRowView rowView = selectedItem.Tag as DataRowView; // Giả sử bạn đã lưu DataRowView trong Tag  

            //    frmUpdateProduct Form= new frmUpdateProduct();

            //    Form.ProductInfo(selectedItem);
            //}
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

        private void tvwCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Lấy nút đang được chọn
            var selectedNode = e.Node;

            // Nếu nút không có dữ liệu (chỉ là nút gốc), thoát
            if (selectedNode.Tag == null) return;

            // Lấy ProductCategoryID từ Tag của nút
            int selectedCategoryId = Convert.ToInt32(selectedNode.Tag);

            // Hiển thị sản phẩm thuộc loại đã chọn
            LoadProductsByCategory(selectedCategoryId);
        }

        private void LoadProductsByCategory(int categoryId)
        {
            lvwProducts.Items.Clear();
            string constr = "Data Source=HOANGPHUC;Initial Catalog=KidShopManagement;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(constr);
            SqlCommand cmd = conn.CreateCommand();

            // Lọc sản phẩm dựa trên ProductCategoryID
            cmd.CommandText = "SELECT ProductID, ProductName, Size, Quantity, Price, Image FROM Product WHERE ProductCategoryID = @CategoryID";
            cmd.Parameters.AddWithValue("@CategoryID", categoryId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();
            var categoryMap = new Dictionary<int, string>()
            {
                {1, "Áo Thun"},
                {2, "Áo Khoác"},
                {3, "Áo Polo"},
                {4, "Quần Dài"},
                {5, "Quần Đùi"},
                {6, "Quần Short"}
            };

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["ProductID"].ToString());
                item.SubItems.Add(row["ProductName"].ToString());
                item.SubItems.Add(row["Size"].ToString());
                item.SubItems.Add(row["Quantity"].ToString());
                item.SubItems.Add(row["Price"].ToString());


                // Hiển thị hình ảnh nếu có
                if (row["Image"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])row["Image"];
                    if (imageData.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            Image image = Image.FromStream(ms);
                            item.Tag = image; // Gắn hình ảnh vào Tag
                        }
                    }
                }
                else
                {
                    item.SubItems.Add("Không có hình ảnh");
                }

                lvwProducts.Items.Add(item);
            }
        }

        private void tvwCategory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null || e.Node.Level < 2 || e.Node.Tag == null) return;

            var category = e.Node.Tag as Category;
            var dialog = new frmUpdateCategory();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                LoadProducts();
            }
        }

        private void tsmAdd_Click(object sender, EventArgs e)
        {
            frmUpdateProduct frmUpdateProduct = new frmUpdateProduct();
            frmUpdateProduct.Show(this);
        }

        private void tsmUpdate_Click(object sender, EventArgs e)
        {
            if (lvwProducts.SelectedItems.Count > 0)
            {
                // Lấy mục được chọn
                ListViewItem selectedItem = lvwProducts.SelectedItems[0];

                // Tạo form thông tin thực phẩm mới
                frmUpdateProduct frmUpdateProduct = new frmUpdateProduct();

                // Hiển thị form và truyền thông tin sản phẩm đã chọn
                frmUpdateProduct.Show(this);

                // Gửi thông tin từ ListViewItem sang form thông tin thực phẩm
                frmUpdateProduct.ProductInfo(selectedItem);
            
            }
            else
            {
                MessageBox.Show("Please select a food item to update.");
            }
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            int numOfRowsAffected = 1;
            frmUpdateProduct frmUpdateProduct = new frmUpdateProduct();
            frmUpdateProduct.Show(this);
            if (numOfRowsAffected == 1)
            {
                // Cập nhật lại dữ liệu trên Listview  
                ListViewItem item = lvwProducts.SelectedItems[0];
                lvwProducts.Items.Remove(item);


                MessageBox.Show("Xóa nhóm món ăn thành công");
            }
        }

        


        // Add Category


    }
}
