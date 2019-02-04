using System.Threading;
using System.Threading.Tasks;
using MediatR;
using QuestionBase.Application.Interfaces.DAL;
using QuestionBase.Domain.Entities;

namespace QuestionBase.Application.CQRS.Teams.Commands.CreateTeam
{
    public class CreateTeamCommandHandler : IRequestHandler<CreateTeamCommand, Team>
    {
        private readonly IQuestionBaseUnitOfWork _unitOfWork;

        public CreateTeamCommandHandler(IQuestionBaseUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Team> Handle(CreateTeamCommand request, CancellationToken cancellationToken)
        {
            var entity = new Team
            {
                Name = request.TeamName
            };

            var team = await _unitOfWork.TeamRepository.Add(entity);
            _unitOfWork.Commit();

            return team;
        }
    }
}
