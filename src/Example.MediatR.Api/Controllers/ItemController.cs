using Example.MediatR.Api.Cqrs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Example.MediatR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ItemController(IMediator mediator)
        {
            this._mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id, CancellationToken cancellationToken)
        {
            var item = await _mediator.Send(new GetItemRequest { Id = id });

            if(item == null)
            {
                return NotFound();
            }

            return new JsonResult(item)
            {
                StatusCode = 200,
                ContentType = "application/json"
            };
        }
    }
}
