using EnocaChallengeApp.Application.Features.Commands.Creates.CreateFirm;
using EnocaChallengeApp.Application.Features.Commands.Delete.DeleteFirm;
using EnocaChallengeApp.Application.Features.Commands.Updates.UpdateFirm;
using EnocaChallengeApp.Application.Features.Queries.GetAll.GetAllFirm;
using EnocaChallengeApp.Application.Features.Queries.GetById.GetFirmById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EnocaChallengeApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmController : ControllerBase
    {
        private readonly IMediator mediator;

        public FirmController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllFirmQuery();

            return Ok(await mediator.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetFirmByIdQuery() { Id = id };

            return Ok(await mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateFirmCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateFirmCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteFirmCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}
