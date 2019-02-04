using System.Threading;
using System.Threading.Tasks;
using MediatR;
using QuestionBase.Application.Interfaces.DAL;
using QuestionBase.Domain.Entities;

namespace QuestionBase.Application.CQRS.Teams.Queries.GetTeamDetail
{
    public class GetTeamDetailQueryHandler : IRequestHandler<GetTeamDetailQuery, Team>
    {
        private readonly IQuestionBaseUnitOfWork _unitOfWork;

        public GetTeamDetailQueryHandler(IQuestionBaseUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Team> Handle(GetTeamDetailQuery request, CancellationToken cancellationToken)
        {
            var team = await _unitOfWork.TeamRepository.Get(request.TeamId);
            return team;
        }
    }
}
