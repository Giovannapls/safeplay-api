using ApiSafePlay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace ApiSafePlay.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            // Replace with your data fetching logic
            return new List<User>();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Replace with your data fetching logic
            var user = new User { Id = id, Name = "Sample User" };
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            // Replace with your data saving logic
            user.Id = new Random().Next(1, 1000); // Example ID generation
            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, User user)
        {
            if (id != user.Id)
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
