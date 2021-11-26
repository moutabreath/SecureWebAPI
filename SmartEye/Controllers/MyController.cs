using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<JsonResult> Act([FromBody] JsonContent myParam)
        {
            return
                 new JsonResult(myParam);
        }
     

        /**
         * 
         * 
         public async Task<JsonResult> Act(HttpContext http, [FromBody] JsonContent myParam)
            var user = http.User;
            var dbContext = http.RequestServices.GetService<TodoDbContext>();
            var todoItems = await dbContext.TodoItems.Where(todoItem => todoItem.User
                == user.Identity.Name).ToListAsync();
        await http.Response.WriteAsJsonAsync("authoriezed");
         */
    }
}