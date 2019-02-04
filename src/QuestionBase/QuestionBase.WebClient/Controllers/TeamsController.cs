using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuestionBase.Application.CQRS.Teams.Commands.CreateTeam;
using QuestionBase.Application.CQRS.Teams.Commands.UpdateTeam;
using QuestionBase.Application.CQRS.Teams.Queries.GetTeamDetail;
using QuestionBase.Application.CQRS.Teams.Queries.GetTeamsList;
using QuestionBase.Domain.Entities;

namespace QuestionBase.WebClient.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TeamsController : BaseController
    {
        // GET: api/teams/all
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Team>>> All()
        {
            var teams = await Mediator.Send(new GetTeamsListQuery());

            return Ok(teams);
        }

        // GET: api/teams/getteam
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Team>>> Get(int id)
        {
            var team = await Mediator.Send(new GetTeamDetailQuery(id));

            return Ok(team);
        }


        // POST: api/teams/create
        [HttpPost]
        public async Task<ActionResult<Team>> Create([FromBody] CreateTeamCommand command)
        {
            var team = await Mediator.Send(command);

            return Ok(team);
        }

        // PUT: api/teams/update
        [HttpPut]
        public async Task<ActionResult<Team>> Update([FromBody] UpdateTeamCommand command)
        {
            var team = await Mediator.Send(command);

            return Ok(team);
        }
    }
}