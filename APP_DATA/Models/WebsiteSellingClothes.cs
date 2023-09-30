using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace APP_DATA.Models
{
    public class WebsiteSellingClothes : DbContext
    {
        public WebsiteSellingClothes()
        {
                
        }
        public WebsiteSellingClothes(DbContextOptions<WebsiteSellingClothes> options):base(options) { }
        public DbSet<Account> accounts { get; set; }
        public DbSet<Bill> bills { get; set; }
        public DbSet<BillDetail> billDetails { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<CartDetails> cartDetails { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<RoleAccount> roleAccounts { get; set; }
        public DbSet<Voucher> vouchers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=AC918\SQLEXPRESS;Initial Catalog=WebsiteSellingClothes;Integrated Security=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()));
        }
    }
}
