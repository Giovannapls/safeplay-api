using ApiSafePlay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace ApiSafePlay.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TournamentsController : ControllerBase
    {
        private readonly ILogger<TournamentsController> _logger;

        public TournamentsController(ILogger<TournamentsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Tournament> Get()
        {
            // Replace with your data fetching logic
            return new List<Tournament>();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Replace with your data fetching logic
            var tournament = new Tournament { Id = id, Description = "Sample Tournament" };
            if (tournament == null)
            {
                return NotFound();
            }
            return Ok(tournament);
        }

        [HttpPost]
        public IActionResult Create(Tournament tournament)
        {
            // Replace with your data saving logic
            tournament.Id = new Random().Next(1, 1000); // Example ID generation
            return CreatedAtAction(nameof(GetById), new { id = tournament.Id }, tournament);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Tournament tournament)
        {
            if (id != tournament.Id)
            {
                return BadRequest();
            }
            // Replace with your data updating logic
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Replace with your data deletion logic
            return NoContent();
        }
    }
}
