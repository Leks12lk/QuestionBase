using MediatR;
using QuestionBase.Domain.Entities;

namespace QuestionBase.Application.CQRS.Teams.Queries.GetTeamDetail
{
    public class GetTeamDetailQuery : IRequest<Team>
    {

        public GetTeamDetailQuery(int id)
        {
            TeamId = id;
        }

        public int TeamId { get; set; }
    }
}
