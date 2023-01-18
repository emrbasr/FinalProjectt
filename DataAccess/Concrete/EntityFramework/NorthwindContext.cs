using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    // Context: Db Tabloları ile proje classlarını bağlamak
    public class NorthwindContext : DbContext
    {

        public NorthwindContext()
        {

        }

        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options)
        {

        }
        // Projemizi hangi veritabanı ile ilişkilendireceğimiz yer
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Sql server veritabanı bağlantısı
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }
        // Tabloların Bağlanması
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
