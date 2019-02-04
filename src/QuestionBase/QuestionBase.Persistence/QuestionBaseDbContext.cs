using Microsoft.EntityFrameworkCore;
using QuestionBase.Domain.Entities;

namespace QuestionBase.Persistence
{
    public sealed class QuestionBaseDbContext : DbContext
    {
        public QuestionBaseDbContext(DbContextOptions<QuestionBaseDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }


        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(QuestionBaseDbContext).Assembly);
        }
    }
}
