using Microsoft.AspNetCore.Mvc;
using PlatformDemo.models;

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
        public IActionResult Post([FromBody]Ticket ticket)
        {
            return Ok(ticket);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Ticket ticket)
        {

            return Ok(ticket);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleting ticket #{id} ");
        }



    }
}
