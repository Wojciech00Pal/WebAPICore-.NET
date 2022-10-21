using Microsoft.AspNetCore.Mvc;

namespace PlatformDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //controller=tickets
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("all tickets");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Reading ticket #{id}. ");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok($"creating ticket");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("Updating ticket  ");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleting ticket #{id} ");
        }



    }
}
