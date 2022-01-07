using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Comtrollers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {

        }

        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("--> Test Inbound Connection");

            return Ok("Inbound test from PlatformsController");
        }
    }
}