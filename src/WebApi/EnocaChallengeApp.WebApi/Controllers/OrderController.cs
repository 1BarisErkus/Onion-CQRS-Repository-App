using EnocaChallengeApp.Application.Features.Commands.Creates.CreateOrder;
using EnocaChallengeApp.Application.Features.Commands.Delete.DeleteOrder;
using EnocaChallengeApp.Application.Features.Commands.Updates.UpdateOrder;
using EnocaChallengeApp.Application.Features.Queries.GetAll.GetAllOrder;
using EnocaChallengeApp.Application.Features.Queries.GetById.GetOrderById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnocaChallengeApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator mediator;

        public OrderController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllOrderQuery();

            return Ok(await mediator.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetOrderByIdQuery() { Id = id };

            return Ok(await mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateOrderCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateOrderCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteOrderCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}
