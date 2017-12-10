using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF.Domain;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace QLCF.Repository
{
    public class CFMEntities : DbContext
    {
        private static CFMEntities instance;
        private CFMEntities()
        { }
        public static CFMEntities Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CFMEntities();
                }
                return instance;
            }
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<BillInfo> BillInfoes { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ReceiptInfo> ReceiptInfoes { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<TableFood> TableFoods { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
