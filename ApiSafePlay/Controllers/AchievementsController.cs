using ApiSafePlay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace ApiSafePlay.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AchievementsController : ControllerBase
    {
        private readonly ILogger<AchievementsController> _logger;

        public AchievementsController(ILogger<AchievementsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Achivement> Get()
        {
            // Replace with your data fetching logic
            return new List<Achivement>(); 
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Replace with your data fetching logic
            var achievement = new Achivement { Id = id, Description = "Sample Achievement" };
            if (achievement == null)
            {
                return NotFound();
            }
            return Ok(achievement);
        }

        [HttpPost]
        public IActionResult Create(Achivement achievement)
        {
            // Replace with your data saving logic
            achievement.Id = new Random().Next(1, 1000); // Example ID generation
            return CreatedAtAction(nameof(GetById), new { id = achievement.Id }, achievement);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Achivement achievement)
        {
            if (id != achievement.Id)
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
