using Microsoft.AspNetCore.Mvc;
using PlatformDemo.models;

namespace PlatformDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController: ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("all project");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Reading project #{id}. ");
        }
        [HttpGet]
        //  overwrite the '/' controller
        [Route("/api/projects/{pid}/tickets")]
        public IActionResult GetProjectTicket(int pId, [FromQuery] int tId)
        {
            if (tId == 0)
            {
                return Ok("Reading all the tickets belong to" +
                    $"project #{pId}");
            }
            else
            {
                return Ok($"Reading project #{pId}, ticket number #{tId}");
            }
        }

        //ctr+k+c komentowanie calego kodu
        //ctr+k+u odkomentowanie kodu






        [HttpPost]
        public IActionResult Post()
        {
            return Ok($"creating project");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("Updating project  ");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleting project #{id} ");
        }



    }
}
