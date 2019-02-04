using MediatR;
using System.Threading;
using System.Threading.Tasks;
using QuestionBase.Application.Interfaces.DAL;
using QuestionBase.Domain.Entities;

namespace QuestionBase.Application.CQRS.Teams.Commands.UpdateTeam
{
    public class UpdateTeamCommandHandler : IRequestHandler<UpdateTeamCommand, Team>
    {
        private readonly IQuestionBaseUnitOfWork _unitOfWork;

        public UpdateTeamCommandHandler(IQuestionBaseUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Team> Handle(UpdateTeamCommand request, CancellationToken cancellationToken)
        {
            var entity = new Team
            {
                Id = request.TeamId,
                Name = request.TeamName
            };

            var team = await _unitOfWork.TeamRepository.Update(entity);
            _unitOfWork.Commit();

            return team;
        }
    }
}
