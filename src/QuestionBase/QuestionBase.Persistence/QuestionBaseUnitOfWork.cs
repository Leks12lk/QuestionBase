using QuestionBase.Application.Interfaces.DAL;
using System;

namespace QuestionBase.Persistence
{
    public class QuestionBaseUnitOfWork : IQuestionBaseUnitOfWork
    {
        private readonly QuestionBaseDbContext _context;
        public QuestionBaseUnitOfWork(QuestionBaseDbContext context
                                    , ITeamRepository teamRepository)
        {
            _context = context;

            TeamRepository = teamRepository;
        }

        public ITeamRepository TeamRepository { get; set; }

        public void Commit()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context?.Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
