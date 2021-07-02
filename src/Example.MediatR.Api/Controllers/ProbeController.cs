using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading;

namespace Example.MediatR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProbeController : ControllerBase
    {
        private readonly ILogger<ProbeController> _logger;

        public ProbeController(ILogger<ProbeController> logger)
        {
            _logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("GET api/probe");

            return Ok();
        }
    }
}
