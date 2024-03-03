using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureDevOps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadConfigurationController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public ReadConfigurationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet("GetEnv")]
        public IActionResult GetEnv()
        {
            return Ok(_configuration.GetSection("Env").Value);
        }
    }
}
