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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<Client>()
                .HasOptional<User>(c => c.user)
                .WithMany()
                .Map(m => m.MapKey("userId"));
            */
        }

    }
}
