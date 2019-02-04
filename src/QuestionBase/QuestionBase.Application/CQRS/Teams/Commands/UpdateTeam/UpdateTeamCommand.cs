using MediatR;
using QuestionBase.Domain.Entities;

namespace QuestionBase.Application.CQRS.Teams.Commands.UpdateTeam
{
    public class UpdateTeamCommand : IRequest<Team>
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
    }
}
