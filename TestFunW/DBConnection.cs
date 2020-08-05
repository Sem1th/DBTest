using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFunW
{

    class DBConnection : DbContext
    {
        public DBConnection()
            : base("DbConnection")
        { }

        public DbSet<Staff> Staff { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Subdivision> Subdivision { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Subdivision1)
               .WithOptional(e => e.Staff1)
                .HasForeignKey(e => e.StaffId);

           modelBuilder.Entity<Subdivision>()
               .Property(e => e.NameSubdivision)
               .IsFixedLength();

            modelBuilder.Entity<Subdivision>()
               .HasMany(e => e.Staff)
               .WithOptional(e => e.Subdivision)
               .HasForeignKey(e => e.SubdivisionId);
        }

    }

    


}
