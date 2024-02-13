
using Library.Entites;
using Microsoft.EntityFrameworkCore;

namespace Library.EntityMaps
{
    public class EfDataContext:DbContext
    {
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Book> Books { get; set; }  
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=LibraryData;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
