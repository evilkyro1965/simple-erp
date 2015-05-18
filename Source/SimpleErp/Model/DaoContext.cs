using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace simpleerp.model
{
    public class DaoContext: DbContext
    {
        public DaoContext() : base(nameOrConnectionString: "simpleerp") { }

        public DbSet<InventoryCategory> InventoryCategories { get; set; }
        public DbSet<InventoryUOM> InventoryUOM { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<VendorContact> VendorContacts { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<InventoryItem>()
                .HasOptional<InventoryCategory>(item => item.Category)
                .WithMany()
                .Map(m => m.MapKey("categoryId"));

            modelBuilder.Entity<InventoryItem>()
                .HasOptional<InventoryUOM>(item => item.UOM)
                .WithMany()
                .Map(m => m.MapKey("uomId"));

            modelBuilder.Entity<Vendor>()
                .HasMany<VendorContact>(v => v.Contacts)
                .WithRequired(c => c.Vendor).Map(m => m.MapKey("VendorId"));

        }

    }
}
