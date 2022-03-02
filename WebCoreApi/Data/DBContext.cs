using Microsoft.EntityFrameworkCore;
using xAI.Models;

namespace xAI.Data
{
    public class xAIContext : DbContext
    {

        public xAIContext() { }

        public xAIContext(DbContextOptions<xAIContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=xaidemo;Trusted_Connection=True;MultipleActiveResultSets=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}