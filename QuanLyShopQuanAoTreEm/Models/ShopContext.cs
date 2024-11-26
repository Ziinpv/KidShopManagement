using QuanLyShopQuanAoTreEm.PAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAoTreEm.Models
{
    public class ShopContext :DbContext
    {
        public DbSet<Category> Categories { get; set; }


        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>()
               .HasRequired(x => x.Category)
               .WithMany()
               .HasForeignKey(x => x.ProductCategoryID)
               .WillCascadeOnDelete(true);
        }
    }
}
