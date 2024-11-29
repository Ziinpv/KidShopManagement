using QuanLyShopQuanAoTreEm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopQuanAoTreEm.View
{
    public partial class frmUpdateCategory : Form
    {
        public frmUpdateCategory()
        {
            InitializeComponent();
        }

        private ShopContext _dbContext;
        private int _categoryId;

        public frmUpdateCategory(int? categoryId = null)
        {
            InitializeComponent();
            _dbContext = new ShopContext();
            _categoryId = categoryId ?? 0;
        }

        private Category GetCategoryById(int categoryId)
        {
            // Nếu ID được truyền vào là hợp lệ, ta tìm thông tin theo ID  
            // Ngược lại, chỉ cần trả về null, cho biết không thấy.  
            return categoryId > 0 ? _dbContext.Categories.Find(categoryId) : null;
        }

        private void ShowCategory()
        {
            // Lấy thông tin của món thức ăn  
            var category = GetCategoryById(_categoryId);

            // Nếu không tìm thấy thông tin, không cần làm gì cả  
            if (category == null)
            {
                return;
            }

            // Ngược lại, nếu tìm thấy, hiện thị lên form  
            txtCategoryID.Text = category.Id.ToString();
            txtCategoryName.Text = category.Name;
            cbbCategoryType.SelectedIndex = (int)category.Type;
        }
        private void UpdateCategoryForm_Load(object sender, EventArgs e)
        {
            ShowCategory();
        }

        private Category GetUpdatedCategory()
        {
            // Tạo đối tượng Category với thông tin đã nhập  
            var category = new Category()
            {
                Name = txtCategoryName.Text.Trim(),
                Type = (CategoryType)cbbCategoryType.SelectedIndex
            };

            // Gán giá trị của ID ban đầu (nếu đang cập nhật)  
            if (_categoryId > 0)
            {
                category.Id = _categoryId;
            }

            return category;
        }

        private bool ValidateUserInput()
        {
          
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Tên nhóm quần áo không được để trống", "Thông báo");
                return false;
            }

            // Kiểm tra loại thức ăn đã được chọn hay chưa  
            if (cbbCategoryType.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn loại nhóm quần áo", "Thông báo");
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu dữ liệu nhập vào là hợp lệ  
            if (ValidateUserInput())
            {
                // Thì lấy thông tin người dùng nhập vào  
                var newCategory = GetUpdatedCategory();

                // và thử tìm xem đã có thông thức trong CSDL chưa  
                var oldCategory = GetCategoryById(_categoryId);

                // Nếu chưa có (chưa tồn tại)  
                if (oldCategory == null)
                {
                    // Thì thêm nhóm thức ăn mới  
                    _dbContext.Categories.Add(newCategory);
                }
                else
                {
                    // Ngược lại, ta chỉ cần cập nhật thông tin còn thiếu  
                    oldCategory.Name = newCategory.Name;
                    oldCategory.Type = newCategory.Type;
                }

                // Lưu các thay đổi xuống CSDL  
                _dbContext.SaveChanges();

                // Đóng hộp thoại  
                DialogResult = DialogResult.OK;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
