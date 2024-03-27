using Core.Models;
using Core.ValidationAttributes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
//using PlatformDemo.Filters;
//using PlatformDemo.Models;

namespace PlatformDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Version1DiscontinueResourceFilter]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Reading all tickets");
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Reading a ticket with Id : {id}");
        }


        [HttpPost]
        [Route("/api/tickets")]
        public IActionResult CreateV1([FromBody] Ticket ticket)
        {
            return Ok(ticket);
        }
        
        [HttpPost]
        [Route("/api/v2/tickets")]
        //[Ticket_ValidateDatesActionFilter]
        //[Ticket_EnsureDueDateAfterReportdate]
        public IActionResult CreateV2([FromBody] Ticket ticket)
        {
            return Ok(ticket);
        }


        [HttpPut]
        public IActionResult Update()
        {
            return Ok("Updating a ticket");
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            return Ok("Deleting a ticket");
        }
    }
}
