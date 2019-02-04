using QuestionBase.Models;
using QuestionBase.Repositories.Interfaces;

namespace QuestionBase.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly ApplicationDbContext _db;
        public TeamRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public void AddTeam(Team team)
        {
            _db.Teams.Add(team);
            _db.SaveChanges();
        }
    }
}
