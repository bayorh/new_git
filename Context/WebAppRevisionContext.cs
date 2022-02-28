
using Microsoft.EntityFrameworkCore;
using WebProjectRevision.Entities;

namespace WebProjectRevision.Context
{
    public class WebAppRevisionContext : DbContext
    {
        public WebAppRevisionContext(DbContextOptions<WebAppRevisionContext> option) : base(option)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }




        public DbSet<Worker> Workers { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}