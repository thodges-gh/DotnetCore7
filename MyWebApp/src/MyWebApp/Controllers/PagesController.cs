using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Api
{
    [Route("controllers/[controller]")]
    [Produces("application/json")]
    public class PagesController : Controller
    {
        [HttpGet]
        [Produces(typeof(string[]))]
        public IActionResult Get()
        {
            return Ok(new[] {
                "Page1x",
                "Page2x",
                "Page3x",
                "Page4x",
                "Page5x",
                "Page6x",
                "Page7x",
                "Page8x",
                "Page9x"
            });
        }
    }
}
