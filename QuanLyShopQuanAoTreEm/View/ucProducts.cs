
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
            // Khởi tạo đối tượng context
            var dbContext = new ShopContext();
            // Lấy danh sách tất cả nhóm quần áo , sắp xếp theo tên
            return dbContext.Categories.OrderBy(x => x.Name).ToList();
        }

        private void ShowProducts()
        {
            // Xóa tất cả các nút hiện có trên cây tvwCategory.Nodes.Clear();
            // Tạo danh sách loại nhóm quần, áo
            // Tên của các loại này được hiển thị trên các nút mức 2
            var cateMap = new Dictionary<CategoryType, string>()
            {
                [CategoryType.Tshirt] = "Áo Thun",
                [CategoryType.Jacket] = "Áo Khoác",
                [CategoryType.Poloshirt] = "Áo Polo",
                [CategoryType.Trouser] = "Quần dài",
                [CategoryType.Pants] = "Quần đùi",
                [CategoryType.Shorts] = "Quần Shorts"
            };

            // Tạo nút gốc của cây
            var rootNode = tvwCategory.Nodes.Add("Tất cȧ");
            // Lấy danh sách nhóm quần áo 
            var categories = GetCategories();
            // Duyệt qua các loại nhóm áo
            foreach (var cateType in cateMap)
            {
                // Tạo các nút tương ứng với loại nhóm áo
                var childNode = rootNode.Nodes.Add(cateType.Key.ToString(), cateType.Value);
                childNode.Tag = cateType.Key;

                foreach (var category in categories)
                {
                    if (category.Type != cateType.Key) continue;
                    var grantChildNode = childNode.Nodes.Add(category.Id.ToString(), category.Name);
                    grantChildNode.Tag = category;
                }
            }

            tvwCategory.ExpandAll();

            tvwCategory.SelectedNode = rootNode;
        }

        private List<ProductModel> GetProductByCategory(int? categoryId)
        {
            // Khởi tạo đối tượng context
            var dbContext = new ShopContext();
            // Tạo truy vấn lấy danh sách quần óa
            var foods = dbContext.Products.AsQueryable();
            // Nếu mã nhóm quần áo khác null và hợp lệ
            if (categoryId != null && categoryId > 0)
            {
                foods = foods.Where(x => x.ProductCategoryID == categoryId);
            }
            // Thì tìm theo mã số nhóm quần áo
            // Sắp xếp đồ ăn, thức uống theo tên và trả về // danh sách chứa đầy đủ thông tin về món ăn.
            return foods
            .OrderBy(x => x.Name)
            .Select(x => new ProductModel()
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
        private List<ProductModel> GetProductByCategoryType(CategoryType cateType)
        {
            var dbContext = new ShopContext();
            // Tìm các món ăn theo loại nhóm thức ăn (Category Type). // Sắp xếp đồ ăn, thức uống theo tên và trả về
            // danh sách chứa đầy đủ thông tin về món ăn.
            return dbContext.Products
            .Where(x => x.Category.Type == cateType)
            .OrderBy(x => x.Name)
            .Select(x => new ProductModel()
            {
                Id = x.Id,
                Name = x.Name,
                Quantity = x.Quantity,
                Size= x.Size,
                Price = x.Price,
                CategoryName = x.Category.Name,
                Notes = x.Notes
            })
            .ToList();
        }

        private void ShowProductForNode(TreeNode node)
        {
            // Xóa danh sách thực đơn hiện tại khỏi listview
            lvwProducts.Items.Clear();
            // Nếu node = null, không cần xử lý gì thêm
            if (node == null) return;
            // Tạo danh sách để chứa danh sách các món ăn tìm được
            List<ProductModel> products = null;
            // Nếu nút được chọn trên TreeView tương ứng với // loại nhóm thức ăn (Category Type) (mức thứ 2 trên cây)
            if (node.Level == 1)
            {
                var categoryType = (CategoryType)node.Tag;
                products= GetProductByCategoryType(categoryType);
            }
            else
            {
                // Thì lấy danh sách món ăn theo loại nhóm

                // Ngược lại, lấy danh sách món ăn theo thể loại 1/ Nếu nút được chọn là 'Tất cả' thì lấy hết
                var category = node.Tag as Category;
                products = GetProductByCategory(category?.Id);
                // Gọi hàm để hiển thị các món ăn lên ListView 
            }
            ShowProductOnListView(products);
        }

        private void ShowProductOnListView(List<ProductModel> products)
        {
            // Duyệt qua từng phần tử của danh sách foodt
            foreach (var productItem in products)
            {
                // Tạo item tương ứng trên ListView
                var item = lvwProducts.Items.Add(productItem.Id.ToString());
                // và hiển thị các thông tin của món ăn
                item.SubItems.Add(productItem.Name); 
                item.SubItems.Add(productItem.Quantity);
                item.SubItems.Add(productItem.Size);
                item.SubItems.Add(productItem.Price.ToString("##,###"));
                item.SubItems.Add(productItem.CategoryName);
                item.SubItems.Add(productItem.Notes);
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
        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            txtPrices.Text = "";
            txtQuantity.Text = "";
            cmbProductCategory.SelectedIndex = 0;
            cmbSize.SelectedIndex = 0;
            picProducts.Image=null;
        }
        // BtnDefalut

        // Cập nhật sản phẩm lên lsvProducts sau khi thêm 


        //Cập nhật thông tin sản Phẩm từ btnThemSP vào dgvSanPham

        // Cập nhật sản phẩm lên lsvProducts sau khi thêm 






        // Add Products Picture
        private void txtHinh_TextChanged(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(txtHinh.Text))
            {
                picProducts.ImageLocation = txtHinh.Text;
            }
        }
        private void btnAddProductPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picProducts.Image = new Bitmap(open.FileName);
                txtHinh.Text = open.FileName;
            }
        }
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
