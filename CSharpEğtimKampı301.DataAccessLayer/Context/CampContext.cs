using CSharpEğtimKampı301.EntityLayer.concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEğtimKampı301.DataAccessLayer.Context
{
    public class CampContext : DbContext
    {
        public DbSet<category> Categories { get; set; }
        public DbSet<Custumer> Custumers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Admin> Admins { get; set; }


    }
}
