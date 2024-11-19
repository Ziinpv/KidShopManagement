using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAoTreEm.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CategoryType Type { get; set; }

    }
    public enum CategoryType
    {
        Tshirt,
        Jacket,
        Poloshirt,
        Trouser,
        Shorts,
        Pants
    }
}
