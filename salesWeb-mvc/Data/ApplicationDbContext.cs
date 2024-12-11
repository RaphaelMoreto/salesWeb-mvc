using Microsoft.EntityFrameworkCore;

namespace salesWeb_mvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<salesWeb_mvc.Models.Department> Department { get; set; }

    }
}
