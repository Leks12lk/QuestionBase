using MediatR;
using QuestionBase.Domain.Entities;

namespace QuestionBase.Application.CQRS.Teams.Commands.CreateTeam
{
    public class CreateTeamCommand : IRequest<Team>
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
    }
}
