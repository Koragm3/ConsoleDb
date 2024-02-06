using ConsoleDb.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDb.Context
{
    internal class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<AddressEntity> Addresses { get; set; }
        public DbSet<CategoryEntity> categories { get; set; }
        public DbSet<CustomerEntity> customers { get; set; }
        public DbSet<ProductEntity> products { get; set; }
        public DbSet<RoleEntity> roles { get; set; }
    }
}
