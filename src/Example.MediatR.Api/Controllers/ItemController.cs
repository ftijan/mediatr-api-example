using Example.MediatR.Api.Cqrs;
using Example.MediatR.Api.Utils;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Example.MediatR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ILogger<ItemController> _logger;
        private readonly IMediator _mediator;

        public ItemController(ILogger<ItemController> logger, IMediator mediator)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"GET api/item/{id}");

            var item = await _mediator.Send(new GetItemRequest { Id = id }, cancellationToken);

            return item.CreatePayloadResult();
        }
    }
}
