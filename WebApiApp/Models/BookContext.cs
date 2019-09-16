using System.Data.Entity;

namespace WebApiApp.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}