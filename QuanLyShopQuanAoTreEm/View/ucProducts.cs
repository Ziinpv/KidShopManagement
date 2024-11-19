using Computer;
using QuanLyShopQuanAoTreEm.Models;
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

        public void UpdateProducts(List<Product> products)
        {
            dgvSanPham.DataSource = products; // Gán danh sách sản phẩm cho DataGridView  
        }

        private void picTimKiemSP_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picAnhSP, "Tìm Kiếm");
        }

        private void tpQuanLySP_Click(object sender, EventArgs e)
        {

        }

        private void btnThemHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picAnhSP.Image = new Bitmap(open.FileName);
                txtHinh.Text = open.FileName;
            }
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            txtTenSP.Text = "";
            txtMauSP.Text = "";
            txtGiaSP.Text = "";
            txtSoLuong.Text = "";
            cmbLoaiSp.SelectedIndex = 0;
            cmbSize.SelectedIndex = 0;
            picAnhSP.Image=null;
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các trường nhập liệu
            string tenSP = txtTenSP.Text;
            string mauSp = txtMauSP.Text;
            string giaSP = txtGiaSP.Text;
            string soLuongSP = txtSoLuong.Text;
            string loaiSP = cmbLoaiSp.SelectedItem?.ToString();
            string sizeSP = cmbSize.SelectedItem?.ToString();
            Image anhSP = picAnhSP.Image;

            // Kiểm tra nếu các trường không được để trống
            if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(mauSp) || string.IsNullOrEmpty(giaSP) || string.IsNullOrEmpty(soLuongSP))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm.");
                return;
            }

            // Chuỗi kết nối với SQL Server
            string connectionString = @"Data Source=HOANGPHUC;Initial Catalog=KidShopManagement;Integrated Security=True;TrustServerCertificate=True"; // Thay bằng chuỗi kết nối của bạn

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Kiểm tra sản phẩm có tồn tại không (theo tên sản phẩm hoặc mã sản phẩm)
                string queryCheck = "SELECT COUNT(*) FROM SanPham WHERE TenSP = @TenSP";

                using (SqlCommand cmdCheck = new SqlCommand(queryCheck, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@TenSP", tenSP);

                    int count = (int)cmdCheck.ExecuteScalar();

                    // Nếu sản phẩm đã tồn tại, thì cập nhật
                    if (count > 0)
                    {
                        string queryUpdate = @"UPDATE SanPham 
                                        SET MauSP = @MauSP, GiaSP = @GiaSP, SoLuongSP = @SoLuongSP, LoaiSP = @LoaiSP, SizeSP = @SizeSP
                                        WHERE TenSP = @TenSP";

                        using (SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn))
                        {
                            cmdUpdate.Parameters.AddWithValue("@TenSP", tenSP);
                            cmdUpdate.Parameters.AddWithValue("@MauSP", mauSp);
                            cmdUpdate.Parameters.AddWithValue("@GiaSP", giaSP);
                            cmdUpdate.Parameters.AddWithValue("@SoLuongSP", soLuongSP);
                            cmdUpdate.Parameters.AddWithValue("@LoaiSP", loaiSP);
                            cmdUpdate.Parameters.AddWithValue("@SizeSP", sizeSP);

                            cmdUpdate.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật sản phẩm thành công!");
                        }
                    }
                    else
                    {
                        // Nếu sản phẩm chưa tồn tại, thì thêm mới
                        string queryInsert = @"INSERT INTO SanPham (TenSP, MauSP, GiaSP, SoLuongSP, LoaiSP, SizeSP)
                                        VALUES (@TenSP, @MauSP, @GiaSP, @SoLuongSP, @LoaiSP, @SizeSP)";

                        using (SqlCommand cmdInsert = new SqlCommand(queryInsert, conn))
                        {
                            cmdInsert.Parameters.AddWithValue("@TenSP", tenSP);
                            cmdInsert.Parameters.AddWithValue("@MauSP", mauSp);
                            cmdInsert.Parameters.AddWithValue("@GiaSP", giaSP);
                            cmdInsert.Parameters.AddWithValue("@SoLuongSP", soLuongSP);
                            cmdInsert.Parameters.AddWithValue("@LoaiSP", loaiSP);
                            cmdInsert.Parameters.AddWithValue("@SizeSP", sizeSP);

                            cmdInsert.ExecuteNonQuery();
                            MessageBox.Show("Thêm sản phẩm mới thành công!");
                        }
                    }
                }
                conn.Close();
            }

            // Sau khi thêm hoặc cập nhật trong CSDL, cần cập nhật lại DataGridView
            UpdateDataGridView();
        }

        //Cập nhật thông tin sản Phẩm từ btnThemSP vào dgvSanPham
        private void UpdateDataGridView()
        {
            string connectionString = @"Data Source=HOANGPHUC;Initial Catalog=KidShopManagement;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"; // Thay bằng chuỗi kết nối của bạn

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM SanPham";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Cập nhật DataGridView
                    dgvSanPham.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                }
            }
            
        }


        private void cmnuChinhSua_Opening(object sender, CancelEventArgs e)
        {
            dgvSanPham.ContextMenuStrip = cmnuChinhSua; // 'contextMenuStrip1' là ContextMenuStrip của bạn

        }

        private void txtHinh_TextChanged(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(txtHinh.Text))
            {
                picAnhSP.ImageLocation = txtHinh.Text;
            }
        }

        private void ShowProducts()
        {
            using (var dbContext = new ShopContext())
            {
                try
                {
                    var products = dbContext.Products.ToList();
                    dgvSanPham.DataSource = products;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy danh sách sản phẩm: " + ex.Message);
                }
            }
        }
        private List<QuanLyShopQuanAoTreEm.Models.Category> GetCategories()
        {
            var dbContext = new ShopContext();
            return dbContext.Categories.OrderBy(x => x.Name).ToList();
        }

        private void btnGetCategory_Click(object sender, EventArgs e)
        {
            ShowProducts();
        }
    }
}
