using Microsoft.AspNetCore.Mvc;

namespace NETCoreIdentityMFA.Api.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration configuration;

        public AuthController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpGet,ActionName("login")]
        public async Task<ActionResult> Login()
        {
            return Ok();
        }
    }
}
