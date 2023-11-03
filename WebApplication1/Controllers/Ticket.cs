using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Ticket : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World!");
        }

        public IActionResult Get(int id)
        {
            return Ok($"Hello World! {id}");
        }

    }
}
