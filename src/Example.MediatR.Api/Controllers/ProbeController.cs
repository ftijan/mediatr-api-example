using Microsoft.AspNetCore.Mvc;

namespace Example.MediatR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProbeController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
