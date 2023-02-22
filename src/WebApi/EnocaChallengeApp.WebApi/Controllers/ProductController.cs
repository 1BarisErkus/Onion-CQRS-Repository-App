using EnocaChallengeApp.Application.Features.Commands.Creates.CreateFirm;
using EnocaChallengeApp.Application.Features.Commands.Creates.CreateProduct;
using EnocaChallengeApp.Application.Features.Commands.Delete.DeleteProduct;
using EnocaChallengeApp.Application.Features.Commands.Updates.UpdateProduct;
using EnocaChallengeApp.Application.Features.Queries.GetAll.GetAllProduct;
using EnocaChallengeApp.Application.Features.Queries.GetById.GetProductById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnocaChallengeApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllProductQuery();

            return Ok(await mediator.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetProductByIdQuery() { Id = id };

            return Ok(await mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateProductCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateProductCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteProductCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}
