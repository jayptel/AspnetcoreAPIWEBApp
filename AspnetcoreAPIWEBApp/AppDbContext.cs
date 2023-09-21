using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AspnetcoreAPIWEBApp
{
    

    public class AppDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
