using Microsoft.EntityFrameworkCore;
using PostgreSqlDemo.Models;

namespace PostgreSqlDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) 
            : base(options)
        {
        }
          
           
        public DbSet<Book> Books { get; set; }
    }
}
