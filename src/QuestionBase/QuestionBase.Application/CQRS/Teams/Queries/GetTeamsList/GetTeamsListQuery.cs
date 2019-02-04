using System.Collections.Generic;
using MediatR;
using QuestionBase.Domain.Entities;

namespace QuestionBase.Application.CQRS.Teams.Queries.GetTeamsList
{
    public class GetTeamsListQuery : IRequest<IEnumerable<Team>>
    {
    }
}
