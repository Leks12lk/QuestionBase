using Microsoft.EntityFrameworkCore;
using QuestionBase.Persistence.Infrastructure;

namespace QuestionBase.Persistence
{
    public class QuestionBaseDbContextFactory : DesignTimeDbContextFactoryBase<QuestionBaseDbContext>
    {
        protected override QuestionBaseDbContext CreateNewInstance(DbContextOptions<QuestionBaseDbContext> options)
        {
            return new QuestionBaseDbContext(options);
        }
    }
}
