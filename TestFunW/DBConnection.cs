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

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Subdivision> Subdivisions { get; set; }
    }


}
