using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{

    public class NorthwindContext : DbContext
    {
        // OnConfiguring ->projenin hangi veritabanıyla ilişkili olduğunu belirteceğimiz metot
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDb;Database=Northwind;Trusted_Connection = true");
        }
        // hangi veri tabanı tablosunun bizim hangi nesnemizle ilişkilendirileceğini belirmek için
        // DbSet<Type> Class ı kullanılır
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }


    }
}
