using Core.Models;
using Microsoft.AspNetCore.Mvc;
//using PlatformDemo.Models;

namespace PlatformDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Reading all projects");
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Reading a project with Id : {id}");
        }



        /// <summary>
        /// api/projects/{pid}/tickets?tid={tid}
        /// </summary>
        /// <returns></returns>
        
        [HttpGet]
        [Route("/api/projects/{pid}/tickets")]
        public IActionResult GetProjectTicket([FromQuery] Ticket ticket)
        {
            if (ticket == null)
                return BadRequest("Parameters not provided");

            if (ticket.TicketId == 0)
                return Ok($"Reading all the tickets belonging to project #{ticket.ProjectId}");
            else
                return Ok($"Reading project #{ticket.ProjectId}, ticket #{ticket.TicketId}");
        }


        [HttpPost]
        public IActionResult Create()
        {
            return Ok("Creating a project");
        }


        [HttpPut]
        public IActionResult Update()
        {
            return Ok("Updating a project");
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            return Ok($"Deleting a project with id: {id}");
        }
    }
}
