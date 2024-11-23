
using QuanLyShopQuanAoTreEm.Models;
using QuanLyShopQuanAoTreEm.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
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

        //Show Products On ListView And TreeView
        private List<Category> GetCategories()
        {
            using (var dbContext = new ShopContext())
            {
                // Lấy danh sách tất cả nhóm quần áo, nếu không có thì trả về danh sách rỗng
                return dbContext.Categories?.OrderBy(x => x.Name).ToList() ?? new List<Category>();
            }
        }


        private void ShowProducts()
        {
            // Xóa tất cả các nút hiện có trên cây
            tvwCategory.Nodes.Clear();

            // Tạo danh sách loại nhóm quần, áo
            var cateMap = new Dictionary<CategoryType, string>()
            {
                [CategoryType.Shirts] = "Áo ",
                [CategoryType.Pants] = "Quần",
                //[CategoryType.Poloshirt] = "Áo Polo",
                //[CategoryType.Trouser] = "Quần Dài",
                //[CategoryType.Pants] = "Quần Đùi",
                //[CategoryType.Shorts] = "Quần Shorts"
            };

            // Tạo nút gốc của cây
            var rootNode = tvwCategory.Nodes.Add("Tất cả");

            // Lấy danh sách nhóm quần áo
            var categories = GetCategories();
            if (categories == null || categories.Count == 0)
            {
                rootNode.Text += " (Không có dữ liệu)";
                return;
            }

            // Duyệt qua các loại nhóm áo
            foreach (var cateType in cateMap)
            {
                // Tạo các nút tương ứng với loại nhóm áo
                var childNode = rootNode.Nodes.Add(cateType.Key.ToString(), cateType.Value);
                childNode.Tag = cateType.Key;

                foreach (var category in categories)
                {
                    // Chỉ thêm các nhóm quần áo tương ứng
                    if (category.Type != cateType.Key) continue;

                    var existingNode = childNode.Nodes
                        .Cast<TreeNode>()
                        .FirstOrDefault(n => n.Name == category.Id.ToString());

                    // Tránh thêm node trùng lặp
                    if (existingNode == null)
                    {
                        var grantChildNode = childNode.Nodes.Add(category.Id.ToString(), category.Name);
                        grantChildNode.Tag = category;
                    }
                }
            }

            // Mở rộng tất cả các nút của cây (nếu cần)
            tvwCategory.ExpandAll();

            // Chọn nút gốc
            tvwCategory.SelectedNode = rootNode;
        }


        private List<ProductModel> GetProductByCategory(int? categoryId)
        {
            using (var dbContext = new ShopContext())
            {
                var products = dbContext.Products?.AsQueryable();

                if (products == null)
                    return new List<ProductModel>();

                if (categoryId != null && categoryId > 0)
                {
                    products = products.Where(x => x.ProductCategoryID == categoryId);
                }

                return products.OrderBy(x => x.Name)
                               .Select(x => new ProductModel
                               {
                                   Id = x.Id,
                                   Name = x.Name,
                                   Quantity = x.Quantity,
                                   Size = x.Size,
                                   Price = x.Price,
                                   CategoryName = x.Category.Name,
                                   Notes = x.Notes
                               })
                               .ToList();
            }
        }

        private List<ProductModel> GetProductByCategoryType(CategoryType cateType)
        {
            using (var dbContext = new ShopContext())
            {
                var products = dbContext.Products?.Where(x => x.Category.Type == cateType);

                if (products == null)
                    return new List<ProductModel>();

                return products.OrderBy(x => x.Name)
                               .Select(x => new ProductModel
                               {
                                   Id = x.Id,
                                   Name = x.Name,
                                   Quantity = x.Quantity,
                                   Size = x.Size,
                                   Price = x.Price,
                                   CategoryName = x.Category.Name,
                                   Notes = x.Notes
                               })
                               .ToList();
            }
        }


        private void ShowProductForNode(TreeNode node)
        {
            lvwProducts.Items.Clear();

            if (node == null)
                return;

            List<ProductModel> products = null;

            // Nếu nút là loại nhóm quần áo (Level 1)
            if (node.Level == 1 && node.Tag is CategoryType categoryType)
            {
                products = GetProductByCategoryType(categoryType);
            }
            else if (node.Tag is Category category)
            {
                products = GetProductByCategory(category?.Id);
            }

            ShowProductOnListView(products);
        }


        private void ShowProductOnListView(List<ProductModel> products)
        {
            if (products == null || products.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào để hiển thị.");
                return;
            }

            foreach (var productItem in products)
            {
                var item = lvwProducts.Items.Add(productItem.Id.ToString());
                item.SubItems.Add(productItem.Name);
                item.SubItems.Add(productItem.Quantity.ToString()); // Đảm bảo Quantity là chuỗi
                item.SubItems.Add(productItem.Size ?? "N/A"); // Kiểm tra null
                item.SubItems.Add(productItem.Price.ToString("N0")); // Định dạng tiền tệ
                item.SubItems.Add(productItem.CategoryName ?? "Chưa xác định");
                item.SubItems.Add(productItem.Notes ?? "Không có ghi chú");
            }
        }

        private void btnReloadCategory_Click(object sender, EventArgs e)
        {
            ShowProducts();
        }

        private void tvwCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowProducts();
        }
        //Show Products On ListView And TreeView
      

        private void picTimKiemSP_MouseHover(object sender, EventArgs e)
        {
         
        }

     
        // BtnDefalut
        //private void btnMacDinh_Click(object sender, EventArgs e)
        //{
        //    txtProductName.Text = "";
        //    txtPrices.Text = "";
        //    txtQuantity.Text = "";
        //    cmbProductCategory.SelectedIndex = 0;
        //    cmbSize.SelectedIndex = 0;
        //    picProducts.Image=null;
        //}
        // BtnDefalut

        // Cập nhật sản phẩm lên lsvProducts sau khi thêm 


        //Cập nhật thông tin sản Phẩm từ btnThemSP vào dgvSanPham

        // Cập nhật sản phẩm lên lsvProducts sau khi thêm 






        // Add Products Picture
        //private void txtHinh_TextChanged(object sender, EventArgs e)
        //{
        //    if (System.IO.File.Exists(txtHinh.Text))
        //    {
        //        picProducts.ImageLocation = txtHinh.Text;
        //    }
        //}
        //private void btnAddProductPic_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog open = new OpenFileDialog();
        //    open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
        //    if (open.ShowDialog() == DialogResult.OK)
        //    {
        //        picProducts.Image = new Bitmap(open.FileName);
        //        txtHinh.Text = open.FileName;
        //    }
        //}
        // Add Products Picture





        // Add Category
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var dialog = new UpdateCategoryForm();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowProducts();
            }
        }

        private void tvwCategory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null || e.Node.Level < 2 || e.Node.Tag == null) return;

            var category = e.Node.Tag as Category;
            var dialog = new UpdateCategoryForm(category?.Id);
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                ShowProducts();
            }
        }

        private void btnReloadProducts_Click(object sender, EventArgs e)
        {
            ShowProductForNode(tvwCategory.SelectedNode);
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
        // Add Category

        
    }
}
