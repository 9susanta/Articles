using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIVersioning.Controllers
{
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[Controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        [HttpGet("GetTeam")]
        [MapToApiVersion("1.0")]
        public IActionResult GetV1()
        {
            return Ok("V1 Get to be implemented");
        }
        [HttpGet("GetTeam")]
        [MapToApiVersion("2.0")]
        public IActionResult GetV2()
        {
            return Ok("V1 Get to be implemented");
        }
        [HttpPost]
        public IActionResult Post()
        {
            return Ok("V1 Post to be implemented");
        }

    }
}
