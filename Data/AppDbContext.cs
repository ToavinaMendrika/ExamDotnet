using Microsoft.EntityFrameworkCore;
using ExamDotnet.Models;

namespace ExamDotnet.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products {get; set;}
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
    }
}