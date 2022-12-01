using DoggieNote.Models;
using Microsoft.EntityFrameworkCore;

namespace DoggieNote.Data
{
    public class DoggieDbContext : DbContext
    {
        public DoggieDbContext()
        {

        }
        public DoggieDbContext(DbContextOptions<DoggieDbContext> options) : base(options)
        {

        }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}
