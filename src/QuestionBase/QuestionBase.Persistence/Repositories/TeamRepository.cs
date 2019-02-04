using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuestionBase.Application.Interfaces.DAL;
using QuestionBase.Domain.Entities;

namespace QuestionBase.Persistence.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly QuestionBaseDbContext _context;

        public TeamRepository(QuestionBaseDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Team>> GetAll()
        {
            return await _context.Teams.ToListAsync();
        }

        public async Task<Team> Get(int id)
        {
            //return await _context.Teams.Where(team => team.Id == id).SingleOrDefaultAsync();
            return await _context.Teams.FindAsync(id);
        }

        public async Task<Team> Add(Team team)
        {
            await _context.Teams.AddAsync(team);
            return team;
        }

        public async Task<Team> Update(Team team)
        {
            var entity = await _context.Teams.FindAsync(team.Id);

            //_context.Entry(team).State = EntityState.Modified;
            entity.Name = team.Name;
            return team;
        }

        public void Delete(int id)
        {
            Team team = _context.Teams.Find(id);
            if (team != null)
            {
                _context.Teams.Remove(team);
            }
        }
    }
}
