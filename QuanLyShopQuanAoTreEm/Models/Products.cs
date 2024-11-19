using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAoTreEm.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
        public int ProductCategoryID { get; set; }
        public int Price { get; set; }
        public string Notes { get; set; }
        public Category Category { get; set; }
    }
}
