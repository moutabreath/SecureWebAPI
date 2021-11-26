using Microsoft.AspNetCore.Mvc;

namespace SmartEye.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyController : ControllerBase
    {

        private readonly ILogger<MyController> _logger;

        public MyController(ILogger<MyController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public JsonResult Act([FromBody] JsonContent myParam)
        {
            return new JsonResult(myParam);
        }
    }
}