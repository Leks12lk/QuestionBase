using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using QuestionBase.Application.Interfaces.DAL;
using QuestionBase.Domain.Entities;

namespace QuestionBase.Application.CQRS.Teams.Queries.GetTeamsList
{
    public class GetTeamsListQueryHandler : IRequestHandler<GetTeamsListQuery, IEnumerable<Team>>
    {
        private readonly IQuestionBaseUnitOfWork _unitOfWork;

        public GetTeamsListQueryHandler(IQuestionBaseUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Team>> Handle(GetTeamsListQuery request, CancellationToken cancellationToken)
        {
            var teams = await _unitOfWork.TeamRepository.GetAll();
            return teams;
        }
    }
}
